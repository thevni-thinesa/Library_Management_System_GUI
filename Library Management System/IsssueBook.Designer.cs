namespace Library_Management_System
{
    partial class FrmIsssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIsssueBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblIssueBook = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtBID = new System.Windows.Forms.TextBox();
            this.LblBID = new System.Windows.Forms.Label();
            this.TxtMID = new System.Windows.Forms.TextBox();
            this.LblMID = new System.Windows.Forms.Label();
            this.BtnIssue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LblIssueBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 92);
            this.panel1.TabIndex = 1;
            // 
            // LblIssueBook
            // 
            this.LblIssueBook.AutoSize = true;
            this.LblIssueBook.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIssueBook.ForeColor = System.Drawing.Color.White;
            this.LblIssueBook.Image = ((System.Drawing.Image)(resources.GetObject("LblIssueBook.Image")));
            this.LblIssueBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblIssueBook.Location = new System.Drawing.Point(291, 30);
            this.LblIssueBook.Name = "LblIssueBook";
            this.LblIssueBook.Size = new System.Drawing.Size(193, 32);
            this.LblIssueBook.TabIndex = 0;
            this.LblIssueBook.Text = "     Issue Book";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 408);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(750, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 408);
            this.panel2.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 500);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(755, 5);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // TxtBID
            // 
            this.TxtBID.BackColor = System.Drawing.Color.White;
            this.TxtBID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBID.Location = new System.Drawing.Point(304, 228);
            this.TxtBID.Name = "TxtBID";
            this.TxtBID.Size = new System.Drawing.Size(325, 31);
            this.TxtBID.TabIndex = 37;
            this.TxtBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblBID
            // 
            this.LblBID.AutoSize = true;
            this.LblBID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBID.Location = new System.Drawing.Point(134, 230);
            this.LblBID.Name = "LblBID";
            this.LblBID.Size = new System.Drawing.Size(79, 23);
            this.LblBID.TabIndex = 36;
            this.LblBID.Text = "Book ID";
            // 
            // TxtMID
            // 
            this.TxtMID.BackColor = System.Drawing.Color.White;
            this.TxtMID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMID.Location = new System.Drawing.Point(304, 180);
            this.TxtMID.Name = "TxtMID";
            this.TxtMID.Size = new System.Drawing.Size(325, 31);
            this.TxtMID.TabIndex = 31;
            this.TxtMID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtMID.TextChanged += new System.EventHandler(this.TxtMID_TextChanged);
            // 
            // LblMID
            // 
            this.LblMID.AutoSize = true;
            this.LblMID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMID.Location = new System.Drawing.Point(134, 182);
            this.LblMID.Name = "LblMID";
            this.LblMID.Size = new System.Drawing.Size(111, 23);
            this.LblMID.TabIndex = 30;
            this.LblMID.Text = "Member ID";
            // 
            // BtnIssue
            // 
            this.BtnIssue.BackColor = System.Drawing.Color.Black;
            this.BtnIssue.FlatAppearance.BorderSize = 0;
            this.BtnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIssue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIssue.ForeColor = System.Drawing.Color.White;
            this.BtnIssue.Location = new System.Drawing.Point(326, 295);
            this.BtnIssue.Name = "BtnIssue";
            this.BtnIssue.Size = new System.Drawing.Size(113, 35);
            this.BtnIssue.TabIndex = 40;
            this.BtnIssue.Text = "Issue Book";
            this.BtnIssue.UseVisualStyleBackColor = false;
            this.BtnIssue.Click += new System.EventHandler(this.BtnIssue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "(Maximum 3 Books Can Be Issued To 1 Member)";
            // 
            // FrmIsssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIssue);
            this.Controls.Add(this.TxtBID);
            this.Controls.Add(this.LblBID);
            this.Controls.Add(this.TxtMID);
            this.Controls.Add(this.LblMID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIsssueBook";
            this.Text = "IsssueBook";
            this.Load += new System.EventHandler(this.FrmIsssueBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblIssueBook;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TxtBID;
        private System.Windows.Forms.Label LblBID;
        private System.Windows.Forms.TextBox TxtMID;
        private System.Windows.Forms.Label LblMID;
        private System.Windows.Forms.Button BtnIssue;
        private System.Windows.Forms.Label label1;
    }
}