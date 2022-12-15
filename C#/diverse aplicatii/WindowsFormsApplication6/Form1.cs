using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        double suma = 0;
        public double[] preturi =new double[30];
        
        public int n = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Items[comboBox1.SelectedIndex]);
            if (textBox1.Text != "") suma += (Convert.ToDouble(textBox1.Text) / 1000) * preturi[comboBox1.SelectedIndex];
            else suma += 0;
           // MessageBox.Show(Convert.ToString( comboBox1.SelectedIndex));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "suma totala= " + suma;
        }

        private void excludeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>-1) listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
           //MessageBox.Show("hkg");
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void excludeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1) comboBox1.Items.Remove(comboBox1.Items[comboBox1.SelectedIndex]);
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            preturi[0]= 15;
            preturi[1]=6;
            preturi[2]=20;
            preturi[3]=5;
            preturi[4]=7;
            preturi[5] =23;
        }
    }
}
