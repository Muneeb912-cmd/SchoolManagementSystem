using BunifuAnimatorNS;
using SchoolManagementSystem.PrincipalForms;
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

namespace SchoolManagementSystem.Forms.Principal
{
    public partial class Principal : Form
    {
        private Form activeForm;

        private string _email;
        public Principal( string email)
        {
            InitializeComponent();
            _email = email;
            initializeCounter();
        }
        private void initializeCounter()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            string query = "Select Count(s.StudentId) From Student s Where IsDeleted = 0" +
                                   " Select Count(c.ClassID) From [Class] c Where IsDeleted = 0 And c.[Session] = '2022'" +
                                   " Select Count(s.SectionID) From Section s inner join ClassVariants cv on s.VID = cv.VariantID inner join class c on c.ClassID = cv.CID And c.isDeleted = 0 Where s.IsDeleted = 0 And c.[Session] = '2022'" +
                                   " Select Count(e.EmployeeId) From Employee e Where [Role] = 14 And IsDeleted = 0" +
                                   " Select Count(e.EmployeeId) From Employee e Where [Role] <> 14 And IsDeleted = 0" +
                                   " Select Count(ea.EID) From Employee_Attendance ea inner join Employee e on ea.EID = e.EmployeeId Where e.[Role] = 14 And e.IsDeleted = 0 And ea.AttStatus = 1 And ea.[Date] = CAST( GETDATE() AS Date )" +
                                   " Select Count(s.StudentId) From Student s";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd.GetInt32(0) < 10)
                {
                    enrolledStdCounter.Text = "0" + rd[0].ToString();
                }
                else
                {
                    enrolledStdCounter.Text = rd[0].ToString();
                }
            }
            rd.NextResult();
            while (rd.Read())
            {
                if (rd.GetInt32(0) < 10)
                {
                    classCounter.Text = "0" + rd[0].ToString();
                }
                else
                {
                    classCounter.Text = rd[0].ToString();
                }
            }
            rd.NextResult();
            while (rd.Read())
            {
                if (rd.GetInt32(0) < 10)
                {
                    classCounter.Text = classCounter.Text+" (0" + rd[0].ToString() + ")";

                }
                else
                {
                    classCounter.Text = classCounter.Text+" ("+rd[0].ToString()+")";
                }
            }
            rd.NextResult();
            while (rd.Read())
            {
                if (rd.GetInt32(0) < 10)
                {
                    teacherCounter.Text = "0" + rd[0].ToString();
                }
                else
                {
                    teacherCounter.Text = rd[0].ToString();
                }
            }
            rd.NextResult();
            while (rd.Read())
            {
                if (rd.GetInt32(0) < 10)
                {
                    nonTeacherCounter.Text = "0" + rd[0].ToString();
                }
                else
                {
                    nonTeacherCounter.Text = rd[0].ToString();
                }
            }
            rd.NextResult();
            while (rd.Read())
            {
                if (rd.GetInt32(0) < 10)
                {
                    teacherPresentCounter.Text = "0" + rd[0].ToString();
                }
                else
                {
                    teacherPresentCounter.Text = rd[0].ToString();
                }
            }
            rd.NextResult();
            while (rd.Read())
            {
                if (rd.GetInt32(0) < 10)
                {
                    totalStdCounter.Text = "0" + rd[0].ToString();
                }
                else
                {
                    totalStdCounter.Text = rd[0].ToString();
                }
            }
            rd.Close();
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
            
                WindowState = FormWindowState.Minimized;
            
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Classes_Window_Main());
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Employee_Attendance_Report());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Subjects_Window_Main());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            initializeCounter();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Principal_Account_Settings(_email));
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimeTable_Main());
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

        private void viewLogoutBtn_Click(object sender, EventArgs e)
        {
            BunifuTransition transition = new BunifuTransition();
            if (logoutBtn.Visible == false)
            {
                transition.ShowSync(logoutBtn, false,BunifuAnimatorNS.Animation.Mosaic);
                //logoutBtn.Visible = true;
            }
            else
            {
                transition.HideSync(logoutBtn, false,BunifuAnimatorNS.Animation.Mosaic);
                //logoutBtn.Visible = false;
            }
        }

    }
}
