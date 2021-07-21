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
    public partial class deposit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\H4k3R\Documents\alldetails.mdf;Integrated Security=True;Connect Timeout=30");
        public deposit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update userdetails set Balance=Balance-'" + textBox4.Text + "' where ACCOUNT_NO='" + textBox3.Text + "'";
                 cmd.ExecuteNonQuery();
                cmd.CommandText = "update userdetails set Balance=Balance+'" + textBox4.Text + "' where ACCOUNT_NO='" + textBox1.Text + "'";

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Balance Successfully deposited");
            }
            catch (Exception excp)
            {
                MessageBox.Show("You dont have sufficient balance");
            }

        }

        private void deposit_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToLongDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            useroperations uo = new useroperations();
            uo.Show();
        }
    }
}
