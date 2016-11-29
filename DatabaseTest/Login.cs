using DatabaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseTest
{
    public partial class Login : Form
    {
        private Credentials c;
        public Login()
        {
            InitializeComponent();
            //SqlManagement m = new SqlManagement();
        }

        public Credentials LoginCredentials
        {
            get
            {
                return c;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            c = new Credentials(txtServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text);
            this.Close();
        }
    }
}
