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
    public partial class EmployeeAttendance : UserControl
    {
        public EmployeeAttendance()
        {
            InitializeComponent();
        }
        int id;
        public void PopulateAttendeceStatud()
        {
            Attendance1.Items.Clear();
            string query = "Select Value From LookUp where CATEGORY = 'ATTENDANCE_STATUS'";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())//while true
            {
                query = dr[0].ToString();
                Attendance1.Items.Add(query);
            }
            dr.Close();
            con.Close();
            
        }
        private void EmployeeAttendance_Load(object sender, EventArgs e)
        {
            PopulateAttendeceStatud();
            name.Enabled = false;
            //CurrentDate.Enabled = false;
            RecentAttendance.Visible = false;
            bunifuCustomLabel7.Visible = false;
            RecentAttendance.Controls.Clear();
        }
        public void SearchUsers()
        {

            if (SearchBox.Text == "")
            {
                MessageBox.Show("Please enter a search term");
            }
            else
            {
                SearchBy();
            }
        }
        public void SearchBy()
        {
            if (SearchBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid search value !");
            }
            else
            {
                if (EmployeeSearch.Text.Length == 10)
                {
                    SearchByContact();

                }
                else if (EmployeeSearch.Text.Contains("@"))
                {
                    SearchByEmail();

                }
                else if (EmployeeSearch.Text.Length < 10)
                {
                    SearchById();

                }
                else
                {
                    MessageBox.Show("No Employee Found");
                    //NormalState();
                }
            }
        }
        Validators v = new Validators();
        public void SearchByContact()
        {
            

            string name = "";            
            string role = "";
            if (Role.selectedIndex == -1)
            {
                role = "";
            }
            else
            {
                role = GetRoleID(Role.selectedValue).ToString();
            }

            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SearchEmployeeUserId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = Convert.ToInt32(EmployeeSearch.Text);
                cmd.Parameters.AddWithValue("@Email", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@HiredAs", SqlDbType.Int).Value = role;
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {

                        EmployeeName.Text = sdr["Name"].ToString();
                        id = Convert.ToInt32(sdr["Id"]);
                        pictureBox1.Image = v.ConvertByteToImage(sdr["Photo"] as byte[]);

                    }
                }
                else
                {
                    Role.selectedIndex = -1;
                    MessageBox.Show("No Employee Found");
                    
                }
                
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public int GetRoleID(string SelectedIem)
        {
            int id = 0;
            if (SelectedIem == "Teacher")
            {
                id = 14;
            }
            else if (SelectedIem == "Admin")
            {
                id = 15;
            }
            else if (SelectedIem == "Accountant")
            {
                id = 16;
            }
            else if (SelectedIem == "Principal")
            {
                id = 13;
            }
            else if (SelectedIem == "Others")
            {
                id = 17;
            }
            return id;
        }
        public void SearchById()
        {
            string name = "";
            string role = "";
            if (Role.selectedIndex == -1)
            {
                role = "";
            }
            else
            {
                role = GetRoleID(Role.selectedValue).ToString();
            }

            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SearchEmployeeUserId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@Email", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = EmployeeSearch.Text;
                cmd.Parameters.AddWithValue("@HiredAs", SqlDbType.Int).Value = role;
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        EmployeeName.Text = sdr["Name"].ToString();
                        id = Convert.ToInt32(sdr["Id"]);
                        pictureBox1.Image = v.ConvertByteToImage(sdr["Photo"] as byte[]);
                    }
                }
                else
                {
                    Role.selectedIndex = -1;
                    MessageBox.Show("No Employee Found");

                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public void SearchByEmail()
        {
            

            string name = "";
            
            string role = "";
            if (Role.selectedIndex == -1)
            {
                role = "";
            }
            else
            {
                role = GetRoleID(Role.selectedValue).ToString();
            }

            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SearchEmployeeUserId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@Email", SqlDbType.Int).Value = EmployeeSearch.Text;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@HiredAs", SqlDbType.Int).Value = role;
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        EmployeeName.Text = sdr["Name"].ToString();
                        id = Convert.ToInt32(sdr["Id"]);
                        pictureBox1.Image = v.ConvertByteToImage(sdr["Photo"] as byte[]);
                    }
                }
                else
                {
                    Role.selectedIndex = -1;
                    MessageBox.Show("No Employee Found");

                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public int GetAttendanceId(string status)
        {
            int aatId;
            if(status=="Present")
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
        public void SaveEmployeeAttendance()
        {
            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("MarkEmployeeAttendance", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@Date", SqlDbType.Int).Value = CurrentDate.Value;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = GetAttendanceId(Attendance1.selectedValue);
                cmd.ExecuteNonQuery();
                con.Close();
                RecentAttendanceInfoCardLayout raicl = new RecentAttendanceInfoCardLayout(id);
                raicl.Dock = DockStyle.Top;
                RecentAttendance.Controls.Add(raicl);
                MessageBox.Show("Attendance Marked Successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Attendance Already Marked!");
                Console.WriteLine("Can not open connection !");
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            RecentAttendance.Visible = true;
            bunifuCustomLabel7.Visible = true;
            SaveEmployeeAttendance();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchUsers();
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Reports r = new Reports(bunifuDatePicker1.Value);
            r.Show();
        }
    }
}
