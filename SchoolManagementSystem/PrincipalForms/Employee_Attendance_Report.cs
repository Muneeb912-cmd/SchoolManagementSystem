using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem.PrincipalForms
{
    public partial class Employee_Attendance_Report : Form
    {
        private static List<Employee_AttendanceCard_UC> employeeAttList;
        public static List<Employee_AttendanceCard_UC> employeeAttListObj
        {
            get
            {
                if (employeeAttList == null)
                {
                    employeeAttList = new List<Employee_AttendanceCard_UC>();
                }
                return employeeAttList;
            }
        }
        public Employee_Attendance_Report()
        {
            InitializeComponent();
            bunifuDatePicker1.Format = DateTimePickerFormat.Custom;
            bunifuDatePicker1.CustomFormat = "MMMM";
            bunifuDatePicker1.MaxDate = DateTime.Today;
            bunifuDatePicker1.MinDate = Convert.ToDateTime("1/1/2021");
            bunifuDatePicker1.ShowUpDown = true;
            toolTip1.SetToolTip(loadAttendanceBtn, "Click Here To load Attendance");
            populateEmployeeRoleComboBox();
            timer1.Start();
            loadAttendanceData();
            loadListToGUI("");
        }

        private void populateEmployeeRoleComboBox()
        {
            string query = "EXEC	stpGetEmployeeRole";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                filterRoleDropDown.Items.Add(rd[0].ToString());
            }
            rd.Close();
        }
        private string getRoleString(int role)
        {
            switch (role)
            {
                case 13:
                    return "Principal";
                case 14:
                    return "Teacher";
                case 15:
                    return "Admin";
                case 16:
                    return "Accountant";
                case 17:
                    return "Others";
                default:
                    return "Others";
            }
        }

        private void loadListToGUI(string role)
        {
            foreach (var item2 in employeeAttList)
            {
                if (role == "")
                {
                    Employee_AttendanceCard_UC s = item2;
                    this.flowLayoutPanel1.Controls.Add(s);
                }
                else
                {
                    if (item2.EmployeeRole == role)
                    {
                        Employee_AttendanceCard_UC s = item2;
                        this.flowLayoutPanel1.Controls.Add(s);
                    }
                }
            }
        }
        private void loadAttendanceData()
        {
            this.flowLayoutPanel1.Controls.Clear();
            Employee_Attendance_Report.employeeAttListObj.Clear();
            //employeeAttList.Clear();
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("stpGetEmployeeAttendancePercentage", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@month", bunifuDatePicker1.Value.ToString("MMMM"));
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Employee_AttendanceCard_UC eac = new Employee_AttendanceCard_UC();
                eac.EmployeeName = rd[0].ToString();
                eac.EmployeeRole = getRoleString(Convert.ToInt32(rd[1].ToString()));
                eac.AttendanceMonth = rd[2].ToString();
                eac.AttendancePercentage = rd[3].ToString();

                employeeAttListObj.Add(eac);
            }
            rd.Close();
        }

        private void loadAttendanceBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(bunifuDatePicker1.Value.ToString("MMMM"));
            loadingPanel.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            timer1.Start();
            loadAttendanceData();
            loadListToGUI("");
        }

        private void filterRoleDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            timer1.Start();
            loadAttendanceData();
            loadListToGUI(filterRoleDropDown.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BunifuTransition transition = new BunifuTransition();
            transition.HideSync(pictureBox1, false, BunifuAnimatorNS.Animation.Particles);
            transition.MaxAnimationTime = 500;
            loadingPanel.Visible = false;
            timer1.Stop();
        }
    }
}
