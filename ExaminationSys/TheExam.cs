using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSys
{
    public partial class TheExam : Form
    {
        public static string Studchoosen = "";
        public static int currentQ = 0;
        public static ReturnedExam studExam = new ReturnedExam();

        public TheExam()
        {
            InitializeComponent();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExamBody_TextChanged(object sender, EventArgs e)
        {

        }

        private void TheExam_Load(object sender, EventArgs e)
        {
            submit.Visible = false;
            DisplayQ();



        }

        private void next_Click(object sender, EventArgs e)
        {
            var CURRENT = studExam.Questions_Body.ElementAt(currentQ);

            if (DBClasses.Q_type(CURRENT.Key) == "mcq")
            studExam.Questions_Answers[CURRENT.Key] = Save_AnswerMCQ();
            else studExam.Questions_Answers[CURRENT.Key] = Save_AnswerTF();


            currentQ++;
            currentQ %= 10;
            DisplayQ();
           
        }
        public string Save_AnswerMCQ()
        {
            if (this.ans1.Checked) return "A";
            else if (this.ans2.Checked) return "B";
            else if (this.ans3.Checked) return "C";
            else if (this.ans4.Checked) return "D";
            else return "NA";
        }
        public string Save_AnswerTF()
        {
            if (this.ans1.Checked) return "T";
          
            else if (this.ans3.Checked) return "F";
            
            else return "NA";
        }
        public void DisplayQ()
        {

            this.ans1.Checked = false;
            this.ans2.Checked = false;
            this.ans3.Checked = false;
            this.ans4.Checked = false;

            var CURRENT = studExam.Questions_Body.ElementAt(currentQ);
            this.quest_body.Text = (CURRENT.Value);
           // MessageBox.Show(CURRENT.Key);
            if (DBClasses.Q_type(CURRENT.Key) == "mcq")
            {

                this.ans2.Visible = true;
                this.ans4.Visible = true;
                List<string> choicess = DBClasses.Get_choices(CURRENT.Key);
                this.ans1.Text = choicess[0];
                this.ans2.Text = choicess[1];
                this.ans3.Text = choicess[2];
                this.ans4.Text = choicess[3];

            }
            else
            {
                this.ans2.Visible = false;
                this.ans4.Visible = false;
                this.ans1.Text = "True";
                this.ans3.Text = "False";
              
            }
            if (currentQ == 9) submit.Visible = true;
            else submit.Visible = false;

        }

        private void back_Click(object sender, EventArgs e)
        {
            var CURRENT = studExam.Questions_Body.ElementAt(currentQ);
            if (DBClasses.Q_type(CURRENT.Key) == "mcq")
                studExam.Questions_Answers[CURRENT.Key] = Save_AnswerMCQ();
            else studExam.Questions_Answers[CURRENT.Key] = Save_AnswerTF();

            currentQ--;
            if (currentQ < 0) currentQ = 9;
            
            DisplayQ();
        }

        private void validate_Click(object sender, EventArgs e)
        {
            int G = DBClasses.Submit_exam(ref studExam);
            G *= 10;
            MessageBox.Show("studExam.Questions" + studExam.Questions);
            MessageBox.Show("studExam.Aswers" + studExam.Aswers);
            MessageBox.Show("studExam.CourseID" + studExam.CourseID);
            MessageBox.Show("studExam.StudId" + studExam.StudId);
            studExam.Grade = G;
            MessageBox.Show("Your Grade is " + G.ToString());
            DBClasses.AddStudent_Exam(studExam);
           
        }
    }
}
