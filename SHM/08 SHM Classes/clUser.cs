using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SHM
{
    class clUser
    {
        #region Fields
        private int _userID;
        private string _userName;
        private string _fullName;
        private string _password;
        private string _userApplications;
        private string _userRoles;
        private string _menuRights;
        private string _branchRights;
        private string _unitRights;
        private bool _isActive;
        private bool _UserIsLocked;
        private bool _alreadyLogin;
        private DateTime _lastLogin;
        private DateTime _passwordChangedOn;
        #endregion

        #region Properties
        public int UserID
        {
            get { return this._userID; }
        }
        public string UserName
        {
            get { return this._userName; }
        }
        public string FullName
        {
            get { return this._fullName; }
        }
        public string Password
        {
            get { return this._password; }
        }
        public string UserApplications
        {
            get { return this._userApplications; }
        }
        public string UserRoles
        {
            get { return this._userRoles; }
        }
        public string MenuRights
        {
            get { return this._menuRights; }
        }
        public string BranchRights
        {
            get { return this._branchRights; }
        }
        public string UnitRights
        {
            get { return this._unitRights; }
        }
        public bool IsActive
        {
            get { return this._isActive; }
        }
        public bool UserIsLocked
        {
            get { return this._UserIsLocked; }
        }
        public bool AlreadyLogin
        {
            get { return this._alreadyLogin; }
        }
        public DateTime LastLogin
        {
            get { return this._lastLogin; } 
        }
        public DateTime PasswordChangedOn
        {
            get { return this._passwordChangedOn; }
        }
        #endregion

        #region Methods
        public static bool ChangePassword(int userID, string currentPassword, string newPassword, string confirmNewPassword)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                result = DataObj.GetValue("tblUsers", "Password", "UserId=" + userID + " AND Password='" + Encrypt(currentPassword) + "'");
                if (result == null)
                {
                    MessageBox.Show("Wrong current passsword", "iCMC Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    return false;
                }
                if (newPassword.Length < 6)
                {
                    MessageBox.Show("New password must be at least 6 characters long", "iCMC Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("New password and confirmation don't match", "iCMC Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                cmdText = "UPDATE tblUsers SET Password='" +Encrypt(newPassword) + "',PasswordChangedOn=getdate() WHERE UserId=" + userID;
                if (DataObj.Execute(cmdText))
                {
                    MessageBox.Show("Password changed successfully", "iCMC Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    return false;
                }
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

        public bool UpdateLogInStatus()
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "UPDATE tblUsers SET AlreadyLogIn=1, LastLogIn=getdate() WHERE UserId=" + this._userID;
                return DataObj.Execute(cmdText);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "iCMC Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public bool UpdateLogOutStatus()
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "UPDATE tblUsers SET AlreadyLogIn=0 WHERE UserId=" + this._userID;
                return DataObj.Execute(cmdText);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "iCMC Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public bool UpdateLogInApplication(int appId)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "UPDATE tblUsers SET LogInApplication=" + appId + " WHERE UserId=" + this._userID;
                return DataObj.Execute(cmdText);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "iCMC Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public bool UpdateLogOutApplication()
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "UPDATE tblUsers SET LogInApplication=null WHERE UserId=" + this._userID;
                return DataObj.Execute(cmdText);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "iCMC Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static string GetUserName(int userID)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT UserName FROM tblUsers WHERE UserID=" + userID;
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

        public static int GetUserID(string userName)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT UserID FROM tblUsers WHERE UserName='" + userName + "'";
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

        public static int GetUserID(string userName, string password)
        {
            object result;
            string cmdText;
           clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT UserID FROM tblUsers WHERE UserName='" + userName + "' AND [Password]='" + Encrypt(password) + "'";
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

        public static bool CheckAppRight(int userID, string app)
        {
            int AppID = -1;
            object result;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                result = DataObj.GetValue("tblApplications", "AppID", "AppName='" + app + "' AND IsActive=1");
                if (result == null) //application not found or is not active
                    return false;
                else
                    AppID = (int)result;

                if (userID == 1) return true; //System Administrator is granted all application rights

                //Check if application is granted or revoked for this user
                result = DataObj.GetValue("tblAppRights", "mUser", "User=" + userID + " AND Application=" + AppID);
                return (result != null);
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

        public static string GetUserApplications(int userID)
        {
            if (userID == 1)
                return "SELECT AppID FROM tblApplications";
            else
                return "SELECT Application FROM tblAppRights WHERE User=" + userID;
        }

        public static string GetUserRoles(int userID, string app)
        {
            if (userID == 1)
                return "SELECT RoleID FROM tblRoles WHERE Application= HR" + clApplication.GetAppID();
            else
                return "SELECT Role FROM tblUserRoles WHERE User=" + userID + " AND Role IN (SELECT RoleID FROM tblRoles WHERE Application=" + clApplication.GetAppID() + ")";
        }

        public static string GetMenuRights(int userID)
        {
            if (userID == 1)
                return "SELECT CodeNo FROM tblMenuDef ";
            else
                return "SELECT MenuCode FROM tblMenuRights WHERE [User]=" + userID ;
        }

        public static string GetBranchRights(int userID, string app)
        {
            if (userID == 1)
                return "SELECT BranchCode FROM mBranches";
            else
                return "SELECT Branch FROM mBranchRights WHERE User=" + userID + " AND Application=" + clApplication.GetAppID();
        }

        public static string GetUnitRights(int userID, string app)
        {
            if (userID == 1)
                return "SELECT UnitCode FROM mWorkUnits";
            else
                return "SELECT WorkUnit FROM mUnitRights WHERE User=" + userID + " AND Application=" + clApplication.GetAppID();
        }

        public clUser(int userID)
        {
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblUsers WHERE UserID=" + userID;
                Ds = DataObj.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    this._userID = userID;
                    this._userName = Convert.ToString(Ds.Tables[0].Rows[0]["UserName"]);
                    this._fullName = Convert.ToString(Ds.Tables[0].Rows[0]["FullName"]);
                    this._password = Convert.ToString(Ds.Tables[0].Rows[0]["Password"]);
                    this._isActive = Convert.ToBoolean(Ds.Tables[0].Rows[0]["IsActive"]);
                    this._UserIsLocked = Convert.ToBoolean(Ds.Tables[0].Rows[0]["UserIsLocked"]);
                    this._alreadyLogin = Convert.ToBoolean(Ds.Tables[0].Rows[0]["AlreadyLogin"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["LastLogin"]))
                        this._lastLogin = Convert.ToDateTime(Ds.Tables[0].Rows[0]["LastLogin"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["PasswordChangedOn"]))
                        this._passwordChangedOn = Convert.ToDateTime(Ds.Tables[0].Rows[0]["PasswordChangedOn"]);
                    this._userApplications = clUser.GetUserApplications(this.UserID);
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

        public clUser(int userID, string app)
        {
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblUsers WHERE UserID=" + userID;
                Ds = DataObj.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    this._userID = userID;
                    this._userName = Convert.ToString(Ds.Tables[0].Rows[0]["UserName"]);
                    this._fullName = Convert.ToString(Ds.Tables[0].Rows[0]["FullName"]);
                    this._password = Convert.ToString(Ds.Tables[0].Rows[0]["Password"]);
                    this._isActive = Convert.ToBoolean(Ds.Tables[0].Rows[0]["IsActive"]);
                    this._alreadyLogin = Convert.ToBoolean(Ds.Tables[0].Rows[0]["AlreadyLogin"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["LastLogin"]))
                        this._lastLogin = Convert.ToDateTime(Ds.Tables[0].Rows[0]["LastLogin"]);
                    if (!Convert.IsDBNull(Ds.Tables[0].Rows[0]["PasswordChangedOn"]))
                        this._passwordChangedOn = Convert.ToDateTime(Ds.Tables[0].Rows[0]["PasswordChangedOn"]);
                    this._userApplications = clUser.GetUserApplications(this.UserID);
                    this.GetAppUserRights(app);
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

        public void GetAppUserRights(string app)
        {
            this._userRoles = clUser.GetUserRoles(this.UserID, app);
            this._menuRights = clUser.GetMenuRights(this.UserID);
            this._branchRights = clUser.GetBranchRights(this.UserID, app);
            this._unitRights = clUser.GetUnitRights(this.UserID, app);
        }

        public static string Encrypt(string str)
        {
            string resultString = string.Empty;
            string tempString = string.Empty;
            char[] strArray = new char[str.Length];
            strArray = str.ToCharArray();
            char ch;
            for (int i = 0; i < strArray.Length; i++)
            {
                ch = strArray[i];
                int char1 = Convert.ToInt32(ch);
                tempString = Convert.ToString((Convert.ToInt32(ch) * Convert.ToInt32('@') * 9) + 5);
                resultString = resultString + tempString;
            }
            return resultString;
        }

        
        #endregion

    }
}
