using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_Login_
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = userBox.Text;
            string pass = passBox.Text;
            string cnfirmPass = cnPassBox.Text;
            string email = mailBox.Text;
            if(user == "" | pass == "" | cnfirmPass == "" | email == "")
            {
                MessageBox.Show("Kindly fill all fields");
                return;

            }
           
            if (pass != cnfirmPass)
            {
                MessageBox.Show("Kindly Confirm Password");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQJIE0P;Initial Catalog=PROJECT;Integrated Security=True");
            
            string insertQuery = "INSERT INTO signUP(userName, user_pass, cnfrm_pass, user_email) VALUES(@a,@b,@c,@d)";
            SqlCommand insertCmd = new SqlCommand(insertQuery, con);
            insertCmd.Parameters.AddWithValue("@a", user);
            insertCmd.Parameters.AddWithValue("@b", pass);
            insertCmd.Parameters.AddWithValue("@c", cnfirmPass);
            insertCmd.Parameters.AddWithValue("@d", email);

            con.Open();
            if(pass == cnfirmPass)
            {
                insertCmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully..!");
                using (Login b = new Login())
                {
                    b.ShowDialog();
                }
            }
            
            con.Close();
            user = "";
            pass = "";
            cnfirmPass = "";
            email = "";
            this.Hide();

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
                cnPassBox.Focus();
            }
        }

        private void cnPassBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // if key is Enter we need to change the focus 
                mailBox.Focus();
            }
        }

        private void mailBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // if key is Enter we need to change the focus 
                signUpButton.Focus();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userBox_Enter(object sender, EventArgs e)
        {
            if(userBox.Text== "Enter a user name")
            {
                userBox.Text = "";
                userBox.ForeColor = Color.Black;
            }
        }

        private void userBox_Leave(object sender, EventArgs e)
        {
            if (userBox.Text == "")
            {
                userBox.Text = "Enter a user name";
                userBox.ForeColor = Color.Silver;
            }
        }

        private void passBox_Enter(object sender, EventArgs e)
        {
            if(passBox.Text== "choose a password")
            {
                passBox.Text = "";
                passBox.ForeColor = Color.Black;
            }
        }

        private void passBox_Leave(object sender, EventArgs e)
        {
            if (passBox.Text == "")
            {
                passBox.Text = "choose a password";
                passBox.ForeColor = Color.Silver;
            }
        }

        private void cnPassBox_Enter(object sender, EventArgs e)
        {
            if(cnPassBox.Text== "enter a password")
            {
                cnPassBox.Text = "";
                cnPassBox.ForeColor = Color.Black;
            }
        }

        private void cnPassBox_Leave(object sender, EventArgs e)
        {
            if (cnPassBox.Text == "")
            {
                cnPassBox.Text = "enter a password";
                cnPassBox.ForeColor = Color.Silver;
            }
        }

        private void mailBox_Enter(object sender, EventArgs e)
        {
            if(mailBox.Text== "somebody@gmail.com")
            {
                mailBox.Text = "";
                mailBox.ForeColor = Color.Black;
            }
        }

        private void mailBox_Leave(object sender, EventArgs e)
        {
            if (mailBox.Text == "")
            {
                mailBox.Text = "somebody@gmail.com";
                mailBox.ForeColor = Color.Silver;
            }
        }
    }
}
