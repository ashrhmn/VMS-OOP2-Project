﻿using System;
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
            SqlConnection connection = dbc.getConnection();
            SqlDataAdapter adp = new SqlDataAdapter("select * from user_credentials where username='"+username+"' and password ='"+password+"'",connection);
            int results = 0;
            try
            {
                results = adp.Fill(new System.Data.DataSet());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
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
