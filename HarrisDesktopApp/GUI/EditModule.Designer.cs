namespace HarrisDesktopApp.GUI
{
    partial class EditModule
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
            this.moduleBtnToAdminHP = new System.Windows.Forms.Button();
            this.lblDets = new System.Windows.Forms.Label();
            this.dataGridViewModule = new System.Windows.Forms.DataGridView();
            this.buttonDeleteTeacher = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.buttonRefreshTeachers = new System.Windows.Forms.Button();
            this.buttonAddModule = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMcourseId = new System.Windows.Forms.TextBox();
            this.txtPassMark2 = new System.Windows.Forms.TextBox();
            this.txtPassMark1 = new System.Windows.Forms.TextBox();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdminTeacher = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModule)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleBtnToAdminHP
            // 
            this.moduleBtnToAdminHP.BackColor = System.Drawing.SystemColors.Control;
            this.moduleBtnToAdminHP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleBtnToAdminHP.Location = new System.Drawing.Point(526, 238);
            this.moduleBtnToAdminHP.Name = "moduleBtnToAdminHP";
            this.moduleBtnToAdminHP.Size = new System.Drawing.Size(105, 35);
            this.moduleBtnToAdminHP.TabIndex = 39;
            this.moduleBtnToAdminHP.Text = "Back";
            this.moduleBtnToAdminHP.UseVisualStyleBackColor = true;
            this.moduleBtnToAdminHP.Click += new System.EventHandler(this.btnClickBack);
            // 
            // lblDets
            // 
            this.lblDets.AutoSize = true;
            this.lblDets.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDets.Location = new System.Drawing.Point(78, 61);
            this.lblDets.Name = "lblDets";
            this.lblDets.Size = new System.Drawing.Size(157, 19);
            this.lblDets.TabIndex = 70;
            this.lblDets.Text = "Enter Module Details ";
            // 
            // dataGridViewModule
            // 
            this.dataGridViewModule.AllowUserToAddRows = false;
            this.dataGridViewModule.AllowUserToDeleteRows = false;
            this.dataGridViewModule.AllowUserToResizeColumns = false;
            this.dataGridViewModule.AllowUserToResizeRows = false;
            this.dataGridViewModule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewModule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewModule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModule.Location = new System.Drawing.Point(12, 321);
            this.dataGridViewModule.Name = "dataGridViewModule";
            this.dataGridViewModule.ReadOnly = true;
            this.dataGridViewModule.Size = new System.Drawing.Size(710, 411);
            this.dataGridViewModule.TabIndex = 69;
            // 
            // buttonDeleteTeacher
            // 
            this.buttonDeleteTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTeacher.Location = new System.Drawing.Point(304, 238);
            this.buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            this.buttonDeleteTeacher.Size = new System.Drawing.Size(105, 35);
            this.buttonDeleteTeacher.TabIndex = 68;
            this.buttonDeleteTeacher.Text = "Delete";
            this.buttonDeleteTeacher.UseVisualStyleBackColor = true;
            this.buttonDeleteTeacher.Click += new System.EventHandler(this.btnClickDeleteModule);
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateModule.Location = new System.Drawing.Point(193, 238);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(105, 35);
            this.btnUpdateModule.TabIndex = 67;
            this.btnUpdateModule.Text = "Update";
            this.btnUpdateModule.UseVisualStyleBackColor = true;
            this.btnUpdateModule.Click += new System.EventHandler(this.btnClickUpdateModule);
            // 
            // buttonRefreshTeachers
            // 
            this.buttonRefreshTeachers.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshTeachers.Location = new System.Drawing.Point(415, 238);
            this.buttonRefreshTeachers.Name = "buttonRefreshTeachers";
            this.buttonRefreshTeachers.Size = new System.Drawing.Size(105, 35);
            this.buttonRefreshTeachers.TabIndex = 66;
            this.buttonRefreshTeachers.Text = "Refresh";
            this.buttonRefreshTeachers.UseVisualStyleBackColor = true;
            this.buttonRefreshTeachers.Click += new System.EventHandler(this.btnClickRefreshModule);
            // 
            // buttonAddModule
            // 
            this.buttonAddModule.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddModule.Location = new System.Drawing.Point(82, 238);
            this.buttonAddModule.Name = "buttonAddModule";
            this.buttonAddModule.Size = new System.Drawing.Size(105, 35);
            this.buttonAddModule.TabIndex = 65;
            this.buttonAddModule.Text = "Add";
            this.buttonAddModule.UseVisualStyleBackColor = true;
            this.buttonAddModule.Click += new System.EventHandler(this.btnClickAddModule);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 64;
            this.label8.Text = "End Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 63;
            this.label7.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "Course Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 61;
            this.label5.Text = "CW2 Pass Mark:";
            // 
            // txtMcourseId
            // 
            this.txtMcourseId.Location = new System.Drawing.Point(195, 119);
            this.txtMcourseId.Name = "txtMcourseId";
            this.txtMcourseId.Size = new System.Drawing.Size(136, 20);
            this.txtMcourseId.TabIndex = 58;
            // 
            // txtPassMark2
            // 
            this.txtPassMark2.Location = new System.Drawing.Point(195, 171);
            this.txtPassMark2.Name = "txtPassMark2";
            this.txtPassMark2.Size = new System.Drawing.Size(136, 20);
            this.txtPassMark2.TabIndex = 57;
            // 
            // txtPassMark1
            // 
            this.txtPassMark1.Location = new System.Drawing.Point(195, 145);
            this.txtPassMark1.Name = "txtPassMark1";
            this.txtPassMark1.Size = new System.Drawing.Size(136, 20);
            this.txtPassMark1.TabIndex = 56;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(195, 95);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(136, 20);
            this.txtModuleName.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "CW1 Pass Mark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Name:";
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
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "";
            this.dateTimePickerStart.Location = new System.Drawing.Point(443, 145);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 74;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "";
            this.dateTimePickerEnd.Location = new System.Drawing.Point(443, 172);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 73;
            // 
            // EditModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 771);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.lblDets);
            this.Controls.Add(this.dataGridViewModule);
            this.Controls.Add(this.buttonDeleteTeacher);
            this.Controls.Add(this.btnUpdateModule);
            this.Controls.Add(this.buttonRefreshTeachers);
            this.Controls.Add(this.buttonAddModule);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMcourseId);
            this.Controls.Add(this.txtPassMark2);
            this.Controls.Add(this.txtPassMark1);
            this.Controls.Add(this.txtModuleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAdminTeacher);
            this.Controls.Add(this.moduleBtnToAdminHP);
            this.Name = "EditModule";
            this.Text = "EditModule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button moduleBtnToAdminHP;
        private System.Windows.Forms.Label lblDets;
        private System.Windows.Forms.DataGridView dataGridViewModule;
        private System.Windows.Forms.Button buttonDeleteTeacher;
        private System.Windows.Forms.Button btnUpdateModule;
        private System.Windows.Forms.Button buttonRefreshTeachers;
        private System.Windows.Forms.Button buttonAddModule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMcourseId;
        private System.Windows.Forms.TextBox txtPassMark2;
        private System.Windows.Forms.TextBox txtPassMark1;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdminTeacher;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
    }
}