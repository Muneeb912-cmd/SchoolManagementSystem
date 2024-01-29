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
    public partial class Section_UC : UserControl
    {
        private Class_UC _parent;
        public Section_UC(Class_UC parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        
        private int _sectionId;
        public int SectionId
        {
            get { return _sectionId; }
            set { _sectionId = value; }
        }
        
        private string _sectionName;
        public string SectionName
        {
            get { return _sectionName; }
            set { _sectionName = value;
                label1.Text = value;
            }
        }

        private int _sectionCapacity;
        public int SectionCapacity
        {
            get { return _sectionCapacity; }
            set
            {
                _sectionCapacity = value;
                label3.Text = value.ToString();
            }
        }

        private void btnEditSection_Click(object sender, EventArgs e)
        {
            Manage_Section manageSection = new Manage_Section(_parent, SectionId, SectionName, SectionCapacity);
            manageSection.cardTitle = "Edit Section";
            manageSection.Controls.Find("editSection", true)[0].BringToFront();
            manageSection.ShowDialog();
        }

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            if (this.Parent.Controls.Count > 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this section?", "Delete Section", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var con = SQL_Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("stpDeleteSection", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SectionId", SectionId);
                    cmd.ExecuteNonQuery();

                    _parent.sectionListObj.Remove(this);
                    
                    this.Parent.Controls.Remove(this);
                }
            }
            else { MessageBox.Show("You cannot delete the last section.", "Delete Section", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
