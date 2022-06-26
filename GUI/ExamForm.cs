using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using GUI.Component;
namespace GUI
{
    public partial class ExamForm : Form
    {
        private Exam curExam = new Exam();
        private List<Subject> subjects = new List<Subject>();
        SubjectBUS subjectBUS = new SubjectBUS();
        ExamBUS examBUS = new ExamBUS();
        List<QuestionItemInfo> questionItemsInfo = new List<QuestionItemInfo>();
        List<QuestionItemComponent> questionItems = new List<QuestionItemComponent>();
        private bool isEnableConfirmBtn = false;
        private bool isStudent = Login.account.RoleID == 2;
        private GeneralBUS generalBUS = new GeneralBUS();
        private Task Countdown;
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public bool IsEnableConfirmBtn
        {
            get
            {
                return isEnableConfirmBtn;
            }
            set
            {
                isEnableConfirmBtn = value;
                ConfirmBtn.Enabled = isEnableConfirmBtn;
            }
        }
        public ExamForm()
        {
            InitializeComponent();
            GetAllSubject();
            curExam = new Exam();
            curExam.Semester = "" + generalBUS.GetCurrentSemester();
            curExam.sAccountID = Login.account.sAccountID;
            SetDisplayEditingOrDoingExam();
        }
        public ExamForm(string ExamID)
        {
            InitializeComponent();
            curExam.id = ExamID;
            SetDisplayEditingOrDoingExam();
        }
        private void SetDisplayEditingOrDoingExam()
        {//student just can do exam
            TimeOutPanel.Visible = !isStudent;
            SetAmountQuestionBtn.Visible = !isStudent;
            AmountQuestionBox.Enabled = !isStudent;
            subjectSelects.Enabled = !isStudent;
            TypeSelect.Enabled = !isStudent;
            CountdownLabel.Visible = isStudent;
            ExamNameField.Enabled = !isStudent;
        }
        private void GetExamInfoByID(string ExamID)
        {
            curExam = examBUS.GetExamById(ExamID);
            if (curExam != null)
            {
                subjectSelects.SelectedItem = curExam.SubjectId;
                TimeOutBox.Text = curExam.GetTimeOutText();
                ExamNameField.Text = curExam.examName;
                subjectSelects.SelectedItem = subjects.FirstOrDefault(s=>s.subjectId == curExam.SubjectId).subjectName;
                TypeSelect.SelectedIndex = curExam.type;
                GetAllQuestion();
            }
            else
            {
                MessageBox.Show("Exam ID not exit");
                ReturnHomeForm();
            }
        }
        private void GetAllQuestion()
        {
            questionItemsInfo = examBUS.GetQuestionItemInfosByExamId(curExam.id);
            if (questionItemsInfo.Count < 1)
            {
                MessageBox.Show("Something went wrong with this exam, please contact to your teacher");
                return;
            }
            AmountQuestionBox.Text = "" + questionItemsInfo.Count;
            if (questionItemsInfo != null)
            {
                SetInfoForAllQuestion();
            }
        }
        private void GetAllSubject()
        {
            subjectSelects.Items.Clear();
            subjects = subjectBUS.GetAllSubject();
            if (subjects != null)
            {
                foreach (Subject item in subjects)
                {
                    subjectSelects.Items.Add(item.subjectName);
                }
            }
        }

        private void SetInfoForAllQuestion()
        {
            QuestionListPanel.Controls.Clear();
            questionItems.Clear();
            foreach (QuestionItemInfo questionItemInfo in questionItemsInfo)
            {
                QuestionItemComponent temp = new QuestionItemComponent(questionItemInfo, isStudent);
                temp.Location = new System.Drawing.Point(0, 400 * (Convert.ToInt32(questionItemInfo.index)-1));
                questionItems.Add(temp);
                QuestionListPanel.Controls.Add(temp);
            }
            if (isStudent)
            {
                StartCownDown();
            }
        }
        private void SetAmountQuestionBtn_Click(object sender, System.EventArgs e)
        {
            int amountQuestion = Convert.ToInt32(AmountQuestionBox.Text);
            QuestionListPanel.Controls.Clear();
            questionItems.Clear();
            for (int i = 1; i <= amountQuestion; i++)
            {
                QuestionItemComponent temp = new QuestionItemComponent("" + i);
                temp.Location = new System.Drawing.Point(0, 400 * (i - 1));
                questionItems.Add(temp);
                QuestionListPanel.Controls.Add(temp);
            }
        }

