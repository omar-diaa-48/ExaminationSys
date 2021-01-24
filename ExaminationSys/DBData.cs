using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExaminationSys
{
    public static class DBData
    {
        public static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
    }
}
