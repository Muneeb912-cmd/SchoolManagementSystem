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
    public partial class Salary_UC : UserControl
    {
        private Accountants _parent;
        public Salary_UC(Accountants parent, string role, int total, int paid)
        {
            InitializeComponent();
            PopulateInfo(role, total, paid);
            _parent = parent;
        }
        public void PopulateInfo(string role, int total, int paid)
        {
            EmployeeRole.Text = role;
            TotalEmployees.Text = total.ToString();
            SalaryPaid.Text = paid.ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuPages bunifuPages1 = (Bunifu.UI.WinForms.BunifuPages)Parent.Parent.Parent;
            _parent.SalaryTable(EmployeeRole.Text);
            bunifuPages1.SetPage("SalaryTable");
        }
    }
}
