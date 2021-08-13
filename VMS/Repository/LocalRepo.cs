using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace VMS.Repository
{
    class LocalRepo
    {
        public List<T> ConvertDataTableToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }


        private T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name.ToLower() == column.ColumnName.ToLower())
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
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
