namespace AttendanceQRScan.UInetframework
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.attendedPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAttendedEmps = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.noAttendancePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEmpCountAttendance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.attendancesPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.listAttendances = new System.Windows.Forms.FlowLayoutPanel();
            this.latePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLateEmps = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.onTimePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblOnTimeEmps = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAttendanceClearFilter = new System.Windows.Forms.LinkLabel();
            this.txtEmpNameSearchQuery = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAttendanceDepartment = new System.Windows.Forms.ComboBox();
            this.lblTimedate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.departmentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.realTimeAttendanceTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.attendedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.noAttendancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.attendancesPanel.SuspendLayout();
            this.latePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.onTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentChart)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 72);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.Padding = new System.Drawing.Point(0, 0);
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1080, 645);
            this.materialTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.attendedPanel);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.noAttendancePanel);
            this.tabPage2.Controls.Add(this.attendancesPanel);
            this.tabPage2.Controls.Add(this.latePanel);
            this.tabPage2.Controls.Add(this.onTimePanel);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.ImageKey = "time-left.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1072, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Real Time Attendance";
            // 
            // attendedPanel
            // 
            this.attendedPanel.BackColor = System.Drawing.Color.White;
            this.attendedPanel.Controls.Add(this.lblAttendedEmps);
            this.attendedPanel.Controls.Add(this.label11);
            this.attendedPanel.Controls.Add(this.pictureBox4);
            this.attendedPanel.Location = new System.Drawing.Point(508, 117);
            this.attendedPanel.Name = "attendedPanel";
            this.attendedPanel.ShadowDecoration.Enabled = true;
            this.attendedPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.attendedPanel.Size = new System.Drawing.Size(244, 89);
            this.attendedPanel.TabIndex = 10;
            // 
            // lblAttendedEmps
            // 
            this.lblAttendedEmps.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendedEmps.Location = new System.Drawing.Point(73, 15);
            this.lblAttendedEmps.Name = "lblAttendedEmps";
            this.lblAttendedEmps.Size = new System.Drawing.Size(141, 45);
            this.lblAttendedEmps.TabIndex = 5;
            this.lblAttendedEmps.Text = "0";
            this.lblAttendedEmps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Attended Employees";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(54, 604);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(530, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Auto-Refresh Record: Attendance records will refresh above every 3 seconds.";
            // 
            // noAttendancePanel
            // 
            this.noAttendancePanel.BackColor = System.Drawing.Color.White;
            this.noAttendancePanel.Controls.Add(this.lblEmpCountAttendance);
            this.noAttendancePanel.Controls.Add(this.label8);
            this.noAttendancePanel.Controls.Add(this.pictureBox3);
            this.noAttendancePanel.Location = new System.Drawing.Point(758, 117);
            this.noAttendancePanel.Name = "noAttendancePanel";
            this.noAttendancePanel.ShadowDecoration.Enabled = true;
            this.noAttendancePanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.noAttendancePanel.Size = new System.Drawing.Size(244, 89);
            this.noAttendancePanel.TabIndex = 6;
            // 
            // lblEmpCountAttendance
            // 
            this.lblEmpCountAttendance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpCountAttendance.Location = new System.Drawing.Point(73, 15);
            this.lblEmpCountAttendance.Name = "lblEmpCountAttendance";
            this.lblEmpCountAttendance.Size = new System.Drawing.Size(141, 45);
            this.lblEmpCountAttendance.TabIndex = 5;
            this.lblEmpCountAttendance.Text = "0";
            this.lblEmpCountAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total No. of Employees";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // attendancesPanel
            // 
            this.attendancesPanel.BackColor = System.Drawing.Color.White;
            this.attendancesPanel.Controls.Add(this.listAttendances);
            this.attendancesPanel.Location = new System.Drawing.Point(52, 227);
            this.attendancesPanel.Name = "attendancesPanel";
            this.attendancesPanel.ShadowDecoration.Enabled = true;
            this.attendancesPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.attendancesPanel.Size = new System.Drawing.Size(893, 365);
            this.attendancesPanel.TabIndex = 5;
            // 
            // listAttendances
            // 
            this.listAttendances.AutoScroll = true;
            this.listAttendances.BackColor = System.Drawing.Color.LightGray;
            this.listAttendances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAttendances.Location = new System.Drawing.Point(0, 0);
            this.listAttendances.Name = "listAttendances";
            this.listAttendances.Padding = new System.Windows.Forms.Padding(4);
            this.listAttendances.Size = new System.Drawing.Size(893, 365);
            this.listAttendances.TabIndex = 0;
            // 
            // latePanel
            // 
            this.latePanel.BackColor = System.Drawing.Color.White;
            this.latePanel.Controls.Add(this.lblLateEmps);
            this.latePanel.Controls.Add(this.label6);
            this.latePanel.Controls.Add(this.pictureBox2);
            this.latePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.latePanel.Location = new System.Drawing.Point(258, 117);
            this.latePanel.Name = "latePanel";
            this.latePanel.ShadowDecoration.Enabled = true;
            this.latePanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.latePanel.Size = new System.Drawing.Size(244, 89);
            this.latePanel.TabIndex = 4;
            // 
            // lblLateEmps
            // 
            this.lblLateEmps.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateEmps.Location = new System.Drawing.Point(73, 15);
            this.lblLateEmps.Name = "lblLateEmps";
            this.lblLateEmps.Size = new System.Drawing.Size(141, 45);
            this.lblLateEmps.TabIndex = 5;
            this.lblLateEmps.Text = "0";
            this.lblLateEmps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Late Employees";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // onTimePanel
            // 
            this.onTimePanel.BackColor = System.Drawing.Color.White;
            this.onTimePanel.Controls.Add(this.lblOnTimeEmps);
            this.onTimePanel.Controls.Add(this.label4);
            this.onTimePanel.Controls.Add(this.pictureBox1);
            this.onTimePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onTimePanel.Location = new System.Drawing.Point(8, 117);
            this.onTimePanel.Name = "onTimePanel";
            this.onTimePanel.ShadowDecoration.Enabled = true;
            this.onTimePanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 5, 5);
            this.onTimePanel.Size = new System.Drawing.Size(244, 89);
            this.onTimePanel.TabIndex = 3;
            // 
            // lblOnTimeEmps
            // 
            this.lblOnTimeEmps.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnTimeEmps.Location = new System.Drawing.Point(73, 15);
            this.lblOnTimeEmps.Name = "lblOnTimeEmps";
            this.lblOnTimeEmps.Size = new System.Drawing.Size(141, 45);
            this.lblOnTimeEmps.TabIndex = 5;
            this.lblOnTimeEmps.Text = "0";
            this.lblOnTimeEmps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "On Time Employees";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.btnAttendanceClearFilter);
            this.panel1.Controls.Add(this.txtEmpNameSearchQuery);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbAttendanceDepartment);
            this.panel1.Controls.Add(this.lblTimedate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 101);
            this.panel1.TabIndex = 0;
            // 
            // btnAttendanceClearFilter
            // 
            this.btnAttendanceClearFilter.AutoSize = true;
            this.btnAttendanceClearFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendanceClearFilter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAttendanceClearFilter.Location = new System.Drawing.Point(922, 79);
            this.btnAttendanceClearFilter.Name = "btnAttendanceClearFilter";
            this.btnAttendanceClearFilter.Size = new System.Drawing.Size(70, 17);
            this.btnAttendanceClearFilter.TabIndex = 7;
            this.btnAttendanceClearFilter.TabStop = true;
            this.btnAttendanceClearFilter.Text = "Clear Filter";
            this.btnAttendanceClearFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAttendanceClearFilter_LinkClicked);
            // 
            // txtEmpNameSearchQuery
            // 
            this.txtEmpNameSearchQuery.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNameSearchQuery.Location = new System.Drawing.Point(830, 55);
            this.txtEmpNameSearchQuery.Name = "txtEmpNameSearchQuery";
            this.txtEmpNameSearchQuery.Size = new System.Drawing.Size(162, 21);
            this.txtEmpNameSearchQuery.TabIndex = 6;
            this.txtEmpNameSearchQuery.TextChanged += new System.EventHandler(this.txtEmpNameSearchQuery_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(728, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Search Employee:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(494, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Sort by Department";
            // 
            // cmbAttendanceDepartment
            // 
            this.cmbAttendanceDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttendanceDepartment.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAttendanceDepartment.FormattingEnabled = true;
            this.cmbAttendanceDepartment.Location = new System.Drawing.Point(601, 55);
            this.cmbAttendanceDepartment.Name = "cmbAttendanceDepartment";
            this.cmbAttendanceDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbAttendanceDepartment.TabIndex = 3;
            this.cmbAttendanceDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbAttendanceDepartment_SelectedIndexChanged);
            // 
            // lblTimedate
            // 
            this.lblTimedate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimedate.ForeColor = System.Drawing.Color.White;
            this.lblTimedate.Location = new System.Drawing.Point(582, 16);
            this.lblTimedate.Name = "lblTimedate";
            this.lblTimedate.Size = new System.Drawing.Size(410, 33);
            this.lblTimedate.TabIndex = 2;
            this.lblTimedate.Text = "Real Time Attendance";
            this.lblTimedate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Real Time Attendance of Employees today.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Real Time Attendance";
            // 
            // tabPage1
            // 
            this.tabPage1.ImageKey = "home.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(10);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1072, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.departmentChart);
            this.tabPage3.ImageKey = "department.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1072, 604);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Departments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // departmentChart
            // 
            chartArea1.Name = "ChartArea1";
            this.departmentChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.departmentChart.Legends.Add(legend1);
            this.departmentChart.Location = new System.Drawing.Point(50, 30);
            this.departmentChart.Name = "departmentChart";
            this.departmentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.departmentChart.Series.Add(series1);
            this.departmentChart.Size = new System.Drawing.Size(460, 381);
            this.departmentChart.TabIndex = 0;
            this.departmentChart.Text = "chart1";
            this.departmentChart.PrePaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.departmentChart_PrePaint);
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "employee(1).png";
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1072, 604);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Employees";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "time-left.png");
            this.imageList1.Images.SetKeyName(2, "department.png");
            this.imageList1.Images.SetKeyName(3, "employee(1).png");
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this.onTimePanel;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 8;
            this.guna2Elipse2.TargetControl = this.latePanel;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 8;
            this.guna2Elipse3.TargetControl = this.noAttendancePanel;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 8;
            this.guna2Elipse4.TargetControl = this.attendancesPanel;
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // realTimeAttendanceTimer
            // 
            this.realTimeAttendanceTimer.Enabled = true;
            this.realTimeAttendanceTimer.Interval = 3000;
            this.realTimeAttendanceTimer.Tick += new System.EventHandler(this.realTimeAttendanceTimer_Tick);
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 8;
            this.guna2Elipse5.TargetControl = this.attendedPanel;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIndicatorWidth = 10;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.DrawerWidth = 300;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0, 72, 0, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Monitoring System V.1 - 2023";
            this.Load += new System.EventHandler(this.Main_New_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.attendedPanel.ResumeLayout(false);
            this.attendedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.noAttendancePanel.ResumeLayout(false);
            this.noAttendancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.attendancesPanel.ResumeLayout(false);
            this.latePanel.ResumeLayout(false);
            this.latePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.onTimePanel.ResumeLayout(false);
            this.onTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel onTimePanel;
        private System.Windows.Forms.Label lblOnTimeEmps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel latePanel;
        private System.Windows.Forms.Label lblLateEmps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Panel attendancesPanel;
        private Guna.UI2.WinForms.Guna2Panel noAttendancePanel;
        private System.Windows.Forms.Label lblEmpCountAttendance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.FlowLayoutPanel listAttendances;
        private System.Windows.Forms.Label lblTimedate;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel attendedPanel;
        private System.Windows.Forms.Label lblAttendedEmps;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cmbAttendanceDepartment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmpNameSearchQuery;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer realTimeAttendanceTimer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private System.Windows.Forms.LinkLabel btnAttendanceClearFilter;
        private System.Windows.Forms.DataVisualization.Charting.Chart departmentChart;
    }
}