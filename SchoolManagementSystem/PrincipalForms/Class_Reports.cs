using CrystalDecisions.CrystalReports.Engine;
using SchoolManagementSystem.PrincipalForms.Reports;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem.PrincipalForms
{
    public partial class Class_Reports : Form
    {
        private int _check;
        public Class_Reports(int check)
        {
            InitializeComponent();
            _check = check;
        }
        public DataTable DtReport { get; set; }
        public string ReportName { get; set; }

        private void Class_Reports_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.SelectionMode = CrystalDecisions.Windows.Forms.SelectionMode.None;
            ReportDocument rd = new ReportDocument();
            if (_check == 0)
            {
                ClassesAndSectionsRPT cr = new ClassesAndSectionsRPT();
                cr.Load(this.ReportName);
                cr.SetDataSource(this.DtReport);
                crystalReportViewer1.ReportSource = cr;
            }
            else if (_check == 1)
            {
                FilteredClassesAndSectionsRPT cr = new FilteredClassesAndSectionsRPT();
                cr.Load(this.ReportName);
                cr.SetDataSource(this.DtReport);
                crystalReportViewer1.ReportSource = cr;
            }
            else if (_check == 2)
            {
                AllClassesAndSubjectsRPT cr = new AllClassesAndSubjectsRPT();
                cr.Load(this.ReportName);
                cr.SetDataSource(this.DtReport);
                crystalReportViewer1.ReportSource = cr;
            }
            else if (_check == 3)
            {
                FilteredSessionClassesAndSubjectsRPT cr = new FilteredSessionClassesAndSubjectsRPT();
                cr.Load(this.ReportName);
                cr.SetDataSource(this.DtReport);
                crystalReportViewer1.ReportSource = cr;
            }
            else if (_check == 4)
            {
                FilteredTeacherClassesAndSubjectsRPT cr = new FilteredTeacherClassesAndSubjectsRPT();
                cr.Load(this.ReportName);
                cr.SetDataSource(this.DtReport);
                crystalReportViewer1.ReportSource = cr;
            }
            else if (_check == 5)
            {
                FilteredSessionPlusTeacherClassesAndSubjectsRPT cr = new FilteredSessionPlusTeacherClassesAndSubjectsRPT();
                cr.Load(this.ReportName);
                cr.SetDataSource(this.DtReport);
                crystalReportViewer1.ReportSource = cr;
            }
        }
    }
}
