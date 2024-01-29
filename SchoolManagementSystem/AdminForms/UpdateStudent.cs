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
    public partial class UpdateStudent : Form
    {

        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;
        int stdreg = 0;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();        
        public UpdateStudent(string name,string registration,string contact)
        {
           
            InitializeComponent();
            PoupulateStudentInfo(name,registration, contact);
            stdreg = Int32.Parse(registration);


        }
        public void PoupulateStudentInfo(string name,string registration, string contact) 
        {
            Validators v = new Validators();
            bunifuLabel1.Text +=" "+name;
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateStudentUpdateForm", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Registration", SqlDbType.VarChar).Value = registration;
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
                }
                else
                    Gender.selectedIndex = 1;
                PostalAdress.Text=reader["PostalAdress"].ToString();
                pictureBox1.Image = v.ConvertByteToImage((byte[])reader["Photo"]);
            }                    
            con.Close();            
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Validators v = new Validators();
        public int GetGenderID(string SelectedItem)
        {
            int id = 0;
            if (SelectedItem == "Male")
                id = 7;
            else
                id = 8;
            return id;
        }
        public void UpdateStudentData()
        {
            Validators v = new Validators();
            int gender = GetGenderID(Gender.selectedValue);
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateStudentData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Registration", SqlDbType.Int).Value = stdreg;
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = FirstName.Text;
            cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = LastName.Text;
            cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = Contact.Text;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.DateTime).Value = DateOFBirth.Value;
            cmd.Parameters.AddWithValue("@Gender", SqlDbType.Int).Value = gender;
            cmd.Parameters.AddWithValue("@PostalAdress", SqlDbType.VarChar).Value = PostalAdress.Text;
            cmd.Parameters.AddWithValue("@Photo", SqlDbType.Image).Value = v.ConvertImageTobyte(pictureBox1.Image);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Update Successfull!");
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (FirstName.Text != "" && v.ValidateName(FirstName.Text))
            {
                if (LastName.Text != "" && v.ValidateName(LastName.Text))
                {
                    if (Contact.Text != "")
                    {
                       if (Gender.selectedIndex!=-1)
                       {
                            if (MessageBox.Show("Are you sure you want to Save Changes?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                UpdateStudentData();
                                this.Close();
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
        }
    }
}
