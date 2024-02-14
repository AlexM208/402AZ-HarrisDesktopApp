namespace HarrisDesktopApp
{
    partial class AdminHomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClassDets = new System.Windows.Forms.Button();
            this.buttonModuleDets = new System.Windows.Forms.Button();
            this.buttonCourseDets = new System.Windows.Forms.Button();
            this.buttonStudentDets = new System.Windows.Forms.Button();
            this.buttonBackAdmin = new System.Windows.Forms.Button();
            this.buttonTeacherDets = new System.Windows.Forms.Button();
            this.buttonTimetableDets = new System.Windows.Forms.Button();
            this.buttonEnrolmentDets = new System.Windows.Forms.Button();
            this.buttonMaterialsDets = new System.Windows.Forms.Button();
            this.buttonWorksheetsDets = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin";
            // 
            // buttonClassDets
            // 
            this.buttonClassDets.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClassDets.Location = new System.Drawing.Point(535, 112);
            this.buttonClassDets.Name = "buttonClassDets";
            this.buttonClassDets.Size = new System.Drawing.Size(129, 34);
            this.buttonClassDets.TabIndex = 1;
            this.buttonClassDets.Text = "Class";
            this.buttonClassDets.UseVisualStyleBackColor = true;
            this.buttonClassDets.Click += new System.EventHandler(this.btnClickClassDets);
            // 
            // buttonModuleDets
            // 
            this.buttonModuleDets.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModuleDets.Location = new System.Drawing.Point(670, 112);
            this.buttonModuleDets.Name = "buttonModuleDets";
            this.buttonModuleDets.Size = new System.Drawing.Size(129, 34);
            this.buttonModuleDets.TabIndex = 2;
            this.buttonModuleDets.Text = "Module";
            this.buttonModuleDets.UseVisualStyleBackColor = true;
            this.buttonModuleDets.Click += new System.EventHandler(this.btnClickModuleDets);
            // 
            // buttonCourseDets
            // 
            this.buttonCourseDets.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCourseDets.Location = new System.Drawing.Point(535, 152);
            this.buttonCourseDets.Name = "buttonCourseDets";
            this.buttonCourseDets.Size = new System.Drawing.Size(129, 34);
            this.buttonCourseDets.TabIndex = 3;
            this.buttonCourseDets.Text = "Course List";
            this.buttonCourseDets.UseVisualStyleBackColor = true;
            this.buttonCourseDets.Click += new System.EventHandler(this.buttonClickCourseList);
            // 
            // buttonStudentDets
            // 
            this.buttonStudentDets.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentDets.Location = new System.Drawing.Point(265, 112);
            this.buttonStudentDets.Name = "buttonStudentDets";
            this.buttonStudentDets.Size = new System.Drawing.Size(129, 34);
            this.buttonStudentDets.TabIndex = 4;
            this.buttonStudentDets.Text = "Student";
            this.buttonStudentDets.UseVisualStyleBackColor = true;
            this.buttonStudentDets.Click += new System.EventHandler(this.btnClickStudentDets);
            // 
            // buttonBackAdmin
            // 
            this.buttonBackAdmin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackAdmin.Location = new System.Drawing.Point(670, 152);
            this.buttonBackAdmin.Name = "buttonBackAdmin";
            this.buttonBackAdmin.Size = new System.Drawing.Size(129, 34);
            this.buttonBackAdmin.TabIndex = 6;
            this.buttonBackAdmin.Text = "Back";
            this.buttonBackAdmin.UseVisualStyleBackColor = true;
            this.buttonBackAdmin.Click += new System.EventHandler(this.buttonClickBackAdminP);
            // 
            // buttonTeacherDets
            // 
            this.buttonTeacherDets.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeacherDets.Location = new System.Drawing.Point(130, 112);
            this.buttonTeacherDets.Name = "buttonTeacherDets";
            this.buttonTeacherDets.Size = new System.Drawing.Size(129, 34);
            this.buttonTeacherDets.TabIndex = 7;
            this.buttonTeacherDets.Text = "Teacher";
            this.buttonTeacherDets.UseVisualStyleBackColor = true;
            this.buttonTeacherDets.Click += new System.EventHandler(this.buttonClickTeacherDets);
            // 
            // buttonTimetableDets
            // 
            this.buttonTimetableDets.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimetableDets.Location = new System.Drawing.Point(400, 152);
            this.buttonTimetableDets.Name = "buttonTimetableDets";
            this.buttonTimetableDets.Size = new System.Drawing.Size(129, 34);
            this.buttonTimetableDets.TabIndex = 8;
            this.buttonTimetableDets.Text = "Timetable";
            this.buttonTimetableDets.UseVisualStyleBackColor = true;
            this.buttonTimetableDets.Click += new System.EventHandler(this.btnClickTimetableDets);
            // 
            // buttonEnrolmentDets
            // 
            this.buttonEnrolmentDets.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnrolmentDets.Location = new System.Drawing.Point(265, 152);
            this.buttonEnrolmentDets.Name = "buttonEnrolmentDets";
            this.buttonEnrolmentDets.Size = new System.Drawing.Size(129, 34);
            this.buttonEnrolmentDets.TabIndex = 9;
            this.buttonEnrolmentDets.Text = "Enrolment";
            this.buttonEnrolmentDets.UseVisualStyleBackColor = true;
            this.buttonEnrolmentDets.Click += new System.EventHandler(this.btnClickEnrolmentDets);
            // 
            // buttonMaterialsDets
            // 
            this.buttonMaterialsDets.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaterialsDets.Location = new System.Drawing.Point(130, 152);
            this.buttonMaterialsDets.Name = "buttonMaterialsDets";
            this.buttonMaterialsDets.Size = new System.Drawing.Size(129, 34);
            this.buttonMaterialsDets.TabIndex = 10;
            this.buttonMaterialsDets.Text = "Materials";
            this.buttonMaterialsDets.UseVisualStyleBackColor = true;
            this.buttonMaterialsDets.Click += new System.EventHandler(this.btnClickMaterialsDets);
            // 
            // buttonWorksheetsDets
            // 
            this.buttonWorksheetsDets.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWorksheetsDets.Location = new System.Drawing.Point(400, 112);
            this.buttonWorksheetsDets.Name = "buttonWorksheetsDets";
            this.buttonWorksheetsDets.Size = new System.Drawing.Size(129, 34);
            this.buttonWorksheetsDets.TabIndex = 11;
            this.buttonWorksheetsDets.Text = "Worksheets";
            this.buttonWorksheetsDets.UseVisualStyleBackColor = true;
            this.buttonWorksheetsDets.Click += new System.EventHandler(this.btnClickWorksheetsDets);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(265, 51);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(129, 34);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonClickLogout);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 761);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonWorksheetsDets);
            this.Controls.Add(this.buttonMaterialsDets);
            this.Controls.Add(this.buttonEnrolmentDets);
            this.Controls.Add(this.buttonTimetableDets);
            this.Controls.Add(this.buttonTeacherDets);
            this.Controls.Add(this.buttonBackAdmin);
            this.Controls.Add(this.buttonStudentDets);
            this.Controls.Add(this.buttonCourseDets);
            this.Controls.Add(this.buttonModuleDets);
            this.Controls.Add(this.buttonClassDets);
            this.Controls.Add(this.label1);
            this.Name = "AdminHomePage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClassDets;
        private System.Windows.Forms.Button buttonModuleDets;
        private System.Windows.Forms.Button buttonCourseDets;
        private System.Windows.Forms.Button buttonStudentDets;
        private System.Windows.Forms.Button buttonBackAdmin;
        private System.Windows.Forms.Button buttonTeacherDets;
        private System.Windows.Forms.Button buttonTimetableDets;
        private System.Windows.Forms.Button buttonEnrolmentDets;
        private System.Windows.Forms.Button buttonMaterialsDets;
        private System.Windows.Forms.Button buttonWorksheetsDets;
        private System.Windows.Forms.Button buttonLogout;
    }
}