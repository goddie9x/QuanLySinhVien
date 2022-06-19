using DAL;
using System.Data;

namespace BUS
{
    public class TranscrioptBUS
    {
        public DataTable GetTransctriptByQuery(string query)
        {
            return DatabaseAccess.GetTransctriptByQuery(query);
        }
    }
}
