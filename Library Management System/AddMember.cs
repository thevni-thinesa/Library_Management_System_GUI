using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Library_Management_System
{
    public partial class FrmAddMember : Form
    {
        public FrmAddMember()
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = TxtName.Text;
                string address = TxtAddress.Text;
                string email = TxtEmail.Text;
                int phone = Convert.ToInt32(TxtPhone.Text);

                MySqlConnection con = GetConnection();

                string query = "insert into member(Name,Address,Email,Phone_Number) values('" + name + "','" + address + "','" + email + "','" + phone + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Data saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TxtName.Clear();
                TxtPhone.Clear();
                TxtAddress.Clear();
                TxtEmail.Clear();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
