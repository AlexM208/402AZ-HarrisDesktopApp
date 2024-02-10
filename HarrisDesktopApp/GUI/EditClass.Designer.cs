namespace HarrisDesktopApp.GUI
{
    partial class EditClass
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTeacherTimetable = new System.Windows.Forms.TextBox();
            this.textTeacherDept = new System.Windows.Forms.TextBox();
            this.textTeacherPosition = new System.Windows.Forms.TextBox();
            this.textTeacherEmail = new System.Windows.Forms.TextBox();
            this.textTeacherFname = new System.Windows.Forms.TextBox();
            this.textTeacherLname = new System.Windows.Forms.TextBox();
            this.textTeacherId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdminCourse
            // 
            this.labelAdminCourse.AutoSize = true;
            this.labelAdminCourse.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminCourse.Location = new System.Drawing.Point(12, 9);
            this.labelAdminCourse.Name = "labelAdminCourse";
            this.labelAdminCourse.Size = new System.Drawing.Size(179, 29);
            this.labelAdminCourse.TabIndex = 3;
            this.labelAdminCourse.Text = "Welcome Admin";
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCourse.Location = new System.Drawing.Point(304, 239);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonDeleteCourse.TabIndex = 38;
            this.buttonDeleteCourse.Text = "Delete";
            this.buttonDeleteCourse.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCourse
            // 
            this.buttonUpdateCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCourse.Location = new System.Drawing.Point(193, 239);
            this.buttonUpdateCourse.Name = "buttonUpdateCourse";
            this.buttonUpdateCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonUpdateCourse.TabIndex = 37;
            this.buttonUpdateCourse.Text = "Update";
            this.buttonUpdateCourse.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshCourse
            // 
            this.buttonRefreshCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshCourse.Location = new System.Drawing.Point(415, 239);
            this.buttonRefreshCourse.Name = "buttonRefreshCourse";
            this.buttonRefreshCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonRefreshCourse.TabIndex = 36;
            this.buttonRefreshCourse.Text = "Refresh";
            this.buttonRefreshCourse.UseVisualStyleBackColor = true;
            this.buttonRefreshCourse.Click += new System.EventHandler(this.btnClickRefresh);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.Location = new System.Drawing.Point(82, 239);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonAddCourse.TabIndex = 35;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            // 
            // courseBtnToAdminHP
            // 
            this.courseBtnToAdminHP.BackColor = System.Drawing.SystemColors.Control;
            this.courseBtnToAdminHP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBtnToAdminHP.Location = new System.Drawing.Point(526, 239);
            this.courseBtnToAdminHP.Name = "courseBtnToAdminHP";
            this.courseBtnToAdminHP.Size = new System.Drawing.Size(105, 35);
            this.courseBtnToAdminHP.TabIndex = 34;
            this.courseBtnToAdminHP.Text = "Back";
            this.courseBtnToAdminHP.UseVisualStyleBackColor = true;
            this.courseBtnToAdminHP.Click += new System.EventHandler(this.btnClickBack);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 52;
            this.label8.Text = "Timetable id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Position:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Email:";
            // 
            // textTeacherTimetable
            // 
            this.textTeacherTimetable.Location = new System.Drawing.Point(440, 171);
            this.textTeacherTimetable.Name = "textTeacherTimetable";
            this.textTeacherTimetable.Size = new System.Drawing.Size(147, 20);
            this.textTeacherTimetable.TabIndex = 48;
            // 
            // textTeacherDept
            // 
            this.textTeacherDept.Location = new System.Drawing.Point(440, 145);
            this.textTeacherDept.Name = "textTeacherDept";
            this.textTeacherDept.Size = new System.Drawing.Size(147, 20);
            this.textTeacherDept.TabIndex = 47;
            // 
            // textTeacherPosition
            // 
            this.textTeacherPosition.Location = new System.Drawing.Point(440, 119);
            this.textTeacherPosition.Name = "textTeacherPosition";
            this.textTeacherPosition.Size = new System.Drawing.Size(147, 20);
            this.textTeacherPosition.TabIndex = 46;
            // 
            // textTeacherEmail
            // 
            this.textTeacherEmail.Location = new System.Drawing.Point(174, 171);
            this.textTeacherEmail.Name = "textTeacherEmail";
            this.textTeacherEmail.Size = new System.Drawing.Size(136, 20);
            this.textTeacherEmail.TabIndex = 45;
            // 
            // textTeacherFname
            // 
            this.textTeacherFname.Location = new System.Drawing.Point(174, 145);
            this.textTeacherFname.Name = "textTeacherFname";
            this.textTeacherFname.Size = new System.Drawing.Size(136, 20);
            this.textTeacherFname.TabIndex = 44;
            // 
            // textTeacherLname
            // 
            this.textTeacherLname.Location = new System.Drawing.Point(174, 119);
            this.textTeacherLname.Name = "textTeacherLname";
            this.textTeacherLname.Size = new System.Drawing.Size(136, 20);
            this.textTeacherLname.TabIndex = 43;
            // 
            // textTeacherId
            // 
            this.textTeacherId.Location = new System.Drawing.Point(174, 93);
            this.textTeacherId.Name = "textTeacherId";
            this.textTeacherId.Size = new System.Drawing.Size(136, 20);
            this.textTeacherId.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Teacher Id:";
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AllowUserToAddRows = false;
            this.dataGridViewClass.AllowUserToDeleteRows = false;
            this.dataGridViewClass.AllowUserToResizeColumns = false;
            this.dataGridViewClass.AllowUserToResizeRows = false;
            this.dataGridViewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Location = new System.Drawing.Point(12, 321);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            this.dataGridViewClass.Size = new System.Drawing.Size(710, 411);
            this.dataGridViewClass.TabIndex = 53;
            // 
            // EditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 771);
            this.Controls.Add(this.dataGridViewClass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTeacherTimetable);
            this.Controls.Add(this.textTeacherDept);
            this.Controls.Add(this.textTeacherPosition);
            this.Controls.Add(this.textTeacherEmail);
            this.Controls.Add(this.textTeacherFname);
            this.Controls.Add(this.textTeacherLname);
            this.Controls.Add(this.textTeacherId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDeleteCourse);
            this.Controls.Add(this.buttonUpdateCourse);
            this.Controls.Add(this.buttonRefreshCourse);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.courseBtnToAdminHP);
            this.Controls.Add(this.labelAdminCourse);
            this.Name = "EditClass";
            this.Text = "EditClass";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTeacherTimetable;
        private System.Windows.Forms.TextBox textTeacherDept;
        private System.Windows.Forms.TextBox textTeacherPosition;
        private System.Windows.Forms.TextBox textTeacherEmail;
        private System.Windows.Forms.TextBox textTeacherFname;
        private System.Windows.Forms.TextBox textTeacherLname;
        private System.Windows.Forms.TextBox textTeacherId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewClass;
    }
}