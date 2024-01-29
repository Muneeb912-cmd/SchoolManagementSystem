
using CrystalDecisions.CrystalReports.Engine;
using SchoolManagementSystem.Reports;
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

namespace SchoolManagementSystem.AdminForms
{
    public partial class Reports : Form
    {
        public Reports(string stdclass, string session, string section,string selected)
        {
            InitializeComponent();
            if (selected=="")
            {
                LoadStudnetReports(stdclass, session, section);
            }
            else if (selected == "Teacher")
            {
                LoadTeacherReports();
            }
            else if (selected=="Principal")
            {
                LoadPrincipleReports();
            }
            else if (selected == "Accountant")
            {
                LoadAccountantReports();
            }
            else if(selected == "Others")
            {
                LoadOtherReports();
            }
            else if (selected == "Admin")
            {
                LoadAdminReports();
            }           

        }
        public Reports(DateTime dateTime)
        {
            InitializeComponent();
            LoadAttendanceReports(dateTime);
        }
        ReportDocument cry = new ReportDocument();
        public void LoadStudnetReports(string stdclass, string session, string section)
        {
            cry.Load(@"D:\Projects\Database\Final Project\DB-GID-28\DBFinalProject2\SchoolManagementSystem\Reports\StudentReports.rpt");
            string query = "ClassWiseStudents";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Class", SqlDbType.VarChar).Value = stdclass;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session;
            cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = section;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet st = new System.Data.DataSet();
            dt.Fill(st,"Student");
            cry.SetDataSource(st);
            ReportViewer.ReportSource= cry;
        }
        public void LoadTeacherReports()
        {
            cry.Load(@"D:\Projects\Database\Final Project\DB-GID-28\DBFinalProject2\SchoolManagementSystem\Reports\TeacherReport.rpt");
            string query = "TeacherInformation";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Class", SqlDbType.Int).Value = stdclass;
            //cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = session;
            //cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = section;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet st = new System.Data.DataSet();
            dt.Fill(st, "TeacherInfo");
            cry.SetDataSource(st);
            ReportViewer.ReportSource = cry;
        }
        private void Reports_Load(object sender, EventArgs e)
        {

        }
        public void LoadPrincipleReports()
        {
            cry.Load(@"D:\Projects\Database\Final Project\DB-GID-28\DBFinalProject2\SchoolManagementSystem\Reports\PrincipleReport.rpt");
            string query = "EmployeeInfo";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Selected", SqlDbType.Int).Value = "Principle";
            //cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = session;
            //cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = section;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet st = new System.Data.DataSet();
            dt.Fill(st, "PrincipleInfo");
            cry.SetDataSource(st);
            ReportViewer.ReportSource = cry;
        }
        public void LoadAccountantReports()
        {
            cry.Load(@"D:\Projects\Database\Final Project\DB-GID-28\DBFinalProject2\SchoolManagementSystem\Reports\AccountantReport.rpt");
            string query = "EmployeeInfo";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Selected", SqlDbType.Int).Value = "Accountant";
            //cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = session;
            //cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = section;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet st = new System.Data.DataSet();
            dt.Fill(st, "AccountantInfo");
            cry.SetDataSource(st);
            ReportViewer.ReportSource = cry;
        }
        public void LoadOtherReports()
        {
            cry.Load(@"D:\Projects\Database\Final Project\DB-GID-28\DBFinalProject2\SchoolManagementSystem\Reports\OtherReport.rpt");
            string query = "EmployeeInfo";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Selected", SqlDbType.Int).Value = "Others";
            //cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = session;
            //cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = section;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet st = new System.Data.DataSet();
            dt.Fill(st, "OthersInfo");
            cry.SetDataSource(st);
            ReportViewer.ReportSource = cry;
        }
        public void LoadAdminReports()
        {
            cry.Load(@"D:\Projects\Database\Final Project\DB-GID-28\DBFinalProject2\SchoolManagementSystem\Reports\AdminReport.rpt");
            string query = "EmployeeInfo";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Selected", SqlDbType.Int).Value = "Admin";
            //cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = session;
            //cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = section;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet st = new System.Data.DataSet();
            dt.Fill(st, "AdminInfo");
            cry.SetDataSource(st);
            ReportViewer.ReportSource = cry;
        }
        public void LoadAttendanceReports(DateTime date)
        {
            cry.Load(@"D:\Projects\Database\Final Project\DB-GID-28\DBFinalProject2\SchoolManagementSystem\Reports\AttendanceReport.rpt");
            string query = "AttendanceInformation";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = date;
            //cmd.Parameters.AddWithValue("@Year", SqlDbType.Int).Value = "2022";
            //cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = session;
            //cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = section;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet st = new System.Data.DataSet();
            dt.Fill(st, "AttendanceInfo");
            cry.SetDataSource(st);
            ReportViewer.ReportSource = cry;
        }
    }
}
