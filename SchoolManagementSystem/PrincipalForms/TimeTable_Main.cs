using BunifuAnimatorNS;
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
    public partial class TimeTable_Main : Form
    {
        public TimeTable_Main()
        {
            InitializeComponent();
        }

        private void TimeTable_Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            BunifuTransition transition = new BunifuTransition();
            transition.ShowSync(pictureBox2, false,BunifuAnimatorNS.Animation.Particles);
            transition.MaxAnimationTime = 400;
            panel1.Controls.Add(new TimeTabel());
            panel1.Controls.Find("TimeTabel", false).First().Dock = DockStyle.Fill;
            timer2.Start();
        }


        //private void tabPage1_MouseHover(object sender, EventArgs e)
        //{
        //    bunifuPages1.SetPage("tabPage2");
        //}

        //private void tabPage2_MouseHover(object sender, EventArgs e)
        //{
        //    bunifuPages1.SetPage("tabPage1");
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            BunifuTransition transition = new BunifuTransition();
            transition.HideSync(pictureBox2, false, BunifuAnimatorNS.Animation.Particles);
            transition.MaxAnimationTime = 500;
            loadingPanel.Visible = false;
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage2");
        }

    }
}
