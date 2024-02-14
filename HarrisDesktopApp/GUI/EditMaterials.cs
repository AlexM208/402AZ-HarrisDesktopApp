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
    public partial class EditMaterials : Form
    {
        private AdminOperations adminOperations = new AdminOperations();
        public EditMaterials()
        {
            InitializeComponent();
        }
        private void EditMaterials_Load(object sender, EventArgs e)
        {
            dataGridViewMaterials.DataSource = adminOperations.GetMaterials();

        }

        // operation for showing Materials details

        private void LoadMaterials()
        {
            dataGridViewMaterials.DataSource = adminOperations.GetMaterials();
        }

        // selecting row in Materials  and replacing values

        private Materials GetSelectedRowMaterial()
        {
            if (dataGridViewMaterials.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMaterials.SelectedRows[0];
                return new Materials
                {
                    mm_materialID = Convert.ToInt32(selectedRow.Cells["material_id"].Value),
                    mm_moduleID = Convert.ToInt32(selectedRow.Cells["module_id"].Value),
                    mm_tID = Convert.ToInt32(selectedRow.Cells["t_id"].Value),
                    mm_mat_date_edit = Convert.ToDateTime(selectedRow.Cells["material_date_edit"].Value),
                    
                };
            }
            return null;
        }

        // clearing fields for Materials
        private void ClearMaterialFields()
        {
            txtModuleId.Clear();
            txtTeacherId.Clear();
            
        }

        // get the selected row Materials id
        private int GetSelectedRowMaterialId()
        {
            if (dataGridViewMaterials.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewMaterials.SelectedRows[0].Cells["material_id"].Value);
            }
            return -1;

        }

        //Create and save Materials button
        private void btnClickAddMaterial(object sender, EventArgs e)
        {
            Materials newMaterial = new Materials
            {
                mm_moduleID = Convert.ToInt32(txtModuleId.Text),                
                mm_tID = Convert.ToInt32(txtTeacherId.Text),
                mm_mat_date_edit = DateTime.Now,
                
            };
            adminOperations.AddMaterial(newMaterial);
            ClearMaterialFields();
            LoadMaterials();
        }

        //update button
        private void btnClickUpdateMaterial(object sender, EventArgs e)
        {
            if (dataGridViewMaterials.SelectedRows.Count > 0)
            {
                Materials selectedMaterial = GetSelectedRowMaterial();
                if (selectedMaterial != null)

                selectedMaterial.mm_moduleID = Convert.ToInt32(txtModuleId.Text);
                selectedMaterial.mm_tID = Convert.ToInt32(txtTeacherId.Text);
                selectedMaterial.mm_mat_date_edit = DateTime.Now;

                adminOperations.UpdateMaterial(selectedMaterial);
                ClearMaterialFields();
                LoadMaterials();
            }
        }

        //Delete operation Materials
        private void btnClickDeleteMaterial(object sender, EventArgs e)
        {
            if (dataGridViewMaterials.SelectedRows.Count > 0)
            {
                int material1 = GetSelectedRowMaterialId();

                if (material1 != -1)
                {
                    adminOperations.DeleteMaterial(material1);
                    LoadMaterials();
                    ClearMaterialFields();
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
        private void btnClickRefreshMaterial(object sender, EventArgs e)
        {
            LoadMaterials();
        }


        // back button
        private void btnClickBack(object sender, EventArgs e)
        {
            AdminHomePage adminp1 = new AdminHomePage();
            adminp1.StartPosition = FormStartPosition.CenterScreen;
            adminp1.Show();
            this.Hide();
        }
    }
}
