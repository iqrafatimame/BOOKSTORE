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
    public partial class AddBookDetails : Form
    {
        public AddBookDetails()
        {
            InitializeComponent();
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            string title = titleBox.Text;
            string sku = skuBox.Text;
            string price = priceBox.Text;
            string description = descBox.Text;
            string category = catBox.Text;
            string author = authorBox.Text;
            string availability = availBox.Text;
            string ID = idBox.Text;
            string insertBook = "INSERT INTO BOOK(bookId,bookSKU , bookTitle, bookPrice, bookAvailability, bookCategory, " +
                "bookDesciption, bookAuthor) VALUES(@i,@s,@t,@p,@a,@c,@d,@auth)";

            if(title =="" | sku == "" | price == "" | description == "" | category == "" | author == "")
            {
                MessageBox.Show("Kindly Enter All Fields");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQJIE0P;Initial Catalog=PROJECT;Integrated Security=True");
            SqlCommand insertBookCmd = new SqlCommand(insertBook , con);
            insertBookCmd.Parameters.AddWithValue("@i", ID);
            insertBookCmd.Parameters.AddWithValue("@s", sku);
            insertBookCmd.Parameters.AddWithValue("@t", title);
            insertBookCmd.Parameters.AddWithValue("@p", price);
            insertBookCmd.Parameters.AddWithValue("@a", availability);
            insertBookCmd.Parameters.AddWithValue("@c", category);
            insertBookCmd.Parameters.AddWithValue("@d", description);
            insertBookCmd.Parameters.AddWithValue("@auth", author);
            con.Open();
            insertBookCmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Book Details Added Succesfully :) ");

            titleBox.Text = "";
            skuBox.Text = "";
            priceBox.Text = "";
            authorBox.Text = "";
            idBox.Text = "";
            catBox.Text = "";
            descBox.Text = "";
            availBox.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void descBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
