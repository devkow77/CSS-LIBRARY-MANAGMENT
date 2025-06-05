namespace BibliotekaProjekt
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.klienci_btn = new System.Windows.Forms.Button();
            this.rezerwacje_btn = new System.Windows.Forms.Button();
            this.ksiazki_btn = new System.Windows.Forms.Button();
            this.okno_startowe_btn = new System.Windows.Forms.Button();
            this.add_author_label = new System.Windows.Forms.Label();
            this.znajdz_btn = new System.Windows.Forms.Button();
            this.znajdz_po_peselu_label = new System.Windows.Forms.Label();
            this.znajdz_autora_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.znajdz_po_nazwisku_label = new System.Windows.Forms.Label();
            this.znajdz_ksiazke_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rezerwuj_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // autorzy_btn
            // 
            this.autorzy_btn.BackColor = System.Drawing.Color.White;
            this.autorzy_btn.Location = new System.Drawing.Point(24, 154);
            this.autorzy_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorzy_btn.Name = "autorzy_btn";
            this.autorzy_btn.Size = new System.Drawing.Size(131, 49);
            this.autorzy_btn.TabIndex = 69;
            this.autorzy_btn.Text = "Autorzy";
            this.autorzy_btn.UseVisualStyleBackColor = false;
            this.autorzy_btn.Click += new System.EventHandler(this.autorzy_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nawigacja";
            // 
            // klienci_btn
            // 
            this.klienci_btn.BackColor = System.Drawing.Color.White;
            this.klienci_btn.Location = new System.Drawing.Point(24, 276);
            this.klienci_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klienci_btn.Name = "klienci_btn";
            this.klienci_btn.Size = new System.Drawing.Size(131, 49);
            this.klienci_btn.TabIndex = 53;
            this.klienci_btn.Text = "Klienci";
            this.klienci_btn.UseVisualStyleBackColor = false;
            this.klienci_btn.Click += new System.EventHandler(this.klienci_btn_Click);
            // 
            // rezerwacje_btn
            // 
            this.rezerwacje_btn.BackColor = System.Drawing.Color.Lime;
            this.rezerwacje_btn.Location = new System.Drawing.Point(24, 335);
            this.rezerwacje_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezerwacje_btn.Name = "rezerwacje_btn";
            this.rezerwacje_btn.Size = new System.Drawing.Size(131, 49);
            this.rezerwacje_btn.TabIndex = 52;
            this.rezerwacje_btn.Text = "Rezerwacje";
            this.rezerwacje_btn.UseVisualStyleBackColor = false;
            // 
            // ksiazki_btn
            // 
            this.ksiazki_btn.Location = new System.Drawing.Point(24, 217);
            this.ksiazki_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ksiazki_btn.Name = "ksiazki_btn";
            this.ksiazki_btn.Size = new System.Drawing.Size(131, 49);
            this.ksiazki_btn.TabIndex = 51;
            this.ksiazki_btn.Text = "Ksiazki";
            this.ksiazki_btn.UseVisualStyleBackColor = true;
            this.ksiazki_btn.Click += new System.EventHandler(this.ksiazki_btn_Click);
            // 
            // okno_startowe_btn
            // 
            this.okno_startowe_btn.Location = new System.Drawing.Point(24, 94);
            this.okno_startowe_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okno_startowe_btn.Name = "okno_startowe_btn";
            this.okno_startowe_btn.Size = new System.Drawing.Size(131, 49);
            this.okno_startowe_btn.TabIndex = 50;
            this.okno_startowe_btn.Text = "Okno startowe";
            this.okno_startowe_btn.UseVisualStyleBackColor = true;
            this.okno_startowe_btn.Click += new System.EventHandler(this.okno_startowe_btn_Click);
            // 
            // add_author_label
            // 
            this.add_author_label.AutoSize = true;
            this.add_author_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_author_label.Location = new System.Drawing.Point(192, 54);
            this.add_author_label.Name = "add_author_label";
            this.add_author_label.Size = new System.Drawing.Size(163, 25);
            this.add_author_label.TabIndex = 49;
            this.add_author_label.Text = "Rezerwuj ksiazke";
            // 
            // znajdz_btn
            // 
            this.znajdz_btn.Location = new System.Drawing.Point(554, 105);
            this.znajdz_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.znajdz_btn.Name = "znajdz_btn";
            this.znajdz_btn.Size = new System.Drawing.Size(121, 30);
            this.znajdz_btn.TabIndex = 72;
            this.znajdz_btn.Text = "znajdz";
            this.znajdz_btn.UseVisualStyleBackColor = true;
            this.znajdz_btn.Click += new System.EventHandler(this.znajdz_btn_Click);
            // 
            // znajdz_po_peselu_label
            // 
            this.znajdz_po_peselu_label.AutoSize = true;
            this.znajdz_po_peselu_label.Location = new System.Drawing.Point(194, 111);
            this.znajdz_po_peselu_label.Name = "znajdz_po_peselu_label";
            this.znajdz_po_peselu_label.Size = new System.Drawing.Size(152, 16);
            this.znajdz_po_peselu_label.TabIndex = 71;
            this.znajdz_po_peselu_label.Text = "Znajdz klienta po peselu";
            // 
            // znajdz_autora_textBox
            // 
            this.znajdz_autora_textBox.Location = new System.Drawing.Point(374, 108);
            this.znajdz_autora_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.znajdz_autora_textBox.Name = "znajdz_autora_textBox";
            this.znajdz_autora_textBox.Size = new System.Drawing.Size(168, 22);
            this.znajdz_autora_textBox.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 75;
            this.button1.Text = "znajdz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // znajdz_po_nazwisku_label
            // 
            this.znajdz_po_nazwisku_label.AutoSize = true;
            this.znajdz_po_nazwisku_label.Location = new System.Drawing.Point(194, 154);
            this.znajdz_po_nazwisku_label.Name = "znajdz_po_nazwisku_label";
            this.znajdz_po_nazwisku_label.Size = new System.Drawing.Size(149, 16);
            this.znajdz_po_nazwisku_label.TabIndex = 74;
            this.znajdz_po_nazwisku_label.Text = "Znajdz ksiazke po tytule";
            // 
            // znajdz_ksiazke_textBox
            // 
            this.znajdz_ksiazke_textBox.Location = new System.Drawing.Point(375, 151);
            this.znajdz_ksiazke_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.znajdz_ksiazke_textBox.Name = "znajdz_ksiazke_textBox";
            this.znajdz_ksiazke_textBox.Size = new System.Drawing.Size(168, 22);
            this.znajdz_ksiazke_textBox.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Termin oddania ksiazki";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 209);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // rezerwuj_btn
            // 
            this.rezerwuj_btn.Location = new System.Drawing.Point(197, 276);
            this.rezerwuj_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rezerwuj_btn.Name = "rezerwuj_btn";
            this.rezerwuj_btn.Size = new System.Drawing.Size(159, 28);
            this.rezerwuj_btn.TabIndex = 78;
            this.rezerwuj_btn.Text = "rezerwuj";
            this.rezerwuj_btn.UseVisualStyleBackColor = true;
            this.rezerwuj_btn.Click += new System.EventHandler(this.rezerwuj_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(696, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 98);
            this.dataGridView1.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(691, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Klient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(691, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "Mozliwe ksiazki do wypozyczenia";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(696, 292);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1151, 384);
            this.dataGridView2.TabIndex = 81;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1861, 705);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rezerwuj_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.znajdz_po_nazwisku_label);
            this.Controls.Add(this.znajdz_ksiazke_textBox);
            this.Controls.Add(this.znajdz_btn);
            this.Controls.Add(this.znajdz_po_peselu_label);
            this.Controls.Add(this.znajdz_autora_textBox);
            this.Controls.Add(this.autorzy_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klienci_btn);
            this.Controls.Add(this.rezerwacje_btn);
            this.Controls.Add(this.ksiazki_btn);
            this.Controls.Add(this.okno_startowe_btn);
            this.Controls.Add(this.add_author_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button autorzy_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button klienci_btn;
        private System.Windows.Forms.Button rezerwacje_btn;
        private System.Windows.Forms.Button ksiazki_btn;
        private System.Windows.Forms.Button okno_startowe_btn;
        private System.Windows.Forms.Label add_author_label;
        private System.Windows.Forms.Button znajdz_btn;
        private System.Windows.Forms.Label znajdz_po_peselu_label;
        private System.Windows.Forms.TextBox znajdz_autora_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label znajdz_po_nazwisku_label;
        private System.Windows.Forms.TextBox znajdz_ksiazke_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button rezerwuj_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}