using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace VMS.Repository
{
    class DbConnection
    {
        readonly SqlConnection _conn;
        //string _connectionString = "Data Source=1.10.11.107;Initial Catalog=VMS;Persist Security Info=True;User ID=sa;Password=mssql-2019";
        string _connectionString = "Data Source = localhost; Initial Catalog = VMS; Persist Security Info=True;User ID = sa; Password=mssql-2019";
        
        LocalRepo _lr;
        public DbConnection()
        {
            _conn = new SqlConnection(_connectionString);
            _lr = new LocalRepo();
        }

        public SqlConnection GetConnection()
        {
            if(_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
            return _conn;
        }

        public void CloseConnection()
        {
            _conn.Close();
        }

        public bool DataExists(string query)
        {
            SqlDataAdapter adp = new SqlDataAdapter(query, _conn);
            int results;
            try
            {
                results = adp.Fill(new DataSet());
            }
            catch (Exception ex)
            {
                _lr.ShowErrorMessage(ex, query);
                return false;
            }
            finally
            {
                _conn.Close();
            }
            if (results != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DataCount(string query)
        {
            SqlDataAdapter adp = new SqlDataAdapter(query, _conn);
            int results = 0;
            try
            {
                results = adp.Fill(new DataSet());
            }
            catch (Exception ex)
            {
                _lr.ShowErrorMessage(ex, query);
            }
            finally
            {
                _conn.Close();
            }

            return results;
        }

        public int Execute(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _conn);
            int rowsAffected = 0;
            try
            {
                _conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _lr.ShowErrorMessage(ex, query);
            }
            finally
            {
                _conn.Close();
            }
            return rowsAffected;
        }

        public bool IsExecuted(string query)
        {
            Boolean successful;
            SqlCommand cmd = new SqlCommand(query, _conn);
            try
            {
                _conn.Open();
                cmd.ExecuteNonQuery();
                successful = true;
            }
            catch (Exception ex)
            {
                _lr.ShowErrorMessage(ex, query);
                successful = false;
            }
            finally
            {
                _conn.Close();
            }
            return successful;
        }

        public List<T> GetDataTableAsList<T>(String query)
        {
            return _lr.ConvertDataTableToList<T>(GetDataTable(query));
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
                _lr.ShowErrorMessage(ex, query);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        public string GetSingleData(string query,string columnName)
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            string columnData = null;
            try
            {
                connection = GetConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    columnData = reader[columnName].ToString();
                }
            }
            catch (Exception ex)
            {
                _lr.ShowErrorMessage(ex, query);
            }
            finally
            {
                connection?.Close();
                reader?.Close();
            }
            return columnData;
        }
    }
}
