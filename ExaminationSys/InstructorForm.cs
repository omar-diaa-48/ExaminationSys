using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSys
{
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow Mn = new MainWindow();
            Mn.Show();
        }

        private void sel_all_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBClasses.SelectAllStudents();
            this.dgvData.DataSource = dt;
        }

        private void sel_by_dept_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBClasses.GetStudentsWDeptId(this.department.Text);
            this.dgvData.DataSource = dt;
        }
    }
}
