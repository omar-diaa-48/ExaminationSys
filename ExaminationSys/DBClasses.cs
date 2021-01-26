using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSys
{
    public static class DBClasses
    {
        static SqlConnection connection = MainWindow.connection;
        public static string GetUserType(string usrName, string usrPswd)
        {
            string user_type ="";
            try
            {
                DataTable dt = new DataTable();
                SqlCommand sqlCmd = new SqlCommand("getUsrType", connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@usrNm", usrName));
                sqlCmd.Parameters.Add(new SqlParameter("@usrpswd", usrPswd));
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                sqlAdapter.Fill(dt);
                if (dt.Rows.Count >= 1)
                    foreach (DataRow row in dt.Rows)
                        user_type = row["UserType"].ToString();
            }
            catch (Exception)
            {

            }
            return user_type;
        }
        public static DataTable SelectAllStudents()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("selAllStuds", connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

                adapter.Fill(dt);
                if (dt.Rows.Count < 1)
                    MessageBox.Show("No data found");

            }
            catch (Exception)
            {

                MessageBox.Show("Something wrong happened");
            }
            return dt;
        }
        public static DataTable SelectData(string usrName, string usrPswd)
        {
            
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("selUsrNameWPswd", connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@usrNm", usrName));
                sqlCmd.Parameters.Add(new SqlParameter("@usrpswd", usrPswd));
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                
                adapter.Fill(dt);
                if (dt.Rows.Count < 1)
                    MessageBox.Show("Wrong User Name or Password");
            }
            catch (Exception)
            {
                MessageBox.Show("Something Wrong happened");
            }
            return dt;
        }
        public static DataTable GetStudentsWDeptId(string deptId)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand sqlCmd = new SqlCommand("selStudWDept", connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@deptId", deptId));
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd);
                sqlAdapter.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong happened");
            }

            return dt;
        }
        public static bool DeleteStud(string studId)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("DeleteStudent", connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@StudId", studId));

                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong happened");
                return true;
            }
        }
        public static void UpdatePhone(string phone, string usrName)
        {
            SqlCommand sqlCmd = new SqlCommand("Update_Email", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@newEmail", phone));
            sqlCmd.Parameters.Add(new SqlParameter("@username", usrName));
            sqlCmd.ExecuteNonQuery();

        }
        public static void UpdatePass(string newPass, string oldPass,string usrName)
        {
            SqlCommand sqlCmd = new SqlCommand("Update_password", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@newpass", newPass));
            
                sqlCmd.Parameters.Add(new SqlParameter("@oldPass", oldPass));
            sqlCmd.Parameters.Add(new SqlParameter("@username", usrName));
            sqlCmd.ExecuteNonQuery();

        }
        public static void UpdateMail(string mail, string usrName)
        {
            SqlCommand sqlCmd = new SqlCommand("Update_Email", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@newEmail", mail));
            sqlCmd.Parameters.Add(new SqlParameter("@username", usrName));
            sqlCmd.ExecuteNonQuery();
           
        }
        public static string return_Password (string usrName)
        {
            DataTable dt = new DataTable();
            string Pass = "";
            SqlCommand sqlCmd = new SqlCommand("return_Password", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@username", usrName));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("Wrong Password ");
            else 
                foreach (DataRow row in dt.Rows)
                    Pass = row["UserPassword"].ToString();
                    return Pass;
        }
        public static List<string> return_Courses(string usrName)
        {
            
            DataTable dt = new DataTable();
            List<string> all_crs = new List<string>();
            SqlCommand sqlCmd = new SqlCommand("Student_Courses", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@username", usrName));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("NO courses For You ");
            else
                foreach (DataRow row in dt.Rows)
                {
                   

                    all_crs.Add(row["CourseName"].ToString());
                }
            return all_crs;
        }
        public static string return_NewExam_Questions_ID(string usrName)
        {
            DataTable dt = new DataTable();
            string Pass = "";
            SqlCommand sqlCmd = new SqlCommand("return_Password", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@username", usrName));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("Wrong Password ");
            else
                foreach (DataRow row in dt.Rows)
                    Pass = row["UserPassword"].ToString();
            return Pass;
        }
        public static ReturnedExam Student_taked_theExam (string usrName, string courseName)
        {
            ReturnedExam taken_exam= new ReturnedExam();

            DataTable dt = new DataTable();
            List<string> all_crs = new List<string>();
            SqlCommand sqlCmd = new SqlCommand("Student_taked_theExam", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@username", usrName));
            sqlCmd.Parameters.Add(new SqlParameter("@courseName", courseName));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
           
                foreach (DataRow row in dt.Rows)
                {


                taken_exam.CourseID=(row["CourseId"].ToString());
               
                taken_exam.StudId = (row["StudId"].ToString());
                taken_exam.ExamID = (row["ExamId"].ToString());
                taken_exam.Grade = ((int)row["Grade"]);
                taken_exam.testDate = (row["TestDate"].ToString());
                taken_exam.Aswers = (row["Answer"].ToString());
                taken_exam.Questions = (row["Questions"].ToString());
                

            }
            return taken_exam;

        }
        public static string Get_CourseID(string coursName)
        {
            string CourseId = "";

            DataTable dt = new DataTable();
            List<string> all_crs = new List<string>();
            SqlCommand sqlCmd = new SqlCommand("Get_Course_ID", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@CName", coursName));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("NO Exames For You ");
            else
                foreach (DataRow row in dt.Rows)
                {
                    CourseId = (row["CourseId"].ToString());
                }
            return CourseId;

        }
        public static ReturnedExam Generate_Exam(string courseName)
        {
            ReturnedExam taken_exam = new ReturnedExam();
            string CourseId = Get_CourseID(courseName);
            taken_exam.CourseID = CourseId;
            DataTable dt = new DataTable();
            List<string> all_crs = new List<string>();
            SqlCommand sqlCmd = new SqlCommand("createAllExam", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@CId", CourseId));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("No courses for you");
            else
                foreach (DataRow row in dt.Rows)
                {
                    taken_exam.Questions += ($"{row["QuestionId"].ToString()},");
                    taken_exam.Questions_Body.Add((row["QuestionId"].ToString()),row["MCQBody"].ToString());
                }
            return taken_exam;

        }
        public static string Q_type (string qid)
        {
            string type = "";

            DataTable dt = new DataTable();
           
            SqlCommand sqlCmd = new SqlCommand("get_QType", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@qid", qid));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("No exams for you");
            else
                foreach (DataRow row in dt.Rows)
                {
                  type = (row["QType"].ToString());
                }
            return type.ToLower();

        }
        public static bool getUserName(string usrName)
        {

            DataTable dt = new DataTable();
            string name = "";
            SqlCommand sqlCmd = new SqlCommand("GetUserName", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@uname", usrName));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                return false;
            else
                foreach (DataRow row in dt.Rows)
                    name = row["UserName"].ToString();
            return name.ToLower() == usrName.ToLower();

        }
        public static bool getStudId(string id)
        {
            DataTable dt = new DataTable();
            string sid = "";
            SqlCommand sqlCmd = new SqlCommand("GetStudId", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@sid", id));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                return false;
            else
                foreach (DataRow row in dt.Rows)
                    sid = row["StudId"].ToString();
            return sid.ToLower() == id.ToLower();
        }
        public static List<string> return_Depts()
        {

            DataTable dt = new DataTable();
            List<string> all_crs = new List<string>();
            SqlCommand sqlCmd = new SqlCommand("GetDeptId", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("NO Dept");
            else
                foreach (DataRow row in dt.Rows)
                {
                    all_crs.Add(row["DeptId"].ToString());
                }
            return all_crs;
        }
        public static void setStudent(string deptid, string email, string uname, string fname, string lname, string phone,
                               string pass, string studid, string city)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("InsertStud", connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@studId", studid));
                sqlCmd.Parameters.Add(new SqlParameter("@studFname", fname));
                sqlCmd.Parameters.Add(new SqlParameter("@studLname", lname));
                sqlCmd.Parameters.Add(new SqlParameter("@studEmail", email));
                sqlCmd.Parameters.Add(new SqlParameter("@studCity", city));
                sqlCmd.Parameters.Add(new SqlParameter("@studPhone", phone));
                sqlCmd.Parameters.Add(new SqlParameter("@studUsername", uname));
                sqlCmd.Parameters.Add(new SqlParameter("@studPassword", pass));
                sqlCmd.Parameters.Add(new SqlParameter("@studDeptId", deptid));
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong happened");
            }
        }
        public static string ReturnStdID(string user)
        {
            DataTable dt = new DataTable();
            //GetStudID
            string s = "";
            SqlCommand sqlCmd = new SqlCommand("GetStudID", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@usrName", user));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("NO Exames For You ");
            else
                foreach (DataRow row in dt.Rows)
                {
                    s = (row["StudId"].ToString());
                }
            return s;
        }
        public static List<string> Get_choices(string Qid)
        {
            List<string> choices = new List<string>();

            DataTable dt = new DataTable();

            SqlCommand sqlCmd = new SqlCommand("Get_Choices", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@Qid", Qid));
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("Wrong question");
            else
                foreach (DataRow row in dt.Rows)
                {
                    choices.Add((row["AnsA"].ToString()));
                    choices.Add((row["AnsB"].ToString()));
                    choices.Add((row["AnsC"].ToString()));
                    choices.Add((row["AnsD"].ToString()));
                }


            return choices;

        }
        //return 
        //return the grade 
        public static int Submit_exam(ref ReturnedExam e)
        {

            int Grade = 0;

            string Answers = "", correct = "";
            foreach (var i in e.Questions_Answers)
            {
                Answers += (i.Value + ',');
            }
            foreach (var QID in e.Questions_Answers.Keys)
                correct += (Get_Correct_Ans(QID) + ',');
            Grade = Get_Matched(correct, Answers);

            e.Aswers = Answers;

            return Grade;
        }
        public static string Get_Correct_Ans(string QID)
        {
            string correct = "";

            DataTable dt = new DataTable();
            List<string> all_crs = new List<string>();
            SqlCommand sqlCmd = new SqlCommand("GetModelAns", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@QID", QID));

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("NO Grade For You ");
            else
                foreach (DataRow row in dt.Rows)
                    correct = row["ModelAnswer"].ToString();

            return correct;
        }
        public static int Get_Matched(string Correct, string Answers)
        {
            int Grade = 0;
            DataTable dt = new DataTable();
            List<string> all_crs = new List<string>();
            SqlCommand sqlCmd = new SqlCommand("CompareAnswers", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@str1", Correct));
            sqlCmd.Parameters.Add(new SqlParameter("@str2", Answers));

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);

            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
                MessageBox.Show("NO Grade For You ");
            else
                foreach (DataRow row in dt.Rows)
                { int.TryParse(row[0].ToString(), out Grade); }


            return Grade - 1;
        }
        public static void AddStudent_Exam(ReturnedExam exam)
        {
            /*@crsID varchar(3), @stdID varchar(3),

                            @grade int,
							@TestDate Date, @ans varchar(255),@quesID varchar(255)
            */
            SqlCommand sqlCmd = new SqlCommand("Add_StudentTest", connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@crsID", exam.CourseID));
            sqlCmd.Parameters.Add(new SqlParameter("@stdID", exam.StudId));

            sqlCmd.Parameters.Add(new SqlParameter("@grade", exam.Grade));
            sqlCmd.Parameters.Add(new SqlParameter("@TestDate", DateTime.Today));
            sqlCmd.Parameters.Add(new SqlParameter("@ans", exam.Aswers));
            sqlCmd.Parameters.Add(new SqlParameter("@questions", exam.Questions));
            sqlCmd.ExecuteNonQuery();
        }
    }
}
