using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatii_cu_Forme
{
    public partial class IntroNume : Form
    {
        public IntroNume()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "Salut, " + textBox1.Text, "Salutare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)==DialogResult.OK)
                Application.Exit();
        }
    }
}
