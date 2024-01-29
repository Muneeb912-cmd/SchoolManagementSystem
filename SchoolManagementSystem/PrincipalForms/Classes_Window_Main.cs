using BunifuAnimatorNS;
using SchoolManagementSystem.PrincipalForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Classes_Window_Main : Form
    {
        public Classes_Window_Main()
        {
            InitializeComponent();
            toolTip1.SetToolTip(addClassBtn, "Click Here To Add A New Class");
            toolTip1.SetToolTip(refreshPageBtn, "Click Here To Refresh Page");
            toolTip1.SetToolTip(generateReportBtn, "Click Here To Generate Report");
            timer1.Start();
            loadClassesAndSectionsToList("");
            loadListToGui();
        }
        public void loadListToGui()
        {

            foreach (var item in Manage_Class.classListObj)
            {
                Class_UC c = item;
                foreach (var item2 in c.sectionListObj)
                {
                    Section_UC s = item2;
                    //this.flowLayoutPanel1.Controls.Add(s);
                    c.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(s);
                    this.flowLayoutPanel1.Controls.Add(c);
                }
            }
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                flowLayoutPanel1.Controls[i].Width = flowLayoutPanel1.Width - 30;
            }
        }
        public void loadClassesAndSectionsToList(string session)
        {
            //Manage_Class mc = new Manage_Class(this, -1, -1, "", "", "");
            //Clear the list
            Manage_Class.classListObj.Clear();
            //Clear the GUI
            this.flowLayoutPanel1.Controls.Clear();
            //Load the classes
            string query = "";
            if (session == "")
            {
                query = "Select * From ClassesAndSectionsData Order by ClassID, VariantType";
            }
            else
            {
                query = "Select * From ClassesAndSectionsData Where Session = '" + session + "'  Order by ClassID, VariantType";
            }

            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Close();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int checkClassID = 0;
            int checkVariantID = 0;
            Class_UC c = new Class_UC(this);
            while (reader.Read())
            {
                //checkId = ;
                if ((checkClassID != Convert.ToInt32(reader["classID"].ToString()) && checkVariantID != Convert.ToInt32(reader["VariantType"].ToString())) || checkClassID != Convert.ToInt32(reader["classID"].ToString()))
                {

                    c = new Class_UC(this);
                    c.ClassID = Convert.ToInt32(reader["classID"].ToString());
                    c.ClassName = reader["Title"].ToString();
                    c.ClassSession = reader["Session"].ToString();
                    c.ClassVariant = getVariantName(Convert.ToInt32(reader["VariantType"].ToString()));
                    c.VariantID = Convert.ToInt32(reader["VariantID"].ToString());
                    //this.flowLayoutPanel1.Controls.Add(c);

                    Section_UC s = new Section_UC(c);
                    s.SectionId = Convert.ToInt32(reader["SectionID"].ToString());
                    s.SectionName = reader["SectionTitle"].ToString();
                    s.SectionCapacity = Convert.ToInt32(reader["Student_Capacity"].ToString());
                    //c.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(s);

                    c.sectionListObj.Add(s);
                    Manage_Class.classListObj.Add(c);
                }
                else if (checkClassID == Convert.ToInt32(reader["classID"].ToString()) && checkVariantID != Convert.ToInt32(reader["VariantType"].ToString()))
                {

                    c = new Class_UC(this);
                    c.ClassID = checkClassID;
                    c.ClassName = reader["Title"].ToString();
                    c.ClassSession = reader["Session"].ToString();
                    c.ClassVariant = getVariantName(Convert.ToInt32(reader["VariantType"].ToString()));
                    c.VariantID = Convert.ToInt32(reader["VariantID"].ToString());
                    //this.flowLayoutPanel1.Controls.Add(c);

                    Section_UC s = new Section_UC(c);
                    s.SectionId = Convert.ToInt32(reader["SectionID"].ToString());
                    s.SectionName = reader["SectionTitle"].ToString();
                    s.SectionCapacity = Convert.ToInt32(reader["Student_Capacity"].ToString());
                    //c.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(s);

                    c.sectionListObj.Add(s);
                    Manage_Class.classListObj.Add(c);
                }
                else
                {
                    //c.Width = this.Controls.Find("flowLayoutPanel1", true)[0].Width - 50;
                    Section_UC s = new Section_UC(c);
                    s.SectionId = Convert.ToInt32(reader["SectionID"].ToString());
                    s.SectionName = reader["SectionTitle"].ToString();
                    s.SectionCapacity = Convert.ToInt32(reader["Student_Capacity"].ToString());
                    //c.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(s);


                    c.sectionListObj.Add(s);
                }
                checkClassID = Convert.ToInt32(reader["classID"].ToString());
                checkVariantID = Convert.ToInt32(reader["VariantType"].ToString());
                //this.flowLayoutPanel1.Controls.Add(c);
            }
            reader.Close();
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
        private void addClassBtn_Click(object sender, EventArgs e)
        {
            Manage_Class manageClass = new Manage_Class(this, -1, -1, "", "", "");
            manageClass.Controls.Find("addClass", true)[0].BackColor = Color.Transparent;
            manageClass.Controls.Find("closeBtn", true)[0].BackColor = Color.Transparent;
            manageClass.Controls.Find("editClass", true)[0].BackColor = Color.Transparent;
            manageClass.pageTitle = "Add Class";
            manageClass.ShowDialog();
        }

        private void Classes_Window_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                flowLayoutPanel1.Controls[i].Width = flowLayoutPanel1.Width - 30;
            }
        }

        private void filterSessionBtn_Click(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            timer1.Start();
            timer1.Interval = 1000;
            loadClassesAndSectionsToList(filterSessionTxtBox.Text);
            loadListToGui();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BunifuTransition transition = new BunifuTransition();
            transition.HideSync(pictureBox1, false, BunifuAnimatorNS.Animation.Particles);
            //transition.MaxAnimationTime = 800;
            loadingPanel.Visible = false;
            timer1.Stop();
        }

        private void refreshPageBtn_Click(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            timer1.Start();
            timer1.Interval = 1500;
            loadClassesAndSectionsToList("");
            loadListToGui();
        }

        private void filterSessionTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                int check = -1;
                if (filterSessionTxtBox.Text.Trim() == "")
                {
                    query = "Select * From ClassesAndSectionsData Order by Title, Session";
                    check = 0;
                }
                else
                {
                    query = "Select * From ClassesAndSectionsData Where Session = '" + filterSessionTxtBox.Text + "'  Order by ClassID, VariantType";
                    check = 1;
                }
                var con = SQL_Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand(query, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                DataTable dtReportData = new DataTable();
                //con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dtReportData.Load(sdr);
                Class_Reports crp = new Class_Reports(check);
                if (check == 0)
                {
                    crp.ReportName = @"SchoolManagementSystem\PrincipalForms\Reports\ClassesAndSectionsRPT.rpt";
                }else if(check == 1)
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
