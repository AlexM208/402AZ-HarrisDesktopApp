using HarrisDesktopApp.DBOperations;
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
    public partial class TeacherHomePage : Form
    {
        private TeacherOperations teacherOperations = new TeacherOperations();
        public TeacherHomePage()
        {
            InitializeComponent();
        }

        private void TeacherHomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnClickLogoutTeacher(object sender, EventArgs e)
        {
            LoginPage login1 = new LoginPage();
            login1.StartPosition = FormStartPosition.CenterScreen;
            login1.Show();
            this.Hide();
            
        }

        private void btnClickTimetableDets(object sender, EventArgs e)
        {
            dataGridViewTimetableTeacher.DataSource = teacherOperations.GetTimetable();
            dataGridViewStTeacher.Hide();
            dataGridViewTimetableTeacher.Show();
            dataGridViewStClass.Hide();
        }

        private void btnClickMaterialsDets(object sender, EventArgs e)
        {
            EditMaterials material1 = new EditMaterials();
            material1.StartPosition = FormStartPosition.CenterScreen;
            material1.Show();
            material1.btnBackToStudent.Hide();
            material1.btnBackToTeacher.Show();
            material1.courseBtnToAdminHP.Hide();
            this.Hide();
        }

        private void btnClickStudentDets(object sender, EventArgs e)
        {
            dataGridViewStTeacher.DataSource = teacherOperations.GetStudents();
            dataGridViewStTeacher.Show();
            dataGridViewTimetableTeacher.Hide();
            dataGridViewStClass.Hide();
        }

        private void dataGridViewStTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // get the selected row Student Room
        private double GetSelectedRowStudentRoom()
        {
            if (dataGridViewStClass.SelectedRows.Count > 0)
            {
                
                return Convert.ToDouble(dataGridViewStClass.SelectedRows[9].Cells["s_class_room"].Value);
            }
            return -1;

        }

      /* private void btnClickShowStClass(object sender, EventArgs e)
        {

        }*/

    }
}
