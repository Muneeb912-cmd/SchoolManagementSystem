using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.TeacherForms
{
    public partial class StudentAttendance : UserControl
    {
        public StudentAttendance(string name,string roll)
        {
            InitializeComponent();
            populate( name,  roll);
        }
        public int GetAttendanceId(string status)
        {
            int aatId;
            if (status == "Present")
            {
                aatId = 1;
            }
            else if (status == "Absent")
            {
                aatId = 2;
            }
            else
            {
                aatId = 3;
            }
            return aatId;

        }
        public void populate(string name, string roll)
        {
            name1.Text = name;
            rollno.Text = roll;            
        }

        public int GetStudentId()
        {
            int studentId=0;
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            string query = "Select StudentId From Student Where RollNo='" + rollno.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                studentId = Convert.ToInt32(dr["StudentId"]);
            }
            dr.Close();
            return studentId;
        }
        private void Status_onItemSelected(object sender, EventArgs e)
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();            
            string query = "MarkStudnetAttendance";            
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StudentId", GetStudentId());
            cmd.Parameters.AddWithValue("@Status", GetAttendanceId(Status.Text));
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.ExecuteNonQuery();
        }
    }
}
