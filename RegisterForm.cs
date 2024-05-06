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
    public partial class RegisterForm : MetroFramework.Forms.MetroForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterFormRegister_Click(object sender, EventArgs e)
        {
            if(tbRegisterFormConfirmPassword.Text != tbRegisterFormPassword.Text)
            {
                MessageBox.Show("Passwords don't match!");
                return;
            }

            DataSet1TableAdapters.UsersTableAdapter registerUser = new DataSet1TableAdapters.UsersTableAdapter();
            registerUser.InsertQuery(tbRegisterFormUsername.Text, tbRegisterFormPassword.Text);
            MessageBox.Show("Registeration Successful!");
            Close();
        }
    }
}
