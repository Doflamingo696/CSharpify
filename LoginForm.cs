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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public bool loginFlag {  get; set; }
        public int UserID { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            loginFlag = false;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UsersTableAdapter userAdaptor = new DataSet1TableAdapters.UsersTableAdapter();
            DataTable dt = userAdaptor.GetDataByUserAndPassword(tbUsername.Text, tbPassword.Text);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Access Granted!");
                UserID = int.Parse(dt.Rows[0]["UserID"].ToString());
                loginFlag = true;
                Close();
            } 
            else
            {
                MessageBox.Show("Access Denied!");
                loginFlag = false;
            }
        }
    }
}
