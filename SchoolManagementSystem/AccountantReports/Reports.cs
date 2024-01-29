using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.AccountantReports
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        public DataTable dtReport { get; set; }
        public string ReportName { get; set; }
        private void Reports_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.SelectionMode = CrystalDecisions.Windows.Forms.SelectionMode.None;
            ReportDocument rd = new ReportDocument();
            FeeReport cr = new FeeReport();

            cr.Load(this.ReportName);
            cr.SetDataSource(this.dtReport);
            cr.SetParameterValue("role", "             The Brain Train School \n Students Who Haven't Paid Fees Yet");
            crystalReportViewer1.ReportSource = cr;  
        }
    }
}
