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
        bool isMouseDown = false;
        Point LastLocation = new Point();
        public string NumberOfStudents
        {
            get => lblTotalStuds.Text;
            set => lblTotalStuds.Text = value;
        }
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
            lblTotalStuds.Text = $"Number of students: {dt.Rows.Count}";
        }

        private void sel_by_dept_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBClasses.GetStudentsWDeptId(this.department.Text);
            this.dgvData.DataSource = dt;
            lblTotalStuds.Text = $"Number of students: {dt.Rows.Count}";
        }

        private void btnDltStud_Click(object sender, EventArgs e)
        {
            string studId = "";
            if (dgvData.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow Row in dgvData.SelectedRows)
                    studId = Row.Cells[0].Value.ToString();

                if (DBClasses.DeleteStud(studId))
                    MessageBox.Show("Student deleted");
                else
                    MessageBox.Show("Student not deleted");
            }
            else
                MessageBox.Show("Select only one student to delete");
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRgstrStud_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.RegStudForm = new RegStudent();
            Forms.RegStudForm.Show();
        }

        private void btnUpdtStud_Click(object sender, EventArgs e)
        {
            string studId = "";
            if (dgvData.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow item in dgvData.SelectedRows)
                {
                    studId = item.Cells["StudId"].Value.ToString();
                }

                DataTable dt = new DataTable();
                dt = DBClasses.GetStudScore(studId);

                if (dt.Rows.Count > 0)
                {
                    string message = "";
                    foreach (DataRow item in dt.Rows)
                    {
                        message += $"{item["CourseName"]} : {item["Grade"]} : {item["TestDate"]}";
                    }

                    MessageBox.Show(message);
                }
                else
                    MessageBox.Show("No exam results for this student");
            }
            else
                MessageBox.Show("Please select only one student to show his/her results");

            
        }

        private void InstructorForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            LastLocation.X = e.X;
            LastLocation.Y = e.Y;
        }

        private void InstructorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(this.Location.X - (LastLocation.X - e.Location.X), this.Location.Y - (LastLocation.Y - e.Location.Y));
            }
        }

        private void InstructorForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
