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
    public partial class TimeTabel : UserControl
    {
        public TimeTabel()
        {
            InitializeComponent();
        }

        private void NewtimeTable_Click(object sender, EventArgs e)
        {
            AddTimeTabe.Controls.Add(new AddTimeTable());
        }

        private void TimeTabel_Load(object sender, EventArgs e)
        {
            AddTimeTabe.Controls.Add(new AddTimeTable());
            AddTimeTabe.Controls.Find("AddTimeTable", false).First().Dock = DockStyle.Fill;
        }
    }
}
