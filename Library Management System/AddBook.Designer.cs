namespace Library_Management_System
{
    partial class FrmAddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAddBook = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblBookTitle = new System.Windows.Forms.Label();
            this.TxtBookTitle = new System.Windows.Forms.TextBox();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.LblPublisher = new System.Windows.Forms.Label();
            this.TxtPublisher = new System.Windows.Forms.TextBox();
            this.LblQty = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LblAddBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 92);
            this.panel1.TabIndex = 0;
            // 
            // LblAddBook
            // 
            this.LblAddBook.AutoSize = true;
            this.LblAddBook.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddBook.ForeColor = System.Drawing.Color.White;
            this.LblAddBook.Image = ((System.Drawing.Image)(resources.GetObject("LblAddBook.Image")));
            this.LblAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblAddBook.Location = new System.Drawing.Point(291, 30);
            this.LblAddBook.Name = "LblAddBook";
            this.LblAddBook.Size = new System.Drawing.Size(184, 32);
            this.LblAddBook.TabIndex = 0;
            this.LblAddBook.Text = "     Add Book";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 500);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(755, 5);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // LblBookTitle
            // 
            this.LblBookTitle.AutoSize = true;
            this.LblBookTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookTitle.Location = new System.Drawing.Point(137, 147);
            this.LblBookTitle.Name = "LblBookTitle";
            this.LblBookTitle.Size = new System.Drawing.Size(97, 23);
            this.LblBookTitle.TabIndex = 2;
            this.LblBookTitle.Text = "Book Title";
            // 
            // TxtBookTitle
            // 
            this.TxtBookTitle.BackColor = System.Drawing.Color.White;
            this.TxtBookTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookTitle.Location = new System.Drawing.Point(309, 145);
            this.TxtBookTitle.Name = "TxtBookTitle";
            this.TxtBookTitle.Size = new System.Drawing.Size(316, 31);
            this.TxtBookTitle.TabIndex = 7;
            this.TxtBookTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.BackColor = System.Drawing.Color.White;
            this.TxtAuthor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAuthor.Location = new System.Drawing.Point(309, 192);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(316, 31);
            this.TxtAuthor.TabIndex = 9;
            this.TxtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblPublisher
            // 
            this.LblPublisher.AutoSize = true;
            this.LblPublisher.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPublisher.Location = new System.Drawing.Point(137, 241);
            this.LblPublisher.Name = "LblPublisher";
            this.LblPublisher.Size = new System.Drawing.Size(92, 23);
            this.LblPublisher.TabIndex = 8;
            this.LblPublisher.Text = "Publisher";
            // 
            // TxtPublisher
            // 
            this.TxtPublisher.BackColor = System.Drawing.Color.White;
            this.TxtPublisher.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPublisher.Location = new System.Drawing.Point(309, 239);
            this.TxtPublisher.Name = "TxtPublisher";
            this.TxtPublisher.Size = new System.Drawing.Size(316, 31);
            this.TxtPublisher.TabIndex = 11;
            this.TxtPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblQty
            // 
            this.LblQty.AutoSize = true;
            this.LblQty.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQty.Location = new System.Drawing.Point(138, 333);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(89, 23);
            this.LblQty.TabIndex = 10;
            this.LblQty.Text = "Quantity";
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.Color.White;
            this.TxtPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(309, 285);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(316, 31);
            this.TxtPrice.TabIndex = 13;
            this.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(138, 287);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(107, 23);
            this.LblPrice.TabIndex = 12;
            this.LblPrice.Text = "Book Price";
            // 
            // TxtQty
            // 
            this.TxtQty.BackColor = System.Drawing.Color.White;
            this.TxtQty.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQty.Location = new System.Drawing.Point(309, 331);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(316, 31);
            this.TxtQty.TabIndex = 15;
            this.TxtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthor.Location = new System.Drawing.Point(137, 194);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(70, 23);
            this.LblAuthor.TabIndex = 14;
            this.LblAuthor.Text = "Author";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Black;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(342, 415);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 35);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(750, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 408);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 408);
            this.panel3.TabIndex = 18;
            // 
            // FrmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(755, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TxtPublisher);
            this.Controls.Add(this.LblQty);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.LblPublisher);
            this.Controls.Add(this.TxtBookTitle);
            this.Controls.Add(this.LblBookTitle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblAddBook;
        private System.Windows.Forms.Label LblBookTitle;
        private System.Windows.Forms.TextBox TxtBookTitle;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.Label LblPublisher;
        private System.Windows.Forms.TextBox TxtPublisher;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}