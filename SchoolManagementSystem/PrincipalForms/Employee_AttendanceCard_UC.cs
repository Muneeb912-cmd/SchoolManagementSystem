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
    public partial class Employee_AttendanceCard_UC : UserControl
    {
        public Employee_AttendanceCard_UC()
        {
            InitializeComponent();
        }

        private string _employeeName;
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value;
                lblEmployeeName.Text = _employeeName;
            }
        }
        
        private string _employeeRole;
        public string EmployeeRole
        {
            get { return _employeeRole; }
            set { _employeeRole = value;
                lblEmployeeRole.Text = _employeeRole;
            }
        }
        
        private string _attendanceMonth;
        public string AttendanceMonth
        {
            get { return _attendanceMonth; }
            set { _attendanceMonth = value;
                lblAttendanceMonth.Text = _attendanceMonth;
            }
        }
        
        private string _attendancePercentage;
        public string AttendancePercentage
        {
            get { return _attendancePercentage; }
            set { _attendancePercentage = value;
                lblAttendancePercentage.Text = _attendancePercentage+" %";
            }
        }
    }
}
