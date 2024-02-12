namespace Student_Registration_System
{
    public partial class Students : Form
    {
#pragma warning disable CS0414 // The field 'Students.isAnimating' is assigned but its value is never used
        private bool isAnimating = false;
#pragma warning restore CS0414 // The field 'Students.isAnimating' is assigned but its value is never used
#pragma warning disable CS0414 // The field 'Students.animationStep' is assigned but its value is never used
        private int animationStep = 0;
#pragma warning restore CS0414 // The field 'Students.animationStep' is assigned but its value is never used






        Functions Con;
        public Students()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            Con = new Functions();
            ShowStudents();
            GetDepartment();
        }


        private void ShowStudents()
        {
            string Query = "Select * from StudentTbl";
            /*string Query = "select s.StCode, s.stname, s.stgen, s.stphone, s.stparent, s.stDistrict, d.depname " +
                   "from studenttbl s " +
                   "join departmenttbl d on s.stdepartment = d.DepId";*/
            StudentsList.DataSource = Con.GetData(Query);
            Console.WriteLine(Con.GetData(Query));

        }




        private void GetDepartment()
        {
            string Query = "Select * from DepartmentTbl";
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            DepCb.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            DepCb.ValueMember = Con.GetData(Query).Columns["DepId"].ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            DepCb.DataSource = Con.GetData(Query);
        }

        private void clear()
        {
            StNameTb.Text = "";
            StPhoneTb.Text = "";
            StParentTb.Text = "";
            StDistrictTb.Text = "";
            GenCb.SelectedIndex = -1;

        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StPhoneTb.Text == "" || StParentTb.Text == "" || StDistrictTb.Text == "" || DepCb.SelectedIndex == -1 || GenCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string TName = StNameTb.Text;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string Gender = GenCb.SelectedItem.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    string Phone = StPhoneTb.Text;
                    string Parent = StParentTb.Text;
                    string District = StDistrictTb.Text;
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string Query = "insert into StudentTbl values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, TName, Gender, Phone, Parent, District, Dep);
                    Con.SetData(Query);
                    ShowStudents();
                    MessageBox.Show("Student Added!!!");
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        int Key = 0;
        private void StudentsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StNameTb.Text = StudentsList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.SelectedItem = StudentsList.SelectedRows[0].Cells[2].Value.ToString();
            StPhoneTb.Text = StudentsList.SelectedRows[0].Cells[3].Value.ToString();
            StParentTb.Text = StudentsList.SelectedRows[0].Cells[4].Value.ToString();
            StDistrictTb.Text = StudentsList.SelectedRows[0].Cells[5].Value.ToString();
            DepCb.SelectedValue = StudentsList.SelectedRows[0].Cells[6].Value.ToString();
            if (StNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StudentsList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || StPhoneTb.Text == "" || StParentTb.Text == "" || StDistrictTb.Text == "" || DepCb.SelectedIndex == -1 || GenCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string TName = StNameTb.Text;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string Gender = GenCb.SelectedItem.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    string Phone = StPhoneTb.Text;
                    string Parent = StParentTb.Text;
                    string District = StDistrictTb.Text;
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string Query = "Update StudentTbl set StName='{0}',StGen='{1}',StPhone='{2}',StParent='{3}',StDistrict='{4}',StDepartment={5} where StCode={6}";
                    Query = string.Format(Query, TName, Gender, Phone, Parent, District, Dep, Key);
                    Con.SetData(Query);
                    ShowStudents();
                    MessageBox.Show("Student Updated!!!");
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string TName = StNameTb.Text;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string Gender = GenCb.SelectedItem.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    string Phone = StPhoneTb.Text;
                    string Parent = StParentTb.Text;
                    string District = StDistrictTb.Text;
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string Query = "Delete from StudentTbl where StCode={0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowStudents();
                    MessageBox.Show("Student Deleted!!!");
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeptLbl_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.ShowDialog();
            this.Close();

            //......

        }

        private void DashboardLbl_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.ShowDialog();
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
