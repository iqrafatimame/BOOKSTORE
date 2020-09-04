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
    public partial class sigupOrLogin : Form
    {
        public sigupOrLogin()
        {
            InitializeComponent();
        }

        private void signUpChoice_Click(object sender, EventArgs e)
        {
            using (signup c = new signup())
            {
                c.ShowDialog();
            }
        }

        private void loginChoice_Click(object sender, EventArgs e)
        {
            using (Login c = new Login())
            {
                c.ShowDialog();
            }
            Hide();
        }
    }
}
