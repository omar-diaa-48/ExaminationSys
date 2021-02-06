using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSys
{
    public partial class StudentForm : Form
    {
        bool isMouseDown = false;
        Point LastLocation = new Point();
        public string UserNameProp { get; set; }
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            donePass.Visible = true;
            oldPass.Visible = true;
            oldPasslabel.Visible = true;
            passwordtext.Visible = true;
            newLabel.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //MainWindow.connection.Close();
            this.Close();
            MainWindow Mn = new MainWindow();
            Mn.Show();
        }

        private void passwordtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void upd_email_Click(object sender, EventArgs e)
        {
            mailnew.Visible = true;
            doneMail.Visible = true;
            upd_email.Visible = false;
        }

        private void doneMail_Click(object sender, EventArgs e)
        {
            string New_Mail = mailnew.Text;

           if (IsValidEmail(New_Mail))
            {
                DBClasses.UpdateMail (New_Mail, UserName.Text);
                if (New_Mail != email.Text) {
                    MessageBox.Show("Your Email Successfully updated");
                    email.Text = New_Mail;
                    mailnew.Visible = false;
                    doneMail.Visible = false;
                    upd_email.Visible = true;
                }
                else
                {
                    MessageBox.Show("Your Email must be diffrent ");
                }
            }
           else
            {
                MessageBox.Show("Write email in correct format");
            }
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            phonenew.Visible = true;
            donePhone.Visible = true;
            upd_phone.Visible = false;
        }

        bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        bool IsValidphone(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([0-9])(){11}$");
        }

        private void donePhone_Click(object sender, EventArgs e)
        {
            string New_phone = phonenew.Text;

            if (IsValidphone(New_phone))
            { 
                if (New_phone != phone.Text)
                {
                    DBClasses.UpdatePhone(New_phone, UserName.Text);
                    MessageBox.Show("Your phone is Successfully updated");
                    phone.Text = New_phone;
                    phonenew.Visible = false;
                    donePhone.Visible = false;
                    upd_phone.Visible = false;
                }
                else
                {
                    MessageBox.Show("Your phone must be different");
                }
            }
            else
            {
                MessageBox.Show("Write phone in correct format");
            }
        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void donePass_Click(object sender, EventArgs e)
        {
            string New_pass = passwordtext.Text;
            string OLD= DBClasses.return_Password(UserName.Text);
            if (oldPass.Text!=OLD)
            {
                MessageBox.Show("Your Password is Wrong");
            }
            else if (New_pass!="")
            {
                DBClasses.UpdatePass(New_pass,oldPass.Text, UserName.Text);
                if (New_pass != oldPass.Text)
                {
                    MessageBox.Show("Your Password is Successfully updated");

                    donePass.Visible = false;
                    oldPass.Visible = false;
                    oldPasslabel.Visible = false;
                    passwordtext.Visible = false;
                    newLabel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Your passwords must be different");
                }
            }
            else
            {
                MessageBox.Show("Write Password in correct format");
            }
        }

        private void courses_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            courses.Visible = true;
            List<string> all = DBClasses.return_Courses(UserName.Text);
            foreach (var item in all)
            {
                courses.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string choosen = (courses.SelectedItem.ToString());
            TheExam.Studchoosen = choosen;


            ReturnedExam studExam1 = DBClasses.Generate_Exam(choosen);
            studExam1.StudId = DBClasses.ReturnStdID(UserNameProp);
            TheExam.studExam = studExam1;
            //MessageBox.Show(studExam.Questions);
            TheExam exam = new TheExam();
            this.Close();
            exam.Show();
        }

        private void StudentForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            LastLocation.X = e.X;
            LastLocation.Y = e.Y;
        }

        private void StudentForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            {
                this.Location = new Point(this.Location.X - (LastLocation.X - e.Location.X), this.Location.Y - (LastLocation.Y - e.Location.Y));
            }
        }

        private void StudentForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
