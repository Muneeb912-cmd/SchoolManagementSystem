using SchoolManagementSystem.AdminForms;
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

namespace SchoolManagementSystem.TeacherForms
{
    public partial class Class_Attendance : Form
    {
        public Class_Attendance()
        {
            InitializeComponent();
        }

        private void loadAttendance_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            session.Clear();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Session From Class Where Title='" + StudentClass.Text + "'", con);
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
            int classtitle = Convert.ToInt32(StudentClass.Text);
            int session1 = Convert.ToInt32(session.selectedValue);
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateVarriantDropDown", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.Int).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = session1;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                varriant.AddItem(dr[0].ToString());
            }
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
        private void varriant_onItemSelected(object sender, EventArgs e)
        {
            section.Clear();
            int classtitle = Convert.ToInt32(StudentClass.Text);
            int session1 = Convert.ToInt32(session.selectedValue);
            int varriant = GetClassVarrantID();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateSectionDropDown", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.Int).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = session1;
            cmd.Parameters.AddWithValue("@Varraint", SqlDbType.Int).Value = varriant;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                section.AddItem(dr[0].ToString());
            }
        }
        public void loadSlectedClassStudent()
        {
            DisplayStudents.Controls.Clear();
            string stdclass = StudentClass.Text;
            string session1 = session.selectedValue;
            string varriant = GetClassVarrantID().ToString();
            string section1 = section.selectedValue;

            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("DisplayStudentsWithClassAndSection", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Class", SqlDbType.Int).Value = stdclass;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = session1;
            cmd.Parameters.AddWithValue("@Varriant", SqlDbType.Int).Value = varriant;
            cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = section1;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                StudentAttendance sa = new StudentAttendance(dr["Name"].ToString(), dr["RollNo"].ToString());
                DisplayStudents.Controls.Add(sa);
            }

            con.Close();


        }

        private void section_onItemSelected(object sender, EventArgs e)
        {
            loadSlectedClassStudent();
            Save.Visible = true;
        }

        private void Class_Attendance_Load(object sender, EventArgs e)
        {
            Save.Visible = false;
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            DisplayStudents.Controls.Clear();
            LoadingScreen ls = new LoadingScreen();
            DisplayStudents.Controls.Add(ls);
            await Task.Delay(5000);
            DisplayStudents.Controls.Clear();
            MessageBox.Show("Attendance Saved");
        }
    }
}
