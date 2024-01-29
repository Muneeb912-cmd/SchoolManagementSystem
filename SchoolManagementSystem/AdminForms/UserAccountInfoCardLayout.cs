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
    public partial class UserAccountInfoCardLayout : UserControl
    {
        public UserAccountInfoCardLayout(string name, string email, string hiredas, string contact, string password,byte[] img)
        {
            InitializeComponent();
            
            PopulateUpdateForm(name, email, GetRole(hiredas), contact, password,img);
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
        Validators v = new Validators();
        public void PopulateUpdateForm(string name, string email, string hiredas, string contact, string password,byte[] img)
        {
            name1.Text = name;
            Email.Text = email;
            HiredAs.Text = hiredas;
            Contact.Text = contact;
            Password.Text = password;
            bunifuPictureBox1.Image = v.ConvertByteToImage(img);
        }
        public void UpdateUserAccount()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdatePassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = Email.Text;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = Password.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Password Updated Successfully");
        }
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            UpdateUserAccount();
            this.Hide();
        }

        private void UserAccountInfoCardLayout_Load(object sender, EventArgs e)
        {
            name1.Enabled = false;
            Contact.Enabled = false;
            HiredAs.Enabled = false;            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Contact.Enabled = true;
            Password.Enabled = true;
        }

        private void DiscardChanges_Click(object sender, EventArgs e)
        {
            this.Hide();
        }        
    }
}
