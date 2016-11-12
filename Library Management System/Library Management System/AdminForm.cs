using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AdminForm : Form
    {
        private bool loggedIn = false;
        private String ID = null;
        
        public AdminForm()
        {
            InitializeComponent();
            
            LibraryDataContext dbContext = new LibraryDataContext();
            table.DataSource = dbContext.Books;
        }

        public AdminForm(bool loggedIn, String ID)
        {
            InitializeComponent();
            this.loggedIn = loggedIn;
            this.ID = ID;
            this.adminIDTxt.Text = ID;
            LibraryDataContext dbContext = new LibraryDataContext();
            table.DataSource = dbContext.Books;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LibraryDataContext dbContext = new LibraryDataContext();
            String searchStr = searchTxt.Text;

            if (searchCombo.SelectedItem.ToString().Equals("Topic"))
            {
                var result = dbContext.Books.Where(x => x.TOPIC == searchStr);
                table.DataSource = result;
            }
            else if (searchCombo.SelectedItem.ToString().Equals("Name"))
            {
                var result = dbContext.Books.Where(x => x.B_NAME == searchStr);
                table.DataSource = result;
            }
            else if (searchCombo.SelectedItem.ToString().Equals("Book ID"))
            {
                var result = dbContext.Books.Where(x => x.B_ID == searchStr);
                table.DataSource = result;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            LibraryDataContext dbContext = new LibraryDataContext();
            Book book = new Book();
            book.B_ID = bookIDTxt.Text;
            book.B_NAME = bookNameTxt.Text;
            book.TOPIC = bookTopicTxt.Text;
            book.T_QTY = Int32.Parse(tQtyTxt.Text);
            book.A_QTY = Int32.Parse(aQtyTxt.Text);
            dbContext.Books.InsertOnSubmit(book);
            dbContext.SubmitChanges();
            MessageBox.Show("Book Added!");
            table.DataSource = dbContext.Books;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            String bookID = bookIDTxt.Text;

            LibraryDataContext dbContext = new LibraryDataContext();
            Book book = dbContext.Books.SingleOrDefault(x => x.B_ID == bookID);

            book.B_NAME = bookNameTxt.Text;
            book.TOPIC = bookTopicTxt.Text;
            book.T_QTY = Int32.Parse(tQtyTxt.Text);
            book.A_QTY = Int32.Parse(aQtyTxt.Text);
            dbContext.SubmitChanges();
            MessageBox.Show("Information Updated!");
            table.DataSource = dbContext.Books;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            String bookID = bookIDTxt.Text;

            LibraryDataContext dbContext = new LibraryDataContext();
            Book book = dbContext.Books.SingleOrDefault(x => x.B_ID == bookID);
            
            dbContext.Books.DeleteOnSubmit(book);
            dbContext.SubmitChanges();
            MessageBox.Show("Book Removed!");
            table.DataSource = dbContext.Books;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.loggedIn = false;
            this.ID = null;
            this.Hide();
            new LoginForm().ShowDialog();
        }

    }
}
