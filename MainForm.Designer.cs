namespace AttendanceSystem
{
    partial class MainForm
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
            this.tabAttendanceAndReport = new MetroFramework.Controls.MetroTabControl();
            this.tabAttendance = new MetroFramework.Controls.MetroTabPage();
            this.btnAttendanceRegister = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssUserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAddStudents = new MetroFramework.Controls.MetroButton();
            this.btnAddClass = new MetroFramework.Controls.MetroButton();
            this.btnAttendanceClear = new MetroFramework.Controls.MetroButton();
            this.btnAttendanceSave = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordsTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AttendanceSystem.DataSet1();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.dtpAttendanceFormDate = new System.Windows.Forms.DateTimePicker();
            this.cbAttendanceClassName = new MetroFramework.Controls.MetroComboBox();
            this.classesTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabReports = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpReportsDate = new System.Windows.Forms.DateTimePicker();
            this.cbReportsClassName = new MetroFramework.Controls.MetroComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classesTBLTableAdapter = new AttendanceSystem.DataSet1TableAdapters.ClassesTBLTableAdapter();
            this.recordsTBLTableAdapter = new AttendanceSystem.DataSet1TableAdapters.RecordsTBLTableAdapter();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAttendanceAndReport.SuspendLayout();
            this.tabAttendance.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesTBLBindingSource)).BeginInit();
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAttendanceAndReport
            // 
            this.tabAttendanceAndReport.Controls.Add(this.tabAttendance);
            this.tabAttendanceAndReport.Controls.Add(this.tabReports);
            this.tabAttendanceAndReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAttendanceAndReport.Location = new System.Drawing.Point(20, 60);
            this.tabAttendanceAndReport.Name = "tabAttendanceAndReport";
            this.tabAttendanceAndReport.SelectedIndex = 0;
            this.tabAttendanceAndReport.Size = new System.Drawing.Size(1160, 640);
            this.tabAttendanceAndReport.TabIndex = 0;
            // 
            // tabAttendance
            // 
            this.tabAttendance.Controls.Add(this.btnAttendanceRegister);
            this.tabAttendance.Controls.Add(this.metroButton1);
            this.tabAttendance.Controls.Add(this.statusStrip1);
            this.tabAttendance.Controls.Add(this.btnAddStudents);
            this.tabAttendance.Controls.Add(this.btnAddClass);
            this.tabAttendance.Controls.Add(this.btnAttendanceClear);
            this.tabAttendance.Controls.Add(this.btnAttendanceSave);
            this.tabAttendance.Controls.Add(this.dataGridView1);
            this.tabAttendance.Controls.Add(this.lblSelectDate);
            this.tabAttendance.Controls.Add(this.lblSelectClass);
            this.tabAttendance.Controls.Add(this.dtpAttendanceFormDate);
            this.tabAttendance.Controls.Add(this.cbAttendanceClassName);
            this.tabAttendance.HorizontalScrollbarBarColor = true;
            this.tabAttendance.Location = new System.Drawing.Point(4, 35);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Size = new System.Drawing.Size(1152, 601);
            this.tabAttendance.TabIndex = 0;
            this.tabAttendance.Text = "Attendance";
            this.tabAttendance.VerticalScrollbarBarColor = true;
            this.tabAttendance.Click += new System.EventHandler(this.tabAttendance_Click);
            // 
            // btnAttendanceRegister
            // 
            this.btnAttendanceRegister.Location = new System.Drawing.Point(957, 33);
            this.btnAttendanceRegister.Name = "btnAttendanceRegister";
            this.btnAttendanceRegister.Size = new System.Drawing.Size(95, 23);
            this.btnAttendanceRegister.TabIndex = 13;
            this.btnAttendanceRegister.Text = "Register";
            this.btnAttendanceRegister.Click += new System.EventHandler(this.btnAttendanceRegister_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(404, 39);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Get Attendance";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssUser,
            this.ssUserLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1152, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssUser
            // 
            this.ssUser.Name = "ssUser";
            this.ssUser.Size = new System.Drawing.Size(33, 17);
            this.ssUser.Text = "User:";
            // 
            // ssUserLabel
            // 
            this.ssUserLabel.Name = "ssUserLabel";
            this.ssUserLabel.Size = new System.Drawing.Size(12, 17);
            this.ssUserLabel.Text = "-";
            // 
            // btnAddStudents
            // 
            this.btnAddStudents.Location = new System.Drawing.Point(856, 33);
            this.btnAddStudents.Name = "btnAddStudents";
            this.btnAddStudents.Size = new System.Drawing.Size(95, 23);
            this.btnAddStudents.TabIndex = 10;
            this.btnAddStudents.Text = "Add Students";
            this.btnAddStudents.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(756, 33);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(94, 23);
            this.btnAddClass.TabIndex = 9;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnAttendanceClear
            // 
            this.btnAttendanceClear.Location = new System.Drawing.Point(1058, 552);
            this.btnAttendanceClear.Name = "btnAttendanceClear";
            this.btnAttendanceClear.Size = new System.Drawing.Size(94, 23);
            this.btnAttendanceClear.TabIndex = 8;
            this.btnAttendanceClear.Text = "Clear";
            this.btnAttendanceClear.Click += new System.EventHandler(this.btnAttendanceClear_Click);
            // 
            // btnAttendanceSave
            // 
            this.btnAttendanceSave.Location = new System.Drawing.Point(1058, 523);
            this.btnAttendanceSave.Name = "btnAttendanceSave";
            this.btnAttendanceSave.Size = new System.Drawing.Size(94, 23);
            this.btnAttendanceSave.TabIndex = 7;
            this.btnAttendanceSave.Text = "Save";
            this.btnAttendanceSave.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.Status});
            this.dataGridView1.DataSource = this.recordsTBLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1052, 493);
            this.dataGridView1.TabIndex = 6;
            // 
            // recordsTBLBindingSource
            // 
            this.recordsTBLBindingSource.DataMember = "RecordsTBL";
            this.recordsTBLBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Location = new System.Drawing.Point(195, 17);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(63, 13);
            this.lblSelectDate.TabIndex = 5;
            this.lblSelectDate.Text = "Select Date";
            this.lblSelectDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Location = new System.Drawing.Point(-1, 17);
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(65, 13);
            this.lblSelectClass.TabIndex = 4;
            this.lblSelectClass.Text = "Select Class";
            // 
            // dtpAttendanceFormDate
            // 
            this.dtpAttendanceFormDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttendanceFormDate.Location = new System.Drawing.Point(198, 33);
            this.dtpAttendanceFormDate.Name = "dtpAttendanceFormDate";
            this.dtpAttendanceFormDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAttendanceFormDate.TabIndex = 3;
            // 
            // cbAttendanceClassName
            // 
            this.cbAttendanceClassName.DataSource = this.classesTBLBindingSource;
            this.cbAttendanceClassName.DisplayMember = "ClassName";
            this.cbAttendanceClassName.FormattingEnabled = true;
            this.cbAttendanceClassName.ItemHeight = 23;
            this.cbAttendanceClassName.Location = new System.Drawing.Point(0, 33);
            this.cbAttendanceClassName.Name = "cbAttendanceClassName";
            this.cbAttendanceClassName.Size = new System.Drawing.Size(192, 29);
            this.cbAttendanceClassName.TabIndex = 2;
            this.cbAttendanceClassName.ValueMember = "ClassID";
            // 
            // classesTBLBindingSource
            // 
            this.classesTBLBindingSource.DataMember = "ClassesTBL";
            this.classesTBLBindingSource.DataSource = this.dataSet1;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.metroButton2);
            this.tabReports.Controls.Add(this.label1);
            this.tabReports.Controls.Add(this.label2);
            this.tabReports.Controls.Add(this.dtpReportsDate);
            this.tabReports.Controls.Add(this.cbReportsClassName);
            this.tabReports.Controls.Add(this.listView1);
            this.tabReports.HorizontalScrollbarBarColor = true;
            this.tabReports.Location = new System.Drawing.Point(4, 35);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(1152, 601);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Reports";
            this.tabReports.VerticalScrollbarBarColor = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(407, 42);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(95, 23);
            this.metroButton2.TabIndex = 17;
            this.metroButton2.Text = "Get Attendance";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Class";
            // 
            // dtpReportsDate
            // 
            this.dtpReportsDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReportsDate.Location = new System.Drawing.Point(201, 36);
            this.dtpReportsDate.Name = "dtpReportsDate";
            this.dtpReportsDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReportsDate.TabIndex = 14;
            // 
            // cbReportsClassName
            // 
            this.cbReportsClassName.DataSource = this.classesTBLBindingSource;
            this.cbReportsClassName.DisplayMember = "ClassName";
            this.cbReportsClassName.FormattingEnabled = true;
            this.cbReportsClassName.ItemHeight = 23;
            this.cbReportsClassName.Location = new System.Drawing.Point(3, 36);
            this.cbReportsClassName.Name = "cbReportsClassName";
            this.cbReportsClassName.Size = new System.Drawing.Size(192, 29);
            this.cbReportsClassName.TabIndex = 13;
            this.cbReportsClassName.ValueMember = "ClassID";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1146, 518);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student";
            this.columnHeader1.Width = 207;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Present";
            this.columnHeader2.Width = 232;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Absent";
            this.columnHeader3.Width = 229;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Late";
            this.columnHeader4.Width = 255;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Excused";
            this.columnHeader5.Width = 221;
            // 
            // classesTBLTableAdapter
            // 
            this.classesTBLTableAdapter.ClearBeforeFill = true;
            // 
            // recordsTBLTableAdapter
            // 
            this.recordsTBLTableAdapter.ClearBeforeFill = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.tabAttendanceAndReport);
            this.Name = "MainForm";
            this.Text = "Attendance System";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabAttendanceAndReport.ResumeLayout(false);
            this.tabAttendance.ResumeLayout(false);
            this.tabAttendance.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesTBLBindingSource)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabAttendanceAndReport;
        private MetroFramework.Controls.MetroTabPage tabAttendance;
        private MetroFramework.Controls.MetroTabPage tabReports;
        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.DateTimePicker dtpAttendanceFormDate;
        private MetroFramework.Controls.MetroComboBox cbAttendanceClassName;
        private System.Windows.Forms.Label lblSelectDate;
        private MetroFramework.Controls.MetroButton btnAttendanceSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnAddClass;
        private MetroFramework.Controls.MetroButton btnAttendanceClear;
        private MetroFramework.Controls.MetroButton btnAddStudents;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssUser;
        private System.Windows.Forms.ToolStripStatusLabel ssUserLabel;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource classesTBLBindingSource;
        private DataSet1TableAdapters.ClassesTBLTableAdapter classesTBLTableAdapter;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.BindingSource recordsTBLBindingSource;
        private DataSet1TableAdapters.RecordsTBLTableAdapter recordsTBLTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpReportsDate;
        private MetroFramework.Controls.MetroComboBox cbReportsClassName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroButton btnAttendanceRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

