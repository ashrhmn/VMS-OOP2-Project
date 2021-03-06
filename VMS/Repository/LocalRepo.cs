using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

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

        public void ShowErrorMessage(Exception ex, string query)
        {
            System.Windows.Forms.MessageBox.Show(@"Query : " + query + @"

" + ex, @"Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowErrorMessage(Exception ex, string fileName, int lineNo)
        {
            System.Windows.Forms.MessageBox.Show(@"File : " + fileName + " (Line : " + lineNo + ")" + @"

" + ex, @"Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowCustomErrorMessage(Exception ex, string customMessage)
        {
            System.Windows.Forms.MessageBox.Show(@"Message : " + customMessage + @"

" + ex, @"Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
