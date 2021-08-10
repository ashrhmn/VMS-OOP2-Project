using System;
using System.Collections.Generic;
using System.Text;
using VMS.Entity;

namespace VMS.Repository
{
    class UserDetailRepo
    {
        private DbConnection dbc;

        public UserDetailRepo()
        {
            dbc = new DbConnection();
        }

        public UserDetail GetUserDetail(string username)
        {
            List<UserDetail> list =
                dbc.GetDataTableAsList<UserDetail>("select * from user_details where username='" + username + "'");
            if (list.Count != 1)
            {
                return null;
            }
            return list[0];
        }
    }
}
