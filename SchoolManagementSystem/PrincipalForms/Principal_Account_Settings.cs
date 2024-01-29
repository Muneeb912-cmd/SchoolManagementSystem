using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SchoolManagementSystem.PrincipalForms
{
    public partial class Principal_Account_Settings : Form
    {
        private string _email;
        private int _id;
        System.ComponentModel.ComponentResourceManager resources;        
        public Principal_Account_Settings(string email)
        {
            //var doc = XDocument.Load("index.xhml");
            resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Account_Settings));            
            InitializeComponent();
            _email = email;
            populateGenderComboBox();
            loadDataOfUser();
        }

        //Make a function to convert image to byte array
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        //Make a function to convert byte array to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void populateGenderComboBox()
        {
            string query = "Select l.Value From Lookup as l Where l.Category='GENDER'";
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            //rd.Close();
            while (rd.Read())
            {
                bunifuDropdown1.Items.Add(rd[0].ToString());
            }
            rd.Close();
            //con.Close();
        }

        private int getGender(string v)
        {
            int id = 0;
            var con = SQL_Configuration.getInstance().getConnection();
            string query = "Select l.id From Lookup as l Where l.Category='GENDER' and l.Value='" + v + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                id = Convert.ToInt32(rd[0].ToString());
            }
            rd.Close();
            return id;
        }

        private string getGenderString(int gender)
        {
            switch (gender)
            {
                case 7:
                    return "Male";
                case 8:
                    return "Female";
                default:
                    return "Male";
            }
        }
        private void loadDataOfUser()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("stpLoadLoggedInUserInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", _email);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                _id = Convert.ToInt32(rd["ID"].ToString());
                FirstName.Text = rd["First_Name"].ToString();
                LastName.Text = rd["Last_Name"].ToString();
                Email.Text = rd["Email"].ToString();
                Contact.Text = rd["Contact"].ToString();
                if (rd["Photo"] == DBNull.Value)
                {
                    bunifuPictureBox1.Image = (System.Drawing.Image)resources.GetObject("bunifuPictureBox1.Image");
                }
                else
                {
                    bunifuPictureBox1.Image = byteArrayToImage((byte[])rd["Photo"]);
                }
                //bunifuPictureBox1.Image = byteArrayToImage((byte[])rd["Photo"]);
                //Console.WriteLine(getGenderString(Convert.ToInt32(rd["Gender"].ToString())));
                string gender = getGenderString(Convert.ToInt32(rd["Gender"].ToString()));
                this.bunifuDropdown1.SelectedIndex = bunifuDropdown1.FindStringExact(gender);
                bunifuDatePicker2.Value = Convert.ToDateTime(rd["DOB"]);
                addressTxtBox.Text = rd["Address"].ToString();
                PasswordTxtbox.Text = rd["Password"].ToString();
            }
            rd.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (FirstName.Text.Length == 0 || LastName.Text.Length == 0 || Contact.Text.Length == 0 || PasswordTxtbox.Text.Length == 0 || bunifuDropdown1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (PasswordTxtbox.Text.Length < 8) { MessageBox.Show("Password must be atleast 8 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Save Changes?", "Update Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            var con = SQL_Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("stpEditLoggedInUserInfo", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", _id);
                            cmd.Parameters.AddWithValue("@fName", FirstName.Text);
                            cmd.Parameters.AddWithValue("@lName", LastName.Text);
                            cmd.Parameters.AddWithValue("@email", Email.Text);
                            cmd.Parameters.AddWithValue("@contact", Contact.Text);
                            cmd.Parameters.AddWithValue("@dob", bunifuDatePicker2.Value);
                            cmd.Parameters.AddWithValue("@password", PasswordTxtbox.Text);
                            cmd.Parameters.AddWithValue("@gender", getGender(bunifuDropdown1.Text));
                            cmd.Parameters.AddWithValue("@address", addressTxtBox.Text);
                            if (bunifuPictureBox1.Image == (System.Drawing.Image)resources.GetObject("bunifuPictureBox1.Image"))
                            {
                                cmd.Parameters.AddWithValue("@image", DBNull.Value);
                            }
                            else
                            {

                                cmd.Parameters.AddWithValue("@image", imageToByteArray(bunifuPictureBox1.Image));
                            }
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Changes Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                bunifuPictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                //PicturePath.Text = open.FileName;
            }
        }

    }
}
