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
    public partial class EditClass : Form
    {
        private AdminOperations adminOperations = new AdminOperations();
        public EditClass()
        {
            InitializeComponent();
        }
        private void EditClass_Load(object sender, EventArgs e)
        {
            dataGridViewClass.DataSource = adminOperations.GetClass();

        }

        private void LoadClass()
        {
            dataGridViewClass.DataSource = adminOperations.GetClass();
        }   

        // selecting row in Class table and replacing values
        private Class GetSelectedRowClass()
        {
            if (dataGridViewClass.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewClass.SelectedRows[0];

                return new Class
                {                
                    cc_classRoom = Convert.ToDouble(selectedRow.Cells["class_room"].Value),
                    cc_classBuilding = Convert.ToString(selectedRow.Cells["class_building"].Value),
                    cc_classFloor = Convert.ToString(selectedRow.Cells["class_floor"].Value),
                    cc_classAddress = Convert.ToString(selectedRow.Cells["class_address"].Value),
                    cc_classPostcode = Convert.ToString(selectedRow.Cells["class_postcode"].Value),


                };
            }
            return null;
        }

        // clearing fields for Class table
        private void ClearClassFields()
        {
            txtBuilding.Clear();
            txtRoom.Clear();
            txtFloor.Clear();
            txtAddress.Clear();
            txtPostcode.Clear();
            txtTeacherId.Clear();

        }

        // get the selected row Class id
        private double GetSelectedRowClassRoom()
        {
            if (dataGridViewClass.SelectedRows.Count > 0)
            {
                //txtRoom.Text = Convert.ToString(dataGridViewClass.SelectedRows[0].Cells["class_room"].Value);
                return Convert.ToDouble(dataGridViewClass.SelectedRows[0].Cells["class_room"].Value);
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

        //Create and save Class button
        private void btnClickAddClass(object sender, EventArgs e)
        {
            
            Class newClass = new Class
            {
                cc_classRoom = Convert.ToDouble(txtRoom.Text),
                cc_classBuilding = txtBuilding.Text,
                cc_classFloor = txtFloor.Text,
                cc_classAddress = txtAddress.Text,
                cc_classPostcode = txtPostcode.Text,
                cc_t_id= Convert.ToInt32(txtTeacherId.Text),
                
                
            };
            adminOperations.AddClass(newClass);
            ClearClassFields();
            lblAddClass.Show();
            lblDeleteClass.Hide();            
            lblUpdateClass.Hide();
            LoadClass();
        }

        //update button
        private void btnClickUpdateClass(object sender, EventArgs e)
        {
            if (dataGridViewClass.SelectedRows.Count > 0)
            {

                Class selectedClass = GetSelectedRowClass();                  
                if (selectedClass != null)
                {
                    
                    selectedClass.cc_classRoom = Convert.ToDouble(txtRoom.Text);
                    selectedClass.cc_classBuilding = txtBuilding.Text;
                    selectedClass.cc_classFloor = txtFloor.Text;
                    selectedClass.cc_classAddress = txtAddress.Text;
                    selectedClass.cc_classPostcode = txtPostcode.Text;
                    selectedClass.cc_t_id = Convert.ToInt32(txtTeacherId.Text);

                    

                    adminOperations.UpdateClass(selectedClass);
                    ClearClassFields();
                    LoadClass();
                    lblDeleteClass.Hide();
                    lblAddClass.Hide();
                    lblUpdateClass.Show();
                }
            }

        }

        //Delete Operation
        private void btnClickDeleteClass(object sender, EventArgs e)
        {
            if (dataGridViewClass.SelectedRows.Count > 0)
            {
                double classRoom1 = GetSelectedRowClassRoom();

                if (classRoom1 != -1)
                {
                    try
                    {
                        adminOperations.DeleteClass(classRoom1);
                        lblDeleteClass.Show();
                        lblAddClass.Hide();
                        lblUpdateClass.Hide();
                        LoadClass();
                        ClearClassFields();
                    }
                    catch
                    {

                        MessageBox.Show("Can't delete, class in use");

                    }
                }
                else
                {
                    MessageBox.Show("Please select a class to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a class to delete.");
            }
        }

        //refresh / view operation

        private void btnClickRefresh(object sender, EventArgs e)
        {
            
            lblDeleteClass.Hide();
            lblAddClass.Hide();
            lblUpdateClass.Hide();
            LoadClass();
        }
    }

}
