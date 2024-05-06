namespace AttendanceSystem
{
    partial class AddStudentsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AttendanceSystem.DataSet1();
            this.lblAddStudentsFormClassName = new MetroFramework.Controls.MetroLabel();
            this.lblAddStudentsFormClassNamePlaceholder = new MetroFramework.Controls.MetroLabel();
            this.lblAddStudentsFormClassIDPlaceholder = new MetroFramework.Controls.MetroLabel();
            this.lblAddStudentsFormClassID = new MetroFramework.Controls.MetroLabel();
            this.btnAddStudentsFormSave = new MetroFramework.Controls.MetroButton();
            this.studentsTBLTableAdapter = new AttendanceSystem.DataSet1TableAdapters.StudentsTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsTBLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "ClassID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "ClassID";
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            // 
            // studentsTBLBindingSource
            // 
            this.studentsTBLBindingSource.DataMember = "StudentsTBL";
            this.studentsTBLBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblAddStudentsFormClassName
            // 
            this.lblAddStudentsFormClassName.AutoSize = true;
            this.lblAddStudentsFormClassName.Location = new System.Drawing.Point(24, 53);
            this.lblAddStudentsFormClassName.Name = "lblAddStudentsFormClassName";
            this.lblAddStudentsFormClassName.Size = new System.Drawing.Size(81, 19);
            this.lblAddStudentsFormClassName.TabIndex = 1;
            this.lblAddStudentsFormClassName.Text = "Class Name:";
            // 
            // lblAddStudentsFormClassNamePlaceholder
            // 
            this.lblAddStudentsFormClassNamePlaceholder.AutoSize = true;
            this.lblAddStudentsFormClassNamePlaceholder.Location = new System.Drawing.Point(111, 53);
            this.lblAddStudentsFormClassNamePlaceholder.Name = "lblAddStudentsFormClassNamePlaceholder";
            this.lblAddStudentsFormClassNamePlaceholder.Size = new System.Drawing.Size(15, 19);
            this.lblAddStudentsFormClassNamePlaceholder.TabIndex = 2;
            this.lblAddStudentsFormClassNamePlaceholder.Text = "-";
            this.lblAddStudentsFormClassNamePlaceholder.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // lblAddStudentsFormClassIDPlaceholder
            // 
            this.lblAddStudentsFormClassIDPlaceholder.AutoSize = true;
            this.lblAddStudentsFormClassIDPlaceholder.Location = new System.Drawing.Point(696, 53);
            this.lblAddStudentsFormClassIDPlaceholder.Name = "lblAddStudentsFormClassIDPlaceholder";
            this.lblAddStudentsFormClassIDPlaceholder.Size = new System.Drawing.Size(15, 19);
            this.lblAddStudentsFormClassIDPlaceholder.TabIndex = 4;
            this.lblAddStudentsFormClassIDPlaceholder.Text = "-";
            // 
            // lblAddStudentsFormClassID
            // 
            this.lblAddStudentsFormClassID.AutoSize = true;
            this.lblAddStudentsFormClassID.Location = new System.Drawing.Point(609, 53);
            this.lblAddStudentsFormClassID.Name = "lblAddStudentsFormClassID";
            this.lblAddStudentsFormClassID.Size = new System.Drawing.Size(57, 19);
            this.lblAddStudentsFormClassID.TabIndex = 3;
            this.lblAddStudentsFormClassID.Text = "Class ID:";
            // 
            // btnAddStudentsFormSave
            // 
            this.btnAddStudentsFormSave.Location = new System.Drawing.Point(701, 404);
            this.btnAddStudentsFormSave.Name = "btnAddStudentsFormSave";
            this.btnAddStudentsFormSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudentsFormSave.TabIndex = 5;
            this.btnAddStudentsFormSave.Text = "Save";
            this.btnAddStudentsFormSave.Click += new System.EventHandler(this.btnAddStudentsFormSave_Click);
            // 
            // studentsTBLTableAdapter
            // 
            this.studentsTBLTableAdapter.ClearBeforeFill = true;
            // 
            // AddStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddStudentsFormSave);
            this.Controls.Add(this.lblAddStudentsFormClassIDPlaceholder);
            this.Controls.Add(this.lblAddStudentsFormClassID);
            this.Controls.Add(this.lblAddStudentsFormClassNamePlaceholder);
            this.Controls.Add(this.lblAddStudentsFormClassName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddStudentsForm";
            this.Text = "Add Students Form";
            this.Load += new System.EventHandler(this.AddStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel lblAddStudentsFormClassName;
        private MetroFramework.Controls.MetroLabel lblAddStudentsFormClassNamePlaceholder;
        private MetroFramework.Controls.MetroLabel lblAddStudentsFormClassIDPlaceholder;
        private MetroFramework.Controls.MetroLabel lblAddStudentsFormClassID;
        private MetroFramework.Controls.MetroButton btnAddStudentsFormSave;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource studentsTBLBindingSource;
        private DataSet1TableAdapters.StudentsTBLTableAdapter studentsTBLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
    }
}