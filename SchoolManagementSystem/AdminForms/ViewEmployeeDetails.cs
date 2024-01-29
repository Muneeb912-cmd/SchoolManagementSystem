using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.AdminForms
{
    public partial class ViewEmployeeDetails : UserControl
    {
        public ViewEmployeeDetails(string name,string contact,string salary,string role,string adress,string gender,string email)
        {
            InitializeComponent();
            LoadDetails( name,  contact,  salary,  role,  adress,  gender,  email);
        }

        public void LoadDetails(string name1, string contact1, string salary1, string role1, string adress1, string gender1, string email1)
        {
            name.Text = name1;
            contact.Text = contact1;
            salary.Text = salary1;
            role.Text = GetRole(role1);
            adress.Text = adress1;
            gender.Text = GetGender(gender1);
            email.Text = email1;
        }
        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }
        public string GetGender(string id)
        {
            string gender = "";
            if (id == "7")
            {
                gender = "Male";
            }
            else
                gender = "Fe Male";

            return gender;
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
        private void ViewEmployeeDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
