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
    public partial class frmReminderSetup : Form
    {
        #region Fields
        private string _title = "Reminder Setup";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

       
        private int _remId = -1;
        private DataTable _tblReminders;
        private DataRow _reminder;

        private DataTable _tblRemindersList;
       
        #endregion

        #region Properties
        public bool IsNew
        {
            get { return this._isNew; }
            set
            {
                this._isNew = value;
                this.deleteToolStripButton.Enabled = !this._isNew;
                this.remIdTextBox.ReadOnly = !this._isNew;
            }
        }
        #endregion

        public frmReminderSetup()
        {
            InitializeComponent();
        }

        private void frmReminderSetup_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void frmReminderSetup_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BindControls()
        {
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
           
            try
            {
                
                
                DataObj.OpenConnection();
               
               
                this._tblRemindersList = DataObj.GetDataTable("tblReminders");
                
               clMain.SetDataSource(this.remIdLookUpEdit, this._tblRemindersList);
                
                this.remIdLookUpEdit.Properties.NullText = "-- Select " + this._title + " --";

                this._tblReminders = DataObj.GetDataTable("tblReminders");

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.remIdTextBox,
                    this.remMessageTextBox,
                    this.dataSourceTextBox,
                    this.isActiveCheckBox
                });

                clMain.BindControls(cntrsList, this._tblReminders);
                cntrsList.Clear();
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
                    DataObj.FillData(this._tblRemindersList, "SELECT * FROM tblReminders");
                }
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
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
                    this.remIdLookUpEdit.Focus();

                    if ( this._remId == -1)
                    {
                        AppMessageBox.ShowExclamation("Please select or add new " + this._title);
                        this.remIdLookUpEdit.Focus();
                        return;
                    }

                   

                    this._reminder = this._tblReminders.Rows[0];

                    if (this._reminder["DataSource"] != null)
                    {
                        this._reminder["DataSource"] = this._reminder["DataSource"].ToString().Replace("`", "''");
                    }

                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._reminder, true))
                        {
                            InitForm(true);
                        }
                    }
                    else
                    {
                        if (DataObj.Update(this._title, this._reminder, true))
                        {
                            InitForm(true);
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

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (this._remId == -1)
                {
                    AppMessageBox.ShowExclamation("Please select " + this._title + " to delete");
                    this.remIdLookUpEdit.Focus();
                    return;
                }
               

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete " + this._title + "?") == DialogResult.No)
                    return;

                this._reminder = this._tblReminders.Rows[0];

                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._reminder, true))
                {
                    InitForm(true);
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

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            
                this.remIdLookUpEdit.EditValue = this.GetNextReminderId();
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.remIdLookUpEdit.EditValue = null;
        }

        private void remIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.remIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.remIdLookUpEdit.EditValue))
            {
                this._remId = -1;
            }
            else
            {
                this._remId = Convert.ToInt32(this.remIdLookUpEdit.EditValue);
            }
            this.GetReminderEntry(this._remId);
        }

        private void remIdTextBox_Validated(object sender, EventArgs e)
        {
            if (!this.remIdTextBox.ReadOnly && this.remIdTextBox.Text != string.Empty)
            {
                this.remIdLookUpEdit.EditValue = this.remIdTextBox.Text;
                if (!this._isNew && this.remIdLookUpEdit.Text == string.Empty)
                {
                    AppMessageBox.ShowExclamation("You don't have the privilage to edit this " + this._title);
                }
            }
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._reminder = this._tblReminders.NewRow();
                clDatacon.SetToDatabaseDefaults(this._reminder, clMain.ConnString);
                if (this._remId != -1) this._reminder["RemId"] = this._remId;
                this._reminder["IsActive"] = true;
                this._tblReminders.Rows.Clear();
                this._tblReminders.Rows.Add(this._reminder);
                this._isLoadingEntry = false;
            }
        }

        private bool GetReminderEntry(int remId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
               
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                if (remId == -1)
                {
                    this.IsNew = false;
                    this._tblReminders.Rows.Clear();
                    this._isLoadingEntry = false;
                    return true;
                }
                if (!this.ReminderExists(remId))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    this.remIdTextBox.Focus();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblReminders, "SELECT * FROM tblReminders WHERE RemId=" + remId);
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

        private bool ReminderExists(int remId)
        {
            object result;
            string cmdText;
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (remId == -1)
                return false;

            try
            {
                
                DataObj.OpenConnection();
                cmdText = "SELECT RemId FROM tblReminders WHERE RemId=" + remId;
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

        private int GetNextReminderId()
        {
            object result;
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("SELECT max(RemId) As MaxRemId FROM tblReminders");
                if (result == null || Convert.IsDBNull(result))
                    return 1;
                else
                    return (Convert.ToInt32(result) + 1);
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return -1;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void checkToolStripButton_Click(object sender, EventArgs e)
        {
          

            string checkMsg = string.Empty;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                if (this.dataSourceTextBox.Text != string.Empty)
                {
                    checkMsg = DataObj.TestCommandText(this.dataSourceTextBox.Text);
                }
                if (checkMsg == string.Empty)
                    AppMessageBox.ShowInformation("No error found");
                else
                    AppMessageBox.ShowExclamation(checkMsg);
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

       

    }
}
