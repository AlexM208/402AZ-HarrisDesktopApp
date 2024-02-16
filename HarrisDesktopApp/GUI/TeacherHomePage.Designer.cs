namespace HarrisDesktopApp
{
    partial class TeacherHomePage
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnTimetableDets = new System.Windows.Forms.Button();
            this.btnMaterialsTeacher = new System.Windows.Forms.Button();
            this.btnStudentTeacher = new System.Windows.Forms.Button();
            this.btnLogoutTeacher = new System.Windows.Forms.Button();
            this.dataGridViewStTeacher = new System.Windows.Forms.DataGridView();
            this.dataGridViewTimetableTeacher = new System.Windows.Forms.DataGridView();
            this.dataGridViewStClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetableTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStClass)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(12, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(190, 29);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome Teacher";
            // 
            // btnTimetableDets
            // 
            this.btnTimetableDets.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimetableDets.Location = new System.Drawing.Point(17, 148);
            this.btnTimetableDets.Name = "btnTimetableDets";
            this.btnTimetableDets.Size = new System.Drawing.Size(132, 42);
            this.btnTimetableDets.TabIndex = 1;
            this.btnTimetableDets.Text = "Timetable";
            this.btnTimetableDets.UseVisualStyleBackColor = true;
            this.btnTimetableDets.Click += new System.EventHandler(this.btnClickTimetableDets);
            // 
            // btnMaterialsTeacher
            // 
            this.btnMaterialsTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialsTeacher.Location = new System.Drawing.Point(155, 148);
            this.btnMaterialsTeacher.Name = "btnMaterialsTeacher";
            this.btnMaterialsTeacher.Size = new System.Drawing.Size(132, 42);
            this.btnMaterialsTeacher.TabIndex = 2;
            this.btnMaterialsTeacher.Text = "Materials";
            this.btnMaterialsTeacher.UseVisualStyleBackColor = true;
            this.btnMaterialsTeacher.Click += new System.EventHandler(this.btnClickMaterialsDets);
            // 
            // btnStudentTeacher
            // 
            this.btnStudentTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentTeacher.Location = new System.Drawing.Point(293, 148);
            this.btnStudentTeacher.Name = "btnStudentTeacher";
            this.btnStudentTeacher.Size = new System.Drawing.Size(132, 42);
            this.btnStudentTeacher.TabIndex = 3;
            this.btnStudentTeacher.Text = "Students";
            this.btnStudentTeacher.UseVisualStyleBackColor = true;
            this.btnStudentTeacher.Click += new System.EventHandler(this.btnClickStudentDets);
            // 
            // btnLogoutTeacher
            // 
            this.btnLogoutTeacher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutTeacher.Location = new System.Drawing.Point(208, 4);
            this.btnLogoutTeacher.Name = "btnLogoutTeacher";
            this.btnLogoutTeacher.Size = new System.Drawing.Size(129, 34);
            this.btnLogoutTeacher.TabIndex = 13;
            this.btnLogoutTeacher.Text = "Logout";
            this.btnLogoutTeacher.UseVisualStyleBackColor = true;
            this.btnLogoutTeacher.Click += new System.EventHandler(this.btnClickLogoutTeacher);
            // 
            // dataGridViewStTeacher
            // 
            this.dataGridViewStTeacher.AllowUserToAddRows = false;
            this.dataGridViewStTeacher.AllowUserToDeleteRows = false;
            this.dataGridViewStTeacher.AllowUserToResizeColumns = false;
            this.dataGridViewStTeacher.AllowUserToResizeRows = false;
            this.dataGridViewStTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStTeacher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStTeacher.Location = new System.Drawing.Point(12, 225);
            this.dataGridViewStTeacher.Name = "dataGridViewStTeacher";
            this.dataGridViewStTeacher.ReadOnly = true;
            this.dataGridViewStTeacher.Size = new System.Drawing.Size(544, 284);
            this.dataGridViewStTeacher.TabIndex = 94;
            this.dataGridViewStTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStTeacher_CellContentClick);
            // 
            // dataGridViewTimetableTeacher
            // 
            this.dataGridViewTimetableTeacher.AllowUserToAddRows = false;
            this.dataGridViewTimetableTeacher.AllowUserToDeleteRows = false;
            this.dataGridViewTimetableTeacher.AllowUserToResizeColumns = false;
            this.dataGridViewTimetableTeacher.AllowUserToResizeRows = false;
            this.dataGridViewTimetableTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTimetableTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimetableTeacher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTimetableTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimetableTeacher.Location = new System.Drawing.Point(12, 225);
            this.dataGridViewTimetableTeacher.Name = "dataGridViewTimetableTeacher";
            this.dataGridViewTimetableTeacher.ReadOnly = true;
            this.dataGridViewTimetableTeacher.Size = new System.Drawing.Size(544, 284);
            this.dataGridViewTimetableTeacher.TabIndex = 95;
            // 
            // dataGridViewStClass
            // 
            this.dataGridViewStClass.AllowUserToAddRows = false;
            this.dataGridViewStClass.AllowUserToDeleteRows = false;
            this.dataGridViewStClass.AllowUserToResizeColumns = false;
            this.dataGridViewStClass.AllowUserToResizeRows = false;
            this.dataGridViewStClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStClass.Location = new System.Drawing.Point(12, 225);
            this.dataGridViewStClass.Name = "dataGridViewStClass";
            this.dataGridViewStClass.ReadOnly = true;
            this.dataGridViewStClass.Size = new System.Drawing.Size(544, 284);
            this.dataGridViewStClass.TabIndex = 96;
            // 
            // TeacherHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 521);
            this.Controls.Add(this.dataGridViewStClass);
            this.Controls.Add(this.dataGridViewStTeacher);
            this.Controls.Add(this.btnLogoutTeacher);
            this.Controls.Add(this.btnStudentTeacher);
            this.Controls.Add(this.btnMaterialsTeacher);
            this.Controls.Add(this.btnTimetableDets);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.dataGridViewTimetableTeacher);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TeacherHomePage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.TeacherHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetableTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnTimetableDets;
        private System.Windows.Forms.Button btnMaterialsTeacher;
        private System.Windows.Forms.Button btnStudentTeacher;
        private System.Windows.Forms.Button btnLogoutTeacher;
        private System.Windows.Forms.DataGridView dataGridViewStTeacher;
        private System.Windows.Forms.DataGridView dataGridViewTimetableTeacher;
        private System.Windows.Forms.DataGridView dataGridViewStClass;
    }
}