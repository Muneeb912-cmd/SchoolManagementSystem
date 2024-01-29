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
    public partial class AddEmployee : Form
    {
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        public AddEmployee()
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            ID_Pass_Panel.Visible = false;
            PopulateEmployeeRoleDropDown();
            PopulateGenderBox();
        }

        private void Role_onItemSelected(object sender, EventArgs e)
        {
            if (Role.selectedValue == "Teacher"|| Role.selectedValue == "Principal"|| Role.selectedValue == "Accountant")
            {
                ID_Pass_Panel.Visible = true;
                Email.Text=GenerateEmail(FirstName.Text, LastName.Text,Role.selectedValue);
            }
            else
            {
                ID_Pass_Panel.Visible = false;
            }
        }
        public void PopulateEmployeeRoleDropDown() 
        {
            Role.Items.Clear();
            string query = "PopulateEmployeeRole";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())//while true
            {
                query = dr[0].ToString();
                Role.Items.Add(query);
            }
            dr.Close();
            con.Close();
        }
        public void PopulateGenderBox()
        {
            Gender.Items.Clear();
            string query = "PopulateGenderBox";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())//while true
            {
                query = dr[0].ToString();
                Gender.Items.Add(query);
            }
            dr.Close();
            con.Close();
        }
        public int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 1000);
        }
        public string GenerateEmail(string firstname, string lastname, string role)
        {
            int randomnumber = GenerateRandomNumber();
            if (role == "Teacher")
            {
                return firstname.ToLower() + lastname.ToLower() + randomnumber + "@teacher.brain.edu.com";
            }
            else if (role == "Admin")
            {
                return firstname.ToLower() + lastname.ToLower() + randomnumber + "@admin.brain.edu.com";
            }
            else if (role == "Accountant")
            {
                return firstname.ToLower() + lastname.ToLower() + randomnumber + "@accountant.brain.edu.com";
            }
            else if (role == "Principal")
            {
                return firstname.ToLower() + lastname.ToLower() + randomnumber + "@principal.brain.edu.com";
            }
            return "";
        }

        Validators v = new Validators();
        private void Save_Click(object sender, EventArgs e)
        {
            if (Role.selectedValue == "Others")
            {
                if (FirstName.Text != "" && v.ValidateName(FirstName.Text))
                {
                    if (LastName.Text != "" && v.ValidateName(LastName.Text))
                    {
                        if (Contact.Text != "" && v.ValidatePhone(Convert.ToInt32(Contact.Text)))
                        {
                            if (Gender.selectedIndex != -1)
                            {
                                if (Role.selectedIndex != -1)
                                {
                                    if (v.ValidateBirthDate(DateOFBirth.Value))
                                    {
                                        if (EmployeeSalary.Text != "")
                                        {
                                            if (MessageBox.Show("Are you sure you want to Save Changes?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                            {
                                                AddNonTeachingStaff();
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Employee Salary Feild Cannot be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }                                           
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid Date of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please select a role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Feild Gender cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Contact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (FirstName.Text != "" && v.ValidateName(FirstName.Text))
                {
                    if (LastName.Text != "" && v.ValidateName(LastName.Text))
                    {
                        if (Contact.Text != "" && v.ValidatePhone(Convert.ToInt32(Contact.Text)))
                        {
                            if (Gender.selectedIndex != -1)
                            {
                                if (Role.selectedIndex != -1)
                                {
                                    if (v.ValidateBirthDate(DateOFBirth.Value))
                                    {
                                        if(Password.Text!=""&& ConfirmPassword.Text != "")
                                        {
                                            if (Password.Text == ConfirmPassword.Text)
                                            {
                                                if (EmployeeSalary.Text != "")
                                                {
                                                    AddTeachingStaff();
                                                    this.Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Employee Salary Feild Cannot be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Password and Confirm Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Password and Confirm Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid Date of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please select a role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Feild Gender cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Contact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int GetGenderID(string SelectedItem)
        {
            int id = 0;
            if (SelectedItem == "Male")
                id = 7;
            else
                id = 8;
            return id;
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
        public void AddTeachingStaff()
        {
            Validators v = new Validators();
            string fname = FirstName.Text;
            string lname = LastName.Text;
            int role = GetRoleID(Role.selectedValue);
            string contact = Contact.Text;
            string postaladress = PostalAdress.Text;
            DateTime dob = DateOFBirth.Value;
            int gender = GetGenderID(Gender.selectedValue.ToString());
            int salary = Convert.ToInt32(EmployeeSalary.Text);
            string email = Email.Text;
            string password = ConfirmPassword.Text;
            //MessageBox.Show("Saving Data Please Wait");
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("SaveEmployeeData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = contact;
            cmd.Parameters.AddWithValue("@Gender", SqlDbType.Int).Value = gender;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.DateTime).Value = dob;
            cmd.Parameters.AddWithValue("@PostalAdress", SqlDbType.VarChar).Value = postaladress;
            cmd.Parameters.AddWithValue("@Role", SqlDbType.VarChar).Value = role;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = password;
            cmd.Parameters.AddWithValue("@Salary", SqlDbType.Int).Value = salary;
            cmd.Parameters.AddWithValue("@Photo", SqlDbType.Image).Value = v.ConvertImageTobyte(pictureBox1.Image);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully saved");
        }
        public void AddNonTeachingStaff()
        {
            string fname = FirstName.Text;
            string lname = LastName.Text;
            int role = GetRoleID(Role.selectedValue);
            string contact = Contact.Text;
            string postaladress = PostalAdress.Text;
            DateTime dob = DateOFBirth.Value;
            int gender = GetGenderID(Gender.selectedValue.ToString());
            int salary = Convert.ToInt32(EmployeeSalary.Text);
            string email = "";
            string password = "";
            //MessageBox.Show("Saving Data Please Wait");
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("SaveEmployeeData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = contact;
            cmd.Parameters.AddWithValue("@Gender", SqlDbType.Int).Value = gender;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.DateTime).Value = dob;
            cmd.Parameters.AddWithValue("@PostalAdress", SqlDbType.VarChar).Value = postaladress;
            cmd.Parameters.AddWithValue("@Role", SqlDbType.VarChar).Value = role;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = password;
            cmd.Parameters.AddWithValue("@Salary", SqlDbType.Int).Value = salary;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully saved");
        }
    }
}
