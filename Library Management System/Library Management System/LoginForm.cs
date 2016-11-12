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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            new RegistrationForm();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String inpID = null, inpPass = null;

            inpID = loginIDTxt.Text;
            inpPass = loginPassTxt.Text;

            LibraryDataContext dbContext = new LibraryDataContext();
            Credential cred = null;

            try
            {
                cred = dbContext.Credentials.SingleOrDefault(x => x.ID == inpID);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input!");
            }
            String role = cred.ROLE;

            if (cred.PASS.Equals(inpPass))
            {
                if (role.Equals("STUDENT"))
                {
                    this.Visible = false;
                    new StudentForm(true, inpID).ShowDialog();
                }
                else if (role.Equals("ADMIN"))
                {
                    this.Visible = false;
                    new AdminForm(true, inpID).ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong Input!");
            }         
        }
    }
}
