using SchoolManagementSystem.PrincipalForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SchoolManagementSystem
{
    public partial class Manage_Class : Form
    {
        //Lists
        private static List<Class_UC> classList;
        public static List<Class_UC> classListObj
        {
            get
            {
                if (classList == null)
                {
                    classList = new List<Class_UC>();
                }
                return classList;
            }
        }

        private int _classId;
        private int _variantId;

        private Classes_Window_Main _parentForm;
        public Manage_Class(Classes_Window_Main classes_Window_Main, int classId, int variantId, string classVariant, string classTitle, string classSession)
        {
            //var doc = XDocument.Load("index.xhml");
            InitializeComponent();
            this._parentForm = classes_Window_Main;
            this.populateVariantComboBox();
            if (classId != -1)
            {
                _classId = classId;
                _variantId = variantId;
                this.classTitleDropDown.SelectedIndex = classTitleDropDown.FindStringExact(classTitle);
                //this.classTitleDropDown.Enabled = false;
                this.sessionTitleTxtBox.Text = classSession;
                this.variantDropDown.SelectedIndex = variantDropDown.FindStringExact(classVariant);
            }
        }


        private void populateVariantComboBox()
        {
            string query = "EXEC	stpGetClassVariant";
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                variantDropDown.Items.Add(rd[0].ToString());
            }
            rd.Close();
        }
        private int searchClassWithSession(string className, string session)
        {
            string query = "Select ClassId from Class where Title = '" + className + "' and Session = '" + session + "' and isDeleted = 0";
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            int classId = -1;
            while (rd.Read())
            {
                try
                {
                    classId = Convert.ToInt32(rd[0]);
                }
                catch (Exception)
                {
                    classId = -1;
                }
            }
            rd.Close();
            return classId;
        }

        private int searchClassWithSessionAndVariant(string className, string session, int variantType)
        {
            string query = "Select c.ClassID From Class c inner join ClassVariants cv on cv.CID = c.ClassID  where c.Title = '" + className + "' and c.Session = '" + session + "' and cv.VariantType = '" + variantType + "' and c.isDeleted = 0 and cv.isDeleted = 0";
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            int classId = -1;
            while (rd.Read())
            {
                try
                {
                    classId = Convert.ToInt32(rd[0]);
                }
                catch (Exception)
                {
                    classId = -1;
                }
            }
            rd.Close();
            return classId;
        }

        private string _pageTitle;
        [Category("Page Title")]
        public string pageTitle
        {
            get { return _pageTitle; }
            set
            {
                _pageTitle = value;
                DialogTitle.Text = value;
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int getClassID()
        {
            int classID = 0;
            string query = "Select Max(ClassId) From Class";
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                try { classID = Convert.ToInt32(rd[0].ToString()); }
                catch (Exception) { rd.Close(); return 1; }
            }
            rd.Close();
            return classID + 1;
        }
        public int getSectionID()
        {
            int sectionID = 0;
            string query = "Select Max(SectionId) From Section";
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                try { sectionID = Convert.ToInt32(rd[0].ToString()); }
                catch (Exception) { rd.Close(); return 1; }
            }
            rd.Close();
            return sectionID + 1;
        }
        public int getVariantID(string variant)
        {
            int variantID = 0;
            string query = "Select Id From Lookup as l Where l.Category='Class_Variant' and l.Value='" + variant + "'";
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                variantID = Convert.ToInt32(rd[0].ToString());
            }
            rd.Close();
            return variantID;
        }
        //Add Class Code Here
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (classTitleDropDown.SelectedIndex == -1 || sessionTitleTxtBox.Text.Trim() == "" || variantDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int session = Convert.ToInt32(sessionTitleTxtBox.Text);
                    if (session > 2015 && session < 2050)
                    {
                        if (searchClassWithSession(classTitleDropDown.Text, sessionTitleTxtBox.Text) == -1)
                        {
                            try
                            {
                                int classID = getClassID();
                                int sectionID = getSectionID();

                                //Code for data entry in Sql Database
                                var con = SQL_Configuration.getInstance().getConnection();
                                SqlCommand cmd = new SqlCommand("stpInsertClassPlusSection", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@classId", classID);
                                cmd.Parameters.AddWithValue("@Title", classTitleDropDown.Text);
                                cmd.Parameters.AddWithValue("@Session", sessionTitleTxtBox.Text);
                                cmd.Parameters.AddWithValue("@VariantType", getVariantID(variantDropDown.Text));
                                cmd.Parameters.AddWithValue("@sectionId", sectionID);

                                SqlParameter RuturnValue = new SqlParameter("@variantId", SqlDbType.Int);
                                RuturnValue.Direction = ParameterDirection.Output;
                                cmd.Parameters.Add(RuturnValue);

                                cmd.ExecuteNonQuery();
                                int variantId = Convert.ToInt32(RuturnValue.Value.ToString());
                                //End of Code for data entry in Sql Database

                                Class_UC class_UC = new Class_UC(_parentForm);
                                class_UC.ClassID = classID;
                                class_UC.VariantID = variantId;
                                class_UC.ClassName = classTitleDropDown.Text;
                                class_UC.ClassSession = sessionTitleTxtBox.Text;
                                class_UC.ClassVariant = variantDropDown.SelectedItem.ToString();

                                Section_UC section_UC = new Section_UC(class_UC);
                                section_UC.SectionId = sectionID;
                                section_UC.SectionName = "Green";
                                section_UC.SectionCapacity = 20;

                                class_UC.sectionListObj.Add(section_UC);
                                classListObj.Add(class_UC);

                                HashSet<string> subjects = new HashSet<string>();
                                for (int i = 0; i < this.Controls.Find("subjectsFlowPanel", true)[0].Controls.Count; i++)
                                {
                                    // Get data from every control of subjectsFlowPanel
                                    var control = this.Controls.Find("subjectsFlowPanel", true)[0].Controls[i];
                                    var textBox = (Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox)control.Controls.Find("subjectTxtBox", true)[0];
                                    if (textBox.Text.Trim() != "")
                                    {
                                        subjects.Add(textBox.Text);

                                    }
                                    //Console.WriteLine(textBox.Text);
                                }
                                //Code for data entry in Sql Database
                                if (subjects.Count > 0)
                                {
                                    foreach (var subject in subjects)
                                    {
                                        if (subject != "")
                                        {
                                            var con2 = SQL_Configuration.getInstance().getConnection();
                                            SqlCommand cmd2 = new SqlCommand("stpInsertSubjectAndAssign", con2);
                                            cmd2.CommandType = CommandType.StoredProcedure;
                                            Console.WriteLine(subject);
                                            cmd2.Parameters.AddWithValue("@Title", subject);
                                            cmd2.Parameters.AddWithValue("@variantId", variantId);
                                            cmd2.ExecuteNonQuery();
                                        }
                                    }
                                }
                                else
                                {
                                    var con2 = SQL_Configuration.getInstance().getConnection();
                                    SqlCommand cmd2 = new SqlCommand("stpInsertSubjectAndAssign", con2);
                                    cmd2.CommandType = CommandType.StoredProcedure;
                                    cmd2.Parameters.AddWithValue("@Title", DBNull.Value);
                                    cmd2.Parameters.AddWithValue("@variantId", variantId);
                                    cmd2.ExecuteNonQuery();
                                }
                                //End of Code for data entry in Sql Database

                                class_UC.Width = _parentForm.Controls.Find("flowLayoutPanel1", true)[0].Width - 20;
                                class_UC.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(section_UC);
                                _parentForm.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(class_UC);
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Class Addition Failed" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            int variantIde = getVariantID(variantDropDown.Text);
                            if (variantIde == 8)
                            {
                                MessageBox.Show("Class with this session already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (searchClassWithSessionAndVariant(classTitleDropDown.Text, sessionTitleTxtBox.Text, variantIde) == -1)
                                {
                                    try
                                    {
                                        int classID = searchClassWithSession(classTitleDropDown.Text, sessionTitleTxtBox.Text);
                                        int sectionID = getSectionID();

                                        //Code for data entry in Sql Database
                                        var con = SQL_Configuration.getInstance().getConnection();
                                        SqlCommand cmd = new SqlCommand("stpAddVariantToClass", con);
                                        cmd.CommandType = CommandType.StoredProcedure;
                                        cmd.Parameters.AddWithValue("@classId", classID);
                                        cmd.Parameters.AddWithValue("@VariantType", getVariantID(variantDropDown.Text));
                                        cmd.Parameters.AddWithValue("@sectionId", sectionID);

                                        SqlParameter RuturnValue = new SqlParameter("@variantId", SqlDbType.Int);
                                        RuturnValue.Direction = ParameterDirection.Output;
                                        cmd.Parameters.Add(RuturnValue);

                                        cmd.ExecuteNonQuery();
                                        int variantId = Convert.ToInt32(RuturnValue.Value.ToString());
                                        //End of Code for data entry in Sql Database

                                        Class_UC class_UC = new Class_UC(_parentForm);
                                        class_UC.ClassID = classID;
                                        class_UC.VariantID = variantId;
                                        class_UC.ClassName = classTitleDropDown.Text;
                                        class_UC.ClassSession = sessionTitleTxtBox.Text;
                                        class_UC.ClassVariant = variantDropDown.SelectedItem.ToString();

                                        Section_UC section_UC = new Section_UC(class_UC);
                                        section_UC.SectionId = sectionID;
                                        section_UC.SectionName = "Green";
                                        section_UC.SectionCapacity = 0;

                                        class_UC.sectionListObj.Add(section_UC);
                                        classListObj.Add(class_UC);

                                        HashSet<string> subjects = new HashSet<string>();
                                        for (int i = 0; i < this.Controls.Find("subjectsFlowPanel", true)[0].Controls.Count; i++)
                                        {
                                            // Get data from every control of subjectsFlowPanel
                                            var control = this.Controls.Find("subjectsFlowPanel", true)[0].Controls[i];
                                            var textBox = (Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox)control.Controls.Find("subjectTxtBox", true)[0];
                                            if (textBox.Text.Trim() != "")
                                            {
                                                subjects.Add(textBox.Text);

                                            }
                                            //Console.WriteLine(textBox.Text);
                                        }
                                        //Code for data entry in Sql Database
                                        if (subjects.Count > 0)
                                        {
                                            foreach (var subject in subjects)
                                            {
                                                var con2 = SQL_Configuration.getInstance().getConnection();
                                                SqlCommand cmd2 = new SqlCommand("stpInsertSubjectAndAssign", con2);
                                                cmd2.CommandType = CommandType.StoredProcedure;
                                                Console.WriteLine(subject);
                                                cmd2.Parameters.AddWithValue("@Title", subject);
                                                cmd2.Parameters.AddWithValue("@variantId", variantId);
                                                cmd2.ExecuteNonQuery();
                                            }
                                        }
                                        //End of Code for data entry in Sql Database

                                        class_UC.Width = _parentForm.Controls.Find("flowLayoutPanel1", true)[0].Width - 20;
                                        class_UC.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(section_UC);
                                        _parentForm.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(class_UC);
                                        this.Close();
                                    }
                                    catch (Exception abc)
                                    {
                                        MessageBox.Show("Something Wrong wit the input" + abc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Class Variant Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Session must be in between 2015 and 2050", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid session", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        // Edit Class Code here
        private void editClass_Click(object sender, EventArgs e)
        {
            if (classTitleDropDown.SelectedIndex == -1 || sessionTitleTxtBox.Text.Trim() == "" || variantDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int session = Convert.ToInt32(sessionTitleTxtBox.Text);
                    if (session > 2015 && session < 2050)
                    {
                        int variantId = getVariantID(variantDropDown.Text);
                        if (searchClassWithSessionAndVariant(classTitleDropDown.Text, sessionTitleTxtBox.Text, variantId) != -1)
                        {
                            MessageBox.Show("Class with this Session and Variant Already Exist!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                //int classID = searchClassWithSession(classTitleDropDown.Text, sessionTitleTxtBox.Text);
                                var con = SQL_Configuration.getInstance().getConnection();
                                SqlCommand cmd = new SqlCommand("stpEditClassPlusVariant", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@classId", _classId);
                                cmd.Parameters.AddWithValue("@Title", classTitleDropDown.Text);
                                cmd.Parameters.AddWithValue("@Session", sessionTitleTxtBox.Text);
                                cmd.Parameters.AddWithValue("@VariantType", getVariantID(variantDropDown.Text));
                                cmd.ExecuteNonQuery();

                                var obj = classListObj.Find(x => x.ClassID == _classId);
                                if (obj != null)
                                {
                                    obj.ClassName = classTitleDropDown.Text;
                                    obj.ClassSession = sessionTitleTxtBox.Text;
                                    obj.ClassVariant = variantDropDown.SelectedItem.ToString();
                                }

                                MessageBox.Show("Class Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Class updation failed \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Session must be in between 2015 and 2050", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid session", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAddSubjectToFlow_Click(object sender, EventArgs e)
        {
            subjectsFlowPanel.Controls.Add(new Subject_TxtBox_UC());
        }

        private void classTitleDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classTitleDropDown.Text.Equals("Pre-Nine", StringComparison.InvariantCultureIgnoreCase) || classTitleDropDown.Text.Equals("Nine", StringComparison.InvariantCultureIgnoreCase) || classTitleDropDown.Text.Equals("Ten", StringComparison.InvariantCultureIgnoreCase))
            {
                variantDropDown.Enabled = true;
            }
            else
            {
                variantDropDown.Enabled = false;
                variantDropDown.SelectedIndex = 0;
            }
        }

    }
}
