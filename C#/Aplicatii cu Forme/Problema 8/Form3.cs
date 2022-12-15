using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Modifica culoare";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)this.Owner;
            string c = textBox1.Text;
            switch (c)
            {
                case "rosu": f.BackColor = Color.Red; break;
                case "verde": f.BackColor = Color.Green; break;
                case "negru": f.BackColor = Color.Black; break;
                case "albastru": f.BackColor = Color.Blue; break;
                case "galben": f.BackColor = Color.Yellow; break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            this.Close();
            
        }
    }
}
