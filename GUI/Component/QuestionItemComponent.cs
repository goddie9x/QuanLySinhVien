
using DTO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.Component
{
    partial class QuestionItemComponent : Panel
    {
        private void InitializeComponent()
        {
            this.SwitchEditConfirm = new Button();
            this.QuestionLabelPanel = new Panel();
            this.QuestionBox = new TextBox();
            this.AnswerPanel = new Panel();
            this.panelAnswerC = new Panel();
            this.AnswerCRadio = new RadioButton();
            this.AnswerCCheckbox = new CheckBox();
            this.AnswerCTextbox = new TextBox();
            this.panelAnswerB = new Panel();
            this.AnswerBRadio = new RadioButton();
            this.AnswerBTextbox = new TextBox();
            this.AnswerBCheckbox = new CheckBox();
            this.panelAnswerD = new Panel();
            this.AnswerDRadio = new RadioButton();
            this.AnswerDCheckbox = new CheckBox();
            this.AnswerDTextbox = new TextBox();
            this.panelAnswerA = new Panel();
            this.AnswerATextbox = new TextBox();
            this.AnswerARadio = new RadioButton();
            this.AnswerACheckbox = new CheckBox();
            this.QuestionType = new Label();
            this.AnswerLabel = new Label();
            this.QuestionTypePanel = new Panel();
            this.MultipleTypeRadio = new RadioButton();
            this.SingleTypeRadio = new RadioButton();
            this.labelQuestion = new Label();
            this.SuspendLayout();
            this.QuestionLabelPanel.SuspendLayout();
            this.AnswerPanel.SuspendLayout();
            this.panelAnswerC.SuspendLayout();
            this.panelAnswerB.SuspendLayout();
            this.panelAnswerD.SuspendLayout();
            this.panelAnswerA.SuspendLayout();
            this.QuestionTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionPanel
            // 
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.SwitchEditConfirm);
            this.Controls.Add(this.QuestionLabelPanel);
            this.Controls.Add(this.AnswerPanel);
            this.Controls.Add(this.QuestionType);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionTypePanel);
            this.Controls.Add(this.labelQuestion);
            this.Location = new System.Drawing.Point(74, 32);
            this.Name = "QuestionPanel";
            this.Size = new System.Drawing.Size(591, 378);
            this.TabIndex = 0;
            // 
            // SwitchEditConfirm
            // 
            this.SwitchEditConfirm.Location = new System.Drawing.Point(494, 99);
            this.SwitchEditConfirm.Name = "SwitchEditConfirm";
            this.SwitchEditConfirm.Size = new System.Drawing.Size(75, 23);
            this.SwitchEditConfirm.TabIndex = 1;
            this.SwitchEditConfirm.Text = "Confirm";
            this.SwitchEditConfirm.UseVisualStyleBackColor = true;
            this.SwitchEditConfirm.Click += new System.EventHandler(this.Switch_Click);
            // 
            // QuestionLabelPanel
            // 
            this.QuestionLabelPanel.AutoSize = true;
            this.QuestionLabelPanel.Controls.Add(this.QuestionBox);
            this.QuestionLabelPanel.Location = new System.Drawing.Point(28, 38);
            this.QuestionLabelPanel.MaximumSize = new System.Drawing.Size(600, 0);
            this.QuestionLabelPanel.Name = "QuestionLabelPanel";
            this.QuestionLabelPanel.Size = new System.Drawing.Size(448, 73);
            this.QuestionLabelPanel.TabIndex = 17;
            // 
            // QuestionBox
            // 
            this.QuestionBox.Location = new System.Drawing.Point(0, 3);
            this.QuestionBox.Multiline = true;
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.ScrollBars = ScrollBars.Both;
            this.QuestionBox.Size = new System.Drawing.Size(445, 67);
            this.QuestionBox.TabIndex = 16;
            this.QuestionBox.TextChanged += new System.EventHandler(this.QuestionBox_TextChanged);
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.AutoSize = true;
            this.AnswerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AnswerPanel.Controls.Add(this.panelAnswerC);
            this.AnswerPanel.Controls.Add(this.panelAnswerB);
            this.AnswerPanel.Controls.Add(this.panelAnswerD);
            this.AnswerPanel.Controls.Add(this.panelAnswerA);
            this.AnswerPanel.Location = new System.Drawing.Point(25, 151);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.Size = new System.Drawing.Size(550, 224);
            this.AnswerPanel.TabIndex = 11;
            // 
            // panelAnswerC
            // 
            this.panelAnswerC.AutoSize = true;
            this.panelAnswerC.Controls.Add(this.AnswerCRadio);
            this.panelAnswerC.Controls.Add(this.AnswerCCheckbox);
            this.panelAnswerC.Controls.Add(this.AnswerCTextbox);
            this.panelAnswerC.Location = new System.Drawing.Point(3, 115);
            this.panelAnswerC.Name = "panelAnswerC";
            this.panelAnswerC.Size = new System.Drawing.Size(544, 50);
            this.panelAnswerC.TabIndex = 21;
            // 
            // AnswerCRadio
            // 
            this.AnswerCRadio.AutoSize = true;
            this.AnswerCRadio.Location = new System.Drawing.Point(13, 17);
            this.AnswerCRadio.Name = "AnswerCRadio";
            this.AnswerCRadio.Size = new System.Drawing.Size(35, 17);
            this.AnswerCRadio.TabIndex = 7;
            this.AnswerCRadio.TabStop = true;
            this.AnswerCRadio.Text = "C.";
            this.AnswerCRadio.UseVisualStyleBackColor = true;
            this.AnswerCRadio.CheckedChanged += new System.EventHandler(this.AnswerRadio_CheckedChanged);
            // 
            // AnswerCCheckbox
            // 
            this.AnswerCCheckbox.AutoSize = true;
            this.AnswerCCheckbox.Location = new System.Drawing.Point(13, 16);
            this.AnswerCCheckbox.Name = "AnswerCCheckbox";
            this.AnswerCCheckbox.Size = new System.Drawing.Size(36, 17);
            this.AnswerCCheckbox.TabIndex = 2;
            this.AnswerCCheckbox.Text = "C.";
            this.AnswerCCheckbox.UseVisualStyleBackColor = true;
            // 
            // AnswerCTextbox
            // 
            this.AnswerCTextbox.Location = new System.Drawing.Point(66, 0);
            this.AnswerCTextbox.Multiline = true;
            this.AnswerCTextbox.Name = "AnswerCTextbox";
            this.AnswerCTextbox.ScrollBars = ScrollBars.Both;
            this.AnswerCTextbox.Size = new System.Drawing.Size(475, 47);
            this.AnswerCTextbox.TabIndex = 15;
            // 
            // panelAnswerB
            // 
            this.panelAnswerB.AutoSize = true;
            this.panelAnswerB.Controls.Add(this.AnswerBRadio);
            this.panelAnswerB.Controls.Add(this.AnswerBTextbox);
            this.panelAnswerB.Controls.Add(this.AnswerBCheckbox);
            this.panelAnswerB.Location = new System.Drawing.Point(3, 59);
            this.panelAnswerB.Name = "panelAnswerB";
            this.panelAnswerB.Size = new System.Drawing.Size(544, 50);
            this.panelAnswerB.TabIndex = 21;
            // 
            // AnswerBRadio
            // 
            this.AnswerBRadio.AutoSize = true;
            this.AnswerBRadio.Location = new System.Drawing.Point(12, 13);
            this.AnswerBRadio.Name = "AnswerBRadio";
            this.AnswerBRadio.Size = new System.Drawing.Size(35, 17);
            this.AnswerBRadio.TabIndex = 5;
            this.AnswerBRadio.TabStop = true;
            this.AnswerBRadio.Text = "B.";
            this.AnswerBRadio.UseVisualStyleBackColor = true;
            this.AnswerBRadio.CheckedChanged += new System.EventHandler(this.AnswerRadio_CheckedChanged);
            // 
            // AnswerBTextbox
            // 
            this.AnswerBTextbox.Location = new System.Drawing.Point(66, 0);
            this.AnswerBTextbox.Multiline = true;
            this.AnswerBTextbox.Name = "AnswerBTextbox";
            this.AnswerBTextbox.ScrollBars = ScrollBars.Both;
            this.AnswerBTextbox.Size = new System.Drawing.Size(475, 47);
            this.AnswerBTextbox.TabIndex = 14;
            // 
            // AnswerBCheckbox
            // 
            this.AnswerBCheckbox.AutoSize = true;
            this.AnswerBCheckbox.Location = new System.Drawing.Point(13, 13);
            this.AnswerBCheckbox.Name = "AnswerBCheckbox";
            this.AnswerBCheckbox.Size = new System.Drawing.Size(36, 17);
            this.AnswerBCheckbox.TabIndex = 5;
            this.AnswerBCheckbox.Text = "B.";
            this.AnswerBCheckbox.UseVisualStyleBackColor = true;
            // 
            // panelAnswerD
            // 
            this.panelAnswerD.AutoSize = true;
            this.panelAnswerD.Controls.Add(this.AnswerDRadio);
            this.panelAnswerD.Controls.Add(this.AnswerDCheckbox);
            this.panelAnswerD.Controls.Add(this.AnswerDTextbox);
            this.panelAnswerD.Location = new System.Drawing.Point(3, 171);
            this.panelAnswerD.Name = "panelAnswerD";
            this.panelAnswerD.Size = new System.Drawing.Size(544, 50);
            this.panelAnswerD.TabIndex = 21;
            // 
            // AnswerDRadio
            // 
            this.AnswerDRadio.AutoSize = true;
            this.AnswerDRadio.Location = new System.Drawing.Point(12, 11);
            this.AnswerDRadio.Name = "AnswerDRadio";
            this.AnswerDRadio.Size = new System.Drawing.Size(36, 17);
            this.AnswerDRadio.TabIndex = 8;
            this.AnswerDRadio.TabStop = true;
            this.AnswerDRadio.Text = "D.";
            this.AnswerDRadio.UseVisualStyleBackColor = true;
            this.AnswerDRadio.CheckedChanged += new System.EventHandler(this.AnswerRadio_CheckedChanged);
            // 
            // AnswerDCheckbox
            // 
            this.AnswerDCheckbox.AutoSize = true;
            this.AnswerDCheckbox.Location = new System.Drawing.Point(13, 12);
            this.AnswerDCheckbox.Name = "AnswerDCheckbox";
            this.AnswerDCheckbox.Size = new System.Drawing.Size(37, 17);
            this.AnswerDCheckbox.TabIndex = 3;
            this.AnswerDCheckbox.Text = "D.";
            this.AnswerDCheckbox.UseVisualStyleBackColor = true;
            // 
            // AnswerDTextbox
            // 
            this.AnswerDTextbox.Location = new System.Drawing.Point(66, 0);
            this.AnswerDTextbox.Multiline = true;
            this.AnswerDTextbox.Name = "AnswerDTextbox";
            this.AnswerDTextbox.ScrollBars = ScrollBars.Both;
            this.AnswerDTextbox.Size = new System.Drawing.Size(475, 47);
            this.AnswerDTextbox.TabIndex = 16;
            // 
            // panelAnswerA
            // 
            this.panelAnswerA.AutoSize = true;
            this.panelAnswerA.Controls.Add(this.AnswerATextbox);
            this.panelAnswerA.Controls.Add(this.AnswerARadio);
            this.panelAnswerA.Controls.Add(this.AnswerACheckbox);
            this.panelAnswerA.Location = new System.Drawing.Point(3, 3);
            this.panelAnswerA.Name = "panelAnswerA";
            this.panelAnswerA.Size = new System.Drawing.Size(544, 50);
            this.panelAnswerA.TabIndex = 20;
            // 
            // AnswerATextbox
            // 
            this.AnswerATextbox.Location = new System.Drawing.Point(66, 0);
            this.AnswerATextbox.Multiline = true;
            this.AnswerATextbox.Name = "AnswerATextbox";
            this.AnswerATextbox.ScrollBars = ScrollBars.Both;
            this.AnswerATextbox.Size = new System.Drawing.Size(475, 47);
            this.AnswerATextbox.TabIndex = 13;
            // 
            // AnswerARadio
            // 
            this.AnswerARadio.AutoSize = true;
            this.AnswerARadio.Location = new System.Drawing.Point(13, 15);
            this.AnswerARadio.Name = "AnswerARadio";
            this.AnswerARadio.Size = new System.Drawing.Size(35, 17);
            this.AnswerARadio.TabIndex = 4;
            this.AnswerARadio.TabStop = true;
            this.AnswerARadio.Text = "A.";
            this.AnswerARadio.UseVisualStyleBackColor = true;
            this.AnswerARadio.CheckedChanged += new System.EventHandler(this.AnswerRadio_CheckedChanged);
            // 
            // AnswerACheckbox
            // 
            this.AnswerACheckbox.AutoSize = true;
            this.AnswerACheckbox.Location = new System.Drawing.Point(13, 15);
            this.AnswerACheckbox.Name = "AnswerACheckbox";
            this.AnswerACheckbox.Size = new System.Drawing.Size(36, 17);
            this.AnswerACheckbox.TabIndex = 4;
            this.AnswerACheckbox.Text = "A.";
            this.AnswerACheckbox.UseVisualStyleBackColor = true;
            // 
            // QuestionType
            // 
            this.QuestionType.AutoSize = true;
            this.QuestionType.Location = new System.Drawing.Point(498, 15);
            this.QuestionType.Name = "QuestionType";
            this.QuestionType.Size = new System.Drawing.Size(78, 13);
            this.QuestionType.TabIndex = 14;
            this.QuestionType.Text = "Question  type:";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(25, 126);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(45, 13);
            this.AnswerLabel.TabIndex = 13;
            this.AnswerLabel.Text = "Answer:";
            // 
            // QuestionTypePanel
            // 
            this.QuestionTypePanel.Controls.Add(this.SwitchEditConfirm);
            this.QuestionTypePanel.Controls.Add(this.QuestionType);
            this.QuestionTypePanel.Controls.Add(this.MultipleTypeRadio);
            this.QuestionTypePanel.Controls.Add(this.SingleTypeRadio);
            this.QuestionTypePanel.Location = new System.Drawing.Point(492, 41);
            this.QuestionTypePanel.Name = "QuestionTypePanel";
            this.QuestionTypePanel.Size = new System.Drawing.Size(96, 52);
            this.QuestionTypePanel.TabIndex = 9;
            // 
            // MultipleTypeRadio
            // 
            this.MultipleTypeRadio.AutoSize = true;
            this.MultipleTypeRadio.Location = new System.Drawing.Point(3, 28);
            this.MultipleTypeRadio.Name = "MultipleTypeRadio";
            this.MultipleTypeRadio.Size = new System.Drawing.Size(84, 17);
            this.MultipleTypeRadio.TabIndex = 2;
            this.MultipleTypeRadio.Text = "Multiple type";
            this.MultipleTypeRadio.UseVisualStyleBackColor = true;
            this.MultipleTypeRadio.CheckedChanged += new System.EventHandler(this.MultipleTypeRadio_CheckedChanged);
            // 
            // SingleTypeRadio
            // 
            this.SingleTypeRadio.AutoSize = true;
            this.SingleTypeRadio.Checked = true;
            this.SingleTypeRadio.Location = new System.Drawing.Point(3, 7);
            this.SingleTypeRadio.Name = "SingleTypeRadio";
            this.SingleTypeRadio.Size = new System.Drawing.Size(77, 17);
            this.SingleTypeRadio.TabIndex = 1;
            this.SingleTypeRadio.TabStop = true;
            this.SingleTypeRadio.Text = "Single type";
            this.SingleTypeRadio.UseVisualStyleBackColor = true;
            this.SingleTypeRadio.CheckedChanged += new System.EventHandler(this.SingleTypeRadio_CheckedChanged);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(25, 15);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(52, 13);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "Question:";
            // 
            // QuestionItem
            // 
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Name = "QuestionItem";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.QuestionLabelPanel.ResumeLayout(false);
            this.QuestionLabelPanel.PerformLayout();
            this.AnswerPanel.ResumeLayout(false);
            this.AnswerPanel.PerformLayout();
            this.panelAnswerC.ResumeLayout(false);
            this.panelAnswerC.PerformLayout();
            this.panelAnswerB.ResumeLayout(false);
            this.panelAnswerB.PerformLayout();
            this.panelAnswerD.ResumeLayout(false);
            this.panelAnswerD.PerformLayout();
            this.panelAnswerA.ResumeLayout(false);
            this.panelAnswerA.PerformLayout();
            this.QuestionTypePanel.ResumeLayout(false);
            this.QuestionTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private RadioButton AnswerBRadio;
        private RadioButton AnswerDRadio;
        private RadioButton AnswerCRadio;
        private Label labelQuestion;
        private CheckBox AnswerDCheckbox;
        private CheckBox AnswerCCheckbox;
        private CheckBox AnswerBCheckbox;
        private CheckBox AnswerACheckbox;
        private Panel QuestionTypePanel;
        private RadioButton MultipleTypeRadio;
        private RadioButton SingleTypeRadio;
        private Label QuestionType;
        private Label AnswerLabel;
        private Panel AnswerPanel;
        private Button SwitchEditConfirm;
        private TextBox AnswerDTextbox;
        private TextBox AnswerATextbox;
        private TextBox AnswerCTextbox;
        private TextBox AnswerBTextbox;
        private TextBox QuestionBox;
        private Panel QuestionLabelPanel;
        private Panel panelAnswerC;
        private Panel panelAnswerB;
        private Panel panelAnswerD;
        private Panel panelAnswerA;
        private RadioButton AnswerARadio;
        private bool isAnswering;
        private List<RadioButton> radioAnswerButtons = new List<RadioButton>();
        private QuestionItemInfo questionItemInfo;
        private string truthRadioAnswer;
        private string truthCheckboxAnswers;
        private bool isSingleSelect = false;
        public bool IsSingleSlect
        {
            get { return isSingleSelect; }
            set
            {
                this.isSingleSelect = value;
                AnswerARadio.Visible = isSingleSelect;
                AnswerBRadio.Visible = isSingleSelect;
                AnswerCRadio.Visible = isSingleSelect;
                AnswerDRadio.Visible = isSingleSelect;
                AnswerACheckbox.Visible = !isSingleSelect;
                AnswerBCheckbox.Visible = !isSingleSelect;
                AnswerCCheckbox.Visible = !isSingleSelect;
                AnswerDCheckbox.Visible = !isSingleSelect;
            }
        }
        public bool IsAnswering
        {
            get { return isAnswering; }
            set
            {
                isAnswering = value;
                QuestionBox.ReadOnly = isAnswering;
                AnswerATextbox.ReadOnly = isAnswering;
                AnswerBTextbox.ReadOnly = isAnswering;
                AnswerCTextbox.ReadOnly = isAnswering;
                AnswerDTextbox.ReadOnly = isAnswering;
                QuestionTypePanel.Visible = !isAnswering;
            }
        }
        public QuestionItemComponent(string index, bool isAnswering = false)
        {
            InitializeComponent();
            questionItemInfo = new QuestionItemInfo(index);
            this.isAnswering = isAnswering;
            this.labelQuestion.Text = "Question " + index + ":";
            InitRadioAnswerButtons();
        }
        public QuestionItemComponent(QuestionItemInfo questionItemInfo, bool isAnswering = false)
        {
            InitializeComponent();
            this.questionItemInfo = questionItemInfo;
            IsAnswering = isAnswering;
            InitQuestionItemWithInfo();
            InitRadioAnswerButtons();
            this.labelQuestion.Text = "Question" + questionItemInfo.index + ":";
            HandleShowQuestionTypeVisibleChanged();
            if (!isAnswering)
            {
                SetSelectedValue();
            }
            else
            {
                truthRadioAnswer = questionItemInfo.radioAnswer;
                truthCheckboxAnswers = questionItemInfo.checkBoxAnswers;
            }
        }

        private void SetSelectedValue()
        {
            if (questionItemInfo.radioAnswer != "")
            {
                radioAnswerButtons[int.Parse(questionItemInfo.radioAnswer)].Checked = true;
            }
            else
            {
                bool[]TruthCheckboxs = questionItemInfo.GetTruthCheckboxSelected();
                AnswerACheckbox.Checked = TruthCheckboxs[0];
                AnswerBCheckbox.Checked = TruthCheckboxs[1];
                AnswerCCheckbox.Checked = TruthCheckboxs[2];
                AnswerDCheckbox.Checked = TruthCheckboxs[3];
            }
        }
        private void InitRadioAnswerButtons()
        {
            radioAnswerButtons.Add(AnswerARadio);
            radioAnswerButtons.Add(AnswerBRadio);
            radioAnswerButtons.Add(AnswerCRadio);
            radioAnswerButtons.Add(AnswerDRadio);
        }
        private void InitQuestionItemWithInfo()
        {
            labelQuestion.Text = "Question " + questionItemInfo.index + ":";
            QuestionBox.Text = questionItemInfo.question;

            var ListAswers = questionItemInfo.GetListAswers();
            AnswerATextbox.Text = ListAswers[0];
            AnswerBTextbox.Text = ListAswers[1];
            AnswerCTextbox.Text = ListAswers[2];
            AnswerDTextbox.Text = ListAswers[3];
        }
        private void HandleShowQuestionTypeVisibleChanged()
        {
            IsSingleSlect = questionItemInfo.radioAnswer != "";
            SingleTypeRadio.Checked = isSingleSelect;
            MultipleTypeRadio.Checked = !isSingleSelect;
        }
        private void SingleTypeRadio_CheckedChanged(object sender, System.EventArgs e)
        {
            IsSingleSlect = SingleTypeRadio.Checked;
        }

        private void MultipleTypeRadio_CheckedChanged(object sender, System.EventArgs e)
        {
            IsSingleSlect = !MultipleTypeRadio.Checked;
        }

        private void QuestionBox_TextChanged(object sender, System.EventArgs e)
        {
            questionItemInfo.question = QuestionBox.Text.Trim();
        }

        private void Switch_Click(object sender, System.EventArgs e)
        {
            IsAnswering = !IsAnswering;
            SwitchEditConfirm.Text = IsAnswering ? "Edit" : "Confirm";
        }
        private void AnswerRadio_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton currentRadio = (RadioButton)sender;
            int index = 0;
            if (currentRadio.Checked)
            {
                foreach (RadioButton crrRadio in radioAnswerButtons)
                {
                    if (crrRadio != currentRadio)
                    {
                        crrRadio.Checked = false;
                    }
                    else
                    {
                        questionItemInfo.radioAnswer = "" + index;
                    }
                    index++;
                }
            }
        }
        public void GetCurrentAnswerInfo()
        {

            if (SingleTypeRadio.Checked)
            {
                questionItemInfo.checkBoxAnswers = "";
            }
            else
            {
                string checkBoxAnswers = AnswerACheckbox.Checked + ";" + AnswerBCheckbox.Checked + ";" + AnswerCCheckbox.Checked + ";" + AnswerDCheckbox.Checked;
                questionItemInfo.checkBoxAnswers = checkBoxAnswers;
                questionItemInfo.radioAnswer = "";
            }
        }
        public QuestionItemInfo GetQuestionItemInfo()
        {
            string answers = AnswerATextbox.Text + ";" + AnswerBTextbox.Text + ";" + AnswerCTextbox.Text + ";" + AnswerDTextbox.Text;
            GetCurrentAnswerInfo();
            questionItemInfo.question = QuestionBox.Text.Trim();
            questionItemInfo.answers = answers;
            return questionItemInfo;
        }
        public bool CheckCorrectAnswer()
        {
            GetCurrentAnswerInfo();
            if (truthRadioAnswer != "")
            {
                return questionItemInfo.radioAnswer == truthRadioAnswer;
            }
            else
            {
                return questionItemInfo.checkBoxAnswers == truthCheckboxAnswers;
            }
        }
    }
}
