using System;
using System.Collections.Generic;
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
            SqlConnection connection = dbc.getConnection();
            SqlDataAdapter adp = new SqlDataAdapter("select * from users where username='"+username+"' and password ='"+password+"'",connection);
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
            if (results!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
