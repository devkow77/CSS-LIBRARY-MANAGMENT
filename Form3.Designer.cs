namespace BibliotekaProjekt
{
    partial class Form3
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
            this.znajdz_btn = new System.Windows.Forms.Button();
            this.znajdz_po_nazwisku_label = new System.Windows.Forms.Label();
            this.znajdz_ksiazke_textBox = new System.Windows.Forms.TextBox();
            this.wyczysc_btn = new System.Windows.Forms.Button();
            this.edytuj_btn = new System.Windows.Forms.Button();
            this.usun_btn = new System.Windows.Forms.Button();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rok_wydania_label = new System.Windows.Forms.Label();
            this.kategoria_label = new System.Windows.Forms.Label();
            this.kategoria_textBox = new System.Windows.Forms.TextBox();
            this.tytul_label = new System.Windows.Forms.Label();
            this.tytul_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.klienci_btn = new System.Windows.Forms.Button();
            this.rezerwacje_btn = new System.Windows.Forms.Button();
            this.autorzy_btn = new System.Windows.Forms.Button();
            this.okno_startowe_btn = new System.Windows.Forms.Button();
            this.add_book_label = new System.Windows.Forms.Label();
            this.liczba_stron_label = new System.Windows.Forms.Label();
            this.ksiazki_btn = new System.Windows.Forms.Button();
            this.id_autora_label = new System.Windows.Forms.Label();
            this.comboBoxAutorzy = new System.Windows.Forms.ComboBox();
            this.rok_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.strony_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kategoria_btn = new System.Windows.Forms.Button();
            this.znajdz_po_kategori_label = new System.Windows.Forms.Label();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.data_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.data_wyczysc_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strony_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // znajdz_btn
            // 
            this.znajdz_btn.Location = new System.Drawing.Point(846, 371);
            this.znajdz_btn.Name = "znajdz_btn";
            this.znajdz_btn.Size = new System.Drawing.Size(121, 30);
            this.znajdz_btn.TabIndex = 40;
            this.znajdz_btn.Text = "znajdz";
            this.znajdz_btn.UseVisualStyleBackColor = true;
            this.znajdz_btn.Click += new System.EventHandler(this.znajdz_btn_Click);
            // 
            // znajdz_po_nazwisku_label
            // 
            this.znajdz_po_nazwisku_label.AutoSize = true;
            this.znajdz_po_nazwisku_label.Location = new System.Drawing.Point(486, 378);
            this.znajdz_po_nazwisku_label.Name = "znajdz_po_nazwisku_label";
            this.znajdz_po_nazwisku_label.Size = new System.Drawing.Size(149, 16);
            this.znajdz_po_nazwisku_label.TabIndex = 39;
            this.znajdz_po_nazwisku_label.Text = "Znajdz ksiazke po tytule";
            // 
            // znajdz_ksiazke_textBox
            // 
            this.znajdz_ksiazke_textBox.Location = new System.Drawing.Point(666, 375);
            this.znajdz_ksiazke_textBox.Name = "znajdz_ksiazke_textBox";
            this.znajdz_ksiazke_textBox.Size = new System.Drawing.Size(168, 22);
            this.znajdz_ksiazke_textBox.TabIndex = 38;
            // 
            // wyczysc_btn
            // 
            this.wyczysc_btn.BackColor = System.Drawing.Color.Silver;
            this.wyczysc_btn.Location = new System.Drawing.Point(323, 480);
            this.wyczysc_btn.Name = "wyczysc_btn";
            this.wyczysc_btn.Size = new System.Drawing.Size(121, 30);
            this.wyczysc_btn.TabIndex = 37;
            this.wyczysc_btn.Text = "wyczysc";
            this.wyczysc_btn.UseVisualStyleBackColor = false;
            this.wyczysc_btn.Click += new System.EventHandler(this.wyczysc_btn_Click);
            // 
            // edytuj_btn
            // 
            this.edytuj_btn.BackColor = System.Drawing.Color.Yellow;
            this.edytuj_btn.Location = new System.Drawing.Point(195, 480);
            this.edytuj_btn.Name = "edytuj_btn";
            this.edytuj_btn.Size = new System.Drawing.Size(121, 30);
            this.edytuj_btn.TabIndex = 36;
            this.edytuj_btn.Text = "edytuj";
            this.edytuj_btn.UseVisualStyleBackColor = false;
            this.edytuj_btn.Click += new System.EventHandler(this.edytuj_btn_Click);
            // 
            // usun_btn
            // 
            this.usun_btn.BackColor = System.Drawing.Color.Red;
            this.usun_btn.Location = new System.Drawing.Point(323, 444);
            this.usun_btn.Name = "usun_btn";
            this.usun_btn.Size = new System.Drawing.Size(121, 30);
            this.usun_btn.TabIndex = 35;
            this.usun_btn.Text = "usun";
            this.usun_btn.UseVisualStyleBackColor = false;
            this.usun_btn.Click += new System.EventHandler(this.usun_btn_Click);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.BackColor = System.Drawing.Color.Lime;
            this.dodaj_btn.Location = new System.Drawing.Point(195, 444);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(121, 30);
            this.dodaj_btn.TabIndex = 34;
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
            this.dataGridView1.Location = new System.Drawing.Point(489, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 308);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rok_wydania_label
            // 
            this.rok_wydania_label.AutoSize = true;
            this.rok_wydania_label.Location = new System.Drawing.Point(192, 222);
            this.rok_wydania_label.Name = "rok_wydania_label";
            this.rok_wydania_label.Size = new System.Drawing.Size(85, 16);
            this.rok_wydania_label.TabIndex = 32;
            this.rok_wydania_label.Text = "Rok wydania";
            // 
            // kategoria_label
            // 
            this.kategoria_label.AutoSize = true;
            this.kategoria_label.Location = new System.Drawing.Point(192, 152);
            this.kategoria_label.Name = "kategoria_label";
            this.kategoria_label.Size = new System.Drawing.Size(65, 16);
            this.kategoria_label.TabIndex = 30;
            this.kategoria_label.Text = "Kategoria";
            // 
            // kategoria_textBox
            // 
            this.kategoria_textBox.Location = new System.Drawing.Point(195, 182);
            this.kategoria_textBox.Name = "kategoria_textBox";
            this.kategoria_textBox.Size = new System.Drawing.Size(249, 22);
            this.kategoria_textBox.TabIndex = 29;
            // 
            // tytul_label
            // 
            this.tytul_label.AutoSize = true;
            this.tytul_label.Location = new System.Drawing.Point(192, 89);
            this.tytul_label.Name = "tytul_label";
            this.tytul_label.Size = new System.Drawing.Size(36, 16);
            this.tytul_label.TabIndex = 28;
            this.tytul_label.Text = "Tytul";
            // 
            // tytul_textBox
            // 
            this.tytul_textBox.Location = new System.Drawing.Point(195, 117);
            this.tytul_textBox.Name = "tytul_textBox";
            this.tytul_textBox.Size = new System.Drawing.Size(249, 22);
            this.tytul_textBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nawigacja";
            // 
            // klienci_btn
            // 
            this.klienci_btn.Location = new System.Drawing.Point(23, 320);
            this.klienci_btn.Name = "klienci_btn";
            this.klienci_btn.Size = new System.Drawing.Size(130, 49);
            this.klienci_btn.TabIndex = 25;
            this.klienci_btn.Text = "Klienci";
            this.klienci_btn.UseVisualStyleBackColor = true;
            this.klienci_btn.Click += new System.EventHandler(this.klienci_btn_Click);
            // 
            // rezerwacje_btn
            // 
            this.rezerwacje_btn.Location = new System.Drawing.Point(23, 379);
            this.rezerwacje_btn.Name = "rezerwacje_btn";
            this.rezerwacje_btn.Size = new System.Drawing.Size(130, 49);
            this.rezerwacje_btn.TabIndex = 24;
            this.rezerwacje_btn.Text = "Rezerwacje";
            this.rezerwacje_btn.UseVisualStyleBackColor = true;
            this.rezerwacje_btn.Click += new System.EventHandler(this.rezerwacje_btn_Click);
            // 
            // autorzy_btn
            // 
            this.autorzy_btn.Location = new System.Drawing.Point(23, 189);
            this.autorzy_btn.Name = "autorzy_btn";
            this.autorzy_btn.Size = new System.Drawing.Size(130, 49);
            this.autorzy_btn.TabIndex = 23;
            this.autorzy_btn.Text = "Autorzy";
            this.autorzy_btn.UseVisualStyleBackColor = true;
            this.autorzy_btn.Click += new System.EventHandler(this.autorzy_btn_Click);
            // 
            // okno_startowe_btn
            // 
            this.okno_startowe_btn.Location = new System.Drawing.Point(23, 129);
            this.okno_startowe_btn.Name = "okno_startowe_btn";
            this.okno_startowe_btn.Size = new System.Drawing.Size(130, 49);
            this.okno_startowe_btn.TabIndex = 22;
            this.okno_startowe_btn.Text = "Okno startowe";
            this.okno_startowe_btn.UseVisualStyleBackColor = true;
            this.okno_startowe_btn.Click += new System.EventHandler(this.okno_startowe_btn_Click);
            // 
            // add_book_label
            // 
            this.add_book_label.AutoSize = true;
            this.add_book_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_book_label.Location = new System.Drawing.Point(190, 47);
            this.add_book_label.Name = "add_book_label";
            this.add_book_label.Size = new System.Drawing.Size(134, 25);
            this.add_book_label.TabIndex = 21;
            this.add_book_label.Text = "Dodaj ksiazke";
            // 
            // liczba_stron_label
            // 
            this.liczba_stron_label.AutoSize = true;
            this.liczba_stron_label.Location = new System.Drawing.Point(192, 290);
            this.liczba_stron_label.Name = "liczba_stron_label";
            this.liczba_stron_label.Size = new System.Drawing.Size(78, 16);
            this.liczba_stron_label.TabIndex = 42;
            this.liczba_stron_label.Text = "Liczba stron";
            // 
            // ksiazki_btn
            // 
            this.ksiazki_btn.BackColor = System.Drawing.Color.Lime;
            this.ksiazki_btn.Location = new System.Drawing.Point(23, 252);
            this.ksiazki_btn.Name = "ksiazki_btn";
            this.ksiazki_btn.Size = new System.Drawing.Size(130, 49);
            this.ksiazki_btn.TabIndex = 43;
            this.ksiazki_btn.Text = "Ksiazki";
            this.ksiazki_btn.UseVisualStyleBackColor = false;
            this.ksiazki_btn.Click += new System.EventHandler(this.ksiazki_btn_Click);
            // 
            // id_autora_label
            // 
            this.id_autora_label.AutoSize = true;
            this.id_autora_label.Location = new System.Drawing.Point(192, 362);
            this.id_autora_label.Name = "id_autora_label";
            this.id_autora_label.Size = new System.Drawing.Size(59, 16);
            this.id_autora_label.TabIndex = 44;
            this.id_autora_label.Text = "Id autora";
            // 
            // comboBoxAutorzy
            // 
            this.comboBoxAutorzy.FormattingEnabled = true;
            this.comboBoxAutorzy.Location = new System.Drawing.Point(195, 392);
            this.comboBoxAutorzy.Name = "comboBoxAutorzy";
            this.comboBoxAutorzy.Size = new System.Drawing.Size(249, 24);
            this.comboBoxAutorzy.TabIndex = 45;
            // 
            // rok_dateTimePicker
            // 
            this.rok_dateTimePicker.Location = new System.Drawing.Point(195, 252);
            this.rok_dateTimePicker.Name = "rok_dateTimePicker";
            this.rok_dateTimePicker.Size = new System.Drawing.Size(249, 22);
            this.rok_dateTimePicker.TabIndex = 46;
            // 
            // strony_numericUpDown
            // 
            this.strony_numericUpDown.Location = new System.Drawing.Point(195, 320);
            this.strony_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.strony_numericUpDown.Name = "strony_numericUpDown";
            this.strony_numericUpDown.Size = new System.Drawing.Size(249, 22);
            this.strony_numericUpDown.TabIndex = 47;
            // 
            // kategoria_btn
            // 
            this.kategoria_btn.Location = new System.Drawing.Point(846, 456);
            this.kategoria_btn.Name = "kategoria_btn";
            this.kategoria_btn.Size = new System.Drawing.Size(121, 30);
            this.kategoria_btn.TabIndex = 50;
            this.kategoria_btn.Text = "znajdz";
            this.kategoria_btn.UseVisualStyleBackColor = true;
            this.kategoria_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // znajdz_po_kategori_label
            // 
            this.znajdz_po_kategori_label.AutoSize = true;
            this.znajdz_po_kategori_label.Location = new System.Drawing.Point(486, 463);
            this.znajdz_po_kategori_label.Name = "znajdz_po_kategori_label";
            this.znajdz_po_kategori_label.Size = new System.Drawing.Size(167, 16);
            this.znajdz_po_kategori_label.TabIndex = 49;
            this.znajdz_po_kategori_label.Text = "Znajdz ksiazke po kategori";
            this.znajdz_po_kategori_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Location = new System.Drawing.Point(666, 460);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(168, 24);
            this.comboBoxKategoria.TabIndex = 51;
            // 
            // data_btn
            // 
            this.data_btn.Location = new System.Drawing.Point(846, 507);
            this.data_btn.Name = "data_btn";
            this.data_btn.Size = new System.Drawing.Size(121, 30);
            this.data_btn.TabIndex = 53;
            this.data_btn.Text = "znajdz";
            this.data_btn.UseVisualStyleBackColor = true;
            this.data_btn.Click += new System.EventHandler(this.data_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Zakres daty napisania";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(640, 516);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 22);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(640, 556);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(194, 22);
            this.dateTimePicker2.TabIndex = 55;
            // 
            // data_wyczysc_btn
            // 
            this.data_wyczysc_btn.Location = new System.Drawing.Point(846, 548);
            this.data_wyczysc_btn.Name = "data_wyczysc_btn";
            this.data_wyczysc_btn.Size = new System.Drawing.Size(121, 30);
            this.data_wyczysc_btn.TabIndex = 56;
            this.data_wyczysc_btn.Text = "wyczysc";
            this.data_wyczysc_btn.UseVisualStyleBackColor = true;
            this.data_wyczysc_btn.Click += new System.EventHandler(this.data_wyczysc_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 59;
            this.button1.Text = "znajdz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Znajdz ksiazke po autorze";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(666, 419);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 57;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 728);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.data_wyczysc_btn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.data_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxKategoria);
            this.Controls.Add(this.kategoria_btn);
            this.Controls.Add(this.znajdz_po_kategori_label);
            this.Controls.Add(this.strony_numericUpDown);
            this.Controls.Add(this.rok_dateTimePicker);
            this.Controls.Add(this.comboBoxAutorzy);
            this.Controls.Add(this.id_autora_label);
            this.Controls.Add(this.ksiazki_btn);
            this.Controls.Add(this.liczba_stron_label);
            this.Controls.Add(this.znajdz_btn);
            this.Controls.Add(this.znajdz_po_nazwisku_label);
            this.Controls.Add(this.znajdz_ksiazke_textBox);
            this.Controls.Add(this.wyczysc_btn);
            this.Controls.Add(this.edytuj_btn);
            this.Controls.Add(this.usun_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rok_wydania_label);
            this.Controls.Add(this.kategoria_label);
            this.Controls.Add(this.kategoria_textBox);
            this.Controls.Add(this.tytul_label);
            this.Controls.Add(this.tytul_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klienci_btn);
            this.Controls.Add(this.rezerwacje_btn);
            this.Controls.Add(this.autorzy_btn);
            this.Controls.Add(this.okno_startowe_btn);
            this.Controls.Add(this.add_book_label);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strony_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button znajdz_btn;
        private System.Windows.Forms.Label znajdz_po_nazwisku_label;
        private System.Windows.Forms.TextBox znajdz_ksiazke_textBox;
        private System.Windows.Forms.Button wyczysc_btn;
        private System.Windows.Forms.Button edytuj_btn;
        private System.Windows.Forms.Button usun_btn;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label rok_wydania_label;
        private System.Windows.Forms.Label kategoria_label;
        private System.Windows.Forms.TextBox kategoria_textBox;
        private System.Windows.Forms.Label tytul_label;
        private System.Windows.Forms.TextBox tytul_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button klienci_btn;
        private System.Windows.Forms.Button rezerwacje_btn;
        private System.Windows.Forms.Button autorzy_btn;
        private System.Windows.Forms.Button okno_startowe_btn;
        private System.Windows.Forms.Label add_book_label;
        private System.Windows.Forms.Label liczba_stron_label;
        private System.Windows.Forms.Button ksiazki_btn;
        private System.Windows.Forms.Label id_autora_label;
        private System.Windows.Forms.ComboBox comboBoxAutorzy;
        private System.Windows.Forms.DateTimePicker rok_dateTimePicker;
        private System.Windows.Forms.NumericUpDown strony_numericUpDown;
        private System.Windows.Forms.Button kategoria_btn;
        private System.Windows.Forms.Label znajdz_po_kategori_label;
        private System.Windows.Forms.ComboBox comboBoxKategoria;
        private System.Windows.Forms.Button data_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button data_wyczysc_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}