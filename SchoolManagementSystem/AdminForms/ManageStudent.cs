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

namespace SchoolManagementSystem.AdminForms
{
    public partial class Manage_Student : UserControl
    {
        int initial_count = 0;
        bool search_clicked = false;
        public Manage_Student()
        {
            InitializeComponent();
        }
        public void LoadStudentData()
        {
            DisplayStudentInfo.Controls.Clear();
            string registration = "";
            string name = "";
            string age = "";
            string contact = "";
            string gender = "";
            int counter = 0;
            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("DisplayStudentData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                while (sdr.Read())
                {
                    if (counter != 10)
                    {
                        registration = sdr["Registration"].ToString();
                        name = sdr["Name"].ToString();
                        age = sdr["Age"].ToString();
                        contact = sdr["Contact"].ToString();
                        gender = sdr["Gender"].ToString();                        
                        StudentInfoCardLayout sicl = new StudentInfoCardLayout(registration, name, contact, age, gender);
                        DisplayStudentInfo.Controls.Add(sicl);
                        counter++;
                    }
                }                
                con.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public int Counter()
        {
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            Console.WriteLine("Connection Open ! ");
            SqlCommand cmd1 = new SqlCommand("Select COUNT(*) From Student", con);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            sdr1.Read();
            int count = Convert.ToInt32(sdr1.GetValue(0));
            return count;
        }

        private void ManageStudent_Load(object sender, EventArgs e) 
        {
            LoadUnAssignedStudents();
            LoadStudentData();            
            initial_count = Counter();
            tabControl1.Visible = false;
            DetailPanel.Visible = false;
            panel3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (Counter() > initial_count)
                LoadStudentData();
        }

        private void Add_Student_Click(object sender, EventArgs e)
        {
            AddStudent a = new AddStudent();
            a.Show();
        }
        public void ToNormalState()
        {
            tabControl1.Visible = false;
            search_clicked = false;
            DisplayStudentInfo.AutoScroll = true;
            DisplayStudentInfo.Size = new Size(996, 397);
            DetailPanel.Visible = false;
            DetailPanel.Size = new Size(996, 24);
        }
        private void TeacherSearch_Click(object sender, EventArgs e)
        {
            if (search_clicked == false)
            {
                tabControl1.Visible = true;
                tabControl1.TabIndex = 0;
                search_clicked = true;
            }
            else
            {
                tabControl1.Visible = false;
                search_clicked = false;
                ToNormalState();
                LoadStudentData();
            }
        }
        public string GetClassVarraintByID(string input)
        {
            string varr = "";
            if (input == "9")
                varr = "General";
            if (input == "10")
                varr = "ComputerScience";
            if (input == "11")
                varr = "Biology";
            if (input == "12")
                varr = "Arts";

            return varr;
        }

        public async void SearchStudentByRollNo()
        {
            
            string registration = "";
            string name = "";
            string age = "";
            string contact = "";
            string gender = "";
            string postal = "";
            string section = "";
            string stdclass = "";
            string session = "";
            string studentof = "";
            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SearchStudentByRollNo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Registration", SqlDbType.Int).Value = Convert.ToInt32(SearchBox.Text);
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        registration = sdr["Registration"].ToString();
                        name = sdr["Name"].ToString();
                        age = sdr["Age"].ToString();
                        contact = sdr["Contact"].ToString();
                        gender = sdr["Gender"].ToString();
                        postal = sdr["PostalAdress"].ToString();
                        section = sdr["Section"].ToString();
                        session = sdr["Session"].ToString();
                        studentof = GetClassVarraintByID(sdr["Varriant"].ToString());
                        stdclass = sdr["ClassTitle"].ToString();
                        byte[] bytes = sdr["Photo"] as byte[];
                        await Task.Delay(2000);
                        StudentInfoCardLayout sicl = new StudentInfoCardLayout(registration, name, contact, age, gender);
                        DisplayStudentInfo.Controls.Clear();
                        DetailPanel.Controls.Clear();
                        DisplayStudentInfo.Controls.Add(sicl);
                        ViewStudentDetails vd = new ViewStudentDetails(name, registration, age, contact, gender, postal, stdclass, section, session, studentof,bytes);
                        DetailPanel.Controls.Add(vd);
                    }
                }
                else
                {
                    MessageBox.Show("No Student Found");
                    ToNormalState();
                    LoadStudentData();
                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public void SearchStudentByContact()
        {
            
            string registration = "";
            string name = "";
            string age = "";
            string contact = "";
            string gender = "";
            string postal = "";
            string section = "";
            string stdclass = "";
            string session = "";
            string studentof = "";
            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SearchStudentByContact", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = Convert.ToInt32(SearchBox.Text);
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        registration = sdr["Registration"].ToString();
                        name = sdr["Name"].ToString();
                        age = sdr["Age"].ToString();
                        contact = sdr["Contact"].ToString();
                        gender = sdr["Gender"].ToString();
                        postal = sdr["PostalAdress"].ToString();
                        section = sdr["Section"].ToString();
                        session = sdr["Session"].ToString();
                        studentof = GetClassVarraintByID(sdr["Varriant"].ToString());
                        stdclass = sdr["ClassTitle"].ToString();                        
                        byte[] bytes = (byte[])(new ImageConverter()).ConvertTo(sdr["Photo"], typeof(byte[]));                         
                        StudentInfoCardLayout sicl = new StudentInfoCardLayout(registration, name, contact, age, gender);
                        DisplayStudentInfo.Controls.Clear();
                        DetailPanel.Controls.Clear();
                        DisplayStudentInfo.Controls.Add(sicl);
                        ViewStudentDetails vd = new ViewStudentDetails(name, registration, age, contact, gender, postal, stdclass, section, session, studentof,bytes);
                        DetailPanel.Controls.Add(vd);
                    }
                }
                else
                {
                    MessageBox.Show("No Student Found");
                    LoadStudentData();
                }
                con.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection !");

            }
        }
        public void SearchStudentData()
        {
            if (SearchBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid search value !");
            }
            else
            {
                if (SearchBox.Text.Length == 10)
                {
                    SearchStudentByContact();
                }
                else
                {
                    SearchStudentByRollNo();
                }
            }


        }
        private void Search_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            DisplayStudentInfo.Controls.Clear();
            DisplayStudentInfo.AutoScroll = false;
            DisplayStudentInfo.Size = new Size(985, 70);
            LoadingScreen ls = new LoadingScreen();
            ls.Dock = DockStyle.Fill;
            DetailPanel.Controls.Add(ls);
            DetailPanel.Visible = true;
            DetailPanel.Size = new Size(985, 341);            
            SearchStudentData();


        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 1;
            panel3.Visible = true;
            panel1.Visible = false;
            bunifuButton2.OnIdleState.BorderColor = Color.FromArgb(105, 181, 255);
            bunifuButton3.OnIdleState.BorderColor = Color.White;

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 0;
            buttonadded = false;
            ClassData.DataSource = null;
            ClassData.Columns.Clear();
            StudentClass.Clear();
            session.selectedIndex = -1;
            varriant.selectedIndex = -1;
            section.selectedIndex = -1;
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            session.Clear();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Session From Class Where Title='" + StudentClass.Text + "' AND IsDeleted=0", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                session.AddItem(dr[0].ToString());
            }
        }

        private void session_onItemSelected(object sender, EventArgs e)
        {
            varriant.Clear();
            string classtitle = StudentClass.Text;
            string session1 = session.selectedValue;
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateVarriantDropDown", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.VarChar).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session1;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                varriant.AddItem(dr[0].ToString());
            }
        }
        public int GetClassVarrantID()
        {
            int id = 9;
            if (varriant.selectedValue == "ComputerScience")
                id = 10;
            if (varriant.selectedValue == "Biology")
                id = 11;
            if (varriant.selectedValue == "Arts")
                id = 12;     
            return id;
        }
        public int GetClassVarID()
        {
            int id = 9;
            if (var.selectedValue == "ComputerScience")
                id = 10;
            if (var.selectedValue == "Biology")
                id = 11;
            if (var.selectedValue == "Arts")
                id = 12;
            return id;
        }
        private void varriant_onItemSelected(object sender, EventArgs e)
        {
            section.Clear();
            string classtitle = StudentClass.Text;
            string session1 = session.selectedValue;
            int varriant = GetClassVarrantID();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateSectionDropDown", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.VarChar).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session1;
            cmd.Parameters.AddWithValue("@Varraint", SqlDbType.Int).Value = varriant;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                section.AddItem(dr[0].ToString());
            }
        }
        
        bool buttonadded = false;
        public void LoadDatainDataGridView()
        {
            string stdclass = StudentClass.Text;
            string session1 = session.selectedValue;
            string varriant = GetClassVarrantID().ToString();
            string section1 = section.selectedValue;

            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("DisplayStudentsWithClassAndSection", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Class", SqlDbType.VarChar).Value = stdclass;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session1;
            cmd.Parameters.AddWithValue("@Varriant", SqlDbType.Int).Value = varriant;
            cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = section1;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ClassData.DataSource = dt;
            if (buttonadded == false)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "";
                buttonColumn.Name = "Unassign";
                buttonColumn.Text = "Un-Assign";
                buttonColumn.UseColumnTextForButtonValue = true;
                ClassData.Columns.Add(buttonColumn);
                buttonadded = true;
            }
            con.Close();

        }

        private void section_onItemSelected(object sender, EventArgs e)
        {
            LoadDatainDataGridView();
        }

        private void ClassData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Un Assign This Student From the Cureent Class?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id;
                
                    UnAssignedStudents uas = new UnAssignedStudents((ClassData.Rows[e.RowIndex].Cells["Name"].Value).ToString(), (ClassData.Rows[e.RowIndex].Cells["RollNo"].Value).ToString());
                    uas.Dock = DockStyle.Top;
                    //DisplayUnAssignedStudents.Controls.Clear();
                    DisplayUnAssignedStudents.Controls.Add(uas);
                    id = (ClassData.Rows[e.RowIndex].Cells["RollNo"].Value).ToString();
                    var con = SQL_Configuration.getInstance().getConnection();
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UnAssignStudent", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Roll", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Un-Assigned Successfully");
                    LoadDatainDataGridView();
                    con.Close();
                
            }
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text == "RollNo,Contact")
            {
                SearchBox.Text = "";
                SearchBox.ForeColor = Color.Black;
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                SearchBox.Text = "RollNo,Contact";
                SearchBox.ForeColor = Color.Silver;
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 0;
            panel3.Visible = false;
            panel1.Visible = true;
            bunifuButton3.OnIdleState.BorderColor = Color.FromArgb(105, 181, 255);
            bunifuButton2.OnIdleState.BorderColor = Color.White;
            ClassData.DataSource = null;
            ClassData.Columns.Clear();
            StudentClass.Clear();
            session.Clear();
            varriant.Clear();
            section.Clear();
            buttonadded = false;
        }
        public void LoadUnAssignedStudents()
        {
            DisplayUnAssignedStudents.Controls.Clear();
            string name = "";
            string rollno = "";
            string sid="";
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("GetUnAssignedStudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader r= cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    name = r["Name"].ToString();
                    rollno = r["RollNo"].ToString();
                    sid = r["SId"].ToString();
                    if (sid == "")
                    {
                        UnAssignedStudents uas = new UnAssignedStudents(name,rollno);
                        uas.Dock = DockStyle.Top;                        
                        DisplayUnAssignedStudents.Controls.Add(uas);
                    }
                }
            }
            con.Close();
        }

        private void refresh1_Click(object sender, EventArgs e)
        {
            if (ClassData.DataSource != null)
            {
                LoadDatainDataGridView();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Reports r = new Reports(cls.Text,ses.selectedValue,sec.selectedValue,"");
            r.Show();
            cls.Clear();
            ses.Clear();
            sec.Clear();
            var.Clear();
        }

        private void cls_TextChange(object sender, EventArgs e)
        {
            ses.Clear();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Session From Class Where Title='" + cls.Text + "' AND IsDeleted=0", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ses.AddItem(dr[0].ToString());
            }
        }

        private void ses_onItemSelected(object sender, EventArgs e)
        {
            var.Clear();
            string classtitle = cls.Text;
            string session1 = ses.selectedValue;
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateVarriantDropDown", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.VarChar).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session1;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var.AddItem(dr[0].ToString());
            }
        }

        private void var_onItemSelected(object sender, EventArgs e)
        {
            sec.Clear();
            string classtitle = cls.Text;
            string session1 = ses.selectedValue;
            int varriant = GetClassVarID();
            var con = SQL_Configuration.getInstance().getConnection();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("PopulateSectionDropDown", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", SqlDbType.VarChar).Value = classtitle;
            cmd.Parameters.AddWithValue("@Session", SqlDbType.VarChar).Value = session1;
            cmd.Parameters.AddWithValue("@Varraint", SqlDbType.Int).Value = varriant;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sec.AddItem(dr[0].ToString());
            }
        }

        private void sec_onItemSelected(object sender, EventArgs e)
        {

        }
        bool filter_clicked = false;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (filter_clicked == false)
            {
                tabControl1.Visible = true;
                tabControl1.TabIndex = 1;
                filter_clicked = true;
            }
            else
            {
                tabControl1.Visible = false;
                filter_clicked = false;
                ToNormalState();
                LoadStudentData();
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void filter1()
        {
            string registration = "";
            string name = "";
            string age = "";
            string contact = "";
            string gender = "";
            string postal = "";
            string section = "";
            string stdclass = "";
            string session = "";
            string studentof = "";
            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SessionFilter", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        registration = sdr["Registration"].ToString();
                        name = sdr["Name"].ToString();
                        age = sdr["Age"].ToString();
                        contact = sdr["Contact"].ToString();
                        gender = sdr["Gender"].ToString();
                        postal = sdr["PostalAdress"].ToString();
                        section = sdr["Section"].ToString();
                        session = sdr["Session"].ToString();
                        studentof = GetClassVarraintByID(sdr["Varriant"].ToString());
                        stdclass = sdr["ClassTitle"].ToString();
                        byte[] bytes = sdr["Photo"] as byte[]; ;
                        StudentInfoCardLayout sicl = new StudentInfoCardLayout(registration, name, contact, age, gender);
                        DisplayStudentInfo.Controls.Clear();
                        DetailPanel.Controls.Clear();
                        DisplayStudentInfo.Controls.Add(sicl);
                        ViewStudentDetails vd = new ViewStudentDetails(name, registration, age, contact, gender, postal, stdclass, section, session, studentof, bytes);
                        DetailPanel.Controls.Add(vd);
                    }
                }
                else
                {
                    MessageBox.Show("No Student Found");
                    LoadStudentData();
                }
                con.Close();
            
            }catch{
                MessageBox.Show("No Student Found");
                LoadStudentData();
            }
        }

        public void filter2()
        {
            string registration = "";
            string name = "";
            string age = "";
            string contact = "";
            string gender = "";
            string postal = "";
            string section = "";
            string stdclass = "";
            string session = "";
            string studentof = "";
            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SessionSectionFilter", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = textBox2.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        registration = sdr["Registration"].ToString();
                        name = sdr["Name"].ToString();
                        age = sdr["Age"].ToString();
                        contact = sdr["Contact"].ToString();
                        gender = sdr["Gender"].ToString();
                        postal = sdr["PostalAdress"].ToString();
                        section = sdr["Section"].ToString();
                        session = sdr["Session"].ToString();
                        studentof = GetClassVarraintByID(sdr["Varriant"].ToString());
                        stdclass = sdr["ClassTitle"].ToString();
                        byte[] bytes = sdr["Photo"] as byte[]; ;
                        StudentInfoCardLayout sicl = new StudentInfoCardLayout(registration, name, contact, age, gender);
                        DisplayStudentInfo.Controls.Clear();
                        DetailPanel.Controls.Clear();
                        DisplayStudentInfo.Controls.Add(sicl);
                        ViewStudentDetails vd = new ViewStudentDetails(name, registration, age, contact, gender, postal, stdclass, section, session, studentof, bytes);
                        DetailPanel.Controls.Add(vd);
                    }
                }
                else
                {
                    MessageBox.Show("No Student Found");
                    LoadStudentData();
                }
                con.Close();

            }
            catch
            {
                MessageBox.Show("No Student Found");
                LoadStudentData();
            }
        }
        
        public void filter3()
        {
            string registration = "";
            string name = "";
            string age = "";
            string contact = "";
            string gender = "";
            string postal = "";
            string section = "";
            string stdclass = "";
            string session = "";
            string studentof = "";
            try
            {
                var con = SQL_Configuration.getInstance().getConnection();
                con.Close();
                con.Open();
                //Console.WriteLine("Connection Open ! ");
                SqlCommand cmd = new SqlCommand("SessionSectionClassFilter", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Session", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                cmd.Parameters.AddWithValue("@Section", SqlDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.AddWithValue("@Class", SqlDbType.VarChar).Value = textBox3.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                ////Retrieve data from table and Display result
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        registration = sdr["Registration"].ToString();
                        name = sdr["Name"].ToString();
                        age = sdr["Age"].ToString();
                        contact = sdr["Contact"].ToString();
                        gender = sdr["Gender"].ToString();
                        postal = sdr["PostalAdress"].ToString();
                        section = sdr["Section"].ToString();
                        session = sdr["Session"].ToString();
                        studentof = GetClassVarraintByID(sdr["Varriant"].ToString());
                        stdclass = sdr["ClassTitle"].ToString();
                        byte[] bytes = sdr["Photo"] as byte[]; ;
                        StudentInfoCardLayout sicl = new StudentInfoCardLayout(registration, name, contact, age, gender);
                        DisplayStudentInfo.Controls.Clear();
                        DetailPanel.Controls.Clear();
                        DisplayStudentInfo.Controls.Add(sicl);
                        ViewStudentDetails vd = new ViewStudentDetails(name, registration, age, contact, gender, postal, stdclass, section, session, studentof, bytes);
                        DetailPanel.Controls.Add(vd);
                    }
                }
                else
                {
                    MessageBox.Show("No Student Found");
                    LoadStudentData();
                }
                con.Close();

            }
            catch
            {
                MessageBox.Show("No Student Found");
                LoadStudentData();
            }
        }
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length==0)
            {
                filter1();
            }
            else if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length == 0)
            {
                filter2();
            }
            else if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                filter3();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }
    }
}
