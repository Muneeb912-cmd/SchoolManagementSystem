using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class SQL_Configuration
    {
        String ConnectionStr  = @"Data Source=DESKTOP-D4E0FB3;Initial Catalog=DBFinalGID-28;Integrated Security=True"; SqlConnection con;
        private static SQL_Configuration _instance;
        public static SQL_Configuration getInstance()
        {
            if (_instance == null)
                _instance = new SQL_Configuration();
            return _instance;
        }
        private SQL_Configuration()
        {
            con = new SqlConnection(ConnectionStr);
            con.Open();
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
