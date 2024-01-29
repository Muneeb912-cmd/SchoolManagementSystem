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
    public partial class ManageUserAccounts : UserControl
    {
        public ManageUserAccounts()
        {
            InitializeComponent();
        }
        public void SearchBy()
        {
            if (SearchBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid search value !");
            }
            else
            {
                if (SearchBox.Text.Length == 10)
                {
                    SearchByContact();

                }
                else if (SearchBox.Text.Contains("@"))
                {
                    SearchByEmail();

                }
                else if (SearchBox.Text.Length < 10)
                {
                    SearchById();

                }
                else
                {
                    MessageBox.Show("No Teacher Found");
                    //NormalState();
                }
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
        public void SearchByContact()
        {
            SearchResultPanel.Controls.Clear();
            
            string name = "";
            string hiredas = "";
            string email = "";
            string contact = "";
            string password = "";
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
                cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = Convert.ToInt32(SearchBox.Text);
                cmd.Parameters.AddWithValue("@Email", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@HiredAs", SqlDbType.Int).Value = role;
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        email = sdr["Email"].ToString();
                        name = sdr["Name"].ToString();
                        hiredas = sdr["HiredAs"].ToString();
                        contact = sdr["Contact"].ToString();
                        password = sdr["Password"].ToString();
                        byte[] img = (byte[])sdr["Photo"];
                        UserAccountInfoCardLayout uaicl = new UserAccountInfoCardLayout(name,email,hiredas,contact,password,img);
                        SearchResultPanel.Controls.Add(uaicl);
                    }
                }
                else
                {
                    MessageBox.Show("No Employee Found");
                    
                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public void SearchById()
        {
            SearchResultPanel.Controls.Clear();

            string name = "";
            string hiredas = "";
            string email = "";
            string contact = "";
            string password = "";
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
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = SearchBox.Text;
                cmd.Parameters.AddWithValue("@HiredAs", SqlDbType.Int).Value = role;
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        email = sdr["Email"].ToString();
                        name = sdr["Name"].ToString();
                        hiredas = sdr["HiredAs"].ToString();
                        contact = sdr["Contact"].ToString();
                        password = sdr["Password"].ToString();
                        byte[] img = (byte[])sdr["Photo"];
                        UserAccountInfoCardLayout uaicl = new UserAccountInfoCardLayout(name, email, hiredas, contact, password,img);
                        SearchResultPanel.Controls.Add(uaicl);
                    }
                }
                else
                {
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
            SearchResultPanel.Controls.Clear();

            string name = "";
            string hiredas = "";
            string email = "";
            string contact = "";
            string password = "";
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
                cmd.Parameters.AddWithValue("@Email", SqlDbType.Int).Value =SearchBox.Text;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = "";
                cmd.Parameters.AddWithValue("@HiredAs", SqlDbType.Int).Value = role;
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        email = sdr["Email"].ToString();
                        name = sdr["Name"].ToString();
                        hiredas = sdr["HiredAs"].ToString();
                        contact = sdr["Contact"].ToString();
                        password = sdr["Password"].ToString();
                        byte[] img = sdr["Photo"] as byte[];
                        UserAccountInfoCardLayout uaicl = new UserAccountInfoCardLayout(name, email, hiredas, contact, password,img);
                        SearchResultPanel.Controls.Add(uaicl);
                    }
                }
                else
                {
                    MessageBox.Show("No Employee Found");

                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }        

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                MessageBox.Show("Please enter a search term");
            }
            else
            {
                SearchBy();
                SearchBox.Clear();
            }
            
        }
    }
}
