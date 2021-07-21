using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace netbanking
{
    public partial class myaccount : Form
    {
        SqlConnection abc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\H4k3R\Documents\alldetails.mdf;Integrated Security=True;Connect Timeout=30");
        public myaccount()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from userdetails where ACCOUNT_NO='" + textBox7.Text + "' and PASSWORD='"+textBox1.Text+"'"  , abc);
                DataTable ss = new DataTable();
                sda.Fill(ss);
                textBox3.Text = ss.Rows[0][0].ToString();
                textBox4.Text = ss.Rows[0][1].ToString();
                textBox5.Text = ss.Rows[0][2].ToString();
                textBox6.Text = ss.Rows[0][3].ToString();
                textBox2.Text = ss.Rows[0][11].ToString();
                textBox9.Text = ss.Rows[0][6].ToString();
                comboBox1.Text = ss.Rows[0][8].ToString();
                textBox10.Text = ss.Rows[0][7].ToString();
                comboBox2.Text = ss.Rows[0][9].ToString();
            }   catch(Exception excp)
            {
                MessageBox.Show("Account number or password doesn't match.Type correct account number and password.");
            }
                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            useroperations uo = new useroperations();
            uo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
