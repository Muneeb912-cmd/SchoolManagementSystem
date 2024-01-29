namespace SchoolManagementSystem.AdminForms
{
    partial class UpdateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployee));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PostalAdress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Browse = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PicturePath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateOFBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Gender = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Contact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.FirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Cancel1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.PostalAdress);
            this.panel1.Controls.Add(this.Browse);
            this.panel1.Controls.Add(this.PicturePath);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DateOFBirth);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Contact);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.Cancel1);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 646);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(55, 348);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(109, 22);
            this.bunifuCustomLabel7.TabIndex = 85;
            this.bunifuCustomLabel7.Text = "Postal Adress";
            // 
            // PostalAdress
            // 
            this.PostalAdress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PostalAdress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PostalAdress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PostalAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PostalAdress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PostalAdress.HintForeColor = System.Drawing.Color.Empty;
            this.PostalAdress.HintText = "";
            this.PostalAdress.isPassword = false;
            this.PostalAdress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.PostalAdress.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.PostalAdress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.PostalAdress.LineThickness = 3;
            this.PostalAdress.Location = new System.Drawing.Point(172, 335);
            this.PostalAdress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PostalAdress.MaxLength = 32767;
            this.PostalAdress.Name = "PostalAdress";
            this.PostalAdress.Size = new System.Drawing.Size(186, 35);
            this.PostalAdress.TabIndex = 84;
            this.PostalAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Browse
            // 
            this.Browse.AllowToggling = false;
            this.Browse.AnimationSpeed = 200;
            this.Browse.AutoGenerateColors = false;
            this.Browse.BackColor = System.Drawing.Color.Transparent;
            this.Browse.BackColor1 = System.Drawing.Color.SeaGreen;
            this.Browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Browse.BackgroundImage")));
            this.Browse.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Browse.ButtonText = "Browse";
            this.Browse.ButtonTextMarginLeft = 0;
            this.Browse.ColorContrastOnClick = 45;
            this.Browse.ColorContrastOnHover = 45;
            this.Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Browse.CustomizableEdges = borderEdges1;
            this.Browse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Browse.DisabledBorderColor = System.Drawing.Color.Empty;
            this.Browse.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Browse.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Browse.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Browse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Browse.ForeColor = System.Drawing.Color.White;
            this.Browse.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Browse.IconMarginLeft = 11;
            this.Browse.IconPadding = 10;
            this.Browse.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Browse.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.Browse.IdleBorderRadius = 3;
            this.Browse.IdleBorderThickness = 1;
            this.Browse.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.Browse.IdleIconLeftImage = null;
            this.Browse.IdleIconRightImage = null;
            this.Browse.IndicateFocus = false;
            this.Browse.Location = new System.Drawing.Point(322, 152);
            this.Browse.Name = "Browse";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.Browse.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.Browse.OnPressedState = stateProperties2;
            this.Browse.Size = new System.Drawing.Size(88, 28);
            this.Browse.TabIndex = 83;
            this.Browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Browse.TextMarginLeft = 0;
            this.Browse.UseDefaultRadiusAndThickness = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // PicturePath
            // 
            this.PicturePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PicturePath.Location = new System.Drawing.Point(322, 115);
            this.PicturePath.Name = "PicturePath";
            this.PicturePath.Size = new System.Drawing.Size(374, 22);
            this.PicturePath.TabIndex = 82;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(96, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DateOFBirth
            // 
            this.DateOFBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.DateOFBirth.BorderRadius = 0;
            this.DateOFBirth.ForeColor = System.Drawing.Color.White;
            this.DateOFBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateOFBirth.FormatCustom = null;
            this.DateOFBirth.Location = new System.Drawing.Point(521, 413);
            this.DateOFBirth.Name = "DateOFBirth";
            this.DateOFBirth.Size = new System.Drawing.Size(190, 32);
            this.DateOFBirth.TabIndex = 80;
            this.DateOFBirth.Value = new System.DateTime(2022, 4, 14, 12, 53, 23, 56);
            // 
            // Gender
            // 
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.BorderRadius = 3;
            this.Gender.DisabledColor = System.Drawing.Color.Gray;
            this.Gender.ForeColor = System.Drawing.Color.White;
            this.Gender.items = new string[] {
        "Male",
        "Fe Male"};
            this.Gender.Location = new System.Drawing.Point(166, 413);
            this.Gender.Name = "Gender";
            this.Gender.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.Gender.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Gender.selectedIndex = -1;
            this.Gender.Size = new System.Drawing.Size(192, 32);
            this.Gender.TabIndex = 79;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(399, 413);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(114, 22);
            this.bunifuCustomLabel6.TabIndex = 78;
            this.bunifuCustomLabel6.Text = "Date OF Birth";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(399, 348);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(68, 22);
            this.bunifuCustomLabel5.TabIndex = 77;
            this.bunifuCustomLabel5.Text = "Contact";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(72, 502);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(53, 22);
            this.bunifuCustomLabel4.TabIndex = 76;
            this.bunifuCustomLabel4.Text = "Email";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(72, 413);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(66, 22);
            this.bunifuCustomLabel3.TabIndex = 75;
            this.bunifuCustomLabel3.Text = "Gender";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(399, 289);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(89, 22);
            this.bunifuCustomLabel2.TabIndex = 74;
            this.bunifuCustomLabel2.Text = "Last Name";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(72, 289);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(92, 22);
            this.bunifuCustomLabel1.TabIndex = 73;
            this.bunifuCustomLabel1.Text = "First Name";
            // 
            // Email
            // 
            this.Email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Email.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.Enabled = false;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.HintForeColor = System.Drawing.Color.Empty;
            this.Email.HintText = "";
            this.Email.isPassword = false;
            this.Email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.Email.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.Email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.Email.LineThickness = 3;
            this.Email.Location = new System.Drawing.Point(166, 489);
            this.Email.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Email.MaxLength = 32767;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(545, 35);
            this.Email.TabIndex = 72;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Contact
            // 
            this.Contact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Contact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Contact.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Contact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Contact.HintForeColor = System.Drawing.Color.Empty;
            this.Contact.HintText = "";
            this.Contact.isPassword = false;
            this.Contact.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.Contact.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.Contact.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.Contact.LineThickness = 3;
            this.Contact.Location = new System.Drawing.Point(521, 335);
            this.Contact.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Contact.MaxLength = 32767;
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(190, 35);
            this.Contact.TabIndex = 71;
            this.Contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LastName
            // 
            this.LastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LastName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastName.HintForeColor = System.Drawing.Color.Empty;
            this.LastName.HintText = "";
            this.LastName.isPassword = false;
            this.LastName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.LastName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.LastName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.LastName.LineThickness = 3;
            this.LastName.Location = new System.Drawing.Point(521, 272);
            this.LastName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LastName.MaxLength = 32767;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(190, 39);
            this.LastName.TabIndex = 70;
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LastName.OnValueChanged += new System.EventHandler(this.LastName_OnValueChanged);
            // 
            // FirstName
            // 
            this.FirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FirstName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstName.HintForeColor = System.Drawing.Color.Empty;
            this.FirstName.HintText = "";
            this.FirstName.isPassword = false;
            this.FirstName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.FirstName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.FirstName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.FirstName.LineThickness = 3;
            this.FirstName.Location = new System.Drawing.Point(172, 272);
            this.FirstName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FirstName.MaxLength = 32767;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(186, 39);
            this.FirstName.TabIndex = 69;
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FirstName.OnValueChanged += new System.EventHandler(this.FirstName_OnValueChanged);
            // 
            // Cancel1
            // 
            this.Cancel1.ActiveBorderThickness = 1;
            this.Cancel1.ActiveCornerRadius = 20;
            this.Cancel1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Cancel1.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Cancel1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Cancel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.Cancel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel1.BackgroundImage")));
            this.Cancel1.ButtonText = "Cancel";
            this.Cancel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.Cancel1.IdleBorderThickness = 1;
            this.Cancel1.IdleCornerRadius = 20;
            this.Cancel1.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.Cancel1.IdleForecolor = System.Drawing.Color.Black;
            this.Cancel1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Cancel1.Location = new System.Drawing.Point(381, 593);
            this.Cancel1.Margin = new System.Windows.Forms.Padding(5);
            this.Cancel1.Name = "Cancel1";
            this.Cancel1.Size = new System.Drawing.Size(181, 41);
            this.Cancel1.TabIndex = 68;
            this.Cancel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel1.Click += new System.EventHandler(this.Cancel1_Click);
            // 
            // Save
            // 
            this.Save.ActiveBorderThickness = 1;
            this.Save.ActiveCornerRadius = 20;
            this.Save.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Save.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Save.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.ButtonText = "Update";
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.Save.IdleBorderThickness = 1;
            this.Save.IdleCornerRadius = 20;
            this.Save.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.Save.IdleForecolor = System.Drawing.Color.Black;
            this.Save.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Save.Location = new System.Drawing.Point(586, 593);
            this.Save.Margin = new System.Windows.Forms.Padding(5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(181, 41);
            this.Save.TabIndex = 67;
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuLabel1.Location = new System.Drawing.Point(32, 21);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(192, 38);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Edit Data For ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 647);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Browse;
        private System.Windows.Forms.TextBox PicturePath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDatepicker DateOFBirth;
        private Bunifu.Framework.UI.BunifuDropdown Gender;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Contact;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FirstName;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Save;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PostalAdress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email;
    }
}