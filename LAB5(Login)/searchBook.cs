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
    public partial class searchBook : Form
    {
        public searchBook()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQJIE0P;Initial Catalog=PROJECT;Integrated Security=True");


        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQJIE0P;Initial Catalog=PROJECT;Integrated Security=True");
            string query = "SELECT * FROM BOOK WHERE bookTitle LIKE '%" + searchBox.Text + "%'";
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            searchGrid.DataSource = dt;
            if (adp.Fill(dt) == 0)
            {
                MessageBox.Show("not found");
            }
            con.Close();
        }


        private void searchBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void serachBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchBookGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBook_Load(object sender, EventArgs e)
        {
           

        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void searchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fairyTale_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Fairy Tale'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void classicLabel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Classic'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void comicBook_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Comic Book'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void crime_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Crime and Detective'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void ethical_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Ethical and Culture'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void fictionLabel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Fiction'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void homour_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Humour'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Historical fiction'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void mystery_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Mystrey'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Novel'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void poetry_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Poetry'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void religion_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK WHERE bookCategory='Religion'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            searchGrid.DataSource = dt;
            con.Close();
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if(searchBox.Text== "Search name of the book")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Search name of the book";
                searchBox.ForeColor = Color.Silver;
            }
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
