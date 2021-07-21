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
using System.Data.Sql;
namespace netbanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passwordtext.PasswordChar='*';
            password1.PasswordChar = '*';
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.Transparent;
            tabControl1.BackColor = Color.Transparent;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
    
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
                    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)    //action for signp of user
        {
            this.Hide();
            userview uv = new userview();
            uv.Show();
        }

        private void button4_Click(object sender, EventArgs e)       //action for admin login button//
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\H4k3R\Documents\alldetails.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from userdetails where USERNAME='"+username1.Text+ "' and PASSWORD= '"+password1.Text+"'",con);
            string output = cmd.ExecuteScalar().ToString();

            if (output == "1")
            {
            this.Hide();
                useroperations uo=new useroperations();
                uo.Show();
            }
            else 
            {
                MessageBox.Show("You are not authenticated user.Please type the correct username and password");
            }
              con.Close();    
               
        }

        private void nametext_Enter(object sender, EventArgs e)
        {
       
            if (nametext.Text == "Username")
            {
                nametext.Text = "";
                nametext.ForeColor = Color.Black;

            }
        }

        private void nametext_leave(object sender, EventArgs e)
        {
            if (nametext.Text == "")
            {
                nametext.Text = "Username";
                nametext.ForeColor = Color.Silver;

            }
        }

        private void passwordtext_enter(object sender, EventArgs e)
        {
            if (passwordtext.Text == "Password")
            {
                passwordtext.Text = "";
                passwordtext.ForeColor = Color.Black;

            }

        }

        private void passwordtext_leave(object sender, EventArgs e)
        {
            if (nametext.Text == "Password")
            {
                passwordtext.Text = "";
                passwordtext.ForeColor = Color.Black;

            }
        }

        private void button3_Click_1(object sender, EventArgs e)   //Action for login
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\H4k3R\Documents\alldetails.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from adminlogin where USERNAME='"+ nametext.Text+ "' and PASSWORD= '"+passwordtext.Text+"'",con);
            string output = cmd.ExecuteScalar().ToString();

            if (output == "1")
            {
                this.Hide();
                adminview av = new adminview();
                av.Show();
            }
            else
            {
                MessageBox.Show("You are not authenticated user.Please type the correct password");
            }
            }

        private void username1_enter(object sender, EventArgs e)
        {
            if (username1.Text == "Username")
            {
                username1.Text = "";
                username1.ForeColor = Color.Black;

            }
        }

        private void username1_leave(object sender, EventArgs e)
        {
            if (username1.Text == "")
            {
                username1.Text = "Username";
                username1.ForeColor = Color.Silver;

            }
        }

        private void password1_enter(object sender, EventArgs e)
        {
            if (password1.Text == "Password")
            {
                password1.Text = "";
                password1.ForeColor = Color.Black;

            }

        }

        private void password1_leave(object sender, EventArgs e)
        {
            if (password1.Text == "Password")
            {
                password1.Text = "";
                password1.ForeColor = Color.Black;

            }

        }
    }
}
