using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Text += "Costul convorbirii : " + Convert.ToDouble(textBox1.Text) * 0.75 + "lei\n\n";

            }
            else if (radioButton2.Checked == true)
            {
                label2.Text += "Costul convorbirii : " + Convert.ToDouble(textBox1.Text) * 1.76 + "lei\n\n";

            }
            else if (radioButton3.Checked == true)
            {
                label2.Text += "Costul convorbirii : " + Convert.ToDouble(textBox1.Text) * 2.5 + "lei\n\n";

            }
        }
    }
}
