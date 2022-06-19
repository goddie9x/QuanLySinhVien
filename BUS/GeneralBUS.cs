using DAL;
using System;

namespace BUS
{
    public class GeneralBUS
    {
        public int GetCurrentSemester()
        {
            DateTime now = DateTime.Now;
            int yeahEstablish = 0;
            string[] UniversityInfo = DatabaseAccess.GetUniversityInfo();
            if (UniversityInfo != null)
            {
                yeahEstablish = Convert.ToInt32(UniversityInfo[2]);
            }
            int amountYears = now.Year - yeahEstablish;
            return now.Month >= 6 ? amountYears * 2 + 1 : amountYears * 2 + 2;
        }
    }
}
