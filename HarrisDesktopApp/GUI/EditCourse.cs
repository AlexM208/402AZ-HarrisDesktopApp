using HarrisDesktopApp.DBOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisDesktopApp.GUI
{
    public partial class EditCourse : Form
    {
        private AdminOperations adminOperations = new AdminOperations();
        public EditCourse()
        {
            InitializeComponent();
        }
        private void EditCourse_Load(object sender, EventArgs e)
        {
            dataGridViewCourse.DataSource = adminOperations.GetCourseList();

        }
        private void LoadCourse()
        {
            dataGridViewCourse.DataSource = adminOperations.GetCourseList();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClickBack(object sender, EventArgs e)
        {
            AdminHomePage adminp1 = new AdminHomePage();
            adminp1.StartPosition = FormStartPosition.CenterScreen;
            adminp1.Show();
            this.Hide();

        }
    }
}
