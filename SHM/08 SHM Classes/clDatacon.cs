using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SHM
{
    class clDatacon
    {
    #region Fields
        private SqlConnection _conn;
        private SqlCommand _comm;
        private SqlDataAdapter _adpt;
        private SqlTransaction _tran;
        private string _connString;
        private bool _tranStarted = false;
        private bool _enableLogging = false;
        #endregion

        #region Properties
        public string ConnString
        {
            get { return this._connString; }
        }
        public bool TranStarted
        {
            get { return this._tranStarted; }
        }
        public bool EnableLogging
        {
            get { return this._enableLogging; }
            set { this._enableLogging = value; }
        }
        #endregion

        public clDatacon(string connString)
        {
            this._connString = connString;
            this._conn = new SqlConnection(this._connString);
            this._comm = new SqlCommand(string.Empty, this._conn);
            this._adpt = new SqlDataAdapter(this._comm);
        }

        public bool OpenConnection()
        {
            try
            {
                if (this._conn.State == ConnectionState.Closed) this._conn.Open();
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                if (this._conn.State == ConnectionState.Open) this._conn.Close();
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public bool BeginTransaction()
        {
            try
            {
                if (!this._tranStarted)
                {
                    this._tran = this._conn.BeginTransaction();
                    this._comm.Transaction = this._tran;
                    this._tranStarted = true;
                }
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public bool CommitTransaction()
        {
            try
            {
                if (this._tranStarted)
                {
                    this._tran.Commit();
                    this._comm.Transaction = null;
                    this._tran = null;
                    this._tranStarted = false;
                }
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public bool RollbackTransaction()
        {
            try
            {
                if (this._tranStarted)
                {
                    this._tran.Rollback();
                    this._comm.Transaction = null;
                    this._tran = null;
                    this._tranStarted = false;
                }
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public bool Execute(string commandText)
        {
            return this.Execute(commandText, false, null);
        }

        public bool Execute(string commandText, bool isProcedure)
        {
            return this.Execute(commandText, isProcedure, null);
        }

        public bool Execute(string commandText, bool isProcedure, SqlParameter[] dataParameters)
        {
            try
            {
                if (isProcedure)
                {
                    this._comm.CommandType = CommandType.StoredProcedure;
                }
                if (dataParameters != null) this._comm.Parameters.AddRange(dataParameters);
                this._comm.CommandText = "set dateformat dmy " + commandText;
                this._comm.ExecuteNonQuery();
                //if (this._enableLogging)
                //    //call logging for success method here
                return true;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(this.GetExceptionMessage(sqlEx), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            catch (Exception Ex)
            {
                //if(this._enableLogging)
                //    //call logging method for error here
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                this._comm.CommandType = CommandType.Text;
                this._comm.Parameters.Clear();
            }
        }

        public bool Execute(List<string> commandTexts)
        {
            try
            {
                this.BeginTransaction();
                foreach (string cmdText in commandTexts)
                {
                    this._comm.CommandText = cmdText;
                    this._comm.ExecuteNonQuery();
                    //if (this._enableLogging)
                    //    //call logging for success method here
                }
                this.CommitTransaction();
                return true;
            }
            catch (Exception Ex)
            {
                //if(this._enableLogging)
                //    //call logging method for error here
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                this.RollbackTransaction();
            }
        }

        public DataSet GetDataSet(string commandText)
        {
            return this.GetDataSet(commandText, false, null);
        }

        public DataSet GetDataSet(string commandText, bool isProcedure)
        {
            return this.GetDataSet(commandText, isProcedure, null);
        }

        public DataSet GetDataSet(string commandText, bool isProcedure, SqlParameter[] dataParameters)
        {
            DataSet result = new DataSet();
            try
            {
                if (isProcedure)
                {
                    this._comm.CommandType = CommandType.StoredProcedure;
                    this._comm.Parameters.AddRange(dataParameters);
                }
                this._comm.CommandText = commandText;
                this._adpt.SelectCommand = this._comm;
                this._adpt.Fill(result);
                return result;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                if (isProcedure)
                {
                    this._comm.CommandType = CommandType.Text;
                    this._comm.Parameters.Clear();
                }
            }
        }

        public SqlDataReader GetReader(string commandText)
        {
            return this.GetReader(commandText, false, null);
        }

        public SqlDataReader GetReader(string commandText, bool isProcedure)
        {
            return this.GetReader(commandText, isProcedure, null);
        }

        public SqlDataReader GetReader(string commandText, bool isProcedure, SqlParameter[] dataParameters)
        {
            SqlDataReader result;
            try
            {
                if (isProcedure)
                {
                    this._comm.CommandType = CommandType.StoredProcedure;
                    this._comm.Parameters.AddRange(dataParameters);
                }
                this._comm.CommandText = commandText;
                result = this._comm.ExecuteReader();
                return result;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                if (isProcedure)
                {
                    this._comm.CommandType = CommandType.Text;
                    this._comm.Parameters.Clear();
                }
            }
        }

        public object GetDataScalar(string commandText)
        {
            return this.GetDataScalar(commandText, false, null);
        }

        public object GetDataScalar(string commandText, bool isProcedure)
        {
            return this.GetDataScalar(commandText, isProcedure, null);
        }

        public object GetDataScalar(string commandText, bool isProcedure, SqlParameter[] dataParameters)
        {
            try
            {
                if (isProcedure)
                {
                    this._comm.CommandType = CommandType.StoredProcedure;
                    this._comm.Parameters.AddRange(dataParameters);
                }
                this._comm.CommandText = commandText;
                return this._comm.ExecuteScalar();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                if (isProcedure)
                {
                    this._comm.CommandType = CommandType.Text;
                    this._comm.Parameters.Clear();
                }
            }
        }

        public object GetValue(string tableName, string fieldName, string criteria)
        {
            string cmdText;
            try
            {
                cmdText = "SELECT " + fieldName + " FROM " + tableName + " WHERE " + criteria;
                this._comm.CommandText = cmdText;
                return this._comm.ExecuteScalar();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
        }

        public bool FillData(ref DataRow row, string commandText)
        {
            if (this.FillData(row.Table, commandText))
            {
                if (row.Table.Rows.Count > 0)
                    row = row.Table.Rows[0];
                else
                    row = row.Table.NewRow();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FillDataWithScalar(ref DataTable table, string commandText)
        {
            try
            {
                this._comm.CommandText = commandText;
                this._adpt.SelectCommand = this._comm;
                table.Clear();
                this._adpt.Fill(table);
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public bool FillData(DataTable table, string commandText)
        {
            return this.FillData(table, commandText, false, null);
        }

        public bool FillData(DataTable table, string commandText, bool isProcedure)
        {
            return this.FillData(table, commandText, isProcedure, null);
        }

        public bool FillData(DataTable table, string commandText, bool isProcedure, SqlParameter[] dataParameters)
        {
            try
            {
                if (isProcedure)
                {
                    this._comm.CommandType = CommandType.StoredProcedure;
                }
                if (dataParameters != null)
                {
                    this._comm.Parameters.AddRange(dataParameters);
                }
                this._comm.CommandText = commandText;
                this._adpt.SelectCommand = this._comm;
                table.Clear();
                this._adpt.Fill(table);
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                this._comm.CommandType = CommandType.Text;
                this._comm.Parameters.Clear();
            }
        }

        public DataTable GetDataTable(string tableName)
        {
            return this.GetDataTable(tableName, false, null);
        }

        public DataTable GetDataTable(string tableName, bool isProcedure)
        {
            return this.GetDataTable(tableName, isProcedure, null);
        }

        public DataTable GetDataTable(string tableName, bool isProcedure, SqlParameter[] dataParameters)
        {
            string cmdText;
            DataSet resultDs = new DataSet();
            resultDs.EnforceConstraints = false;
            try
            {
                if (isProcedure)
                {
                    cmdText = tableName;
                    this._comm.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    cmdText = "SELECT top 1 * FROM " + tableName + " WHERE 1=0";
                }
                if (dataParameters != null) this._comm.Parameters.AddRange(dataParameters);
                this._comm.CommandText = cmdText;
                this._adpt.SelectCommand = this._comm;
                this._adpt.FillSchema(resultDs, SchemaType.Source, tableName);
                this._adpt.Fill(resultDs, tableName);
                return resultDs.Tables[0];
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                this._comm.CommandType = CommandType.Text;
                this._comm.Parameters.Clear();
            }
        }

        //public string GetColumnDescription(string tableName, string columnName)
        //{
        //    return this.GetColumnDescription(tableName, columnName, columnName);
        //}

        //public string GetColumnDescription(string tableName, string columnName, string columnCaption)
        //{
        //    string cmdText;
        //    object result;
        //    try
        //    {
               
        //        return columnCaption;
        //    }
        //    catch
        //    {
        //        return columnCaption;
        //    }
        //}

        public string GetColumnDescription(string tableName, string columnName)
        {
            return this.GetColumnDescription(tableName, columnName, columnName);
        }

        public string GetColumnDescription(string tableName, string columnName, string columnCaption)
        {
            string cmdText;
            object result;
            try
            {
                //cmdText = "SELECT sysproperties.[value] " +
                //    " FROM sysobjects INNER JOIN syscolumns ON sysobjects.id = syscolumns.id INNER JOIN " +
                //    " sysproperties ON syscolumns.id = sysproperties.id AND syscolumns.colid = sysproperties.smallid " +
                //    " where sysobjects.name='" + tableName + "' and syscolumns.name='" + columnName + "'";
                cmdText = "SELECT tblAppColumns.Description " +
                    " FROM tblAppTables INNER JOIN tblAppColumns ON tblAppTables.TableId = tblAppColumns.TableId" +
                    " WHERE tblAppTables.TableName='" + tableName + "' AND tblAppColumns.ColumnName='" + columnName + "'";
                this._comm.CommandText = cmdText;
                result = this._comm.ExecuteScalar();
                if (result == null || Convert.IsDBNull(result))
                    return columnCaption;
                else
                    return Convert.ToString(result);
            }
            catch
            {
                return columnCaption;
            }
        }

        public string GetTableDescription(string tableName)
        {
            string cmdText;
            object result;
            try
            {
                cmdText = "SELECT Description FROM tblAppTables WHERE TableName='" + tableName + "'";
                this._comm.CommandText = cmdText;
                result = this._comm.ExecuteScalar();
                if (result == null || Convert.IsDBNull(result))
                    return tableName;
                else
                    return Convert.ToString(result);
            }
            catch
            {
                return tableName;
            }
        }

        //public string GetTableDescription(string tableName)
        //{
        //    string cmdText;
        //    object result;
        //    try
        //    {
               
        //        return tableName;
        //    }
        //    catch
        //    {
        //        return tableName;
        //    }
        //}

        public string TestCommandText(string commandText)
        {
            try
            {
                this.BeginTransaction();
                this._comm.CommandText = commandText;
                this._comm.ExecuteNonQuery();
                return string.Empty;
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
            finally
            {
                this.RollbackTransaction();
            }
        }

        public bool IsTableExist(string tableName)
        {
            string cmdText;
            try
            {
                cmdText = "SELECT * FROM " + tableName + " WHERE 1=0";
                this._comm.CommandText = cmdText;
                if (this._comm.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public bool Insert(string title, DataRow row, bool showMessage)
        {
            return this.Insert(title, row, showMessage, true);
        }

        public bool Insert(string title, DataRow row, bool showMessage, bool validate)
        {
            string cmdText;
            
            try
            {
                if (validate)
                {
                    if (!clDataUtility.Validate(row, this._connString))
                    {
                        return false;
                    }
                }

                cmdText = clDataUtility.GetQuery(1, row);
                if (this.Execute(cmdText))
                {
                    if (showMessage) MessageBox.Show(title + " added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    if (showMessage) MessageBox.Show(title + " could not be added", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        //public static bool Insert(DataRow row, DataTable table, bool validate, string connString)
        //{
        //    string checkValueMsg;
        //    try
        //    {
        //        if (validate)
        //        {
        //            if (!Validate(row, connString))
        //            {
        //                return false;
        //            }
        //        }

        //        DataRow newRow = table.NewRow();
        //        for (int i = 0; i < table.Columns.Count; i++)
        //        {
        //            if (!table.Columns[i].AutoIncrement && !table.Columns[i].ReadOnly) newRow[i] = row[i];
        //        }
        //        //newRow.ItemArray = row.ItemArray;
        //        table.Rows.Add(newRow);
        //        return true;
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //        return false;
        //    }
        //}

        public bool Update(string title, DataRow row, bool showMessage)
        {
            return this.Update(title, row, showMessage, true);
        }

        public bool Update(string title, DataRow row, bool showMessage, bool validate)
        {
            string cmdText;
            
            try
            {
                if (validate)
                {
                    if (!clDataUtility.Validate(row, this._connString))
                    {
                        return false;
                    }
                }

                cmdText = clDataUtility.GetQuery(2, row);
                if (this.Execute(cmdText))
                {
                    if (showMessage) MessageBox.Show(title + " updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    if (showMessage) MessageBox.Show(title + " could not be updated", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public bool Delete(string title, DataRow row, bool showMessage)
        {
            return this.Delete(title, row, showMessage, true);
        }

        public bool Delete(string title, DataRow row, bool showMessage, bool validate)
        {
            string cmdText;
            string checkValueMsg;
            try
            {
                if (validate)
                {
                    if (!clDataUtility.Validate(row, row.Table.PrimaryKey, this._connString))
                    {
                        return false;
                    }
                }

                cmdText = clDataUtility.GetQuery(3, row);
                if (this.Execute(cmdText))
                {
                    if (showMessage) MessageBox.Show(title + " deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    if (showMessage) MessageBox.Show(title + " could not be deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        //public static bool Delete(DataRow row, DataTable table, bool validate, string connString)
        //{
        //    string checkValueMsg;
        //    object[] primaryKeys;
        //    try
        //    {
        //        if (validate)
        //        {
        //            if (!Validate(row, row.Table.PrimaryKey, connString))
        //            {
        //                return false;
        //            }
        //        }
        //        primaryKeys = new object[row.Table.PrimaryKey.Length];
        //        for (int i = 0; i < row.Table.PrimaryKey.Length; i++)
        //            primaryKeys[i] = row[row.Table.PrimaryKey[i]];
        //        row = table.Rows.Find(primaryKeys);
        //        row.Delete();
        //        return true;
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //        return false;
        //    }
        //}

        public bool UpdateTable(DataTable table)
        {
            return UpdateTable(table, false);
        }

        public bool UpdateTable(DataTable table, bool acceptChanges)
        {
            bool adptAcceptChangesFill = this._adpt.AcceptChangesDuringFill;
            bool adptAcceptChangesUpdate = this._adpt.AcceptChangesDuringUpdate;
            try
            {
                this._comm.CommandText = "SELECT * FROM " + table.TableName + " WHERE 1=0";
                this._adpt = new SqlDataAdapter(this._comm);
                this._adpt.AcceptChangesDuringFill = acceptChanges;
                this._adpt.AcceptChangesDuringUpdate = acceptChanges;
                //this._adpt = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM " + table.TableName + " WHERE 1=0", this._conn);
                SqlCommandBuilder cmdBuilder = new System.Data.SqlClient.SqlCommandBuilder(this._adpt);
                this._adpt.Update(table);
                return true;
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547)
                {
                    MessageBox.Show("The record is alreay in use by another object.\n\n" + sqlEx.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("The record should be unique.\n\n" + sqlEx.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(sqlEx.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                this._adpt.AcceptChangesDuringFill = adptAcceptChangesFill;
                this._adpt.AcceptChangesDuringUpdate = adptAcceptChangesUpdate;
            }
        }

        //public static bool Update(DataRow row, DataTable table, bool validate, string connString)
        //{
        //    string checkValueMsg;
        //    object[] primaryKeys;
        //    try
        //    {
        //        if (validate)
        //        {
        //            if (!Validate(row, connString))
        //            {
        //                return false;
        //            }
        //        }
        //        primaryKeys = new object[row.Table.PrimaryKey.Length];
        //        for (int i = 0; i < row.Table.PrimaryKey.Length; i++)
        //            primaryKeys[i] = row[row.Table.PrimaryKey[i]];
        //        DataRow updateRow = table.Rows.Find(primaryKeys);
        //        for (int i = 0; i < table.Columns.Count; i++)
        //        {
        //            if (!table.Columns[i].AutoIncrement && !table.Columns[i].ReadOnly) updateRow[i] = row[i];
        //        }
        //        //table.Rows.Find(primaryKeys).ItemArray = row.ItemArray;
        //        return true;
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //        return false;
        //    }
        //}

        private string GetExceptionMessage(SqlException exception)
        {
            if (exception.Number == 547)
            {
                return this.GetForeignKeyExceptionMessage(exception.Message);
            }
            else if (exception.Number == 2627)
            {
                return this.GetUniqueExceptionMessage(exception.Message);
            }
            else
            {
                return exception.Message;
            }
        }

        private string GetForeignKeyExceptionMessage(string message)
        {
            string tableName, tableDescription;
            string[] tempStr = message.Split(new string[] { "', table '", "', column '" }, StringSplitOptions.None);
            tableName = tempStr[1];
            tableDescription = this.GetTableDescription(tableName);
            if (tableDescription != tableName)
                //return ("The record is being used by one or more '" + tableDescription + "'.\n\n" + message);
                return ("Deletion could not completed because the record is being used by another object.\n\n");
            else
                //return ("The record is being used by another object.\n\n" + message);
                return ("Deletion could not completed because the record is being used by another object.\n\n");
        }

        private string GetUniqueExceptionMessage(string message)
        {
            string cmdText;
            DataTable result;
            string constraintName, tableName, columnName, columnDescription;
            int tableId;
            try
            {
                string[] tempStr = message.Split(new string[] { " KEY constraint '", "'. Cannot insert duplicate key in object '" }, StringSplitOptions.None);
                constraintName = tempStr[1];

                result = new DataTable();
                cmdText = "select syscolumns.Name, syscolumns.Id from syscolumns" +
                    " inner join sysindexkeys on syscolumns.id=sysindexkeys.id and syscolumns.colid=sysindexkeys.colid" +
                    " inner join sysindexes on sysindexkeys.id=sysindexes.id and sysindexkeys.indid=sysindexes.indid" +
                    " where sysindexes.name='" + constraintName + "'";
                this.FillData(result, cmdText);
                if (result.Rows.Count == 0)
                    columnDescription = "Record";
                else
                {
                    tableId = Convert.ToInt32(result.Rows[0]["Id"]);
                    columnName = Convert.ToString(result.Rows[0]["Name"]);
                    tableName = this.GetDataObjectName(tableId);
                    columnDescription = this.GetColumnDescription(tableName, columnName);
                }
                return (columnDescription + " should be unique.\n\n" + message);
            }
            catch
            {
                return ("Record should be unique.\n\n" + message);
            }
        }

        private int GetDataObjectId(string dataObjName)
        {
            object result;
            try
            {
                result = this.GetValue("sysobjects", "id", "name='" + dataObjName + "'");
                if (result == null || Convert.IsDBNull(result))
                    return -1;
                else
                    return Convert.ToInt32(result);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return -1;
            }
        }

        private string GetDataObjectName(int objectId)
        {
            object result;
            try
            {
                result = this.GetValue("sysobjects", "name", "id=" + objectId);
                if (result == null || Convert.IsDBNull(result))
                    return string.Empty;
                else
                    return Convert.ToString(result);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
        }

        public static void SetToDatabaseDefaults(DataRow Dr, string connString)
        {
            DataTable Dt;
            DataColumn dataColumn;
            string SqlStr = string.Empty;
            string DbDefaultValue = string.Empty;
            string fldname = string.Empty;
           
            

            clDatacon DataObj = new clDatacon(connString);


            try
            {
                DataObj.OpenConnection();
                SqlStr = "select sc.name from sysobjects as so inner join syscolumns as sc on so.id=sc.id inner join systypes as st on sc.xusertype=st.xusertype " +
                         " where so.name='" + Dr.Table.TableName + "' and sc.cdefault=0 and st.name in ('SmallDateTime','DateTime')";
                Dt = new DataTable();
                DataObj.FillData(Dt, SqlStr);
                foreach (DataRow DtDr in Dt.Rows)
                {
                    fldname = DtDr["name"].ToString();
                    Dr[fldname] = clUtility.GetCurrentDate().ToShortDateString();
                    
                }

                //read all default values and assign to Data Row
                SqlStr = "select sc.name, df.text as DbDefaultValue from sysobjects as so inner join syscolumns as sc on so.id=sc.id " +
                       " inner join systypes as st on sc.xusertype=st.xusertype inner join syscomments as df on sc.cdefault = df.id " +
                       " where so.name='" + Dr.Table.TableName + "' and sc.cdefault<>0 ";

                Dt = new DataTable();
                DataObj.FillData(Dt, SqlStr);
                foreach (DataRow DtDr in Dt.Rows)
                {
                    fldname = DtDr["name"].ToString();
                    DbDefaultValue = DtDr["dbDefaultvalue"].ToString();
                    if (DbDefaultValue.Length > 0)
                    {
                        dataColumn = Dr.Table.Columns[fldname];
                        if (dataColumn.DataType == System.Type.GetType("System.String") && DbDefaultValue != "(host_name())")
                          DbDefaultValue = DbDefaultValue.Substring(2, DbDefaultValue.Length - 4);
                       
                        else
                        {
                            DbDefaultValue = DbDefaultValue.Substring(1, DbDefaultValue.Length - 2);
                            int index=DbDefaultValue.IndexOf("(");
                            if(index==0)
                              DbDefaultValue = DbDefaultValue.Substring(1, DbDefaultValue.Length - 2);
                            
                        }
                        
                        if ((DbDefaultValue.ToLower() != "getdate()") && (DbDefaultValue.ToLower() != "host_name()"))
                        {
                            if (dataColumn.DataType == System.Type.GetType("System.Boolean"))
                                Dr[fldname] = Convert.ToInt32(DbDefaultValue) == 1 ? true : false;
                            else
                                Dr[fldname] = DbDefaultValue;
                        }
                       
                        
                    }
                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();

            }

        }

       




    }
}
