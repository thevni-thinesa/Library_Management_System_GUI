using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FrmRecords : Form
    {
        public FrmRecords()
        {
            InitializeComponent();
        }

        private MySqlConnection GetConnection()
        {
            string con_string = "server=127.0.0.1;user=root;password=;database=library;";
            return new MySqlConnection(con_string);
        }

        private void FrmRecords_Load(object sender, EventArgs e)
        {
            MySqlConnection con = GetConnection();

            string query = "select * from record";
            MySqlCommand cmd = new MySqlCommand(query, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.ReadOnly = true;
        }

        private void TxtMemID_TextChanged(object sender, EventArgs e)
        {
            if (TxtMemID.Text != "")
            {
                MySqlConnection con = GetConnection();

                string query = "select * from record where Member_ID like '" + TxtMemID.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MySqlConnection con = GetConnection();

                string query = "select * from record";
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
        }
    }
}
