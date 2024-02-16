using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HarrisDesktopApp.DBOperations;
using HarrisDesktopApp.Models;

namespace HarrisDesktopApp.GUI
{
    public partial class EditTeacher : Form
    {
        private AdminOperations adminOperations = new AdminOperations();
        public EditTeacher()
        {
            InitializeComponent();
        }

        private void EditTeacher_Load(object sender, EventArgs e)
        {
            dataGridViewTeacher.DataSource = adminOperations.GetTeachers();

        }

        // operation for showing Teachers details

        private void LoadTeachers()
        {
            dataGridViewTeacher.DataSource = adminOperations.GetTeachers();
        }

        // selecting row in teacher table and replacing values

        private Teacher GetSelectedRowTeacher()
        {
            if (dataGridViewTeacher.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewTeacher.SelectedRows[0];
                return new Teacher
                {
                    Id = Convert.ToInt32(selectedRow.Cells["t_id"].Value),
                    Fname = Convert.ToString(selectedRow.Cells["t_Fname"].Value),
                    Lname = Convert.ToString(selectedRow.Cells["t_Lname"].Value),
                    email = Convert.ToString(selectedRow.Cells["t_email"].Value),
                    tt_position = Convert.ToString(selectedRow.Cells["t_position"].Value),
                    tt_department = Convert.ToString(selectedRow.Cells["t_department"].Value),

                };
            }
            return null;
        }

        // clearing fields for teacher
        private void ClearTeacherFields()
        {
            textTeacherFname.Clear();
            textTeacherLname.Clear();  
            textTeacherEmail.Clear();  
            textTeacherPosition.Clear();
            textTeacherDept.Clear();    
        }

        // get the selected row Teacher id

        private int GetSelectedRowTeacherId()
        {
            if (dataGridViewTeacher.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewTeacher.SelectedRows[0].Cells["t_id"].Value);
            }
            return -1;

        }


        //back buton
        private void btnClickBack(object sender, EventArgs e)
        {
            AdminHomePage adminp1 = new AdminHomePage();
            adminp1.StartPosition = FormStartPosition.CenterScreen;
            adminp1.Show();
            this.Hide();

        }

        //Create and save teacher button

        private void buttonAddTeacherClick(object sender, EventArgs e)
        {
            Teacher newTeacher = new Teacher
            {
                Fname=textTeacherFname.Text,
                Lname=textTeacherLname.Text,
                email=textTeacherEmail.Text,
                tt_position=textTeacherPosition.Text,
                tt_department=textTeacherDept.Text,
            };
            adminOperations.AddTeacher(newTeacher);
            ClearTeacherFields();
            LoadTeachers();
            lblAddTeacher.Show();
            lblDeleteTeacher.Hide();
            lblUpdateTeacher.Hide();
        }


        //update button
        private void buttonUpdateTeacherClick(object sender, EventArgs e)
        {
            if (dataGridViewTeacher.SelectedRows.Count > 0)
            {
                Teacher selectedTeacher = GetSelectedRowTeacher();
                if (selectedTeacher != null)
                {
                    selectedTeacher.Fname= textTeacherFname.Text;
                    selectedTeacher.Lname= textTeacherLname.Text;
                    selectedTeacher.email= textTeacherEmail.Text;
                    selectedTeacher.tt_position= textTeacherPosition.Text;
                    selectedTeacher.tt_department= textTeacherDept.Text;
                   

                    adminOperations.UpdateTeacher(selectedTeacher);
                    LoadTeachers();
                    lblAddTeacher.Hide();
                    lblDeleteTeacher.Hide();
                    lblUpdateTeacher.Show();
                    ClearTeacherFields();
                }
            }
        }

        //Delete operation
        private void buttonDeleteTeacherClick(object sender, EventArgs e)
        {
            if (dataGridViewTeacher.SelectedRows.Count>0)
            {
                int TeacherId1 = GetSelectedRowTeacherId();

                if (TeacherId1 != -1)
                {
                    try
                    {


                        adminOperations.DeleteTeacher(TeacherId1);
                        LoadTeachers();
                        lblAddTeacher.Hide();
                        lblDeleteTeacher.Show();
                        lblUpdateTeacher.Hide();
                        ClearTeacherFields();
                    }
                    catch 
                    {
                       MessageBox.Show("Teacher in use, can't be deleted!");

                    }
                }
                else
                {
                    MessageBox.Show("Please select a teacher to delete.");
                }            
            }
            else
            {
                MessageBox.Show("Please select a teacher to delete.");
            }
        }


        //refresh / view operation
        private void btnClickRefreshTeacher(object sender, EventArgs e)
        {
            LoadTeachers();
            lblAddTeacher.Hide();
            lblDeleteTeacher.Hide();
            lblUpdateTeacher.Hide();
        }

       
    }
}
