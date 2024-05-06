using AttendanceSystem.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public int UserID { get; set; }
        public MainForm()
        {
            InitializeComponent();
            loggedIn = 0;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (loggedIn == 0)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();

                if (loginForm.loginFlag == false)
                {
                    Close();
                }
                else
                {
                    UserID = loginForm.UserID;
                    ssUserLabel.Text = UserID.ToString();
                    loggedIn = 1;

                    this.classesTBLTableAdapter.Fill(this.dataSet1.ClassesTBL);
                    classesTBLBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RecordsTBLTableAdapter recordsAdaptor = new RecordsTBLTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    recordsAdaptor.UpdateQuery(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), (int)cbAttendanceClassName.SelectedValue, dtpAttendanceFormDate.Text);
                }
            }
            DataTable dt_new = recordsAdaptor.GetDataBy((int)cbAttendanceClassName.SelectedValue, dtpAttendanceFormDate.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddClassForm addClassForm = new AddClassForm();
            addClassForm.UserID = this.UserID;
            addClassForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            AddStudentsForm addStudentForm = new AddStudentsForm();
            addStudentForm.ClassName = cbAttendanceClassName.Text;
            addStudentForm.ClassID = (int)cbAttendanceClassName.SelectedValue;

            addStudentForm.ShowDialog();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            RecordsTBLTableAdapter recordsAdaptor = new RecordsTBLTableAdapter();
            DataTable dt = recordsAdaptor.GetDataBy((int)cbAttendanceClassName.SelectedValue, dtpAttendanceFormDate.Text);

            if (dt.Rows.Count > 0)
            {
                DataTable dt_new = recordsAdaptor.GetDataBy((int)cbAttendanceClassName.SelectedValue, dtpAttendanceFormDate.Text);
                dataGridView1.DataSource = dt_new;
            }
            else
            {
                StudentsTBLTableAdapter studentsAdaptor = new StudentsTBLTableAdapter();
                DataTable dt_students = studentsAdaptor.GetDataByClassID((int)cbAttendanceClassName.SelectedValue);

                foreach (DataRow row in dt_students.Rows)
                {
                    recordsAdaptor.InsertQuery((int)row[0], (int)cbAttendanceClassName.SelectedValue, dtpAttendanceFormDate.Text, "", row[1].ToString(), cbAttendanceClassName.Text);
                }

                DataTable dt_new = recordsAdaptor.GetDataBy((int)cbAttendanceClassName.SelectedValue, dtpAttendanceFormDate.Text);
                dataGridView1.DataSource = dt_new;
            }
        }

        private void btnAttendanceClear_Click(object sender, EventArgs e)
        {
            RecordsTBLTableAdapter recordsAdaptor = new RecordsTBLTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    recordsAdaptor.UpdateQuery("", row.Cells[0].Value.ToString(), (int)cbAttendanceClassName.SelectedValue, dtpAttendanceFormDate.Text);
                }
            }
            DataTable dt_new = recordsAdaptor.GetDataBy((int)cbAttendanceClassName.SelectedValue, dtpAttendanceFormDate.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            StudentsTBLTableAdapter studentsAdaptor = new StudentsTBLTableAdapter();
            DataTable dt_students = studentsAdaptor.GetDataByClassID((int)cbReportsClassName.SelectedValue);

            RecordsTBLTableAdapter recordsAdaptor = new RecordsTBLTableAdapter();

            foreach (DataRow row in dt_students.Rows)
            {
                int presentCount = 0;
                int absentCount = 0;
                int lateCount = 0;
                int excusedCount = 0;

                DataRow presentRow = recordsAdaptor.GetDataByReport(dtpReportsDate.Value.Month, row[1].ToString(), "present").Rows[0];
                DataRow absentRow = recordsAdaptor.GetDataByReport(dtpReportsDate.Value.Month, row[1].ToString(), "absent").Rows[0];
                DataRow lateRow = recordsAdaptor.GetDataByReport(dtpReportsDate.Value.Month, row[1].ToString(), "late").Rows[0];
                DataRow excusedRow = recordsAdaptor.GetDataByReport(dtpReportsDate.Value.Month, row[1].ToString(), "excused").Rows[0];

                if (presentRow != null && presentRow[6] != DBNull.Value)
                    presentCount = Convert.ToInt32(presentRow[6]);
                    presentCount++;
                if (absentRow != null && absentRow[6] != DBNull.Value)
                    absentCount = Convert.ToInt32(absentRow[6]);
                    absentCount++;
                if (lateRow != null && lateRow[6] != DBNull.Value)
                    lateCount = Convert.ToInt32(lateRow[6]);
                    lateCount++;
                if (excusedRow != null && excusedRow[6] != DBNull.Value)
                    excusedCount = Convert.ToInt32(excusedRow[6]);
                    excusedCount++;

                ListViewItem listItem = new ListViewItem();
                listItem.Text = row[1].ToString();
                listItem.SubItems.Add(presentCount.ToString());
                listItem.SubItems.Add(absentCount.ToString());
                listItem.SubItems.Add(lateCount.ToString());
                listItem.SubItems.Add(excusedCount.ToString());
                listView1.Items.Add(listItem);
                listView1.Refresh();
            }
        }

        private void btnAttendanceRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void tabAttendance_Click(object sender, EventArgs e)
        {
            cbAttendanceClassName.Refresh();
        }
    }
}
