namespace HarrisDesktopApp.GUI
{
    partial class EditTim
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
            this.lblDets = new System.Windows.Forms.Label();
            this.dataGridViewMaterialsUpload = new System.Windows.Forms.DataGridView();
            this.buttonRefreshTeachers = new System.Windows.Forms.Button();
            this.labelAdminTeacher = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.txtModuleId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterialsUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // courseBtnToAdminHP
            // 
            this.courseBtnToAdminHP.BackColor = System.Drawing.SystemColors.Control;
            this.courseBtnToAdminHP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBtnToAdminHP.Location = new System.Drawing.Point(278, 259);
            this.courseBtnToAdminHP.Name = "courseBtnToAdminHP";
            this.courseBtnToAdminHP.Size = new System.Drawing.Size(105, 35);
            this.courseBtnToAdminHP.TabIndex = 39;
            this.courseBtnToAdminHP.Text = "Back";
            this.courseBtnToAdminHP.UseVisualStyleBackColor = true;
            this.courseBtnToAdminHP.Click += new System.EventHandler(this.btnClickBack);
            // 
            // lblDets
            // 
            this.lblDets.AutoSize = true;
            this.lblDets.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDets.Location = new System.Drawing.Point(34, 78);
            this.lblDets.Name = "lblDets";
            this.lblDets.Size = new System.Drawing.Size(154, 23);
            this.lblDets.TabIndex = 70;
            this.lblDets.Text = "Timetable Details ";
            this.lblDets.Click += new System.EventHandler(this.lblDets_Click);
            // 
            // dataGridViewMaterialsUpload
            // 
            this.dataGridViewMaterialsUpload.AllowUserToAddRows = false;
            this.dataGridViewMaterialsUpload.AllowUserToDeleteRows = false;
            this.dataGridViewMaterialsUpload.AllowUserToResizeColumns = false;
            this.dataGridViewMaterialsUpload.AllowUserToResizeRows = false;
            this.dataGridViewMaterialsUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMaterialsUpload.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaterialsUpload.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMaterialsUpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterialsUpload.Location = new System.Drawing.Point(12, 321);
            this.dataGridViewMaterialsUpload.Name = "dataGridViewMaterialsUpload";
            this.dataGridViewMaterialsUpload.ReadOnly = true;
            this.dataGridViewMaterialsUpload.Size = new System.Drawing.Size(710, 411);
            this.dataGridViewMaterialsUpload.TabIndex = 69;
            // 
            // buttonRefreshTeachers
            // 
            this.buttonRefreshTeachers.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshTeachers.Location = new System.Drawing.Point(38, 259);
            this.buttonRefreshTeachers.Name = "buttonRefreshTeachers";
            this.buttonRefreshTeachers.Size = new System.Drawing.Size(234, 35);
            this.buttonRefreshTeachers.TabIndex = 66;
            this.buttonRefreshTeachers.Text = "Show Timetable";
            this.buttonRefreshTeachers.UseVisualStyleBackColor = true;
            this.buttonRefreshTeachers.Click += new System.EventHandler(this.btnClickRefreshMaterials);
            // 
            // labelAdminTeacher
            // 
            this.labelAdminTeacher.AutoSize = true;
            this.labelAdminTeacher.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminTeacher.Location = new System.Drawing.Point(12, 9);
            this.labelAdminTeacher.Name = "labelAdminTeacher";
            this.labelAdminTeacher.Size = new System.Drawing.Size(179, 29);
            this.labelAdminTeacher.TabIndex = 47;
            this.labelAdminTeacher.Text = "Welcome Admin";
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.SystemColors.Control;
            this.uploadBtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Location = new System.Drawing.Point(538, 104);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(105, 35);
            this.uploadBtn.TabIndex = 71;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.btnClickUpload);
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(388, 114);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(100, 20);
            this.textFilePath.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 126;
            this.label1.Text = "Teacher Id:";
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Location = new System.Drawing.Point(196, 139);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.Size = new System.Drawing.Size(136, 20);
            this.txtTeacherId.TabIndex = 125;
            // 
            // txtModuleId
            // 
            this.txtModuleId.Location = new System.Drawing.Point(196, 113);
            this.txtModuleId.Name = "txtModuleId";
            this.txtModuleId.Size = new System.Drawing.Size(136, 20);
            this.txtModuleId.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 123;
            this.label2.Text = "Module Id:";
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaterial.Location = new System.Drawing.Point(383, 174);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(105, 35);
            this.btnAddMaterial.TabIndex = 127;
            this.btnAddMaterial.Text = "Add";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnUploadMaterial);
            // 
            // EditTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 771);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeacherId);
            this.Controls.Add(this.txtModuleId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.lblDets);
            this.Controls.Add(this.dataGridViewMaterialsUpload);
            this.Controls.Add(this.buttonRefreshTeachers);
            this.Controls.Add(this.labelAdminTeacher);
            this.Controls.Add(this.courseBtnToAdminHP);
            this.Name = "EditTim";
            this.Text = "EditTimetable";
            this.Load += new System.EventHandler(this.EditTimetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterialsUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button courseBtnToAdminHP;
        private System.Windows.Forms.Label lblDets;
        private System.Windows.Forms.DataGridView dataGridViewMaterialsUpload;
        private System.Windows.Forms.Button buttonRefreshTeachers;
        private System.Windows.Forms.Label labelAdminTeacher;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.TextBox txtModuleId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMaterial;
    }
}