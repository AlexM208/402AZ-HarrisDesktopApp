namespace HarrisDesktopApp.GUI
{
    partial class StudentHomeP
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
            this.labelStudentHP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStudentHP
            // 
            this.labelStudentHP.AutoSize = true;
            this.labelStudentHP.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentHP.Location = new System.Drawing.Point(12, 9);
            this.labelStudentHP.Name = "labelStudentHP";
            this.labelStudentHP.Size = new System.Drawing.Size(190, 29);
            this.labelStudentHP.TabIndex = 3;
            this.labelStudentHP.Text = "Welcome Student";
            // 
            // StudentHomeP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStudentHP);
            this.Name = "StudentHomeP";
            this.Text = "StudentHomeP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentHP;
    }
}