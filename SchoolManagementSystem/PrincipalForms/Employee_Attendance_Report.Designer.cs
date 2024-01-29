namespace SchoolManagementSystem.PrincipalForms
{
    partial class Employee_Attendance_Report
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Attendance_Report));
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filterRoleDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.loadAttendanceBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loadAttendanceBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(142, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(728, 49);
            this.label3.TabIndex = 22;
            this.label3.Text = "Employee Attendance Overview";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 50);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(998, 17);
            this.bunifuSeparator1.TabIndex = 23;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 10, 0, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 540);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // filterRoleDropDown
            // 
            this.filterRoleDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterRoleDropDown.BackColor = System.Drawing.Color.White;
            this.filterRoleDropDown.BorderRadius = 3;
            this.filterRoleDropDown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.filterRoleDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterRoleDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.filterRoleDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.filterRoleDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterRoleDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.filterRoleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterRoleDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.filterRoleDropDown.FillDropDown = false;
            this.filterRoleDropDown.FillIndicator = true;
            this.filterRoleDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterRoleDropDown.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterRoleDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.filterRoleDropDown.FormattingEnabled = true;
            this.filterRoleDropDown.Icon = null;
            this.filterRoleDropDown.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.filterRoleDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.filterRoleDropDown.ItemBackColor = System.Drawing.Color.White;
            this.filterRoleDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.filterRoleDropDown.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.filterRoleDropDown.ItemHeight = 40;
            this.filterRoleDropDown.ItemHighLightColor = System.Drawing.Color.Ivory;
            this.filterRoleDropDown.Location = new System.Drawing.Point(662, 67);
            this.filterRoleDropDown.Name = "filterRoleDropDown";
            this.filterRoleDropDown.Size = new System.Drawing.Size(343, 46);
            this.filterRoleDropDown.TabIndex = 43;
            this.filterRoleDropDown.Text = "--Select Role to Filter--";
            this.filterRoleDropDown.SelectedIndexChanged += new System.EventHandler(this.filterRoleDropDown_SelectedIndexChanged);
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BorderRadius = 5;
            this.bunifuDatePicker1.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuDatePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuDatePicker1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(7, 68);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(329, 45);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(329, 45);
            this.bunifuDatePicker1.TabIndex = 44;
            // 
            // loadAttendanceBtn
            // 
            this.loadAttendanceBtn.BackColor = System.Drawing.Color.Transparent;
            this.loadAttendanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadAttendanceBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadAttendanceBtn.Image")));
            this.loadAttendanceBtn.ImageActive = null;
            this.loadAttendanceBtn.Location = new System.Drawing.Point(342, 74);
            this.loadAttendanceBtn.Name = "loadAttendanceBtn";
            this.loadAttendanceBtn.Size = new System.Drawing.Size(40, 35);
            this.loadAttendanceBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadAttendanceBtn.TabIndex = 45;
            this.loadAttendanceBtn.TabStop = false;
            this.loadAttendanceBtn.Zoom = 10;
            this.loadAttendanceBtn.Click += new System.EventHandler(this.loadAttendanceBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Atrendance Overview";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadingPanel
            // 
            this.loadingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadingPanel.Controls.Add(this.pictureBox1);
            this.loadingPanel.Location = new System.Drawing.Point(-14, 125);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(1047, 636);
            this.loadingPanel.TabIndex = 46;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Employee_Attendance_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 678);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.loadAttendanceBtn);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Controls.Add(this.filterRoleDropDown);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "Employee_Attendance_Report";
            this.Text = "Employee_Attendance_Report";
            ((System.ComponentModel.ISupportInitialize)(this.loadAttendanceBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loadingPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuDropdown filterRoleDropDown;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Bunifu.Framework.UI.BunifuImageButton loadAttendanceBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Timer timer1;
    }
}