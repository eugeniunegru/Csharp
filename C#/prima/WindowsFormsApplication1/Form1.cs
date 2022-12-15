using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\TEMP\Desktop\inregistrare\WindowsFormsApplication1\test1.mdb");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand selAll = new OleDbCommand("select * from Utilizatori", con);
            OleDbDataAdapter da1 = new OleDbDataAdapter(selAll);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand insData = new OleDbCommand("INSERT INTO Utilizatori(Nume,Prenume,Login,Parola,DataNasterii,IntrebareaSecreta,RaspunsIntrebare,Raiting) VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"',@dn,'"+textBox5.Text+"','"+textBox6.Text+"','"+numericUpDown1.Value+"')",con);
            insData.Parameters.AddWithValue("@dn", dateTimePicker1.Value);
            insData.ExecuteNonQuery();
            
            OleDbCommand selAll = new OleDbCommand("select * from Utilizatori", con);
            OleDbDataAdapter da1 = new OleDbDataAdapter(selAll);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand delData = new OleDbCommand("DELETE * FROM Utilizatori WHERE idUtilizator="+dataGridView1.CurrentRow.Cells[0].Value.ToString(), con);
            delData.ExecuteNonQuery();
           // this.InitializeComponent();
            OleDbCommand selAll = new OleDbCommand("select * from Utilizatori", con);
            OleDbDataAdapter da2 = new OleDbDataAdapter(selAll);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text != "")
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    var strexpr = string.Format("select * from Utilizatori where (YEAR(DATE())-YEAR(DataNasterii))={0}", textBox8.Text);
                    OleDbCommand selAll = new OleDbCommand(strexpr, con);
                    //selAll.Parameters.AddWithValue("@dn", textBox8);=@dn GROUP BY Nume,Prenume)-DataNasterii
                    OleDbDataAdapter da = new OleDbDataAdapter(selAll);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           if (con.State == ConnectionState.Closed) con.Open(); 
            var strexpr=string.Format("select * from Utilizatori where Nume LIKE '%{0}%'",textBox7.Text);
            OleDbCommand selAll = new OleDbCommand(strexpr, con);
           //=@dn GROUP BY Nume,Prenume(YEAR()-YEAR(DataNasterii))
            OleDbDataAdapter da = new OleDbDataAdapter(selAll);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            var strexpr = string.Format("select * from Utilizatori where Prenume LIKE '%{0}%'", textBox8.Text);
            OleDbCommand selAll = new OleDbCommand(strexpr, con);
            //=@dn GROUP BY Nume,Prenume(YEAR()-YEAR(DataNasterii))
            OleDbDataAdapter da = new OleDbDataAdapter(selAll);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

          }
}
