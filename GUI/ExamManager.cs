using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class ExamManager : Form
    {
        private ExamBUS examBus = new ExamBUS();
        private SubjectBUS SubjectBUS = new SubjectBUS();
        private List<Exam> examsCreatedByCurrentAccount = new List<Exam>();
        private bool isStudent = Login.account.RoleID == 2;
        private List<Subject> subjects = new List<Subject>();
        public ExamManager()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            ExamGrid.Visible = !isStudent;
            CreateBtn.Visible = !isStudent;
            HandleExamIDBtn.Text = isStudent ? "Do" : "Search";
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm();
            this.Hide();
            examForm.ShowDialog();
        }

        private void ExamIdField_TextChanged(object sender, EventArgs e)
        {

        }

        private void HandleExamIDBtn_Click(object sender, EventArgs e)
        {
            if (isStudent)
            {
                ExamForm examForm = new ExamForm(ExamIdField.Text);
                this.Hide();
                examForm.ShowDialog();
            }
            else
            {
                string ExamIDText = ExamIdField.Text;
                if (ExamIDText == "")
                {
                    RenderExamGrid();
                }
                else
                {
                    Exam crrExam = examBus.GetExamById(Login.account.sAccountID);
                    if (crrExam != null)
                    {
                        ExamGrid.Rows.Clear();
                        AddAnExamToExamGrid(crrExam);
                    }
                    else
                    {
                        RenderExamGrid();
                    }
                }
            }
        }
        private void AddAnExamToExamGrid(Exam crrExam)
        {
            string crrSubject = subjects.Single(subject =>
            {
                return subject.subjectId == crrExam.SubjectId;
            }).subjectName;
            ExamGrid.Rows.Add(crrExam.id, crrSubject, crrExam.GetTimeOutText(), crrExam.examName, crrExam.type);
        }
        private void RenderExamGrid()
        {
            if (isStudent)
            {
                return;
            }
            examsCreatedByCurrentAccount.Clear();
            ExamGrid.Rows.Clear();
            examsCreatedByCurrentAccount = examBus.GetAllExamCreatedByAccountID(Login.account.sAccountID);
            foreach (Exam exam in examsCreatedByCurrentAccount)
            {
                AddAnExamToExamGrid(exam);
            }
        }
        private void ExamManager_Load(object sender, EventArgs e)
        {
            if (!isStudent)
            {
                subjects = SubjectBUS.GetAllSubject();
                RenderExamGrid();
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (Home.instance == null)
            {
                Home.instance = new Home();
            }
            Home.instance.Show();
            this.Hide();
        }
    }
}
