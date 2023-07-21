namespace AttendanceQRScan.UInetframework.UserControls
{
    partial class DepartmentDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblSchedEmpCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 7;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(3, 7);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(249, 47);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "Internet Management";
            this.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDepartmentName.UseCompatibleTextRendering = true;
            // 
            // lblSchedEmpCount
            // 
            this.lblSchedEmpCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedEmpCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSchedEmpCount.Location = new System.Drawing.Point(258, 7);
            this.lblSchedEmpCount.Name = "lblSchedEmpCount";
            this.lblSchedEmpCount.Size = new System.Drawing.Size(181, 47);
            this.lblSchedEmpCount.TabIndex = 1;
            this.lblSchedEmpCount.Text = "Schedule: 8:00am - 5:00pm\r\nNo. of Employees: 1000";
            this.lblSchedEmpCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSchedEmpCount.UseCompatibleTextRendering = true;
            // 
            // DepartmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblSchedEmpCount);
            this.Controls.Add(this.lblDepartmentName);
            this.Name = "DepartmentDetails";
            this.Size = new System.Drawing.Size(454, 60);
            this.Load += new System.EventHandler(this.DepartmentDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblSchedEmpCount;
    }
}
