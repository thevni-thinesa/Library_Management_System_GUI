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
    public partial class FrmDashboard : Form
    {
        bool sidebarExpand;
        bool booksCollapsed;
        bool membersCollapsed;

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {

        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }
        private void customizeDesign()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            sidebar.BringToFront();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width) 
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void BtnLogout_Click_1(object sender, EventArgs e)
        {
            FrmLogin fl = new FrmLogin();
            fl.Show();
            this.Close();
        }

        private void BtnViewBook_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmViewBooks());
        }

        private void BooksTimer_Tick(object sender, EventArgs e)
        {
            if(booksCollapsed)
            {
                BookMenu.Height -= 10;
                if (BookMenu.Height == BookMenu.MinimumSize.Height)
                {
                    booksCollapsed = false;
                    BooksTimer.Stop();
                }
            }
            else
            {
                BookMenu.Height += 10;
                if (BookMenu.Height == BookMenu.MaximumSize.Height)
                {
                    booksCollapsed = true;
                    BooksTimer.Stop();
                }
            }
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            BooksTimer.Start();
        }

        private void MembersTimer_Tick(object sender, EventArgs e)
        {
            if (membersCollapsed)
            {
                MemberMenu.Height -= 10;
                if (MemberMenu.Height == MemberMenu.MinimumSize.Height)
                {
                    membersCollapsed = false;
                    MembersTimer.Stop();
                }
            }
            else
            {
                MemberMenu.Height += 10;
                if (MemberMenu.Height == MemberMenu.MaximumSize.Height)
                {
                    membersCollapsed = true;
                    MembersTimer.Stop();
                }
            }
        }

        private void BtnMembers_Click(object sender, EventArgs e)
        {
            MembersTimer.Start();
        }

        private void BtnDashExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAddBook());
        }

        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAddMember());
        }

        private void BtnViewMember_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmViewMembers());
        }

        private Form activeForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.TopMost = true;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(ChildForm);
            panelForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void BtnIssue_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmIsssueBook());
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmReturnBook());
        }

        private void BtnRecords_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRecords());
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
