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
    public partial class ManageNonTeachingStaff : UserControl
    {
        int initial_Count = 0;
        public ManageNonTeachingStaff()
        {
            InitializeComponent();
        }

        private void Manage_Non_Teaching_Staff_Load(object sender, EventArgs e)
        {
            Apply.Enabled = false;
            LoadEmployeeData("All");
            //initial_Count = Counter();
            DisplayEmployeeInfo.Visible = false;
        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (Counter() > initial_Count)
                LoadEmployeeData("All");
        }
        public string GetRoleId(string selectedrole)
        {
            string role = "";
            if (selectedrole == "Principal")
            {
                role = "13";
            }            
            else if (selectedrole == "Accountant")
            {
                role = "16";
            }
            else if (selectedrole == "Admin")
            {
                role = "15";
            }
            else if (selectedrole == "Others")
            {
                role = "17";
            }
            return role;
        }
        public void LoadEmployeeData(string Datafor)
        {
            DisplayEmployeeCards.Controls.Clear();
            String name = "";
            String email = "";
            String contact = "";
            string roleId = GetRoleId(Datafor);
            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("DisplayEmployeeData", con);                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SelectedItem", SqlDbType.Int).Value = roleId;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    name = sdr["Name"].ToString();
                    email = sdr["Email"].ToString();
                    contact = sdr["Contact"].ToString();
                    byte[] img = sdr["Photo"] as byte[];
                    EmployeeCardLayout ecl = new EmployeeCardLayout(name, email, contact,img);
                    DisplayEmployeeCards.Controls.Add(ecl);

                }
                con.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }

        }
        public int Counter()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            Console.WriteLine("Connection Open ! ");
            SqlCommand cmd1 = new SqlCommand("Select COUNT(*) From Student", con);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            sdr1.Read();
            int count = Convert.ToInt32(sdr1.GetValue(0));
            return count;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool search_clicked = false;
        public void NormalState()
        {
            DisplayEmployeeCards.Size = new Size(982, 380);
            DisplayEmployeeInfo.Visible = false;
            DisplayEmployeeCards.AutoScroll = true;
            DisplayEmployeeInfo.Size = new Size(14, 395);
            search_clicked = false;
            LoadEmployeeData("All");
        }
        public void SearchState()
        {
            search_clicked = true;
            DisplayEmployeeCards.Size = new Size(320, 381);
            DisplayEmployeeInfo.Visible = true;
            DisplayEmployeeCards.AutoScroll = false;
            DisplayEmployeeInfo.Size = new Size(664, 400);
        }
        private void Refresh_Click_1(object sender, EventArgs e)
        {
            if (initial_Count < Counter() || search_clicked == true)
            {
                TeacherSerchBox.Text = "Search By Emp.ID,Email,Contact";
                LoadEmployeeData("All");
                Filters.Text = "All";
                Apply.Enabled = false;
                initial_Count = Counter();
                search_clicked = false;
                NormalState();
            }
        }
        public void SearchEmployeeData()
        {
            if (TeacherSerchBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid search value !");
            }
            else
            {
                if (TeacherSerchBox.Text.Length == 10)
                {
                    SearchEmployeeByContact();

                }
                else if (TeacherSerchBox.Text.Contains("@"))
                {
                    SearchEmployeeByEmail();

                }
                else if (TeacherSerchBox.Text.Length < 10)
                {
                    SearchEmployeeById();

                }
                else
                {
                    MessageBox.Show("No Employee Found");
                    NormalState();
                }
            }
        }
        public void SearchEmployeeByContact()
        {
            SearchState();
            DisplayEmployeeCards.Controls.Clear();
            DisplayEmployeeInfo.Controls.Clear();
            string email = "";
            string name = "";
            string role = "";
            string contact = "";
            string gender = "";
            string postal = "";
            string salary = "";

            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SearchEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = Convert.ToInt32(TeacherSerchBox.Text);
                cmd.Parameters.AddWithValue("@Email", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = "";
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        email = sdr["Email"].ToString();
                        name = sdr["Name"].ToString();
                        role = sdr["Role"].ToString();
                        contact = sdr["Contact"].ToString();
                        gender = sdr["Gender"].ToString();
                        postal = sdr["Adress"].ToString();
                        salary = sdr["Salary"].ToString();
                        byte[] img = (byte[])sdr["Photo"];
                        EmployeeCardLayout tcl = new EmployeeCardLayout(name, email, contact,img);
                        DisplayEmployeeCards.Controls.Add(tcl);

                        ViewEmployeeDetails ved = new ViewEmployeeDetails(name, contact, salary, role, postal, gender, email);
                        DisplayEmployeeInfo.Controls.Add(ved);
                    }
                }
                else
                {
                    MessageBox.Show("No Employee Found");
                    NormalState();
                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public void SearchEmployeeByEmail()
        {
            SearchState();
            DisplayEmployeeCards.Controls.Clear();
            DisplayEmployeeInfo.Controls.Clear();
            string email = "";
            string name = "";
            string role = "";
            string contact = "";
            string gender = "";
            string postal = "";
            string salary = "";

            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SearchEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@Email", SqlDbType.Int).Value = TeacherSerchBox.Text;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = "";
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        email = sdr["Email"].ToString();
                        name = sdr["Name"].ToString();
                        role = sdr["Role"].ToString();
                        contact = sdr["Contact"].ToString();
                        gender = sdr["Gender"].ToString();
                        postal = sdr["Adress"].ToString();
                        salary = sdr["Salary"].ToString();
                        byte[] img = (byte[])sdr["Photo"];
                        EmployeeCardLayout tcl = new EmployeeCardLayout(name, email, contact,img);
                        DisplayEmployeeCards.Controls.Add(tcl);
                        ViewEmployeeDetails ved = new ViewEmployeeDetails(name, contact, salary, role, postal, gender, email);
                        DisplayEmployeeInfo.Controls.Add(ved);
                    }
                }
                else
                {
                    MessageBox.Show("No Employee Found");
                    NormalState();
                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public void SearchEmployeeById()
        {
            SearchState();
            DisplayEmployeeCards.Controls.Clear();
            DisplayEmployeeInfo.Controls.Clear();
            string email = "";
            string name = "";
            string role = "";
            string contact = "";
            string gender = "";
            string postal = "";
            string salary = "";

            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SearchEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@Email", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = TeacherSerchBox.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        email = sdr["Email"].ToString();
                        name = sdr["Name"].ToString();
                        role = sdr["Role"].ToString();
                        contact = sdr["Contact"].ToString();
                        gender = sdr["Gender"].ToString();
                        postal = sdr["Adress"].ToString();
                        salary = sdr["Salary"].ToString();
                        byte[] img = (byte[])sdr["Photo"];
                        EmployeeCardLayout tcl = new EmployeeCardLayout(name, email, contact,img);
                        DisplayEmployeeCards.Controls.Add(tcl);
                        ViewEmployeeDetails ved = new ViewEmployeeDetails(name, contact, salary, role, postal, gender, email);
                        DisplayEmployeeInfo.Controls.Add(ved);
                    }
                }
                else
                {
                    MessageBox.Show("No Employee Found");
                    NormalState();

                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }      
        
        private void TeacherSearch_Click(object sender, EventArgs e)
        {
            if (TeacherSerchBox.Text == "" ||TeacherSerchBox.Text== "Search By Emp.ID,Email,Contact")
            {
                MessageBox.Show("Please Enter a Value");
            }
            else
            {
                search_clicked = true;
                SearchEmployeeData();
            }
            
        }

        private void TeacherSerchBox_Enter(object sender, EventArgs e)
        {
            if (TeacherSerchBox.Text == "Search By Emp.ID,Email,Contact")
            {
                TeacherSerchBox.Text = "";
                TeacherSerchBox.ForeColor = Color.Black;
            }
        }

        private void TeacherSerchBox_Leave(object sender, EventArgs e)
        {
            if (TeacherSerchBox.Text == "")
            {
                TeacherSerchBox.Text = "Search By Emp.ID,Email,Contact";
                TeacherSerchBox.ForeColor = Color.Silver;
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (Filters.SelectedItem.ToString() == "All")
            {
                LoadEmployeeData("All");
                Apply.Enabled = false;
            }
            else if (Filters.SelectedItem.ToString() == "Admin")
            {
                LoadEmployeeData("Admin");
            }
            else if (Filters.SelectedItem.ToString() == "Principal")
            {
                LoadEmployeeData("Principal");
            }
            else if (Filters.SelectedItem.ToString() == "Accountant")
            {
                LoadEmployeeData("Accountant");
            }
            else if (Filters.SelectedItem.ToString() == "Others")
            {
                LoadEmployeeData("Others");
            }
        }

        private void Filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            Apply.Enabled = true;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Reports r = new Reports("","","",Select.selectedValue);
            r.Show();
        }
    }
}
