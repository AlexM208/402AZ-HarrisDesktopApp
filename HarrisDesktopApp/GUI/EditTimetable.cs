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
    public partial class EditTimetable : Form
    {
        private AdminOperations adminOperations = new AdminOperations();
        public EditTimetable()
        {
            InitializeComponent();
        }       
        private void EditTimetable_Load(object sender, EventArgs e)
        {
            dataGridViewTimetable.DataSource = adminOperations.GetTimetable();

        }

        // operation for showing Timetable details

        private void LoadTimetable()
        {
            dataGridViewTimetable.DataSource = adminOperations.GetTimetable();
        }

        // selecting row in timetable  and replacing values

        private Timetable GetSelectedRowTimetable()
        {
            if (dataGridViewTimetable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewTimetable.SelectedRows[0];
                return new Timetable
                {
                    xt_timetableID = Convert.ToInt32(selectedRow.Cells["timetable_id"].Value),
                    xt_moduleID = Convert.ToInt32(selectedRow.Cells["module_id"].Value),
                    xt_classRoom = Convert.ToDouble(selectedRow.Cells["class_room"].Value),
                    xt_tId = Convert.ToInt32(selectedRow.Cells["t_id"].Value),
                    xt_classHours = Convert.ToString(selectedRow.Cells["class_hours"].Value),
                    //xt_moduleName = Convert.ToString(selectedRow.Cells["module_name"].Value),
                    //xt_tLname = Convert.ToString(selectedRow.Cells["t_Lname"].Value),
                   // xt_tFname = Convert.ToString(selectedRow.Cells["t_Fname"].Value),
                    //xt_classFloor = Convert.ToString(selectedRow.Cells["class_floor"].Value),
                   // xt_classBuilding = Convert.ToString(selectedRow.Cells["class_building"].Value),

                };
            }
            return null;
        }

        // clearing fields for Timetable
        private void ClearTimetableFields()
        {
            txtModuleId.Clear();           
            txtClassRoom.Clear();
            txtTeacherId.Clear();           
            txtHoursTime.Clear();
           // txtClassFloor.Clear();
           // txtClassBuilding.Clear();
            //txtModuleName.Clear();
        }

        // get the selected row Timetable id
        private int GetSelectedRowTimetableId()
        {
            if (dataGridViewTimetable.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewTimetable.SelectedRows[0].Cells["timetable_id"].Value);
            }
            return -1;

        }
           
        //Create and save Timetable button

        private void btnClickAddTimetable(object sender, EventArgs e)
        {
            Timetable newTimetable = new Timetable
            {
               /* xt_classBuilding = txtClassBuilding.Text,               
                xt_tFname = txtTeacherId.Text,
                xt_classFloor = txtClassFloor.Text,
                xt_tLname = txtTeacherId.Text,
                xt_moduleName = txtModuleName.Text,*/
                xt_moduleID = Convert.ToInt32(txtModuleId.Text),
                xt_classRoom = Convert.ToDouble(txtClassRoom.Text),
                xt_tId = Convert.ToInt32(txtTeacherId.Text),
                xt_classHours = txtHoursTime.Text,
            };
            adminOperations.AddTimetable(newTimetable);
            ClearTimetableFields();
            LoadTimetable();

        }


        //update button
        private void btnClickUpdateTimetable(object sender, EventArgs e)
        {
            if (dataGridViewTimetable.SelectedRows.Count > 0)
            {
                Timetable selectedTimetable = GetSelectedRowTimetable();
                if (selectedTimetable != null)
                {
                   /* selectedTimetable.xt_moduleName = txtModuleName.Text;
                    selectedTimetable.xt_tLname = txtTeacherId.Text;
                    selectedTimetable.xt_tFname = txtTeacherId.Text;
                    selectedTimetable.xt_classBuilding = txtClassBuilding.Text;
                    selectedTimetable.xt_classFloor = txtClassFloor.Text;*/
                    selectedTimetable.xt_moduleID = Convert.ToInt32(txtModuleId.Text);
                    selectedTimetable.xt_classRoom = Convert.ToDouble(txtClassRoom.Text);
                    selectedTimetable.xt_tId = Convert.ToInt32(txtTeacherId.Text);
                    selectedTimetable.xt_classHours = txtHoursTime.Text;
                    

                    adminOperations.UpdateTimetable(selectedTimetable);
                    LoadTimetable();
                    ClearTimetableFields();
                }
            }
        }

        //Delete operation Timetable
        private void btnClickDeleteTimetable(object sender, EventArgs e)
        {
            if (dataGridViewTimetable.SelectedRows.Count > 0)
            {
                int timetable1 = GetSelectedRowTimetableId();

                if (timetable1 != -1)
                {
                    adminOperations.DeleteTimetable(timetable1);
                    LoadTimetable();
                    ClearTimetableFields();
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
        private void btnClickRefreshTimetable(object sender, EventArgs e)
        {
            LoadTimetable();
        }
        
        //back buton
        private void btnClickBack(object sender, EventArgs e)
        {
            AdminHomePage adminp1 = new AdminHomePage();
            adminp1.StartPosition = FormStartPosition.CenterScreen;
            adminp1.Show();
            this.Hide();            
        }
    }
}
