using HarrisDesktopApp.DBOperations;
using HarrisDesktopApp.Models;
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
    public partial class EditStudent : Form
    {
        private AdminOperations adminOperations = new AdminOperations();
        public EditStudent()
        {
            InitializeComponent();
        }
        private void EditStudent_Load(object sender, EventArgs e)
        {
            dataGridViewStudent.DataSource = adminOperations.GetStudents();

        }

        // operation for showing Student details

        private void LoadStudents()
        {
            dataGridViewStudent.DataSource = adminOperations.GetStudents();
        }

        // selecting row in Student  and replacing values

        private Student GetSelectedRowStudent()
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewStudent.SelectedRows[0];
                return new Student
                {
                    Id = Convert.ToInt32(selectedRow.Cells["s_id"].Value),
                    Lname = Convert.ToString(selectedRow.Cells["s_Lname"].Value),
                    Fname = Convert.ToString(selectedRow.Cells["s_Fname"].Value),
                    email = Convert.ToString(selectedRow.Cells["s_email"].Value),
                    ss_phone = Convert.ToString(selectedRow.Cells["s_phone"].Value),
                    ss_address = Convert.ToString(selectedRow.Cells["s_address"].Value),
                    ss_postcode = Convert.ToString(selectedRow.Cells["s_postcode"].Value),
                    ss_grade_CW2 = Convert.ToString(selectedRow.Cells["grade_CW2"].Value),
                    ss_pass_fail = Convert.ToString(selectedRow.Cells["pass_fail"].Value),
                    timetableID = Convert.ToInt32(selectedRow.Cells["timetable_id"].Value),

                };
            }
            return null;
        }

        // clearing fields for Student
        private void ClearStudentFields()
        {
            txtStPhone.Clear();
            txtStEmail.Clear();
            txtStFname.Clear();
            txtStLname.Clear();
            txtStPostcode.Clear();
            txtStAddress.Clear();
            txtStGrade.Clear();
            txtStPassFail.Clear();
            txtStTimetableId.Clear();
        }

        // get the selected row Student id
        private int GetSelectedRowStudentId()
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewStudent.SelectedRows[0].Cells["s_id"].Value);
            }
            return -1;

        }

        //Create and save Student button
        private void btnClickAddStudent(object sender, EventArgs e)
        {
            Student newStudent = new Student
            {
                Lname = txtStLname.Text,
                Fname = txtStFname.Text,
                email = txtStEmail.Text,
                ss_phone = txtStPhone.Text,
                ss_address = txtStAddress.Text,
                ss_postcode = txtStPostcode.Text,
                ss_grade_CW2 = txtStGrade.Text,
                ss_pass_fail = txtStPassFail.Text,
                timetableID = Convert.ToInt32(txtStTimetableId.Text),
            };
            adminOperations.AddStudent(newStudent);
            ClearStudentFields();
            LoadStudents();
        }

        //update button
        private void btnClickUpdateStudent(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                Student selectedStudent = GetSelectedRowStudent();
                if (selectedStudent != null)
                
                    selectedStudent.Lname = txtStLname.Text;
                    selectedStudent.Fname = txtStFname.Text;
                    selectedStudent.email = txtStEmail.Text;
                    selectedStudent.ss_phone = txtStPhone.Text;
                    selectedStudent.ss_address = txtStAddress.Text;
                    selectedStudent.ss_postcode = txtStPostcode.Text;
                    selectedStudent.ss_grade_CW2 = txtStGrade.Text;
                    selectedStudent.ss_pass_fail = txtStPassFail.Text;
                    selectedStudent.timetableID = Convert.ToInt32(txtStTimetableId.Text);


                    adminOperations.UpdateStudent(selectedStudent);
                    ClearStudentFields();
                    LoadStudents();
                }
            }        

        //Delete operation Timetable
        private void btnClickDeleteStudent(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                int student1 = GetSelectedRowStudentId();

                if (student1 != -1)
                {
                    adminOperations.DeleteStudent(student1);
                    LoadStudents();
                    ClearStudentFields();
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

        //refresh / view operation
        private void btnClickRefreshStudent(object sender, EventArgs e)
        {
            LoadStudents();
        }

        //back button
        private void btnClickBack(object sender, EventArgs e)
        {
            AdminHomePage adminp1 = new AdminHomePage();
            adminp1.StartPosition = FormStartPosition.CenterScreen;
            adminp1.Show();
            this.Hide();
        }
    }
}
