using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titlu = textBox1.Text;
            int lung = Convert.ToInt32(textBox2.Text);
            int lat = Convert.ToInt32(textBox3.Text);
            int top = Convert.ToInt32(textBox4.Text);
            int left = Convert.ToInt32(textBox5.Text);

            Form2 f = new Form2();
            f.Owner = this;
            f.Text = titlu;
            f.Width = lung;
            f.Height = lat;
            f.Top = top;
            f.Left = left;
            f.Show();
            this.Hide();
        }
    }
}
