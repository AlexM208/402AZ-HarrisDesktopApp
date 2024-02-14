using HarrisDesktopApp.DBOperations;
using HarrisDesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisDesktopApp.GUI
{
    public partial class EditModule : Form
    {
        private AdminOperations adminOperations = new AdminOperations();
        public EditModule()
        {
            InitializeComponent();
        }

        private void EditModule_Load(object sender, EventArgs e)
        {
            dataGridViewModule.DataSource = adminOperations.GetModuleName();

        }

        // operation for showing Module details
        private void LoadModule()
        {
            dataGridViewModule.DataSource = adminOperations.GetModuleName();
        }

        // selecting row in Module table and replacing values
        private ModuleName GetSelectedRowModule()
        {
            if (dataGridViewModule.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewModule.SelectedRows[0];
                return new ModuleName
                {
                    xm_moduleId = Convert.ToInt32(selectedRow.Cells["module_id"].Value),
                    xm_moduleName = Convert.ToString(selectedRow.Cells["module_name"].Value),
                    xm_cw1_pass_fail = Convert.ToString(selectedRow.Cells["cw1_pass_fail"].Value),
                    xm_cw2_mark = Convert.ToString(selectedRow.Cells["cw2_mark"].Value),
                    courseID = Convert.ToInt32(selectedRow.Cells["course_id"].Value),
                    startDate = Convert.ToDateTime(selectedRow.Cells["start_date"].Value),
                    endDate = Convert.ToDateTime(selectedRow.Cells["end_date"].Value),

                };
            }
            return null;
        }

        // clearing fields for Module List table
        private void ClearModuleFields()
        {
            txtModuleName.Clear();
            txtMcourseId.Clear();            
            txtPassMark1.Clear();
            txtPassMark2.Clear();
            
        }

        // get the selected row Module id

        private int GetSelectedRowModuleId()
        {
            if (dataGridViewModule.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewModule.SelectedRows[0].Cells["module_id"].Value);
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

        //Create and save Module button
        private void btnClickAddModule(object sender, EventArgs e)
        {
            ModuleName newModule = new ModuleName
            {                
                xm_moduleName = txtModuleName.Text,
                startDate = dateTimePickerStart.Value,
                endDate = dateTimePickerEnd.Value,
                xm_cw1_pass_fail = txtPassMark1.Text,
                xm_cw2_mark = txtPassMark2.Text,
                courseID = Convert.ToInt32(txtMcourseId.Text),

            };
            adminOperations.AddModule(newModule);
            LoadModule();
            ClearModuleFields();


        }
        //courseID = Convert.ToInt32(txtMcourseId.Text),

        //update button
        private void btnClickUpdateModule(object sender, EventArgs e)
        {
            if (dataGridViewModule.SelectedRows.Count > 0)
            {
                ModuleName selectedModule = GetSelectedRowModule();
                if (selectedModule != null)
                {
                    selectedModule.xm_moduleName = txtModuleName.Text;
                    selectedModule.courseID = Convert.ToInt32(txtMcourseId.Text); 
                    selectedModule.startDate = dateTimePickerStart.Value;
                    selectedModule.endDate = dateTimePickerEnd.Value;
                    selectedModule.xm_cw1_pass_fail =txtPassMark1.Text;
                    selectedModule.xm_cw2_mark =txtPassMark2.Text;

                    adminOperations.UpdateModule(selectedModule);
                    LoadModule();
                    ClearModuleFields();
                }
            }
        }

        //Delete operation
        private void btnClickDeleteModule(object sender, EventArgs e)
        {
            if (dataGridViewModule.SelectedRows.Count > 0)
            {
                int module1 = GetSelectedRowModuleId();

                if (module1 != -1)
                {
                    adminOperations.DeleteModule(module1);
                    LoadModule();
                    ClearModuleFields();
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
        private void btnClickRefreshModule(object sender, EventArgs e)
        {
            LoadModule();
        }

        
    }
}
