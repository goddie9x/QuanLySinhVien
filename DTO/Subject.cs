using System;

namespace DTO
{
    public class Subject
    {
        #region attributes
        private string SubjectId;
        private TimeSpan TimeStart;
        private TimeSpan TimeEnd;
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
        public string timeStart
        {
            get { return TimeStart.ToString(); }
            set
            {
                this.TimeStart = TimeSpan.Parse(value);
            }
        }
        public string timeEnd
        {
            get { return TimeEnd.ToString(); }
            set
            {
                this.TimeEnd = TimeSpan.Parse(value); ;
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
        public bool CheckValidatePesentNow()
        {

            DateTime now = DateTime.Now;
            int dayOfWeekNow = (int)now.DayOfWeek;
            if (dayOfWeekNow != this.DayOfWeek)
            {
                return false;
            }
            return TimeStart <= now.TimeOfDay&& TimeEnd>= now.TimeOfDay;
        }
    }
}
