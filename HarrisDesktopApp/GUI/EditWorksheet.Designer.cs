namespace HarrisDesktopApp.GUI
{
    partial class EditWorksheet
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
            this.lblDeleteClass = new System.Windows.Forms.Label();
            this.lblUpdateClass = new System.Windows.Forms.Label();
            this.lblAddClass = new System.Windows.Forms.Label();
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
            this.buttonDeleteCourse.Location = new System.Drawing.Point(276, 200);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonDeleteCourse.TabIndex = 43;
            this.buttonDeleteCourse.Text = "Delete";
            this.buttonDeleteCourse.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCourse
            // 
            this.buttonUpdateCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCourse.Location = new System.Drawing.Point(165, 200);
            this.buttonUpdateCourse.Name = "buttonUpdateCourse";
            this.buttonUpdateCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonUpdateCourse.TabIndex = 42;
            this.buttonUpdateCourse.Text = "Update";
            this.buttonUpdateCourse.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshCourse
            // 
            this.buttonRefreshCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshCourse.Location = new System.Drawing.Point(387, 200);
            this.buttonRefreshCourse.Name = "buttonRefreshCourse";
            this.buttonRefreshCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonRefreshCourse.TabIndex = 41;
            this.buttonRefreshCourse.Text = "Refresh";
            this.buttonRefreshCourse.UseVisualStyleBackColor = true;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.Location = new System.Drawing.Point(54, 200);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(105, 35);
            this.buttonAddCourse.TabIndex = 40;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            // 
            // courseBtnToAdminHP
            // 
            this.courseBtnToAdminHP.BackColor = System.Drawing.SystemColors.Control;
            this.courseBtnToAdminHP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBtnToAdminHP.Location = new System.Drawing.Point(498, 200);
            this.courseBtnToAdminHP.Name = "courseBtnToAdminHP";
            this.courseBtnToAdminHP.Size = new System.Drawing.Size(105, 35);
            this.courseBtnToAdminHP.TabIndex = 39;
            this.courseBtnToAdminHP.Text = "Back";
            this.courseBtnToAdminHP.UseVisualStyleBackColor = true;
            this.courseBtnToAdminHP.Click += new System.EventHandler(this.btnClickBack);
            // 
            // lblDeleteClass
            // 
            this.lblDeleteClass.AutoSize = true;
            this.lblDeleteClass.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteClass.ForeColor = System.Drawing.Color.Blue;
            this.lblDeleteClass.Location = new System.Drawing.Point(199, 104);
            this.lblDeleteClass.Name = "lblDeleteClass";
            this.lblDeleteClass.Size = new System.Drawing.Size(231, 23);
            this.lblDeleteClass.TabIndex = 62;
            this.lblDeleteClass.Text = "Course deleted  successfully!";
            this.lblDeleteClass.Visible = false;
            // 
            // lblUpdateClass
            // 
            this.lblUpdateClass.AutoSize = true;
            this.lblUpdateClass.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUpdateClass.Location = new System.Drawing.Point(391, 104);
            this.lblUpdateClass.Name = "lblUpdateClass";
            this.lblUpdateClass.Size = new System.Drawing.Size(234, 23);
            this.lblUpdateClass.TabIndex = 61;
            this.lblUpdateClass.Text = "Course updated successfully!";
            this.lblUpdateClass.Visible = false;
            // 
            // lblAddClass
            // 
            this.lblAddClass.AutoSize = true;
            this.lblAddClass.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAddClass.Location = new System.Drawing.Point(199, 127);
            this.lblAddClass.Name = "lblAddClass";
            this.lblAddClass.Size = new System.Drawing.Size(228, 23);
            this.lblAddClass.TabIndex = 63;
            this.lblAddClass.Text = "Course created successfully!";
            this.lblAddClass.Visible = false;
            // 
            // EditWorksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDeleteClass);
            this.Controls.Add(this.lblUpdateClass);
            this.Controls.Add(this.lblAddClass);
            this.Controls.Add(this.buttonDeleteCourse);
            this.Controls.Add(this.buttonUpdateCourse);
            this.Controls.Add(this.buttonRefreshCourse);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.courseBtnToAdminHP);
            this.Controls.Add(this.labelAdminCourse);
            this.Name = "EditWorksheet";
            this.Text = "EditWorksheet";
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
        private System.Windows.Forms.Label lblDeleteClass;
        private System.Windows.Forms.Label lblUpdateClass;
        private System.Windows.Forms.Label lblAddClass;
    }
}