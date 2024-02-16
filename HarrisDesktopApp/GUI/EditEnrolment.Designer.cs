namespace HarrisDesktopApp.GUI
{
    partial class EditEnrolment
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
            this.btnEnrolmentBackToAdminHP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.lblDets = new System.Windows.Forms.Label();
            this.dataGridViewEnrolment = new System.Windows.Forms.DataGridView();
            this.btnDeleteEnrolment = new System.Windows.Forms.Button();
            this.btnUpdateEnrolment = new System.Windows.Forms.Button();
            this.btnRefreshEnrolment = new System.Windows.Forms.Button();
            this.btnAddEnrolment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStPartFull = new System.Windows.Forms.TextBox();
            this.txtStYear = new System.Windows.Forms.TextBox();
            this.txtStId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAdminTeacher = new System.Windows.Forms.Label();
            this.lblDeleteEnrolment = new System.Windows.Forms.Label();
            this.lblUpdateEnrolment = new System.Windows.Forms.Label();
            this.lblAddEnrolment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnrolment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnrolmentBackToAdminHP
            // 
            this.btnEnrolmentBackToAdminHP.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnrolmentBackToAdminHP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrolmentBackToAdminHP.Location = new System.Drawing.Point(526, 269);
            this.btnEnrolmentBackToAdminHP.Name = "btnEnrolmentBackToAdminHP";
            this.btnEnrolmentBackToAdminHP.Size = new System.Drawing.Size(105, 35);
            this.btnEnrolmentBackToAdminHP.TabIndex = 39;
            this.btnEnrolmentBackToAdminHP.Text = "Back";
            this.btnEnrolmentBackToAdminHP.UseVisualStyleBackColor = true;
            this.btnEnrolmentBackToAdminHP.Click += new System.EventHandler(this.btnClickBack);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 124;
            this.label9.Text = "Course Id:";
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(177, 119);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(136, 20);
            this.txtCourseId.TabIndex = 123;
            // 
            // lblDets
            // 
            this.lblDets.AutoSize = true;
            this.lblDets.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDets.Location = new System.Drawing.Point(34, 58);
            this.lblDets.Name = "lblDets";
            this.lblDets.Size = new System.Drawing.Size(176, 19);
            this.lblDets.TabIndex = 120;
            this.lblDets.Text = "Enter Enrolment Details ";
            // 
            // dataGridViewEnrolment
            // 
            this.dataGridViewEnrolment.AllowUserToAddRows = false;
            this.dataGridViewEnrolment.AllowUserToDeleteRows = false;
            this.dataGridViewEnrolment.AllowUserToResizeColumns = false;
            this.dataGridViewEnrolment.AllowUserToResizeRows = false;
            this.dataGridViewEnrolment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEnrolment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEnrolment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEnrolment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnrolment.Location = new System.Drawing.Point(12, 336);
            this.dataGridViewEnrolment.Name = "dataGridViewEnrolment";
            this.dataGridViewEnrolment.ReadOnly = true;
            this.dataGridViewEnrolment.Size = new System.Drawing.Size(710, 411);
            this.dataGridViewEnrolment.TabIndex = 119;
            // 
            // btnDeleteEnrolment
            // 
            this.btnDeleteEnrolment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEnrolment.Location = new System.Drawing.Point(304, 269);
            this.btnDeleteEnrolment.Name = "btnDeleteEnrolment";
            this.btnDeleteEnrolment.Size = new System.Drawing.Size(105, 35);
            this.btnDeleteEnrolment.TabIndex = 118;
            this.btnDeleteEnrolment.Text = "Delete";
            this.btnDeleteEnrolment.UseVisualStyleBackColor = true;
            this.btnDeleteEnrolment.Click += new System.EventHandler(this.btnClickDeleteEnrolment);
            // 
            // btnUpdateEnrolment
            // 
            this.btnUpdateEnrolment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEnrolment.Location = new System.Drawing.Point(193, 269);
            this.btnUpdateEnrolment.Name = "btnUpdateEnrolment";
            this.btnUpdateEnrolment.Size = new System.Drawing.Size(105, 35);
            this.btnUpdateEnrolment.TabIndex = 117;
            this.btnUpdateEnrolment.Text = "Update";
            this.btnUpdateEnrolment.UseVisualStyleBackColor = true;
            this.btnUpdateEnrolment.Click += new System.EventHandler(this.btnClickUpdateEnrolment);
            // 
            // btnRefreshEnrolment
            // 
            this.btnRefreshEnrolment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshEnrolment.Location = new System.Drawing.Point(415, 269);
            this.btnRefreshEnrolment.Name = "btnRefreshEnrolment";
            this.btnRefreshEnrolment.Size = new System.Drawing.Size(105, 35);
            this.btnRefreshEnrolment.TabIndex = 116;
            this.btnRefreshEnrolment.Text = "Refresh";
            this.btnRefreshEnrolment.UseVisualStyleBackColor = true;
            this.btnRefreshEnrolment.Click += new System.EventHandler(this.btnClickRefreshEnrolment);
            // 
            // btnAddEnrolment
            // 
            this.btnAddEnrolment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEnrolment.Location = new System.Drawing.Point(82, 269);
            this.btnAddEnrolment.Name = "btnAddEnrolment";
            this.btnAddEnrolment.Size = new System.Drawing.Size(105, 35);
            this.btnAddEnrolment.TabIndex = 115;
            this.btnAddEnrolment.Text = "Add";
            this.btnAddEnrolment.UseVisualStyleBackColor = true;
            this.btnAddEnrolment.Click += new System.EventHandler(this.btnClickAddEnrolment);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 111;
            this.label5.Text = "Part / Full time:";
            // 
            // txtStPartFull
            // 
            this.txtStPartFull.Location = new System.Drawing.Point(458, 119);
            this.txtStPartFull.Name = "txtStPartFull";
            this.txtStPartFull.Size = new System.Drawing.Size(136, 20);
            this.txtStPartFull.TabIndex = 107;
            // 
            // txtStYear
            // 
            this.txtStYear.Location = new System.Drawing.Point(458, 93);
            this.txtStYear.Name = "txtStYear";
            this.txtStYear.Size = new System.Drawing.Size(136, 20);
            this.txtStYear.TabIndex = 106;
            // 
            // txtStId
            // 
            this.txtStId.Location = new System.Drawing.Point(177, 93);
            this.txtStId.Name = "txtStId";
            this.txtStId.Size = new System.Drawing.Size(136, 20);
            this.txtStId.TabIndex = 105;
            this.txtStId.TextChanged += new System.EventHandler(this.txtStId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 103;
            this.label4.Text = "Student Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 102;
            this.label3.Text = "Year:";
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
            // lblDeleteEnrolment
            // 
            this.lblDeleteEnrolment.AutoSize = true;
            this.lblDeleteEnrolment.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteEnrolment.ForeColor = System.Drawing.Color.Blue;
            this.lblDeleteEnrolment.Location = new System.Drawing.Point(243, 208);
            this.lblDeleteEnrolment.Name = "lblDeleteEnrolment";
            this.lblDeleteEnrolment.Size = new System.Drawing.Size(260, 23);
            this.lblDeleteEnrolment.TabIndex = 126;
            this.lblDeleteEnrolment.Text = "Enrolment deleted  successfully!";
            this.lblDeleteEnrolment.Visible = false;
            // 
            // lblUpdateEnrolment
            // 
            this.lblUpdateEnrolment.AutoSize = true;
            this.lblUpdateEnrolment.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateEnrolment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUpdateEnrolment.Location = new System.Drawing.Point(243, 208);
            this.lblUpdateEnrolment.Name = "lblUpdateEnrolment";
            this.lblUpdateEnrolment.Size = new System.Drawing.Size(263, 23);
            this.lblUpdateEnrolment.TabIndex = 125;
            this.lblUpdateEnrolment.Text = "Enrolment updated successfully!";
            this.lblUpdateEnrolment.Visible = false;
            // 
            // lblAddEnrolment
            // 
            this.lblAddEnrolment.AutoSize = true;
            this.lblAddEnrolment.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEnrolment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAddEnrolment.Location = new System.Drawing.Point(243, 208);
            this.lblAddEnrolment.Name = "lblAddEnrolment";
            this.lblAddEnrolment.Size = new System.Drawing.Size(257, 23);
            this.lblAddEnrolment.TabIndex = 127;
            this.lblAddEnrolment.Text = "Enrolment created successfully!";
            this.lblAddEnrolment.Visible = false;
            // 
            // EditEnrolment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 771);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.lblDets);
            this.Controls.Add(this.dataGridViewEnrolment);
            this.Controls.Add(this.btnDeleteEnrolment);
            this.Controls.Add(this.btnUpdateEnrolment);
            this.Controls.Add(this.btnRefreshEnrolment);
            this.Controls.Add(this.btnAddEnrolment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStPartFull);
            this.Controls.Add(this.txtStYear);
            this.Controls.Add(this.txtStId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAdminTeacher);
            this.Controls.Add(this.btnEnrolmentBackToAdminHP);
            this.Controls.Add(this.lblUpdateEnrolment);
            this.Controls.Add(this.lblAddEnrolment);
            this.Controls.Add(this.lblDeleteEnrolment);
            this.Name = "EditEnrolment";
            this.Text = "EditEnrolment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnrolment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnrolmentBackToAdminHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label lblDets;
        private System.Windows.Forms.DataGridView dataGridViewEnrolment;
        private System.Windows.Forms.Button btnDeleteEnrolment;
        private System.Windows.Forms.Button btnUpdateEnrolment;
        private System.Windows.Forms.Button btnRefreshEnrolment;
        private System.Windows.Forms.Button btnAddEnrolment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStPartFull;
        private System.Windows.Forms.TextBox txtStYear;
        private System.Windows.Forms.TextBox txtStId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAdminTeacher;
        private System.Windows.Forms.Label lblDeleteEnrolment;
        private System.Windows.Forms.Label lblUpdateEnrolment;
        private System.Windows.Forms.Label lblAddEnrolment;
    }
}