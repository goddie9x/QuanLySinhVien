using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class SubjectBUS
    {
        public List<Subject> GetAllSubject() 
        {
            return DatabaseAccess.GetAllSubject();
        }
        public DataTable GetAllSubjectDataTable()
        {
            return DatabaseAccess.GetAllSubjectDataTable();
        }
        public List<Subject> GetAllSubjectAreLearningThisSemester(string semester)
        {
            int semesterInt = int.Parse(semester);
            return DatabaseAccess.GetAllSubjectAreLearningThisSemester(semesterInt);
        }
        public List<Subject> GetAllSubjectAreLearningThisSemesterAndStudentId(string semester, string StudentId)
        {
            int semesterInt = int.Parse(semester);
            return DatabaseAccess.GetAllSubjectAreLearningThisSemesterAndStudentId(semesterInt, StudentId);
        }
    }
}
