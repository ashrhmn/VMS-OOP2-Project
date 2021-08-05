using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace VMS.Repository
{
    class DBConnection
    {
        SqlConnection conn;
        string connectionString = "Data Source=1.10.11.107;Initial Catalog=VMS;Persist Security Info=True;User ID=sa;Password=mssql-2019";
        public DBConnection()
        {
            this.conn = new SqlConnection(connectionString);
            
        }

        public SqlConnection getConnection()
        {
            this.conn.Open();
            return this.conn;
        }

        public void closeConnection()
        {
            this.conn.Close();
        }

        public int execute(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            int rowsAffected = 0;
            try
            {
                this.conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            finally{
                this.conn.Close();
            }
            return rowsAffected;
        }
    }
}
