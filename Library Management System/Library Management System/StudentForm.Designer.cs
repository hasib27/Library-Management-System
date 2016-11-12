namespace Library_Management_System
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.borrowCombo = new System.Windows.Forms.ComboBox();
            this.borrowTxt = new System.Windows.Forms.TextBox();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOPICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(222, 14);
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(142, 20);
            this.idTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(149, 49);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(165, 20);
            this.searchTxt.TabIndex = 3;
            // 
            // searchCombo
            // 
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Items.AddRange(new object[] {
            "Topic",
            "Name",
            "Book ID"});
            this.searchCombo.Location = new System.Drawing.Point(342, 49);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(90, 21);
            this.searchCombo.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(459, 49);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Borrow";
            // 
            // borrowCombo
            // 
            this.borrowCombo.FormattingEnabled = true;
            this.borrowCombo.Items.AddRange(new object[] {
            "Name",
            "Book ID"});
            this.borrowCombo.Location = new System.Drawing.Point(342, 85);
            this.borrowCombo.Name = "borrowCombo";
            this.borrowCombo.Size = new System.Drawing.Size(90, 21);
            this.borrowCombo.TabIndex = 7;
            // 
            // borrowTxt
            // 
            this.borrowTxt.Location = new System.Drawing.Point(149, 85);
            this.borrowTxt.Name = "borrowTxt";
            this.borrowTxt.Size = new System.Drawing.Size(165, 20);
            this.borrowTxt.TabIndex = 8;
            // 
            // borrowBtn
            // 
            this.borrowBtn.Location = new System.Drawing.Point(459, 82);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(75, 23);
            this.borrowBtn.TabIndex = 9;
            this.borrowBtn.Text = "Borrow";
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // table
            // 
            this.table.AutoGenerateColumns = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.bNAMEDataGridViewTextBoxColumn,
            this.tOPICDataGridViewTextBoxColumn,
            this.tQTYDataGridViewTextBoxColumn,
            this.aQTYDataGridViewTextBoxColumn});
            this.table.DataSource = this.bookBindingSource;
            this.table.Location = new System.Drawing.Point(24, 124);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(543, 382);
            this.table.TabIndex = 10;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "B_ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            // 
            // bNAMEDataGridViewTextBoxColumn
            // 
            this.bNAMEDataGridViewTextBoxColumn.DataPropertyName = "B_NAME";
            this.bNAMEDataGridViewTextBoxColumn.HeaderText = "B_NAME";
            this.bNAMEDataGridViewTextBoxColumn.Name = "bNAMEDataGridViewTextBoxColumn";
            // 
            // tOPICDataGridViewTextBoxColumn
            // 
            this.tOPICDataGridViewTextBoxColumn.DataPropertyName = "TOPIC";
            this.tOPICDataGridViewTextBoxColumn.HeaderText = "TOPIC";
            this.tOPICDataGridViewTextBoxColumn.Name = "tOPICDataGridViewTextBoxColumn";
            // 
            // tQTYDataGridViewTextBoxColumn
            // 
            this.tQTYDataGridViewTextBoxColumn.DataPropertyName = "T_QTY";
            this.tQTYDataGridViewTextBoxColumn.HeaderText = "T_QTY";
            this.tQTYDataGridViewTextBoxColumn.Name = "tQTYDataGridViewTextBoxColumn";
            // 
            // aQTYDataGridViewTextBoxColumn
            // 
            this.aQTYDataGridViewTextBoxColumn.DataPropertyName = "A_QTY";
            this.aQTYDataGridViewTextBoxColumn.HeaderText = "A_QTY";
            this.aQTYDataGridViewTextBoxColumn.Name = "aQTYDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Library_Management_System.Book);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(492, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 11;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Borrow History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.table);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.borrowTxt);
            this.Controls.Add(this.borrowCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox borrowCombo;
        private System.Windows.Forms.TextBox borrowTxt;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOPICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
    }
}