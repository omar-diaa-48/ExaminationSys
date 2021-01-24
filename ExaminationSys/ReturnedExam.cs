using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys
{
    public class ReturnedExam
    {
        public string Grade, Aswers, Questions,CourseID,StudId,ExamID,testDate;
        public Dictionary<string,string > Questions_Body = new Dictionary<string, string>();
        public Dictionary<string, string> Questions_Answers = new Dictionary<string, string>();

        public ReturnedExam()
        {
            Grade = "";
            Aswers = ""; Questions = "";CourseID = "";StudId = ""; ExamID = ""; testDate="";

        }
    }
}
