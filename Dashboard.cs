using System.Data;

namespace Student_Registration_System
{
    public partial class Dashboard : Form
    {
        Functions Con;

        public Dashboard()
        {
            InitializeComponent();
            timer1.Start();

            this.DoubleBuffered = true;
            Con = new Functions();
            CountStudents();
            CountDepartments();
            CountMale();
            CountFemale();



        }


        private void CountStudents()
        {
            string Query = "Select Count(*) as Stud from StudentTbl";
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                StudNumLbl.Text = dr["Stud"].ToString();
            }
        }

        private void CountDepartments()
        {
            string Query = "Select Count(*) as Dep from DepartmentTbl";
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DepNumLbl.Text = dr["Dep"].ToString();
            }
        }

        private void CountMale()
        {
            string Gen = "Male";
            string Query = "Select Count(*) as Male from StudentTbl where StGen='{0}'";
            Query = string.Format(Query, Gen);
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                MaleStudLbl.Text = dr["Male"].ToString();
            }
        }

        private void CountFemale()
        {
            string Gen = "Female";
            string Query = "Select Count(*) as Female from StudentTbl where StGen='{0}'";
            Query = string.Format(Query, Gen);
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                FemaleStudLbl.Text = dr["Female"].ToString();
            }
        }

        private void StudentLbl_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.ShowDialog();
            this.Close();

        }

        private void DepLbl_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.ShowDialog();
            this.Close();


        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}



