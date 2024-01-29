namespace SchoolManagementSystem.AdminForms
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeSalary = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PostalAdress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ID_Pass_Panel = new System.Windows.Forms.Panel();
            this.labelx = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Labely = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Role = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Browse = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PicturePath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DateOFBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Gender = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Contact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.FirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Cancel1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.ID_Pass_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.EmployeeSalary);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.PostalAdress);
            this.panel1.Controls.Add(this.ID_Pass_Panel);
            this.panel1.Controls.Add(this.Role);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.Browse);
            this.panel1.Controls.Add(this.PicturePath);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuCustomLabel16);
            this.panel1.Controls.Add(this.DateOFBirth);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.Contact);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.Cancel1);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 671);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmployeeSalary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmployeeSalary.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmployeeSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeeSalary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeeSalary.HintForeColor = System.Drawing.Color.Empty;
            this.EmployeeSalary.HintText = "";
            this.EmployeeSalary.isPassword = false;
            this.EmployeeSalary.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.EmployeeSalary.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.EmployeeSalary.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.EmployeeSalary.LineThickness = 3;
            this.EmployeeSalary.Location = new System.Drawing.Point(502, 416);
            this.EmployeeSalary.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmployeeSalary.MaxLength = 32767;
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.Size = new System.Drawing.Size(195, 39);
            this.EmployeeSalary.TabIndex = 74;
            this.EmployeeSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(388, 423);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(57, 22);
            this.bunifuCustomLabel10.TabIndex = 73;
            this.bunifuCustomLabel10.Text = "Salary";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(63, 433);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(43, 22);
            this.bunifuCustomLabel9.TabIndex = 72;
            this.bunifuCustomLabel9.Text = "Role";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(41, 326);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(109, 22);
            this.bunifuCustomLabel8.TabIndex = 71;
            this.bunifuCustomLabel8.Text = "Postal Adress";
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
            this.PostalAdress.Location = new System.Drawing.Point(158, 309);
            this.PostalAdress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PostalAdress.MaxLength = 32767;
            this.PostalAdress.Name = "PostalAdress";
            this.PostalAdress.Size = new System.Drawing.Size(186, 39);
            this.PostalAdress.TabIndex = 70;
            this.PostalAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ID_Pass_Panel
            // 
            this.ID_Pass_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_Pass_Panel.Controls.Add(this.labelx);
            this.ID_Pass_Panel.Controls.Add(this.Password);
            this.ID_Pass_Panel.Controls.Add(this.Labely);
            this.ID_Pass_Panel.Controls.Add(this.ConfirmPassword);
            this.ID_Pass_Panel.Controls.Add(this.bunifuCustomLabel4);
            this.ID_Pass_Panel.Controls.Add(this.Email);
            this.ID_Pass_Panel.Location = new System.Drawing.Point(51, 474);
            this.ID_Pass_Panel.Name = "ID_Pass_Panel";
            this.ID_Pass_Panel.Size = new System.Drawing.Size(667, 134);
            this.ID_Pass_Panel.TabIndex = 69;
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelx.Location = new System.Drawing.Point(11, 86);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(81, 22);
            this.labelx.TabIndex = 62;
            this.labelx.Text = "Password";
            // 
            // Password
            // 
            this.Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "";
            this.Password.isPassword = false;
            this.Password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.Password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(111, 73);
            this.Password.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(161, 35);
            this.Password.TabIndex = 61;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Labely
            // 
            this.Labely.AutoSize = true;
            this.Labely.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labely.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Labely.Location = new System.Drawing.Point(322, 86);
            this.Labely.Name = "Labely";
            this.Labely.Size = new System.Drawing.Size(148, 22);
            this.Labely.TabIndex = 60;
            this.Labely.Text = "Confirm Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ConfirmPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ConfirmPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConfirmPassword.HintForeColor = System.Drawing.Color.Empty;
            this.ConfirmPassword.HintText = "";
            this.ConfirmPassword.isPassword = false;
            this.ConfirmPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.ConfirmPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.ConfirmPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(101)))), ((int)(((byte)(58)))));
            this.ConfirmPassword.LineThickness = 3;
            this.ConfirmPassword.Location = new System.Drawing.Point(478, 73);
            this.ConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ConfirmPassword.MaxLength = 32767;
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(168, 35);
            this.ConfirmPassword.TabIndex = 59;
            this.ConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(11, 27);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(53, 22);
            this.bunifuCustomLabel4.TabIndex = 58;
            this.bunifuCustomLabel4.Text = "Email";
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
            this.Email.Location = new System.Drawing.Point(111, 14);
            this.Email.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Email.MaxLength = 32767;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(535, 35);
            this.Email.TabIndex = 54;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.Color.Transparent;
            this.Role.BorderRadius = 3;
            this.Role.DisabledColor = System.Drawing.Color.Gray;
            this.Role.ForeColor = System.Drawing.Color.White;
            this.Role.items = new string[] {
        "Male",
        "Fe Male"};
            this.Role.Location = new System.Drawing.Point(158, 423);
            this.Role.Name = "Role";
            this.Role.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.Role.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Role.selectedIndex = -1;
            this.Role.Size = new System.Drawing.Size(186, 32);
            this.Role.TabIndex = 68;
            this.Role.onItemSelected += new System.EventHandler(this.Role_onItemSelected);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(-261, 308);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(43, 22);
            this.bunifuCustomLabel7.TabIndex = 67;
            this.bunifuCustomLabel7.Text = "Role";
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
            this.Browse.Location = new System.Drawing.Point(323, 138);
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
            this.Browse.TabIndex = 66;
            this.Browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Browse.TextMarginLeft = 0;
            this.Browse.UseDefaultRadiusAndThickness = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // PicturePath
            // 
            this.PicturePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PicturePath.Location = new System.Drawing.Point(323, 101);
            this.PicturePath.Name = "PicturePath";
            this.PicturePath.Size = new System.Drawing.Size(374, 22);
            this.PicturePath.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(97, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Garamond", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(24, 23);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(207, 33);
            this.bunifuCustomLabel16.TabIndex = 63;
            this.bunifuCustomLabel16.Text = "New Employee";
            // 
            // DateOFBirth
            // 
            this.DateOFBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.DateOFBirth.BorderRadius = 0;
            this.DateOFBirth.ForeColor = System.Drawing.Color.White;
            this.DateOFBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateOFBirth.FormatCustom = null;
            this.DateOFBirth.Location = new System.Drawing.Point(507, 367);
            this.DateOFBirth.Name = "DateOFBirth";
            this.DateOFBirth.Size = new System.Drawing.Size(190, 32);
            this.DateOFBirth.TabIndex = 62;
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
            this.Gender.Location = new System.Drawing.Point(158, 367);
            this.Gender.Name = "Gender";
            this.Gender.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.Gender.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Gender.selectedIndex = -1;
            this.Gender.Size = new System.Drawing.Size(186, 32);
            this.Gender.TabIndex = 61;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(385, 367);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(114, 22);
            this.bunifuCustomLabel6.TabIndex = 60;
            this.bunifuCustomLabel6.Text = "Date OF Birth";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(385, 314);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(68, 22);
            this.bunifuCustomLabel5.TabIndex = 59;
            this.bunifuCustomLabel5.Text = "Contact";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(52, 377);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(66, 22);
            this.bunifuCustomLabel3.TabIndex = 57;
            this.bunifuCustomLabel3.Text = "Gender";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(385, 269);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(89, 22);
            this.bunifuCustomLabel2.TabIndex = 56;
            this.bunifuCustomLabel2.Text = "Last Name";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(52, 269);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(92, 22);
            this.bunifuCustomLabel1.TabIndex = 55;
            this.bunifuCustomLabel1.Text = "First Name";
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
            this.Contact.Location = new System.Drawing.Point(507, 313);
            this.Contact.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Contact.MaxLength = 32767;
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(190, 35);
            this.Contact.TabIndex = 53;
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
            this.LastName.Location = new System.Drawing.Point(507, 252);
            this.LastName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LastName.MaxLength = 32767;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(190, 39);
            this.LastName.TabIndex = 52;
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.FirstName.Location = new System.Drawing.Point(158, 252);
            this.FirstName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FirstName.MaxLength = 32767;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(186, 39);
            this.FirstName.TabIndex = 51;
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Cancel1.Location = new System.Drawing.Point(389, 616);
            this.Cancel1.Margin = new System.Windows.Forms.Padding(5);
            this.Cancel1.Name = "Cancel1";
            this.Cancel1.Size = new System.Drawing.Size(181, 41);
            this.Cancel1.TabIndex = 50;
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
            this.Save.ButtonText = "Save";
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.Save.IdleBorderThickness = 1;
            this.Save.IdleCornerRadius = 20;
            this.Save.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.Save.IdleForecolor = System.Drawing.Color.Black;
            this.Save.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Save.Location = new System.Drawing.Point(580, 616);
            this.Save.Margin = new System.Windows.Forms.Padding(5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(181, 41);
            this.Save.TabIndex = 49;
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ID_Pass_Panel.ResumeLayout(false);
            this.ID_Pass_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown Role;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Browse;
        private System.Windows.Forms.TextBox PicturePath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuDatepicker DateOFBirth;
        private Bunifu.Framework.UI.BunifuDropdown Gender;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Contact;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FirstName;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Save;
        private System.Windows.Forms.Panel ID_Pass_Panel;
        private Bunifu.Framework.UI.BunifuCustomLabel labelx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Bunifu.Framework.UI.BunifuCustomLabel Labely;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ConfirmPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmployeeSalary;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PostalAdress;
    }
}