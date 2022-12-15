using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            if (a == 6) if (MessageBox.Show(this, "Raspunsul este corect", "Raspuns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    Application.Exit();
             //   else  MessageBox.Show(this, "RAspunsul nu este corect", "Raspuns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
