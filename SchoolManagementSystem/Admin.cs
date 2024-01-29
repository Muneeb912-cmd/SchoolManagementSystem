using Bunifu.Framework.UI;
using SchoolManagementSystem.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Forms.Admin
{
    public partial class Admin : Form
    {
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        bool manage_student_clicked = false;
        bool manage_employee_clicked = false;
        bool attendace_clicked = false;
        bool manage_profile_clicked = false;
        bool user_out_clicked = false;
        bool user_account_clicked = false;
        string Admin_Email = "";
        public Admin(string admin_email)
        {
            InitializeComponent();
            Admin_Email = admin_email;
        }
        
        

        private void Admin_Load(object sender, EventArgs e)
        {
            SelectPanel1.Visible = false;
            SelectPanel2.Visible = false;
            SelectPanel3.Visible = false;
            SelectPanel4.Visible = false;
            panel11.Visible = false;
            SelectPanel5.Visible = false;
            SubMenu2.Visible = false;
            
            panel8.Controls.Clear();
            AdminProfile ap = new AdminProfile(Admin_Email);
            ap.Dock = DockStyle.Fill;
            panel8.Controls.Add(ap);

        }

        private void ManageStudent_Click(object sender, EventArgs e)
        {
            if (manage_student_clicked == false)
            {
                panel8.Controls.Clear();
                Manage_Student ms = new Manage_Student();
                ms.Dock = DockStyle.Fill;
                //TimeTabel tt = new TimeTabel();
                //tt.Dock = DockStyle.Fill;
                panel8.Controls.Add(ms);    
                manage_student_clicked = true;
                manage_employee_clicked = false;
                attendace_clicked = false;
                SelectPanel1.Visible = true;
                SelectPanel2.Visible = false;
                SelectPanel3.Visible = false;
                SelectPanel1.BackColor = Color.FromArgb(64, 223, 239);
                SelectPanel5.Visible = false;
                SubMenu2.Visible = false;
                manage_profile_clicked = false;
                user_out_clicked = false;
                SelectPanel4.Visible = false;
            }
            else
            {
                manage_student_clicked = false;
                manage_employee_clicked = false;
                attendace_clicked = false;
                SelectPanel1.Visible = false;
                SelectPanel2.Visible = false;
                SelectPanel3.Visible = false;
                user_out_clicked = false;
                SubMenu2.Visible = false;
                manage_profile_clicked = false;
                SelectPanel5.Visible = false;
                SelectPanel4.Visible = false;
            }
        }

        private void ManageEmployee_Click(object sender, EventArgs e)
        {
            if (manage_employee_clicked == false)
            {
                manage_student_clicked = false;
                manage_employee_clicked = true;
                attendace_clicked = false;
                SelectPanel1.Visible = false;
                SelectPanel2.Visible = true;
                SelectPanel3.Visible = false;
                SelectPanel2.BackColor = Color.FromArgb(64, 223, 239);
                SelectPanel5.Visible = false;
                SubMenu2.Visible = true;
                manage_profile_clicked = false;
                user_out_clicked = false;

                SelectPanel4.Visible = false;
            }
            else
            {
                manage_student_clicked = false;
                manage_employee_clicked = false;
                attendace_clicked = false;
                SelectPanel1.Visible = false;
                SelectPanel2.Visible = false;
                SelectPanel3.Visible = false; 
                manage_profile_clicked = false;

                SubMenu2.Visible = false;
                user_out_clicked = false;
                SelectPanel5.Visible = false;
                SelectPanel4.Visible = false;
            }
        }

        private void ManageUserAccounts_Click(object sender, EventArgs e)
        {
            if (attendace_clicked == false)
            {
                panel8.Controls.Clear();
                manage_student_clicked = false;
                manage_employee_clicked = false;
                manage_profile_clicked = false;
                attendace_clicked = true;
                SelectPanel1.Visible = false;
                SelectPanel2.Visible = false;
                SelectPanel3.Visible = true;
                SelectPanel3.BackColor = Color.FromArgb(64, 223, 239);
                SelectPanel5.Visible = false;
                SubMenu2.Visible = false;
                user_out_clicked = false;

                SelectPanel4.Visible = false;
                EmployeeAttendance ea = new EmployeeAttendance();
                ea.Dock = DockStyle.Fill;
                panel8.Controls.Add(ea);
            }
            else
            {
                manage_student_clicked = false;
                manage_profile_clicked = false;
                manage_employee_clicked = false;
                attendace_clicked = false;
                SelectPanel1.Visible = false;
                SelectPanel2.Visible = false;
                SelectPanel3.Visible = false;
                SelectPanel5.Visible = false;
                SubMenu2.Visible = false;
                user_out_clicked = false;

                SelectPanel4.Visible = false;
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            if (manage_profile_clicked == false)
            {
                
                manage_profile_clicked = true;
                SelectPanel4.Visible = false;                
                SelectPanel5.BackColor = Color.FromArgb(64, 223, 239);
                SelectPanel5.Visible = true;
                panel8.Controls.Clear();
                AdminProfile ap = new AdminProfile(Admin_Email);
                ap.Dock = DockStyle.Fill;
                panel8.Controls.Add(ap);
                manage_student_clicked = false;
                manage_employee_clicked = false;
                attendace_clicked = false;
                SelectPanel1.Visible = false;
                SelectPanel2.Visible = false;
                SelectPanel3.Visible = false;
                user_out_clicked = false;
                SubMenu2.Visible = false;
               
              
            }
            else
            {
                manage_profile_clicked = false;
                SelectPanel4.Visible = false;
                manage_student_clicked = false;
                manage_employee_clicked = false;
                attendace_clicked = false;
                SelectPanel1.Visible = false;
                SelectPanel2.Visible = false;
                SelectPanel3.Visible = false;
                SelectPanel5.Visible = false ;
                SubMenu2.Visible = false;
                user_out_clicked = false;

            }
        }
        
        private void MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    flowLayoutPanel1.Height -= 130;
                }
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        } 

        private void ManageTeacher_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            ManageTeacher manageTeacher = new ManageTeacher();
            //manageTeacher.Anchor = AnchorStyles.Top;
            //manageTeacher.Anchor = AnchorStyles.Left;
            //manageTeacher.Anchor = AnchorStyles.Right;
            //manageTeacher.Anchor = AnchorStyles.Bottom;
            manageTeacher.Dock = DockStyle.Fill;
            panel8.Controls.Add(manageTeacher);
            
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            ManageNonTeachingStaff mnts = new ManageNonTeachingStaff();
            mnts.Dock = DockStyle.Fill;
            panel8.Controls.Add(mnts);
        }        

        private void exitToolbarBtn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void maxToolbarBtn_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                flowLayoutPanel1.Height -= 130;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                flowLayoutPanel1.Height += 130;
            }
        }

        private void minToolbarBtn_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void LogOut1_Click(object sender, EventArgs e)
        {
            if (user_out_clicked == false)
            {
                panel11.Visible =true;
                user_out_clicked = true;
            }
            else
            {
                panel11.Visible = false;
                user_out_clicked = false;
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login_Window lf = new Login_Window();
                lf.Show();
            }
        }

        private void UserAccounts_Click(object sender, EventArgs e)
        {
            if (user_account_clicked == false)
            {
                user_out_clicked = true;
                SelectPanel5.Visible = false;
                SelectPanel4.BackColor = Color.FromArgb(64, 223, 239);
                SelectPanel4.Visible = true;               
                manage_student_clicked = false;
                manage_employee_clicked = false;
                attendace_clicked = false;
                SelectPanel1.Visible = false;
                SelectPanel2.Visible = false;
                SelectPanel3.Visible = false;
                SubMenu2.Visible = false;
                panel8.Controls.Clear();
                ManageUserAccounts mua = new ManageUserAccounts();
                mua.Dock = DockStyle.Fill;
                panel8.Controls.Add(mua);
            }
            else
            {
                user_out_clicked = false;
                SelectPanel4.Visible = false;
                manage_student_clicked = false;
                manage_employee_clicked = false;
                attendace_clicked = false;
                SelectPanel1.Visible = false;
                SelectPanel2.Visible = false;
                SelectPanel3.Visible = false;
                SelectPanel5.Visible = false;
                SubMenu2.Visible = false;


            }
        }
    }
}
