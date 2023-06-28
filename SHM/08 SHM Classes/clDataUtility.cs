using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace SHM
{
    public class clDataUtility
    {
        #region Methods
        public static bool TestConnString(string connString)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Dispose();
            }
        }
        private static string GetConnString(string serverName, string databaseName)
        {
            return "Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";Integrated Security=True";
        }

        private static string GetConnString(string serverName, string databaseName, string userID, string password)
        {
            return "Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";User ID=" + userID + ";Password=" + password;
        }

        public static string GetConnString(string serverName, string databaseName, string userID, string password, bool integratedSecurity)
        {
            if (!integratedSecurity)
                return GetConnString(serverName, databaseName, userID, password);
            else
                return GetConnString(serverName, databaseName);

        }

       

        public static string CheckValues(DataRow row, string connString)
        {
            string result = string.Empty;
            foreach (DataColumn col in row.Table.Columns)
            {
                if (col.AutoIncrement || col.ReadOnly) continue;
                if (col.DataType == typeof(String) && !(row.IsNull(col) || Convert.IsDBNull(row[col]))) row[col] = row[col].ToString().Trim();

                if ((row.IsNull(col) || Convert.IsDBNull(row[col])) && col.AllowDBNull) continue;

                if ((row.IsNull(col) || Convert.IsDBNull(row[col])) && (!col.AllowDBNull))
                {
                    result = result + " - " + GetColumnDescription(col.Table.TableName, col.ColumnName, col.Caption, connString) + "\n";
                    continue;
                }
                if ((!row.IsNull(col)) && col.DataType == typeof(String) && row[col].ToString() == string.Empty && !col.AllowDBNull)
                {
                    result = result + " - " + GetColumnDescription(col.Table.TableName, col.ColumnName, col.Caption, connString) + "\n";
                    continue;
                }
                if ((!row.IsNull(col)) && col.DataType == typeof(String) && row[col].ToString().Length > col.MaxLength)
                {
                    result = result + " - " + GetColumnDescription(col.Table.TableName, col.ColumnName, col.Caption, connString) + " (should be less than " + col.MaxLength.ToString() + " characters)\n";
                    continue;
                }
            }
            if (result != string.Empty)
            {
                result = "Please enter valid:\n\n" + result;
            }
            return result;
        }

        public static string CheckValues(DataRow row, DataColumn[] columns, string connString)
        {
            string result = string.Empty;
            foreach (DataColumn col in columns)
            {
                if (col.AutoIncrement || col.ReadOnly) continue;
                if (col.DataType == typeof(String) && !(row.IsNull(col) || Convert.IsDBNull(row[col]))) row[col] = row[col].ToString().Trim();

                if ((row.IsNull(col) || Convert.IsDBNull(row[col])) && col.AllowDBNull) continue;

                if ((row.IsNull(col) || Convert.IsDBNull(row[col])) && (!col.AllowDBNull))
                {
                    result = result + " - " + GetColumnDescription(col.Table.TableName, col.ColumnName, col.Caption, connString) + "\n";
                    continue;
                }
                if ((!row.IsNull(col)) && col.DataType == typeof(String) && row[col].ToString() == string.Empty && !col.AllowDBNull)
                {
                    result = result + " - " + GetColumnDescription(col.Table.TableName, col.ColumnName, col.Caption, connString) + "\n";
                    continue;
                }
                if ((!row.IsNull(col)) && col.DataType == typeof(String) && row[col].ToString().Length > col.MaxLength)
                {
                    result = result + " - " + GetColumnDescription(col.Table.TableName, col.ColumnName, col.Caption, connString) + " (should be less than " + col.MaxLength.ToString() + " characters)\n";
                    continue;
                }
            }
            if (result != string.Empty)
            {
                result = "Please enter valid:\n\n" + result;
            }
            return result;
        }

        public static string GetColumnDescription(string tableName, string columnName, string connString)
        {
            return GetColumnDescription(tableName, columnName, columnName, connString);
        }

        public static string GetColumnDescription(string tableName, string columnName, string columnCaption, string connString)
        {
            clDatacon DataObj = new clDatacon(connString);
            try
            {
                DataObj.OpenConnection();
                return DataObj.GetColumnDescription(tableName, columnName, columnCaption);
                
            }
            catch
            {
                return columnCaption;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static string GetQuery(int commandType, DataRow row)
        {
            string SqlText = string.Empty;
            string Criteria = string.Empty;
            string ColumnsText = string.Empty;
            string ValuesText = string.Empty;

            if (commandType < 0 || commandType > 3 || row == null)
                return SqlText;
            if (row.Table == null)
                return SqlText;
            try
            {
                //Find criteria
                if (commandType != 1)
                {
                    foreach (DataColumn col in row.Table.PrimaryKey)
                    {
                        Criteria = Criteria + " and " + col.ColumnName + " = ";
                        if (col.DataType == typeof(String))
                            Criteria = Criteria + "'" + row[col] + "'";
                        else if (col.DataType == typeof(DateTime))
                            Criteria = Criteria + "'" + ((DateTime)row[col]).ToShortDateString() + "'";
                        else if (col.DataType == typeof(Guid))
                            Criteria = Criteria + "'" + row[col] + "'";
                        else if (col.DataType == typeof(Boolean))
                            Criteria = Criteria + Convert.ToInt32(row[col]);
                        else
                            Criteria = Criteria + row[col];
                    }
                    if (Criteria != string.Empty)
                        Criteria = Criteria.Remove(0, 5);
                }

                //Find sql statment based on command type
                switch (commandType)
                {
                    case 0: //SELECT
                        foreach (DataColumn col in row.Table.Columns)
                        {
                            SqlText = SqlText + ", " + col.ColumnName;
                        }
                        if (SqlText != string.Empty)
                            SqlText = "SELECT " + SqlText.Remove(0, 2) + " FROM " + row.Table.TableName + " WHERE " + Criteria; ;
                        break;
                    case 1: //INSERT 
                        foreach (DataColumn col in row.Table.Columns)
                        {
                            if (!col.AutoIncrement && !col.ReadOnly)
                            {
                                ColumnsText = ColumnsText + ", " + col.ColumnName;
                                if (Convert.IsDBNull(row[col]))
                                    ValuesText = ValuesText + ", null";
                                else if (col.DataType == typeof(String) && !Convert.IsDBNull(row[col]))
                                    ValuesText = ValuesText + ", '" + row[col] + "'";
                                else if (col.DataType == typeof(DateTime) && !Convert.IsDBNull(row[col]))
                                    ValuesText = ValuesText + ", '" + ((DateTime)row[col]).ToShortDateString() + "'";
                                else if (col.DataType == typeof(Guid) && !Convert.IsDBNull(row[col]))
                                    ValuesText = ValuesText + ", '" + row[col] + "'";
                                else if (col.DataType == typeof(Boolean))
                                    ValuesText = ValuesText + ", " + Convert.ToInt32(row[col]);
                                else if (col.DataType == typeof(System.Drawing.Image))
                                    ValuesText = ValuesText + ", '" + row[col] + "'";
                                else
                                    ValuesText = ValuesText + ", " + row[col];
                            }
                        }
                        if (ColumnsText != string.Empty && ValuesText != string.Empty)
                            SqlText = "INSERT INTO " + row.Table.TableName + " (" + ColumnsText.Remove(0, 2) + ") VALUES (" + ValuesText.Remove(0, 2) + ")";
                        break;
                    case 2: //UPDATE
                        foreach (DataColumn col in row.Table.Columns)
                        {
                            if (!col.AutoIncrement && !col.ReadOnly && !IsPrimaryKey(col))
                            {
                                if (Convert.IsDBNull(row[col]))
                                    SqlText = SqlText + ", " + col.ColumnName + " = null";
                                else if (col.DataType == typeof(byte[]))
                                {
                                }
                                else if (col.DataType == typeof(String) && !Convert.IsDBNull(row[col]))
                                    SqlText = SqlText + ", " + col.ColumnName + " = '" + row[col] + "'";
                                else if (col.DataType == typeof(DateTime) && !Convert.IsDBNull(row[col]))
                                    SqlText = SqlText + ", " + col.ColumnName + " = '" + ((DateTime)row[col]).ToShortDateString() + "'";
                                else if (col.DataType == typeof(Guid) && !Convert.IsDBNull(row[col]))
                                    SqlText = SqlText + ", " + col.ColumnName + " = '" + row[col] + "'";
                                else if (col.DataType == typeof(Boolean))
                                    SqlText = SqlText + ", " + col.ColumnName + " = " + Convert.ToInt32(row[col]);
                                else if (col.DataType == typeof(System.Drawing.Image))
                                    SqlText = SqlText + ", " + col.ColumnName + " = '" + row[col] + "'";
                                else
                                    SqlText = SqlText + ", " + col.ColumnName + " = " + row[col];
                            }
                        }
                        if (SqlText != string.Empty)
                            SqlText = "set dateformat dmy UPDATE " + row.Table.TableName + " SET " + SqlText.Remove(0, 2) + " WHERE " + Criteria;
                        break;
                    case 3://DELETE
                        SqlText = "DELETE from " + row.Table.TableName + " WHERE " + Criteria;
                        break;
                }

                return SqlText;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return string.Empty;
            }
        }

        private static bool IsPrimaryKey(DataColumn col)
        {
            foreach (DataColumn keyCol in col.Table.PrimaryKey)
            {
                if (keyCol == col) return true;
            }
            return false;
        }

        public static bool Insert(DataRow row, DataTable table, bool validate, string connString)
        {
            
            try
            {
                if (validate)
                {
                    if (!Validate(row, connString))
                    {
                        return false;
                    }
                }

                DataRow newRow = table.NewRow();
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    if (!table.Columns[i].AutoIncrement && !table.Columns[i].ReadOnly) newRow[i] = row[i];
                }
                //newRow.ItemArray = row.ItemArray;
                table.Rows.Add(newRow);
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public static bool Update(DataRow row, DataTable table, bool validate, string connString)
        {
           
            object[] primaryKeys;
            try
            {
                if (validate)
                {
                    if (!Validate(row, connString))
                    {
                        return false;
                    }
                }
                primaryKeys = new object[row.Table.PrimaryKey.Length];
                for (int i = 0; i < row.Table.PrimaryKey.Length; i++)
                    primaryKeys[i] = row[row.Table.PrimaryKey[i]];
                DataRow updateRow = table.Rows.Find(primaryKeys);
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    if (!table.Columns[i].AutoIncrement && !table.Columns[i].ReadOnly) updateRow[i] = row[i];
                }
                //table.Rows.Find(primaryKeys).ItemArray = row.ItemArray;
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public static bool Delete(DataRow row, DataTable table, bool validate, string connString)
        {
            
            object[] primaryKeys;
            try
            {
                if (validate)
                {
                    if (!Validate(row, row.Table.PrimaryKey, connString))
                    {
                        return false;
                    }
                }
                primaryKeys = new object[row.Table.PrimaryKey.Length];
                for (int i = 0; i < row.Table.PrimaryKey.Length; i++)
                    primaryKeys[i] = row[row.Table.PrimaryKey[i]];
                row = table.Rows.Find(primaryKeys);
                row.Delete();
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public static void SetAdded(DataTable table)
        {
            foreach (DataRow row in table.Rows)
                row.SetAdded();
        }

        public static bool Validate(DataRow row, string connString)
        {
            string checkValueMsg;
            checkValueMsg = CheckValues(row, connString);
            if (checkValueMsg == string.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show(checkValueMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public static bool Validate(DataRow row, DataColumn[] columns, string connString)
        {
            string checkValueMsg;
            checkValueMsg = CheckValues(row, columns, connString);
            if (checkValueMsg == string.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show(checkValueMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        public static bool BackupDatabase(string fileNameExtension)
        {
            string cmdText = string.Empty;
            object result;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            string SHMFileName = string.Empty;
            string BackupPath = string.Empty;

            try
            {
                DataObj.OpenConnection();
                cmdText = "select ParameterValue from tblNameValueParameter where ParameterName='SHMDBFileName'";
                result = DataObj.GetDataScalar(cmdText);
                if (result != null && !Convert.IsDBNull(result))
                    SHMFileName = Convert.ToString(result);
                else
                    SHMFileName = "SHMData";

                cmdText = "select ParameterValue from tblNameValueParameter where ParameterName='SHMDbBackupPath'";
                result = DataObj.GetDataScalar(cmdText);
                if (result != null && !Convert.IsDBNull(result))
                    BackupPath = Convert.ToString(result);
                else
                    BackupPath = "C:\\";

                cmdText = "BACKUP DATABASE " + SHMFileName + " TO DISK='" + BackupPath + "\\" + fileNameExtension + "-iCMCSHMDB" + clUtility.GetCurrentDate().Day.ToString() + "-" + clUtility.GetCurrentDate().Month.ToString() + "-" + clUtility.GetCurrentDate().Year.ToString() + ".bak'";
                return DataObj.Execute(cmdText);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }
      
        #endregion

    }
}
