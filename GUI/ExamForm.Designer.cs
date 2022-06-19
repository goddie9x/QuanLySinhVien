
namespace GUI
{
    partial class ExamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionListPanel = new System.Windows.Forms.Panel();
            this.AmountQuestionBox = new System.Windows.Forms.TextBox();
            this.SetAmountQuestionBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectSelects = new System.Windows.Forms.ComboBox();
            this.TimeOutBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeOutErrLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeOutPanel = new System.Windows.Forms.Panel();
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.TypeSelect = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExamNameField = new System.Windows.Forms.TextBox();
            this.ExamNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TimeOutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionListPanel
            // 
            this.QuestionListPanel.AutoScroll = true;
            this.QuestionListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuestionListPanel.Location = new System.Drawing.Point(15, 75);
            this.QuestionListPanel.Name = "QuestionListPanel";
            this.QuestionListPanel.Size = new System.Drawing.Size(630, 447);
            this.QuestionListPanel.TabIndex = 0;
            // 
            // AmountQuestionBox
            // 
            this.AmountQuestionBox.Location = new System.Drawing.Point(9, 32);
            this.AmountQuestionBox.Name = "AmountQuestionBox";
            this.AmountQuestionBox.Size = new System.Drawing.Size(164, 20);
            this.AmountQuestionBox.TabIndex = 1;
            this.AmountQuestionBox.TextChanged += new System.EventHandler(this.AmountQuestionBox_TextChanged);
            // 
            // SetAmountQuestionBtn
            // 
            this.SetAmountQuestionBtn.AutoSize = true;
            this.SetAmountQuestionBtn.Location = new System.Drawing.Point(9, 58);
            this.SetAmountQuestionBtn.Name = "SetAmountQuestionBtn";
            this.SetAmountQuestionBtn.Size = new System.Drawing.Size(75, 23);
            this.SetAmountQuestionBtn.TabIndex = 2;
            this.SetAmountQuestionBtn.Text = "Set";
            this.SetAmountQuestionBtn.UseVisualStyleBackColor = true;
            this.SetAmountQuestionBtn.Click += new System.EventHandler(this.SetAmountQuestionBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Enabled = false;
            this.ConfirmBtn.Location = new System.Drawing.Point(12, 379);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 3;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject";
            // 
            // subjectSelects
            // 
            this.subjectSelects.FormattingEnabled = true;
            this.subjectSelects.Location = new System.Drawing.Point(9, 107);
            this.subjectSelects.Name = "subjectSelects";
            this.subjectSelects.Size = new System.Drawing.Size(164, 21);
            this.subjectSelects.TabIndex = 7;
            this.subjectSelects.SelectedIndexChanged += new System.EventHandler(this.subjectSelects_SelectedIndexChanged);
            // 
            // TimeOutBox
            // 
            this.TimeOutBox.Location = new System.Drawing.Point(8, 24);
            this.TimeOutBox.Name = "TimeOutBox";
            this.TimeOutBox.Size = new System.Drawing.Size(164, 20);
            this.TimeOutBox.TabIndex = 9;
            this.TimeOutBox.TextChanged += new System.EventHandler(this.TimeOutBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "TimeOut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount:";
            // 
            // TimeOutErrLabel
            // 
            this.TimeOutErrLabel.AutoSize = true;
            this.TimeOutErrLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeOutErrLabel.Location = new System.Drawing.Point(8, 47);
            this.TimeOutErrLabel.Name = "TimeOutErrLabel";
            this.TimeOutErrLabel.Size = new System.Drawing.Size(164, 13);
            this.TimeOutErrLabel.TabIndex = 12;
            this.TimeOutErrLabel.Text = "Timeout error format(type: hh:mm)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TimeOutPanel);
            this.panel1.Controls.Add(this.CountdownLabel);
            this.panel1.Controls.Add(this.TypeSelect);
            this.panel1.Controls.Add(this.TypeLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ConfirmBtn);
            this.panel1.Controls.Add(this.AmountQuestionBox);
            this.panel1.Controls.Add(this.SetAmountQuestionBtn);
            this.panel1.Controls.Add(this.subjectSelects);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(651, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 447);
            this.panel1.TabIndex = 13;
            // 
            // TimeOutPanel
            // 
            this.TimeOutPanel.Controls.Add(this.label2);
            this.TimeOutPanel.Controls.Add(this.TimeOutBox);
            this.TimeOutPanel.Controls.Add(this.TimeOutErrLabel);
            this.TimeOutPanel.Location = new System.Drawing.Point(3, 212);
            this.TimeOutPanel.Name = "TimeOutPanel";
            this.TimeOutPanel.Size = new System.Drawing.Size(179, 73);
            this.TimeOutPanel.TabIndex = 16;
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.AutoSize = true;
            this.CountdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel.ForeColor = System.Drawing.Color.Lime;
            this.CountdownLabel.Location = new System.Drawing.Point(6, 311);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(174, 46);
            this.CountdownLabel.TabIndex = 15;
            this.CountdownLabel.Text = "00:00:00";
            // 
            // TypeSelect
            // 
            this.TypeSelect.FormattingEnabled = true;
            this.TypeSelect.Items.AddRange(new object[] {
            "Mid term",
            "End term"});
            this.TypeSelect.Location = new System.Drawing.Point(9, 167);
            this.TypeSelect.Name = "TypeSelect";
            this.TypeSelect.Size = new System.Drawing.Size(164, 21);
            this.TypeSelect.TabIndex = 13;
            this.TypeSelect.SelectedIndexChanged += new System.EventHandler(this.TypeSelect_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(9, 151);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 14;
            this.TypeLabel.Text = "Type";
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(12, 25);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(75, 23);
            this.HomeBtn.TabIndex = 14;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExamNameField);
            this.panel2.Controls.Add(this.ExamNameLabel);
            this.panel2.Location = new System.Drawing.Point(137, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 57);
            this.panel2.TabIndex = 15;
            // 
            // ExamNameField
            // 
            this.ExamNameField.Location = new System.Drawing.Point(100, 10);
            this.ExamNameField.Multiline = true;
            this.ExamNameField.Name = "ExamNameField";
            this.ExamNameField.Size = new System.Drawing.Size(399, 40);
            this.ExamNameField.TabIndex = 1;
            this.ExamNameField.TextChanged += new System.EventHandler(this.ExamNameField_TextChanged);
            // 
            // ExamNameLabel
            // 
            this.ExamNameLabel.AutoSize = true;
            this.ExamNameLabel.Location = new System.Drawing.Point(17, 13);
            this.ExamNameLabel.Name = "ExamNameLabel";
            this.ExamNameLabel.Size = new System.Drawing.Size(65, 13);
            this.ExamNameLabel.TabIndex = 0;
            this.ExamNameLabel.Text = "Exam name:";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.QuestionListPanel);
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamForm_FormClosing);
            this.Shown += new System.EventHandler(this.ExamForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TimeOutPanel.ResumeLayout(false);
            this.TimeOutPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel QuestionListPanel;
        private System.Windows.Forms.TextBox AmountQuestionBox;
        private System.Windows.Forms.Button SetAmountQuestionBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subjectSelects;
        private System.Windows.Forms.TextBox TimeOutBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TimeOutErrLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox TypeSelect;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label CountdownLabel;
        private System.Windows.Forms.Panel TimeOutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ExamNameField;
        private System.Windows.Forms.Label ExamNameLabel;
    }
}