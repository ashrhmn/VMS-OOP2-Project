using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace VMS.Repository
{
    class DBConnection
    {
        readonly SqlConnection conn;
        string connectionString = "Data Source=1.10.11.107;Initial Catalog=VMS;Persist Security Info=True;User ID=sa;Password=mssql-2019";
        LocalRepo lr;
        public DBConnection()
        {
            this.conn = new SqlConnection(connectionString);
            lr = new LocalRepo();
        }

        public SqlConnection GetConnection()
        {
            if(this.conn.State != System.Data.ConnectionState.Open)
            {
                this.conn.Open();
            }
            return this.conn;
        }

        public void CloseConnection()
        {
            this.conn.Close();
        }

        public int Execute(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            int rowsAffected = 0;
            try
            {
                this.conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex, query);
            }
            finally
            {
                this.conn.Close();
            }
            return rowsAffected;
        }

        public bool IsExecuted(string query)
        {
            Boolean successful = false;
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                this.conn.Open();
                cmd.ExecuteNonQuery();
                successful = true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex, query);
                successful = false;
            }
            finally
            {
                this.conn.Close();
            }
            return successful;
        }

        public List<T> GetDataTableAsList<T>(String query)
        {
            return lr.ConvertDataTableToList<T>(GetDataTable(query));
        }
        public DataTable GetDataTable(String query)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = GetConnection();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex, query);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public void ShowErrorMessage(Exception ex, string query, int lineNo)
        {
            System.Windows.Forms.MessageBox.Show("Error Message Box\nQuery : " + query + "\nLine no : " + lineNo + "\n\n" + ex.ToString());
        }

        public void ShowErrorMessage(Exception ex, string query)
        {
            System.Windows.Forms.MessageBox.Show("Error Message Box\nQuery : " + query + "\n\n" + ex.ToString());
        }
    }
}
