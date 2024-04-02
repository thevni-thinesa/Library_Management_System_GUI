using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Management_System
{
    public partial class FrmIsssueBook : Form
    {
        public FrmIsssueBook()
        {
            InitializeComponent();
        }

        private MySqlConnection GetConnection()
        {
            string con_string = "server=127.0.0.1;user=root;password=;database=library;";
            return new MySqlConnection(con_string);
        }

        private void FrmIsssueBook_Load(object sender, EventArgs e)
        {
           
        }
  
        private void BtnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = Convert.ToInt32(TxtMID.Text);
                int bid = Convert.ToInt32(TxtBID.Text);
                string issue = DateTime.Now.ToString("yyyy-MM-dd");
                string retun = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");

                MySqlConnection con = GetConnection();

                con.Open();

                string memberQuery = "SELECT COUNT(*) FROM member WHERE Member_ID = " + mid + "";
                using (MySqlCommand memberCommand = new MySqlCommand(memberQuery, con))
                {
                    memberCommand.Parameters.AddWithValue("@MemberID", mid);
                    int memberCount = Convert.ToInt32(memberCommand.ExecuteScalar());
                    if (memberCount == 0)
                    {
                        MessageBox.Show("Invalid Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtMID.Clear();
                        return;
                    }
                }

                string bookQuery = "SELECT COUNT(*) FROM book WHERE Book_ID = " + bid + "";
                using (MySqlCommand bookCommand = new MySqlCommand(bookQuery, con))
                {
                    bookCommand.Parameters.AddWithValue("@Book_ID", bid);
                    int bookCount = Convert.ToInt32(bookCommand.ExecuteScalar());
                    if (bookCount == 0)
                    {
                        MessageBox.Show("Invalid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtBID.Clear();
                        return;
                    }
                }

                string qtyQuery = "SELECT Quantity FROM book WHERE Book_ID = " + bid + "";
                using (MySqlCommand bookCommand = new MySqlCommand(qtyQuery, con))
                {
                    bookCommand.Parameters.AddWithValue("@Book_ID", bid);
                    int quantity = Convert.ToInt32(bookCommand.ExecuteScalar());
                    if (quantity == 0)
                    {
                        MessageBox.Show("This book is out of stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtBID.Clear();
                        return;
                    }
                }

                string query3 = "SELECT COUNT(*) FROM issuebook WHERE Member_ID = " + mid + "";
                using (MySqlCommand memberCommand = new MySqlCommand(query3, con))
                {
                    memberCommand.Parameters.AddWithValue("@MemberID", mid);
                    int issueCount = Convert.ToInt32(memberCommand.ExecuteScalar());
                    if (issueCount >= 3)
                    {
                        MessageBox.Show("This member has already borrowed 3 books.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string query4 = "INSERT INTO issuebook(Member_ID, Book_ID, Issue_Date, Return_Date) VALUES('" + mid + "','" + bid + "','" + issue + "','" + retun + "')";
                MySqlCommand cmd4 = new MySqlCommand(query4, con);
                cmd4.ExecuteNonQuery();

                string query5 = "INSERT INTO record(Member_ID, Book_ID, Issue_Date, Return_Date) VALUES('" + mid + "','" + bid + "','" + issue + "','" + retun + "')";
                MySqlCommand cmd5 = new MySqlCommand(query5, con);
                cmd5.ExecuteNonQuery();

                string query6 = "UPDATE book SET Quantity = Quantity - 1 WHERE Book_ID = " + bid + "";
                MySqlCommand cmd6 = new MySqlCommand(query6, con);
                cmd6.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TxtMID.Clear();
                TxtBID.Clear();
            }
        }

        private void TxtMID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}