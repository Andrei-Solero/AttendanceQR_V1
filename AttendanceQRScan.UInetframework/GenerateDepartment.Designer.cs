using System.Drawing;
using System.Windows.Forms;

namespace AttendanceQRScan.UInetframework
{
    partial class GenerateDepartment
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
            this.label3 = new System.Windows.Forms.Label();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "End Hour";
            // 
            // timeEnd
            // 
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(185, 75);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(147, 20);
            this.timeEnd.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Starting Hour";
            // 
            // timeStart
            // 
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(33, 75);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(147, 20);
            this.timeStart.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(81, 101);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(193, 27);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Department Name";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(31, 35);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(301, 20);
            this.txtDepartmentName.TabIndex = 7;
            // 
            // GenerateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 150);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartmentName);
            this.Name = "GenerateDepartment";
            this.Text = "DepartmentGeneration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private DateTimePicker timeEnd;
        private Label label2;
        private DateTimePicker timeStart;
        private Button btnGenerate;
        private Label label1;
        private TextBox txtDepartmentName;
    }
}