using System;
using System.Windows.Forms;
using DTO;
using BUS;


namespace GUI
{
    public partial class Login : Form
    {
        
        public static Account account = new Account();
        AccountBUS acBUS = new AccountBUS();
        StudentManagement studentManagement;

        public Login()
        {
            InitializeComponent();
        }
        public Login(StudentManagement studentManagement)
        {
            InitializeComponent();
            this.studentManagement = studentManagement;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (userName == "" || password == "")
            {
                MessageBox.Show("All field must not be empty!");
            }
            else
            {
                account.sUsername = userName;
                account.sPassword = password;
                if (acBUS.GetUserInfo(ref account))
                {
                    MessageBox.Show("login successfully!!");
                    this.Hide();
                    Home homeView = new Home();
                    homeView.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrected!");
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
