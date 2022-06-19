using System;
using System.Linq;

namespace DTO
{
    public class QuestionItemInfo
    {
        public string question;
        public string answers;
        public string radioAnswer;
        public string checkBoxAnswers;
        public string index;
        public string ExamId;
        public string id;

        public QuestionItemInfo(string index)
        {
            this.index = index;
            this.question = "";
            this.answers = "";
            this.radioAnswer = "";
            this.checkBoxAnswers = "";
        }
        //the answers string is the list answer like: 1.answer1;2.answer2;3.answer3;4.answer4,we will split it later
        public QuestionItemInfo(string id, string ExamId,string question, string answers, string radioAnswer, string checkBoxAnswers, string questionIndex)
        {
            this.index = questionIndex;
            this.id = id;
            this.question = question;
            this.answers = answers;
            this.radioAnswer = radioAnswer;
            this.checkBoxAnswers = checkBoxAnswers;
            this.ExamId = ExamId;
        }
        //for store question to the database
        public QuestionItemInfo(string ExamId, string index, string question, string[] answers, int radioAnswerSelected, bool[] checkBoxAnswersSelected)
        {
            this.index = index;
            this.question = question;
            this.answers = string.Join(";", answers);
            this.radioAnswer = "" + radioAnswerSelected;
            this.checkBoxAnswers = string.Join(";", checkBoxAnswersSelected);
            this.ExamId = ExamId;
        }
        public string[] GetListAswers()
        {
            return answers.Split(';');
        }
        public int GetRadioAnswerSelected()
        {
            return Convert.ToInt32(radioAnswer);
        }
        public void SetExamId(string examId)
        {
            this.ExamId = examId;
        }
        public bool[] GetTruthCheckboxSelected()
        {
            return checkBoxAnswers.Split(';').Select(checkBox => bool.Parse(checkBox)).ToArray();
        }
    }
}
