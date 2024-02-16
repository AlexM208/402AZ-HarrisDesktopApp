namespace HarrisDesktopApp.GUI
{
    partial class EditTeacher
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
            this.labelAdminTeacher = new System.Windows.Forms.Label();
            this.teacherBtnToAdminHP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTeacherLname = new System.Windows.Forms.TextBox();
            this.textTeacherFname = new System.Windows.Forms.TextBox();
            this.textTeacherEmail = new System.Windows.Forms.TextBox();
            this.textTeacherPosition = new System.Windows.Forms.TextBox();
            this.textTeacherDept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.buttonRefreshTeachers = new System.Windows.Forms.Button();
            this.buttonUpdateTeacher = new System.Windows.Forms.Button();
            this.buttonDeleteTeacher = new System.Windows.Forms.Button();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.lblDets = new System.Windows.Forms.Label();
            this.lblDeleteTeacher = new System.Windows.Forms.Label();
            this.lblUpdateTeacher = new System.Windows.Forms.Label();
            this.lblAddTeacher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdminTeacher
            // 
            this.labelAdminTeacher.AutoSize = true;
            this.labelAdminTeacher.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminTeacher.Location = new System.Drawing.Point(12, 9);
            this.labelAdminTeacher.Name = "labelAdminTeacher";
            this.labelAdminTeacher.Size = new System.Drawing.Size(179, 29);
            this.labelAdminTeacher.TabIndex = 1;
            this.labelAdminTeacher.Text = "Welcome Admin";
            // 
            // teacherBtnToAdminHP
            // 
            this.teacherBtnToAdminHP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherBtnToAdminHP.Location = new System.Drawing.Point(526, 239);
            this.teacherBtnToAdminHP.Name = "teacherBtnToAdminHP";
            this.teacherBtnToAdminHP.Size = new System.Drawing.Size(105, 35);
            this.teacherBtnToAdminHP.TabIndex = 9;
            this.teacherBtnToAdminHP.Text = "Back";
            this.teacherBtnToAdminHP.UseVisualStyleBackColor = true;
            this.teacherBtnToAdminHP.Click += new System.EventHandler(this.btnClickBack);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last Name:";
            // 
            // textTeacherLname
            // 
            this.textTeacherLname.Location = new System.Drawing.Point(177, 119);
            this.textTeacherLname.Name = "textTeacherLname";
            this.textTeacherLname.Size = new System.Drawing.Size(136, 20);
            this.textTeacherLname.TabIndex = 15;
            // 
            // textTeacherFname
            // 
            this.textTeacherFname.Location = new System.Drawing.Point(177, 145);
            this.textTeacherFname.Name = "textTeacherFname";
            this.textTeacherFname.Size = new System.Drawing.Size(136, 20);
            this.textTeacherFname.TabIndex = 16;
            // 
            // textTeacherEmail
            // 
            this.textTeacherEmail.Location = new System.Drawing.Point(177, 171);
            this.textTeacherEmail.Name = "textTeacherEmail";
            this.textTeacherEmail.Size = new System.Drawing.Size(136, 20);
            this.textTeacherEmail.TabIndex = 17;
            // 
            // textTeacherPosition
            // 
            this.textTeacherPosition.Location = new System.Drawing.Point(443, 119);
            this.textTeacherPosition.Name = "textTeacherPosition";
            this.textTeacherPosition.Size = new System.Drawing.Size(147, 20);
            this.textTeacherPosition.TabIndex = 18;
            // 
            // textTeacherDept
            // 
            this.textTeacherDept.Location = new System.Drawing.Point(443, 145);
            this.textTeacherDept.Name = "textTeacherDept";
            this.textTeacherDept.Size = new System.Drawing.Size(147, 20);
            this.textTeacherDept.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Department:";
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTeacher.Location = new System.Drawing.Point(82, 239);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(105, 35);
            this.buttonAddTeacher.TabIndex = 25;
            this.buttonAddTeacher.Text = "Add";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacherClick);
            // 
            // buttonRefreshTeachers
            // 
            this.buttonRefreshTeachers.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshTeachers.Location = new System.Drawing.Point(415, 239);
            this.buttonRefreshTeachers.Name = "buttonRefreshTeachers";
            this.buttonRefreshTeachers.Size = new System.Drawing.Size(105, 35);
            this.buttonRefreshTeachers.TabIndex = 26;
            this.buttonRefreshTeachers.Text = "Refresh";
            this.buttonRefreshTeachers.UseVisualStyleBackColor = true;
            this.buttonRefreshTeachers.Click += new System.EventHandler(this.btnClickRefreshTeacher);
            // 
            // buttonUpdateTeacher
            // 
            this.buttonUpdateTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTeacher.Location = new System.Drawing.Point(193, 239);
            this.buttonUpdateTeacher.Name = "buttonUpdateTeacher";
            this.buttonUpdateTeacher.Size = new System.Drawing.Size(105, 35);
            this.buttonUpdateTeacher.TabIndex = 27;
            this.buttonUpdateTeacher.Text = "Update";
            this.buttonUpdateTeacher.UseVisualStyleBackColor = true;
            this.buttonUpdateTeacher.Click += new System.EventHandler(this.buttonUpdateTeacherClick);
            // 
            // buttonDeleteTeacher
            // 
            this.buttonDeleteTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTeacher.Location = new System.Drawing.Point(304, 239);
            this.buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            this.buttonDeleteTeacher.Size = new System.Drawing.Size(105, 35);
            this.buttonDeleteTeacher.TabIndex = 28;
            this.buttonDeleteTeacher.Text = "Delete";
            this.buttonDeleteTeacher.UseVisualStyleBackColor = true;
            this.buttonDeleteTeacher.Click += new System.EventHandler(this.buttonDeleteTeacherClick);
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.AllowUserToAddRows = false;
            this.dataGridViewTeacher.AllowUserToDeleteRows = false;
            this.dataGridViewTeacher.AllowUserToResizeColumns = false;
            this.dataGridViewTeacher.AllowUserToResizeRows = false;
            this.dataGridViewTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeacher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Location = new System.Drawing.Point(12, 321);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.ReadOnly = true;
            this.dataGridViewTeacher.Size = new System.Drawing.Size(710, 411);
            this.dataGridViewTeacher.TabIndex = 30;
            // 
            // lblDets
            // 
            this.lblDets.AutoSize = true;
            this.lblDets.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDets.Location = new System.Drawing.Point(88, 66);
            this.lblDets.Name = "lblDets";
            this.lblDets.Size = new System.Drawing.Size(157, 19);
            this.lblDets.TabIndex = 46;
            this.lblDets.Text = "Enter Teacher Details ";
            // 
            // lblDeleteTeacher
            // 
            this.lblDeleteTeacher.AutoSize = true;
            this.lblDeleteTeacher.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTeacher.ForeColor = System.Drawing.Color.Blue;
            this.lblDeleteTeacher.Location = new System.Drawing.Point(243, 208);
            this.lblDeleteTeacher.Name = "lblDeleteTeacher";
            this.lblDeleteTeacher.Size = new System.Drawing.Size(239, 23);
            this.lblDeleteTeacher.TabIndex = 62;
            this.lblDeleteTeacher.Text = "Teacher deleted  successfully!";
            this.lblDeleteTeacher.Visible = false;
            // 
            // lblUpdateTeacher
            // 
            this.lblUpdateTeacher.AutoSize = true;
            this.lblUpdateTeacher.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUpdateTeacher.Location = new System.Drawing.Point(243, 208);
            this.lblUpdateTeacher.Name = "lblUpdateTeacher";
            this.lblUpdateTeacher.Size = new System.Drawing.Size(242, 23);
            this.lblUpdateTeacher.TabIndex = 61;
            this.lblUpdateTeacher.Text = "Teacher updated successfully!";
            this.lblUpdateTeacher.Visible = false;
            // 
            // lblAddTeacher
            // 
            this.lblAddTeacher.AutoSize = true;
            this.lblAddTeacher.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAddTeacher.Location = new System.Drawing.Point(243, 208);
            this.lblAddTeacher.Name = "lblAddTeacher";
            this.lblAddTeacher.Size = new System.Drawing.Size(236, 23);
            this.lblAddTeacher.TabIndex = 63;
            this.lblAddTeacher.Text = "Teacher created successfully!";
            this.lblAddTeacher.Visible = false;
            // 
            // EditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 771);
            this.Controls.Add(this.lblAddTeacher);
            this.Controls.Add(this.lblDets);
            this.Controls.Add(this.dataGridViewTeacher);
            this.Controls.Add(this.buttonDeleteTeacher);
            this.Controls.Add(this.buttonUpdateTeacher);
            this.Controls.Add(this.buttonRefreshTeachers);
            this.Controls.Add(this.buttonAddTeacher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTeacherDept);
            this.Controls.Add(this.textTeacherPosition);
            this.Controls.Add(this.textTeacherEmail);
            this.Controls.Add(this.textTeacherFname);
            this.Controls.Add(this.textTeacherLname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teacherBtnToAdminHP);
            this.Controls.Add(this.labelAdminTeacher);
            this.Controls.Add(this.lblDeleteTeacher);
            this.Controls.Add(this.lblUpdateTeacher);
            this.Name = "EditTeacher";
            this.Text = "EditTeacher";
            this.Load += new System.EventHandler(this.EditTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminTeacher;
        private System.Windows.Forms.Button teacherBtnToAdminHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTeacherLname;
        private System.Windows.Forms.TextBox textTeacherFname;
        private System.Windows.Forms.TextBox textTeacherEmail;
        private System.Windows.Forms.TextBox textTeacherPosition;
        private System.Windows.Forms.TextBox textTeacherDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.Button buttonRefreshTeachers;
        private System.Windows.Forms.Button buttonUpdateTeacher;
        private System.Windows.Forms.Button buttonDeleteTeacher;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.Label lblDets;
        private System.Windows.Forms.Label lblDeleteTeacher;
        private System.Windows.Forms.Label lblUpdateTeacher;
        private System.Windows.Forms.Label lblAddTeacher;
    }
}