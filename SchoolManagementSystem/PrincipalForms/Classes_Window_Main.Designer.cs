namespace SchoolManagementSystem
{
    partial class Classes_Window_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classes_Window_Main));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.addClassBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshPageBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.filterSessionTxtBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.filterSessionBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.generateReportBtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.addClassBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterSessionBtn)).BeginInit();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Add / Create Class";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(297, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 49);
            this.label3.TabIndex = 17;
            this.label3.Text = "Classes && Sections";
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
            this.bunifuSeparator1.TabIndex = 19;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // addClassBtn
            // 
            this.addClassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addClassBtn.BackColor = System.Drawing.Color.Transparent;
            this.addClassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClassBtn.Image = ((System.Drawing.Image)(resources.GetObject("addClassBtn.Image")));
            this.addClassBtn.ImageActive = null;
            this.addClassBtn.Location = new System.Drawing.Point(965, 19);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(40, 35);
            this.addClassBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addClassBtn.TabIndex = 18;
            this.addClassBtn.TabStop = false;
            this.addClassBtn.Zoom = 10;
            this.addClassBtn.Click += new System.EventHandler(this.addClassBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1018, 604);
            this.flowLayoutPanel1.TabIndex = 20;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // refreshPageBtn
            // 
            this.refreshPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshPageBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshPageBtn.Image")));
            this.refreshPageBtn.ImageActive = null;
            this.refreshPageBtn.Location = new System.Drawing.Point(919, 19);
            this.refreshPageBtn.Name = "refreshPageBtn";
            this.refreshPageBtn.Size = new System.Drawing.Size(40, 35);
            this.refreshPageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshPageBtn.TabIndex = 21;
            this.refreshPageBtn.TabStop = false;
            this.refreshPageBtn.Zoom = 10;
            this.refreshPageBtn.Click += new System.EventHandler(this.refreshPageBtn_Click);
            // 
            // filterSessionTxtBox
            // 
            this.filterSessionTxtBox.AcceptsReturn = true;
            this.filterSessionTxtBox.AcceptsTab = false;
            this.filterSessionTxtBox.AnimationSpeed = 200;
            this.filterSessionTxtBox.AutoCompleteCustomSource.AddRange(new string[] {
            "2022-2023"});
            this.filterSessionTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.filterSessionTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.filterSessionTxtBox.BackColor = System.Drawing.Color.White;
            this.filterSessionTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filterSessionTxtBox.BackgroundImage")));
            this.filterSessionTxtBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.filterSessionTxtBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.filterSessionTxtBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.filterSessionTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.filterSessionTxtBox.BorderRadius = 15;
            this.filterSessionTxtBox.BorderThickness = 0;
            this.filterSessionTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.filterSessionTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterSessionTxtBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.filterSessionTxtBox.DefaultText = "";
            this.filterSessionTxtBox.FillColor = System.Drawing.Color.White;
            this.filterSessionTxtBox.HideSelection = true;
            this.filterSessionTxtBox.IconLeft = null;
            this.filterSessionTxtBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.filterSessionTxtBox.IconPadding = 10;
            this.filterSessionTxtBox.IconRight = null;
            this.filterSessionTxtBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.filterSessionTxtBox.Lines = new string[0];
            this.filterSessionTxtBox.Location = new System.Drawing.Point(7, 7);
            this.filterSessionTxtBox.MaxLength = 32767;
            this.filterSessionTxtBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.filterSessionTxtBox.Modified = false;
            this.filterSessionTxtBox.Multiline = false;
            this.filterSessionTxtBox.Name = "filterSessionTxtBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.filterSessionTxtBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.filterSessionTxtBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.filterSessionTxtBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.filterSessionTxtBox.OnIdleState = stateProperties4;
            this.filterSessionTxtBox.PasswordChar = '\0';
            this.filterSessionTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.filterSessionTxtBox.PlaceholderText = "Enter Session To Filter";
            this.filterSessionTxtBox.ReadOnly = false;
            this.filterSessionTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filterSessionTxtBox.SelectedText = "";
            this.filterSessionTxtBox.SelectionLength = 0;
            this.filterSessionTxtBox.SelectionStart = 0;
            this.filterSessionTxtBox.ShortcutsEnabled = true;
            this.filterSessionTxtBox.Size = new System.Drawing.Size(216, 47);
            this.filterSessionTxtBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.filterSessionTxtBox.TabIndex = 38;
            this.filterSessionTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.filterSessionTxtBox.TextMarginBottom = 0;
            this.filterSessionTxtBox.TextMarginLeft = -5;
            this.filterSessionTxtBox.TextMarginTop = 0;
            this.filterSessionTxtBox.TextPlaceholder = "Enter Session To Filter";
            this.filterSessionTxtBox.UseSystemPasswordChar = false;
            this.filterSessionTxtBox.WordWrap = true;
            this.filterSessionTxtBox.TextChanged += new System.EventHandler(this.filterSessionTxtBox_TextChanged);
            // 
            // filterSessionBtn
            // 
            this.filterSessionBtn.BackColor = System.Drawing.Color.Transparent;
            this.filterSessionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterSessionBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterSessionBtn.Image")));
            this.filterSessionBtn.ImageActive = null;
            this.filterSessionBtn.Location = new System.Drawing.Point(184, 16);
            this.filterSessionBtn.Name = "filterSessionBtn";
            this.filterSessionBtn.Size = new System.Drawing.Size(32, 28);
            this.filterSessionBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterSessionBtn.TabIndex = 39;
            this.filterSessionBtn.TabStop = false;
            this.filterSessionBtn.Zoom = 10;
            this.filterSessionBtn.Click += new System.EventHandler(this.filterSessionBtn_Click);
            // 
            // loadingPanel
            // 
            this.loadingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadingPanel.Controls.Add(this.pictureBox1);
            this.loadingPanel.Location = new System.Drawing.Point(-13, 67);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(1047, 636);
            this.loadingPanel.TabIndex = 40;
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
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.generateReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("generateReportBtn.Image")));
            this.generateReportBtn.ImageActive = null;
            this.generateReportBtn.Location = new System.Drawing.Point(873, 19);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(40, 35);
            this.generateReportBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.generateReportBtn.TabIndex = 41;
            this.generateReportBtn.TabStop = false;
            this.generateReportBtn.Zoom = 10;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
            // 
            // Classes_Window_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 678);
            this.Controls.Add(this.generateReportBtn);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.filterSessionBtn);
            this.Controls.Add(this.filterSessionTxtBox);
            this.Controls.Add(this.refreshPageBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.addClassBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "Classes_Window_Main";
            this.Text = "Classes_Window";
            this.SizeChanged += new System.EventHandler(this.Classes_Window_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.addClassBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterSessionBtn)).EndInit();
            this.loadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton addClassBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuImageButton refreshPageBtn;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox filterSessionTxtBox;
        private Bunifu.Framework.UI.BunifuImageButton filterSessionBtn;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton generateReportBtn;
    }
}