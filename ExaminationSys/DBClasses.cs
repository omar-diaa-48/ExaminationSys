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
                taken_exam.Grade = (row["Grade"].ToString());
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
                    taken_exam.Questions += (row["QuestionId"].ToString());
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
    }
}
