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
    public partial class AdminProfile : UserControl
    {
        public AdminProfile(string email)
        {
            InitializeComponent();
            LoadLoggedInAdminInfo(email);
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
        public int GetGenderID(string gender)
        {
            if (gender == "Male")
                return 7;
            else
                return 8;
        }
        public string GetGender(string id)
        {
            string gender = "";
            if (id == "7")
                gender = "Male";
            else
                gender = "Fe Male";

            return gender;
        }
        public void setGender(string id)        {
           
            if (id == "7")
                Gender.selectedIndex=0;
            else
                Gender.selectedIndex = 1;            
        }
        public void LoadLoggedInAdminInfo(string email)   
        {
            Validators v = new Validators();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("LoadLoggedInAdminInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;           
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name.Text = reader["Name"].ToString();
                email1.Text = reader["Email"].ToString();
                contact.Text = reader["Contact"].ToString();
                dob.Text = reader["DOB"].ToString();
                gender1.Text= GetGender(reader["Gender"].ToString());
                role.Text = GetRole(reader["Role"].ToString());
                pictureBox1.Image = v.ConvertByteToImage(reader["Photo"] as byte[]);
            }
            con.Close();
        }
        byte[] oldimg;
        private void AdminProfile_Load(object sender, EventArgs e)
        {
            //Validators v = new Validators();
            //oldimg = v.ConvertImageTobyte(pictureBox1.Image);
            PopulationCountDisplay();
            panel2.Visible = false;
            panel3.Visible = false;
            SaveChanges.Visible = false;
            DiscardChanges.Visible = false;
        }
        public void PopulationCountDisplay()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulationCount", con);
            cmd.CommandType = CommandType.StoredProcedure;            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                totalstudents.Text =  reader["TotalStudents"].ToString();
                totalprincipals.Text = reader["TotalPrincipals"].ToString();
                totalteachers.Text = reader["TotalTeachers"].ToString();
                totalnonteachers.Text = reader["TotalNonTeachingStaff"].ToString();

            }
            con.Close();
        }
        private void AdminDash_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 0;
            panel1.Visible = true;
            panel3.Visible = false;
            
        }

        private void AdminAccountSetting_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 1;
            panel3.Visible = true;
        }

        private void AdminDash2_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 0;
            panel1.Visible = true;
        }

        private void bunifuCustomLabel22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            SaveChanges.Visible = true;
            DiscardChanges.Visible = true;
            PopulateAdminEdit();
        }

        private void DisvcardChanges_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SaveChanges.Visible = false;
            DiscardChanges.Visible = false;
        }

        private void AccountSettings_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Pages.PageIndex = 1;
            panel3.Visible = true;
        }
        //public void UpdateUserAccount()
        //{
        //    var con = SQL_Configuration.getInstance().getConnection();
        //    con.Close();
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("UpdatePassword", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = Email.Text;
        //    cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = Password.Text;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    //MessageBox.Show("Password Updated Successfully");
        //}
        
        public void PopulateAdminEdit()
        {
            edit_email.Text = email1.Text;
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateEditProfile", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email1.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                firstname.Text = reader["firstname"].ToString();
                lastname.Text = reader["lastname"].ToString();
                edit_contact.Text = reader["Contact"].ToString();
                dateob.Value = Convert.ToDateTime(reader["DOB"]);
                setGender(reader["Gender"].ToString());
                edit_password.Text = reader["Password"].ToString();
                adress.Text = reader["Adress"].ToString();
            }

        }
        public void SaveProfileChanges()
        {
            Validators v = new Validators();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateEmployeeProfile", con);
            SqlCommand cmd1 = new SqlCommand("UpdatePassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email1.Text;
            cmd1.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = edit_password.Text;
            cmd.Parameters.AddWithValue("@OldContact", SqlDbType.Int).Value = "";
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = firstname.Text;
            cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = lastname.Text;
            cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = edit_contact.Text;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.VarChar).Value = dateob.Value;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email1.Text;
            cmd.Parameters.AddWithValue("@Gender", SqlDbType.Int).Value = GetGenderID(Gender.selectedValue);
            cmd.Parameters.AddWithValue("@PostalAdress", SqlDbType.VarChar).Value = adress.Text;           
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfull!");
            LoadLoggedInAdminInfo(email1.Text);
            
        }
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            SaveProfileChanges();
            //PopulateAdminEdit();
            panel2.Visible = false;
            SaveChanges.Visible = false;
            DiscardChanges.Visible = false;
        }
        public bool browseImage()
        {            
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                //PicturePath.Text = open.FileName;
                return true;
            }           
            return false;
        }
        public void updatePic()
        {
            Validators v = new Validators();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateProfilePhoto", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email1.Text;
            cmd.Parameters.AddWithValue("@Photo", SqlDbType.Image).Value = v.ConvertImageTobyte(pictureBox1.Image);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            
            if (browseImage())
            {                
                if (MessageBox.Show("Are you sure you want to Save Changes?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    updatePic();
                    MessageBox.Show("Changes Saved Successfully!");
                }
                //else
                //{
                //    Validators v = new Validators();
                //    pictureBox1.Image = v.ConvertByteToImage(oldimg);
                //}
            }
        }
    }
}
