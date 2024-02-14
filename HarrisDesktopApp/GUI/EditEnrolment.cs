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
    public partial class EditEnrolment : Form
    {
        private AdminOperations adminOperations = new AdminOperations();
        public EditEnrolment()
        {
            InitializeComponent();
        }

        private void EditEnrolment_Load(object sender, EventArgs e)
        {
            dataGridViewEnrolment.DataSource = adminOperations.GetEnrolment();

        }

        // operation for showing Enrolment details

        private void LoadEnrolment()
        {
            dataGridViewEnrolment.DataSource = adminOperations.GetEnrolment();
        }

        // selecting row in Enrolment  and replacing values

        private Enrolment GetSelectedRowEnrolment()
        {
            if (dataGridViewEnrolment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEnrolment.SelectedRows[0];
                return new Enrolment
                {
                    ee_enrolmentID = Convert.ToInt32(selectedRow.Cells["enrolment_id"].Value),
                    ee_stId = Convert.ToInt32(selectedRow.Cells["st_id"].Value),
                    courseID = Convert.ToInt32(selectedRow.Cells["course_id"].Value),
                    ee_yearNumber = Convert.ToInt32(selectedRow.Cells["year_number"].Value),
                    ee_PT_FT = Convert.ToString(selectedRow.Cells["PT_FT"].Value),

                };
            }
            return null;
        }

        // clearing fields for Enrolment
        private void ClearEnrolmentFields()
        {
            txtStId.Clear();
            txtCourseId.Clear();
            txtStYear.Clear();
            txtStPartFull.Clear();
            
        }

        // get the selected row Enrolment id
        private int GetSelectedRowEnrolmentId()
        {
            if (dataGridViewEnrolment.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewEnrolment.SelectedRows[0].Cells["enrolment_id"].Value);
            }
            return -1;

        }

        //Create and save Enrolment button
        private void btnClickAddEnrolment(object sender, EventArgs e)
        {
            Enrolment newEnrolment = new Enrolment
            {
                ee_stId = Convert.ToInt32(txtStId.Text),
                courseID = Convert.ToInt32(txtCourseId.Text),
                ee_yearNumber = Convert.ToInt32(txtStYear.Text),
                ee_PT_FT = txtStPartFull.Text,
            };
            adminOperations.AddEnrolment(newEnrolment);
            ClearEnrolmentFields();
            LoadEnrolment();
        }

        //update button
        private void btnClickUpdateEnrolment(object sender, EventArgs e)
        {
            if (dataGridViewEnrolment.SelectedRows.Count > 0)
            {
                Enrolment selectedEnrolment = GetSelectedRowEnrolment();
                if (selectedEnrolment != null)
                {
                    selectedEnrolment.ee_stId = Convert.ToInt32(txtStId.Text);
                    selectedEnrolment.courseID = Convert.ToInt32(txtCourseId.Text);
                    selectedEnrolment.ee_yearNumber = Convert.ToInt32(txtStYear.Text);
                    selectedEnrolment.ee_PT_FT = txtStPartFull.Text;


                    adminOperations.UpdateEnrolment(selectedEnrolment);
                    ClearEnrolmentFields();
                    LoadEnrolment();
                }
            }
        }

        //Delete operation Enrolment
        private void btnClickDeleteEnrolment(object sender, EventArgs e)
        {
            if (dataGridViewEnrolment.SelectedRows.Count > 0)
            {
                int enrolment1 = GetSelectedRowEnrolmentId();

                if (enrolment1 != -1)
                {
                    adminOperations.DeleteEnrolment(enrolment1);
                    ClearEnrolmentFields();
                    LoadEnrolment();
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
        private void btnClickRefreshEnrolment(object sender, EventArgs e)
        {
            LoadEnrolment();
        }

        // back button
        private void btnClickBack(object sender, EventArgs e)
        {
            AdminHomePage adminp1 = new AdminHomePage();
            adminp1.StartPosition = FormStartPosition.CenterScreen;
            adminp1.Show();
            this.Hide();
        }

        private void txtStId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
