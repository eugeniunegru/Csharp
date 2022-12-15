using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pret, consum, distanta;
            pret = Convert.ToDouble(textBox1.Text);
            consum = Convert.ToDouble(textBox2.Text);
            distanta = Convert.ToDouble(textBox3.Text);
            label4.Text += "Pret pentru 1 litru : " + pret + "lei\n\n";
            label4.Text += "Consum pt 100 km : " + consum + "litri\n\n";
            label4.Text += "Distanta  : " + distanta + "km\n\n";
            double cost1km = consum / 100 * pret;
            label4.Text += "Costul : " + cost1km*distanta + "lei\n\n";
        }
    }
}
