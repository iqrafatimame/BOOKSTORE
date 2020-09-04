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

namespace LAB5_Login_
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (updateBook c = new updateBook())
            {
                c.ShowDialog();
            }

        }
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            using (AddBookDetails c = new AddBookDetails())
            {
                c.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(viewBooks c = new viewBooks())
            {
                c.ShowDialog();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
