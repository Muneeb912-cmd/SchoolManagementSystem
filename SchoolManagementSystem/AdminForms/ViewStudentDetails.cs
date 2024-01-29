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
    public partial class ViewStudentDetails : UserControl
    {
        public ViewStudentDetails(string name, string registration, string age, string contact, string gender, string postal,string stdclass,string section,string session,string studentof,byte[] image)
        {
            //Loading.Visible = true;
            InitializeComponent();
            populateViewDetail(name, registration, age, contact, gender, postal,  stdclass,  section,  session,  studentof,image);
        }
        public void populateViewDetail(string name1, string registration1, string age1, string contact1, string gender1, string postal1, string stdclass, string section, string session, string studentof, byte[] image)
        {
            Validators v = new Validators();
            name.Text = name1;
            roll.Text = registration1;
            Age.Text = age1;
            contact.Text = contact1;
            if (gender1 == "7")
                gender.Text = "Male";
            else
                gender.Text = "Fe Male";
            adress.Text = postal1;
            bunifuCustomLabel8.Text = stdclass;
            bunifuCustomLabel13.Text = section;
            bunifuCustomLabel12.Text = session;
            bunifuCustomLabel14.Text = studentof;
            bunifuPictureBox1.Image = v.ConvertByteToImage(image);
        }
       
        private void ViewDetails_Load(object sender, EventArgs e)
        {
            
        }
    }
}
