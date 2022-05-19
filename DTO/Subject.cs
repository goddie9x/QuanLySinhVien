using System;

namespace DTO
{
    public class Subject
    {
        #region attributes
        private string SubjectId;
        private string Time;
        private int DayOfWeek;
        private string SubjectName;

        public string subjectId
        {
            get { return SubjectId; }
            set
            {
                this.SubjectId = value;
            }
        }
        public string time
        {
            get { return Time; }
            set
            {
                this.Time = value;
            }
        }
        public string subjectName
        {
            get { return SubjectName; }
            set
            {
                this.SubjectName = value;
            }
        }
        public int dayOfWeek
        {
            get { return DayOfWeek; }
            set
            {
                this.DayOfWeek = value;
            }
        }
        #endregion
    }
}
