using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.IO;
using System.Drawing.Imaging;

namespace DziennikWyprawGorskich
{
    public partial class Form1 : Form
    {
        private string _sciezka;
        public Form1()
        {
            InitializeComponent();
            btnUsun.Enabled = false;
            pobierzSciezkeZConfiga();
            utworzFolder(_sciezka, "Dziennik wypraw górskich");
            _sciezka += @"Dziennik wypraw górskich\";
            pobierzFoldery(_sciezka);
        }
        private string pobierzSciezkeZConfiga()
        {
            _sciezka = ConfigurationManager.AppSettings["sciezka"];
            return _sciezka;
        }

        private void utworzFolder(string sciezka, string nazwaFolderu)
        {
            try
            {
                Directory.CreateDirectory(sciezka + nazwaFolderu);
            }
            finally
            { }
        }
        private void pobierzFoldery(string sciezka)
        {
            cmbListaWypraw.Items.Clear();
            try
            {
                DirectoryInfo di = new DirectoryInfo(sciezka);
                DirectoryInfo[] foldery = di.GetDirectories();
                if (foldery.Length > 0)
                {
                    foreach (DirectoryInfo folder in foldery)
                        cmbListaWypraw.Items.Add(folder.Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Brak Folderów");
            }
            
        }

        private void cmbListaWypraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUsun.Enabled = true;
            wczytajDane();
        }

        private void wczytajDane()
        {
            txtNazwa.Text = cmbListaWypraw.SelectedItem.ToString();
            txtTrasa.Text = wczytajZPliku(_sciezka + cmbListaWypraw.SelectedItem.ToString(), "trasa");
            txtOpis.Text = wczytajZPliku(_sciezka + cmbListaWypraw.SelectedItem.ToString(), "opis");
            try
            {
                pictureBox1.Image = Image.FromFile(_sciezka + cmbListaWypraw.SelectedItem.ToString() + "\\zdj");
            }
            catch
            {
                pictureBox1.Image = null;
            }

            try
            {
                dateTimePicker1.Text = wczytajZPliku(_sciezka + cmbListaWypraw.SelectedItem.ToString(), "data");

            }
            catch
            {
                dateTimePicker1.Text = DateTime.Now.ToLongDateString();
            }
            //MessageBox.Show(cmbListaWypraw.SelectedItem.ToString());
        }

        private string wczytajZPliku(string sciezka,string nazwa)
        {
            try
            {
                using (StreamReader sr = new StreamReader(sciezka+"\\"+nazwa+".txt"))
                {
                    string line = sr.ReadToEnd();
                    return line;
                }
            }
            catch
            {
                return "brak";
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if(txtNazwa.Text != "")
            {
                if (Directory.Exists(_sciezka + "\\" + txtNazwa.Text))                      //sprawdzenie czy folder istnieje
                {
                }
                else
                {
                    Directory.CreateDirectory(_sciezka + "\\" + txtNazwa.Text);
                }
                File.WriteAllText(_sciezka + "\\" + txtNazwa.Text + "\\trasa.txt", txtTrasa.Text);
                File.WriteAllLines(_sciezka + "\\" + txtNazwa.Text + "\\opis.txt", txtOpis.Lines);
                File.WriteAllText(_sciezka + "\\" + txtNazwa.Text + "\\data.txt", dateTimePicker1.Text);
                try
                {
                    pictureBox1.Image.Save(_sciezka + "\\" + txtNazwa.Text + "\\zdj"+lbRozszerzenie.Text, wczytajFormat(lbRozszerzenie.Text));

                }
                catch (Exception)
                { }
                odswierz();
            }
            
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (txtNazwa.Text != "")
            {
                DialogResult result = MessageBox.Show("Usunąć ?", "Błąd", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    pictureBox1.Image.Dispose(); 
                    if (Directory.Exists(_sciezka + "\\" + txtNazwa.Text))                      //sprawdzenie czy folder istnieje
                    {
                        try
                        {
                            Directory.Delete(_sciezka + "\\" + txtNazwa.Text, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                odswierz();
            }
            
        }

        private void btnDodajZdjecie_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = System.Drawing.Image.FromStream(fs);
                    wczytajKoniec(openFileDialog1.FileName);
                    
                }
            }
        }

        private void wczytajKoniec(string fileName)
        {
            if (fileName.EndsWith(".jpg"))
                lbRozszerzenie.Text = ".jpeg";
            else if (fileName.EndsWith(".png"))
                lbRozszerzenie.Text = ".png";
            else if (fileName.EndsWith(".bmp"))
                lbRozszerzenie.Text = ".bmp";
        }

        private ImageFormat wczytajFormat(string rozszerzenie)
        {
            if (rozszerzenie.EndsWith(".jpg"))
                return ImageFormat.Jpeg;
            else if (rozszerzenie.EndsWith(".png"))
                return ImageFormat.Png;
            else if (rozszerzenie.EndsWith(".bmp"))
                return ImageFormat.Bmp;
            return ImageFormat.Jpeg;
        }

        private void odswierz()
        {
            pobierzFoldery(_sciezka);
            cmbListaWypraw.Text = "";
            txtNazwa.Clear();
            txtOpis.Clear();
            txtTrasa.Clear();
            pictureBox1.Image = null;
            dateTimePicker1.Text = DateTime.Now.ToLongDateString();

            cmbListaWypraw.Enabled = true;
            btnUsun.Enabled = false;
        }
    }
}
