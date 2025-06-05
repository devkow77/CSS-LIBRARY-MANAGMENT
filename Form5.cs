using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaProjekt
{
    public partial class Form5: Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void okno_startowe_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void autorzy_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void ksiazki_btn_Click(object sender, EventArgs e)
        {
            Form3 form3
                = new Form3();
            form3.Show();
            this.Hide();

        }

        private void klienci_btn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
