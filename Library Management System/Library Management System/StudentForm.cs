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
    public partial class StudentForm : Form
    {
        private bool loggedIn = false;
        private String ID = null;

        public StudentForm()
        {
            InitializeComponent();
        }

        public StudentForm(bool loggedIn, String ID)
        {
            InitializeComponent();
            this.loggedIn = loggedIn;
            this.ID = ID;
            this.idTxt.Text = ID;
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.loggedIn = false;
            this.ID = null;
            this.Hide();
            new LoginForm().ShowDialog();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            LibraryDataContext dbContext = new LibraryDataContext();
            String borrowStr = borrowTxt.Text;

            Book book = null;

            if (borrowCombo.SelectedItem.ToString().Equals("Name"))
            {
                book = dbContext.Books.SingleOrDefault(x => x.B_NAME == borrowStr);
            }
            else if (borrowCombo.SelectedItem.ToString().Equals("Book ID"))
            {
                book = dbContext.Books.SingleOrDefault(x => x.B_ID == borrowStr);
            }
            Borrow borrow = new Borrow();
            borrow.ID = ID;
            borrow.B_ID = book.B_ID;
            borrow.B_NAME = book.B_NAME;
            borrow.TOPIC = book.TOPIC;
            dbContext.Borrows.InsertOnSubmit(borrow);
            dbContext.SubmitChanges();
            MessageBox.Show("Book borrowed!");
            table.DataSource = dbContext.Books;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryDataContext dbContext = new LibraryDataContext();
            
            var result = dbContext.Borrows.Where(x => x.ID == ID);
            table.DataSource = result;
        }
    }
}
