using System;

using System.Windows.Forms;

namespace GUI
{
    public partial class Home : Form
    {
        public static Home instance;

        public Home()
        {
            InitializeComponent();
            instance=this;
        }
        private void btnStudentMana_Click()
        {
            this.Hide();
            if (StudentManagement.instance == null)
            {
                StudentManagement.instance = new StudentManagement();
            }
            try
            {
                StudentManagement.instance.ShowDialog();
            }
            catch(Exception e)
            {

            }
        }

        private void logoutBtn_Click()
        {
            this.Hide();
            Login instance = new Login();
            instance.ShowDialog();
        }

        private void btnPresentation_Click()
        {
            Pesentation presentView = new Pesentation();
            this.Hide();
            presentView.ShowDialog();
        }

        private void btnTranscript_Click()
        {
            AnalysisTerm analysisTerm = new AnalysisTerm();
            this.Hide();
            analysisTerm.ShowDialog();
        }
        private void transcriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTranscript_Click();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            logoutBtn_Click();
        }

        private void studentManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnStudentMana_Click();
        }

        private void presentationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnPresentation_Click();
        }

        private void transcriptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnTranscript_Click();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Home_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamForm exam = new ExamForm();
            this.Hide();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamManager examManager = new ExamManager();
            this.Hide();
            examManager.ShowDialog();
        }

        private void doToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamManager examManager = new ExamManager();
            this.Hide();
            examManager.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
             bool canManagerExam = Login.account.RoleID != 2;
            managerToolStripMenuItem.Visible = canManagerExam;
            createToolStripMenuItem1.Visible = canManagerExam;
            doToolStripMenuItem.Visible = !canManagerExam;
        }
    }
}
