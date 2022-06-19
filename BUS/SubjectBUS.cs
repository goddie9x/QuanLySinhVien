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
    }
}
