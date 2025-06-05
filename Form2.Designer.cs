namespace BibliotekaProjekt
{
    partial class Form2
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
            this.add_author_label = new System.Windows.Forms.Label();
            this.okno_startowe_btn = new System.Windows.Forms.Button();
            this.ksiazki_btn = new System.Windows.Forms.Button();
            this.rezerwacje_btn = new System.Windows.Forms.Button();
            this.klienci_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imie_textBox = new System.Windows.Forms.TextBox();
            this.imie_label = new System.Windows.Forms.Label();
            this.nazwisko_label = new System.Windows.Forms.Label();
            this.nazwisko_textBox = new System.Windows.Forms.TextBox();
            this.kraj_label = new System.Windows.Forms.Label();
            this.kraj_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.usun_btn = new System.Windows.Forms.Button();
            this.edytuj_btn = new System.Windows.Forms.Button();
            this.wyczysc_btn = new System.Windows.Forms.Button();
            this.znajdz_autora_textBox = new System.Windows.Forms.TextBox();
            this.znajdz_po_nazwisku_label = new System.Windows.Forms.Label();
            this.znajdz_btn = new System.Windows.Forms.Button();
            this.autorzy_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKraj = new System.Windows.Forms.ComboBox();
            this.kraj_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_author_label
            // 
            this.add_author_label.AutoSize = true;
            this.add_author_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_author_label.Location = new System.Drawing.Point(189, 51);
            this.add_author_label.Name = "add_author_label";
            this.add_author_label.Size = new System.Drawing.Size(123, 25);
            this.add_author_label.TabIndex = 0;
            this.add_author_label.Text = "Dodaj autora";
            // 
            // okno_startowe_btn
            // 
            this.okno_startowe_btn.Location = new System.Drawing.Point(22, 133);
            this.okno_startowe_btn.Name = "okno_startowe_btn";
            this.okno_startowe_btn.Size = new System.Drawing.Size(130, 49);
            this.okno_startowe_btn.TabIndex = 1;
            this.okno_startowe_btn.Text = "Okno startowe";
            this.okno_startowe_btn.UseVisualStyleBackColor = true;
            this.okno_startowe_btn.Click += new System.EventHandler(this.okno_startowe_btn_Click);
            // 
            // ksiazki_btn
            // 
            this.ksiazki_btn.Location = new System.Drawing.Point(22, 256);
            this.ksiazki_btn.Name = "ksiazki_btn";
            this.ksiazki_btn.Size = new System.Drawing.Size(130, 49);
            this.ksiazki_btn.TabIndex = 3;
            this.ksiazki_btn.Text = "Ksiazki";
            this.ksiazki_btn.UseVisualStyleBackColor = true;
            this.ksiazki_btn.Click += new System.EventHandler(this.ksiazki_btn_Click);
            // 
            // rezerwacje_btn
            // 
            this.rezerwacje_btn.Location = new System.Drawing.Point(22, 374);
            this.rezerwacje_btn.Name = "rezerwacje_btn";
            this.rezerwacje_btn.Size = new System.Drawing.Size(130, 49);
            this.rezerwacje_btn.TabIndex = 4;
            this.rezerwacje_btn.Text = "Rezerwacje";
            this.rezerwacje_btn.UseVisualStyleBackColor = true;
            this.rezerwacje_btn.Click += new System.EventHandler(this.rezerwacje_btn_Click);
            // 
            // klienci_btn
            // 
            this.klienci_btn.Location = new System.Drawing.Point(22, 315);
            this.klienci_btn.Name = "klienci_btn";
            this.klienci_btn.Size = new System.Drawing.Size(130, 49);
            this.klienci_btn.TabIndex = 5;
            this.klienci_btn.Text = "Klienci";
            this.klienci_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nawigacja";
            // 
            // imie_textBox
            // 
            this.imie_textBox.Location = new System.Drawing.Point(194, 121);
            this.imie_textBox.Name = "imie_textBox";
            this.imie_textBox.Size = new System.Drawing.Size(249, 22);
            this.imie_textBox.TabIndex = 7;
            // 
            // imie_label
            // 
            this.imie_label.AutoSize = true;
            this.imie_label.Location = new System.Drawing.Point(191, 93);
            this.imie_label.Name = "imie_label";
            this.imie_label.Size = new System.Drawing.Size(32, 16);
            this.imie_label.TabIndex = 8;
            this.imie_label.Text = "Imie";
            // 
            // nazwisko_label
            // 
            this.nazwisko_label.AutoSize = true;
            this.nazwisko_label.Location = new System.Drawing.Point(191, 156);
            this.nazwisko_label.Name = "nazwisko_label";
            this.nazwisko_label.Size = new System.Drawing.Size(65, 16);
            this.nazwisko_label.TabIndex = 10;
            this.nazwisko_label.Text = "Nazwisko";
            // 
            // nazwisko_textBox
            // 
            this.nazwisko_textBox.Location = new System.Drawing.Point(194, 186);
            this.nazwisko_textBox.Name = "nazwisko_textBox";
            this.nazwisko_textBox.Size = new System.Drawing.Size(249, 22);
            this.nazwisko_textBox.TabIndex = 9;
            // 
            // kraj_label
            // 
            this.kraj_label.AutoSize = true;
            this.kraj_label.Location = new System.Drawing.Point(191, 226);
            this.kraj_label.Name = "kraj_label";
            this.kraj_label.Size = new System.Drawing.Size(30, 16);
            this.kraj_label.TabIndex = 12;
            this.kraj_label.Text = "Kraj";
            // 
            // kraj_textBox
            // 
            this.kraj_textBox.Location = new System.Drawing.Point(194, 256);
            this.kraj_textBox.Name = "kraj_textBox";
            this.kraj_textBox.Size = new System.Drawing.Size(249, 22);
            this.kraj_textBox.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(488, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 308);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.BackColor = System.Drawing.Color.Lime;
            this.dodaj_btn.Location = new System.Drawing.Point(194, 293);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(121, 30);
            this.dodaj_btn.TabIndex = 14;
            this.dodaj_btn.Text = "dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = false;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // usun_btn
            // 
            this.usun_btn.BackColor = System.Drawing.Color.Red;
            this.usun_btn.Location = new System.Drawing.Point(322, 293);
            this.usun_btn.Name = "usun_btn";
            this.usun_btn.Size = new System.Drawing.Size(121, 30);
            this.usun_btn.TabIndex = 15;
            this.usun_btn.Text = "usun";
            this.usun_btn.UseVisualStyleBackColor = false;
            this.usun_btn.Click += new System.EventHandler(this.usun_btn_Click);
            // 
            // edytuj_btn
            // 
            this.edytuj_btn.BackColor = System.Drawing.Color.Yellow;
            this.edytuj_btn.Location = new System.Drawing.Point(194, 329);
            this.edytuj_btn.Name = "edytuj_btn";
            this.edytuj_btn.Size = new System.Drawing.Size(121, 30);
            this.edytuj_btn.TabIndex = 16;
            this.edytuj_btn.Text = "edytuj";
            this.edytuj_btn.UseVisualStyleBackColor = false;
            this.edytuj_btn.Click += new System.EventHandler(this.edytuj_btn_Click);
            // 
            // wyczysc_btn
            // 
            this.wyczysc_btn.BackColor = System.Drawing.Color.Silver;
            this.wyczysc_btn.Location = new System.Drawing.Point(322, 329);
            this.wyczysc_btn.Name = "wyczysc_btn";
            this.wyczysc_btn.Size = new System.Drawing.Size(121, 30);
            this.wyczysc_btn.TabIndex = 17;
            this.wyczysc_btn.Text = "wyczysc";
            this.wyczysc_btn.UseVisualStyleBackColor = false;
            this.wyczysc_btn.Click += new System.EventHandler(this.wyczysc_btn_Click);
            // 
            // znajdz_autora_textBox
            // 
            this.znajdz_autora_textBox.Location = new System.Drawing.Point(665, 379);
            this.znajdz_autora_textBox.Name = "znajdz_autora_textBox";
            this.znajdz_autora_textBox.Size = new System.Drawing.Size(168, 22);
            this.znajdz_autora_textBox.TabIndex = 18;
            // 
            // znajdz_po_nazwisku_label
            // 
            this.znajdz_po_nazwisku_label.AutoSize = true;
            this.znajdz_po_nazwisku_label.Location = new System.Drawing.Point(485, 382);
            this.znajdz_po_nazwisku_label.Name = "znajdz_po_nazwisku_label";
            this.znajdz_po_nazwisku_label.Size = new System.Drawing.Size(164, 16);
            this.znajdz_po_nazwisku_label.TabIndex = 19;
            this.znajdz_po_nazwisku_label.Text = "Znajdz autora po nazwisku";
            // 
            // znajdz_btn
            // 
            this.znajdz_btn.Location = new System.Drawing.Point(845, 375);
            this.znajdz_btn.Name = "znajdz_btn";
            this.znajdz_btn.Size = new System.Drawing.Size(121, 30);
            this.znajdz_btn.TabIndex = 20;
            this.znajdz_btn.Text = "znajdz";
            this.znajdz_btn.UseVisualStyleBackColor = true;
            this.znajdz_btn.Click += new System.EventHandler(this.znajdz_btn_Click);
            // 
            // autorzy_btn
            // 
            this.autorzy_btn.BackColor = System.Drawing.Color.Lime;
            this.autorzy_btn.Location = new System.Drawing.Point(22, 193);
            this.autorzy_btn.Name = "autorzy_btn";
            this.autorzy_btn.Size = new System.Drawing.Size(130, 49);
            this.autorzy_btn.TabIndex = 21;
            this.autorzy_btn.Text = "Autorzy";
            this.autorzy_btn.UseVisualStyleBackColor = false;
            this.autorzy_btn.Click += new System.EventHandler(this.autorzy_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Wybierz kraj pochodzenia";
            // 
            // comboBoxKraj
            // 
            this.comboBoxKraj.FormattingEnabled = true;
            this.comboBoxKraj.Location = new System.Drawing.Point(665, 420);
            this.comboBoxKraj.Name = "comboBoxKraj";
            this.comboBoxKraj.Size = new System.Drawing.Size(168, 24);
            this.comboBoxKraj.TabIndex = 23;
            // 
            // kraj_btn
            // 
            this.kraj_btn.Location = new System.Drawing.Point(845, 416);
            this.kraj_btn.Name = "kraj_btn";
            this.kraj_btn.Size = new System.Drawing.Size(121, 30);
            this.kraj_btn.TabIndex = 24;
            this.kraj_btn.Text = "znajdz";
            this.kraj_btn.UseVisualStyleBackColor = true;
            this.kraj_btn.Click += new System.EventHandler(this.kraj_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 599);
            this.Controls.Add(this.kraj_btn);
            this.Controls.Add(this.comboBoxKraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autorzy_btn);
            this.Controls.Add(this.znajdz_btn);
            this.Controls.Add(this.znajdz_po_nazwisku_label);
            this.Controls.Add(this.znajdz_autora_textBox);
            this.Controls.Add(this.wyczysc_btn);
            this.Controls.Add(this.edytuj_btn);
            this.Controls.Add(this.usun_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kraj_label);
            this.Controls.Add(this.kraj_textBox);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_author_label;
        private System.Windows.Forms.Button okno_startowe_btn;
        private System.Windows.Forms.Button ksiazki_btn;
        private System.Windows.Forms.Button rezerwacje_btn;
        private System.Windows.Forms.Button klienci_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imie_textBox;
        private System.Windows.Forms.Label imie_label;
        private System.Windows.Forms.Label nazwisko_label;
        private System.Windows.Forms.TextBox nazwisko_textBox;
        private System.Windows.Forms.Label kraj_label;
        private System.Windows.Forms.TextBox kraj_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button usun_btn;
        private System.Windows.Forms.Button edytuj_btn;
        private System.Windows.Forms.Button wyczysc_btn;
        private System.Windows.Forms.TextBox znajdz_autora_textBox;
        private System.Windows.Forms.Label znajdz_po_nazwisku_label;
        private System.Windows.Forms.Button znajdz_btn;
        private System.Windows.Forms.Button autorzy_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKraj;
        private System.Windows.Forms.Button kraj_btn;
    }
}