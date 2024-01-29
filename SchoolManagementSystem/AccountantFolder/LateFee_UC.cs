using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class LateFee_UC : UserControl
    {
        private Accountants _parent;
        public LateFee_UC(Accountants parent, string clas,int total,int not,string Sess)
        {
            InitializeComponent();
            PopulateInfo(clas,total,not,Sess);
            _parent = parent;
        }

        public void PopulateInfo(string clas,int total,int not,string Sess)
        {
            ClassTextBox.Text = clas;
            TotalStudentss.Text = total.ToString();
            NotPaidYet.Text=not.ToString();
            SessionBOx.Text= Sess;  
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuPages bunifuPages1 = (Bunifu.UI.WinForms.BunifuPages)Parent.Parent.Parent;
            _parent.FeeTable(ClassTextBox.Text, SessionBOx.Text);
            bunifuPages1.SetPage("Table");

        }
    }
}
