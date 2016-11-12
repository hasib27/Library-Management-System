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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Credential cred = new Credential();
            cred.ID = idTxt.Text;
            String p1 = passTxt.Text;
            String p2 = passReTxt.Text;
            if(!p1.Equals(p2))
            {
                MessageBox.Show("Password do not match!");
                return;
            }
            cred.PASS = passTxt.Text;
            cred.ROLE = "STUDENT";
            LibraryDataContext dbContext = new LibraryDataContext();
            dbContext.Credentials.InsertOnSubmit(cred);
            dbContext.SubmitChanges();
            MessageBox.Show("Registration Successful!");
        }
    }
}
