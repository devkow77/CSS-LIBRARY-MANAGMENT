namespace BibliotekaProjekt
{
    partial class Form4
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
            this.autorzy_btn = new System.Windows.Forms.Button();
            this.znajdz_btn = new System.Windows.Forms.Button();
            this.znajdz_po_peselu_label = new System.Windows.Forms.Label();
            this.znajdz_autora_textBox = new System.Windows.Forms.TextBox();
            this.wyczysc_btn = new System.Windows.Forms.Button();
            this.edytuj_btn = new System.Windows.Forms.Button();
            this.usun_btn = new System.Windows.Forms.Button();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pesel_label = new System.Windows.Forms.Label();
            this.pesel_textBox = new System.Windows.Forms.TextBox();
            this.nazwisko_label = new System.Windows.Forms.Label();
            this.nazwisko_textBox = new System.Windows.Forms.TextBox();
            this.imie_label = new System.Windows.Forms.Label();
            this.imie_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.klienci_btn = new System.Windows.Forms.Button();
            this.rezerwacje_btn = new System.Windows.Forms.Button();
            this.ksiazki_btn = new System.Windows.Forms.Button();
            this.okno_startowe_btn = new System.Windows.Forms.Button();
            this.add_author_label = new System.Windows.Forms.Label();
            this.kod_pocztowy_label = new System.Windows.Forms.Label();
            this.kod_pocztowy_textBox = new System.Windows.Forms.TextBox();
            this.ulica_label = new System.Windows.Forms.Label();
            this.ulica_textBox = new System.Windows.Forms.TextBox();
            this.miasto_label = new System.Windows.Forms.Label();
            this.miasto_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // autorzy_btn
            // 
            this.autorzy_btn.BackColor = System.Drawing.Color.White;
            this.autorzy_btn.Location = new System.Drawing.Point(35, 177);
            this.autorzy_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorzy_btn.Name = "autorzy_btn";
            this.autorzy_btn.Size = new System.Drawing.Size(131, 49);
            this.autorzy_btn.TabIndex = 42;
            this.autorzy_btn.Text = "Autorzy";
            this.autorzy_btn.UseVisualStyleBackColor = false;
            this.autorzy_btn.Click += new System.EventHandler(this.autorzy_btn_Click);
            // 
            // znajdz_btn
            // 
            this.znajdz_btn.Location = new System.Drawing.Point(856, 693);
            this.znajdz_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.znajdz_btn.Name = "znajdz_btn";
            this.znajdz_btn.Size = new System.Drawing.Size(121, 30);
            this.znajdz_btn.TabIndex = 41;
            this.znajdz_btn.Text = "znajdz";
            this.znajdz_btn.UseVisualStyleBackColor = true;
            this.znajdz_btn.Click += new System.EventHandler(this.znajdz_btn_Click);
            // 
            // znajdz_po_peselu_label
            // 
            this.znajdz_po_peselu_label.AutoSize = true;
            this.znajdz_po_peselu_label.Location = new System.Drawing.Point(496, 699);
            this.znajdz_po_peselu_label.Name = "znajdz_po_peselu_label";
            this.znajdz_po_peselu_label.Size = new System.Drawing.Size(152, 16);
            this.znajdz_po_peselu_label.TabIndex = 40;
            this.znajdz_po_peselu_label.Text = "Znajdz klienta po peselu";
            // 
            // znajdz_autora_textBox
            // 
            this.znajdz_autora_textBox.Location = new System.Drawing.Point(676, 697);
            this.znajdz_autora_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.znajdz_autora_textBox.Name = "znajdz_autora_textBox";
            this.znajdz_autora_textBox.Size = new System.Drawing.Size(168, 22);
            this.znajdz_autora_textBox.TabIndex = 39;
            // 
            // wyczysc_btn
            // 
            this.wyczysc_btn.BackColor = System.Drawing.Color.Silver;
            this.wyczysc_btn.Location = new System.Drawing.Point(332, 529);
            this.wyczysc_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wyczysc_btn.Name = "wyczysc_btn";
            this.wyczysc_btn.Size = new System.Drawing.Size(121, 30);
            this.wyczysc_btn.TabIndex = 38;
            this.wyczysc_btn.Text = "wyczysc";
            this.wyczysc_btn.UseVisualStyleBackColor = false;
            this.wyczysc_btn.Click += new System.EventHandler(this.wyczysc_btn_Click);
            // 
            // edytuj_btn
            // 
            this.edytuj_btn.BackColor = System.Drawing.Color.Yellow;
            this.edytuj_btn.Location = new System.Drawing.Point(204, 529);
            this.edytuj_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edytuj_btn.Name = "edytuj_btn";
            this.edytuj_btn.Size = new System.Drawing.Size(121, 30);
            this.edytuj_btn.TabIndex = 37;
            this.edytuj_btn.Text = "edytuj";
            this.edytuj_btn.UseVisualStyleBackColor = false;
            this.edytuj_btn.Click += new System.EventHandler(this.edytuj_btn_Click);
            // 
            // usun_btn
            // 
            this.usun_btn.BackColor = System.Drawing.Color.Red;
            this.usun_btn.Location = new System.Drawing.Point(332, 494);
            this.usun_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usun_btn.Name = "usun_btn";
            this.usun_btn.Size = new System.Drawing.Size(121, 30);
            this.usun_btn.TabIndex = 36;
            this.usun_btn.Text = "usun";
            this.usun_btn.UseVisualStyleBackColor = false;
            this.usun_btn.Click += new System.EventHandler(this.usun_btn_Click);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.BackColor = System.Drawing.Color.Lime;
            this.dodaj_btn.Location = new System.Drawing.Point(204, 494);
            this.dodaj_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(121, 30);
            this.dodaj_btn.TabIndex = 35;
            this.dodaj_btn.Text = "dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = false;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(500, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(854, 308);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pesel_label
            // 
            this.pesel_label.AutoSize = true;
            this.pesel_label.Location = new System.Drawing.Point(203, 210);
            this.pesel_label.Name = "pesel_label";
            this.pesel_label.Size = new System.Drawing.Size(42, 16);
            this.pesel_label.TabIndex = 33;
            this.pesel_label.Text = "Pesel";
            // 
            // pesel_textBox
            // 
            this.pesel_textBox.Location = new System.Drawing.Point(205, 240);
            this.pesel_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pesel_textBox.Name = "pesel_textBox";
            this.pesel_textBox.Size = new System.Drawing.Size(249, 22);
            this.pesel_textBox.TabIndex = 32;
            // 
            // nazwisko_label
            // 
            this.nazwisko_label.AutoSize = true;
            this.nazwisko_label.Location = new System.Drawing.Point(203, 140);
            this.nazwisko_label.Name = "nazwisko_label";
            this.nazwisko_label.Size = new System.Drawing.Size(65, 16);
            this.nazwisko_label.TabIndex = 31;
            this.nazwisko_label.Text = "Nazwisko";
            // 
            // nazwisko_textBox
            // 
            this.nazwisko_textBox.Location = new System.Drawing.Point(205, 170);
            this.nazwisko_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko_textBox.Name = "nazwisko_textBox";
            this.nazwisko_textBox.Size = new System.Drawing.Size(249, 22);
            this.nazwisko_textBox.TabIndex = 30;
            // 
            // imie_label
            // 
            this.imie_label.AutoSize = true;
            this.imie_label.Location = new System.Drawing.Point(203, 78);
            this.imie_label.Name = "imie_label";
            this.imie_label.Size = new System.Drawing.Size(32, 16);
            this.imie_label.TabIndex = 29;
            this.imie_label.Text = "Imie";
            // 
            // imie_textBox
            // 
            this.imie_textBox.Location = new System.Drawing.Point(205, 105);
            this.imie_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie_textBox.Name = "imie_textBox";
            this.imie_textBox.Size = new System.Drawing.Size(249, 22);
            this.imie_textBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nawigacja";
            // 
            // klienci_btn
            // 
            this.klienci_btn.BackColor = System.Drawing.Color.Lime;
            this.klienci_btn.Location = new System.Drawing.Point(35, 299);
            this.klienci_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klienci_btn.Name = "klienci_btn";
            this.klienci_btn.Size = new System.Drawing.Size(131, 49);
            this.klienci_btn.TabIndex = 26;
            this.klienci_btn.Text = "Klienci";
            this.klienci_btn.UseVisualStyleBackColor = false;
            // 
            // rezerwacje_btn
            // 
            this.rezerwacje_btn.Location = new System.Drawing.Point(35, 358);
            this.rezerwacje_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezerwacje_btn.Name = "rezerwacje_btn";
            this.rezerwacje_btn.Size = new System.Drawing.Size(131, 49);
            this.rezerwacje_btn.TabIndex = 25;
            this.rezerwacje_btn.Text = "Rezerwacje";
            this.rezerwacje_btn.UseVisualStyleBackColor = true;
            this.rezerwacje_btn.Click += new System.EventHandler(this.rezerwacje_btn_Click);
            // 
            // ksiazki_btn
            // 
            this.ksiazki_btn.Location = new System.Drawing.Point(35, 240);
            this.ksiazki_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ksiazki_btn.Name = "ksiazki_btn";
            this.ksiazki_btn.Size = new System.Drawing.Size(131, 49);
            this.ksiazki_btn.TabIndex = 24;
            this.ksiazki_btn.Text = "Ksiazki";
            this.ksiazki_btn.UseVisualStyleBackColor = true;
            this.ksiazki_btn.Click += new System.EventHandler(this.ksiazki_btn_Click);
            // 
            // okno_startowe_btn
            // 
            this.okno_startowe_btn.Location = new System.Drawing.Point(35, 117);
            this.okno_startowe_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okno_startowe_btn.Name = "okno_startowe_btn";
            this.okno_startowe_btn.Size = new System.Drawing.Size(131, 49);
            this.okno_startowe_btn.TabIndex = 23;
            this.okno_startowe_btn.Text = "Okno startowe";
            this.okno_startowe_btn.UseVisualStyleBackColor = true;
            this.okno_startowe_btn.Click += new System.EventHandler(this.okno_startowe_btn_Click);
            // 
            // add_author_label
            // 
            this.add_author_label.AutoSize = true;
            this.add_author_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_author_label.Location = new System.Drawing.Point(201, 34);
            this.add_author_label.Name = "add_author_label";
            this.add_author_label.Size = new System.Drawing.Size(124, 25);
            this.add_author_label.TabIndex = 22;
            this.add_author_label.Text = "Dodaj klienta";
            // 
            // kod_pocztowy_label
            // 
            this.kod_pocztowy_label.AutoSize = true;
            this.kod_pocztowy_label.Location = new System.Drawing.Point(203, 417);
            this.kod_pocztowy_label.Name = "kod_pocztowy_label";
            this.kod_pocztowy_label.Size = new System.Drawing.Size(90, 16);
            this.kod_pocztowy_label.TabIndex = 48;
            this.kod_pocztowy_label.Text = "Kod pocztowy";
            // 
            // kod_pocztowy_textBox
            // 
            this.kod_pocztowy_textBox.Location = new System.Drawing.Point(205, 447);
            this.kod_pocztowy_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kod_pocztowy_textBox.Name = "kod_pocztowy_textBox";
            this.kod_pocztowy_textBox.Size = new System.Drawing.Size(249, 22);
            this.kod_pocztowy_textBox.TabIndex = 47;
            // 
            // ulica_label
            // 
            this.ulica_label.AutoSize = true;
            this.ulica_label.Location = new System.Drawing.Point(203, 347);
            this.ulica_label.Name = "ulica_label";
            this.ulica_label.Size = new System.Drawing.Size(38, 16);
            this.ulica_label.TabIndex = 46;
            this.ulica_label.Text = "Ulica";
            // 
            // ulica_textBox
            // 
            this.ulica_textBox.Location = new System.Drawing.Point(205, 377);
            this.ulica_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ulica_textBox.Name = "ulica_textBox";
            this.ulica_textBox.Size = new System.Drawing.Size(249, 22);
            this.ulica_textBox.TabIndex = 45;
            // 
            // miasto_label
            // 
            this.miasto_label.AutoSize = true;
            this.miasto_label.Location = new System.Drawing.Point(203, 284);
            this.miasto_label.Name = "miasto_label";
            this.miasto_label.Size = new System.Drawing.Size(47, 16);
            this.miasto_label.TabIndex = 44;
            this.miasto_label.Text = "Miasto";
            // 
            // miasto_textBox
            // 
            this.miasto_textBox.Location = new System.Drawing.Point(205, 313);
            this.miasto_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miasto_textBox.Name = "miasto_textBox";
            this.miasto_textBox.Size = new System.Drawing.Size(249, 22);
            this.miasto_textBox.TabIndex = 43;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(500, 358);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(854, 308);
            this.dataGridView2.TabIndex = 49;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.kod_pocztowy_label);
            this.Controls.Add(this.kod_pocztowy_textBox);
            this.Controls.Add(this.ulica_label);
            this.Controls.Add(this.ulica_textBox);
            this.Controls.Add(this.miasto_label);
            this.Controls.Add(this.miasto_textBox);
            this.Controls.Add(this.autorzy_btn);
            this.Controls.Add(this.znajdz_btn);
            this.Controls.Add(this.znajdz_po_peselu_label);
            this.Controls.Add(this.znajdz_autora_textBox);
            this.Controls.Add(this.wyczysc_btn);
            this.Controls.Add(this.edytuj_btn);
            this.Controls.Add(this.usun_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesel_label);
            this.Controls.Add(this.pesel_textBox);
            this.Controls.Add(this.nazwisko_label);
            this.Controls.Add(this.nazwisko_textBox);
            this.Controls.Add(this.imie_label);
            this.Controls.Add(this.imie_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klienci_btn);
            this.Controls.Add(this.rezerwacje_btn);
            this.Controls.Add(this.ksiazki_btn);
            this.Controls.Add(this.okno_startowe_btn);
            this.Controls.Add(this.add_author_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button autorzy_btn;
        private System.Windows.Forms.Button znajdz_btn;
        private System.Windows.Forms.Label znajdz_po_peselu_label;
        private System.Windows.Forms.TextBox znajdz_autora_textBox;
        private System.Windows.Forms.Button wyczysc_btn;
        private System.Windows.Forms.Button edytuj_btn;
        private System.Windows.Forms.Button usun_btn;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label pesel_label;
        private System.Windows.Forms.TextBox pesel_textBox;
        private System.Windows.Forms.Label nazwisko_label;
        private System.Windows.Forms.TextBox nazwisko_textBox;
        private System.Windows.Forms.Label imie_label;
        private System.Windows.Forms.TextBox imie_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button klienci_btn;
        private System.Windows.Forms.Button rezerwacje_btn;
        private System.Windows.Forms.Button ksiazki_btn;
        private System.Windows.Forms.Button okno_startowe_btn;
        private System.Windows.Forms.Label add_author_label;
        private System.Windows.Forms.Label kod_pocztowy_label;
        private System.Windows.Forms.TextBox kod_pocztowy_textBox;
        private System.Windows.Forms.Label ulica_label;
        private System.Windows.Forms.TextBox ulica_textBox;
        private System.Windows.Forms.Label miasto_label;
        private System.Windows.Forms.TextBox miasto_textBox;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}