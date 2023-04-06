using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked == true) label1.Text = Convert.ToString(a * 1000);
            if (radioButton2.Checked == true) label1.Text = Convert.ToString(a * 10);
            if (radioButton3.Checked == true) label1.Text = Convert.ToString(a * 100);
            if (radioButton4.Checked == true) label1.Text = Convert.ToString(a / 1000);
            if (radioButton5.Checked == true) label2.Text = Convert.ToString(a * 1000);
            if (radioButton6.Checked == true) label2.Text = Convert.ToString(a / 1000);
            if (radioButton7.Checked == true) label2.Text = Convert.ToString(a / 1000000);
            if (radioButton8.Checked == true) label2.Text = Convert.ToString(a *100);
            if (radioButton9.Checked == true) label3.Text = Convert.ToString(a * 0.00595238095);
            if (radioButton10.Checked == true) label3.Text = Convert.ToString(a * 0.0416666667);
            if (radioButton11.Checked == true) label3.Text = Convert.ToString(a * 60);
            if (radioButton12.Checked == true) label3.Text = Convert.ToString(a * 3600);

        }
    }
}
