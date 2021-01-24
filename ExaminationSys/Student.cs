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
    class Student
    {
        public string StudID { get; set; }
        public string StudFname { get; set; }
        public string StudLname { get; set; }
        public string StudEmail { get; set; }
        public string StudCity { get; set; }
        public string StudPhone { get; set; }
        public string StudUserName { get; set; }
        public string DeptId { get; set; }

    }
}
