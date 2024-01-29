using BunifuAnimatorNS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem.PrincipalForms
{
    public partial class Subjects_Window_Main : Form
    {
        public Subjects_Window_Main()
        {
            InitializeComponent();
            timer1.Start();
            loadClassesVaraintsAndSubjectsToList("", "");
            loadListToGui();
        }

        public string getVariantName(int id)
        {
            string variantTitle = "";
            switch (id)
            {
                case 9:
                    variantTitle = "General";
                    break;
                case 10:
                    variantTitle = "ComputerScience";
                    break;
                case 11:
                    variantTitle = "Biology";
                    break;
                case 12:
                    variantTitle = "Arts";
                    break;
            }
            return variantTitle;
        }

        private void Subjects_Window_Main_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                flowLayoutPanel1.Controls[i].Width = flowLayoutPanel1.Width - 30;
            }
        }

        //private static Class_Subjects_UC csu = new Class_Subjects_UC(this);
        private void loadListToGui()
        {
            foreach (var item in Manage_Subject_Syllabus.classSubjectListObj)
            {
                Class_Subjects_UC c = item;
                foreach (var item2 in c.subjectListObj)
                {
                    if (item2.SubjectName == "")
                    {
                        //break;
                    }
                    else
                    {
                        Subject_UC s = item2;
                        //this.flowLayoutPanel1.Controls.Add(s);
                        c.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(s);
                    }
                }
                this.flowLayoutPanel1.Controls.Add(c);
            }
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                flowLayoutPanel1.Controls[i].Width = flowLayoutPanel1.Width - 30;
            }
        }
        private void loadClassesVaraintsAndSubjectsToList(string session, string teacher)
        {
            Manage_Subject_Syllabus.classSubjectListObj.Clear();
            //Clear the GUI
            this.flowLayoutPanel1.Controls.Clear();
            //Load the classes
            string query = "";
            if (session == "" && teacher == "")
            {
                query = "Select * From ClassesAndSubjectsData Order by ClassID, VariantType";
            }
            else if (session != "" && teacher == "")
            {
                query = "Select * From ClassesAndSubjectsData Where Session = '" + session + "'  Order by ClassID, VariantType";
            }
            else if (session == "" && teacher != "")
            {
                query = "Select * From ClassesAndSubjectsData Where TeacherName  Like '%" + teacher + "%'  Order by ClassID, VariantType";
            }
            else if (session != "" && teacher != "")
            {
                query = "Select * From ClassesAndSubjectsData Where  Session = '" + session + "' And TeacherName  Like '%" + teacher + "%'  Order by ClassID, VariantType";
            }

            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int checkClassID = 0;
            int checkVariantID = 0;
            Class_Subjects_UC c = new Class_Subjects_UC(this);
            while (reader.Read())
            {
                //checkId = ;
                if ((checkClassID != Convert.ToInt32(reader["classID"].ToString()) && checkVariantID != Convert.ToInt32(reader["VariantType"].ToString())) || checkClassID != Convert.ToInt32(reader["classID"].ToString()))
                {

                    c = new Class_Subjects_UC(this);
                    c.ClassID = Convert.ToInt32(reader["classID"].ToString());
                    c.ClassName = reader["Title"].ToString();
                    c.ClassSession = reader["Session"].ToString();
                    c.ClassVariant = getVariantName(Convert.ToInt32(reader["VariantType"].ToString()));
                    c.VariantID = Convert.ToInt32(reader["VariantID"].ToString());
                    //this.flowLayoutPanel1.Controls.Add(c);

                    Subject_UC s = new Subject_UC(c);
                    s.SubjectId = Convert.ToInt32(reader["ID"].ToString());
                    s.SubjectName = reader["SubjectTitle"].ToString();
                    s.Syllabus = reader["Description"].ToString();
                    try { s.TeacherId = Convert.ToInt32(reader["TeacherID"].ToString()); }
                    catch { s.TeacherId = -1; }

                    s.TeacherName = reader["TeacherName"].ToString();
                    //c.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(s);

                    c.subjectListObj.Add(s);
                    Manage_Subject_Syllabus.classSubjectListObj.Add(c);
                }
                else if (checkClassID == Convert.ToInt32(reader["classID"].ToString()) && checkVariantID != Convert.ToInt32(reader["VariantType"].ToString()))
                {

                    c = new Class_Subjects_UC(this);
                    c.ClassID = checkClassID;
                    c.ClassName = reader["Title"].ToString();
                    c.ClassSession = reader["Session"].ToString();
                    c.ClassVariant = getVariantName(Convert.ToInt32(reader["VariantType"].ToString()));
                    c.VariantID = Convert.ToInt32(reader["VariantID"].ToString());
                    //this.flowLayoutPanel1.Controls.Add(c);


                    Subject_UC s = new Subject_UC(c);
                    s.SubjectId = Convert.ToInt32(reader["ID"].ToString());
                    s.SubjectName = reader["SubjectTitle"].ToString();
                    s.Syllabus = reader["Description"].ToString();
                    try { s.TeacherId = Convert.ToInt32(reader["TeacherID"].ToString()); }
                    catch { s.TeacherId = -1; }

                    s.TeacherName = reader["TeacherName"].ToString();
                    //c.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(s);

                    c.subjectListObj.Add(s);
                    Manage_Subject_Syllabus.classSubjectListObj.Add(c);
                }
                else
                {
                    Subject_UC s = new Subject_UC(c);
                    s.SubjectId = Convert.ToInt32(reader["ID"].ToString());
                    s.SubjectName = reader["SubjectTitle"].ToString();
                    s.Syllabus = reader["Description"].ToString();
                    try { s.TeacherId = Convert.ToInt32(reader["TeacherID"].ToString()); }
                    catch { s.TeacherId = -1; }

                    s.TeacherName = reader["TeacherName"].ToString();
                    //c.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(s);


                    c.subjectListObj.Add(s);
                }
                checkClassID = Convert.ToInt32(reader["classID"].ToString());
                checkVariantID = Convert.ToInt32(reader["VariantType"].ToString());
                //this.flowLayoutPanel1.Controls.Add(c);
            }
            reader.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BunifuTransition transition = new BunifuTransition();
            transition.HideSync(pictureBox1, false, BunifuAnimatorNS.Animation.Particles);
            //transition.MaxAnimationTime = 800;
            loadingPanel.Visible = false;
            timer1.Stop();
        }

        private void filterSessionBtn_Click(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            timer1.Start();
            timer1.Interval = 1000;
            loadClassesVaraintsAndSubjectsToList(filterSessionTxtBox.Text.Trim(), filterTeacherTxtBox.Text.Trim());
            loadListToGui();
        }

        private void filterTeacherBtn_Click(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            timer1.Start();
            timer1.Interval = 1000;
            loadClassesVaraintsAndSubjectsToList(filterSessionTxtBox.Text.Trim(), filterTeacherTxtBox.Text.Trim());
            loadListToGui();
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string session = filterSessionTxtBox.Text.Trim();
                string teacher = filterTeacherTxtBox.Text.Trim();
                string query = "";
                int check = -1;
                if (session == "" && teacher == "")
                {
                    query = "Select * From ClassesAndSubjectsData where SubjectTitle is not Null Order by Title, session";
                    check = 2;
                }
                else if (session != "" && teacher == "")
                {
                    query = "Select * From ClassesAndSubjectsData Where Session = '" + session + "' And SubjectTitle is not Null  Order by Title, session";
                    check = 3;
                }
                else if (session == "" && teacher != "")
                {
                    query = "Select * From ClassesAndSubjectsData Where TeacherName  Like '%" + teacher + "%' And SubjectTitle is not Null  Order by Title, session";
                    check = 4;
                }
                else if (session != "" && teacher != "")
                {
                    query = "Select * From ClassesAndSubjectsData Where  Session = '" + session + "' And TeacherName  Like '%" + teacher + "%' And SubjectTitle is not Null  Order by Title, session";
                    check = 5;
                }
                var con = SQL_Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dtReportData = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dtReportData.Load(sdr);
                Class_Reports crp = new Class_Reports(check);
                if (check == 2)
                {
                    crp.ReportName = @"SchoolManagementSystem\PrincipalForms\Reports\AllClassesAndSubjectsRPT.rpt";
                }
                else if (check == 3)
                {
                    crp.ReportName = @"SchoolManagementSystem\PrincipalForms\Reports\FilteredClassesAndSectionsRPT.rpt";
                }
                else if (check == 4)
                {
                    crp.ReportName = @"SchoolManagementSystem\PrincipalForms\Reports\FilteredClassesAndSectionsRPT.rpt";
                }
                else if (check == 5)
                {
                    crp.ReportName = @"SchoolManagementSystem\PrincipalForms\Reports\FilteredClassesAndSectionsRPT.rpt";
                }
                crp.DtReport = dtReportData;
                crp.ShowDialog();
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
