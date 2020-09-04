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
    public partial class AddPicture : Form
    {
        public AddPicture()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png, *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bookImgBox.ImageLocation = openFileDialog.FileName;
            }

        }
    }
}
