using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace SHM
{
    public class clApplication
    {
       #region Fields
        private int _appID;
        private string _name;
        private string _description;
        private int _currentYear;
        private int _currentPeriod;
        private int _maximumPeriod;
        private bool _isActive;
       
        private string _appPath;
        private string _dataPath;
        private string _reportPath;
        private int _PasswordExpiryDays;
        private int _GraceLogins;
        private int _MinimumPwdLength;
        private int _NoOfUnsuccessAttempt;
        
        #endregion

        #region Properties
        public int AppID
        {
            get { return this._appID; }
        }
        public string Name
        {
            get { return this._name; }
        }
        public string Description
        {
            get { return this._description; }
        }
        public int CurrentPeriod
        {
            get { return this._currentPeriod; }
            set { this._currentPeriod = value; }
        }
        public int MaximumPeriod
        {
            get { return this._maximumPeriod; }
        }
        public bool IsActive
        {
            get { return this._isActive; }
        }
       
        public string AppPath
        {
            get { return this._appPath; }
        }
        public string DataPath
        {
            get { return this._dataPath; }
        }
        public string ReportPath
        {
            get { return this._reportPath; }
        }

        public int PasswordExpiryDays
        {
            get { return this._PasswordExpiryDays; }
        }
        public int GraceLogins
        {
            get { return this._GraceLogins; }
        }
        public int MinimumPwdLength
        {
            get { return this._MinimumPwdLength; }
        }
        public int NoOfUnsuccessAttempt
        {
            get { return this._NoOfUnsuccessAttempt; }
        }
        
        #endregion

        #region Methods
        public static string GetAppName(int appID)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT top 1 AppName FROM tblApplications WHERE AppID=" + appID;
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

        public static int GetAppID()
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT top 1 AppID FROM tblApplications";
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

        public static int GetCurrentYear()
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT CalendarYear as FiscalYear FROM tblYearPeriod WHERE YearPeriod=" + GetCurrentPeriod();
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

        public static int GetCurrentPeriod()
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT CurrentPeriod FROM tblApplications";
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

        public static string GetAppPath()
        {
            object result;
            string cmdText;
           clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT AppPath FROM tblApplications";
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

        public static string GetAppDataPath()
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT DataPath FROM tblApplications";
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

        public static string GetAppReportPath()
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT ReportPath FROM tblApplications";
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

        private void InitApplication()
        {
            DataSet Ds;
            string cmdText;
           clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblApplications ";
                Ds = DataObj.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    this._appID = Convert.ToInt32(Ds.Tables[0].Rows[0]["AppID"]);
                    this._name = "SHM";
                    this._description = Convert.ToString(Ds.Tables[0].Rows[0]["Description"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["CurrentPeriod"]))
                        this._currentYear = clApplication.GetCurrentYear();
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["CurrentPeriod"]))
                        this._currentPeriod = Convert.ToInt32(Ds.Tables[0].Rows[0]["CurrentPeriod"]);
                    this._maximumPeriod = Convert.ToInt32(Ds.Tables[0].Rows[0]["MaximumPeriod"]);
                    this._isActive = Convert.ToBoolean(Ds.Tables[0].Rows[0]["IsActive"]);
                    this._appPath = clApplication.GetAppPath();
                    this._dataPath = clApplication.GetAppDataPath();
                    this._reportPath = clApplication.GetAppReportPath();
                    
                   
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

        private void GetDefaultValues()
        {
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblDefaults ";
                Ds = DataObj.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                  
                   
                   
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["PasswordExpiryDays"]))
                        this._PasswordExpiryDays = Convert.ToInt32(Ds.Tables[0].Rows[0]["PasswordExpiryDays"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["GraceLogins"]))
                        this._GraceLogins = Convert.ToInt32(Ds.Tables[0].Rows[0]["GraceLogins"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["MinimumPwdLength"]))
                        this._MinimumPwdLength = Convert.ToInt32(Ds.Tables[0].Rows[0]["MinimumPwdLength"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["NoOfUnsuccessAttempt"]))
                        this._NoOfUnsuccessAttempt = Convert.ToInt32(Ds.Tables[0].Rows[0]["NoOfUnsuccessAttempt"]);
                   
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

        public clApplication()
        {
            InitApplication();
            GetDefaultValues();
        }

        
        #endregion

    }
}
