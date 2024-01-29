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
    public partial class StudentInfoCardLayout : UserControl
    {
        public StudentInfoCardLayout(string registration, string name, string contact, string age, string gender)
        {
            InitializeComponent();
            AddStudentInfo(registration, name, contact, age, gender);

        }
        
        public void AddStudentInfo(string registration,string name,string contact,string age,string gender)
        {
            Validators v = new Validators();
            Registration.Text = registration;
            Name1.Text = name;
            Contact.Text =contact;
            Age.Text = age+" yrs.";
            if (gender == "7")
            {
                Gender.Text = "Male";
            }
            else
            {
                Gender.Text = "Fe Male";
            }        

        }
        
        public void DeleteStudentData()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteStudentData", con);
            cmd.CommandType = CommandType.StoredProcedure;            
            cmd.Parameters.AddWithValue("@Registration", SqlDbType.VarChar).Value = Registration.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted Student Data");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {               
                DeleteStudentData();
                this.Dispose();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           
            string name = Name1.Text;
            string registration = Registration.Text;
            string contact = Contact.Text;
            UpdateStudent us = new UpdateStudent(name,registration, contact);            
            us.Show();
        }

        private void StudentInfoCardLayout_Load(object sender, EventArgs e)
        {

        }
    }
}
