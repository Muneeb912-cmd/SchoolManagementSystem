using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem.PrincipalForms
{
    public partial class Subject_UC : UserControl
    {
        private Class_Subjects_UC _parent;
        public Subject_UC(Class_Subjects_UC parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private int _subjectId;
        public int SubjectId
        {
            get { return _subjectId; }
            set { _subjectId = value; }
        }

        private int _teacherId;
        public int TeacherId
        {
            get { return _teacherId; }
            set { _teacherId = value; }
        }

        private string _subjectName;
        public string SubjectName
        {
            get { return _subjectName; }
            set
            {
                _subjectName = value;
                lblSubjectTitle.Text = value;
            }
        }

        private string _syllabus;
        public string Syllabus
        {
            get { return _syllabus; }
            set
            {
                _syllabus = value;
                lblSyllabus.Text = value;
            }
        }

        private string _teacherName;
        public string TeacherName
        {
            get { return _teacherName; }
            set
            {
                _teacherName = value;
                lblTeacherName.Text = value;
            }
        }

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this subject?", "Delete Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var con = SQL_Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("stpDeleteSubject", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@subjectId", SubjectId);
                    cmd.ExecuteNonQuery();

                    _parent.subjectListObj.Remove(this);

                    this.Parent.Controls.Remove(this);
                    MessageBox.Show("Subject successfully Deleted.", "Delete Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Subject deletion Failed.", "Delete Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ////_parent.DeleteSubject(this);
                //_parent.Controls.Remove(this);
                //this.Dispose();
            }
        }

        private void btnEditSection_Click(object sender, EventArgs e)
        {
            Manage_Subject_Syllabus manage_Subject_Syllabus = new Manage_Subject_Syllabus(_parent, _subjectId, SubjectName, Syllabus, TeacherName, TeacherId);
            manage_Subject_Syllabus.cardTitle = "Edit Subject";
            manage_Subject_Syllabus.Controls.Find("editSubject", true)[0].BringToFront();
            manage_Subject_Syllabus.ShowDialog();
        }
    }
}
