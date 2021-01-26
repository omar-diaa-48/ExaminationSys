using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExaminationSys
{
    public partial class RegStudent : Form
    {
       
        public RegStudent()
        {
            InitializeComponent();
        }

        private void newLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegStudent_Load(object sender, EventArgs e)
        {
            List<string> all = DBClasses.return_Depts();
            foreach (var item in all)
            {
                dept.Items.Add(item);
            }
        }

        bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            if(Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                return true;
            else
            {
                MessageBox.Show("Write email in correct format");
                return false;
            }
        }

        bool IsValidUsername(string str)
        {
            if (!(DBClasses.getUserName(str)))
                return true;
            else
            {
                MessageBox.Show("Write another user name ");
                return false;
            }
           
        }
        bool IsValidStudID(string str)
        {
            if(!(DBClasses.getStudId(str)))
                return true;
            else
            {
                MessageBox.Show("Write another student id ");
                return false;
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (IsValidUsername(userNametxt.Text)&& IsValidStudID(idtxt.Text)&& IsValidEmail(emailtxt.Text))
            {
                string deptid = (dept.SelectedItem.ToString());
                string email = emailtxt.Text;
                string uname = userNametxt.Text;
                string fname = fNametxt.Text;
                string lname = LNametxt.Text;
                string phone = phonetxt.Text;
                string pass = passwordtext.Text;
                string studid = idtxt.Text;
                string city = citytxt.Text;
                DBClasses.setStudent(deptid, email, uname, fname, lname, phone, pass, studid, city);
            }          
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.InstForm.Show();
        }
    }
}
