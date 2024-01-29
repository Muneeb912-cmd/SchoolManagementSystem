using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.AdminForms
{
    public partial class AddStudent : Form
    {
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public AddStudent()
        {
            InitializeComponent();
        }

        private void Cancel1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                PicturePath.Text = open.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                PicturePath.Text = open.FileName;
            }
        }

        private void AddStudent_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            PopulateGenderDropBox();
            GenerateStudentRollNo();
        }

        public void PopulateGenderDropBox()
        {
            Gender.Items.Clear();
            string query = "Exec PopulateGenderBox";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())//while true
            {
                query = dr[0].ToString();
                Gender.Items.Add(query);
            }
            dr.Close();
            con.Close();
        }

        public int GetGenderID(string SelectedItem)
        {
            int id=0;
            if (SelectedItem == "Male")
                id = 7;
            else
                id = 8;
            return id;
        }
        public int GetClassVarrantID()
        {
            int id = 9;
            if (Varriant.selectedValue == "ComputerScience")
                id = 10;
            if (Varriant.selectedValue == "Biology")
                id = 11;
            if (Varriant.selectedValue == "Arts")
                id = 12;

            return id;
        }
        public int GetSectionID()
        {
            int id = 0;
            string section= Section.selectedValue;
            string classtitle = StudentClass.Text;
            string session = Session.selectedValue;
            int varriant = GetClassVarrantID();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("GetSctionId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SectionTitle", SqlDbType.VarChar).Value = section;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.VarChar).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session;
            cmd.Parameters.AddWithValue("@Varriant", SqlDbType.Int).Value = varriant;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }   
            con.Close();
            return id;
        }
        Validators vv = new Validators();
        public void SaveStudentData()
        {
            
            string fname = FirstName.Text;
            string lname = LastName.Text;
            int registration = int.Parse(Registration.Text);
            int contact = int.Parse(Contact.Text);          
            int section = GetSectionID();           
            string postaladress = PostalAdress.Text;
            DateTime dob = DateOfBirth.Value;
            int gender = GetGenderID(Gender.selectedValue.ToString());
            
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("SaveStudentData", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value=fname;
            cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value=lname;
            cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = contact;
            cmd.Parameters.AddWithValue("@Gender", SqlDbType.Int).Value=gender;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.DateTime).Value=dob;
            cmd.Parameters.AddWithValue("@PostalAdress", SqlDbType.VarChar).Value=postaladress;
            cmd.Parameters.AddWithValue("@Registration", SqlDbType.VarChar).Value = registration;            
            cmd.Parameters.AddWithValue("@Section", SqlDbType.Int).Value = section;
            cmd.Parameters.AddWithValue("@Image", SqlDbType.Image).Value = vv.ConvertImageTobyte(pictureBox1.Image);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully saved");
        }
        
        public bool checkRegistration()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select RollNo From Student", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Registration.Text == dr[0].ToString())
                {
                    MessageBox.Show("Registration Number already exists");
                    return false;
                }
            }
            return true;
        }
        Validators v = new Validators();
        private void Save_Click(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && v.ValidateName(FirstName.Text))
            {
                if (LastName.Text != "" && v.ValidateName(LastName.Text))
                {
                    if (Contact.Text != "")
                    {
                        if (Gender.selectedIndex != -1)
                        {

                            if (checkRegistration())
                            {
                                if (MessageBox.Show("Are you sure you want to Save Changes?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    SaveStudentData();
                                    this.Close();
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please Select a gender!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input Feild Empty!");
                    }
                }
                else
                {
                    MessageBox.Show("Input Feild Empty!");
                }
            }
            else
            {
                MessageBox.Show("Input Feild Empty!");
            }
        
            
            
            //SaveStudentData();                        
        }
        public void GenerateStudentRollNo()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select MAX(RollNo) From Student", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == "")
                {
                    Registration.Text = "1";
                }
                else
                {
                    int reg = int.Parse(dr[0].ToString());
                    reg++;
                    Registration.Text = reg.ToString();
                }
            }
        }

        private void DateOfBirth_onValueChanged(object sender, EventArgs e)
        {
            DateTime dob = DateOfBirth.Value;
            int age = DateTime.Now.Year - dob.Year;            
            if(age==3)
                StudentClass.Text = "Nursery";
            if (age == 4)
                StudentClass.Text = "Kindergarden 1";
            if (age == 5)
                StudentClass.Text = "Kindergarden 2";
            if(age==6)
                StudentClass.Text = "1";
            if (age == 7)
                StudentClass.Text = "2";
            if (age == 8)
                StudentClass.Text = "3";
            if (age == 9)
                StudentClass.Text = "4";
            if (age == 10)
                StudentClass.Text = "5";
            if (age == 11)
                StudentClass.Text = "6";
            if (age == 12)
                StudentClass.Text = "7";
            if (age == 13)
                StudentClass.Text = "8";
            if (age == 14)
                StudentClass.Text = "9";
            if (age == 15)
                StudentClass.Text = "10";            
        }

        private void StudentClass_OnValueChanged(object sender, EventArgs e)
        {
            Session.Clear();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Distinct Session From Class Where Title='"+StudentClass.Text+"'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Session.AddItem(dr[0].ToString());
            }
        }

        private void Session_onItemSelected(object sender, EventArgs e)
        {
            
            Varriant.Clear();
            string classtitle = StudentClass.Text;
            string session = Session.selectedValue;
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateVarriantDropDown", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.VarChar).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Varriant.AddItem(dr[0].ToString());
            }
        }

        private void Varriant_onItemSelected(object sender, EventArgs e)
        {
            Section.Clear();
            string classtitle = StudentClass.Text;
            string session = Session.selectedValue;
            int varriant = GetClassVarrantID();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateSectionDropDown", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.VarChar).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session;
            cmd.Parameters.AddWithValue("@Varraint", SqlDbType.Int).Value = varriant;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Section.AddItem(dr[0].ToString());
            }
        }
    }
}
