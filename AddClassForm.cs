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
    public partial class AddClassForm : MetroFramework.Forms.MetroForm
    {
        public int UserID { get; set; }
        public AddClassForm()
        {
            InitializeComponent();
        }

        private void AddClassForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClassFormAccept_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClassesTBLTableAdapter classAdapter = new DataSet1TableAdapters.ClassesTBLTableAdapter();
            classAdapter.AddClass(tbAddClassFormAddClass.Text, UserID);
            Close();
        }
    }
}
