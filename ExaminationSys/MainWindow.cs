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
    public partial class MainWindow : Form
    {
        public static SqlConnection connection;   
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(DBData.connstring);
            connection.Open();
        }

        private void validate_Click(object sender, EventArgs e)
        {
            DataTable dt = DBClasses.SelectData(usrNameTxt.Text, usrPswdTxt.Text);
            if(DBClasses.GetUserType(usrNameTxt.Text, usrPswdTxt.Text) == "0")
            {
                if (dt.Rows.Count >= 1)
                {
                    StudentForm StudForm = new StudentForm();
                    StudForm.dgvData.DataSource = dt;
                    // MessageBox.Show($"Wrong User Name or Password");
                    foreach (DataRow row in dt.Rows)
                    {
                        string id = row["StudId"].ToString();
                        string fn = row["StudFname"].ToString();
                        string ln = row["StudLname"].ToString();
                        string installScript = row["StudEmail"].ToString();
                        StudForm.UserName.Text = $"{fn}";
                        StudForm.phone.Text = row["StudPhone"].ToString();
                        StudForm.email.Text = row["StudEmail"].ToString();
                        //StudForm.UserName.Text = row["StudUserName"].ToString();

                    }
                    this.Hide();
                    StudForm.Show();
                }
            }
            else if(DBClasses.GetUserType(usrNameTxt.Text, usrPswdTxt.Text) == "1")
            {
                InstructorForm InstForm = new InstructorForm();
                InstForm.dgvData.DataSource = dt;
                string department = "";
                foreach (DataRow row in dt.Rows)
                {
                    string id = row["InstId"].ToString();
                    string fn = row["InstFname"].ToString();
                    string ln = row["InstLname"].ToString();
                    department = row["DeptId"].ToString();
                    InstForm.UserName.Text = $"{fn}";
                    InstForm.department.Text = row["DeptId"].ToString();
                    InstForm.salary.Text = row["InstSalary"].ToString();
                }
                DataTable dtStud = DBClasses.GetStudentsWDeptId(department);
                InstForm.dgvData.DataSource = dtStud;
                InstForm.NumberOfStudents = $"Number of students: {dt.Rows.Count}";
                this.Hide();
                InstForm.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MainWindow.connection.Close();
            Application.Exit();
        }
    }
}
