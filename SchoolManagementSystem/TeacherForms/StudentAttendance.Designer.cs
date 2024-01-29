namespace SchoolManagementSystem.TeacherForms
{
    partial class StudentAttendance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAttendance));
            this.Status = new Bunifu.Framework.UI.BunifuDropdown();
            this.name1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.rollno = new Bunifu.UI.WinForms.BunifuLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.BorderRadius = 3;
            this.Status.DisabledColor = System.Drawing.Color.Gray;
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.items = new string[] {
        "Present",
        "Absent",
        "Leave"};
            this.Status.Location = new System.Drawing.Point(529, 8);
            this.Status.Name = "Status";
            this.Status.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Status.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Status.selectedIndex = -1;
            this.Status.Size = new System.Drawing.Size(164, 33);
            this.Status.TabIndex = 15;
            this.Status.onItemSelected += new System.EventHandler(this.Status_onItemSelected);
            // 
            // name1
            // 
            this.name1.AutoEllipsis = false;
            this.name1.CursorType = null;
            this.name1.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.ForeColor = System.Drawing.Color.White;
            this.name1.Location = new System.Drawing.Point(167, 13);
            this.name1.Name = "name1";
            this.name1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name1.Size = new System.Drawing.Size(49, 23);
            this.name1.TabIndex = 13;
            this.name1.Text = "Name";
            this.name1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.name1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(477, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(434, 49);
            this.splitter3.TabIndex = 12;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(142, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(335, 49);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // rollno
            // 
            this.rollno.AutoEllipsis = false;
            this.rollno.CursorType = null;
            this.rollno.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollno.ForeColor = System.Drawing.Color.White;
            this.rollno.Location = new System.Drawing.Point(41, 13);
            this.rollno.Name = "rollno";
            this.rollno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rollno.Size = new System.Drawing.Size(61, 23);
            this.rollno.TabIndex = 9;
            this.rollno.Text = "Roll No";
            this.rollno.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.rollno.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(142, 49);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.Status);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.rollno);
            this.Controls.Add(this.splitter1);
            this.Name = "StudentAttendance";
            this.Size = new System.Drawing.Size(736, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown Status;
        private Bunifu.UI.WinForms.BunifuLabel name1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private Bunifu.UI.WinForms.BunifuLabel rollno;
        private System.Windows.Forms.Splitter splitter1;
    }
}
