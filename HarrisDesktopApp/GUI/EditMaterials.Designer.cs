namespace HarrisDesktopApp.GUI
{
    partial class EditMaterials
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
            this.courseBtnToAdminHP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.lblDets = new System.Windows.Forms.Label();
            this.dataGridViewMaterials = new System.Windows.Forms.DataGridView();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnRefreshStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtModuleId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdminTeacher = new System.Windows.Forms.Label();
            this.lblDeleteMaterial = new System.Windows.Forms.Label();
            this.lblUpdateMaterial = new System.Windows.Forms.Label();
            this.lblAddClass = new System.Windows.Forms.Label();
            this.lblMaterialUpload = new System.Windows.Forms.Label();
            this.btnBackToTeacher = new System.Windows.Forms.Button();
            this.btnBackToStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // courseBtnToAdminHP
            // 
            this.courseBtnToAdminHP.BackColor = System.Drawing.SystemColors.Control;
            this.courseBtnToAdminHP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBtnToAdminHP.Location = new System.Drawing.Point(526, 239);
            this.courseBtnToAdminHP.Name = "courseBtnToAdminHP";
            this.courseBtnToAdminHP.Size = new System.Drawing.Size(105, 35);
            this.courseBtnToAdminHP.TabIndex = 39;
            this.courseBtnToAdminHP.Text = "Back";
            this.courseBtnToAdminHP.UseVisualStyleBackColor = true;
            this.courseBtnToAdminHP.Click += new System.EventHandler(this.btnClickBack);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 122;
            this.label1.Text = "Teacher Id:";
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Location = new System.Drawing.Point(177, 119);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.Size = new System.Drawing.Size(136, 20);
            this.txtTeacherId.TabIndex = 121;
            // 
            // lblDets
            // 
            this.lblDets.AutoSize = true;
            this.lblDets.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDets.Location = new System.Drawing.Point(34, 58);
            this.lblDets.Name = "lblDets";
            this.lblDets.Size = new System.Drawing.Size(168, 19);
            this.lblDets.TabIndex = 120;
            this.lblDets.Text = "Enter Materials Details ";
            // 
            // dataGridViewMaterials
            // 
            this.dataGridViewMaterials.AllowUserToAddRows = false;
            this.dataGridViewMaterials.AllowUserToDeleteRows = false;
            this.dataGridViewMaterials.AllowUserToResizeColumns = false;
            this.dataGridViewMaterials.AllowUserToResizeRows = false;
            this.dataGridViewMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaterials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterials.Location = new System.Drawing.Point(12, 336);
            this.dataGridViewMaterials.Name = "dataGridViewMaterials";
            this.dataGridViewMaterials.ReadOnly = true;
            this.dataGridViewMaterials.Size = new System.Drawing.Size(710, 411);
            this.dataGridViewMaterials.TabIndex = 119;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(304, 239);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(105, 35);
            this.btnDeleteStudent.TabIndex = 118;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnClickDeleteMaterial);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.Location = new System.Drawing.Point(193, 239);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(105, 35);
            this.btnUpdateStudent.TabIndex = 117;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnClickUpdateMaterial);
            // 
            // btnRefreshStudent
            // 
            this.btnRefreshStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshStudent.Location = new System.Drawing.Point(415, 239);
            this.btnRefreshStudent.Name = "btnRefreshStudent";
            this.btnRefreshStudent.Size = new System.Drawing.Size(105, 35);
            this.btnRefreshStudent.TabIndex = 116;
            this.btnRefreshStudent.Text = "Refresh";
            this.btnRefreshStudent.UseVisualStyleBackColor = true;
            this.btnRefreshStudent.Click += new System.EventHandler(this.btnClickRefreshMaterial);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(56, 239);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(131, 35);
            this.btnAddStudent.TabIndex = 115;
            this.btnAddStudent.Text = "Upload Material";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnClickAddMaterial);
            // 
            // txtModuleId
            // 
            this.txtModuleId.Location = new System.Drawing.Point(177, 93);
            this.txtModuleId.Name = "txtModuleId";
            this.txtModuleId.Size = new System.Drawing.Size(136, 20);
            this.txtModuleId.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 101;
            this.label2.Text = "Module Id:";
            // 
            // labelAdminTeacher
            // 
            this.labelAdminTeacher.AutoSize = true;
            this.labelAdminTeacher.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminTeacher.Location = new System.Drawing.Point(12, 9);
            this.labelAdminTeacher.Name = "labelAdminTeacher";
            this.labelAdminTeacher.Size = new System.Drawing.Size(179, 29);
            this.labelAdminTeacher.TabIndex = 100;
            this.labelAdminTeacher.Text = "Welcome Admin";
            // 
            // lblDeleteMaterial
            // 
            this.lblDeleteMaterial.AutoSize = true;
            this.lblDeleteMaterial.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteMaterial.ForeColor = System.Drawing.Color.Blue;
            this.lblDeleteMaterial.Location = new System.Drawing.Point(243, 208);
            this.lblDeleteMaterial.Name = "lblDeleteMaterial";
            this.lblDeleteMaterial.Size = new System.Drawing.Size(248, 23);
            this.lblDeleteMaterial.TabIndex = 126;
            this.lblDeleteMaterial.Text = "Material deleted  successfully!";
            this.lblDeleteMaterial.Visible = false;
            // 
            // lblUpdateMaterial
            // 
            this.lblUpdateMaterial.AutoSize = true;
            this.lblUpdateMaterial.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUpdateMaterial.Location = new System.Drawing.Point(243, 208);
            this.lblUpdateMaterial.Name = "lblUpdateMaterial";
            this.lblUpdateMaterial.Size = new System.Drawing.Size(251, 23);
            this.lblUpdateMaterial.TabIndex = 125;
            this.lblUpdateMaterial.Text = "Material updated successfully!";
            this.lblUpdateMaterial.Visible = false;
            // 
            // lblAddClass
            // 
            this.lblAddClass.AutoSize = true;
            this.lblAddClass.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAddClass.Location = new System.Drawing.Point(243, 208);
            this.lblAddClass.Name = "lblAddClass";
            this.lblAddClass.Size = new System.Drawing.Size(245, 23);
            this.lblAddClass.TabIndex = 127;
            this.lblAddClass.Text = "Material created successfully!";
            this.lblAddClass.Visible = false;
            // 
            // lblMaterialUpload
            // 
            this.lblMaterialUpload.AutoSize = true;
            this.lblMaterialUpload.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialUpload.ForeColor = System.Drawing.Color.Magenta;
            this.lblMaterialUpload.Location = new System.Drawing.Point(243, 208);
            this.lblMaterialUpload.Name = "lblMaterialUpload";
            this.lblMaterialUpload.Size = new System.Drawing.Size(263, 23);
            this.lblMaterialUpload.TabIndex = 128;
            this.lblMaterialUpload.Text = "Material uploaded  successfully!";
            this.lblMaterialUpload.Visible = false;
            // 
            // btnBackToTeacher
            // 
            this.btnBackToTeacher.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackToTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToTeacher.Location = new System.Drawing.Point(526, 239);
            this.btnBackToTeacher.Name = "btnBackToTeacher";
            this.btnBackToTeacher.Size = new System.Drawing.Size(105, 35);
            this.btnBackToTeacher.TabIndex = 129;
            this.btnBackToTeacher.Text = "Back";
            this.btnBackToTeacher.UseVisualStyleBackColor = true;
            this.btnBackToTeacher.Click += new System.EventHandler(this.btnClickBackTeacherHP);
            // 
            // btnBackToStudent
            // 
            this.btnBackToStudent.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackToStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToStudent.Location = new System.Drawing.Point(526, 239);
            this.btnBackToStudent.Name = "btnBackToStudent";
            this.btnBackToStudent.Size = new System.Drawing.Size(105, 35);
            this.btnBackToStudent.TabIndex = 130;
            this.btnBackToStudent.Text = "Back";
            this.btnBackToStudent.UseVisualStyleBackColor = true;
            this.btnBackToStudent.Click += new System.EventHandler(this.btnBackToStudent_Click);
            // 
            // EditMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 771);
            this.Controls.Add(this.btnBackToStudent);
            this.Controls.Add(this.btnBackToTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeacherId);
            this.Controls.Add(this.lblDets);
            this.Controls.Add(this.dataGridViewMaterials);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnRefreshStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtModuleId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAdminTeacher);
            this.Controls.Add(this.courseBtnToAdminHP);
            this.Controls.Add(this.lblMaterialUpload);
            this.Controls.Add(this.lblDeleteMaterial);
            this.Controls.Add(this.lblUpdateMaterial);
            this.Controls.Add(this.lblAddClass);
            this.Name = "EditMaterials";
            this.Text = "EditMaterials";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button courseBtnToAdminHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Label lblDets;
        private System.Windows.Forms.DataGridView dataGridViewMaterials;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnRefreshStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtModuleId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdminTeacher;
        private System.Windows.Forms.Label lblDeleteMaterial;
        private System.Windows.Forms.Label lblUpdateMaterial;
        private System.Windows.Forms.Label lblAddClass;
        private System.Windows.Forms.Label lblMaterialUpload;
        public System.Windows.Forms.Button btnBackToTeacher;
        public System.Windows.Forms.Button btnBackToStudent;
    }
}