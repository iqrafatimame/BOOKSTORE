using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_Login_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // if key is Enter we need to change the focus 
                passBox.Focus();
            }
        }

        private void passBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // if key is Enter we need to change the focus 
                loginBtn.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new signup().Show();
            this.Hide();
         
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            string name = userBox.Text;
            string pass = passBox.Text;
            if (name == "" | pass == "")
            {
                MessageBox.Show(" Please fill all the data fields");
                return;
            }


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQJIE0P;Initial Catalog=PROJECT;Integrated Security=True");
            
            string SelectQuery = "SELECT userName, user_pass FROM signUP WHERE userName=@id AND user_pass=@pas";
            SqlCommand cmd = new SqlCommand(SelectQuery, con);
            cmd.Parameters.AddWithValue("@id", name);
            cmd.Parameters.AddWithValue("@pas", pass);

            con.Open();
            

            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                read.Read();

                MessageBox.Show(" Login Succesfully!");
                //---- Sign In to Menu ----
                new adAdminOrUser().Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("User Not Found !");
            }

            con.Close();
            userBox.Text = " ";
            passBox.Text = " ";
            

        }
    }
}
