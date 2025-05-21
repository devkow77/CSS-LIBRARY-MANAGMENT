namespace BibliotekaProjekt
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.imie_label = new System.Windows.Forms.Label();
            this.imie_textBox = new System.Windows.Forms.TextBox();
            this.nazwisko_label = new System.Windows.Forms.Label();
            this.nazwisko_textBox = new System.Windows.Forms.TextBox();
            this.autorzy_header = new System.Windows.Forms.Label();
            this.ksiazki_header = new System.Windows.Forms.Label();
            this.idAutora_label = new System.Windows.Forms.Label();
            this.tytul_textBox = new System.Windows.Forms.TextBox();
            this.tytul_label = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.biblioteka_header = new System.Windows.Forms.Label();
            this.dodaj_autora_btn = new System.Windows.Forms.Button();
            this.wyczysc_autora_btn = new System.Windows.Forms.Button();
            this.wyczysc_ksiazke_btn = new System.Windows.Forms.Button();
            this.dodaj_ksiazke_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.idAutora_textBox = new System.Windows.Forms.NumericUpDown();
            this.edytuj_autora_btn = new System.Windows.Forms.Button();
            this.edytuj_ksiazke_btn = new System.Windows.Forms.Button();
            this.usun_autora_btn = new System.Windows.Forms.Button();
            this.usun_ksiazke_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idAutora_textBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 557);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1099, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(533, 232);
            this.dataGridView2.TabIndex = 2;
            // 
            // imie_label
            // 
            this.imie_label.AutoSize = true;
            this.imie_label.Location = new System.Drawing.Point(18, 75);
            this.imie_label.Name = "imie_label";
            this.imie_label.Size = new System.Drawing.Size(32, 16);
            this.imie_label.TabIndex = 4;
            this.imie_label.Text = "Imie";
            // 
            // imie_textBox
            // 
            this.imie_textBox.Location = new System.Drawing.Point(21, 94);
            this.imie_textBox.Name = "imie_textBox";
            this.imie_textBox.Size = new System.Drawing.Size(177, 22);
            this.imie_textBox.TabIndex = 5;
            // 
            // nazwisko_label
            // 
            this.nazwisko_label.AutoSize = true;
            this.nazwisko_label.Location = new System.Drawing.Point(18, 135);
            this.nazwisko_label.Name = "nazwisko_label";
            this.nazwisko_label.Size = new System.Drawing.Size(65, 16);
            this.nazwisko_label.TabIndex = 7;
            this.nazwisko_label.Text = "Nazwisko";
            // 
            // nazwisko_textBox
            // 
            this.nazwisko_textBox.Location = new System.Drawing.Point(21, 154);
            this.nazwisko_textBox.Name = "nazwisko_textBox";
            this.nazwisko_textBox.Size = new System.Drawing.Size(177, 22);
            this.nazwisko_textBox.TabIndex = 8;
            // 
            // autorzy_header
            // 
            this.autorzy_header.AutoSize = true;
            this.autorzy_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autorzy_header.Location = new System.Drawing.Point(16, 199);
            this.autorzy_header.Name = "autorzy_header";
            this.autorzy_header.Size = new System.Drawing.Size(79, 25);
            this.autorzy_header.TabIndex = 9;
            this.autorzy_header.Text = "Autorzy";
            // 
            // ksiazki_header
            // 
            this.ksiazki_header.AutoSize = true;
            this.ksiazki_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ksiazki_header.Location = new System.Drawing.Point(582, 199);
            this.ksiazki_header.Name = "ksiazki_header";
            this.ksiazki_header.Size = new System.Drawing.Size(75, 25);
            this.ksiazki_header.TabIndex = 15;
            this.ksiazki_header.Text = "Książki";
            // 
            // idAutora_label
            // 
            this.idAutora_label.AutoSize = true;
            this.idAutora_label.Location = new System.Drawing.Point(584, 135);
            this.idAutora_label.Name = "idAutora_label";
            this.idAutora_label.Size = new System.Drawing.Size(59, 16);
            this.idAutora_label.TabIndex = 13;
            this.idAutora_label.Text = "Id autora";
            // 
            // tytul_textBox
            // 
            this.tytul_textBox.Location = new System.Drawing.Point(587, 94);
            this.tytul_textBox.Name = "tytul_textBox";
            this.tytul_textBox.Size = new System.Drawing.Size(177, 22);
            this.tytul_textBox.TabIndex = 12;
            // 
            // tytul_label
            // 
            this.tytul_label.AutoSize = true;
            this.tytul_label.Location = new System.Drawing.Point(584, 75);
            this.tytul_label.Name = "tytul_label";
            this.tytul_label.Size = new System.Drawing.Size(36, 16);
            this.tytul_label.TabIndex = 11;
            this.tytul_label.Text = "Tytul";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(587, 244);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(533, 232);
            this.dataGridView3.TabIndex = 10;
            // 
            // biblioteka_header
            // 
            this.biblioteka_header.AutoSize = true;
            this.biblioteka_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.biblioteka_header.Location = new System.Drawing.Point(535, 507);
            this.biblioteka_header.Name = "biblioteka_header";
            this.biblioteka_header.Size = new System.Drawing.Size(96, 25);
            this.biblioteka_header.TabIndex = 16;
            this.biblioteka_header.Text = "Biblioteka";
            // 
            // dodaj_autora_btn
            // 
            this.dodaj_autora_btn.BackColor = System.Drawing.Color.Lime;
            this.dodaj_autora_btn.Location = new System.Drawing.Point(223, 108);
            this.dodaj_autora_btn.Name = "dodaj_autora_btn";
            this.dodaj_autora_btn.Size = new System.Drawing.Size(112, 32);
            this.dodaj_autora_btn.TabIndex = 17;
            this.dodaj_autora_btn.Text = "dodaj";
            this.dodaj_autora_btn.UseVisualStyleBackColor = false;
            this.dodaj_autora_btn.Click += new System.EventHandler(this.dodaj_autora_btn_Click);
            // 
            // wyczysc_autora_btn
            // 
            this.wyczysc_autora_btn.BackColor = System.Drawing.Color.Silver;
            this.wyczysc_autora_btn.Location = new System.Drawing.Point(348, 108);
            this.wyczysc_autora_btn.Name = "wyczysc_autora_btn";
            this.wyczysc_autora_btn.Size = new System.Drawing.Size(112, 32);
            this.wyczysc_autora_btn.TabIndex = 18;
            this.wyczysc_autora_btn.Text = "wyczyść";
            this.wyczysc_autora_btn.UseVisualStyleBackColor = false;
            this.wyczysc_autora_btn.Click += new System.EventHandler(this.wyczysc_autora_btn_Click);
            // 
            // wyczysc_ksiazke_btn
            // 
            this.wyczysc_ksiazke_btn.BackColor = System.Drawing.Color.Silver;
            this.wyczysc_ksiazke_btn.Location = new System.Drawing.Point(912, 108);
            this.wyczysc_ksiazke_btn.Name = "wyczysc_ksiazke_btn";
            this.wyczysc_ksiazke_btn.Size = new System.Drawing.Size(112, 32);
            this.wyczysc_ksiazke_btn.TabIndex = 20;
            this.wyczysc_ksiazke_btn.Text = "wyczyść";
            this.wyczysc_ksiazke_btn.UseVisualStyleBackColor = false;
            this.wyczysc_ksiazke_btn.Click += new System.EventHandler(this.wyczysc_ksiazke_btn_Click);
            // 
            // dodaj_ksiazke_btn
            // 
            this.dodaj_ksiazke_btn.BackColor = System.Drawing.Color.Lime;
            this.dodaj_ksiazke_btn.Location = new System.Drawing.Point(787, 108);
            this.dodaj_ksiazke_btn.Name = "dodaj_ksiazke_btn";
            this.dodaj_ksiazke_btn.Size = new System.Drawing.Size(112, 32);
            this.dodaj_ksiazke_btn.TabIndex = 19;
            this.dodaj_ksiazke_btn.Text = "dodaj";
            this.dodaj_ksiazke_btn.UseVisualStyleBackColor = false;
            this.dodaj_ksiazke_btn.Click += new System.EventHandler(this.dodaj_ksiazke_btn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(356, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(436, 32);
            this.title.TabIndex = 21;
            this.title.Text = "System zarządzania bliblioteką";
            // 
            // idAutora_textBox
            // 
            this.idAutora_textBox.Location = new System.Drawing.Point(587, 159);
            this.idAutora_textBox.Name = "idAutora_textBox";
            this.idAutora_textBox.Size = new System.Drawing.Size(177, 22);
            this.idAutora_textBox.TabIndex = 22;
            // 
            // edytuj_autora_btn
            // 
            this.edytuj_autora_btn.BackColor = System.Drawing.Color.Yellow;
            this.edytuj_autora_btn.Location = new System.Drawing.Point(223, 146);
            this.edytuj_autora_btn.Name = "edytuj_autora_btn";
            this.edytuj_autora_btn.Size = new System.Drawing.Size(112, 32);
            this.edytuj_autora_btn.TabIndex = 23;
            this.edytuj_autora_btn.Text = "edytuj";
            this.edytuj_autora_btn.UseVisualStyleBackColor = false;
            this.edytuj_autora_btn.Click += new System.EventHandler(this.edytuj_autora_btn_Click);
            // 
            // edytuj_ksiazke_btn
            // 
            this.edytuj_ksiazke_btn.BackColor = System.Drawing.Color.Yellow;
            this.edytuj_ksiazke_btn.Location = new System.Drawing.Point(787, 149);
            this.edytuj_ksiazke_btn.Name = "edytuj_ksiazke_btn";
            this.edytuj_ksiazke_btn.Size = new System.Drawing.Size(112, 32);
            this.edytuj_ksiazke_btn.TabIndex = 24;
            this.edytuj_ksiazke_btn.Text = "edytuj";
            this.edytuj_ksiazke_btn.UseVisualStyleBackColor = false;
            this.edytuj_ksiazke_btn.Click += new System.EventHandler(this.edytuj_ksiazke_btn_Click);
            // 
            // usun_autora_btn
            // 
            this.usun_autora_btn.BackColor = System.Drawing.Color.Red;
            this.usun_autora_btn.Location = new System.Drawing.Point(348, 146);
            this.usun_autora_btn.Name = "usun_autora_btn";
            this.usun_autora_btn.Size = new System.Drawing.Size(112, 32);
            this.usun_autora_btn.TabIndex = 25;
            this.usun_autora_btn.Text = "usuń";
            this.usun_autora_btn.UseVisualStyleBackColor = false;
            this.usun_autora_btn.Click += new System.EventHandler(this.usun_autora_btn_Click);
            // 
            // usun_ksiazke_btn
            // 
            this.usun_ksiazke_btn.BackColor = System.Drawing.Color.Red;
            this.usun_ksiazke_btn.Location = new System.Drawing.Point(912, 149);
            this.usun_ksiazke_btn.Name = "usun_ksiazke_btn";
            this.usun_ksiazke_btn.Size = new System.Drawing.Size(112, 32);
            this.usun_ksiazke_btn.TabIndex = 26;
            this.usun_ksiazke_btn.Text = "usuń";
            this.usun_ksiazke_btn.UseVisualStyleBackColor = false;
            this.usun_ksiazke_btn.Click += new System.EventHandler(this.usun_ksiazke_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 814);
            this.Controls.Add(this.usun_ksiazke_btn);
            this.Controls.Add(this.usun_autora_btn);
            this.Controls.Add(this.edytuj_ksiazke_btn);
            this.Controls.Add(this.edytuj_autora_btn);
            this.Controls.Add(this.idAutora_textBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.wyczysc_ksiazke_btn);
            this.Controls.Add(this.dodaj_ksiazke_btn);
            this.Controls.Add(this.wyczysc_autora_btn);
            this.Controls.Add(this.dodaj_autora_btn);
            this.Controls.Add(this.biblioteka_header);
            this.Controls.Add(this.ksiazki_header);
            this.Controls.Add(this.idAutora_label);
            this.Controls.Add(this.tytul_textBox);
            this.Controls.Add(this.tytul_label);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.autorzy_header);
            this.Controls.Add(this.nazwisko_textBox);
            this.Controls.Add(this.nazwisko_label);
            this.Controls.Add(this.imie_textBox);
            this.Controls.Add(this.imie_label);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idAutora_textBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label imie_label;
        private System.Windows.Forms.TextBox imie_textBox;
        private System.Windows.Forms.Label nazwisko_label;
        private System.Windows.Forms.TextBox nazwisko_textBox;
        private System.Windows.Forms.Label autorzy_header;
        private System.Windows.Forms.Label ksiazki_header;
        private System.Windows.Forms.Label idAutora_label;
        private System.Windows.Forms.TextBox tytul_textBox;
        private System.Windows.Forms.Label tytul_label;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label biblioteka_header;
        private System.Windows.Forms.Button dodaj_autora_btn;
        private System.Windows.Forms.Button wyczysc_autora_btn;
        private System.Windows.Forms.Button wyczysc_ksiazke_btn;
        private System.Windows.Forms.Button dodaj_ksiazke_btn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.NumericUpDown idAutora_textBox;
        private System.Windows.Forms.Button edytuj_autora_btn;
        private System.Windows.Forms.Button edytuj_ksiazke_btn;
        private System.Windows.Forms.Button usun_autora_btn;
        private System.Windows.Forms.Button usun_ksiazke_btn;
    }
}

