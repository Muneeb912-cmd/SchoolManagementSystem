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
    public partial class UnAssignedStudents : UserControl
    {
        public UnAssignedStudents(string name,string rollno)
        {
            InitializeComponent();
            populateUsAssignedStudents( name,  rollno);    
        }
        public void populateUsAssignedStudents(string name1, string rollno)
        {
            roll.Text = rollno;
            name.Text = name1;
        }
        public int GetStudentID()
        {
            int id = 0;
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select StudentId From Student Where RollNo='"+roll.Text+"'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["StudentId"]);
            }
            return id;
        }
        public int GetClassVarrantID()
        {
            int id = 9;
            if (varriant.selectedValue == "ComputerScience")
                id = 10;
            if (varriant.selectedValue == "Biology")
                id = 11;
            if (varriant.selectedValue == "Arts")
                id = 12;

            return id;
        }
        public int GetSectionID()
        {
            int id = 0;
            string section1 = section.selectedValue;
            string clsstitle1 = StudentClass.Text;
            string session1 = session.selectedValue;
            int varriant1 = GetClassVarrantID();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("GetSctionId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SectionTitle", SqlDbType.VarChar).Value = section1;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.VarChar).Value = clsstitle1;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session1;
            cmd.Parameters.AddWithValue("@Varriant", SqlDbType.Int).Value = varriant1;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            con.Close();
            return id;
        }
        public void AssignStudent()
        {
            int studentid = GetStudentID();
            int sectionid = GetSectionID();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("AssignStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;            
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = studentid;
            cmd.Parameters.AddWithValue("@Section", SqlDbType.Int).Value = sectionid;
            SqlDataReader dr = cmd.ExecuteReader();           
            con.Close();
            
        }
        private void Update_Click(object sender, EventArgs e)
        {                       
            AssignStudent();
            MessageBox.Show("Student Assigned Successfully");           
            this.Dispose();
        }

        private void StudentClass_TextChange(object sender, EventArgs e)
        {
            session.Clear();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Session From Class Where Title='" + StudentClass.Text + "' AND IsDeleted=0", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                session.AddItem(dr[0].ToString());
            }
        }

        private void session_onItemSelected(object sender, EventArgs e)
        {
            varriant.Clear();
            string classtitle =StudentClass.Text;
            string session1 = session.selectedValue;
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateVarriantDropDown", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.VarChar).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session1;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                varriant.AddItem(dr[0].ToString());
            }
        }

        private void varriant_onItemSelected(object sender, EventArgs e)
        {
            section.Clear();
            string classtitle = StudentClass.Text;
            string session1 =session.selectedValue;
            int varriant = GetClassVarrantID();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateSectionDropDown", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.VarChar).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session1;
            cmd.Parameters.AddWithValue("@Varraint", SqlDbType.Int).Value = varriant;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                section.AddItem(dr[0].ToString());
            }
        }

        private void UnAssignedStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
