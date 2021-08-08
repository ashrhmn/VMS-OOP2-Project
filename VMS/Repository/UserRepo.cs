using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace VMS.Repository
{
    class UserRepo
    {
        DBConnection dbc;

        public UserRepo()
        {
            dbc = new DBConnection();
        }

        public Boolean isAuthenticated(string username, string password)
        {
            string query = "select * from user_credentials where username='" + username + "' and password ='" + password + "'";
            SqlConnection connection = dbc.GetConnection();
            SqlDataAdapter adp = new SqlDataAdapter(query,connection);
            int results = 0;
            try
            {
                results = adp.Fill(new System.Data.DataSet());
            }
            catch (Exception ex)
            {
                dbc.ShowErrorMessage(ex, query, 32);
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

        public Boolean updateUser(Entity.User user, string username)
        {
            Boolean updateSuccesful = dbc.IsExecuted("update user_credentials set username='" + user.Username + "', password='" + user.Password + "', role='" + user.Role + "' where username='" + username + "'");
            if (user.Username != username)
            {
                //Update username throughout entire database
                foreach (string tableName in new String[] { "user_details", "candidates" })
                {
                    if (!dbc.IsExecuted("update " + tableName + " set username='" + user.Username + "' where username='" + username + "'"))
                    {
                        System.Windows.Forms.MessageBox.Show("Username may not have been updated in table " + tableName + "\nHave a look in your Database");
                    }
                }
            }
            return updateSuccesful;
        }

        public Boolean addUser(Entity.User user)
        {
            return dbc.IsExecuted("insert into user_credentials(username,password,role) values('" + user.Username + "','" + user.Password + "','" + user.Role + "')");
        }

        public Boolean deleteUser(string username)
        {
            //Delete username throughout entire database
            foreach (string tableName in new String[] { "user_details", "candidates" })
            {
                if (!dbc.IsExecuted("delete from "+tableName+" where username='" + username + "'"))
                {
                    System.Windows.Forms.MessageBox.Show("Username may not have been deleted in table " + tableName + "\nHave a look in your Database");
                }
            }
            return dbc.IsExecuted("delete from user_credentials where username='"+username+"'");
        }

        public string getRole(string username)
        {
            string role = null;
            SqlConnection connection = dbc.GetConnection();
            SqlCommand cmd = new SqlCommand("select role from user_credentials where username='" + username+"'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                role = reader["role"].ToString();
            }
            connection.Close();
            return role;
        }

        public DataTable getUsersDataTable()
        {
            return dbc.GetDataTable("select * from user_credentials");
        }
    }
}
