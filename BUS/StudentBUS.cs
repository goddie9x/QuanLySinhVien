using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class StudentBUS
    {
        public StudentBUS() { }
        public DataTable GetAllStudentInfo()
        {
            return DatabaseAccess.GetAllStudentsDataTable();
        }
        public List<Student> GetAllStudent()
        {
            return DatabaseAccess.GetAllStudents();
        }

        public bool UpdateStudentInfo(Student student)
        {
            return DatabaseAccess.UpdateStudentInfo(student);
        }
        public bool AddStudent(Student student)
        {
            return DatabaseAccess.AddStudent(student);
        }
        public bool DeleteStudent(Student student)
        {
            return DatabaseAccess.DeleteStudent(student);
        }
        public Student GetStudentInfoById(string studentID)
        {
            return DatabaseAccess.GetStudentInfoById(studentID);
        }
        public List<Student> GetStudentsByString(string queryText)
        {
            return DatabaseAccess.GetStudentsByString(queryText);
        }
        public bool HandlePresentation(string studentID, string subjectID)
        {
            return DatabaseAccess.HandlePresentation(studentID, subjectID);
        }
    }
}
