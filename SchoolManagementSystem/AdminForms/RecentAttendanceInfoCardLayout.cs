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
    public partial class RecentAttendanceInfoCardLayout : UserControl
    {
        public RecentAttendanceInfoCardLayout(int id)
        {
            InitializeComponent();
            LoadRecentAttendance(id);
        }
        public string GetRole(string SelectedIem)
        {
            string role = "";
            if (SelectedIem == "14")
            {
                role = "Teacher";
            }
            else if (SelectedIem == "15")
            {
                role = "Admin";
            }
            else if (SelectedIem == "16")
            {
                role = "Accountant";
            }
            else if (SelectedIem == "13")
            {
                role = "Pricipal";
            }
            else if (SelectedIem == "17")
            {
                role = "Others";
            }
            return role;
        }
        public void LoadRecentAttendance(int id)
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            //Console.WriteLine("Connection Open ! ");
            SqlCommand cmd = new SqlCommand("LoadRecentAttendanceData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value =id;
            SqlDataReader sdr = cmd.ExecuteReader();
            ////Retrieve data from table and Display result
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Email.Text = sdr["Email"].ToString();
                    name.Text = sdr["Name"].ToString();
                    Designation.Text = GetRole(sdr["Role"].ToString());
                    if (sdr["AttStatus"].ToString() == "1")
                    {
                        Status.selectedIndex = 0;
                    }
                    else if (sdr["AttStatus"].ToString() == "2")
                    {
                        Status.selectedIndex = 1;
                    }
                    else
                    {
                        Status.selectedIndex = 2;
                    }     
                }
            }            
            con.Close();
        }
        public int GetAttendanceId(string status)
        {
            int statusid;
            if (status == "Present")
            {
                statusid = 1;
            }
            else if (status == "Absent")
            {
                statusid = 2;
            }
            else
            {
                statusid = 3;
            }
            return statusid;
        }
        public void UpdateEmployeeAttendance()
        {
            int empid= Convert.ToInt32(GetEmployeeId());
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            //Console.WriteLine("Connection Open ! ");
            SqlCommand cmd = new SqlCommand("UpdateEmployeeAttendance", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = empid;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = GetAttendanceId(Status.selectedValue);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update this Eployee Attendance?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateEmployeeAttendance();
                LoadRecentAttendance(Convert.ToInt32(GetEmployeeId()));
            }
        }
       
        public string GetEmployeeId()
        {
            string email = Email.Text;
            string empID = "";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select EmployeeId From Employee Where UserId='"+email+"'", con);
            cmd.CommandType = CommandType.Text;            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                empID= reader["EmployeeId"].ToString();
            }
            con.Close();
            return empID;
        }
        private void RecentAttendanceInfoCardLayout_Load(object sender, EventArgs e)
        {

        }
    }
}
