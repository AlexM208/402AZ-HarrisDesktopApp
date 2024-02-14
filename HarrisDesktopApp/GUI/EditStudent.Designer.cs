namespace HarrisDesktopApp.GUI
{
    partial class EditStudent
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
            this.studentBtnToAdminHP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStAddress = new System.Windows.Forms.TextBox();
            this.lblDets = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnRefreshStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStPassFail = new System.Windows.Forms.TextBox();
            this.txtStGrade = new System.Windows.Forms.TextBox();
            this.txtStPostcode = new System.Windows.Forms.TextBox();
            this.txtStEmail = new System.Windows.Forms.TextBox();
            this.txtStPhone = new System.Windows.Forms.TextBox();
            this.txtStFname = new System.Windows.Forms.TextBox();
            this.txtStLname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdminTeacher = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStTimetableId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBtnToAdminHP
            // 
            this.studentBtnToAdminHP.BackColor = System.Drawing.SystemColors.Control;
            this.studentBtnToAdminHP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentBtnToAdminHP.Location = new System.Drawing.Point(526, 239);
            this.studentBtnToAdminHP.Name = "studentBtnToAdminHP";
            this.studentBtnToAdminHP.Size = new System.Drawing.Size(105, 35);
            this.studentBtnToAdminHP.TabIndex = 39;
            this.studentBtnToAdminHP.Text = "Back";
            this.studentBtnToAdminHP.UseVisualStyleBackColor = true;
            this.studentBtnToAdminHP.Click += new System.EventHandler(this.btnClickBack);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Address:";
            // 
            // txtStAddress
            // 
            this.txtStAddress.Location = new System.Drawing.Point(443, 93);
            this.txtStAddress.Name = "txtStAddress";
            this.txtStAddress.Size = new System.Drawing.Size(147, 20);
            this.txtStAddress.TabIndex = 95;
            // 
            // lblDets
            // 
            this.lblDets.AutoSize = true;
            this.lblDets.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDets.Location = new System.Drawing.Point(34, 58);
            this.lblDets.Name = "lblDets";
            this.lblDets.Size = new System.Drawing.Size(159, 19);
            this.lblDets.TabIndex = 94;
            this.lblDets.Text = "Enter Student Details ";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AllowUserToResizeColumns = false;
            this.dataGridViewStudent.AllowUserToResizeRows = false;
            this.dataGridViewStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(12, 336);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.Size = new System.Drawing.Size(710, 411);
            this.dataGridViewStudent.TabIndex = 93;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(304, 239);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(105, 35);
            this.btnDeleteStudent.TabIndex = 92;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnClickDeleteStudent);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.Location = new System.Drawing.Point(193, 239);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(105, 35);
            this.btnUpdateStudent.TabIndex = 91;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnClickUpdateStudent);
            // 
            // btnRefreshStudent
            // 
            this.btnRefreshStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshStudent.Location = new System.Drawing.Point(415, 239);
            this.btnRefreshStudent.Name = "btnRefreshStudent";
            this.btnRefreshStudent.Size = new System.Drawing.Size(105, 35);
            this.btnRefreshStudent.TabIndex = 90;
            this.btnRefreshStudent.Text = "Refresh";
            this.btnRefreshStudent.UseVisualStyleBackColor = true;
            this.btnRefreshStudent.Click += new System.EventHandler(this.btnClickRefreshStudent);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(82, 239);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(105, 35);
            this.btnAddStudent.TabIndex = 89;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnClickAddStudent);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 88;
            this.label8.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 87;
            this.label7.Text = "Grade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 86;
            this.label6.Text = "Postcode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 85;
            this.label5.Text = "Email:";
            // 
            // txtStPassFail
            // 
            this.txtStPassFail.Location = new System.Drawing.Point(443, 171);
            this.txtStPassFail.Name = "txtStPassFail";
            this.txtStPassFail.Size = new System.Drawing.Size(147, 20);
            this.txtStPassFail.TabIndex = 84;
            // 
            // txtStGrade
            // 
            this.txtStGrade.Location = new System.Drawing.Point(443, 145);
            this.txtStGrade.Name = "txtStGrade";
            this.txtStGrade.Size = new System.Drawing.Size(147, 20);
            this.txtStGrade.TabIndex = 83;
            // 
            // txtStPostcode
            // 
            this.txtStPostcode.Location = new System.Drawing.Point(443, 119);
            this.txtStPostcode.Name = "txtStPostcode";
            this.txtStPostcode.Size = new System.Drawing.Size(147, 20);
            this.txtStPostcode.TabIndex = 82;
            // 
            // txtStEmail
            // 
            this.txtStEmail.Location = new System.Drawing.Point(177, 171);
            this.txtStEmail.Name = "txtStEmail";
            this.txtStEmail.Size = new System.Drawing.Size(136, 20);
            this.txtStEmail.TabIndex = 81;
            // 
            // txtStPhone
            // 
            this.txtStPhone.Location = new System.Drawing.Point(177, 145);
            this.txtStPhone.Name = "txtStPhone";
            this.txtStPhone.Size = new System.Drawing.Size(136, 20);
            this.txtStPhone.TabIndex = 80;
            // 
            // txtStFname
            // 
            this.txtStFname.Location = new System.Drawing.Point(177, 119);
            this.txtStFname.Name = "txtStFname";
            this.txtStFname.Size = new System.Drawing.Size(136, 20);
            this.txtStFname.TabIndex = 79;
            // 
            // txtStLname
            // 
            this.txtStLname.Location = new System.Drawing.Point(177, 93);
            this.txtStLname.Name = "txtStLname";
            this.txtStLname.Size = new System.Drawing.Size(136, 20);
            this.txtStLname.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 77;
            this.label4.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "Last Name:";
            // 
            // labelAdminTeacher
            // 
            this.labelAdminTeacher.AutoSize = true;
            this.labelAdminTeacher.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminTeacher.Location = new System.Drawing.Point(12, 9);
            this.labelAdminTeacher.Name = "labelAdminTeacher";
            this.labelAdminTeacher.Size = new System.Drawing.Size(179, 29);
            this.labelAdminTeacher.TabIndex = 74;
            this.labelAdminTeacher.Text = "Welcome Admin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(343, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 98;
            this.label9.Text = "Timetable Id:";
            // 
            // txtStTimetableId
            // 
            this.txtStTimetableId.Location = new System.Drawing.Point(443, 67);
            this.txtStTimetableId.Name = "txtStTimetableId";
            this.txtStTimetableId.Size = new System.Drawing.Size(147, 20);
            this.txtStTimetableId.TabIndex = 97;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 771);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStTimetableId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStAddress);
            this.Controls.Add(this.lblDets);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnRefreshStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStPassFail);
            this.Controls.Add(this.txtStGrade);
            this.Controls.Add(this.txtStPostcode);
            this.Controls.Add(this.txtStEmail);
            this.Controls.Add(this.txtStPhone);
            this.Controls.Add(this.txtStFname);
            this.Controls.Add(this.txtStLname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAdminTeacher);
            this.Controls.Add(this.studentBtnToAdminHP);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button studentBtnToAdminHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStAddress;
        private System.Windows.Forms.Label lblDets;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnRefreshStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStPassFail;
        private System.Windows.Forms.TextBox txtStGrade;
        private System.Windows.Forms.TextBox txtStPostcode;
        private System.Windows.Forms.TextBox txtStEmail;
        private System.Windows.Forms.TextBox txtStPhone;
        private System.Windows.Forms.TextBox txtStFname;
        private System.Windows.Forms.TextBox txtStLname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdminTeacher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStTimetableId;
    }
}