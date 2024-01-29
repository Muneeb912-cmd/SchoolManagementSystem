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
    public partial class UpdateEmployee : Form
    {
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        string email1 = "";
        string contact1 = "";
        public UpdateEmployee(string name,string email,string contact ,string isnonteachingstaff)
        {
            
            InitializeComponent();
            contact1 = contact;
            if (isnonteachingstaff == "no")
            {
                bunifuCustomLabel4.Visible = true;
                Add_Info(name, email, contact);
                if (email == "")
                {
                    Email.Visible = false;
                    bunifuCustomLabel4.Visible = false;
                }
                else
                    email1 = email;
            }
            else
            {
                Email.Visible = false;
                bunifuCustomLabel4.Visible = false;
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

        private void Cancel1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
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
        public void Add_Info(string name, string email, string contact)
        {
            string label = bunifuLabel1.Text;
            string label2 = label + " " + name;
            bunifuLabel1.Text = label2;
            Populate_Employee_Data(name,email, contact);
        }
        public void Populate_Employee_Data(string name,string email, string contact)
        {
            Validators v = new Validators();
            string phrase = name;
            string[] words = phrase.Split(' ');
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateEmployeeUpdateForm", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = words[0];
            cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = words[1];            
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.AddWithValue("@Contact", SqlDbType.VarChar).Value = contact;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                FirstName.Text = reader["FirstName"].ToString();
                LastName.Text = reader["LastName"].ToString();
                Contact.Text = reader["Contact"].ToString();
                DateOFBirth.Value = Convert.ToDateTime(reader["DOB"]);
                if (reader["Gender"].ToString() == "7")
                {
                    Gender.selectedIndex = 0;
                }else
                    Gender.selectedIndex = 1;
                PostalAdress.Text = reader["PostalAdress"].ToString();
                Email.Text = reader["Email"].ToString();
                pictureBox1.Image = v.ConvertByteToImage(reader["Photo"] as byte[]);
            }
            con.Close();
        }

        public void UpdateEmployeeData()
        {
            Validators v = new Validators();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateEmployeeData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OldContact", SqlDbType.Int).Value = contact1;
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = FirstName.Text;
            cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = LastName.Text;
            cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = Contact.Text;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.VarChar).Value = DateOFBirth.Value;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email1;
            cmd.Parameters.AddWithValue("@Gender", SqlDbType.Int).Value = GetGenderID(Gender.selectedValue);
            cmd.Parameters.AddWithValue("@PostalAdress", SqlDbType.VarChar).Value = PostalAdress.Text;
            cmd.Parameters.AddWithValue("@Photo", SqlDbType.Image).Value = v.ConvertImageTobyte(pictureBox1.Image);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfull!");
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
        Validators v = new Validators();
        private void Save_Click(object sender, EventArgs e)
        {
            
                if (FirstName.Text != "" && v.ValidateName(FirstName.Text))
                {
                    if (LastName.Text != "" && v.ValidateName(LastName.Text))
                    {
                        if (Contact.Text != "" && v.ValidatePhone(Convert.ToInt32(Contact.Text)))
                        {
                        if (Gender.selectedIndex != -1)
                        {
                            if (v.ValidateBirthDate(DateOFBirth.Value))
                            {
                                if (MessageBox.Show("Are you sure you want to Save Changes?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    UpdateEmployeeData();
                                    //ManageNonTeachingStaff.FromChildHandle();                                    
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Date of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        public int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 1000);
        }
        public string GenerateEmail(string firstname, string lastname)
        {
            return firstname.ToLower() + lastname.ToLower() + GenerateRandomNumber() + "@teacher.brain.edu.com";            
        }
        private void FirstName_OnValueChanged(object sender, EventArgs e)
        {
            Email.Text=GenerateEmail( FirstName.Text,  LastName.Text);
        }

        private void LastName_OnValueChanged(object sender, EventArgs e)
        {
            Email.Text = GenerateEmail(FirstName.Text, LastName.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            Email.Visible = false;
            bunifuCustomLabel4.Visible = false;
        }
    }
}
