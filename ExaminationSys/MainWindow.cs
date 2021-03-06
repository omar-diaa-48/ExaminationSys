﻿using System;
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
        bool isMouseDow = false;
        Point LastLocation = new Point();

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
                    Forms.StudForm.dgvData.DataSource = dt;
                    // MessageBox.Show($"Wrong User Name or Password");
                    foreach (DataRow row in dt.Rows)
                    {
                        string id = row["StudId"].ToString();
                        string fn = row["StudFname"].ToString();
                        string ln = row["StudLname"].ToString();
                        string installScript = row["StudEmail"].ToString();
                        Forms.StudForm.UserName.Text = $"{fn}";
                        Forms.StudForm.phone.Text = row["StudPhone"].ToString();
                        Forms.StudForm.email.Text = row["StudEmail"].ToString();
                        Forms.StudForm.UserNameProp = row["StudUserName"].ToString();

                    }
                    this.Hide();
                    Forms.StudForm.Show();
                }
            }
            else if(DBClasses.GetUserType(usrNameTxt.Text, usrPswdTxt.Text) == "1")
            {
                Forms.InstForm.dgvData.DataSource = dt;
                string department = "";
                foreach (DataRow row in dt.Rows)
                {
                    string id = row["InstId"].ToString();
                    string fn = row["InstFname"].ToString();
                    string ln = row["InstLname"].ToString();
                    department = row["DeptId"].ToString();
                    Forms.InstForm.UserName.Text = $"{fn}";
                    Forms.InstForm.department.Text = row["DeptId"].ToString();
                    Forms.InstForm.salary.Text = row["InstSalary"].ToString();
                }
                DataTable dtStud = DBClasses.GetStudentsWDeptId(department);
                Forms.InstForm.dgvData.DataSource = dtStud;
                Forms.InstForm.NumberOfStudents = $"Number of students: {dt.Rows.Count}";
                this.Hide();
                Forms.InstForm.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MainWindow.connection.Close();
            Application.Exit();
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDow = true;
            LastLocation.X = e.X;
            LastLocation.Y = e.Y;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDow)
            {
                this.Location = new Point(this.Location.X - (LastLocation.X - e.Location.X), this.Location.Y - (LastLocation.Y - e.Location.Y));
            }
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDow = false;
        }
    }
}
