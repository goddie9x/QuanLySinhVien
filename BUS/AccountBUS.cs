using DTO;
using DAL;

namespace BUS
{
    public class AccountBUS
    {
        public bool GetUserInfo(ref Account account)
        {
            return DatabaseAccess.GetUserInfo(ref account);
        }
    }
}
