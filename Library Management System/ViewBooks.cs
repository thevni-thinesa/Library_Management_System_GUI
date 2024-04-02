using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlConnector;

namespace Library_Management_System
{
    public partial class FrmViewBooks : Form
    {
        public FrmViewBooks()
        {
            InitializeComponent();
        }

        private MySqlConnection GetConnection()
        {
            string con_string = "server=127.0.0.1;user=root;password=;database=library;";
            return new MySqlConnection(con_string);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmViewBooks_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = GetConnection();

                string query = "select * from book";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int bid;
        int rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            MySqlConnection con = GetConnection();

            string query = "select * from book where Book_ID=" + bid + "";
            MySqlCommand cmd = new MySqlCommand(query, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

            TxtBname.Text = ds.Tables[0].Rows[0][1].ToString();
            TxtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            TxtPublisher.Text = ds.Tables[0].Rows[0][3].ToString();
            TxtPrice.Text = ds.Tables[0].Rows[0][4].ToString();
            TxtQty.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void TxtBookName_TextChanged(object sender, EventArgs e)
        {
            if(TxtBookID.Text != "")
            {
                MySqlConnection con = GetConnection();

                string query = "select * from book where Book_ID like '"+TxtBookID.Text+"%'";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MySqlConnection con = GetConnection();

                string query = "select * from book";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TxtBookID.Clear();
            TxtBname.Clear();
            TxtAuthor.Clear();
            TxtPublisher.Clear();
            TxtPrice.Clear();
            TxtQty.Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data will be updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string bName = TxtBname.Text;
                    string author = TxtAuthor.Text;
                    string publisher = TxtPublisher.Text;
                    double price = Convert.ToDouble(TxtPrice.Text);
                    int qty = Convert.ToInt32(TxtQty.Text);

                    MySqlConnection con = GetConnection();

                    string query = "update book set Book_Title = '" + bName + "',Author = '" + author + "',Publisher = '" + publisher + "',Book_Price = " + price + ",Quantity = " + qty + " where Book_ID = " + rowid + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    string reloadQuery = "SELECT * FROM book";
                    MySqlDataAdapter reloadAdapter = new MySqlDataAdapter(reloadQuery, con);
                    DataTable reloadTable = new DataTable();
                    reloadAdapter.Fill(reloadTable);
                    dataGridView1.DataSource = reloadTable;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid input format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will deleted. Confirm?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MySqlConnection con = GetConnection();

                string query = "delete from book where Book_ID= " + rowid + "";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                string reloadQuery = "SELECT * FROM book";
                MySqlDataAdapter reloadAdapter = new MySqlDataAdapter(reloadQuery, con);
                DataTable reloadTable = new DataTable();
                reloadAdapter.Fill(reloadTable);
                dataGridView1.DataSource = reloadTable;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
