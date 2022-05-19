using DTO;
using System;

using System.Windows.Forms;

namespace GUI
{
    public partial class Home : Form
    {
        private StudentManagement studentManagement;
        private Login login;
        public static Home instance;

        public Home(StudentManagement studentManagement = null)
        {
            InitializeComponent();
            this.studentManagement = studentManagement;
        }
        private void btnStudentMana_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (studentManagement == null)
            {
                studentManagement = new StudentManagement(this);
            }
            studentManagement.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(login == null)
            {
                login = new Login();
            }
            login.Show();
        }

        private void btnPresentation_Click(object sender, EventArgs e)
        {
            Pesentation presentView = new Pesentation();
            this.Dispose();
            presentView.ShowDialog();
        }
    }
}
