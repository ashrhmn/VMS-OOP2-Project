using System;
using System.Collections.Generic;
using System.Data;

namespace VMS.Repository
{
    class UserRepo
    {
        readonly DbConnection _dbc;

        public UserRepo()
        {
            _dbc = new DbConnection();
        }

        public bool IsAuthenticated(string username, string password)
        {
            return _dbc.DataExists("select * from user_credentials where username='" + username + "' and password ='" +
                                   password + "'");
        }

        public bool IsPendingAccount(string username, string password)
        {
            return _dbc.DataExists("select * from pending_signups where username='" + username + "' and password ='" +
                                   password + "'");
        }



        public bool UpdateUser(Entity.User user, string username)
        {
            Boolean updateSuccessful = _dbc.IsExecuted("update user_credentials set username='" + user.Username + "', password='" + user.Password + "', role='" + user.Role + "' where username='" + username + "'");
            if (user.Username != username)
            {
                //Update username throughout entire database
                foreach (string tableName in new[] { "user_details", "candidates" })
                {
                    if (!_dbc.IsExecuted("update " + tableName + " set username='" + user.Username + "' where username='" + username + "'"))
                    {
                        System.Windows.Forms.MessageBox.Show(@"Username may not have been updated in table " + tableName + @"
                        Have a look in your Database");
                    }
                }
            }
            return updateSuccessful;
        }

        public bool AddUser(Entity.User user)
        {
            return _dbc.IsExecuted("insert into user_credentials(username,password,role) values('" + user.Username + "','" + user.Password + "','" + user.Role + "')");
        }

        public bool DeletePendingUser(string username)
        {
            return _dbc.IsExecuted("delete from pending_signups where username='"+username+"'");
        }
        public bool ApplyNewUser(Entity.User user)
        {
            return _dbc.IsExecuted("insert into pending_signups(username,password) values('" + user.Username + "','" + user.Password + "')");
        }

        public bool DeleteUser(string username)
        {
            //Delete username throughout entire database
            foreach (string tableName in new[] { "user_details", "candidates" })
            {
                if (!_dbc.IsExecuted("delete from "+tableName+" where username='" + username + "'"))
                {
                    System.Windows.Forms.MessageBox.Show(@"Username may not have been deleted in table " + tableName + @"Have a look in your Database");
                }
            }
            return _dbc.IsExecuted("delete from user_credentials where username='"+username+"'");
        }

        public string GetRole(string username)
        {
            return _dbc.GetSingleData("select role from user_credentials where username='" + username + "'", "role");
        }

        public DataTable GetUsersDataTable()
        {
            return _dbc.GetDataTable("select * from user_credentials");
        }

        public bool UserExists(string username)
        {
            return _dbc.DataExists("select username from user_credentials where username='"+username+"'");
        }

        public DataTable GetPendingUsersDataTable()
        {
            return _dbc.GetDataTable("select * from pending_signups");
        }

        public DataTable GetGeneralPublicDataTable()
        {
            return _dbc.GetDataTable("select username from user_credentials where role='General Public'");
        }


        public List<Entity.User> GetUsersDataList()
        {
            return _dbc.GetDataTableAsList<Entity.User>("select * from user_credentials");
        }
    }
}
