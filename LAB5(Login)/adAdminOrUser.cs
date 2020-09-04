using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_Login_
{
    public partial class adAdminOrUser : Form
    {
        public adAdminOrUser()
        {
            InitializeComponent();
        }
        private void adAdminOrUser_Load_1(object sender, EventArgs e)
        {
            
        }

        private void userBtn_MouseHover(object sender, EventArgs e)
        {
          

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            using (Home c = new Home())
            {
          
                c.ShowDialog();
            }
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            using(searchBook c = new searchBook())
            {
                c.ShowDialog();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
