namespace Student_Registration_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if (UNameTb.Text == "Admin" && PasswordTb.Text == "Password")
            {
                // Students Obj = new Students();
                Dashboard Obj = new Dashboard();
                Obj.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name Or Password!!!");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}