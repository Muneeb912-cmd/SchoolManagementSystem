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
    public partial class ManageTeacher : UserControl
    {
        int initial_Count = 0;
        public ManageTeacher()
        {
            InitializeComponent();
        }
        bool search_clicked = false;
        private void bunifuCustomTextbox1_Enter(object sender, EventArgs e)
        {
            if(TeacherSerchBox.Text== "Search By Email,ID,Contact")
            {
                TeacherSerchBox.Text = "";
            }            
        }

        private void TeacherSerchBox_Leave(object sender, EventArgs e)
        {
            if (TeacherSerchBox.Text == "")
            {
                TeacherSerchBox.Text = "Search By Email,ID,Contact";
            }
        }

        private void Add_Teacher_Click(object sender, EventArgs e)
        {           
            AddEmployee ae = new AddEmployee();
            ae.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
                       
        }

        public void LoadTeacherData()
        {
            DisplayTeacherCards.Controls.Clear();
            String name = "";
            String email = "";
            String contact = "";
            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("DisplayTeachingStaffData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();               
                ////Retrieve data from table and Display result
                while (sdr.Read())
                {
                    name = sdr["Name"].ToString();
                    email = sdr["Email"].ToString();
                    contact = sdr["Contact"].ToString();
                    byte[] bytes = (byte[])sdr["Photo"];
                    EmployeeCardLayout tcl = new EmployeeCardLayout(name, email, contact,bytes);
                    DisplayTeacherCards.Controls.Add(tcl);

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
            SqlCommand cmd1 = new SqlCommand("Select COUNT(*) From Employee where Role=14 AND IsDeleted=0", con);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            sdr1.Read();
            int count = Convert.ToInt32(sdr1.GetValue(0));
            return count;
        }
        private void ManageTeacher_Load(object sender, EventArgs e)
        {            
            LoadTeacherData();
            initial_Count = Counter();
            DisplayTeacherInfo.Visible = false;
        }
        public void NormalState()
        {
            DisplayTeacherCards.Size = new Size(982, 380);
            DisplayTeacherInfo.Visible = false;
            DisplayTeacherCards.AutoScroll = true;
            DisplayTeacherInfo.Size = new Size(14, 395);
            search_clicked = false;
            LoadTeacherData();
        }
        public void SearchState()
        {
            search_clicked = true;
            DisplayTeacherCards.Size = new Size(325, 384);
            DisplayTeacherInfo.Visible = true;
            DisplayTeacherCards.AutoScroll = false;
            DisplayTeacherInfo.Size = new Size(664, 400);
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            if (initial_Count < Counter()||search_clicked==true)
            {
                LoadTeacherData();
                initial_Count = Counter();
                NormalState();
            }
        }
        public void SearchTeacherData()
        {
            if (TeacherSerchBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid search value !");
            }
            else
            {
                if (TeacherSerchBox.Text.Length == 10)
                {
                    SearchTeacherByContact();
                    
                }
                else if(TeacherSerchBox.Text.Contains("@"))
                {
                    SearchTeacherByEmail();
                    
                }
                else if(TeacherSerchBox.Text.Length < 10)
                {
                    SearchTeacherById();
                    
                }
                else
                {
                    MessageBox.Show("No Teacher Found");
                    NormalState();
                }
            }


        }
        public void SearchTeacherByContact()
        {
            SearchState();
            DisplayTeacherCards.Controls.Clear();
            DisplayTeacherInfo.Controls.Clear();
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
                SqlCommand cmd = new SqlCommand("SearchTeacher", con);
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
                        byte[] img = sdr["Photo"] as byte[];
                        EmployeeCardLayout tcl = new EmployeeCardLayout(name, email, contact,img);
                        DisplayTeacherCards.Controls.Add(tcl);
                        ViewEmployeeDetails ved = new ViewEmployeeDetails(name, contact, salary, role, postal, gender, email);
                        DisplayTeacherInfo.Controls.Add(ved);
                    }
                }
                else
                {
                    MessageBox.Show("No Teacher Found");
                    NormalState();
                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public void SearchTeacherByEmail()
        {
            SearchState();
            DisplayTeacherCards.Controls.Clear();
            DisplayTeacherInfo.Controls.Clear();
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
                SqlCommand cmd = new SqlCommand("SearchTeacher", con);
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
                        DisplayTeacherCards.Controls.Add(tcl);
                        ViewEmployeeDetails ved = new ViewEmployeeDetails(name, contact, salary, role, postal, gender, email);
                        DisplayTeacherInfo.Controls.Add(ved);
                    }
                }
                else
                {
                    MessageBox.Show("No Teacher Found");
                    NormalState();
                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public void SearchTeacherById()
        {
            SearchState();
            DisplayTeacherCards.Controls.Clear();
            DisplayTeacherInfo.Controls.Clear();
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
                SqlCommand cmd = new SqlCommand("SearchTeacher", con);
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
                        DisplayTeacherCards.Controls.Add(tcl);
                        ViewEmployeeDetails ved = new ViewEmployeeDetails(name, contact, salary, role, postal, gender, email);
                        DisplayTeacherInfo.Controls.Add(ved);
                    }
                }
                else
                {
                    MessageBox.Show("No Teacher Found");
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
            if (TeacherSerchBox.Text == ""||TeacherSerchBox.Text== "Search By Email,ID,Contact")
            {
                MessageBox.Show("Please Enter a Value");
            }
            else
            {
                SearchTeacherData();
            }
            
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            Reports r = new Reports("","","","Teacher");
            r.Show();
        }
    }
}
