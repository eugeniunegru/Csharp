using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;
using WindowsFormsApplication9;
namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        string sir;
        Node root = null;
        Tree bst = new Tree();
        bool val;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bst.n = 0;
            root = null;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            //MessageBox.Show(path);
            using (StreamReader citeste = new StreamReader(path + "\\farmacie.txt"))
                        {
                string[] strArrayOne = new string[] { "" };

                while ((sir = citeste.ReadLine()) != null)
                {
                    //somewhere in your code
                    strArrayOne = sir.Split(',');


                    root = bst.insert(root, strArrayOne[0], Convert.ToDouble(strArrayOne[1]), Convert.ToInt32(strArrayOne[2]), strArrayOne[3], strArrayOne[4]);

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bst.n = 0;
            label1.Text = "";
            bst.traverse(root);
            for (int i = 0; i < bst.n; i++)
            {
                label1.Text += Convert.ToString(bst.array[i]) + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            root = bst.insert(root, textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bst.Delete(ref root, textBox7.Text, ref val);
            if (val) MessageBox.Show("sters");
            else MessageBox.Show("Ne sters");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bst.traverse2(root, textBox8.Text);
            for (int i = 0; i < bst.n; i++)
            {
                label1.Text += Convert.ToString(bst.array[i]) + " ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
