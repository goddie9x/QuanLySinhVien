using System;

namespace DTO
{
    public class Student
    {
        #region attributes
        private string StudentId;
        private string DeleteId;
        private string StudentName;
        private string DateOfBirth;
        //0: male 1: female 2: other
        private int Gender;
        private string ClassId;

        public string studentId{
            get { return StudentId; }
            set
            {
                this.StudentId = value;
            }
        }

        public string deleteId
        {
            get { return DeleteId; }
            set
            {
                this.DeleteId = value;
            }
        }
        public string studentName
        {
            get { return StudentName; }
            set
            {
                this.StudentName = value;
            }
        }
        public string dateOfBirth
        {
            get { return DateOfBirth; }
            set
            {
                this.DateOfBirth = value;
            }
        }
        public int gender
        {
            get { return Gender; }
            set
            {
                this.Gender = value;
            }
        }
        public string classId
        {
            get { return ClassId; }
            set
            {
                this.ClassId = value;
            }
        }
        #endregion
    }
}
