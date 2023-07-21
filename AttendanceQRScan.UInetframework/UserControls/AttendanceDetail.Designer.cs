namespace AttendanceQRScan.UInetframework.UserControls
{
    partial class AttendanceDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceDetail));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.empImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmpTime = new System.Windows.Forms.Label();
            this.lblAttendanceStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 100;
            // 
            // empImage
            // 
            this.empImage.BackColor = System.Drawing.Color.White;
            this.empImage.Image = ((System.Drawing.Image)(resources.GetObject("empImage.Image")));
            this.empImage.ImageRotate = 0F;
            this.empImage.Location = new System.Drawing.Point(28, 2);
            this.empImage.Name = "empImage";
            this.empImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.empImage.Size = new System.Drawing.Size(75, 67);
            this.empImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empImage.TabIndex = 0;
            this.empImage.TabStop = false;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(137, 15);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(334, 23);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Solero, Francis Michael Jonathan M.";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDepartment.Location = new System.Drawing.Point(138, 38);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(240, 20);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "House Keeping";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpTime
            // 
            this.lblEmpTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmpTime.Location = new System.Drawing.Point(477, 15);
            this.lblEmpTime.Name = "lblEmpTime";
            this.lblEmpTime.Size = new System.Drawing.Size(180, 43);
            this.lblEmpTime.TabIndex = 3;
            this.lblEmpTime.Text = "Time In: 7:30:00 am";
            this.lblEmpTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAttendanceStats
            // 
            this.lblAttendanceStats.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAttendanceStats.Location = new System.Drawing.Point(663, 26);
            this.lblAttendanceStats.Name = "lblAttendanceStats";
            this.lblAttendanceStats.Size = new System.Drawing.Size(122, 20);
            this.lblAttendanceStats.TabIndex = 4;
            this.lblAttendanceStats.Text = "On Time";
            this.lblAttendanceStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttendanceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblAttendanceStats);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.empImage);
            this.Controls.Add(this.lblEmpTime);
            this.Name = "AttendanceDetail";
            this.Size = new System.Drawing.Size(855, 72);
            this.Load += new System.EventHandler(this.AttendanceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox empImage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblAttendanceStats;
        private System.Windows.Forms.Label lblEmpTime;
    }
}
