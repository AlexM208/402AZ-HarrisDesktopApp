namespace HarrisDesktopApp.GUI
{
    partial class EditTimetable
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
            this.dataGridViewTimetable = new System.Windows.Forms.DataGridView();
            this.buttonDeleteTeacher = new System.Windows.Forms.Button();
            this.buttonUpdateTeacher = new System.Windows.Forms.Button();
            this.buttonRefreshTeachers = new System.Windows.Forms.Button();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoursTime = new System.Windows.Forms.TextBox();
            this.txtClassBuilding = new System.Windows.Forms.TextBox();
            this.txtClassFloor = new System.Windows.Forms.TextBox();
            this.txtTeacherFname = new System.Windows.Forms.TextBox();
            this.txtTeacherLname = new System.Windows.Forms.TextBox();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.txtModuleId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdminTeacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassRoom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).BeginInit();
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
            // lblDets
            // 
            this.lblDets.AutoSize = true;
            this.lblDets.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDets.Location = new System.Drawing.Point(34, 58);
            this.lblDets.Name = "lblDets";
            this.lblDets.Size = new System.Drawing.Size(172, 19);
            this.lblDets.TabIndex = 70;
            this.lblDets.Text = "Enter Timetable Details ";
            // 
            // dataGridViewTimetable
            // 
            this.dataGridViewTimetable.AllowUserToAddRows = false;
            this.dataGridViewTimetable.AllowUserToDeleteRows = false;
            this.dataGridViewTimetable.AllowUserToResizeColumns = false;
            this.dataGridViewTimetable.AllowUserToResizeRows = false;
            this.dataGridViewTimetable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimetable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimetable.Location = new System.Drawing.Point(12, 321);
            this.dataGridViewTimetable.Name = "dataGridViewTimetable";
            this.dataGridViewTimetable.ReadOnly = true;
            this.dataGridViewTimetable.Size = new System.Drawing.Size(710, 411);
            this.dataGridViewTimetable.TabIndex = 69;
            // 
            // buttonDeleteTeacher
            // 
            this.buttonDeleteTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTeacher.Location = new System.Drawing.Point(304, 239);
            this.buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            this.buttonDeleteTeacher.Size = new System.Drawing.Size(105, 35);
            this.buttonDeleteTeacher.TabIndex = 68;
            this.buttonDeleteTeacher.Text = "Delete";
            this.buttonDeleteTeacher.UseVisualStyleBackColor = true;
            this.buttonDeleteTeacher.Click += new System.EventHandler(this.btnClickDeleteTimetable);
            // 
            // buttonUpdateTeacher
            // 
            this.buttonUpdateTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTeacher.Location = new System.Drawing.Point(193, 239);
            this.buttonUpdateTeacher.Name = "buttonUpdateTeacher";
            this.buttonUpdateTeacher.Size = new System.Drawing.Size(105, 35);
            this.buttonUpdateTeacher.TabIndex = 67;
            this.buttonUpdateTeacher.Text = "Update";
            this.buttonUpdateTeacher.UseVisualStyleBackColor = true;
            this.buttonUpdateTeacher.Click += new System.EventHandler(this.btnClickUpdateTimetable);
            // 
            // buttonRefreshTeachers
            // 
            this.buttonRefreshTeachers.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshTeachers.Location = new System.Drawing.Point(415, 239);
            this.buttonRefreshTeachers.Name = "buttonRefreshTeachers";
            this.buttonRefreshTeachers.Size = new System.Drawing.Size(105, 35);
            this.buttonRefreshTeachers.TabIndex = 66;
            this.buttonRefreshTeachers.Text = "Refresh";
            this.buttonRefreshTeachers.UseVisualStyleBackColor = true;
            this.buttonRefreshTeachers.Click += new System.EventHandler(this.btnClickRefreshTimetable);
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTeacher.Location = new System.Drawing.Point(82, 239);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(105, 35);
            this.buttonAddTeacher.TabIndex = 65;
            this.buttonAddTeacher.Text = "Add";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            this.buttonAddTeacher.Click += new System.EventHandler(this.btnClickAddTimetable);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 64;
            this.label8.Text = "Hours Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 63;
            this.label7.Text = "Building:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "Floor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 61;
            this.label5.Text = "Teacher First Name:";
            // 
            // txtHoursTime
            // 
            this.txtHoursTime.Location = new System.Drawing.Point(443, 171);
            this.txtHoursTime.Name = "txtHoursTime";
            this.txtHoursTime.Size = new System.Drawing.Size(147, 20);
            this.txtHoursTime.TabIndex = 60;
            // 
            // txtClassBuilding
            // 
            this.txtClassBuilding.Location = new System.Drawing.Point(443, 145);
            this.txtClassBuilding.Name = "txtClassBuilding";
            this.txtClassBuilding.Size = new System.Drawing.Size(147, 20);
            this.txtClassBuilding.TabIndex = 59;
            // 
            // txtClassFloor
            // 
            this.txtClassFloor.Location = new System.Drawing.Point(443, 119);
            this.txtClassFloor.Name = "txtClassFloor";
            this.txtClassFloor.Size = new System.Drawing.Size(147, 20);
            this.txtClassFloor.TabIndex = 58;
            // 
            // txtTeacherFname
            // 
            this.txtTeacherFname.Location = new System.Drawing.Point(177, 171);
            this.txtTeacherFname.Name = "txtTeacherFname";
            this.txtTeacherFname.Size = new System.Drawing.Size(136, 20);
            this.txtTeacherFname.TabIndex = 57;
            // 
            // txtTeacherLname
            // 
            this.txtTeacherLname.Location = new System.Drawing.Point(177, 145);
            this.txtTeacherLname.Name = "txtTeacherLname";
            this.txtTeacherLname.Size = new System.Drawing.Size(136, 20);
            this.txtTeacherLname.TabIndex = 56;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(177, 119);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(136, 20);
            this.txtModuleName.TabIndex = 55;
            // 
            // txtModuleId
            // 
            this.txtModuleId.Location = new System.Drawing.Point(177, 93);
            this.txtModuleId.Name = "txtModuleId";
            this.txtModuleId.Size = new System.Drawing.Size(136, 20);
            this.txtModuleId.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Module Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Teacher Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Module ID:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "Class Room:";
            // 
            // txtClassRoom
            // 
            this.txtClassRoom.Location = new System.Drawing.Point(443, 93);
            this.txtClassRoom.Name = "txtClassRoom";
            this.txtClassRoom.Size = new System.Drawing.Size(147, 20);
            this.txtClassRoom.TabIndex = 71;
            // 
            // EditTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 771);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassRoom);
            this.Controls.Add(this.lblDets);
            this.Controls.Add(this.dataGridViewTimetable);
            this.Controls.Add(this.buttonDeleteTeacher);
            this.Controls.Add(this.buttonUpdateTeacher);
            this.Controls.Add(this.buttonRefreshTeachers);
            this.Controls.Add(this.buttonAddTeacher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoursTime);
            this.Controls.Add(this.txtClassBuilding);
            this.Controls.Add(this.txtClassFloor);
            this.Controls.Add(this.txtTeacherFname);
            this.Controls.Add(this.txtTeacherLname);
            this.Controls.Add(this.txtModuleName);
            this.Controls.Add(this.txtModuleId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAdminTeacher);
            this.Controls.Add(this.courseBtnToAdminHP);
            this.Name = "EditTimetable";
            this.Text = "EditTimetable";
            this.Load += new System.EventHandler(this.EditTimetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button courseBtnToAdminHP;
        private System.Windows.Forms.Label lblDets;
        private System.Windows.Forms.DataGridView dataGridViewTimetable;
        private System.Windows.Forms.Button buttonDeleteTeacher;
        private System.Windows.Forms.Button buttonUpdateTeacher;
        private System.Windows.Forms.Button buttonRefreshTeachers;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoursTime;
        private System.Windows.Forms.TextBox txtClassBuilding;
        private System.Windows.Forms.TextBox txtClassFloor;
        private System.Windows.Forms.TextBox txtTeacherFname;
        private System.Windows.Forms.TextBox txtTeacherLname;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.TextBox txtModuleId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdminTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassRoom;
    }
}