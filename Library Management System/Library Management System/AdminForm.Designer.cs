namespace Library_Management_System
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.adminIDTxt = new System.Windows.Forms.TextBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bookIDTxt = new System.Windows.Forms.TextBox();
            this.bookNameTxt = new System.Windows.Forms.TextBox();
            this.bookTopicTxt = new System.Windows.Forms.TextBox();
            this.tQtyTxt = new System.Windows.Forms.TextBox();
            this.aQtyTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available Qty";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(95, 123);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 34);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add Book";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(241, 123);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 33);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(384, 123);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(94, 33);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Search";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(111, 176);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(150, 20);
            this.searchTxt.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(408, 169);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(90, 33);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchCombo
            // 
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Items.AddRange(new object[] {
            "Topic",
            "Name",
            "Book ID"});
            this.searchCombo.Location = new System.Drawing.Point(285, 176);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(93, 21);
            this.searchCombo.TabIndex = 14;
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 216);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(543, 326);
            this.table.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Admin ID";
            // 
            // adminIDTxt
            // 
            this.adminIDTxt.Location = new System.Drawing.Point(285, 13);
            this.adminIDTxt.Name = "adminIDTxt";
            this.adminIDTxt.ReadOnly = true;
            this.adminIDTxt.Size = new System.Drawing.Size(131, 20);
            this.adminIDTxt.TabIndex = 17;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(423, 13);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 18;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Topic";
            // 
            // bookIDTxt
            // 
            this.bookIDTxt.Location = new System.Drawing.Point(111, 47);
            this.bookIDTxt.Name = "bookIDTxt";
            this.bookIDTxt.Size = new System.Drawing.Size(148, 20);
            this.bookIDTxt.TabIndex = 20;
            // 
            // bookNameTxt
            // 
            this.bookNameTxt.Location = new System.Drawing.Point(343, 47);
            this.bookNameTxt.Name = "bookNameTxt";
            this.bookNameTxt.Size = new System.Drawing.Size(155, 20);
            this.bookNameTxt.TabIndex = 21;
            // 
            // bookTopicTxt
            // 
            this.bookTopicTxt.Location = new System.Drawing.Point(111, 84);
            this.bookTopicTxt.Name = "bookTopicTxt";
            this.bookTopicTxt.Size = new System.Drawing.Size(92, 20);
            this.bookTopicTxt.TabIndex = 22;
            // 
            // tQtyTxt
            // 
            this.tQtyTxt.Location = new System.Drawing.Point(268, 84);
            this.tQtyTxt.Name = "tQtyTxt";
            this.tQtyTxt.Size = new System.Drawing.Size(74, 20);
            this.tQtyTxt.TabIndex = 23;
            // 
            // aQtyTxt
            // 
            this.aQtyTxt.Location = new System.Drawing.Point(424, 84);
            this.aQtyTxt.Name = "aQtyTxt";
            this.aQtyTxt.Size = new System.Drawing.Size(74, 20);
            this.aQtyTxt.TabIndex = 24;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 554);
            this.Controls.Add(this.aQtyTxt);
            this.Controls.Add(this.tQtyTxt);
            this.Controls.Add(this.bookTopicTxt);
            this.Controls.Add(this.bookNameTxt);
            this.Controls.Add(this.bookIDTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.adminIDTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.table);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminIDTxt;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bookIDTxt;
        private System.Windows.Forms.TextBox bookNameTxt;
        private System.Windows.Forms.TextBox bookTopicTxt;
        private System.Windows.Forms.TextBox tQtyTxt;
        private System.Windows.Forms.TextBox aQtyTxt;
    }
}