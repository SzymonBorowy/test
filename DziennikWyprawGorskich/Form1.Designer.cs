namespace DziennikWyprawGorskich
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbListaWypraw = new System.Windows.Forms.ComboBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrasa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDodajZdjecie = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRozszerzenie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbListaWypraw
            // 
            this.cmbListaWypraw.FormattingEnabled = true;
            this.cmbListaWypraw.Location = new System.Drawing.Point(14, 14);
            this.cmbListaWypraw.Name = "cmbListaWypraw";
            this.cmbListaWypraw.Size = new System.Drawing.Size(177, 21);
            this.cmbListaWypraw.TabIndex = 1;
            this.cmbListaWypraw.Text = "nazwa";
            this.cmbListaWypraw.SelectedIndexChanged += new System.EventHandler(this.cmbListaWypraw_SelectedIndexChanged);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(496, 227);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 9;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(64, 125);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(507, 96);
            this.txtOpis.TabIndex = 5;
            this.txtOpis.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Trasa";
            // 
            // txtTrasa
            // 
            this.txtTrasa.Location = new System.Drawing.Point(64, 93);
            this.txtTrasa.Name = "txtTrasa";
            this.txtTrasa.Size = new System.Drawing.Size(507, 20);
            this.txtTrasa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nazwa";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(64, 54);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(507, 20);
            this.txtNazwa.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(405, 227);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 8;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDodajZdjecie
            // 
            this.btnDodajZdjecie.Location = new System.Drawing.Point(295, 227);
            this.btnDodajZdjecie.Name = "btnDodajZdjecie";
            this.btnDodajZdjecie.Size = new System.Drawing.Size(91, 23);
            this.btnDodajZdjecie.TabIndex = 7;
            this.btnDodajZdjecie.Text = "Dodaj zdjęcie";
            this.btnDodajZdjecie.UseVisualStyleBackColor = true;
            this.btnDodajZdjecie.Click += new System.EventHandler(this.btnDodajZdjecie_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(577, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lbRozszerzenie
            // 
            this.lbRozszerzenie.AutoSize = true;
            this.lbRozszerzenie.Location = new System.Drawing.Point(574, 268);
            this.lbRozszerzenie.Name = "lbRozszerzenie";
            this.lbRozszerzenie.Size = new System.Drawing.Size(35, 13);
            this.lbRozszerzenie.TabIndex = 21;
            this.lbRozszerzenie.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 290);
            this.Controls.Add(this.lbRozszerzenie);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDodajZdjecie);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrasa);
            this.Controls.Add(this.cmbListaWypraw);
            this.Name = "Form1";
            this.Text = "Dziennik wypraw górksich";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbListaWypraw;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDodajZdjecie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbRozszerzenie;
    }
}

