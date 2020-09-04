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
    public partial class viewBooks : Form
    {
        DataTable dt;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        public viewBooks()
        {
            InitializeComponent();
        }
        public void displayData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQJIE0P;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOK", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            bookDetailGrid.DataSource = dt;
            con.Close();


        }

        private void viewBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDBDataSet.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter1.Fill(this.storeDBDataSet.BOOK);
            // TODO: This line of code loads data into the 'bOOKDataSet1.BOOK' table. You can move, or remove it, as needed.


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewDetailBtn_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void viewBox_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQJIE0P;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM BOOK WHERE bookTitle like '%" + srchBox.Text + "%'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted successfully");
            displayData();

        }

        private void viewBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQJIE0P;Initial Catalog=PROJECT;Integrated Security=True");
            string query = "SELECT * FROM BOOK WHERE bookTitle LIKE '%" + srchBox.Text + "%'";
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            bookDetailGrid.DataSource = dt;
            if (adp.Fill(dt)==0)
            {
                MessageBox.Show("not found");
            }
            con.Close();
        }

        private void srchBox_Enter(object sender, EventArgs e)
        {
            if(srchBox.Text == "Search Book Name")
            {
                srchBox.Text = "";
                srchBox.ForeColor = Color.Black;
            }
        }

        private void srchBox_Leave(object sender, EventArgs e)
        {
            if (srchBox.Text == "")
            {
                srchBox.Text = "Search Book Name";
                srchBox.ForeColor = Color.Silver;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            using(Home c=new Home())
            {
                c.ShowDialog();
            }
        }
    }
}
