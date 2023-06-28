using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHM
{
    public partial class frmUserAdmin : Form
    {
        #region Fields
        private string _title = "User";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

        private int _userId = -1;
       
        private DataTable _tblUsers;
        private DataRow _user;

        private DataTable _tblUsersList;
        private DataTable _pS_GetUserMenuRights;
        private DataTable _pS_GetUserRoleRights;
        private DataTable _pS_GetUserReportRights;
        private DataTable _pS_GetUserReminderRights;
        private DataTable _pS_GetUserOtherParamterRights;

        private DataTable _tblUsersPrev;
        private DataTable _tblAuditLog;
        private DataRow _AuditLog;

        #endregion

        #region Properties
        public bool IsNew
        {
            get { return this._isNew; }
            set
            {
                this._isNew = value;
                this.deleteToolStripButton.Enabled = !this._isNew;
                this.userNameTextBox.ReadOnly = !this._isNew;
            }
        }
        #endregion

        public frmUserAdmin()
        {
            InitializeComponent();
        }

        private void frmUserAdmin_Load(object sender, EventArgs e)
        {
            this.tabUserRoleRights.Hide();
            if (clMain.User.UserID!= 1)
            {
                this.tctRights.Visible = false;
            }
            BindControls();
            InitForm(true);
        }

        private void frmUserAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


        private void DisableControls(int userId)
        {
            if (userId == 1 && clMain.User.UserID != 1)
            {
                this.groupBox1.Enabled = false;
                this.tspUserAdmin.Enabled = false;
            }
            else
            {
                this.groupBox1.Enabled = true;
                this.tspUserAdmin.Enabled = true;
            }
        }
        private void BindControls()
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
           
            try
            {
                DataObj.OpenConnection();
                this._tblUsersList = DataObj.GetDataTable("tblUsers");
                
                clMain.SetDataSource(this.userIdLookUpEdit, this._tblUsersList);
                
                this.userIdLookUpEdit.Properties.NullText = "-- Select " + this._title + " --";
              
                this._tblUsers = DataObj.GetDataTable("tblUsers");
                this._tblUsers.Columns["UserId"].ReadOnly = true;
                this._tblUsers.Columns["AlreadyLogin"].ReadOnly = true;
                this._tblUsers.Columns["LastLogin"].ReadOnly = true;
                this._tblUsers.Columns["PasswordChangedOn"].ReadOnly = true;
                this._tblUsers.Columns["CrtDt"].ReadOnly = true;
                this._tblUsers.Columns["CrtWs"].ReadOnly = true;

                this._tblUsersPrev = DataObj.GetDataTable("tblUsers");
                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;


                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.userNameTextBox,
                    this.fullNameTextBox,
                    this.passwordTextBox,
                    this.isActiveCheckBox,
                    this.alreadyLoginCheckBox,
                    this.UserIsLockedCheckBox,
                    this.lastLoginDateTimePicker,
                    this.passwordChangedOnDateTimePicker
                });

                clMain.BindControls(cntrsList, this._tblUsers, false);
                cntrsList.Clear();

                #region User Rights
                
               

                this._pS_GetUserMenuRights = DataObj.GetDataTable("PS_GetUserMenuRights", true);
                this._pS_GetUserMenuRights.Columns["Granted"].ReadOnly = false;
                this._pS_GetUserRoleRights = DataObj.GetDataTable("PS_GetUserRoleRights", true);
                this._pS_GetUserRoleRights.Columns["Granted"].ReadOnly = false;
               
                clMain.SetDataSource(this.gctUserMenuRights, this._pS_GetUserMenuRights);
                clMain.SetDataSource(this.gctUserRoleRights, this._pS_GetUserRoleRights);





                this._pS_GetUserReportRights = DataObj.GetDataTable("PS_GetUserReportRights", true);
                //this._pS_GetUserReportRights.Rows.Clear();
                this._pS_GetUserReportRights.Columns["Granted"].ReadOnly = false;
                this._pS_GetUserReminderRights = DataObj.GetDataTable("PS_GetUserReminderRights", true);
                //this._pS_GetUserReminderRights.Rows.Clear();
                this._pS_GetUserReminderRights.Columns["Granted"].ReadOnly = false;
                this._pS_GetUserOtherParamterRights = DataObj.GetDataTable("PS_GetUserOtherParameterRights", true);
                //this._pS_GetUserGlobalParamterRights.Rows.Clear();
                this._pS_GetUserOtherParamterRights.Columns["Granted"].ReadOnly = false;
                
                clMain.SetDataSource(this.gctUserReportRights, this._pS_GetUserReportRights);
                clMain.SetDataSource(this.gctUserReminderRights, this._pS_GetUserReminderRights);
                clMain.SetDataSource(this.gctUserGlobalParameterRights, this._pS_GetUserOtherParamterRights);

               
                #endregion

            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void InitForm(bool All)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                if (All)
                {

                }
                if (clMain.User.UserID == 1)
                {
                    if (this.chkUserAll.Checked)
                        DataObj.FillData(this._tblUsersList, "SELECT * FROM tblUsers");
                    else
                        DataObj.FillData(this._tblUsersList, "SELECT * FROM tblUsers WHERE IsActive=1");
                }
                else
                {
                    if (this.chkUserAll.Checked)
                        DataObj.FillData(this._tblUsersList, "SELECT * FROM tblUsers where userId!= 1");
                    else
                        DataObj.FillData(this._tblUsersList, "SELECT * FROM tblUsers WHERE userId!= 1 and IsActive=1");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshToolStripButton1_Click(null, null);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (this.Validate())
                {
                    this.userIdLookUpEdit.Focus();

                    if (this._userId == -1)
                    {
                        AppMessageBox.ShowExclamation("Please select or add new " + this._title);
                        this.userIdLookUpEdit.Focus();
                        return;
                    }

                    this._user = this._tblUsers.Rows[0];

                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        this._user["password"] = clUser.Encrypt(this._user["password"].ToString());
                        if (DataObj.Insert(this._title, this._user, true))
                        {
                            this._userId = clUser.GetUserID(this._user["UserName"].ToString());
                         
                            InitForm(false);
                        }
                    }
                    else
                    {
                        DataObj.BeginTransaction();
                        string oldpass = this._tblUsersPrev.Rows[0]["Password"].ToString().Trim();
                        string nnewpass = this._user["Password"].ToString().Trim();
                        if (this._tblUsersPrev.Rows[0]["Password"].ToString().Trim() != this._user["Password"].ToString().Trim())
                             this._user["password"] = clUser.Encrypt(this._user["password"].ToString());
                        if (DataObj.Update(this._title, this._user, false))
                        {
                           
                            
                                clSecurity.UpdateMenuRights(this._userId,  this._pS_GetUserMenuRights);
                                clSecurity.UpdateRoleRights(this._userId,  this._pS_GetUserRoleRights);

                                clSecurity.UpdateReportRights(this._userId,  this._pS_GetUserReportRights);
                                clSecurity.UpdateRemiderRights(this._userId,  this._pS_GetUserReminderRights);
                                clSecurity.UpdateOtherParameterRights(this._userId,  this._pS_GetUserOtherParamterRights);
                           
                            if (InsertAuditlog(this._user))
                            {
                                DataObj.CommitTransaction();
                                AppMessageBox.ShowInformation("user detail is updated successfully");
                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("user detail updating is failed");
                            }
                           
                            InitForm(false);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private bool InsertAuditlog(DataRow user)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this._tblUsersPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();

                    if (this._tblUsersPrev.Rows[0]["FullName"].ToString().Trim() != user["FullName"].ToString().ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblUsers";
                        this._AuditLog["KeyFld"] = "UserId";
                        this._AuditLog["KeyFldValue"] = this._tblUsersPrev.Rows[0]["UserId"];
                        this._AuditLog["ActionTaken"] = "User Details Changed";
                        this._AuditLog["FldChged"] = "FullName";
                        this._AuditLog["OldValue"] = this._tblUsersPrev.Rows[0]["FullName"];
                        this._AuditLog["NewValue"] = user["FullName"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && this._tblUsersPrev.Rows[0]["Password"].ToString().Trim() != user["Password"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblUsers";
                        this._AuditLog["KeyFld"] = "UserId";
                        this._AuditLog["KeyFldValue"] = this._tblUsersPrev.Rows[0]["UserId"];
                        this._AuditLog["ActionTaken"] = "Period Details Changed";
                        this._AuditLog["FldChged"] = "Password";
                        this._AuditLog["OldValue"] = this._tblUsersPrev.Rows[0]["Password"];
                        this._AuditLog["NewValue"] = user["Password"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }

                    if (success && this._tblUsersPrev.Rows[0]["IsActive"].ToString().Trim() != user["IsActive"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblUsers";
                        this._AuditLog["KeyFld"] = "UserId";
                        this._AuditLog["KeyFldValue"] = this._tblUsersPrev.Rows[0]["UserId"];
                        this._AuditLog["ActionTaken"] = "User Details Changed";
                        this._AuditLog["FldChged"] = "IsActive";
                        this._AuditLog["OldValue"] = this._tblUsersPrev.Rows[0]["IsActive"];
                        this._AuditLog["NewValue"] = user["IsActive"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }



                }


            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();

            }
            return success;
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            this.userIdLookUpEdit.EditValue = 0;
        }

        private void refreshToolStripButton1_Click(object sender, EventArgs e)
        {
            this.userIdLookUpEdit.EditValue = null;
        }

        private void userIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.userIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.userIdLookUpEdit.EditValue))
            {
                this._userId = -1;
            }
            else
            {
                this._userId = Convert.ToInt32(this.userIdLookUpEdit.EditValue);

            }
            DisableControls(this._userId);
            this.GetUserEntry(this._userId);
            this.GetUserMenuRights(this._userId);
            this.GetUserRoleRights(this._userId);
            this.GetUserReportRights(this._userId);
            this.GetUserReminderRights(this._userId);
            this.GetUserOtherParameterRights(this._userId);
           
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._user = this._tblUsers.NewRow();
                clDatacon.SetToDatabaseDefaults(this._user, clMain.ConnString);
                if (this._userId != -1) this._user["UserId"] = this._userId;
                this._user["IsActive"] = true;
                if (clMain.User.UserName != null)
                   this._user["CrtBy"] = clMain.User.UserName;
                this._tblUsers.Rows.Clear();
                this._tblUsers.Rows.Add(this._user);
                this._isLoadingEntry = false;
            }
        }

        private bool GetUserEntry(int userId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                if (userId == -1)
                {
                    this.IsNew = false;
                    this._tblUsers.Rows.Clear();
                    this._isLoadingEntry = false;
                    return true;
                }
                if (!this.UserExists(userId))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    this.userNameTextBox.Focus();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblUsers, "SELECT * FROM tblUsers WHERE UserId=" + userId);
                    DataObj.FillData(this._tblUsersPrev, "SELECT * FROM tblUsers WHERE UserId=" + userId);
                    return true;
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    return false;
                }
                finally
                {
                    DataObj.CloseConnection();
                    this._isLoadingEntry = false;
                }
            }
            else
                return false;
        }

        private bool UserExists(int userId)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (userId == -1)
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT UserId FROM tblUsers WHERE UserId=" + userId;
                result = DataObj.GetDataScalar(cmdText);
                if (result != null && !Convert.IsDBNull(result))
                    return true;
                else
                    return false;
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void GetUserMenuRights(int userId)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                SqlParameter[] DataParameters = new SqlParameter[1];
                DataParameters[0] = new SqlParameter("UserId", userId);
               
                DataObj.FillData(this._pS_GetUserMenuRights, "PS_GetUserMenuRights", true, DataParameters);
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

        private void GetUserRoleRights(int userId)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                SqlParameter[] DataParameters = new SqlParameter[1];
                DataParameters[0] = new SqlParameter("UserId", userId);
               
                DataObj.FillData(this._pS_GetUserRoleRights, "PS_GetUserRoleRights", true, DataParameters);
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

        private void GetUserReportRights(int userId)
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
              
                DataObj.OpenConnection();
                SqlParameter[] DataParameters = new SqlParameter[1];
                DataParameters[0] = new SqlParameter("UserId", userId);
                DataObj.FillData(this._pS_GetUserReportRights, "PS_GetUserReportRights", true, DataParameters);

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

        private void GetUserReminderRights(int userId)
        {
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                SqlParameter[] DataParameters = new SqlParameter[1];
                DataParameters[0] = new SqlParameter("UserId", userId);
                DataObj.FillData(this._pS_GetUserReminderRights, "PS_GetUserReminderRights", true, DataParameters);

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

        private void GetUserOtherParameterRights(int userId)
        {
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                SqlParameter[] DataParameters = new SqlParameter[1];
                DataParameters[0] = new SqlParameter("UserId", userId);
                DataObj.FillData(this._pS_GetUserOtherParamterRights, "PS_GetUserOtherParameterRights", true, DataParameters);

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

        private void chkUserAll_CheckedChanged(object sender, EventArgs e)
        {
            InitForm(true);
        }

        private void checkAllToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.tctUserRights.SelectedTab == this.tabUserMenuRights)
                SetChecked(this._pS_GetUserMenuRights, true);
            else if (this.tctUserRights.SelectedTab == this.tabUserRoleRights)
                SetChecked(this._pS_GetUserRoleRights, true);
            else if (this.tctUserRights.SelectedTab == this.tabUserReportRights)
                SetChecked(this._pS_GetUserReportRights, true);
            else if (this.tctUserRights.SelectedTab == this.tabUserReminderRights)
                SetChecked(this._pS_GetUserReminderRights, true);
            else if (this.tctUserRights.SelectedTab == this.tabUserGlobalParameterRights)
                SetChecked(this._pS_GetUserOtherParamterRights, true);
        }

        private void checkNoneToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.tctUserRights.SelectedTab == this.tabUserMenuRights)
                SetChecked(this._pS_GetUserMenuRights, false);
            else if (this.tctUserRights.SelectedTab == this.tabUserRoleRights)
                SetChecked(this._pS_GetUserRoleRights, false);
            else if (this.tctUserRights.SelectedTab == this.tabUserReportRights)
                SetChecked(this._pS_GetUserReportRights, false);
            else if (this.tctUserRights.SelectedTab == this.tabUserReminderRights)
                SetChecked(this._pS_GetUserReminderRights, false);
            else if (this.tctUserRights.SelectedTab == this.tabUserGlobalParameterRights)
                SetChecked(this._pS_GetUserOtherParamterRights, false);
        }

        private void checkRefreshToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.tctUserRights.SelectedTab == this.tabUserMenuRights)
                this.GetUserMenuRights(this._userId);
            else if (this.tctUserRights.SelectedTab == this.tabUserRoleRights)
                this.GetUserRoleRights(this._userId);
          
            else if (this.tctUserRights.SelectedTab == this.tabUserReportRights)
                this.GetUserReportRights(this._userId);
            else if (this.tctUserRights.SelectedTab == this.tabUserReminderRights)
                this.GetUserReminderRights(this._userId);
            else if (this.tctUserRights.SelectedTab == this.tabUserGlobalParameterRights)
                this.GetUserOtherParameterRights(this._userId);
        }

        private void SetChecked(DataTable table, bool value)
        {
            foreach (DataRow row in table.Rows)
            {
                row["Granted"] = value;
            }
        }



    }
}