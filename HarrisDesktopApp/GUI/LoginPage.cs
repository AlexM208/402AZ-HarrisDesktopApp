using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisDesktopApp
{
    public partial class LoginPage : Form
    {
        private const string AdminUsername = "admin";
        private const string AdminPassword = "admin";
        public LoginPage()
        {
            InitializeComponent();
        }

       
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoginClick(object sender, EventArgs e)
        {
            string adminUser = "admin";
            string adminPasw = "admin";
            if((textBoxUsername.Text==adminUser) && (textBoxPassword.Text == adminPasw))
            {
                 AdminHomePage adminp1 = new AdminHomePage();
                 adminp1.Show();
                 this.Hide();
                //Application.Run(new AdminHomePage());
                lblPasswordInvalid.Hide();
            }
            else
            {
                lblPasswordInvalid.Show();
            }
        }
    }
}
