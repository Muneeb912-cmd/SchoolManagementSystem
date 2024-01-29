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
    public partial class Subject_TxtBox_UC : UserControl
    {
        public Subject_TxtBox_UC()
        {
            InitializeComponent();
        }

        private void btnRemoveTxtBox_Click(object sender, EventArgs e)
        {
            if (this.Parent.Controls.Count >= 1)
            {
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
