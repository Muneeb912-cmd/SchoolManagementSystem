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

namespace SchoolManagementSystem
{
    public partial class Class_UC : UserControl
    {
        private Classes_Window_Main _parentForm;
        public Class_UC(Classes_Window_Main _parent)
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.btnAddSection, "Click to add a new section");
            toolTip1.SetToolTip(this.btnEditClass, "Click to edit class");
            toolTip1.SetToolTip(this.btnDeleteClass, "Click to delete class");
            _parentForm = _parent;
        }
        
        private  List<Section_UC> sectionList;
        public  List<Section_UC> sectionListObj
        {
            get
            {
                if (sectionList == null)
                {
                    sectionList = new List<Section_UC>();
                }
                return sectionList;
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
            set { _className = value;
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

        private int checkClassCount(int classID)
        {
            int count = 0;
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ClassVariants WHERE CID = @class_id and isDeleted = 0", con);
            cmd.Parameters.AddWithValue("@class_id", classID);
            count = (int)cmd.ExecuteScalar();
            return count;
        }
        private void btnAddSection_Click(object sender, EventArgs e)
        {
            Manage_Section manage_Section = new Manage_Section(this, -1, "",0);
            manage_Section.cardTitle = "Add Section";
            manage_Section.ShowDialog();
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            Manage_Class manageClass = new Manage_Class(_parentForm, ClassID, VariantID, ClassVariant, ClassName, ClassSession);
            manageClass.pageTitle = "Edit Class";
            manageClass.Controls.Find("editClass", true)[0].BringToFront();
            manageClass.Controls.Find("addClass", true)[0].BackColor = Color.Transparent;
            manageClass.Controls.Find("closeBtn", true)[0].BackColor = Color.Transparent;
            manageClass.Controls.Find("editClass", true)[0].BackColor = Color.Transparent;
            manageClass.Controls.Find("editClass", true)[0].Location = new Point(360, 300);
            manageClass.Controls.Find("closeBtn", true)[0].Location = new Point(475, 300);
            manageClass.Controls.Find("bunifuCustomLabel4", true)[0].Visible = false;
            manageClass.Controls.Find("subjectsFlowPanel", true)[0].Visible = false;
            manageClass.Controls.Find("btnAddSubjectToFlow", true)[0].Visible = false;
            manageClass.Height = 350;
            manageClass.ShowDialog();
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this class?", "Delete Class", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Console.WriteLine(checkClassCount(ClassID));
                if (checkClassCount(ClassID) > 1)
                {
                    var con = SQL_Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("stpDeleteClassVariant", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VariantId", VariantID);
                    cmd.ExecuteNonQuery();

                    Manage_Class.classListObj.Remove(this);

                    _parentForm.Controls.Remove(this);
                    this.Dispose();
                }
                else
                {
                    //MessageBox.Show("You cannot delete this class because it has sections. Please delete all sections first.", "Delete Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    var con = SQL_Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("stpDeleteClass", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@classId", ClassID);
                    cmd.ExecuteNonQuery();

                    Manage_Class.classListObj.Remove(this);

                    _parentForm.Controls.Remove(this);
                    this.Dispose();
                }

                //Classes.DeleteClass(ClassID);
                //_parentForm.LoadClasses();
            }
        }
    }
}
