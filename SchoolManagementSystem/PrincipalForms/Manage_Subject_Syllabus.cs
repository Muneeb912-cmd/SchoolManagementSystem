using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem.PrincipalForms
{
    public partial class Manage_Subject_Syllabus : Form
    {
        private Class_Subjects_UC _parent;

        private int _subjectId;
        private int _teacherId;

        public Manage_Subject_Syllabus(Class_Subjects_UC parent, int subjectId, string subjectTitle, string subjectSyllabus, string subjectTeacher, int teacherId)
        {
            InitializeComponent();
            populateTeacherComboBox();
            _parent = parent;
            if (subjectId != -1)
            {
                _subjectId = subjectId;
                _teacherId = teacherId;
                txtSubjectTitle.Text = subjectTitle;
                txtSubjectSyllabus.Text = subjectSyllabus;
                this.teacherDropDown.SelectedIndex = teacherDropDown.FindStringExact(subjectTeacher);
            }
        }

        private void populateTeacherComboBox()
        {
            string query = "EXEC	stpGetTeachers";
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                teacherDropDown.Items.Add(rd[0].ToString());
            }
            rd.Close();
        }
        private int getTeacherId(string text)
        {
            string fName = text.Split(' ')[0];
            string lName = text.Split(' ')[1];
            int teacherId = -1;
            string query = "Select EmployeeId From Employee e inner join Person p on e.EmployeeId = p.ID Where First_Name = '" + fName + "' And Last_Name = '" + lName + "' And e.Role = 14";
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                try { teacherId = Convert.ToInt32(rd[0].ToString()); }
                catch (Exception) { rd.Close(); return 0; }
            }
            rd.Close();
            //Console.WriteLine(teacherId);
            return teacherId;
        }
        private static List<Class_Subjects_UC> classSubjectList;
        public static List<Class_Subjects_UC> classSubjectListObj
        {
            get
            {
                if (classSubjectList == null)
                {
                    classSubjectList = new List<Class_Subjects_UC>();
                }
                return classSubjectList;
            }
        }
        private string _cardTitle;
        [Category("Card Title")]
        public string cardTitle
        {
            get { return _cardTitle; }
            set
            {
                _cardTitle = value;
                DialogTitle.Text = value;
            }
        }
        private void btnCloseCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSubject_Click(object sender, EventArgs e)
        {
            if (txtSubjectTitle.Text.Trim() == "" || txtSubjectSyllabus.Text.Trim() == "" || teacherDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int tacherID = getTeacherId(teacherDropDown.Text);
                    var con2 = SQL_Configuration.getInstance().getConnection();
                    SqlCommand cmd2 = new SqlCommand("stpInsertSubjectAndSyllabus", con2);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@variantId", _parent.VariantID);
                    cmd2.Parameters.AddWithValue("@Title", txtSubjectTitle.Text);
                    cmd2.Parameters.AddWithValue("@TeacherID", tacherID);
                    cmd2.Parameters.AddWithValue("@Description", txtSubjectSyllabus.Text);

                    SqlParameter RuturnValue = new SqlParameter("@subjectId", SqlDbType.Int);
                    RuturnValue.Direction = ParameterDirection.Output;
                    cmd2.Parameters.Add(RuturnValue);

                    cmd2.ExecuteNonQuery();
                    _subjectId = Convert.ToInt32(RuturnValue.Value.ToString());

                    Subject_UC subject = new Subject_UC(_parent);
                    subject.SubjectId = _subjectId;
                    subject.SubjectName = txtSubjectTitle.Text;
                    subject.Syllabus = txtSubjectSyllabus.Text;
                    subject.TeacherName = teacherDropDown.Text;
                    subject.TeacherId = tacherID;
                    _parent.subjectListObj.Add(subject);
                    _parent.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(subject);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void editSubject_Click(object sender, EventArgs e)
        {
            if (txtSubjectTitle.Text.Trim() == "" )
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int tacherID = -1;
                    var con2 = SQL_Configuration.getInstance().getConnection();
                    SqlCommand cmd2 = new SqlCommand("stpEditSubjectAndSyllabus", con2);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@subjectId", _subjectId);
                    cmd2.Parameters.AddWithValue("@Title", txtSubjectTitle.Text);
                    if (teacherDropDown.SelectedIndex == -1)
                    {
                        cmd2.Parameters.AddWithValue("@TeacherID", DBNull.Value);
                    }
                    else
                    {
                        tacherID = getTeacherId(teacherDropDown.Text);
                        cmd2.Parameters.AddWithValue("@TeacherID", tacherID);
                    }

                    cmd2.Parameters.AddWithValue("@Description", txtSubjectSyllabus.Text.Trim());

                    cmd2.ExecuteNonQuery();

                    var obj = _parent.subjectListObj.Find(x => x.SubjectId == _subjectId);
                    if (obj != null)
                    {
                        obj.SubjectName = txtSubjectTitle.Text;
                        obj.Syllabus = txtSubjectSyllabus.Text;
                        obj.TeacherName = teacherDropDown.Text;
                        obj.TeacherId = tacherID;
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
