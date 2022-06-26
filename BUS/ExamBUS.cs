using DAL;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class ExamBUS
    {
        public Exam GetExamById(string ExamId)
        {
            return DatabaseAccess.GetExamById(ExamId);
        }
        public bool CheckUserTookExam(string sAccountID, string ExamId)
        {
            return DatabaseAccess.CheckUserTookExam(sAccountID, ExamId);
        }
        public List<QuestionItemInfo> GetQuestionItemInfosByExamId(string ExamId)
        {
            return DatabaseAccess.GetQuestionItemInfosByExamId(ExamId);
        }
        public string CreateExam(Exam exam)
        {
            return DatabaseAccess.CreateExam(exam);
        }
        public bool CreatQuestion(QuestionItemInfo questionItem)
        {
            return DatabaseAccess.CreatQuestion(questionItem);
        }
        public bool EditExam(Exam exam)
        {
            return DatabaseAccess.EditExam(exam);
        }
        public bool UpdateQuestion(QuestionItemInfo questionItem)
        {
            return DatabaseAccess.UpdateQuestion(questionItem);
        }
        public List<Exam> GetAllExamCreatedByAccountID(string sAccountID)
        {
            return DatabaseAccess.GetAllExamCreatedByAccountID(sAccountID);
        }
        public bool SetExamPoint(string SubjectId, string Semester, int termType, int point, string sAccountID, string ExamId)

        {
            return DatabaseAccess.SetExamPoint(SubjectId, Semester, termType, point,sAccountID,ExamId);
        }
    }
}
