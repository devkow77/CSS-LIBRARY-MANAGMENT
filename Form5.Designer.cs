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
            this.SuspendLayout();
            // 
            // autorzy_btn
            // 
            this.autorzy_btn.BackColor = System.Drawing.Color.White;
            this.autorzy_btn.Location = new System.Drawing.Point(24, 154);
            this.autorzy_btn.Name = "autorzy_btn";
            this.autorzy_btn.Size = new System.Drawing.Size(130, 49);
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
            this.klienci_btn.Name = "klienci_btn";
            this.klienci_btn.Size = new System.Drawing.Size(130, 49);
            this.klienci_btn.TabIndex = 53;
            this.klienci_btn.Text = "Klienci";
            this.klienci_btn.UseVisualStyleBackColor = false;
            this.klienci_btn.Click += new System.EventHandler(this.klienci_btn_Click);
            // 
            // rezerwacje_btn
            // 
            this.rezerwacje_btn.BackColor = System.Drawing.Color.Lime;
            this.rezerwacje_btn.Location = new System.Drawing.Point(24, 335);
            this.rezerwacje_btn.Name = "rezerwacje_btn";
            this.rezerwacje_btn.Size = new System.Drawing.Size(130, 49);
            this.rezerwacje_btn.TabIndex = 52;
            this.rezerwacje_btn.Text = "Rezerwacje";
            this.rezerwacje_btn.UseVisualStyleBackColor = false;
            // 
            // ksiazki_btn
            // 
            this.ksiazki_btn.Location = new System.Drawing.Point(24, 217);
            this.ksiazki_btn.Name = "ksiazki_btn";
            this.ksiazki_btn.Size = new System.Drawing.Size(130, 49);
            this.ksiazki_btn.TabIndex = 51;
            this.ksiazki_btn.Text = "Ksiazki";
            this.ksiazki_btn.UseVisualStyleBackColor = true;
            this.ksiazki_btn.Click += new System.EventHandler(this.ksiazki_btn_Click);
            // 
            // okno_startowe_btn
            // 
            this.okno_startowe_btn.Location = new System.Drawing.Point(24, 94);
            this.okno_startowe_btn.Name = "okno_startowe_btn";
            this.okno_startowe_btn.Size = new System.Drawing.Size(130, 49);
            this.okno_startowe_btn.TabIndex = 50;
            this.okno_startowe_btn.Text = "Okno startowe";
            this.okno_startowe_btn.UseVisualStyleBackColor = true;
            this.okno_startowe_btn.Click += new System.EventHandler(this.okno_startowe_btn_Click);
            // 
            // add_author_label
            // 
            this.add_author_label.AutoSize = true;
            this.add_author_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_author_label.Location = new System.Drawing.Point(265, 54);
            this.add_author_label.Name = "add_author_label";
            this.add_author_label.Size = new System.Drawing.Size(163, 25);
            this.add_author_label.TabIndex = 49;
            this.add_author_label.Text = "Rezerwuj ksiazke";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 590);
            this.Controls.Add(this.autorzy_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klienci_btn);
            this.Controls.Add(this.rezerwacje_btn);
            this.Controls.Add(this.ksiazki_btn);
            this.Controls.Add(this.okno_startowe_btn);
            this.Controls.Add(this.add_author_label);
            this.Name = "Form5";
            this.Text = "Form5";
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
    }
}