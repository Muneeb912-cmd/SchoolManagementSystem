namespace SchoolManagementSystem.AdminForms
{
    partial class UnAssignedStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnAssignedStudents));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.roll = new Bunifu.UI.WinForms.BunifuLabel();
            this.name = new Bunifu.UI.WinForms.BunifuLabel();
            this.session = new Bunifu.Framework.UI.BunifuDropdown();
            this.varriant = new Bunifu.Framework.UI.BunifuDropdown();
            this.section = new Bunifu.Framework.UI.BunifuDropdown();
            this.StudentClass = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Update = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(144, 67);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(144, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(243, 67);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // roll
            // 
            this.roll.AutoEllipsis = false;
            this.roll.CursorType = null;
            this.roll.Font = new System.Drawing.Font("Garamond", 14.25F);
            this.roll.ForeColor = System.Drawing.Color.White;
            this.roll.Location = new System.Drawing.Point(3, 22);
            this.roll.Name = "roll";
            this.roll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roll.Size = new System.Drawing.Size(100, 23);
            this.roll.TabIndex = 2;
            this.roll.Text = "bunifuLabel1";
            this.roll.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.roll.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // name
            // 
            this.name.AutoEllipsis = false;
            this.name.CursorType = null;
            this.name.Font = new System.Drawing.Font("Garamond", 14.25F);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(150, 22);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(100, 23);
            this.name.TabIndex = 3;
            this.name.Text = "bunifuLabel2";
            this.name.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.name.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // session
            // 
            this.session.BackColor = System.Drawing.Color.Transparent;
            this.session.BorderRadius = 3;
            this.session.DisabledColor = System.Drawing.Color.Gray;
            this.session.ForeColor = System.Drawing.Color.White;
            this.session.items = new string[0];
            this.session.Location = new System.Drawing.Point(512, 16);
            this.session.Name = "session";
            this.session.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.session.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.session.selectedIndex = -1;
            this.session.Size = new System.Drawing.Size(95, 35);
            this.session.TabIndex = 6;
            this.session.onItemSelected += new System.EventHandler(this.session_onItemSelected);
            // 
            // varriant
            // 
            this.varriant.BackColor = System.Drawing.Color.Transparent;
            this.varriant.BorderRadius = 3;
            this.varriant.DisabledColor = System.Drawing.Color.Gray;
            this.varriant.ForeColor = System.Drawing.Color.White;
            this.varriant.items = new string[0];
            this.varriant.Location = new System.Drawing.Point(631, 16);
            this.varriant.Name = "varriant";
            this.varriant.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.varriant.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.varriant.selectedIndex = -1;
            this.varriant.Size = new System.Drawing.Size(95, 35);
            this.varriant.TabIndex = 7;
            this.varriant.onItemSelected += new System.EventHandler(this.varriant_onItemSelected);
            // 
            // section
            // 
            this.section.BackColor = System.Drawing.Color.Transparent;
            this.section.BorderRadius = 3;
            this.section.DisabledColor = System.Drawing.Color.Gray;
            this.section.ForeColor = System.Drawing.Color.White;
            this.section.items = new string[0];
            this.section.Location = new System.Drawing.Point(750, 16);
            this.section.Name = "section";
            this.section.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.section.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.section.selectedIndex = -1;
            this.section.Size = new System.Drawing.Size(95, 35);
            this.section.TabIndex = 8;
            // 
            // StudentClass
            // 
            this.StudentClass.AcceptsReturn = false;
            this.StudentClass.AcceptsTab = false;
            this.StudentClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StudentClass.AnimationSpeed = 200;
            this.StudentClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.StudentClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.StudentClass.BackColor = System.Drawing.Color.Transparent;
            this.StudentClass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StudentClass.BackgroundImage")));
            this.StudentClass.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.StudentClass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.StudentClass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.StudentClass.BorderColorIdle = System.Drawing.Color.Silver;
            this.StudentClass.BorderRadius = 1;
            this.StudentClass.BorderThickness = 1;
            this.StudentClass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.StudentClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentClass.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.StudentClass.DefaultText = "";
            this.StudentClass.FillColor = System.Drawing.Color.White;
            this.StudentClass.HideSelection = true;
            this.StudentClass.IconLeft = null;
            this.StudentClass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentClass.IconPadding = 10;
            this.StudentClass.IconRight = null;
            this.StudentClass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentClass.Lines = new string[0];
            this.StudentClass.Location = new System.Drawing.Point(393, 16);
            this.StudentClass.MaxLength = 32767;
            this.StudentClass.MinimumSize = new System.Drawing.Size(100, 35);
            this.StudentClass.Modified = false;
            this.StudentClass.Multiline = false;
            this.StudentClass.Name = "StudentClass";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.StudentClass.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.StudentClass.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.StudentClass.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.StudentClass.OnIdleState = stateProperties4;
            this.StudentClass.PasswordChar = '\0';
            this.StudentClass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.StudentClass.PlaceholderText = "Enter Class";
            this.StudentClass.ReadOnly = false;
            this.StudentClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StudentClass.SelectedText = "";
            this.StudentClass.SelectionLength = 0;
            this.StudentClass.SelectionStart = 0;
            this.StudentClass.ShortcutsEnabled = true;
            this.StudentClass.Size = new System.Drawing.Size(101, 35);
            this.StudentClass.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.StudentClass.TabIndex = 80;
            this.StudentClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StudentClass.TextMarginBottom = 0;
            this.StudentClass.TextMarginLeft = 5;
            this.StudentClass.TextMarginTop = 0;
            this.StudentClass.TextPlaceholder = "Enter Class";
            this.StudentClass.UseSystemPasswordChar = false;
            this.StudentClass.WordWrap = true;
            this.StudentClass.TextChange += new System.EventHandler(this.StudentClass_TextChange);
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
            this.Update.Location = new System.Drawing.Point(911, 12);
            this.Update.Name = "Update";
            this.Update.Rotation = 0;
            this.Update.ShowActiveImage = true;
            this.Update.ShowCursorChanges = true;
            this.Update.ShowImageBorders = true;
            this.Update.ShowSizeMarkers = false;
            this.Update.Size = new System.Drawing.Size(50, 43);
            this.Update.TabIndex = 81;
            this.Update.ToolTipText = "";
            this.Update.WaitOnLoad = false;
            this.Update.Zoom = 10;
            this.Update.ZoomSpeed = 10;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // UnAssignedStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.Update);
            this.Controls.Add(this.StudentClass);
            this.Controls.Add(this.section);
            this.Controls.Add(this.varriant);
            this.Controls.Add(this.session);
            this.Controls.Add(this.name);
            this.Controls.Add(this.roll);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Name = "UnAssignedStudents";
            this.Size = new System.Drawing.Size(981, 67);
            this.Load += new System.EventHandler(this.UnAssignedStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private Bunifu.UI.WinForms.BunifuLabel roll;
        private Bunifu.UI.WinForms.BunifuLabel name;
        private Bunifu.Framework.UI.BunifuDropdown session;
        private Bunifu.Framework.UI.BunifuDropdown varriant;
        private Bunifu.Framework.UI.BunifuDropdown section;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox StudentClass;
        private Bunifu.UI.WinForms.BunifuImageButton Update;
    }
}
