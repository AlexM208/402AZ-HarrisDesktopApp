using HarrisDesktopApp.DBOperations;
using HarrisDesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                //mm_material_blob = btnUploadMaterial.AccessibilityObject;

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
                    MessageBox.Show("Please select a Material to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Material to delete.");
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

        private void btnClickUploadMaterial(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    txtMaterialUp.Text= openFileDialog.FileName;
                    //btnUploadMaterial  = mm_material_blob.FromFile(openFileDialog.FileName);
                    btnUploadMaterial.Image = Image.FromFile(openFileDialog.FileName);

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void txtMaterialUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClickBackTeacherHP(object sender, EventArgs e)
        {
            TeacherHomePage teacherHP = new TeacherHomePage();
            teacherHP.StartPosition = FormStartPosition.CenterScreen;
            teacherHP.Show();
            this.Hide();
        }

        private void btnBackToStudent_Click(object sender, EventArgs e)
        {
            StudentHomeP studentHP = new StudentHomeP();
            studentHP.StartPosition = FormStartPosition.CenterScreen;
            studentHP.Show();
            this.Hide();

        }
    }
}
