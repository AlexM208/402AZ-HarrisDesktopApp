using HarrisDesktopApp.GUI;
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
       
        public LoginPage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

       
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoginClick(object sender, EventArgs e)
        {
            string adminUser = "admin";
            string adminPasw = "admin";
            string stUser = "student";
            string stPasw = "student";
            string TeacherPasw = "teacher";
            string TeacherUser = "teacher";
            if((textBoxUsername.Text==adminUser) && (textBoxPassword.Text == adminPasw))
            {
                 AdminHomePage adminp1 = new AdminHomePage();
                adminp1.StartPosition = FormStartPosition.CenterScreen;
                 adminp1.Show();
                 this.Hide();
                //Application.Run(new AdminHomePage());
                lblPasswordInvalid.Hide();
            }
            else if ((textBoxUsername.Text == stUser) && (textBoxPassword.Text == stPasw))
            {
                StudentHomeP studentPage1 = new StudentHomeP();
                studentPage1.StartPosition = FormStartPosition.CenterScreen;
                studentPage1.Show();
                this.Hide();
                //Application.Run(new StudentHomeP());
                lblPasswordInvalid.Hide();

            }
            else if ((textBoxUsername.Text == TeacherUser) && (textBoxPassword.Text == TeacherPasw))
            {
                TeacherHomePage teacherPage1 = new TeacherHomePage();
                teacherPage1.StartPosition = FormStartPosition.CenterScreen;
                teacherPage1.Show();
                this.Hide();
                //Application.Run(new StudentHomeP());
                lblPasswordInvalid.Hide();

            }
            else
            {
                lblPasswordInvalid.Show();
            }
        }
    }
}
