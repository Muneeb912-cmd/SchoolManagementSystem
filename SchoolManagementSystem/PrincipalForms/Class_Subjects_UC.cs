using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.PrincipalForms
{
    public partial class Class_Subjects_UC : UserControl
    {
        private static Subjects_Window_Main _Parent;
        public Class_Subjects_UC(Subjects_Window_Main Parent)
        {
            InitializeComponent();
            _Parent = Parent;
        }
        
        private List<Subject_UC> subjectList;
        public List<Subject_UC> subjectListObj
        {
            get
            {
                if (subjectList == null)
                {
                    subjectList = new List<Subject_UC>();
                }
                return subjectList;
            }
        }
        private int _classID;
        [Category("Class ID")]
        public int ClassID
        {
            get { return _classID; }
            set { _classID = value; }
        }
        
        private int _variantID;
        [Category("Variant ID")]
        public int VariantID
        {
            get { return _variantID; }
            set { _variantID = value; }
        }
        
        private string _className;
        [Category("Class Name")]
        public string ClassName
        {
            get { return _className; }
            set
            {
                _className = value;
                lblClassName.Text = value;
            }
        }

        private string _classVariant;
        [Category("Class Variant")]
        public string ClassVariant
        {
            get { return _classVariant; }
            set
            {
                _classVariant = value;
                lblClassVariant.Text = value;
            }
        }

        private string _classSession;
        [Category("Class Session")]
        public string ClassSession
        {
            get { return _classSession; }
            set
            {
                _classSession = value;
                label2.Text = value;
            }
        }
        
        private void btnAddSection_Click(object sender, EventArgs e)
        {
            Manage_Subject_Syllabus manage_Subject_Syllabus = new Manage_Subject_Syllabus(this, -1,"","","",-1);
            manage_Subject_Syllabus.cardTitle = "Add Subject";
            manage_Subject_Syllabus.ShowDialog();
        }
    }
}
