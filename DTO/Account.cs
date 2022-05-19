using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private int roleId;
        public string sAccountID
        {
            get;set;
        }

        public string sUsername
        {
            get;set;
        }

        public string sPassword
        {
            get;set;
        }

        public int RoleID
        {
            get { return this.roleId; }
            set { this.roleId = value; }
        }
    }
}
