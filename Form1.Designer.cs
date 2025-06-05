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
            this.title = new System.Windows.Forms.Label();
            this.ksiazki_btn = new System.Windows.Forms.Button();
            this.klienci_btn = new System.Windows.Forms.Button();
            this.rezerwacje_btn = new System.Windows.Forms.Button();
            this.autorzy_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(209, 59);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(371, 29);
            this.title.TabIndex = 21;
            this.title.Text = "System zarządzania bliblioteką";
            // 
            // ksiazki_btn
            // 
            this.ksiazki_btn.BackColor = System.Drawing.Color.White;
            this.ksiazki_btn.Location = new System.Drawing.Point(214, 171);
            this.ksiazki_btn.Name = "ksiazki_btn";
            this.ksiazki_btn.Size = new System.Drawing.Size(366, 49);
            this.ksiazki_btn.TabIndex = 48;
            this.ksiazki_btn.Text = "Ksiazki";
            this.ksiazki_btn.UseVisualStyleBackColor = false;
            this.ksiazki_btn.Click += new System.EventHandler(this.ksiazki_btn_Click);
            // 
            // klienci_btn
            // 
            this.klienci_btn.Location = new System.Drawing.Point(214, 239);
            this.klienci_btn.Name = "klienci_btn";
            this.klienci_btn.Size = new System.Drawing.Size(366, 49);
            this.klienci_btn.TabIndex = 47;
            this.klienci_btn.Text = "Klienci";
            this.klienci_btn.UseVisualStyleBackColor = true;
            this.klienci_btn.Click += new System.EventHandler(this.klienci_btn_Click);
            // 
            // rezerwacje_btn
            // 
            this.rezerwacje_btn.Location = new System.Drawing.Point(214, 298);
            this.rezerwacje_btn.Name = "rezerwacje_btn";
            this.rezerwacje_btn.Size = new System.Drawing.Size(366, 49);
            this.rezerwacje_btn.TabIndex = 46;
            this.rezerwacje_btn.Text = "Rezerwacje";
            this.rezerwacje_btn.UseVisualStyleBackColor = true;
            this.rezerwacje_btn.Click += new System.EventHandler(this.rezerwacje_btn_Click);
            // 
            // autorzy_btn
            // 
            this.autorzy_btn.Location = new System.Drawing.Point(214, 108);
            this.autorzy_btn.Name = "autorzy_btn";
            this.autorzy_btn.Size = new System.Drawing.Size(366, 49);
            this.autorzy_btn.TabIndex = 45;
            this.autorzy_btn.Text = "Autorzy";
            this.autorzy_btn.UseVisualStyleBackColor = true;
            this.autorzy_btn.Click += new System.EventHandler(this.autorzy_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 415);
            this.Controls.Add(this.ksiazki_btn);
            this.Controls.Add(this.klienci_btn);
            this.Controls.Add(this.rezerwacje_btn);
            this.Controls.Add(this.autorzy_btn);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button ksiazki_btn;
        private System.Windows.Forms.Button klienci_btn;
        private System.Windows.Forms.Button rezerwacje_btn;
        private System.Windows.Forms.Button autorzy_btn;
    }
}

