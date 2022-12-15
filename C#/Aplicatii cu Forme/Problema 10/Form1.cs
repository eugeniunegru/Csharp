using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_10
{
    public partial class Form1 : Form
    {
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Logare";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            string parola = textBox2.Text;
            Form2 f = new Form2();
            if ((nume == "Georgeta") && (parola == "ciorba98")) { this.Hide(); f.Show(); }
            else { if (k <= 1) { k++; MessageBox.Show(this, "Gresit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error); } else this.Close(); }
           
        }
    }
}
