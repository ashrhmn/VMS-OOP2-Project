using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace VMS.Repository
{
    class UserRepo
    {
        DbConnection _dbc;

        public UserRepo()
        {
            _dbc = new DbConnection();
        }

        public bool IsAuthenticated(string username, string password)
        {
            string query = "select * from user_credentials where username='" + username + "' and password ='" + password + "'";
            SqlConnection connection = _dbc.GetConnection();
            SqlDataAdapter adp = new SqlDataAdapter(query,connection);
            int results = 0;
            try
            {
                results = adp.Fill(new System.Data.DataSet());
            }
            catch (Exception ex)
            {
                _dbc.ShowErrorMessage(ex, query, 32);
                return false;
            }
            finally
            {
                connection.Close();
            }
            if (results!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateUser(Entity.User user, string username)
        {
            Boolean updateSuccesful = _dbc.IsExecuted("update user_credentials set username='" + user.Username + "', password='" + user.Password + "', role='" + user.Role + "' where username='" + username + "'");
            if (user.Username != username)
            {
                //Update username throughout entire database
                foreach (string tableName in new String[] { "user_details", "candidates" })
                {
                    if (!_dbc.IsExecuted("update " + tableName + " set username='" + user.Username + "' where username='" + username + "'"))
                    {
                        System.Windows.Forms.MessageBox.Show("Username may not have been updated in table " + tableName + "\nHave a look in your Database");
                    }
                }
            }
            return updateSuccesful;
        }

        public bool AddUser(Entity.User user)
        {
            return _dbc.IsExecuted("insert into user_credentials(username,password,role) values('" + user.Username + "','" + user.Password + "','" + user.Role + "')");
        }

        public bool DeleteUser(string username)
        {
            //Delete username throughout entire database
            foreach (string tableName in new String[] { "user_details", "candidates" })
            {
                if (!_dbc.IsExecuted("delete from "+tableName+" where username='" + username + "'"))
                {
                    System.Windows.Forms.MessageBox.Show("Username may not have been deleted in table " + tableName + "\nHave a look in your Database");
                }
            }
            return _dbc.IsExecuted("delete from user_credentials where username='"+username+"'");
        }

        public string GetRole(string username)
        {
            string role = null;
            SqlConnection connection = _dbc.GetConnection();
            SqlCommand cmd = new SqlCommand("select role from user_credentials where username='" + username+"'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                role = reader["role"].ToString();
            }
            connection.Close();
            return role;
        }

        public DataTable GetUsersDataTable()
        {
            return _dbc.GetDataTable("select * from user_credentials");
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
