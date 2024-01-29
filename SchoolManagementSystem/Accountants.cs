using SchoolManagementSystem.AccountantFolder;
using SchoolManagementSystem.AccountantReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Accountants : Form
    {
        int a = 0;
        string b = "";
        string EmployeName = "";
        string Emplopyerole = "";
        string titleparameter = "";
        string sessionparameter = "";

        public Accountants(string email)
        {
            InitializeComponent();
            customizeDesign();
            LoadLoggedInAdminInfo(email);


        }
        public void LoadLoggedInAdminInfo(string email)
        {
            Validators v = new Validators();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("LoadLoggedInAccountant", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name.Text = reader["Name"].ToString();
                email1.Text = reader["Email"].ToString();
                contact.Text = reader["Contact"].ToString();
                dob.Text = reader["DOB"].ToString();
                gender1.Text = GetGender(reader["Gender"].ToString());
                role.Text = GetRole(reader["Role"].ToString());
                //pictureBox1.Image = v.ConvertByteToImage(reader["Photo"] as byte[]);
            }
            con.Close();
            panel7.Visible = false;
            SaveChanges.Visible = false;
            DiscardChanges.Visible = false;
        }
        public string GetRole(string SelectedIem)
        {
            string role = "";
            if (SelectedIem == "14")
            {
                role = "Teacher";
            }
            else if (SelectedIem == "15")
            {
                role = "Admin";
            }
            else if (SelectedIem == "16")
            {
                role = "Accountant";
            }
            else if (SelectedIem == "13")
            {
                role = "Pricipal";
            }
            else if (SelectedIem == "17")
            {
                role = "Others";
            }
            return role;
        }
        public string GetGender(string id)
        {
            string gender = "";
            if (id == "7")
                gender = "Male";
            else
                gender = "Fe Male";

            return gender;
        }
        private void customizeDesign()
        {
            SubMenu1.Visible = false;
            Submenu2.Visible = false;
        }


        private void exitToolbarBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void maxToolbarBtn_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void minToolbarBtn_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;

        }
        private void ShowMenu(Panel Menu)
        {
            if (Menu.Visible == false)
            {
                HideMenu();
                Menu.Visible = true;
            }
        }
        private void HideMenu()
        {
            if (SubMenu1.Visible == true)
                SubMenu1.Visible = false;
            if (Submenu2.Visible == true)
                Submenu2.Visible = false;
        }

        private void bunifuButton7_Click_1(object sender, EventArgs e)
        {
            ShowMenu(SubMenu1);
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            ShowMenu(Submenu2);
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            LoadSalaryDetails();
            bunifuPages1.SetPage(FeeChallan);

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            HideMenu();
            bunifuCards1.Visible = false;
            bunifuPages1.SetPage(FeeStatus);
            SearchBox.Visible = false;
            SClass.Visible = false;
            SearchStudent.Visible = false;

        }
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            if (!(SearchBox.Visible && SClass.Visible))
            {
                SearchBox.Text = null;
                SClass.Text = null;
                bunifuTransition1.ShowSync(SearchBox, false, BunifuAnimatorNS.Animation.HorizSlide);
                bunifuTransition1.ShowSync(SClass, false, BunifuAnimatorNS.Animation.HorizSlide);
                SClass.Text = "Enter Class";
                bunifuTransition1.ShowSync(SearchStudent, false, BunifuAnimatorNS.Animation.Leaf);

            }
            else
            {
                bunifuTransition1.HideSync(SearchBox, false, BunifuAnimatorNS.Animation.HorizSlide);
                bunifuTransition1.HideSync(SClass, false, BunifuAnimatorNS.Animation.HorizSlide);
            }

        }

        private void bunifuPictureBox2_Click_1(object sender, EventArgs e)
        {

            if (!(EmployeeSearch.Visible && EmployeeRole.Visible))
            {
                EmployeeSearch.Text = null;
                EmployeeRole.Text = null;
                bunifuTransition1.ShowSync(EmployeeSearch, false, BunifuAnimatorNS.Animation.HorizSlide);
                EmployeeSearch.PlaceholderText = "Employee Name";
                bunifuTransition1.ShowSync(EmployeeRole, false, BunifuAnimatorNS.Animation.HorizSlide);
                EmployeeRole.PlaceholderText = "Employee Role";
                bunifuTransition1.ShowSync(EmSearchbtn, false, BunifuAnimatorNS.Animation.Leaf);

            }
            else
            {
                bunifuTransition1.HideSync(EmployeeSearch, false, BunifuAnimatorNS.Animation.HorizSlide);
                bunifuTransition1.HideSync(EmployeeRole, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            HideMenu();
            bunifuPages1.SetPage(FeeDetails);
            Load_Classes();

        }
        //Loaading numbers of students who haven't paid the fees yet
        public void Load_Classes()
        {
            flowLayoutPanel1.Controls.Clear();
            string Title = "";
            int Total = 0;
            int notpaid = 0;
            string sess = "";
            string query = "FeesNotPaid";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())//while true
            {
                Title = dr["Title"].ToString();
                Total = Convert.ToInt32(dr["TotalStudent"]);
                notpaid = Convert.ToInt32(dr["NonPaidStudents"]);
                sess = dr["Session"].ToString();
                LateFee_UC lfu = new LateFee_UC(this, Title, Total, notpaid, sess);
                flowLayoutPanel1.Controls.Add(lfu);
            }
            dr.Close();
            con.Close();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            HideMenu();
            bunifuPages1.SetPage(SalaryDetails);
            LoadSalary();
        }
        //Loading Salary Details into the Cards
        private void LoadSalary()
        {

            flowLayoutPanel2.Controls.Clear();
            string Role = "";
            int Total = 0;
            int paid = 0;
            string query = "SalaryDetails";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())//while true
            {
                Role = dr["Value"].ToString();
                Total = Convert.ToInt32(dr["TotalEmployees"]);
                paid = Convert.ToInt32(dr["SalaryNotPaid"]);
                Salary_UC SUC = new Salary_UC(this, Role, Total, paid);
                flowLayoutPanel2.Controls.Add(SUC);
            }
            dr.Close();
            con.Close();

        }
        private void bunifuButton4_Click_1(object sender, EventArgs e)
        {

            HideMenu();
            bunifuCards2.Visible = false;
            EmployeeSearch.Visible = false;
            EmployeeRole.Visible = false;
            EmSearchbtn.Visible = false;
            bunifuPages1.SetPage(PaySalary);
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
        }
        //Loading fees details into the cards
        private void LoadSalaryDetails()
        {
            flowLayoutPanel3.Controls.Clear();
            string clas = "";
            int Scetion = 0;
            int total = 0;
            int session;
            string query = "FeeChallan";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())//while true
            {
                clas = dr["Title"].ToString();
                Scetion = Convert.ToInt32(dr["Sections"]);
                total = Convert.ToInt32(dr["TotalStudents"]);
                session = Convert.ToInt32(dr["Session"]);
                Challan_UC CUC = new Challan_UC(clas, session, Scetion, total);
                flowLayoutPanel3.Controls.Add(CUC);
            }
            dr.Close();
            con.Close();

        }
        private void viewLogoutBtn_Click(object sender, EventArgs e)
        {

            if (logoutBtn.Visible == false)
            {
                bunifuTransition1.ShowSync(logoutBtn, false, BunifuAnimatorNS.Animation.Particles);
            }
            else
            {
                bunifuTransition1.HideSync(logoutBtn, false, BunifuAnimatorNS.Animation.Particles);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Window LW = new Login_Window();
            LW.Show();
        }
        //Search the Student
        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            if (!(SearchBox.Text == "" && SClass.Text == ""))
            {
                var con = SQL_Configuration.getInstance().getConnection();
                try
                {
                    a = Convert.ToInt32(SearchBox.Text);
                    b = SClass.Text;
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Stp_SearchStudent", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@RollNo", SearchBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@Class", SClass.Text));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                        if (rdr.Read())
                        {
                            bunifuCards1.Visible = true;
                            bunifuTextBox1.Text = rdr["Name"].ToString();
                            int sta = Convert.ToInt32(rdr["Status"]);
                            if (sta == 13)
                            { bunifuDropdown1.Text = "Paid"; }
                            else
                            {
                                bunifuDropdown1.Text = "NotPaid";
                            }
                        }
                        else
                        {
                            bunifuCards1.Visible = false;
                            MessageBox.Show("The Student Does not Exist in the School", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                }
                catch (Exception ex)
                {
                    String a = ex.Message;
                    MessageBox.Show(a, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bunifuCards1.Visible = false;
                MessageBox.Show("Enter Name and Class ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //Initialize the Dropdown of Student Fees 
        private void Accountant_Load(object sender, EventArgs e)
        {
            string query = "Exec StpGetFeeStatus";
            var con = SQL_Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                bunifuDropdown1.Items.Add(rd[1].ToString());
                bunifuDropdown2.Items.Add(rd[1].ToString());
            }
            rd.Close();

            AutocompleteClass();
            AutoNameComplete();
            AutoNameRole();
        }
        //Change Fee Status of the Student
        private void exitBtn_Click(object sender, EventArgs e)
        {
            int SID = -1;
            var con = SQL_Configuration.getInstance().getConnection();
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("Stp_GetSID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@RollNo", a));
                cmd.Parameters.Add(new SqlParameter("@Class", b));
                using (SqlDataReader rdr = cmd.ExecuteReader())
                    if (rdr.Read())
                    {

                        SID = Convert.ToInt32(rdr["StudentId"]);
                        con.Close();
                        con.Open();


                    }
                    else
                    {
                        bunifuCards1.Visible = false;
                        MessageBox.Show("An Error Occured While changing the stauts.\n Please Search the Student Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            catch (Exception ex)
            {
                String a = ex.Message;
                MessageBox.Show(a, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                string query = "Update Student_Fee set DuesStatus=(select lu.ID from Lookup lu WHERE lu.value='" + bunifuDropdown1.Text + "') where SID='" + SID + "'";
                MessageBox.Show("Status Changed Successfully!");
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                String a = ex.Message;
                MessageBox.Show(a, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void AutocompleteClass()
        {
            SchoolManagementSystem.AccountantFolder.ClassAutoComplete classAutoComplete = new SchoolManagementSystem.AccountantFolder.ClassAutoComplete();
            SClass.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SClass.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            classAutoComplete.SetClass();
            collection.AddRange(classAutoComplete.Classlist.ToArray());
            SClass.AutoCompleteCustomSource = collection;
        }
        private void AutoNameComplete()
        {
            SchoolManagementSystem.AccountantFolder.ClassAutoComplete classAutoComplete = new SchoolManagementSystem.AccountantFolder.ClassAutoComplete();
            EmployeeSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EmployeeSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            classAutoComplete.SetName();
            collection.AddRange(classAutoComplete.Namelist.ToArray());
            EmployeeSearch.AutoCompleteCustomSource = collection;
        }
        private void AutoNameRole()
        {
            SchoolManagementSystem.AccountantFolder.ClassAutoComplete classAutoComplete = new SchoolManagementSystem.AccountantFolder.ClassAutoComplete();
            EmployeeRole.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EmployeeRole.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            classAutoComplete.SetRole();
            collection.AddRange(classAutoComplete.Rolelist.ToArray());
            EmployeeRole.AutoCompleteCustomSource = collection;
        }
        private void EmSearchbtn_Click(object sender, EventArgs e)
        {

            if (!(EmployeeSearch.Text == "" && EmployeeRole.Text == ""))
            {
                var con = SQL_Configuration.getInstance().getConnection();
                try
                {
                    EmployeName = EmployeeSearch.Text;
                    Emplopyerole = EmployeeRole.Text;
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Stp_SearchEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", EmployeeSearch.Text));
                    cmd.Parameters.Add(new SqlParameter("@Role", EmployeeRole.Text));
                    using (SqlDataReader rd = cmd.ExecuteReader())
                        if (rd.Read())
                        {
                            bunifuCards2.Visible = true;
                            bunifuTextBox3.Text = rd["NAME"].ToString();
                            bunifuDropdown2.Text = rd["STATUS"].ToString();

                        }
                        else
                        {
                            bunifuCards2.Visible = false;
                            MessageBox.Show("The Employee Does not Exist in the Staff", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                }
                catch (Exception ex)
                {
                    String a = ex.Message;
                    MessageBox.Show(a, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bunifuCards1.Visible = false;
                MessageBox.Show("Enter Name and Role ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Change Status of Employee Salary
        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            int EID = -1;
            var con = SQL_Configuration.getInstance().getConnection();
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("Stp_GetEmployeeID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@name", EmployeName));
                cmd.Parameters.Add(new SqlParameter("@role", Emplopyerole));
                using (SqlDataReader rdr = cmd.ExecuteReader())
                    if (rdr.Read())
                    {

                        EID = Convert.ToInt32(rdr["EID"]);
                        con.Close();
                        con.Open();
                        string query = "Update Employee_Salary set DuesStatus=(select lu.ID from Lookup lu WHERE lu.value='" + bunifuDropdown2.Text + "') where EID='" + EID + "'";
                        MessageBox.Show("Status Changed Successfully!");
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.ExecuteNonQuery();


                    }
                    else
                    {
                        bunifuCards1.Visible = false;
                        MessageBox.Show("An Error Occured While changing the stauts.\n Please Search the Student Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            catch (Exception ex)
            {
                String a = ex.Message;
                MessageBox.Show(a, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //public void FeeTable1(string a,string b)
        //{
        //   // BindingSource bindingSource1 = new BindingSource();
        //    var con1 = SQL_Configuration.getInstance().getConnection();
        //    con1.Close();
        //    con1.Open();

        //    MessageBox.Show(a + b);
        //    SqlCommand cmd = new SqlCommand("STP_FeesTable", con1);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add(new SqlParameter("@title", a));
        //    cmd.Parameters.Add(new SqlParameter("@session", Convert.ToInt32(b)));
        //    // SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    //  DataTable dt = new DataTable();
        //    //  da.Fill(dt);
        //    // bindingSource1.DataSource = dt;
        //    using (SqlDataReader rdr = cmd.ExecuteReader())

        //    {
        //      //  dataGridView1.Columns.Add("Name",Name);
        //        if (rdr.Read())
        //        {
        //            dataGridView1.Rows[0].Cells[0].Value = "khadija";
        //            //MessageBox.Show(rdr["Name"].ToString());
        //            dataGridView1.Rows[0].Cells[0].Value = rdr["Name"].ToString();
        //            // dataGridView1.Rows.Add(rdr["Name"].ToString(), rdr["Class"].ToString());

        //            //   bunifuDataGridView1.Rows.Add("Khadija","Playgroup");

        //        }

        //    }
        //}


        public void FeeTable(string a, string b)
        {
            titleparameter = a;
            sessionparameter = b;
            var con = SQL_Configuration.getInstance().getConnection();
            string query = "SELECT ST.RollNo,P.First_Name +' '+ P.Last_Name As Name,C.Title As Class,S.SectionTitle Section,C.Session,SF.Amount,SF.Month  FROM Class C JOIN ClassVariants CV ON C.ClassID=CV.CID JOIN Section S ON S.VID=CV.VariantID  JOIN Student_Class SC ON SC.SectionID=S.SectionID  JOIN Student ST ON ST.StudentId=SC.SId  JOIN Student_Fee SF ON SF.SID=ST.StudentId JOIN Person P ON P.ID=ST.StudentId AND SF.DuesStatus='19' Where c.Session = '" + Convert.ToInt32(b) + "' And c.Title ='" + a + "' ORDER by Section";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            bunifuCustomDataGrid1.DataSource = data;
        }
        public void SalaryTable(string a)
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            string query = "SELECT P.First_Name+' '+p.Last_Name Name,(SELECT VALUE FROM Lookup where ID=Role) [Employee Role],Salary,Date,Contact FROM EMPLOYEE E JOIN Employee_Salary ES ON ES.EID=E.EmployeeId JOIN Person P ON p.ID=E.EmployeeId AND ES.DuesStatus='19' Where (SELECT VALUE FROM Lookup where ID=Role)='" + a + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            bunifuCustomDataGrid2.DataSource = data;
        }

        private void bunifuButton8_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(AccountSetting);
        }


        private void bunifuButton10_Click_1(object sender, EventArgs e)
        {
            panel7.Visible = true;
            SaveChanges.Visible = true;
            DiscardChanges.Visible = true;
        }
        public void updatePic()
        {
            Validators v = new Validators();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateProfilePhoto", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email1.Text;
            cmd.Parameters.AddWithValue("@Photo", SqlDbType.Image).Value = v.ConvertImageTobyte(pictureBox1.Image);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool browseImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                PictureBox.Image = new Bitmap(open.FileName);
                // image file path  
                //PicturePath.Text = open.FileName;
                return true;
            }
            return false;
        }
        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            if (browseImage())
            {
                if (MessageBox.Show("Are you sure you want to Save Changes?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    updatePic();
                    MessageBox.Show("Changes Saved Successfully!");
                }
            }
        }
        public int GetGenderID(string gender)
        {
            if (gender == "Male")
                return 7;
            else
                return 8;
        }
        public void SaveProfileChanges()
        {
            Validators v = new Validators();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateEmployeeProfile", con);
            SqlCommand cmd1 = new SqlCommand("UpdatePassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email1.Text;
            cmd1.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = edit_password.Text;
            cmd.Parameters.AddWithValue("@OldContact", SqlDbType.Int).Value = "";
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = firstname.Text;
            cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = lastname.Text;
            cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = edit_contact.Text;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.VarChar).Value = dateob.Value;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email1.Text;
            cmd.Parameters.AddWithValue("@Gender", SqlDbType.Int).Value = GetGenderID(Gender.selectedValue);
            cmd.Parameters.AddWithValue("@PostalAdress", SqlDbType.VarChar).Value = adress.Text;
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfull!");
            //LoadLoggedInAdminInfo(email1.Text);

        }
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            SaveProfileChanges();
            //PopulateAdminEdit();
            panel2.Visible = false;
            SaveChanges.Visible = false;
            DiscardChanges.Visible = false;
        }

        private void DiscardChanges_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            SaveChanges.Visible = false;
            DiscardChanges.Visible = false;
        }

      
        private void FeeReport(string a, string b)
        {
            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                using (SqlCommand cmd = new SqlCommand("STP_FeesTable", con))
                {
                    MessageBox.Show("Report is Being Generated");
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dtReportData = new DataTable();
                    con.Open();
                    cmd.Parameters.AddWithValue("@title", a);
                    cmd.Parameters.AddWithValue("@session", b);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtReportData.Load(sdr);
                    AccountantReports.Reports rf = new AccountantReports.Reports();
                    //MessageBox.Show(mon.Text+" Crystal");
                    rf.ReportName = @"AccountantReports\FeeReport.rpt";
                    rf.dtReport = dtReportData;
                    rf.Show();

                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuButton12_Click_1(object sender, EventArgs e)
        {
            FeeReport(titleparameter,sessionparameter);
        }
    }
}
                
              