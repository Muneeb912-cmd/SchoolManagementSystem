namespace SchoolManagementSystem.TeacherForms
{
    partial class Class_Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class_Attendance));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.StudentClass = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Save = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.session = new Bunifu.Framework.UI.BunifuDropdown();
            this.section = new Bunifu.Framework.UI.BunifuDropdown();
            this.varriant = new Bunifu.Framework.UI.BunifuDropdown();
            this.DisplayStudents = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(230, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 39);
            this.label3.TabIndex = 83;
            this.label3.Text = "Class Attendance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(5, 41);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(748, 14);
            this.bunifuSeparator1.TabIndex = 84;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // StudentClass
            // 
            this.StudentClass.AcceptsReturn = false;
            this.StudentClass.AcceptsTab = false;
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
            this.StudentClass.Location = new System.Drawing.Point(5, 61);
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
            this.StudentClass.PlaceholderText = "Enter text";
            this.StudentClass.ReadOnly = false;
            this.StudentClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StudentClass.SelectedText = "";
            this.StudentClass.SelectionLength = 0;
            this.StudentClass.SelectionStart = 0;
            this.StudentClass.ShortcutsEnabled = true;
            this.StudentClass.Size = new System.Drawing.Size(111, 35);
            this.StudentClass.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.StudentClass.TabIndex = 92;
            this.StudentClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StudentClass.TextMarginBottom = 0;
            this.StudentClass.TextMarginLeft = 5;
            this.StudentClass.TextMarginTop = 0;
            this.StudentClass.TextPlaceholder = "Enter text";
            this.StudentClass.UseSystemPasswordChar = false;
            this.StudentClass.WordWrap = true;
            this.StudentClass.TextChange += new System.EventHandler(this.bunifuTextBox1_TextChange);
            // 
            // Save
            // 
            this.Save.AllowToggling = false;
            this.Save.AnimationSpeed = 200;
            this.Save.AutoGenerateColors = false;
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Save.ButtonText = "Save";
            this.Save.ButtonTextMarginLeft = 0;
            this.Save.ColorContrastOnClick = 45;
            this.Save.ColorContrastOnHover = 45;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Save.CustomizableEdges = borderEdges1;
            this.Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Save.DisabledBorderColor = System.Drawing.Color.Empty;
            this.Save.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Save.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Save.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Save.IconMarginLeft = 11;
            this.Save.IconPadding = 10;
            this.Save.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Save.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Save.IdleBorderRadius = 3;
            this.Save.IdleBorderThickness = 1;
            this.Save.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Save.IdleIconLeftImage = null;
            this.Save.IdleIconRightImage = null;
            this.Save.IndicateFocus = false;
            this.Save.Location = new System.Drawing.Point(666, 81);
            this.Save.Name = "Save";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.Save.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.Save.OnPressedState = stateProperties6;
            this.Save.Size = new System.Drawing.Size(86, 29);
            this.Save.TabIndex = 93;
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.TextMarginLeft = 0;
            this.Save.UseDefaultRadiusAndThickness = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // session
            // 
            this.session.BackColor = System.Drawing.Color.Transparent;
            this.session.BorderRadius = 3;
            this.session.DisabledColor = System.Drawing.Color.Gray;
            this.session.ForeColor = System.Drawing.Color.White;
            this.session.items = new string[0];
            this.session.Location = new System.Drawing.Point(142, 61);
            this.session.Name = "session";
            this.session.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.session.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.session.selectedIndex = -1;
            this.session.Size = new System.Drawing.Size(126, 35);
            this.session.TabIndex = 94;
            this.session.onItemSelected += new System.EventHandler(this.session_onItemSelected);
            // 
            // section
            // 
            this.section.BackColor = System.Drawing.Color.Transparent;
            this.section.BorderRadius = 3;
            this.section.DisabledColor = System.Drawing.Color.Gray;
            this.section.ForeColor = System.Drawing.Color.White;
            this.section.items = new string[0];
            this.section.Location = new System.Drawing.Point(456, 61);
            this.section.Name = "section";
            this.section.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.section.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.section.selectedIndex = -1;
            this.section.Size = new System.Drawing.Size(126, 35);
            this.section.TabIndex = 95;
            this.section.onItemSelected += new System.EventHandler(this.section_onItemSelected);
            // 
            // varriant
            // 
            this.varriant.BackColor = System.Drawing.Color.Transparent;
            this.varriant.BorderRadius = 3;
            this.varriant.DisabledColor = System.Drawing.Color.Gray;
            this.varriant.ForeColor = System.Drawing.Color.White;
            this.varriant.items = new string[0];
            this.varriant.Location = new System.Drawing.Point(299, 61);
            this.varriant.Name = "varriant";
            this.varriant.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.varriant.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.varriant.selectedIndex = -1;
            this.varriant.Size = new System.Drawing.Size(126, 35);
            this.varriant.TabIndex = 96;
            this.varriant.onItemSelected += new System.EventHandler(this.varriant_onItemSelected);
            // 
            // DisplayStudents
            // 
            this.DisplayStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayStudents.Location = new System.Drawing.Point(5, 114);
            this.DisplayStudents.Name = "DisplayStudents";
            this.DisplayStudents.Size = new System.Drawing.Size(747, 425);
            this.DisplayStudents.TabIndex = 97;
            // 
            // Class_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 551);
            this.Controls.Add(this.DisplayStudents);
            this.Controls.Add(this.varriant);
            this.Controls.Add(this.section);
            this.Controls.Add(this.session);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.StudentClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Class_Attendance";
            this.Text = "Class_Attendance";
            this.Load += new System.EventHandler(this.Class_Attendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox StudentClass;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Save;
        private Bunifu.Framework.UI.BunifuDropdown session;
        private Bunifu.Framework.UI.BunifuDropdown section;
        private Bunifu.Framework.UI.BunifuDropdown varriant;
        private System.Windows.Forms.FlowLayoutPanel DisplayStudents;
    }
}