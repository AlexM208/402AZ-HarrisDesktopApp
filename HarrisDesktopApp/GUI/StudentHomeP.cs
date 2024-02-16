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
    public partial class StudentHomeP : Form
    {
        private StudentOperations studentOperations= new StudentOperations();
        public StudentHomeP()
        {
            InitializeComponent();
        }

        private void btnClickShowTimetable(object sender, EventArgs e)
        {
            dataGridViewStTimetable.DataSource = studentOperations.GetTimetable();
            dataGridViewStMaterials.Hide();
            dataGridViewStTimetable.Show();

        }

        private void btnClickShowMaterials(object sender, EventArgs e)
        {
            dataGridViewStMaterials.DataSource = studentOperations.GetMaterials();
            dataGridViewStTimetable.Hide();
            dataGridViewStMaterials.Show();

        }

        private void btnClickLogoutStudent(object sender, EventArgs e)
        {
            LoginPage login1 = new LoginPage();
            login1.StartPosition = FormStartPosition.CenterScreen;
            login1.Show();
            this.Hide();
        }

        private void btnClickRefresh(object sender, EventArgs e)
        {
            dataGridViewStTimetable.Hide();
            dataGridViewStMaterials.Hide();

        }
    }
}
