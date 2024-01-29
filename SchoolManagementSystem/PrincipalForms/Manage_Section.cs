using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Manage_Section : Form
    {
        private Class_UC _parent;
        private int _sectionID;
        private string _sectionTitle;
        private int _studentCapacity;
        public Manage_Section(Class_UC parent, int sectionID, string sectionTitle, int studentCapacity)
        {
            InitializeComponent();
            if (sectionID != -1)
            {
                _sectionID = sectionID;
                _sectionTitle = sectionTitle;
                _studentCapacity = studentCapacity;
                sectionTitleTxtBox.Text = sectionTitle;
                studentCapacityTxtBox.Text = studentCapacity.ToString();
            }
            _parent = parent;
            Console.WriteLine(_parent.VariantID.ToString());
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

        private void addSection_Click(object sender, EventArgs e)
        {
            if (sectionTitleTxtBox.Text.Trim() == "" || studentCapacityTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(studentCapacityTxtBox.Text) <= 50 && Convert.ToInt32(studentCapacityTxtBox.Text) >= 20)
                    {
                        int sectionID = getSectionID();
                        Section_UC sectionUC = new Section_UC(_parent);
                        sectionUC.SectionId = sectionID;
                        sectionUC.SectionName = sectionTitleTxtBox.Text;
                        sectionUC.SectionCapacity = Convert.ToInt32(studentCapacityTxtBox.Text);
                        _parent.sectionListObj.Add(sectionUC);

                        //Code for data entry in Sql Database
                        var con = SQL_Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("stpInsertSection", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sectionId", sectionID);
                        cmd.Parameters.AddWithValue("@VId", _parent.VariantID);
                        cmd.Parameters.AddWithValue("@SectionTitle", sectionTitleTxtBox.Text);
                        cmd.Parameters.AddWithValue("@StudentCapacity", Convert.ToInt32(studentCapacityTxtBox.Text));
                        cmd.ExecuteNonQuery();
                        _parent.Controls.Find("flowLayoutPanel1", true)[0].Controls.Add(sectionUC);
                        this.Close();
                    }
                    else { MessageBox.Show("Student Capacity should be in between 20 - 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch (Exception) { MessageBox.Show("Section Already exist with this Title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        }

        private void btnCloseCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editSection_Click(object sender, EventArgs e)
        {
            if (sectionTitleTxtBox.Text.Trim() == "" || studentCapacityTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(studentCapacityTxtBox.Text) <= 50 && Convert.ToInt32(studentCapacityTxtBox.Text) >= 20)
                    {
                        //int sectionID = getSectionID();
                        var obj = _parent.sectionListObj.Find(x => x.SectionId == _sectionID);
                        if (obj != null)
                        {
                            obj.SectionName = sectionTitleTxtBox.Text;
                            obj.SectionCapacity = Convert.ToInt32(studentCapacityTxtBox.Text);
                        }

                        //Code for data entry in Sql Database
                        var con = SQL_Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("stpEditSection", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sectionId", _sectionID);
                        cmd.Parameters.AddWithValue("@SectionTitle", sectionTitleTxtBox.Text);
                        cmd.Parameters.AddWithValue("@StudentCapacity", Convert.ToInt32(studentCapacityTxtBox.Text));
                        cmd.ExecuteNonQuery();
                        this.Close();
                    }
                    else { MessageBox.Show("Student Capacity should be in between 20 - 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch (Exception) { MessageBox.Show("Section Already exist with this Title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
