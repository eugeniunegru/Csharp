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
        double cost;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            string nuime = textBox1.Text;
            string prenume = textBox2.Text;
            string datanasterii = textBox3.Text;
            string cnp = textBox4.Text;
            string nr_telefon = textBox5.Text;
            double zile = Convert.ToDouble(textBox6.Text);
            label7.Text+="Nume : "+nuime+"\n\n";
            label7.Text+="Prenume : "+prenume+"\n\n";
            label7.Text+="Data nasterii : "+datanasterii+"\n\n";
            label7.Text+="CNP : "+cnp+"\n\n";
            label7.Text+="Nr telefon : "+nr_telefon+"\n\n";
            label7.Text+="Perioada : "+zile+"\n\n";
            

            if (radioButton1.Checked == true)
            {label7.Text += "Abonament : Econom \n\n";
            cost = zile * 200;
            }
            else if (radioButton2.Checked == true)
            {
                label7.Text += "Abonament : Clasic \n\n";
                cost= zile * 350;
            }
            else if (radioButton3.Checked == true)
            {
                label7.Text += "Abonament : Lux \n\n";
                cost = zile * 500;
            }

            if (zile >= 4 && zile < 7)
            {
                cost = cost - cost * 0.03;
                label7.Text += "Cost : " + cost + " lei\n\n";
            }
            else if (zile >= 8 && zile <= 14)
            {
                cost = cost - cost * 0.07;
                label7.Text += "Cost : " + cost + " lei\n\n";
            }
            else if (zile >= 15 && zile <= 30)
            {
                cost = cost - cost * 0.1;
                label7.Text += "Cost : " + cost + " lei\n\n";
            }
            else if (zile > 30)
            {
                cost = cost - cost * 0.15;
                label7.Text += "Cost : " + cost + " lei\n\n";
            }
            else
            {
                label7.Text += "Cost : " + cost + " lei\n\n";
            }
        }
    }
}
