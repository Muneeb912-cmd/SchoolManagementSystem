namespace SchoolManagementSystem.AdminForms
{
    partial class RecentAttendanceInfoCardLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecentAttendanceInfoCardLayout));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.name = new Bunifu.UI.WinForms.BunifuLabel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.Email = new Bunifu.UI.WinForms.BunifuLabel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.Designation = new Bunifu.UI.WinForms.BunifuLabel();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.Status = new Bunifu.Framework.UI.BunifuDropdown();
            this.Update = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(135, 49);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // name
            // 
            this.name.AutoEllipsis = false;
            this.name.CursorType = null;
            this.name.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(3, 13);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(49, 23);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            this.name.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.name.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(135, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(237, 49);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // Email
            // 
            this.Email.AutoEllipsis = false;
            this.Email.CursorType = null;
            this.Email.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(141, 16);
            this.Email.Name = "Email";
            this.Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Email.Size = new System.Drawing.Size(34, 16);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            this.Email.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Email.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(372, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(135, 49);
            this.splitter3.TabIndex = 4;
            this.splitter3.TabStop = false;
            // 
            // Designation
            // 
            this.Designation.AutoEllipsis = false;
            this.Designation.CursorType = null;
            this.Designation.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Designation.ForeColor = System.Drawing.Color.White;
            this.Designation.Location = new System.Drawing.Point(378, 13);
            this.Designation.Name = "Designation";
            this.Designation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Designation.Size = new System.Drawing.Size(94, 23);
            this.Designation.TabIndex = 5;
            this.Designation.Text = "Designation";
            this.Designation.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Designation.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(507, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(173, 49);
            this.splitter4.TabIndex = 6;
            this.splitter4.TabStop = false;
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
            this.Status.Location = new System.Drawing.Point(507, 3);
            this.Status.Name = "Status";
            this.Status.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Status.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Status.selectedIndex = -1;
            this.Status.Size = new System.Drawing.Size(164, 43);
            this.Status.TabIndex = 7;
            // 
            // Update
            // 
            this.Update.ActiveImage = null;
            this.Update.AllowAnimations = true;
            this.Update.AllowBuffering = false;
            this.Update.AllowZooming = true;
            this.Update.BackColor = System.Drawing.Color.Transparent;
            this.Update.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Update.ErrorImage")));
            this.Update.FadeWhenInactive = false;
            this.Update.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageActive = null;
            this.Update.ImageLocation = null;
            this.Update.ImageMargin = 10;
            this.Update.ImageSize = new System.Drawing.Size(40, 33);
            this.Update.ImageZoomSize = new System.Drawing.Size(50, 43);
            this.Update.InitialImage = ((System.Drawing.Image)(resources.GetObject("Update.InitialImage")));
            this.Update.Location = new System.Drawing.Point(745, 3);
            this.Update.Name = "Update";
            this.Update.Rotation = 0;
            this.Update.ShowActiveImage = true;
            this.Update.ShowCursorChanges = true;
            this.Update.ShowImageBorders = true;
            this.Update.ShowSizeMarkers = false;
            this.Update.Size = new System.Drawing.Size(50, 43);
            this.Update.TabIndex = 8;
            this.Update.ToolTipText = "";
            this.Update.WaitOnLoad = false;
            this.Update.Zoom = 10;
            this.Update.ZoomSpeed = 10;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // RecentAttendanceInfoCardLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.Designation);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.splitter1);
            this.Name = "RecentAttendanceInfoCardLayout";
            this.Size = new System.Drawing.Size(830, 49);
            this.Load += new System.EventHandler(this.RecentAttendanceInfoCardLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private Bunifu.UI.WinForms.BunifuLabel name;
        private System.Windows.Forms.Splitter splitter2;
        private Bunifu.UI.WinForms.BunifuLabel Email;
        private System.Windows.Forms.Splitter splitter3;
        private Bunifu.UI.WinForms.BunifuLabel Designation;
        private System.Windows.Forms.Splitter splitter4;
        private Bunifu.Framework.UI.BunifuDropdown Status;
        private Bunifu.UI.WinForms.BunifuImageButton Update;
    }
}
