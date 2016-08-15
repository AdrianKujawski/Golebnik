namespace Golebnik
{
    partial class OknoGlowne
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoGlowne));
			this.ImageBoxZdjecieGolebia = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox_nrObraczki = new System.Windows.Forms.TextBox();
			this.textBox_barwa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.picturebox_wczytaneZdjecie = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label_nrObraczkiOdczyt = new System.Windows.Forms.Label();
			this.label_barwaOdczyt = new System.Windows.Forms.Label();
			this.label_plecOdczyt = new System.Windows.Forms.Label();
			this.listaGolebii = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.wczytany_nrObraczki = new System.Windows.Forms.Label();
			this.wczytany_barwa = new System.Windows.Forms.Label();
			this.wczytany_plec = new System.Windows.Forms.Label();
			this.button_usunGolebia = new System.Windows.Forms.Button();
			this.button_szukaj = new System.Windows.Forms.Button();
			this.szukajBox = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.wczytany_rodzaj = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label_Sortuj = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ImageBoxZdjecieGolebia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturebox_wczytaneZdjecie)).BeginInit();
			this.SuspendLayout();
			// 
			// ImageBoxZdjecieGolebia
			// 
			this.ImageBoxZdjecieGolebia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ImageBoxZdjecieGolebia.Location = new System.Drawing.Point(12, 12);
			this.ImageBoxZdjecieGolebia.Name = "ImageBoxZdjecieGolebia";
			this.ImageBoxZdjecieGolebia.Size = new System.Drawing.Size(179, 180);
			this.ImageBoxZdjecieGolebia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImageBoxZdjecieGolebia.TabIndex = 0;
			this.ImageBoxZdjecieGolebia.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(197, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Wczytaj";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.load_image);
			// 
			// textBox_nrObraczki
			// 
			this.textBox_nrObraczki.Location = new System.Drawing.Point(115, 198);
			this.textBox_nrObraczki.Name = "textBox_nrObraczki";
			this.textBox_nrObraczki.Size = new System.Drawing.Size(100, 20);
			this.textBox_nrObraczki.TabIndex = 2;
			// 
			// textBox_barwa
			// 
			this.textBox_barwa.Location = new System.Drawing.Point(115, 224);
			this.textBox_barwa.Name = "textBox_barwa";
			this.textBox_barwa.Size = new System.Drawing.Size(100, 20);
			this.textBox_barwa.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F);
			this.label1.Location = new System.Drawing.Point(12, 198);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nr obrączki";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F);
			this.label2.Location = new System.Drawing.Point(12, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Barwa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F);
			this.label3.Location = new System.Drawing.Point(12, 251);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "Płeć";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Samiec",
            "Samica"});
			this.comboBox1.Location = new System.Drawing.Point(115, 251);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(197, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 37);
			this.button2.TabIndex = 9;
			this.button2.Text = "Zapisz gołębia";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.PrzyciskZapiszGolebia);
			// 
			// picturebox_wczytaneZdjecie
			// 
			this.picturebox_wczytaneZdjecie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picturebox_wczytaneZdjecie.Location = new System.Drawing.Point(497, 12);
			this.picturebox_wczytaneZdjecie.Name = "picturebox_wczytaneZdjecie";
			this.picturebox_wczytaneZdjecie.Size = new System.Drawing.Size(179, 180);
			this.picturebox_wczytaneZdjecie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturebox_wczytaneZdjecie.TabIndex = 10;
			this.picturebox_wczytaneZdjecie.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(682, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(220, 44);
			this.button3.TabIndex = 11;
			this.button3.Text = "Wczytaj gołębie";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.PrzyciskWczytajGolebie);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F);
			this.label4.Location = new System.Drawing.Point(493, 199);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 19);
			this.label4.TabIndex = 12;
			this.label4.Text = "Nr obrączki";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F);
			this.label5.Location = new System.Drawing.Point(493, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 19);
			this.label5.TabIndex = 13;
			this.label5.Text = "Barwa";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 12F);
			this.label6.Location = new System.Drawing.Point(493, 253);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 19);
			this.label6.TabIndex = 14;
			this.label6.Text = "Płeć";
			// 
			// label_nrObraczkiOdczyt
			// 
			this.label_nrObraczkiOdczyt.AutoSize = true;
			this.label_nrObraczkiOdczyt.Font = new System.Drawing.Font("Calibri", 12F);
			this.label_nrObraczkiOdczyt.Location = new System.Drawing.Point(595, 199);
			this.label_nrObraczkiOdczyt.Name = "label_nrObraczkiOdczyt";
			this.label_nrObraczkiOdczyt.Size = new System.Drawing.Size(0, 19);
			this.label_nrObraczkiOdczyt.TabIndex = 15;
			// 
			// label_barwaOdczyt
			// 
			this.label_barwaOdczyt.AutoSize = true;
			this.label_barwaOdczyt.Font = new System.Drawing.Font("Calibri", 12F);
			this.label_barwaOdczyt.Location = new System.Drawing.Point(595, 225);
			this.label_barwaOdczyt.Name = "label_barwaOdczyt";
			this.label_barwaOdczyt.Size = new System.Drawing.Size(0, 19);
			this.label_barwaOdczyt.TabIndex = 16;
			// 
			// label_plecOdczyt
			// 
			this.label_plecOdczyt.AutoSize = true;
			this.label_plecOdczyt.Font = new System.Drawing.Font("Calibri", 12F);
			this.label_plecOdczyt.Location = new System.Drawing.Point(595, 253);
			this.label_plecOdczyt.Name = "label_plecOdczyt";
			this.label_plecOdczyt.Size = new System.Drawing.Size(0, 19);
			this.label_plecOdczyt.TabIndex = 17;
			// 
			// listaGolebii
			// 
			this.listaGolebii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listaGolebii.FullRowSelect = true;
			this.listaGolebii.GridLines = true;
			this.listaGolebii.Location = new System.Drawing.Point(682, 62);
			this.listaGolebii.Name = "listaGolebii";
			this.listaGolebii.Size = new System.Drawing.Size(220, 208);
			this.listaGolebii.TabIndex = 18;
			this.listaGolebii.UseCompatibleStateImageBehavior = false;
			this.listaGolebii.View = System.Windows.Forms.View.Details;
			this.listaGolebii.Click += new System.EventHandler(this.listaGolebii_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.DisplayIndex = 1;
			this.columnHeader1.Text = "Numer obrączki";
			this.columnHeader1.Width = 213;
			// 
			// columnHeader2
			// 
			this.columnHeader2.DisplayIndex = 0;
			this.columnHeader2.Text = "LP";
			this.columnHeader2.Width = 37;
			// 
			// wczytany_nrObraczki
			// 
			this.wczytany_nrObraczki.AutoSize = true;
			this.wczytany_nrObraczki.Font = new System.Drawing.Font("Calibri", 12F);
			this.wczytany_nrObraczki.Location = new System.Drawing.Point(581, 198);
			this.wczytany_nrObraczki.Name = "wczytany_nrObraczki";
			this.wczytany_nrObraczki.Size = new System.Drawing.Size(14, 19);
			this.wczytany_nrObraczki.TabIndex = 19;
			this.wczytany_nrObraczki.Text = "-";
			// 
			// wczytany_barwa
			// 
			this.wczytany_barwa.AutoSize = true;
			this.wczytany_barwa.Font = new System.Drawing.Font("Calibri", 12F);
			this.wczytany_barwa.Location = new System.Drawing.Point(581, 225);
			this.wczytany_barwa.Name = "wczytany_barwa";
			this.wczytany_barwa.Size = new System.Drawing.Size(14, 19);
			this.wczytany_barwa.TabIndex = 20;
			this.wczytany_barwa.Text = "-";
			// 
			// wczytany_plec
			// 
			this.wczytany_plec.AutoSize = true;
			this.wczytany_plec.Font = new System.Drawing.Font("Calibri", 12F);
			this.wczytany_plec.Location = new System.Drawing.Point(581, 250);
			this.wczytany_plec.Name = "wczytany_plec";
			this.wczytany_plec.Size = new System.Drawing.Size(14, 19);
			this.wczytany_plec.TabIndex = 21;
			this.wczytany_plec.Text = "-";
			// 
			// button_usunGolebia
			// 
			this.button_usunGolebia.Location = new System.Drawing.Point(682, 329);
			this.button_usunGolebia.Name = "button_usunGolebia";
			this.button_usunGolebia.Size = new System.Drawing.Size(69, 23);
			this.button_usunGolebia.TabIndex = 22;
			this.button_usunGolebia.Text = "Usuń";
			this.button_usunGolebia.UseVisualStyleBackColor = true;
			this.button_usunGolebia.Click += new System.EventHandler(this.button_usunGolebia_Click);
			// 
			// button_szukaj
			// 
			this.button_szukaj.Location = new System.Drawing.Point(682, 303);
			this.button_szukaj.Name = "button_szukaj";
			this.button_szukaj.Size = new System.Drawing.Size(69, 23);
			this.button_szukaj.TabIndex = 23;
			this.button_szukaj.Text = "Szukaj";
			this.button_szukaj.UseVisualStyleBackColor = true;
			this.button_szukaj.Click += new System.EventHandler(this.button_szukaj_Click);
			// 
			// szukajBox
			// 
			this.szukajBox.Location = new System.Drawing.Point(757, 303);
			this.szukajBox.Name = "szukajBox";
			this.szukajBox.Size = new System.Drawing.Size(145, 20);
			this.szukajBox.TabIndex = 24;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Rozpłodowy",
            "Lotowy"});
			this.comboBox2.Location = new System.Drawing.Point(115, 278);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(100, 21);
			this.comboBox2.TabIndex = 25;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 12F);
			this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label7.Location = new System.Drawing.Point(12, 280);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 19);
			this.label7.TabIndex = 29;
			this.label7.Text = "Rodzaj";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 12F);
			this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new System.Drawing.Point(493, 280);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 19);
			this.label8.TabIndex = 30;
			this.label8.Text = "Rodzaj";
			// 
			// wczytany_rodzaj
			// 
			this.wczytany_rodzaj.AutoSize = true;
			this.wczytany_rodzaj.Font = new System.Drawing.Font("Calibri", 12F);
			this.wczytany_rodzaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.wczytany_rodzaj.Location = new System.Drawing.Point(581, 280);
			this.wczytany_rodzaj.Name = "wczytany_rodzaj";
			this.wczytany_rodzaj.Size = new System.Drawing.Size(14, 19);
			this.wczytany_rodzaj.TabIndex = 31;
			this.wczytany_rodzaj.Text = "-";
			// 
			// comboBox3
			// 
			this.comboBox3.BackColor = System.Drawing.SystemColors.Window;
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "Rozpłodowy",
            "Lotowy"});
			this.comboBox3.Location = new System.Drawing.Point(757, 276);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(145, 21);
			this.comboBox3.TabIndex = 32;
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// label_Sortuj
			// 
			this.label_Sortuj.AutoSize = true;
			this.label_Sortuj.Font = new System.Drawing.Font("Calibri", 12F);
			this.label_Sortuj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label_Sortuj.Location = new System.Drawing.Point(678, 275);
			this.label_Sortuj.Name = "label_Sortuj";
			this.label_Sortuj.Size = new System.Drawing.Size(78, 19);
			this.label_Sortuj.TabIndex = 33;
			this.label_Sortuj.Text = "Sortuj wg.:";
			// 
			// OknoGlowne
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(914, 361);
			this.Controls.Add(this.label_Sortuj);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.wczytany_rodzaj);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.szukajBox);
			this.Controls.Add(this.button_szukaj);
			this.Controls.Add(this.button_usunGolebia);
			this.Controls.Add(this.wczytany_plec);
			this.Controls.Add(this.wczytany_barwa);
			this.Controls.Add(this.wczytany_nrObraczki);
			this.Controls.Add(this.listaGolebii);
			this.Controls.Add(this.label_plecOdczyt);
			this.Controls.Add(this.label_barwaOdczyt);
			this.Controls.Add(this.label_nrObraczkiOdczyt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.picturebox_wczytaneZdjecie);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_barwa);
			this.Controls.Add(this.textBox_nrObraczki);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ImageBoxZdjecieGolebia);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "OknoGlowne";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.ImageBoxZdjecieGolebia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturebox_wczytaneZdjecie)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBoxZdjecieGolebia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_nrObraczki;
        private System.Windows.Forms.TextBox textBox_barwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picturebox_wczytaneZdjecie;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_nrObraczkiOdczyt;
        private System.Windows.Forms.Label label_barwaOdczyt;
        private System.Windows.Forms.Label label_plecOdczyt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listaGolebii;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label wczytany_nrObraczki;
        private System.Windows.Forms.Label wczytany_barwa;
        private System.Windows.Forms.Label wczytany_plec;
        private System.Windows.Forms.Button button_usunGolebia;
        private System.Windows.Forms.Button button_szukaj;
        private System.Windows.Forms.TextBox szukajBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label wczytany_rodzaj;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label_Sortuj;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

