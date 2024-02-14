using HarrisDesktopApp.DBOperations;
using HarrisDesktopApp.Models;
using System;
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
            dataGridViewCourseList.DataSource = adminOperations.GetCourseList();

        }
        // operation for showing Course List details
        private void LoadCourse()
        {
            dataGridViewCourseList.DataSource = adminOperations.GetCourseList();
        }

        // selecting row in Course List table and replacing values

        private CourseList GetSelectedRowCourseList()
        {
            if (dataGridViewCourseList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCourseList.SelectedRows[0];
                return new CourseList
                {
                    courseID = Convert.ToInt32(selectedRow.Cells["course_id"].Value),
                    courseCode = Convert.ToString(selectedRow.Cells["course_code"].Value),
                    xc_courseName = Convert.ToString(selectedRow.Cells["course_name"].Value),
                    startDate = Convert.ToDateTime(selectedRow.Cells["start_date"].Value),
                    endDate = Convert.ToDateTime(selectedRow.Cells["end_date"].Value),
                    xc_normal_Accelerated = Convert.ToString(selectedRow.Cells["normal_accelerated"].Value),
                    

                };
            }
            return null;
        }

        // clearing fields for Course List
        private void ClearCourseListFields()
        {
            txtCourseCode.Clear();
            txtCourseName.Clear();
            txtCourseType.Clear();
            
        }

        // get the selected row Course id

        private int GetSelectedRowCourseListId()
        {
            if (dataGridViewCourseList.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewCourseList.SelectedRows[0].Cells["course_id"].Value);
            }
            return -1;

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

        //create and save new course
        private void btnAddClickCourse(object sender, EventArgs e)
        {
            CourseList newCourse = new CourseList 
            {
                courseCode = txtCourseCode.Text,
                xc_courseName = txtCourseName.Text,
                startDate = dateTimePickerStart.Value,
                endDate = dateTimePickerEnd.Value,
                xc_normal_Accelerated = txtCourseType.Text,
                
            };
            adminOperations.AddCourseList(newCourse);
            LoadCourse();
            ClearCourseListFields();

        }

        //update button 
        private void btnClickUpdateCourse(object sender, EventArgs e)
        {
            if (dataGridViewCourseList.SelectedRows.Count > 0)
            {
                CourseList selectedCourse = GetSelectedRowCourseList();
                if (selectedCourse != null)
                {
                    selectedCourse.courseCode = txtCourseCode.Text;
                    selectedCourse.xc_courseName = txtCourseName.Text;
                    selectedCourse.startDate = dateTimePickerStart.Value;
                    selectedCourse.endDate = dateTimePickerEnd.Value;
                    selectedCourse.xc_normal_Accelerated = txtCourseType.Text;
                    

                    adminOperations.UpdateCourseList(selectedCourse);
                    LoadCourse();
                    ClearCourseListFields();
                }
            }
        }

        private void btnClickDeleteCourse(object sender, EventArgs e)
        {
            if (dataGridViewCourseList.SelectedRows.Count > 0)
            {
                int courseId1 = GetSelectedRowCourseListId();

                if (courseId1 != -1)
                {
                    adminOperations.DeleteCourseList(courseId1);
                    LoadCourse();
                    ClearCourseListFields();
                }
                else
                {
                    MessageBox.Show("Please select a customer to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void btnClickRefreshCourseList(object sender, EventArgs e)
        {
            LoadCourse();
        }
    }
}
