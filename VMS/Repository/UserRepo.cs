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
        DataTable userDataTable;

        public UserRepo()
        {
            dbc = new DBConnection();
        }

        public Boolean isAuthenticated(string username, string password)
        {
            string query = "select * from user_credentials where username='" + username + "' and password ='" + password + "'";
            SqlConnection connection = dbc.getConnection();
            SqlDataAdapter adp = new SqlDataAdapter(query,connection);
            int results = 0;
            try
            {
                results = adp.Fill(new System.Data.DataSet());
            }
            catch (Exception ex)
            {
                dbc.showErrorMessage(ex, query, 32);
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
            Boolean updateSuccesful = dbc.isExecuted("update user_credentials set username='" + user.Username + "', password='" + user.Password + "', role='" + user.Role + "' where username='" + username + "'");
            if (user.Username != username)
            {
                //Update username throughout entire database
                foreach (string tableName in new String[] { "user_details", "candidates" })
                {
                    if (!dbc.isExecuted("update " + tableName + " set username='" + user.Username + "' where username='" + username + "'"))
                    {
                        System.Windows.Forms.MessageBox.Show("Username may not have updated in table " + tableName + "\nHave a look in your Database");
                    }
                }
            }
            return updateSuccesful;
        }

        /*Boolean changeUsernameInTable(string tableName, string usernameOld, string usernameNew)
        {
            try
            {
                dbc.execute("update "+tableName+" set username='"+usernameNew+"' where username='"+usernameOld+"'");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }*/

        public Boolean addUser(Entity.User user)
        {
            /*Boolean updateSuccesful = false;
            try
            {
                int affectedRows = dbc.execute("insert into user_credentials(username,password,role) values('" + user.Username + "','" + user.Password + "','" + user.Role + "')");
                updateSuccesful = true;
            }
            catch (Exception ex)
            {
                updateSuccesful = false;
                //System.Windows.Forms.MessageBox.Show("Line 98\n"+ex.ToString());
            }
            return updateSuccesful;*/

            return dbc.isExecuted("insert into user_credentials(username,password,role) values('" + user.Username + "','" + user.Password + "','" + user.Role + "')");
        }

        public string getRole(string username)
        {
            string role = null;
            SqlConnection connection = dbc.getConnection();
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
            userDataTable = new DataTable();
            SqlConnection connection = dbc.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from user_credentials", connection);
            sda.Fill(userDataTable);
            connection.Close();
            return userDataTable;
        }

        public int updateUsersDataTable(DataTable dt=null)
        {
            SqlConnection connection = dbc.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from user_credentials", connection);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            int row = sda.Update(userDataTable);
            connection.Close();
            return row;
        }
    }
}
