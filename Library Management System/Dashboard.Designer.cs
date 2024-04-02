namespace Library_Management_System
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblMenu = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.BookMenu = new System.Windows.Forms.Panel();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.BtnViewBook = new System.Windows.Forms.Button();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.MemberMenu = new System.Windows.Forms.Panel();
            this.BtnViewMember = new System.Windows.Forms.Button();
            this.BtnAddMember = new System.Windows.Forms.Button();
            this.BtnMembers = new System.Windows.Forms.Button();
            this.BtnIssue = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnRecords = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.BooksTimer = new System.Windows.Forms.Timer(this.components);
            this.MembersTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnDashExit = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.BookMenu.SuspendLayout();
            this.MemberMenu.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.BookMenu);
            this.sidebar.Controls.Add(this.MemberMenu);
            this.sidebar.Controls.Add(this.BtnIssue);
            this.sidebar.Controls.Add(this.BtnReturn);
            this.sidebar.Controls.Add(this.BtnRecords);
            this.sidebar.Controls.Add(this.BtnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(223, 600);
            this.sidebar.MinimumSize = new System.Drawing.Size(70, 600);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(70, 600);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblMenu);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 57);
            this.panel1.TabIndex = 0;
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.ForeColor = System.Drawing.Color.White;
            this.LblMenu.Location = new System.Drawing.Point(67, 23);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(61, 23);
            this.LblMenu.TabIndex = 1;
            this.LblMenu.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(14, 20);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(30, 30);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BookMenu
            // 
            this.BookMenu.BackColor = System.Drawing.Color.White;
            this.BookMenu.Controls.Add(this.BtnAddBook);
            this.BookMenu.Controls.Add(this.BtnViewBook);
            this.BookMenu.Controls.Add(this.BtnBooks);
            this.BookMenu.Location = new System.Drawing.Point(3, 66);
            this.BookMenu.MaximumSize = new System.Drawing.Size(223, 134);
            this.BookMenu.MinimumSize = new System.Drawing.Size(223, 54);
            this.BookMenu.Name = "BookMenu";
            this.BookMenu.Size = new System.Drawing.Size(223, 54);
            this.BookMenu.TabIndex = 7;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddBook.FlatAppearance.BorderSize = 0;
            this.BtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBook.ForeColor = System.Drawing.Color.White;
            this.BtnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddBook.Image")));
            this.BtnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddBook.Location = new System.Drawing.Point(0, 54);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAddBook.Size = new System.Drawing.Size(223, 40);
            this.BtnAddBook.TabIndex = 2;
            this.BtnAddBook.Text = "           Add Book";
            this.BtnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddBook.UseVisualStyleBackColor = false;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // BtnViewBook
            // 
            this.BtnViewBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnViewBook.FlatAppearance.BorderSize = 0;
            this.BtnViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewBook.ForeColor = System.Drawing.Color.White;
            this.BtnViewBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnViewBook.Image")));
            this.BtnViewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnViewBook.Location = new System.Drawing.Point(0, 94);
            this.BtnViewBook.Name = "BtnViewBook";
            this.BtnViewBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnViewBook.Size = new System.Drawing.Size(223, 40);
            this.BtnViewBook.TabIndex = 3;
            this.BtnViewBook.Text = "           View Books";
            this.BtnViewBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnViewBook.UseVisualStyleBackColor = false;
            this.BtnViewBook.Click += new System.EventHandler(this.BtnViewBook_Click);
            // 
            // BtnBooks
            // 
            this.BtnBooks.BackColor = System.Drawing.Color.Black;
            this.BtnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBooks.FlatAppearance.BorderSize = 0;
            this.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooks.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooks.ForeColor = System.Drawing.Color.White;
            this.BtnBooks.Image = ((System.Drawing.Image)(resources.GetObject("BtnBooks.Image")));
            this.BtnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBooks.Location = new System.Drawing.Point(-3, 0);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnBooks.Size = new System.Drawing.Size(223, 54);
            this.BtnBooks.TabIndex = 1;
            this.BtnBooks.Text = "           Books";
            this.BtnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBooks.UseVisualStyleBackColor = false;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // MemberMenu
            // 
            this.MemberMenu.Controls.Add(this.BtnViewMember);
            this.MemberMenu.Controls.Add(this.BtnAddMember);
            this.MemberMenu.Controls.Add(this.BtnMembers);
            this.MemberMenu.Location = new System.Drawing.Point(3, 126);
            this.MemberMenu.MaximumSize = new System.Drawing.Size(223, 134);
            this.MemberMenu.MinimumSize = new System.Drawing.Size(223, 54);
            this.MemberMenu.Name = "MemberMenu";
            this.MemberMenu.Size = new System.Drawing.Size(223, 54);
            this.MemberMenu.TabIndex = 8;
            // 
            // BtnViewMember
            // 
            this.BtnViewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnViewMember.FlatAppearance.BorderSize = 0;
            this.BtnViewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewMember.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewMember.ForeColor = System.Drawing.Color.White;
            this.BtnViewMember.Image = ((System.Drawing.Image)(resources.GetObject("BtnViewMember.Image")));
            this.BtnViewMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnViewMember.Location = new System.Drawing.Point(0, 94);
            this.BtnViewMember.Name = "BtnViewMember";
            this.BtnViewMember.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnViewMember.Size = new System.Drawing.Size(223, 40);
            this.BtnViewMember.TabIndex = 5;
            this.BtnViewMember.Text = "           View Members";
            this.BtnViewMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnViewMember.UseVisualStyleBackColor = false;
            this.BtnViewMember.Click += new System.EventHandler(this.BtnViewMember_Click);
            // 
            // BtnAddMember
            // 
            this.BtnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddMember.FlatAppearance.BorderSize = 0;
            this.BtnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddMember.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMember.ForeColor = System.Drawing.Color.White;
            this.BtnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddMember.Image")));
            this.BtnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddMember.Location = new System.Drawing.Point(0, 54);
            this.BtnAddMember.Name = "BtnAddMember";
            this.BtnAddMember.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAddMember.Size = new System.Drawing.Size(223, 40);
            this.BtnAddMember.TabIndex = 4;
            this.BtnAddMember.Text = "           Add Member";
            this.BtnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddMember.UseVisualStyleBackColor = false;
            this.BtnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
            // 
            // BtnMembers
            // 
            this.BtnMembers.BackColor = System.Drawing.Color.Black;
            this.BtnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMembers.FlatAppearance.BorderSize = 0;
            this.BtnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMembers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMembers.ForeColor = System.Drawing.Color.White;
            this.BtnMembers.Image = ((System.Drawing.Image)(resources.GetObject("BtnMembers.Image")));
            this.BtnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMembers.Location = new System.Drawing.Point(0, 0);
            this.BtnMembers.Name = "BtnMembers";
            this.BtnMembers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnMembers.Size = new System.Drawing.Size(223, 54);
            this.BtnMembers.TabIndex = 2;
            this.BtnMembers.Text = "           Members";
            this.BtnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMembers.UseVisualStyleBackColor = false;
            this.BtnMembers.Click += new System.EventHandler(this.BtnMembers_Click);
            // 
            // BtnIssue
            // 
            this.BtnIssue.BackColor = System.Drawing.Color.Black;
            this.BtnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIssue.FlatAppearance.BorderSize = 0;
            this.BtnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIssue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIssue.ForeColor = System.Drawing.Color.White;
            this.BtnIssue.Image = ((System.Drawing.Image)(resources.GetObject("BtnIssue.Image")));
            this.BtnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIssue.Location = new System.Drawing.Point(3, 186);
            this.BtnIssue.Name = "BtnIssue";
            this.BtnIssue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnIssue.Size = new System.Drawing.Size(223, 54);
            this.BtnIssue.TabIndex = 3;
            this.BtnIssue.Text = "           Issue Books";
            this.BtnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIssue.UseVisualStyleBackColor = false;
            this.BtnIssue.Click += new System.EventHandler(this.BtnIssue_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.Black;
            this.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturn.FlatAppearance.BorderSize = 0;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Image = ((System.Drawing.Image)(resources.GetObject("BtnReturn.Image")));
            this.BtnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReturn.Location = new System.Drawing.Point(3, 246);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReturn.Size = new System.Drawing.Size(223, 54);
            this.BtnReturn.TabIndex = 4;
            this.BtnReturn.Text = "           Return Books";
            this.BtnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnRecords
            // 
            this.BtnRecords.BackColor = System.Drawing.Color.Black;
            this.BtnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecords.FlatAppearance.BorderSize = 0;
            this.BtnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecords.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecords.ForeColor = System.Drawing.Color.White;
            this.BtnRecords.Image = ((System.Drawing.Image)(resources.GetObject("BtnRecords.Image")));
            this.BtnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecords.Location = new System.Drawing.Point(3, 306);
            this.BtnRecords.Name = "BtnRecords";
            this.BtnRecords.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRecords.Size = new System.Drawing.Size(223, 54);
            this.BtnRecords.TabIndex = 5;
            this.BtnRecords.Text = "           Records";
            this.BtnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecords.UseVisualStyleBackColor = false;
            this.BtnRecords.Click += new System.EventHandler(this.BtnRecords_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Black;
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.Location = new System.Drawing.Point(3, 366);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnLogout.Size = new System.Drawing.Size(223, 54);
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.Text = "           Logout";
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click_1);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // BooksTimer
            // 
            this.BooksTimer.Interval = 10;
            this.BooksTimer.Tick += new System.EventHandler(this.BooksTimer_Tick);
            // 
            // MembersTimer
            // 
            this.MembersTimer.Interval = 10;
            this.MembersTimer.Tick += new System.EventHandler(this.MembersTimer_Tick);
            // 
            // BtnDashExit
            // 
            this.BtnDashExit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDashExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashExit.FlatAppearance.BorderSize = 0;
            this.BtnDashExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashExit.Image")));
            this.BtnDashExit.Location = new System.Drawing.Point(798, 12);
            this.BtnDashExit.Name = "BtnDashExit";
            this.BtnDashExit.Size = new System.Drawing.Size(33, 33);
            this.BtnDashExit.TabIndex = 1;
            this.BtnDashExit.UseVisualStyleBackColor = false;
            this.BtnDashExit.Click += new System.EventHandler(this.BtnDashExit_Click);
            // 
            // panelForm
            // 
            this.panelForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelForm.Controls.Add(this.panel5);
            this.panelForm.Location = new System.Drawing.Point(76, 47);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(755, 505);
            this.panelForm.TabIndex = 2;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(60, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(634, 198);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(475, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Library Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(70, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 5);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(70, 595);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 5);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(838, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 590);
            this.panel4.TabIndex = 5;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.BtnDashExit);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.BookMenu.ResumeLayout(false);
            this.MemberMenu.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBooks;
        private System.Windows.Forms.Button BtnMembers;
        private System.Windows.Forms.Button BtnIssue;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnRecords;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer BooksTimer;
        private System.Windows.Forms.Timer MembersTimer;
        private System.Windows.Forms.Button BtnViewBook;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.Panel BookMenu;
        private System.Windows.Forms.Button BtnAddMember;
        private System.Windows.Forms.Button BtnViewMember;
        private System.Windows.Forms.Panel MemberMenu;
        private System.Windows.Forms.Button BtnDashExit;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}