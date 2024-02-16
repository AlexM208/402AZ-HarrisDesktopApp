namespace HarrisDesktopApp.GUI
{
    partial class EditCourse
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
            this.labelAdminCourse = new System.Windows.Forms.Label();
            this.buttonDeleteCourse = new System.Windows.Forms.Button();
            this.buttonUpdateCourse = new System.Windows.Forms.Button();
            this.buttonRefreshCourse = new System.Windows.Forms.Button();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.courseBtnToAdminHP = new System.Windows.Forms.Button();
            this.dataGridViewCourseList = new System.Windows.Forms.DataGridView();
            this.labelCrsCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseType = new System.Windows.Forms.TextBox();
            this.labelCrsName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDets = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblUpdateCourse = new System.Windows.Forms.Label();
            this.lblDeleteCourse = new System.Windows.Forms.Label();
            this.lblAddCourse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdminCourse
            // 
            this.labelAdminCourse.AutoSize = true;
            this.labelAdminCourse.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminCourse.Location = new System.Drawing.Point(12, 9);
            this.labelAdminCourse.Name = "labelAdminCourse";
            this.labelAdminCourse.Size = new System.Drawing.Size(179, 29);
            this.labelAdminCourse.TabIndex = 2;
            this.labelAdminCourse.Text = "Welcome Admin";
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCourse.Location = new System.Drawing.Point(307, 244);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonDeleteCourse.TabIndex = 33;
            this.buttonDeleteCourse.Text = "Delete";
            this.buttonDeleteCourse.UseVisualStyleBackColor = true;
            this.buttonDeleteCourse.Click += new System.EventHandler(this.btnClickDeleteCourse);
            // 
            // buttonUpdateCourse
            // 
            this.buttonUpdateCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCourse.Location = new System.Drawing.Point(196, 244);
            this.buttonUpdateCourse.Name = "buttonUpdateCourse";
            this.buttonUpdateCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonUpdateCourse.TabIndex = 32;
            this.buttonUpdateCourse.Text = "Update";
            this.buttonUpdateCourse.UseVisualStyleBackColor = true;
            this.buttonUpdateCourse.Click += new System.EventHandler(this.btnClickUpdateCourse);
            // 
            // buttonRefreshCourse
            // 
            this.buttonRefreshCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshCourse.Location = new System.Drawing.Point(418, 244);
            this.buttonRefreshCourse.Name = "buttonRefreshCourse";
            this.buttonRefreshCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonRefreshCourse.TabIndex = 31;
            this.buttonRefreshCourse.Text = "Refresh";
            this.buttonRefreshCourse.UseVisualStyleBackColor = true;
            this.buttonRefreshCourse.Click += new System.EventHandler(this.btnClickRefreshCourseList);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.Location = new System.Drawing.Point(85, 244);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonAddCourse.TabIndex = 30;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.btnAddClickCourse);
            // 
            // courseBtnToAdminHP
            // 
            this.courseBtnToAdminHP.BackColor = System.Drawing.SystemColors.Control;
            this.courseBtnToAdminHP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBtnToAdminHP.Location = new System.Drawing.Point(529, 244);
            this.courseBtnToAdminHP.Name = "courseBtnToAdminHP";
            this.courseBtnToAdminHP.Size = new System.Drawing.Size(105, 35);
            this.courseBtnToAdminHP.TabIndex = 29;
            this.courseBtnToAdminHP.Text = "Back";
            this.courseBtnToAdminHP.UseVisualStyleBackColor = true;
            this.courseBtnToAdminHP.Click += new System.EventHandler(this.btnClickBack);
            // 
            // dataGridViewCourseList
            // 
            this.dataGridViewCourseList.AllowUserToAddRows = false;
            this.dataGridViewCourseList.AllowUserToDeleteRows = false;
            this.dataGridViewCourseList.AllowUserToResizeColumns = false;
            this.dataGridViewCourseList.AllowUserToResizeRows = false;
            this.dataGridViewCourseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCourseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourseList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourseList.Location = new System.Drawing.Point(12, 321);
            this.dataGridViewCourseList.Name = "dataGridViewCourseList";
            this.dataGridViewCourseList.ReadOnly = true;
            this.dataGridViewCourseList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCourseList.Size = new System.Drawing.Size(710, 411);
            this.dataGridViewCourseList.TabIndex = 34;
            // 
            // labelCrsCode
            // 
            this.labelCrsCode.AutoSize = true;
            this.labelCrsCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrsCode.Location = new System.Drawing.Point(88, 92);
            this.labelCrsCode.Name = "labelCrsCode";
            this.labelCrsCode.Size = new System.Drawing.Size(46, 19);
            this.labelCrsCode.TabIndex = 35;
            this.labelCrsCode.Text = "Code:";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(177, 93);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(136, 20);
            this.txtCourseCode.TabIndex = 36;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(177, 119);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(136, 20);
            this.txtCourseName.TabIndex = 37;
            // 
            // txtCourseType
            // 
            this.txtCourseType.Location = new System.Drawing.Point(177, 145);
            this.txtCourseType.Name = "txtCourseType";
            this.txtCourseType.Size = new System.Drawing.Size(136, 20);
            this.txtCourseType.TabIndex = 38;
            // 
            // labelCrsName
            // 
            this.labelCrsName.AutoSize = true;
            this.labelCrsName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrsName.Location = new System.Drawing.Point(88, 118);
            this.labelCrsName.Name = "labelCrsName";
            this.labelCrsName.Size = new System.Drawing.Size(51, 19);
            this.labelCrsName.TabIndex = 41;
            this.labelCrsName.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Type:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(343, 118);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(78, 19);
            this.lblStartDate.TabIndex = 43;
            this.lblStartDate.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "End Date:";
            // 
            // lblDets
            // 
            this.lblDets.AutoSize = true;
            this.lblDets.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDets.Location = new System.Drawing.Point(81, 55);
            this.lblDets.Name = "lblDets";
            this.lblDets.Size = new System.Drawing.Size(150, 19);
            this.lblDets.TabIndex = 45;
            this.lblDets.Text = "Enter Course Details ";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "";
            this.dateTimePickerEnd.Location = new System.Drawing.Point(427, 146);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 46;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "";
            this.dateTimePickerStart.Location = new System.Drawing.Point(427, 117);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 47;
            // 
            // lblUpdateCourse
            // 
            this.lblUpdateCourse.AutoSize = true;
            this.lblUpdateCourse.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUpdateCourse.Location = new System.Drawing.Point(243, 208);
            this.lblUpdateCourse.Name = "lblUpdateCourse";
            this.lblUpdateCourse.Size = new System.Drawing.Size(234, 23);
            this.lblUpdateCourse.TabIndex = 58;
            this.lblUpdateCourse.Text = "Course updated successfully!";
            this.lblUpdateCourse.Visible = false;
            // 
            // lblDeleteCourse
            // 
            this.lblDeleteCourse.AutoSize = true;
            this.lblDeleteCourse.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCourse.ForeColor = System.Drawing.Color.Blue;
            this.lblDeleteCourse.Location = new System.Drawing.Point(243, 208);
            this.lblDeleteCourse.Name = "lblDeleteCourse";
            this.lblDeleteCourse.Size = new System.Drawing.Size(231, 23);
            this.lblDeleteCourse.TabIndex = 59;
            this.lblDeleteCourse.Text = "Course deleted  successfully!";
            this.lblDeleteCourse.Visible = false;
            // 
            // lblAddCourse
            // 
            this.lblAddCourse.AutoSize = true;
            this.lblAddCourse.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAddCourse.Location = new System.Drawing.Point(243, 208);
            this.lblAddCourse.Name = "lblAddCourse";
            this.lblAddCourse.Size = new System.Drawing.Size(228, 23);
            this.lblAddCourse.TabIndex = 60;
            this.lblAddCourse.Text = "Course created successfully!";
            this.lblAddCourse.Visible = false;
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 771);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.lblDets);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCrsName);
            this.Controls.Add(this.txtCourseType);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.labelCrsCode);
            this.Controls.Add(this.dataGridViewCourseList);
            this.Controls.Add(this.buttonDeleteCourse);
            this.Controls.Add(this.buttonUpdateCourse);
            this.Controls.Add(this.buttonRefreshCourse);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.courseBtnToAdminHP);
            this.Controls.Add(this.labelAdminCourse);
            this.Controls.Add(this.lblAddCourse);
            this.Controls.Add(this.lblDeleteCourse);
            this.Controls.Add(this.lblUpdateCourse);
            this.Name = "EditCourse";
            this.Text = "EditCourse";
            this.Load += new System.EventHandler(this.EditCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminCourse;
        private System.Windows.Forms.Button buttonDeleteCourse;
        private System.Windows.Forms.Button buttonUpdateCourse;
        private System.Windows.Forms.Button buttonRefreshCourse;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button courseBtnToAdminHP;
        private System.Windows.Forms.DataGridView dataGridViewCourseList;
        private System.Windows.Forms.Label labelCrsCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseType;
        private System.Windows.Forms.Label labelCrsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDets;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label lblUpdateCourse;
        private System.Windows.Forms.Label lblDeleteCourse;
        private System.Windows.Forms.Label lblAddCourse;
    }
}