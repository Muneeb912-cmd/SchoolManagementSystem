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
    public partial class Challan_UC : UserControl
    {
        public Challan_UC(string Clas,int sess, int Section, int total)
        {
            InitializeComponent();
            PopulateInfo(Clas,sess, Section, total);
        }
        public void PopulateInfo(string Clas,int sess, int Section, int total)
        {
            clas.Text = Clas;
            Sections.Text = Section.ToString();
            TotalStudents.Text = total.ToString();
            Session.Text = sess.ToString();
        }
    }
}
