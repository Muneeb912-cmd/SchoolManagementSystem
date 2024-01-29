using BunifuAnimatorNS;
using SchoolManagementSystem.TeacherForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Teacher : Form
    {
        private Form activeForm;
        private string _email;
        public Teacher(string email)
        {
            InitializeComponent();
            _email = email;
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(childForm);
            this.MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        private void exitToolbarBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void maxToolbarBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void minToolbarBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void viewLogoutBtn_Click(object sender, EventArgs e)
        {
            BunifuTransition transition = new BunifuTransition();
            if (logoutBtn.Visible == false)
            {
                transition.ShowSync(logoutBtn, false, BunifuAnimatorNS.Animation.Mosaic);
                //logoutBtn.Visible = true;
            }
            else
            {
                transition.HideSync(logoutBtn, false, BunifuAnimatorNS.Animation.Mosaic);
                //logoutBtn.Visible = false;
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login_Window login = new Login_Window();
                login.Show();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Class_Attendance());
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_Account_Settings(_email));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
    }
}
