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
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnRefreshClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btbBackAdminHP = new System.Windows.Forms.Button();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.lblDets = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblAddClass = new System.Windows.Forms.Label();
            this.lblDeleteClass = new System.Windows.Forms.Label();
            this.lblUpdateClass = new System.Windows.Forms.Label();
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
            // btnDeleteClass
            // 
            this.btnDeleteClass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.Location = new System.Drawing.Point(304, 239);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(105, 35);
            this.btnDeleteClass.TabIndex = 38;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnClickDeleteClass);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClass.Location = new System.Drawing.Point(193, 239);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(105, 35);
            this.btnUpdateClass.TabIndex = 37;
            this.btnUpdateClass.Text = "Update";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnClickUpdateClass);
            // 
            // btnRefreshClass
            // 
            this.btnRefreshClass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshClass.Location = new System.Drawing.Point(415, 239);
            this.btnRefreshClass.Name = "btnRefreshClass";
            this.btnRefreshClass.Size = new System.Drawing.Size(105, 35);
            this.btnRefreshClass.TabIndex = 36;
            this.btnRefreshClass.Text = "Refresh";
            this.btnRefreshClass.UseVisualStyleBackColor = true;
            this.btnRefreshClass.Click += new System.EventHandler(this.btnClickRefresh);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.Location = new System.Drawing.Point(82, 239);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(105, 35);
            this.btnAddClass.TabIndex = 35;
            this.btnAddClass.Text = "Add";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnClickAddClass);
            // 
            // btbBackAdminHP
            // 
            this.btbBackAdminHP.BackColor = System.Drawing.SystemColors.Control;
            this.btbBackAdminHP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBackAdminHP.Location = new System.Drawing.Point(526, 239);
            this.btbBackAdminHP.Name = "btbBackAdminHP";
            this.btbBackAdminHP.Size = new System.Drawing.Size(105, 35);
            this.btbBackAdminHP.TabIndex = 34;
            this.btbBackAdminHP.Text = "Back";
            this.btbBackAdminHP.UseVisualStyleBackColor = true;
            this.btbBackAdminHP.Click += new System.EventHandler(this.btnClickBack);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(343, 145);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(72, 19);
            this.lblPostcode.TabIndex = 50;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(343, 119);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 19);
            this.lblAddress.TabIndex = 49;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(443, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(147, 20);
            this.txtAddress.TabIndex = 46;
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(177, 171);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(136, 20);
            this.txtFloor.TabIndex = 45;
            // 
            // txtBuilding
            // 
            this.txtBuilding.Location = new System.Drawing.Point(177, 145);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(136, 20);
            this.txtBuilding.TabIndex = 44;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(177, 119);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(136, 20);
            this.txtRoom.TabIndex = 43;
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding.Location = new System.Drawing.Point(88, 145);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(66, 19);
            this.lblBuilding.TabIndex = 41;
            this.lblBuilding.Text = "Building:";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.Location = new System.Drawing.Point(88, 171);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(45, 19);
            this.lblFloor.TabIndex = 40;
            this.lblFloor.Text = "Floor:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(88, 119);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(72, 19);
            this.lblRoom.TabIndex = 39;
            this.lblRoom.Text = "Room No:";
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
            // lblDets
            // 
            this.lblDets.AutoSize = true;
            this.lblDets.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDets.Location = new System.Drawing.Point(88, 66);
            this.lblDets.Name = "lblDets";
            this.lblDets.Size = new System.Drawing.Size(136, 19);
            this.lblDets.TabIndex = 54;
            this.lblDets.Text = "Enter Class Details ";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(443, 145);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(147, 20);
            this.txtPostcode.TabIndex = 47;
            // 
            // lblAddClass
            // 
            this.lblAddClass.AutoSize = true;
            this.lblAddClass.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAddClass.Location = new System.Drawing.Point(242, 204);
            this.lblAddClass.Name = "lblAddClass";
            this.lblAddClass.Size = new System.Drawing.Size(214, 23);
            this.lblAddClass.TabIndex = 55;
            this.lblAddClass.Text = "Class created successfully!";
            this.lblAddClass.Visible = false;
            // 
            // lblDeleteClass
            // 
            this.lblDeleteClass.AutoSize = true;
            this.lblDeleteClass.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteClass.ForeColor = System.Drawing.Color.Blue;
            this.lblDeleteClass.Location = new System.Drawing.Point(243, 204);
            this.lblDeleteClass.Name = "lblDeleteClass";
            this.lblDeleteClass.Size = new System.Drawing.Size(213, 23);
            this.lblDeleteClass.TabIndex = 56;
            this.lblDeleteClass.Text = "Class deleted successfully!";
            this.lblDeleteClass.Visible = false;
            // 
            // lblUpdateClass
            // 
            this.lblUpdateClass.AutoSize = true;
            this.lblUpdateClass.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUpdateClass.Location = new System.Drawing.Point(243, 204);
            this.lblUpdateClass.Name = "lblUpdateClass";
            this.lblUpdateClass.Size = new System.Drawing.Size(220, 23);
            this.lblUpdateClass.TabIndex = 57;
            this.lblUpdateClass.Text = "Class updated successfully!";
            this.lblUpdateClass.Visible = false;
            // 
            // EditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 771);
            this.Controls.Add(this.lblUpdateClass);
            this.Controls.Add(this.lblDeleteClass);
            this.Controls.Add(this.lblAddClass);
            this.Controls.Add(this.lblDets);
            this.Controls.Add(this.dataGridViewClass);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.txtBuilding);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.btnRefreshClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btbBackAdminHP);
            this.Controls.Add(this.labelAdminCourse);
            this.Name = "EditClass";
            this.Text = "EditClass";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminCourse;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnRefreshClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btbBackAdminHP;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.Label lblDets;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblAddClass;
        private System.Windows.Forms.Label lblDeleteClass;
        private System.Windows.Forms.Label lblUpdateClass;
    }
}