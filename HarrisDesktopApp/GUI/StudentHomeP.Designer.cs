namespace HarrisDesktopApp.GUI
{
    partial class StudentHomeP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStudentHP = new System.Windows.Forms.Label();
            this.btnMaterialsStudent = new System.Windows.Forms.Button();
            this.btnTimetableStudent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefreshStudent = new System.Windows.Forms.Button();
            this.btnLogoutSt = new System.Windows.Forms.Button();
            this.dataGridViewStTimetable = new System.Windows.Forms.DataGridView();
            this.dataGridViewStMaterials = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStTimetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudentHP
            // 
            this.labelStudentHP.AutoSize = true;
            this.labelStudentHP.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentHP.Location = new System.Drawing.Point(12, 9);
            this.labelStudentHP.Name = "labelStudentHP";
            this.labelStudentHP.Size = new System.Drawing.Size(190, 29);
            this.labelStudentHP.TabIndex = 3;
            this.labelStudentHP.Text = "Welcome Student";
            // 
            // btnMaterialsStudent
            // 
            this.btnMaterialsStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialsStudent.Location = new System.Drawing.Point(152, 76);
            this.btnMaterialsStudent.Name = "btnMaterialsStudent";
            this.btnMaterialsStudent.Size = new System.Drawing.Size(129, 34);
            this.btnMaterialsStudent.TabIndex = 13;
            this.btnMaterialsStudent.Text = "Materials";
            this.btnMaterialsStudent.UseVisualStyleBackColor = true;
            this.btnMaterialsStudent.Click += new System.EventHandler(this.btnClickShowMaterials);
            // 
            // btnTimetableStudent
            // 
            this.btnTimetableStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimetableStudent.Location = new System.Drawing.Point(17, 76);
            this.btnTimetableStudent.Name = "btnTimetableStudent";
            this.btnTimetableStudent.Size = new System.Drawing.Size(129, 34);
            this.btnTimetableStudent.TabIndex = 12;
            this.btnTimetableStudent.Text = "Timetable";
            this.btnTimetableStudent.UseVisualStyleBackColor = true;
            this.btnTimetableStudent.Click += new System.EventHandler(this.btnClickShowTimetable);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(398, 75);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 34);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnRefreshStudent
            // 
            this.btnRefreshStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshStudent.Location = new System.Drawing.Point(287, 74);
            this.btnRefreshStudent.Name = "btnRefreshStudent";
            this.btnRefreshStudent.Size = new System.Drawing.Size(105, 35);
            this.btnRefreshStudent.TabIndex = 32;
            this.btnRefreshStudent.Text = "Refresh";
            this.btnRefreshStudent.UseVisualStyleBackColor = true;
            // 
            // btnLogoutSt
            // 
            this.btnLogoutSt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutSt.Location = new System.Drawing.Point(208, 4);
            this.btnLogoutSt.Name = "btnLogoutSt";
            this.btnLogoutSt.Size = new System.Drawing.Size(129, 34);
            this.btnLogoutSt.TabIndex = 33;
            this.btnLogoutSt.Text = "Logout";
            this.btnLogoutSt.UseVisualStyleBackColor = true;
            this.btnLogoutSt.Click += new System.EventHandler(this.btnClickLogoutStudent);
            // 
            // dataGridViewStTimetable
            // 
            this.dataGridViewStTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStTimetable.Location = new System.Drawing.Point(12, 217);
            this.dataGridViewStTimetable.Name = "dataGridViewStTimetable";
            this.dataGridViewStTimetable.Size = new System.Drawing.Size(640, 332);
            this.dataGridViewStTimetable.TabIndex = 34;
            // 
            // dataGridViewStMaterials
            // 
            this.dataGridViewStMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStMaterials.Location = new System.Drawing.Point(12, 217);
            this.dataGridViewStMaterials.Name = "dataGridViewStMaterials";
            this.dataGridViewStMaterials.Size = new System.Drawing.Size(640, 332);
            this.dataGridViewStMaterials.TabIndex = 35;
            // 
            // StudentHomeP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 561);
            this.Controls.Add(this.btnLogoutSt);
            this.Controls.Add(this.btnRefreshStudent);
            this.Controls.Add(this.btnMaterialsStudent);
            this.Controls.Add(this.btnTimetableStudent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelStudentHP);
            this.Controls.Add(this.dataGridViewStMaterials);
            this.Controls.Add(this.dataGridViewStTimetable);
            this.Name = "StudentHomeP";
            this.Text = "StudentHomeP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStTimetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentHP;
        private System.Windows.Forms.Button btnMaterialsStudent;
        private System.Windows.Forms.Button btnTimetableStudent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefreshStudent;
        private System.Windows.Forms.Button btnLogoutSt;
        private System.Windows.Forms.DataGridView dataGridViewStTimetable;
        private System.Windows.Forms.DataGridView dataGridViewStMaterials;
    }
}