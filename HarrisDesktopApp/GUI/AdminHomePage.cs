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
    public partial class AdminHomePage : Form
    {
        private AdminOperations adminOps = new AdminOperations();

        public AdminHomePage()
        {
            InitializeComponent();
        }

        public void BackButton()
        {
            AdminHomePage adminp1 = new AdminHomePage();
            adminp1.StartPosition = FormStartPosition.CenterScreen;
            adminp1.Show();
            this.Hide();

        }



        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        

        private void buttonClickTeacherDets(object sender, EventArgs e)
        {
            EditTeacher teacher1 = new EditTeacher();
            teacher1.StartPosition = FormStartPosition.CenterScreen;
            teacher1.Show();
            this.Hide();
        }

        

        

        private void buttonClickBackAdminP(object sender, EventArgs e)
        {
            AdminHomePage adminp1 = new AdminHomePage();
            adminp1.StartPosition = FormStartPosition.CenterScreen;
            adminp1.Show();
            this.Hide();
        }

        private void buttonClickCourseList(object sender, EventArgs e)
        {
            EditCourse course1 = new EditCourse();
            course1.StartPosition = FormStartPosition.CenterScreen;
            course1.Show();

            this.Hide();
        }

        private void btnClickStudentDets(object sender, EventArgs e)
        {
            EditStudent student1 = new EditStudent();
            student1.StartPosition = FormStartPosition.CenterScreen;
            student1.Show();
         
            this.Hide();
        }

        private void btnClickWorksheetsDets(object sender, EventArgs e)
        {
            EditWorksheet worksheet1 = new EditWorksheet();
            worksheet1.StartPosition = FormStartPosition.CenterScreen;
            worksheet1.Show();
            this.Hide();
        }

        private void btnClickClassDets(object sender, EventArgs e)
        {
            EditClass class1 = new EditClass();
            class1.StartPosition = FormStartPosition.CenterScreen;
            class1.Show();
            this.Hide();
        }

        private void btnClickModuleDets(object sender, EventArgs e)
        {
            EditModule module1 = new EditModule();
            module1.StartPosition = FormStartPosition.CenterScreen;
            module1.Show();
            this.Hide();
        }

        private void btnClickMaterialsDets(object sender, EventArgs e)
        {
            EditMaterials material1 = new EditMaterials();
            material1.StartPosition = FormStartPosition.CenterScreen;
            material1.Show();
            material1.btnBackToStudent.Hide();
            material1.btnBackToTeacher.Hide();
            material1.courseBtnToAdminHP.Show();
            this.Hide();
        }

        private void btnClickEnrolmentDets(object sender, EventArgs e)
        {
            EditEnrolment enr1 = new EditEnrolment();
            enr1.StartPosition = FormStartPosition.CenterScreen;
            enr1.Show();
            this.Hide();
        }

        private void btnClickTimetableDets(object sender, EventArgs e)
        {
            dataGridViewTimetblDets.DataSource = adminOps.GetTimetable();
            dataGridViewTimetblDets.Show();
        }

      

        private void btnClickLogoutAdmin(object sender, EventArgs e)
        {
            LoginPage login1 = new LoginPage();
            login1.StartPosition = FormStartPosition.CenterScreen;
            login1.Show();
            this.Hide();

        }

        private void btnClickRefreshTimetblDets(object sender, EventArgs e)
        {
            dataGridViewTimetblDets.Hide();
        }
    }
}
