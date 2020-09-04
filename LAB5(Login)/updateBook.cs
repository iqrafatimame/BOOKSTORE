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
    public partial class updateBook : Form
    {
        SqlDataReader mdr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQJIE0P;Initial Catalog=PROJECT;Integrated Security=True");

        public updateBook()
        {
            InitializeComponent();
        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            con.Open();
           string query = "SELECT * FROM BOOK WHERE bookId =" + int.Parse(srchBox.Text);
            SqlCommand cmd = new SqlCommand(query,con);
             mdr =cmd.ExecuteReader();
            if (mdr.Read())
            {

                idBox.Text = (mdr["bookId"].ToString());
                titleBox.Text = (mdr["bookTitle"].ToString());
                authorBox.Text = (mdr["bookAuthor"].ToString());
                priceBox.Text = (mdr["bookPrice"].ToString());
                availBox.Text = (mdr["bookAvailability"].ToString());
                catBox.Text = (mdr["bookCategory"].ToString());
                desBox.Text = (mdr["bookDesciption"].ToString());
                skuBox.Text = (mdr["bookSKU"].ToString());
            }
            else
            {
                idBox.Text = "";
                titleBox.Text = "";
                authorBox.Text = "";
                availBox.Text = "";
                catBox.Text = "";
                desBox.Text = "";
                skuBox.Text = "";   
                MessageBox.Show("No Such Book Found");
            }
            con.Close();


        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string updateQuery = "UPDATE BOOK SET bookTitle=@t, bookAuthor=@a, bookPrice=@p, bookAvailability=@av, bookCategory=@c, bookDesciption=@d, bookSKU=@s WHERE bookId=@i";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("t", titleBox.Text);
            cmd.Parameters.AddWithValue("a", authorBox.Text);
            cmd.Parameters.AddWithValue("p", int.Parse(priceBox.Text));
            cmd.Parameters.AddWithValue("av", availBox.Text);
            cmd.Parameters.AddWithValue("c", catBox.Text);
            cmd.Parameters.AddWithValue("d", desBox.Text);
            cmd.Parameters.AddWithValue("s", int.Parse(skuBox.Text));
            cmd.Parameters.AddWithValue("i", srchBox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully...!");
            con.Close();
            titleBox.Text = "";
            autherName.Text = "";
            priceBox.Text = "";
            availBox.Text = "";
            catBox.Text = "";
            desBox.Text = "";
            skuBox.Text = "";
            srchBox.Text = "";
        }

        private void srchBox_Click(object sender, EventArgs e)
        {
            
        }

        private void srchBox_Enter(object sender, EventArgs e)
        {
            if (srchBox.Text == "Search by Book ID")
            {
                srchBox.Text = "";
                srchBox.ForeColor = Color.Black;
            }
        }

        private void srchBox_Leave(object sender, EventArgs e)
        {
            if (srchBox.Text == "")
            {
                srchBox.Text = "Search by Book ID";
                srchBox.ForeColor = Color.Silver;
            }
        }
    }
}
