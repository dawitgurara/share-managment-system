using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SHM
{
   public class clDatabase
    {
   #region Fields
        private int _databaseID;
        private string _name;
        private int _server;
        private int _App;
        private clDatabaseType _databaseType;
        private string _description;
        private int _fiscalYear;
        private int _period;
        private string _serverName;
        private string _serverUserID;
        private string _serverPassword;
        private bool _integratedSecurity;
        #endregion

        #region Properties
        public int DatabaseID
        {
            get { return this._databaseID; }
        }
        public string Name
        {
            get { return this._name; }
        }
        public int Server
        {
            get { return this._server; }
        }
        public int App
        {
            get { return this._App; }
        }
        public clDatabaseType DatabaseType
        {
            get { return this._databaseType; }
        }
        public string Description
        {
            get { return this._description; }
        }
        public int FiscalYear
        {
            get { return this._fiscalYear; }
        }
        public int Period
        {
            get { return this._period; }
        }
        public string ServerName
        {
            get { return this._serverName; }
        }
        public string ServerUserID
        {
            get { return this._serverUserID; }
        }
        public string ServerPassword
        {
            get { return this._serverPassword; }
        }
        public bool IntegratedSecuriy
        {
            get { return this._integratedSecurity; }
        }
        public string FullName
        {
            get { return (this._name + "@" + this._serverName); }
        }
        #endregion

        #region Methods
        public clDatabase(int databaseID)
        {
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblDatabases WHERE DatabaseID=" + databaseID;
                Ds = DataObj.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    this._databaseID = databaseID;
                    this._name = Convert.ToString(Ds.Tables[0].Rows[0]["DatabaseName"]);
                    this._App = Convert.ToInt32(Ds.Tables[0].Rows[0]["Application"]);
                    this._server = Convert.ToInt32(Ds.Tables[0].Rows[0]["Server"]);
                    this._databaseType = (clDatabaseType)Convert.ToInt32(Ds.Tables[0].Rows[0]["DatabaseType"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["Description"]))
                        this._description = Convert.ToString(Ds.Tables[0].Rows[0]["Description"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["FiscalYear"]))
                        this._fiscalYear = Convert.ToInt32(Ds.Tables[0].Rows[0]["FiscalYear"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["Period"]))
                        this._period = Convert.ToInt32(Ds.Tables[0].Rows[0]["Period"]);

                    cmdText = "SELECT * FROM mServers WHERE ServerID=" + this.Server;
                    Ds = DataObj.GetDataSet(cmdText);
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        this._serverName = Convert.ToString(Ds.Tables[0].Rows[0]["ServerName"]);
                        this._serverUserID = Convert.ToString(Ds.Tables[0].Rows[0]["UserID"]);
                        this._serverPassword = Convert.ToString(Ds.Tables[0].Rows[0]["Password"]);
                        this._integratedSecurity = Convert.ToBoolean(Ds.Tables[0].Rows[0]["IntegratedSecurity"]);
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

        public static clDatabase GetAppDatabase(string app)
        {
            int DBID = -1;
            object resultDBID;
            clDatabase result = null;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT DatabaseID FROM tblDatabases WHERE Application=" + GetAppID(app) + " AND DatabaseType=" + (int)clDatabaseType.Default;
                resultDBID = DataObj.GetDataScalar(cmdText);
                if (resultDBID != null)
                    DBID = Convert.ToInt32(resultDBID);
                if (DBID != -1)
                {
                    result = new clDatabase(DBID);
                }
                return result;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static clDatabase[] GetAppDatabase(string app, int fiscalYear)
        {
            return clDatabase.GetAppDatabase(app, fiscalYear, -1);
        }

        public static clDatabase[] GetAppDatabase(string app, int fiscalYear, int period)
        {
            List<clDatabase> result = new List<clDatabase>();
            int DBID = -1;
            DataSet resultDs;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
               
                cmdText = "SELECT DatabaseID FROM tblDatabases WHERE Application=" + GetAppID(app) + " AND DatabaseType=" + (int)clDatabaseType.History + " AND FiscalYear=" + fiscalYear;
                if (period != -1)
                    cmdText = cmdText + " AND Period=" + period;

                resultDs = DataObj.GetDataSet(cmdText);
                foreach (DataRow row in resultDs.Tables[0].Rows)
                {
                    DBID = Convert.ToInt32(row[0]);
                    result.Add(new clDatabase(DBID));
                }
                return result.ToArray();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static clDatabase[] GetAppDatabase(string serverName, string databaseName)
        {
            List<clDatabase> result = new List<clDatabase>();
            int DBID = -1;
            DataSet resultDs;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                cmdText = "SELECT DatabaseId FROM tblDatabases WHERE DatabaseName='" + databaseName + "' AND Server IN (SELECT ServerId FROM mServers WHERE ServerName='" + serverName + "')";

                resultDs = DataObj.GetDataSet(cmdText);
                foreach (DataRow row in resultDs.Tables[0].Rows)
                {
                    DBID = Convert.ToInt32(row[0]);
                    result.Add(new clDatabase(DBID));
                }
                return result.ToArray();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static clDatabase GetAppBranchDatabase(string app, string branch)
        {
            int DBID = -1;
            object resultDBID;
            clDatabase result = null;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT DatabaseID FROM mBranchDBRights, mDatabases WHERE [Database]=DatabaseID AND Application=" + GetAppID(app) + " AND Branch=" + branch + " AND DatabaseType=" + (int)clDatabaseType.BranchDefault;
                resultDBID = DataObj.GetDataScalar(cmdText);
                if (resultDBID != null)
                    DBID = Convert.ToInt32(resultDBID);
                if (DBID != -1)
                {
                    result = new clDatabase(DBID);
                }
                return result;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static clDatabase[] GetAppBranchDatabase(string app, string branch, int fiscalYear)
        {
            return clDatabase.GetAppBranchDatabase(app, branch, fiscalYear, -1);
        }

        public static clDatabase[] GetAppBranchDatabase(string app, string branch, int fiscalYear, int period)
        {
            List<clDatabase> result = new List<clDatabase>();
            int DBID = -1;
            DataSet resultDs;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                cmdText = "SELECT DatabaseID FROM mBranchDBRights, mDatabases WHERE [Database]=DatabaseID AND Application=" + GetAppID(app) + " AND Branch=" + branch + " AND DatabaseType=" + (int)clDatabaseType.BranchHistory + " AND FiscalYear=" + fiscalYear;
                if (period != -1)
                    cmdText = cmdText + " AND Period=" + period;

                resultDs = DataObj.GetDataSet(cmdText);
                foreach (DataRow row in resultDs.Tables[0].Rows)
                {
                    DBID = Convert.ToInt32(row[0]);
                    result.Add(new clDatabase(DBID));
                }
                return result.ToArray();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static clDatabase GetAppUserDatabase(string app, int userID)
        {
            int DBID = -1;
            object resultDBID;
            clDatabase result = null;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT DatabaseID FROM tblUserDBRights, tblDatabases WHERE [Database]=DatabaseID AND Application=" + GetAppID(app) + " AND HillUser=" + userID + " AND DatabaseType=" + (int)clDatabaseType.UserDefault;
                resultDBID = DataObj.GetDataScalar(cmdText);
                if (resultDBID != null)
                    DBID = Convert.ToInt32(resultDBID);
                if (DBID != -1)
                {
                    result = new clDatabase(DBID);
                }
                return result;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static clDatabase[] GetAppUserDatabase(string app, int userID, int fiscalYear)
        {
            return clDatabase.GetAppUserDatabase(app, userID, fiscalYear, -1);
        }

        public static clDatabase[] GetAppUserDatabase(string app, int userID, int fiscalYear, int period)
        {
            List<clDatabase> result = new List<clDatabase>();
            int DBID = -1;
            DataSet resultDs;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                cmdText = "SELECT DatabaseID FROM tblUserDBRights, mDatabases WHERE [Database]=DatabaseID AND Application=" + GetAppID(app) + " AND User=" + userID + " AND DatabaseType=" + (int)clDatabaseType.UserHistory + " AND FiscalYear=" + fiscalYear;
                if (period != -1)
                    cmdText = cmdText + " AND Period=" + period;

                resultDs = DataObj.GetDataSet(cmdText);
                foreach (DataRow row in resultDs.Tables[0].Rows)
                {
                    DBID = Convert.ToInt32(row[0]);
                    result.Add(new clDatabase(DBID));
                }
                return result.ToArray();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public bool BackupDatabase()
        {
            string sysFileName;
            sysFileName = this.GetBackUpFileName();
            return this.BackupDatabase(sysFileName);
        }

        public bool BackupDatabase(string fileName)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "BACKUP DATABASE " + this.Name + " TO DISK='" + GetAppDataPath(GetAppName(this.App)) + "\\" + fileName + ".bak'";
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

        public static bool BackupAppDatabase(string app)
        {
            return clDatabase.BackupAppDatabase(app, null);
        }

        public static bool BackupAppDatabase(string app, string fileName)
        {
            clDatabase appDB = clDatabase.GetAppDatabase(app);
            if (appDB == null)
                return false;
            else
            {
                if (fileName == null)
                    return appDB.BackupDatabase();
                else
                    return appDB.BackupDatabase(fileName);
            }
        }

        private string GetBackUpFileName()
        {
            string SysFileName;
            SysFileName = DateTime.Now.ToString();
            SysFileName = SysFileName.Replace("/", ".");
            SysFileName = SysFileName.Replace(":", ".");
            SysFileName = this.Name + " " + SysFileName;
            return SysFileName;
        }

        public static bool RestoreDatabase(string app, string databaseName, string fileName)
        {
            return false;
        }

        public string GetConnectionString()
        {
            return clDataUtility.GetConnString(this._serverName, this._name, this._serverUserID, this._serverPassword, this._integratedSecurity);
        }

        public static SqlConnectionStringBuilder GetConnectionStringBuilder(string connString)
        {
            SqlConnectionStringBuilder resultConnString;
            try
            {
                resultConnString = new SqlConnectionStringBuilder(connString);
                return resultConnString;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
        }

        public static bool isHistoryDatabase(string connString)
        {
            SqlConnectionStringBuilder connStrBld;
            List<clDatabase> resultDatabases = new List<clDatabase>();
            try
            {
                connStrBld = GetConnectionStringBuilder(connString);
                if (connStrBld != null)
                {
                    resultDatabases.AddRange(GetAppDatabase(connStrBld.DataSource, connStrBld.InitialCatalog));
                    foreach (clDatabase hillDB in resultDatabases)
                    {
                        if ((hillDB.DatabaseType == clDatabaseType.History) || (hillDB.DatabaseType == clDatabaseType.BranchHistory) || (hillDB.DatabaseType == clDatabaseType.UserHistory))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #region Copied from clApplication to avoid circular reference
        private static string GetAppName(int appID)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT AppName FROM tblApplications WHERE AppID=" + appID;
                result = DataObj.GetDataScalar(cmdText);
                if (result != null)
                    return result.ToString();
                else
                    return null;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private static int GetAppID(string app)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT AppID FROM tblApplications WHERE AppName='" + app + "'";
                result = DataObj.GetDataScalar(cmdText);
                if (result != null)
                    return Convert.ToInt32(result);
                else
                    return -1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return -1;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private static string GetAppDataPath(string app)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT DataPath FROM tblApplications WHERE AppName='" + app + "'";
                result = DataObj.GetDataScalar(cmdText);
                if (result != null && !Convert.IsDBNull(result))
                    return result.ToString();
                else
                    return null;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        } 
        #endregion

        #endregion

    }

    /// <summary>
    /// Specifies type of a HillMark.HillDatabase.
    /// </summary>
    public enum clDatabaseType
    {
        Default = 1,
        History,
        BranchDefault,
        BranchHistory,
        UserDefault,
        UserHistory,
        Test
    }
}

