namespace Library_Management_System
{
    partial class FrmReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReturnBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblReturnBook = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtMemID = new System.Windows.Forms.TextBox();
            this.BtnRfresh = new System.Windows.Forms.Button();
            this.LblMemID = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblReturn = new System.Windows.Forms.Label();
            this.LblIssue = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtBID = new System.Windows.Forms.TextBox();
            this.LblBookID = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TxtMID = new System.Windows.Forms.TextBox();
            this.LblMID = new System.Windows.Forms.Label();
            this.TxtReturn = new System.Windows.Forms.TextBox();
            this.TxtIssue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LblReturnBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 92);
            this.panel1.TabIndex = 22;
            // 
            // LblReturnBook
            // 
            this.LblReturnBook.AutoSize = true;
            this.LblReturnBook.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturnBook.ForeColor = System.Drawing.Color.White;
            this.LblReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("LblReturnBook.Image")));
            this.LblReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblReturnBook.Location = new System.Drawing.Point(291, 30);
            this.LblReturnBook.Name = "LblReturnBook";
            this.LblReturnBook.Size = new System.Drawing.Size(210, 32);
            this.LblReturnBook.TabIndex = 0;
            this.LblReturnBook.Text = "     Return Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(750, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 500);
            this.panel2.TabIndex = 24;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 500);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(755, 5);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // TxtMemID
            // 
            this.TxtMemID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemID.Location = new System.Drawing.Point(286, 98);
            this.TxtMemID.Name = "TxtMemID";
            this.TxtMemID.Size = new System.Drawing.Size(202, 22);
            this.TxtMemID.TabIndex = 49;
            this.TxtMemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtMemID.TextChanged += new System.EventHandler(this.TxtMemID_TextChanged);
            // 
            // BtnRfresh
            // 
            this.BtnRfresh.BackColor = System.Drawing.Color.Black;
            this.BtnRfresh.FlatAppearance.BorderSize = 0;
            this.BtnRfresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRfresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRfresh.ForeColor = System.Drawing.Color.White;
            this.BtnRfresh.Location = new System.Drawing.Point(494, 97);
            this.BtnRfresh.Name = "BtnRfresh";
            this.BtnRfresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRfresh.TabIndex = 48;
            this.BtnRfresh.Text = "Refresh";
            this.BtnRfresh.UseVisualStyleBackColor = false;
            this.BtnRfresh.Click += new System.EventHandler(this.BtnRfresh_Click);
            // 
            // LblMemID
            // 
            this.LblMemID.AutoSize = true;
            this.LblMemID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMemID.Location = new System.Drawing.Point(202, 101);
            this.LblMemID.Name = "LblMemID";
            this.LblMemID.Size = new System.Drawing.Size(78, 16);
            this.LblMemID.TabIndex = 47;
            this.LblMemID.Text = "Member ID";
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.Black;
            this.BtnReturn.FlatAppearance.BorderSize = 0;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(340, 128);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 38;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblReturn
            // 
            this.LblReturn.AutoSize = true;
            this.LblReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturn.Location = new System.Drawing.Point(376, 71);
            this.LblReturn.Name = "LblReturn";
            this.LblReturn.Size = new System.Drawing.Size(82, 16);
            this.LblReturn.TabIndex = 54;
            this.LblReturn.Text = "Return Date";
            // 
            // LblIssue
            // 
            this.LblIssue.AutoSize = true;
            this.LblIssue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIssue.Location = new System.Drawing.Point(377, 36);
            this.LblIssue.Name = "LblIssue";
            this.LblIssue.Size = new System.Drawing.Size(73, 16);
            this.LblIssue.TabIndex = 46;
            this.LblIssue.Text = "Issue Date";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(-68, 241);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(575, 184);
            this.panel5.TabIndex = 39;
            // 
            // TxtBID
            // 
            this.TxtBID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBID.Location = new System.Drawing.Point(114, 68);
            this.TxtBID.Name = "TxtBID";
            this.TxtBID.Size = new System.Drawing.Size(228, 22);
            this.TxtBID.TabIndex = 38;
            this.TxtBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblBookID
            // 
            this.LblBookID.AutoSize = true;
            this.LblBookID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookID.Location = new System.Drawing.Point(29, 71);
            this.LblBookID.Name = "LblBookID";
            this.LblBookID.Size = new System.Drawing.Size(56, 16);
            this.LblBookID.TabIndex = 37;
            this.LblBookID.Text = "Book ID";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TxtMID);
            this.panel6.Controls.Add(this.LblMID);
            this.panel6.Controls.Add(this.TxtReturn);
            this.panel6.Controls.Add(this.TxtIssue);
            this.panel6.Controls.Add(this.BtnReturn);
            this.panel6.Controls.Add(this.LblReturn);
            this.panel6.Controls.Add(this.LblIssue);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.TxtBID);
            this.panel6.Controls.Add(this.LblBookID);
            this.panel6.Location = new System.Drawing.Point(11, 309);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(731, 184);
            this.panel6.TabIndex = 46;
            // 
            // TxtMID
            // 
            this.TxtMID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMID.Location = new System.Drawing.Point(114, 33);
            this.TxtMID.Name = "TxtMID";
            this.TxtMID.Size = new System.Drawing.Size(228, 22);
            this.TxtMID.TabIndex = 61;
            this.TxtMID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblMID
            // 
            this.LblMID.AutoSize = true;
            this.LblMID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMID.Location = new System.Drawing.Point(29, 36);
            this.LblMID.Name = "LblMID";
            this.LblMID.Size = new System.Drawing.Size(78, 16);
            this.LblMID.TabIndex = 60;
            this.LblMID.Text = "Member ID";
            // 
            // TxtReturn
            // 
            this.TxtReturn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReturn.Location = new System.Drawing.Point(473, 68);
            this.TxtReturn.Name = "TxtReturn";
            this.TxtReturn.Size = new System.Drawing.Size(228, 22);
            this.TxtReturn.TabIndex = 59;
            this.TxtReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtReturn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtIssue
            // 
            this.TxtIssue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIssue.Location = new System.Drawing.Point(473, 33);
            this.TxtIssue.Name = "TxtIssue";
            this.TxtIssue.Size = new System.Drawing.Size(228, 22);
            this.TxtIssue.TabIndex = 58;
            this.TxtIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(11, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 177);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 500);
            this.panel3.TabIndex = 25;
            // 
            // FrmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtMemID);
            this.Controls.Add(this.BtnRfresh);
            this.Controls.Add(this.LblMemID);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReturnBook";
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.FrmReturnBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblReturnBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TxtMemID;
        private System.Windows.Forms.Button BtnRfresh;
        private System.Windows.Forms.Label LblMemID;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label LblReturn;
        private System.Windows.Forms.Label LblIssue;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TxtBID;
        private System.Windows.Forms.Label LblBookID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtIssue;
        private System.Windows.Forms.TextBox TxtReturn;
        private System.Windows.Forms.TextBox TxtMID;
        private System.Windows.Forms.Label LblMID;
    }
}