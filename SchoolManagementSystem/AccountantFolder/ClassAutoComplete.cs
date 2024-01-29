using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.AccountantFolder
{
    internal class ClassAutoComplete
    {
        private int ClassID;
        private string ClassName;
        private string EmployeeName;
        private string EmployeeRole;
        public static List<String> ClassList = new List<String>(); 
        public static List<String> NameList = new List<String>();
        public static List<String> RoleList = new List<String>();
        public int classID { get => ClassID; set => ClassID = value; }
        public string Title { get => ClassName; set => ClassName = value; }
        public List<string> Classlist { get => ClassList; set => ClassList = value; }
        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        public string EmployeeRole1 { get => EmployeeRole; set => EmployeeRole = value; }
        public List<string> Namelist { get => NameList; set => NameList = value; }
        public List<string> Rolelist { get => RoleList; set => RoleList = value; }

        public void SetClass()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            string query = " SELECT Title FROM Class";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                ClassList.Add(dt.Rows[i]["Title"].ToString());

            }
            
        }
        public void SetName()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            string query = " SELECT p.First_Name+' '+p.Last_Name AS Name FROM Person p JOin Employee E ON E.EmployeeId=p.ID";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NameList.Add(dt.Rows[i]["Name"].ToString());

            }

        }
        public void SetRole()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            string query = "SELECT VALUE FROM LookUp where CATEGORY='Employee_Role'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                RoleList.Add(dt.Rows[i]["VALUE"].ToString());

            }

        }
    }
}
