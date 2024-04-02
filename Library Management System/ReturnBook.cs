using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class FrmReturnBook : Form
    {
        public FrmReturnBook()
        {
            InitializeComponent();
        }

        private MySqlConnection GetConnection()
        {
            string con_string = "server=127.0.0.1;user=root;password=;database=library;";
            return new MySqlConnection(con_string);
        }

        private void FrmReturnBook_Load(object sender, EventArgs e)
        {
            MySqlConnection con = GetConnection();

            string query = "select * from issuebook";
            MySqlCommand cmd = new MySqlCommand(query, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

            TxtMID.Text = selectedRow.Cells["Member_ID"].Value.ToString();
            TxtBID.Text = selectedRow.Cells["Book_ID"].Value.ToString();
            TxtIssue.Text = selectedRow.Cells["Issue_Date"].Value.ToString();
            TxtReturn.Text = selectedRow.Cells["Return_Date"].Value.ToString();
        }

        private void TxtMemID_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = GetConnection();

            if (TxtMemID.Text != "")
            {
                string query = "select * from issuebook where Member_ID like '" + TxtMemID.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string query = "select * from issuebook";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void BtnRfresh_Click(object sender, EventArgs e)
        {
            TxtMemID.Clear();
            TxtBID.Clear();
            TxtIssue.Clear();
            TxtReturn.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = GetConnection();

            con.Open();

            string query = "UPDATE book SET Quantity = Quantity + 1 WHERE Book_ID = " + TxtBID.Text + "";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            string returnDate = DateTime.Now.ToString("yyyy-MM-dd");
            query = "UPDATE record SET Return_Date = '" + returnDate + "' WHERE Book_ID = " + TxtBID.Text + " AND Member_ID = '" + TxtMID.Text + "'";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            query = "DELETE FROM issuebook WHERE Book_ID = " + TxtBID.Text + " AND Member_ID = '" + TxtMID.Text + "'";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Book Returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string reloadQuery = "SELECT * FROM issuebook";
            MySqlDataAdapter reloadAdapter = new MySqlDataAdapter(reloadQuery, con);
            DataTable reloadTable = new DataTable();
            reloadAdapter.Fill(reloadTable);
            dataGridView1.DataSource = reloadTable;

            con.Close();
        }
    }
}
