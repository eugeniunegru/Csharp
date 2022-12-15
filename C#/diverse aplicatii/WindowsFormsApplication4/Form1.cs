using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label3.Text += " Cantitatea : " + textBox2.Text+" m3\n\n";
            label3.Text += " Pret/m3 : " + textBox1.Text + " lei\n\n";
            label3.Text += " Plata : " + Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox1.Text) + " lei\n\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double plata=Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox1.Text)+Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox4.Text)+
                Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text)+Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox8.Text);
            label13.Text = "";
            label13.Text += "Plata : " + plata + " lei\n\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            label10.Text += " Cantitatea : " + textBox8.Text + " m3\n\n";
            label10.Text += " Pret/m3 : " + textBox7.Text + " lei\n\n";
            label10.Text += " Plata : " + Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox8.Text) + " lei\n\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            label7.Text += " Cantitatea : " + textBox6.Text + " m3\n\n";
            label7.Text += " Pret/m3 : " + textBox5.Text + " lei\n\n";
            label7.Text += " Plata : " + Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text) + " lei\n\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label4.Text += " Cantitatea : " + textBox4.Text + " m3\n\n";
            label4.Text += " Pret/m3 : " + textBox3.Text + " lei\n\n";
            label4.Text += " Plata : " + Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox4.Text) + " lei\n\n";
        }
    }
}
