using DAL;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class SubjectBUS
    {
        public List<Subject> GetAllSubject() {
            return DatabaseAccess.GetAllSubject();
        }
    }
}
