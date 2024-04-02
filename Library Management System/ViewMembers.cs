using MySqlConnector;
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

namespace Library_Management_System
{
    public partial class FrmViewMembers : Form
    {
        public FrmViewMembers()
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
            
        }

        private void FrmViewMembers_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = GetConnection();

                string query = "select * from member";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred: " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int mid;
        int rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                mid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            MySqlConnection con = GetConnection();

            string query = "select * from member where Member_ID=" + mid + "";
            MySqlCommand cmd = new MySqlCommand(query, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

            TxtName.Text = ds.Tables[0].Rows[0][1].ToString();
            TxtAddress.Text = ds.Tables[0].Rows[0][2].ToString();
            TxtEmail.Text = ds.Tables[0].Rows[0][3].ToString();
            TxtPhone.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        private void TxtMemID_TextChanged(object sender, EventArgs e)
        {
            if (TxtMemID.Text != "")
            {
                MySqlConnection con = GetConnection(); 

                string query = "select * from member where Member_ID like '" + TxtMemID.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MySqlConnection con = GetConnection();

                string query = "select * from member";
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
            TxtName.Clear();
            TxtAddress.Clear();
            TxtEmail.Clear();
            TxtPhone.Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Data will be updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string name = TxtName.Text;
                    string address = TxtAddress.Text;
                    string email = TxtEmail.Text;
                    string phone = TxtPhone.Text;

                    MySqlConnection con = GetConnection();

                    string query = "update member set Name = '" + name + "',Address = '" + address + "',Email = '" + email + "',Phone_Number = " + phone + " where Member_ID = " + rowid + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    string reloadQuery = "SELECT * FROM member";
                    MySqlDataAdapter reloadAdapter = new MySqlDataAdapter(reloadQuery, con);
                    DataTable reloadTable = new DataTable();
                    reloadAdapter.Fill(reloadTable);
                    dataGridView1.DataSource = reloadTable;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will deleted. Confirm?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MySqlConnection con = GetConnection();

                string query = "delete from member where Member_ID= " + rowid + "";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                string reloadQuery = "SELECT * FROM member";
                MySqlDataAdapter reloadAdapter = new MySqlDataAdapter(reloadQuery, con);
                DataTable reloadTable = new DataTable();
                reloadAdapter.Fill(reloadTable);
                dataGridView1.DataSource = reloadTable;
            }
        }

        private void LblMemID_Click(object sender, EventArgs e)
        {

        }
    }
}
