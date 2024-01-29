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
    public partial class EmployeeCardLayout : UserControl
    {
        string name1 = "";
        public EmployeeCardLayout(string name,string email,string contact,byte[] bytes)
        {
            InitializeComponent();
            AddEmployeeInfo(name,email,contact,bytes);
            name1 = name;
        }
        public void AddEmployeeInfo(string name, string email, string contact,byte[]bytes)
        {
            Validators v = new Validators();
            Ename.Text = name;
            Email.Text = email;
            Contact.Text = contact;
            pictureBox1.Image = v.ConvertByteToImage(bytes);
        }
        private void EmployeeCardLayout_Load(object sender, EventArgs e)
        {

        }
        public int GetEmpId()
        {
            string phrase = name1;
            string[] words = phrase.Split(' ');
            int id = 0;
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("GetEmployeeId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = words[0];
            cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = words[1];
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = Email.Text;
            cmd.Parameters.AddWithValue("@Contact", SqlDbType.VarChar).Value = Contact.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader[0]);
            }
            con.Close();
            return id;
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("Are you sure you want to delete this teacher?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var con1 = SQL_Configuration.getInstance().getConnection();
                    con1.Close();
                    con1.Open();
                    SqlCommand cmd = new SqlCommand("DeleteEmployeeData", con1);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpId", SqlDbType.VarChar).Value = GetEmpId();
                    con1.Open();
                    cmd.ExecuteNonQuery();
                    con1.Close();
                    MessageBox.Show("Successfully Deleted Employee Data");
                    this.Dispose();
                }
                
            
        }

        public int GetEmployeeRole()
        {
            int id =0;
            string query = "Select Role from Employee where UserId = '" + Email.Text + "'";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())//while true
            {
                id = Convert.ToInt32(dr["Role"]);
            }
            dr.Close();
            con.Close();
            return id;
        }
        
        private void Edit_Delete_Click(object sender, EventArgs e)
        {
            //this.Parent.Parent.Enabled = false;
            string name = Ename.Text;
            string email = Email.Text;
            string contact = Contact.Text;
            string isnonteachingstaff = "";
            if (GetEmployeeRole() == 17)
                isnonteachingstaff = "yes";
            else
                isnonteachingstaff = "no";
            UpdateEmployee eut = new UpdateEmployee(name, email, contact,isnonteachingstaff);
            eut.Show();
        }
    }
}
