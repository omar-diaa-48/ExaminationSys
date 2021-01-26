using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys
{
    public class ReturnedExam
    {
        public int Grade;
        public string Aswers, Questions,CourseID,StudId,ExamID,testDate;
        public Dictionary<string,string > Questions_Body = new Dictionary<string, string>();
        public Dictionary<string, string> Questions_Answers = new Dictionary<string, string>();

        public ReturnedExam()
        {
            Grade = 0;
            Aswers = ""; Questions = "";CourseID = "";StudId = ""; ExamID = ""; testDate="";

        }
    }
}