        private void EditExam()
        {
            examBUS.EditExam(curExam);
            foreach (QuestionItemComponent questionItemComponent in questionItems)
            {
                QuestionItemInfo questionItemInfo = questionItemComponent.GetQuestionItemInfo();
                questionItemInfo.SetExamId(curExam.id);
                examBUS.UpdateQuestion(questionItemInfo);
            }
            MessageBox.Show("Edit the exam success!");
        }

        private void CreateExam()
        {
            curExam.id = examBUS.CreateExam(curExam);
            if (curExam.id != "")
            {
                foreach (QuestionItemComponent questionItemComponent in questionItems)
                {
                    QuestionItemInfo questionItemInfo = questionItemComponent.GetQuestionItemInfo();
                    questionItemInfo.SetExamId(curExam.id);
                    examBUS.CreatQuestion(questionItemInfo);
                }
                MessageBox.Show("Create the exam success!, the exam ID is: "+ curExam.id+" (student can use this to do exam)");
            }
            else
            {
                MessageBox.Show("Create exam failed");
            }
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (questionItems.Count < 1)
            {
                MessageBox.Show("Please input at lease 1 question");
                return;
            }
            if (isStudent)
            {
                CalculatorPoint();
            }
            else
            {//is editing an exit exam
                if (curExam.id != "")
                {
                    EditExam();
                }
                else
                {
                    CreateExam();
                }
            }
        }
        private void StartCownDown()
        {
            Countdown = new Task(() =>
            {
                int timeout = curExam.timeOut;
                for (int time = timeout; time >= 0; time--)
                {
                    TimeSpan crrTime = TimeSpan.FromSeconds(time);
                    if (!cancellationTokenSource.IsCancellationRequested)
                    {
                        this.Invoke(new Action(() =>
                        {
                            CountdownLabel.Text = crrTime.ToString(@"hh\:mm\:ss");
                        }));
                        Thread.Sleep(1000);
                    }
                }
                if (!cancellationTokenSource.IsCancellationRequested)
                {
                    MessageBox.Show("Time out");
                    this.Invoke(new Action(() =>
                    {
                        CalculatorPoint();
                    }));
                }
            }, cancellationTokenSource.Token);
            Countdown.Start();
        }
        private void CalculatorPoint()
        {
            if (questionItems.Count == 0)
            {
                return;
            }
            double pointPerQuest = 10 / questionItems.Count;
            double totalPoint = 0;

            foreach (QuestionItemComponent quest in questionItems)
            {
                if (quest.CheckCorrectAnswer())
                {
                    totalPoint += pointPerQuest;
                }
            }
            int point = (int)Math.Round(totalPoint,1);
            examBUS.SetExamPoint(curExam.SubjectId, curExam.Semester, curExam.type, point,Login.account.sAccountID,curExam.id);
            MessageBox.Show("you are finish your exam, good luck");
            if(Countdown!=null)
            {
                cancellationTokenSource.Cancel();
            }
            ReturnHomeForm();
        }
        private void TimeOutBox_TextChanged(object sender, EventArgs e)
        {
            string timeout = TimeOutBox.Text;
            bool isSatifyCondition = (curExam.SetTimeOutByString(timeout));
            TimeOutErrLabel.Visible = !isSatifyCondition;
            IsEnableConfirmBtn = isSatifyCondition;
        }

        private void AmountQuestionBox_TextChanged(object sender, EventArgs e)
        {
            int amount;
            if (!int.TryParse(AmountQuestionBox.Text, out amount))
            {
                MessageBox.Show("Please enter number for this field");
            }
            else
            {
            }
        }
        private void ReturnHomeForm()
        {
            if (Home.instance == null)
            {
                Home.instance = new Home();
            }
            Home.instance.Show();
            this.Hide();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ReturnHomeForm();
        }

        private void subjectSelects_SelectedIndexChanged(object sender, EventArgs e)
        {
            curExam.SubjectId = subjects[subjectSelects.SelectedIndex].subjectId;
        }

        private void TypeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            curExam.type = TypeSelect.SelectedIndex;
        }

        private void ExamForm_Shown(object sender, EventArgs e)
        {
            GetAllSubject();
            if (curExam.id != "")
            {
                if(!examBUS.CheckUserTookExam(Login.account.sAccountID, curExam.id)){
                    GetExamInfoByID(curExam.id);
                }
                else
                {
                    MessageBox.Show("Something went wrong or you already took that exam");
                }
            }
        }

        private void ExamNameField_TextChanged(object sender, EventArgs e)
        {
            curExam.examName = ExamNameField.Text;
        }

        private void ExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isStudent)
            {
                CalculatorPoint();
            }
        }
    }
}
