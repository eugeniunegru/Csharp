using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        int i = 0,j=0;
        int corect=0, incorect=0;
        int rasp = 0,check=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            timer1.Enabled = true;
            button1.Click -=button1_Click;
            button1.Click += rasp_Click;
            button1.Text = "Raspunde";
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 60) { timer1.Enabled = false; MessageBox.Show("corecte="+corect+"\nincorect= "+incorect); }
            label3.Text =Convert.ToString( 60 - i);
        }
        private void rasp_Click(object sender, EventArgs e)
        {
            if (rasp==check) corect++;
            else incorect++;
            j++;
            if (j == 1)
            {
                label2.Text = " Pe drapelul cărei ţări stă scrie motto-ul „Ordine şi progres”?";
                radioButton1.Text = "a. Australia";
                radioButton2.Text = "b. Brazilia";
                radioButton3.Text = "c. Africa de Sud";
                radioButton4.Text = "d. Indonezia";
                rasp = 1;
            }
            else if (j == 2)
            {
                label2.Text = " Prefixul „eco” vine de la un cuvânt grecesc care înseamnă:";
                radioButton1.Text = "a. stat";
                radioButton2.Text = "b. casă";
                radioButton3.Text = "c. soare";
                radioButton4.Text = "d. viaţă";
                rasp = 1;
            }
            else if (j == 3)
            {
                label2.Text = "Care dintre următoarele soiuri de struguri este folosit pentru a produce un celebru vin roşu?";
                radioButton1.Text = "a. Pinot Grigio";
                radioButton2.Text = "b. Riesling";
                radioButton3.Text = "c. Cabernet Sauvignon";
                radioButton4.Text = "d. Chardonnay";
                rasp = 2;
            }
            else if (j == 4)
            {
                label2.Text = "Muammar Gaddafi a fost conducătorul cărei ţări între 1969 şi 2011?";
                radioButton1.Text = "a. Libia";
                radioButton2.Text = "b. Tunisia";
                radioButton3.Text = "c. Sudan";
                radioButton4.Text = "d. Egipt";
                rasp = 0;
            }
            else if (j == 5)
            {
                label2.Text = "Cu ce parte a unui computer este asociat brand-ul „Intel Inside”?";
                radioButton1.Text = "a. BIOS";
                radioButton2.Text = "b. RAM";
                radioButton3.Text = "c. USB";
                radioButton4.Text = "d. Procesorul";
                rasp = 3;
            }
            else if (j == 6)
            {
                label2.Text = "Care dintre următoarele oraşe este capitala Arabiei Saudite?";
                radioButton1.Text = "a. Abu Dhabi";
                radioButton2.Text = "b. Manama";
                radioButton3.Text = "c. Doha";
                radioButton4.Text = "d. Riyadh";
                rasp = 3;
            }
            else if (j == 7)
            {
                label2.Text = "Sub ce nume a rămas cunoscut eroul naţional al Spaniei, Rodrigo Diaz de Bivar?";
                radioButton1.Text = "a. El Cano";
                radioButton2.Text = "b. El Greco";
                radioButton3.Text = "c. El Cid";
                radioButton4.Text = "d. El Salvador";
                rasp = 2;
            }
            else if (j == 8)
            {
                label2.Text = "În ce judeţ se află localitatea Roşia Montană?";
                radioButton1.Text = "a. Prahova";
                radioButton2.Text = "b. Alba";
                radioButton3.Text = "c. Buzău";
                radioButton4.Text = "d. Maramureş";
                rasp = 1;
            }
            else if (j == 9)
            {
                label2.Text = "Care dintre următoarele variante denumeşte un bici alcătuit din mai multe curele împletite?";
                radioButton1.Text = "a. gârbaci";
                radioButton2.Text = "b. gârliţă";
                radioButton3.Text = "c. gâză";
                radioButton4.Text = "d. gârniţă";
                rasp = 0;
            }
            else MessageBox.Show("corecte=" + corect + "\nincorect= " + incorect); 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            check = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            check = 3;
        }
    }
}
