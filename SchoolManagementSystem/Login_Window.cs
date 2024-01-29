using SchoolManagementSystem.Forms.Admin;
using SchoolManagementSystem.Forms.Principal;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Login_Window : Form
    {
        public Login_Window()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool VarrifyPassword()
        {
            string id = userIdTxtBox.Text;
            string password = pwdTxtBox.Text;

            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select Password From User_Account Where UserId='" + id + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["Password"].ToString() == password)
                    {
                        reader.Close();

                        return true;
                    }
                    else
                    {
                        reader.Close();

                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid UserId or Password");
                    reader.Close();

                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No User Found");

            }
            con.Close();
            return false;

        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (userIdTxtBox.Text.Contains("admin") && VarrifyPassword())
            {
                this.Hide();
                Admin admin = new Admin(userIdTxtBox.Text);
                admin.Show();
            }
            else if (userIdTxtBox.Text.Contains("teacher") && VarrifyPassword())
            {
                this.Hide();
                Teacher admin = new Teacher(userIdTxtBox.Text);
                admin.Show();
            }
            else if (userIdTxtBox.Text.Contains("accountant") && VarrifyPassword())
            {
                this.Hide();
                Accountants admin = new Accountants("talha912@accountant.brain.edu.com");
                admin.Show();
            }
            else if (userIdTxtBox.Text.Contains("principal") && VarrifyPassword())
            {
                this.Hide();
                Principal admin = new Principal(userIdTxtBox.Text);
                admin.Show();
            }
            else
            {
                MessageBox.Show("Invalid UserId or Password");
            }
        }
    }
}
