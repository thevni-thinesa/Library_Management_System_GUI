using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySqlConnector;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FrmAddBook : Form
    {
        public FrmAddBook()
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string btitle = TxtBookTitle.Text;
            string author=TxtAuthor.Text;
            string publisher = TxtPublisher.Text;
            double price = Convert.ToDouble(TxtPrice.Text);
            int qty = Convert.ToInt32(TxtQty.Text);

            MySqlConnection con = GetConnection();

            string query = "insert into book(Book_Title,Author,Publisher,Book_Price,Quantity) values('" + btitle + "','" + author + "','" + publisher + "'," + price + "," + qty + ")";
            MySqlCommand cmd = new MySqlCommand(query,con);

            con.Open();
           
            cmd.ExecuteNonQuery();
            
            con.Close();

            MessageBox.Show("Data saved.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            TxtBookTitle.Clear();
            TxtQty.Clear();
            TxtAuthor.Clear();
            TxtPublisher.Clear();
            TxtPrice.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
