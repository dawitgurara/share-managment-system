using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SHM
{
    class clConvertCalendar
    {
        #region Fields
        private static string _tableName;
        private static string[] _sourceColumns;
        private static string _criteria;
        private static ConversionType _convertType;
        #endregion

        #region Validation and Get Status Methods
        public static bool Validate()
        {
            return true;
        }
        #endregion

        #region Convert Methods
        public static bool Convert(string tableName, string[] sourceColumns, string criteria, ConversionType convertType, ProgressBar convertProgress, Label convertLable)
        {
            _tableName = tableName;
            _sourceColumns = sourceColumns;
            _criteria = criteria;
            _convertType = convertType;

            if (!Validate()) return false;

            try
            {
                convertProgress.Maximum = sourceColumns.Length;
                for (int i = 0; i < sourceColumns.Length; i++)
                {
                    convertLable.Text = "Converting Column '" + sourceColumns[i] + "' ...";
                    convertProgress.Value = i;
                    Application.DoEvents();
                    if (_convertType == ConversionType.GrgToEth)
                        ConvertGrgToEth(_tableName, sourceColumns[i]);
                    else
                        ConvertEthToGrg(_tableName, sourceColumns[i]);
                }
                return true;
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowError(Ex.Message);
                return false;
            }
            finally
            {

            }
        }

        public static bool ConvertGrgToEth(string tableName, string sourceColumn)
        {
            string destinationColumn;
            DateTime grgDate;
            object ethDate;
            clEthiopianCalendar cal = new clEthiopianCalendar();
            DataTable sourceData;
            string cmdText;
            List<SqlParameter> parameterValues;
            bool success = false;
            string keyColumnsList = string.Empty;
            string keyColumnsCriteria = string.Empty;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                destinationColumn = (sourceColumn + "Eth");

                DataObj.OpenConnection();
                sourceData = DataObj.GetDataTable(tableName);
                foreach (DataColumn keyColumn in sourceData.PrimaryKey)
                {
                    keyColumnsList += (", [" + keyColumn.ColumnName + "]");
                    if (keyColumnsCriteria == string.Empty)
                        keyColumnsCriteria += (keyColumn.ColumnName + "=@" + keyColumn);
                    else
                        keyColumnsCriteria += (" AND " + keyColumn.ColumnName + "=@" + keyColumn);
                }

                DataObj.BeginTransaction();

                cmdText = "SELECT [" + sourceColumn + "]" + keyColumnsList + " FROM [" + tableName + "]";
                if (_criteria != null && _criteria != string.Empty)
                    cmdText += (" WHERE " + _criteria);
                DataObj.FillData(sourceData, cmdText);

                foreach (DataRow row in sourceData.Rows)
                {
                    if (System.Convert.IsDBNull(row[sourceColumn]))
                        ethDate = System.Convert.DBNull;
                    else
                    {
                        grgDate = System.Convert.ToDateTime(row[sourceColumn]);
                        ethDate = cal.ConvertgregorianToEthiopic(grgDate.Year, grgDate.Month, grgDate.Day);
                    }

                    parameterValues = new List<SqlParameter>();
                    parameterValues.Add(new SqlParameter("ethDate", ethDate));
                    foreach (DataColumn keyColumn in sourceData.PrimaryKey)
                        parameterValues.Add(new SqlParameter(keyColumn.ColumnName, row[keyColumn]));

                    cmdText = "UPDATE [" + tableName + "] SET [" + destinationColumn + "]=@ethDate WHERE " + keyColumnsCriteria;
                    success = DataObj.Execute(cmdText, false, parameterValues.ToArray());
                    Application.DoEvents();
                }

                if (success)
                {
                    DataObj.CommitTransaction();
                    return true;
                }
                else
                {
                    DataObj.RollbackTransaction();
                    return false;
                }
            }
            catch (Exception Ex)
            {
                DataObj.RollbackTransaction();
                AppMessageBox.ShowError(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static bool ConvertEthToGrg(string tableName, string sourceColumn)
        {
            string destinationColumn;
            string ethDate;
            object grgDate;
            clEthiopianCalendar cal = new clEthiopianCalendar();
            DataTable sourceData;
            string cmdText;
            List<SqlParameter> parameterValues;
            bool success = false;
            string keyColumnsList = string.Empty;
            string keyColumnsCriteria = string.Empty;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                destinationColumn = sourceColumn.Remove(sourceColumn.Length - 3);

                DataObj.OpenConnection();
                sourceData = DataObj.GetDataTable(tableName);
                foreach (DataColumn keyColumn in sourceData.PrimaryKey)
                {
                    keyColumnsList += (", [" + keyColumn.ColumnName + "]");
                    if (keyColumnsCriteria == string.Empty)
                        keyColumnsCriteria += (keyColumn.ColumnName + "=@" + keyColumn);
                    else
                        keyColumnsCriteria += (" AND " + keyColumn.ColumnName + "=@" + keyColumn);
                }

                DataObj.BeginTransaction();

                cmdText = "SELECT [" + sourceColumn + "]" + keyColumnsList + " FROM [" + tableName + "]";
                if (_criteria != null && _criteria != string.Empty)
                    cmdText += (" WHERE " + _criteria);
                DataObj.FillData(sourceData, cmdText);

                string[] splitStr;
                string result;
                foreach (DataRow row in sourceData.Rows)
                {
                    if (System.Convert.IsDBNull(row[sourceColumn]))
                        grgDate = System.Convert.DBNull;
                    else
                    {
                        ethDate = System.Convert.ToString(row[sourceColumn]);
                        splitStr = ethDate.Split(new string[] { "/" }, StringSplitOptions.None);
                        if (splitStr.Length < 3)
                        {
                            grgDate = new DateTime(1900, 1, 1);
                        }
                        else
                        {
                            result = cal.ConvertethiopicToGregorian(System.Convert.ToInt32(splitStr[2]), System.Convert.ToInt32(splitStr[1]), System.Convert.ToInt32(splitStr[0]));
                            grgDate = System.Convert.ToDateTime(result);
                        }
                    }

                    parameterValues = new List<SqlParameter>();
                    parameterValues.Add(new SqlParameter("grgDate", grgDate));
                    foreach (DataColumn keyColumn in sourceData.PrimaryKey)
                        parameterValues.Add(new SqlParameter(keyColumn.ColumnName, row[keyColumn]));

                    cmdText = "UPDATE [" + tableName + "] SET [" + destinationColumn + "]=@grgDate WHERE " + keyColumnsCriteria;
                    success = DataObj.Execute(cmdText, false, parameterValues.ToArray());
                    Application.DoEvents();
                }

                if (success)
                {
                    DataObj.CommitTransaction();
                    return true;
                }
                else
                {
                    DataObj.RollbackTransaction();
                    return false;
                }
            }
            catch (Exception Ex)
            {
                DataObj.RollbackTransaction();
                AppMessageBox.ShowError(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }

        }

        #endregion

    }

    public enum ConversionType
    {
        GrgToEth = 1,
        EthToGrg = 2
    }
}
