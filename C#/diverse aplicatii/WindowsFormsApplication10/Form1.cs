using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication12;

namespace Calculator
{
    public partial class Form1 : Form
    {
        BaseConverter bases=new BaseConverter();
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        bool scient = true;
        double result;
        double opr1, opr2;
        bool semn = true;
        char operation;
        int baza=10;
        Color color;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnTwo.Text;

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnSeven.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnZero.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btnPeriod.Text;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '+';
            textBox1.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                operand2 = textBox1.Text;

                opr1 = Double.Parse(operand1);
                opr2 = Double.Parse(operand2);


                switch (operation)
                {
                    case '+':
                        result = (opr1 + opr2);
                        break;

                    case '-':
                        result = (opr1 - opr2);
                        break;

                    case '*':
                        result = (opr1 * opr2);
                        break;

                    case '/':
                        if (opr2 != 0)
                        {
                            result = (opr1 / opr2);
                        }
                        else
                        {
                            MessageBox.Show("Nu se imparte la zero");
                        }
                        break;
                    case 'l':
                        if (opr2 != 0)
                        {
                            result = Math.Log(opr2, opr1 );
                        }
                        else
                        {
                            MessageBox.Show("log(0)?");
                        }
                        break;
                    case '%':
                        if (opr1 < 0)
                        {
                            result = opr2*opr1/100;
                        }
                        else
                        {
                            MessageBox.Show("%<0");
                        }
                        break;   
                    case '^':
                        if (opr2 != 0)
                        {
                            result = Math.Pow( opr1 , opr2);
                        }
                        break;
                }

                textBox1.Text = result.ToString();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '/';
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            opr1 = 0;
            opr2 = 0;
            textBox1.Text = string.Empty;
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '-';
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '*';
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if(textBox1.Text.Length>0) textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 439; 
            this.Height = 530;
            button24.BackColor = Color.Gray;
            color = button1.BackColor;
        }

        private void operatiiDeConversieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scient)
            {
                this.Width = 835;
                this.Height = 528;
                scient = false;
            }
            else
            {
                this.Width = 439;
                this.Height = 530;
                scient = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            textBox1.Text =Math.Sin(Convert.ToDouble( operand1)).ToString("F");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            textBox1.Text = Math.Cos(Convert.ToDouble(operand1)).ToString("F");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            textBox1.Text = Math.Tan(Convert.ToDouble(operand1)).ToString("F");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            textBox1.Text = (Math.Cos(Convert.ToDouble(operand1)) / Math.Sin(Convert.ToDouble(operand1))).ToString("F");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = 'l';
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
             operand1 = textBox1.Text;
            if (Convert.ToDouble(operand1) > 0)
                {
                          textBox1.Text= Math.Log(Convert.ToDouble(operand1), Math.E).ToString("F");  
                 }
             else
                  {
                            MessageBox.Show("log(0)?");
                  } 
                           
        }

        private void button14_Click_1(object sender, EventArgs e)
        {  double result1=1;
            operand1 = textBox1.Text;
            if (Convert.ToInt16(operand1) < 32000)
            {
                for (int i = 2; i <= Convert.ToInt16(operand1); i++) result1 =result1* i;
                textBox1.Text = Convert.ToString(result1);
            }

            else MessageBox.Show("x>32000");
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;

           if(Convert.ToInt16(operand1)>0) textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToInt16(operand1)));
           else MessageBox.Show("x<0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.PI);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.E);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / Convert.ToDouble(operand1)).ToString("F");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(operand1),2));
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Pow(10,Convert.ToDouble(operand1) ));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '%';
            textBox1.Clear();
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private void button2_Click(object sender, EventArgs e)
        {string str=textBox1.Text;
            if (semn) { textBox1.Text = "-" + textBox1.Text; semn = false; }
            else
            {
                str = Reverse(str);                
                str=str.Remove(str.Length-1,1);
                str = Reverse(str);
                //MessageBox.Show(str);
                textBox1.Text = str;
                semn = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '^';
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button22.BackColor = Color.Gray;
            button21.BackColor = color;
            button24.BackColor = color;
            button23.BackColor = color;
            if (baza != 2)
            {
                textBox1.Text = bases.ToBase(textBox1.Text, baza,2);
            }
            baza = 2;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button22.BackColor = color;
            button21.BackColor =Color.Gray ;
            button24.BackColor = color;
            button23.BackColor = color;
            if (baza != 8)
            {
                textBox1.Text = bases.ToBase(textBox1.Text, baza, 8);
            }
            baza = 8;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button22.BackColor = color;
            button21.BackColor = color;
            button24.BackColor = Color.Gray;
            button23.BackColor = color;
            if (baza != 10)
            {
                textBox1.Text = bases.ToBase(textBox1.Text, baza, 10);
            }
            baza = 10;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button22.BackColor = color;
            button21.BackColor = color;
            button24.BackColor = color;
            button23.BackColor = Color.Gray;
            
            if (baza != 16)
            {
                textBox1.Text = bases.ToBase(textBox1.Text, baza, 16);
            }

            baza = 16;
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button25.Text;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button26.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button27.Text;
        }
    }
}
