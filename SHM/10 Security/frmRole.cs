using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHM
{
    public partial class frmRole : Form
    {
        #region Fields
        private string _title = "Role";
        private int _RoleId = -1;
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

        
        private DataTable _tblRole;
        private DataRow _Role;

        private DataTable _tblRoleList;
       
        #endregion

        #region Properties
        public bool IsNew
        {
            get { return this._isNew; }
            set
            {
                this._isNew = value;
                
            }
        }
        #endregion

        #region Methods
        public frmRole()
        {
            InitializeComponent();
        }

        private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                DataObj.OpenConnection();

                this._tblRoleList = DataObj.GetDataTable("tblRoles");


                this._tblRole = DataObj.GetDataTable("tblRoles");
                this._tblRole.Columns["CrtDt"].ReadOnly = true;
                this._tblRole.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.roleNameTextBox,
                    
                    
                });

                clMain.BindControls(cntrsList, this._tblRole);
                cntrsList.Clear();

                //this._tblTemplateList = DataObj.GetDataTable("tblTemplate");
                clMain.SetDataSource(this.gctRoleTypes, this._tblRoleList);
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

        private void frmRoles_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm();           
        }

        private void frmRoles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void InitForm()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                DataObj.FillData(this._tblRoleList, "SELECT * FROM tblRoles");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshToolStripButton_Click(null, null);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                if (this.Validate())
                {
                    this.roleNameTextBox.Focus();

                    if (this._RoleId == -1)
                    {
                        AppMessageBox.ShowExclamation("Please enter " + this._title);
                        this.roleNameTextBox.Focus();
                        return;
                    }

                    this._Role = this._tblRole.Rows[0];
                    this._Role["LmBy"] = clMain.User.UserName;
                    this._Role["LmDt"] = clUtility.GetCurrentDate();
                    this._Role["LmWs"] = clUtility.GetCurrentWorkstation();

                    DataObj.OpenConnection();

                    if (this._isNew)
                    {
                        
                        if (DataObj.Insert(this._title, this._Role, true))
                        {
                            InitForm();
                        }
                    }
                    else
                    {
                        if (DataObj.Update(this._title, this._Role, true))
                        {
                            InitForm();
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
        #endregion

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            this.roleNameTextBox.Text = string.Empty;
            this._RoleId = 0;
            this.GetRoleEntry(_RoleId);
        }


        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.roleNameTextBox.Text = string.Empty;
            this._RoleId = -1;
            this.GetRoleEntry(_RoleId);
           
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._Role = this._tblRole.NewRow();
                clDatacon.SetToDatabaseDefaults(this._Role, clMain.ConnString);
                if (this._RoleId != -1) this._Role["RoleId"] = this._RoleId;
                this._Role["CrtBy"] = clMain.User.UserName;
                this._tblRole.Rows.Clear();
                this._tblRole.Rows.Add(this._Role);
                this._isLoadingEntry = false;
            }
        }

        private bool GetRoleEntry(int RoleId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                if (RoleId == -1)
                {
                    this.IsNew = false;
                    this._tblRole.Rows.Clear();
                    this._isLoadingEntry = false;
                    return true;
                }
                if (!this.RoleExists(RoleId))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblRole, "SELECT * FROM tblRoles WHERE RoleId=" + RoleId);
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

        private bool RoleExists(int roleId)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (roleId == -1)
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT RoleId FROM tblRoles WHERE RoleId=" + roleId;
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


        private void gridRoleTypes_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridRoleTypes.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridRoleTypes.GetDataRow(focused);
                this._RoleId = Convert.ToInt32(curRow["RoleId"]);
                this.GetRoleEntry(this._RoleId);
                this.gridRoleTypes.FocusedRowHandle = focused;
            }
        }

    }
}
