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
    public partial class frmFiscalYears : Form
    {
        #region Fields
        private string _title = "Fiscal Year";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

        private string _fiscalYearId = "-1";
        private DataTable _tblFiscalYears;
        private DataRow _fiscalYear;

        private DataTable _tblFiscalYearsList;

        private DataTable _tblFiscalYearsPrev;
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
                this.fiscalYearTextBox.ReadOnly = !this._isNew;
            }
        }
        #endregion

        public frmFiscalYears()
        {
            InitializeComponent();
        }

        private void frmFiscalYears_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void frmFiscalYears_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                this._tblFiscalYearsList = DataObj.GetDataTable("tblFiscalYears");
                clMain.SetDataSource(this.fiscalYearLookUpEdit, this._tblFiscalYearsList);
                this.fiscalYearLookUpEdit.Properties.NullText = "-- Select " + this._title + " --";

                this._tblFiscalYears = DataObj.GetDataTable("tblFiscalYears");
                this._tblFiscalYearsPrev = DataObj.GetDataTable("tblFiscalYears");
                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.fiscalYearTextBox,
                    this.startDateDateTimePicker,
                    this.startDateEthTextBox,
                    this.endDateDateTimePicker,
                    this.endDateEthTextBox,
                    this.closedCheckBox
                });

                clMain.BindControls(cntrsList, this._tblFiscalYears);
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

                }
                if (this.chkYearAll.Checked)
                    DataObj.FillData(this._tblFiscalYearsList, "SELECT * FROM tblFiscalYears");
                else
                    DataObj.FillData(this._tblFiscalYearsList, "SELECT * FROM tblFiscalYears WHERE Closed=0");
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
                    this.fiscalYearLookUpEdit.Focus();

                    if (this._fiscalYearId == "")
                    {
                        AppMessageBox.ShowExclamation("Please select or add new " + this._title);
                        this.fiscalYearLookUpEdit.Focus();
                        return;
                    }

                    this._fiscalYear = this._tblFiscalYears.Rows[0];

                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._fiscalYear, true))
                        {
                            InitForm(false);
                        }
                    }
                    else
                    {
                        if (DataObj.Update(this._title, this._fiscalYear, false))
                        {
                            if (InsertAuditlog(this._fiscalYear))
                            {
                                DataObj.CommitTransaction();
                                AppMessageBox.ShowInformation("Fiscal year is updated successfully");
                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Fiscal year updating is failed");
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

        private bool InsertAuditlog(DataRow fiscalYear)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this._tblFiscalYearsPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();

                    if (this._tblFiscalYearsPrev.Rows[0]["StartDate"].ToString().Trim() != fiscalYear["StartDate"].ToString().ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblFiscalYears";
                        this._AuditLog["KeyFld"] = "FiscalYear";
                        this._AuditLog["KeyFldValue"] = this._tblFiscalYearsPrev.Rows[0]["FiscalYear"];
                        this._AuditLog["ActionTaken"] = "Fiscal Year Details Changed";
                        this._AuditLog["FldChged"] = "StartDate";
                        this._AuditLog["OldValue"] = this._tblFiscalYearsPrev.Rows[0]["StartDate"];
                        this._AuditLog["NewValue"] = fiscalYear["StartDate"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && this._tblFiscalYearsPrev.Rows[0]["EndDate"].ToString().Trim() != fiscalYear["EndDate"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblFiscalYears";
                        this._AuditLog["KeyFld"] = "FiscalYear";
                        this._AuditLog["KeyFldValue"] = this._tblFiscalYearsPrev.Rows[0]["FiscalYear"];
                        this._AuditLog["ActionTaken"] = "Fiscal Year Details Changed";
                        this._AuditLog["FldChged"] = "EndDate";
                        this._AuditLog["OldValue"] = this._tblFiscalYearsPrev.Rows[0]["EndDate"];
                        this._AuditLog["NewValue"] = fiscalYear["EndDate"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }

                    if (success && this._tblFiscalYearsPrev.Rows[0]["Closed"].ToString().Trim() != fiscalYear["Closed"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblFiscalYears";
                        this._AuditLog["KeyFld"] = "FiscalYear";
                        this._AuditLog["KeyFldValue"] = this._tblFiscalYearsPrev.Rows[0]["FiscalYear"];
                        this._AuditLog["ActionTaken"] = "Fiscal Year Details Changed and year end transaction may occured if any";
                        this._AuditLog["FldChged"] = "Closed";
                        this._AuditLog["OldValue"] = this._tblFiscalYearsPrev.Rows[0]["Closed"];
                        this._AuditLog["NewValue"] = fiscalYear["Closed"];
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
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (this._fiscalYearId == "")
                {
                    AppMessageBox.ShowExclamation("Please select " + this._title + " to delete");
                    this.fiscalYearLookUpEdit.Focus();
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete " + this._title + "?") == DialogResult.No)
                    return;

                this._fiscalYear = this._tblFiscalYears.Rows[0];

                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._fiscalYear, true))
                {
                    InitForm(false);
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

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            this.fiscalYearLookUpEdit.EditValue = "0";
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.fiscalYearLookUpEdit.EditValue = null;
        }

        private void fiscalYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.fiscalYearLookUpEdit.EditValue == null || Convert.IsDBNull(this.fiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYearId = "-1";
            }
            else
            {
                this._fiscalYearId = Convert.ToString(this.fiscalYearLookUpEdit.EditValue);
            }
            this.GetFiscalYearEntry(this._fiscalYearId);
        }

        private void fiscalYearTextBox_Validated(object sender, EventArgs e)
        {
            if (!this.fiscalYearTextBox.ReadOnly)
            {
                this.fiscalYearLookUpEdit.EditValue = Convert.ToInt32(this.fiscalYearTextBox.Text);
                if (!this._isNew && this.fiscalYearLookUpEdit.Text == string.Empty)
                {
                    AppMessageBox.ShowExclamation("You don't have the privilage to edit this " + this._title);
                }
            }
        }

        private void chkYearAll_CheckedChanged(object sender, EventArgs e)
        {
            this.InitForm(false);
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._fiscalYear = this._tblFiscalYears.NewRow();
                clDatacon.SetToDatabaseDefaults(this._fiscalYear, clMain.ConnString);
               if (this._fiscalYearId != "0" && this._fiscalYearId != "-1") this._fiscalYear["FiscalYear"] = this._fiscalYearId;
                this._fiscalYear["Closed"] = false;
                this._tblFiscalYears.Rows.Clear();
                this._tblFiscalYears.Rows.Add(this._fiscalYear);
                this._isLoadingEntry = false;
            }
        }

        private bool GetFiscalYearEntry(string fiscalYear)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                if (fiscalYear == "-1")
                {
                    this.IsNew = false;
                    this._tblFiscalYears.Rows.Clear();
                    this._isLoadingEntry = false;
                    return true;
                }
                if (!this.FiscalYearExists(fiscalYear))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    this.fiscalYearTextBox.Focus();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblFiscalYears, "SELECT * FROM tblFiscalYears WHERE FiscalYear='" + fiscalYear+"'");
                    DataObj.FillData(this._tblFiscalYearsPrev, "SELECT * FROM tblFiscalYears WHERE FiscalYear='" + fiscalYear + "'");
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

        private bool FiscalYearExists(string fiscalYear)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString); 

            if (fiscalYear == "-1")
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT FiscalYear FROM tblFiscalYears WHERE FiscalYear='" + fiscalYear+"'";
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

        private void startDateDateTimePicker_Validated(object sender, EventArgs e)
        {
           this.startDateEthTextBox.Text= clUtility.GetEthDate(this.startDateDateTimePicker.Value);
        }

        private void endDateDateTimePicker_Validated(object sender, EventArgs e)
        {
            this.endDateEthTextBox.Text = clUtility.GetEthDate(this.endDateDateTimePicker.Value);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            frmReportPreview RptPreviewForm = new frmReportPreview();
            RptPreviewForm.ReportConfig = new clReportConfig(clMain.App.ReportPath + "\\FiscalYears.rpt",
                                                "tblFiscalYears");
            RptPreviewForm.ReportConfig.ReportDoc.DataDefinition.FormulaFields["CompName"].Text = clUtility.Qchar(clMain.Company.Name);
            RptPreviewForm.ReportConfig.PreviewReport("Fiscal Years (Print)", false);
            RptPreviewForm.Text = "Fiscal Years (Print)";
            RptPreviewForm.Show();
            
        }

    }
}
