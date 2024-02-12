namespace Student_Registration_System
{
    public partial class Departments : Form
    {
        Functions Con;
        public Departments()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Con = new Functions();
            ShowDepartments();
        }

        private void ShowDepartments()
        {
            string Query = "Select * from DepartmentTbl";
            DepartmentsList.DataSource = Con.GetData(Query);

        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DepNameTb.Text == "" || DetailsTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string DName = DepNameTb.Text;
                    string Details = DetailsTb.Text;
                    string Query = "insert into DepartmentTbl values('{0}','{1}')";
                    Query = string.Format(Query, DName, Details);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!!!");
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void DepartmentsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNameTb.Text = DepartmentsList.SelectedRows[0].Cells[1].Value.ToString();
            DetailsTb.Text = DepartmentsList.SelectedRows[0].Cells[2].Value.ToString();
            if (DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DepartmentsList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (DepNameTb.Text == "" || DetailsTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string DName = DepNameTb.Text;
                    string Details = DetailsTb.Text;
                    string Query = "Update DepartmentTbl set DepName='{0}',DepDetails='{1}' where DepId='{2}'";
                    Query = string.Format(Query, DName, Details, Key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Updated!!!");
                    clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void clear()
        {
            DepNameTb.Text = "";
            DetailsTb.Text = "";
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Department!!!");
            }
            else
            {
                try
                {
                    string DName = DepNameTb.Text;
                    string Details = DetailsTb.Text;
                    string Query = "Delete from DepartmentTbl where DepId='{0}'";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!!!");
                    clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }




        private void StudentLbl_Click_1(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.ShowDialog();
            this.Close();
        }

        private void Dashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.ShowDialog();
            this.Close();
        }

        private void label10_Click_1(object sender, EventArgs e)
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

