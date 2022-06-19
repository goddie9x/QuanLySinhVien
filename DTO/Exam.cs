using System;
using System.Text.RegularExpressions;

namespace DTO
{
    public class Exam
    {
        public string id;
        public string SubjectId;
        public int timeOut;
        //0: mid term, 1: end term
        public int type;
        public string sAccountID;
        public string examName;
        public string Semester;

        public Exam(string id, string SubjectId, string timeOut, string examName, string type, string sAccountID, string Semester)
        {
            this.id = id;
            this.SubjectId = SubjectId;
            this.examName = examName;
            string[] timeOutArrayForHHmm = timeOut.Split(':');
            this.timeOut = Convert.ToInt32(timeOut);
            this.type = Int32.Parse(type);
            this.sAccountID = sAccountID;
            this.Semester = Semester;
        }
        public Exam()
        {
            this.id = "";
            this.SubjectId = "";
            this.timeOut = 0;
            this.examName = "";
            this.type = 0;
            this.sAccountID = "";
            this.Semester = "";
        }
        public string GetTimeOutText()
        {
            TimeSpan time = TimeSpan.FromSeconds(timeOut);
            return time.ToString(@"hh\:mm");
        }
        public bool SetTimeOutByString(string timeOut)
        {
            Regex reg = new Regex("^[0-5][0-9]:[0-5][0-9]$");
            if (reg.IsMatch(timeOut))
            {
                string[] timeOutSplit = timeOut.Split(':');
                this.timeOut = Convert.ToInt32(timeOutSplit[0])*3600 + Convert.ToInt32(timeOutSplit[1]) * 60;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
