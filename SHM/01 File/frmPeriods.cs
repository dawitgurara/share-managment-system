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
    public partial class frmPeriods : Form
    {
        #region Fields
        private string _title = "Period";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

        private string _fiscalYear = "0";
        private int _period = 0;
        private DataTable _tblYearPeriod;
        private DataRow _yearPeriod;

        private DataTable _veiwYearPeriod;
        private DataTable _FiscalYears;
        private DataTable _Periods;

        private DataTable _tblYearPeriodPrev;
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
            }
        }
        #endregion

        public frmPeriods()
        {
            InitializeComponent();
        }

        private void frmPeriods_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void frmPeriods_KeyDown(object sender, KeyEventArgs e)
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
                this._FiscalYears = DataObj.GetDataTable("tblFiscalYears");
                this._Periods = DataObj.GetDataTable("tblPeriods");
                clMain.SetDataSource(this.fiscalYearLookUpEdit, this._FiscalYears);
                clMain.SetDataSource(this.periodLookUpEdit, this._Periods);
               

                this._tblYearPeriod = DataObj.GetDataTable("tblYearPeriod");
                this._tblYearPeriodPrev = DataObj.GetDataTable("tblFiscalYears");
                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;


                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.fiscalYearLookUpEdit,
                    this.periodLookUpEdit,
                    this.calendarYearTextBox,
                    this.startDateDateTimePicker,
                    this.startDateEthTextBox,
                    this.endDateDateTimePicker,
                    this.endDateEthTextBox,
                });

                clMain.BindControls(cntrsList, this._tblYearPeriod);
                cntrsList.Clear();

                this._veiwYearPeriod = DataObj.GetDataTable("ViewYearPeriod");
                clMain.SetDataSource(this.gctPeriods, this._veiwYearPeriod);

               
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
                    if (this.chkYearAll.Checked)
                        DataObj.FillData(this._FiscalYears, "SELECT * FROM tblFiscalYears ORDER BY FiscalYear");
                    else
                        DataObj.FillData(this._FiscalYears, "SELECT * FROM tblFiscalYears WHERE Closed=0 ORDER BY FiscalYear");
                    DataObj.FillData(this._Periods, "SELECT * FROM tblPeriods ORDER BY PeriodId");
                }
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshToolStripButton_Click(this, new EventArgs());
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
                    GetPeiodofaYear(this._fiscalYear, this._period);
                    this._yearPeriod = this._tblYearPeriod.Rows[0];
                   

                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._yearPeriod, true))
                        {
                            InitForm(false);
                        }
                    }
                    else
                    {
                        DataObj.BeginTransaction();
                        if (DataObj.Update(this._title, this._yearPeriod, false))
                        {
                            if (InsertAuditlog(this._yearPeriod))
                            {
                                DataObj.CommitTransaction();
                                AppMessageBox.ShowInformation("Period is updated successfully");
                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Period updating is failed");
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
        private bool InsertAuditlog(DataRow yearPeriod)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this._tblYearPeriodPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();

                    if (this._tblYearPeriodPrev.Rows[0]["CalendarYear"].ToString().Trim() != yearPeriod["CalendarYear"].ToString().ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblYearPeriod";
                        this._AuditLog["KeyFld"] = "YearPeriod";
                        this._AuditLog["KeyFldValue"] = this._tblYearPeriodPrev.Rows[0]["YearPeriod"];
                        this._AuditLog["ActionTaken"] = "Period Details Changed";
                        this._AuditLog["FldChged"] = "CalendarYear";
                        this._AuditLog["OldValue"] = this._tblYearPeriodPrev.Rows[0]["CalendarYear"];
                        this._AuditLog["NewValue"] = yearPeriod["CalendarYear"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && this._tblYearPeriodPrev.Rows[0]["StartDate"].ToString().Trim() != yearPeriod["StartDate"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblYearPeriod";
                        this._AuditLog["KeyFld"] = "YearPeriod";
                        this._AuditLog["KeyFldValue"] = this._tblYearPeriodPrev.Rows[0]["YearPeriod"];
                        this._AuditLog["ActionTaken"] = "Period Details Changed";
                        this._AuditLog["FldChged"] = "StartDate";
                        this._AuditLog["OldValue"] = this._tblYearPeriodPrev.Rows[0]["StartDate"];
                        this._AuditLog["NewValue"] = yearPeriod["StartDate"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }

                    if (success && this._tblYearPeriodPrev.Rows[0]["EndDate"].ToString().Trim() != yearPeriod["EndDate"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblYearPeriod";
                        this._AuditLog["KeyFld"] = "YearPeriod";
                        this._AuditLog["KeyFldValue"] = this._tblYearPeriodPrev.Rows[0]["YearPeriod"];
                        this._AuditLog["ActionTaken"] = "Period Details Changed";
                        this._AuditLog["FldChged"] = "EndDate";
                        this._AuditLog["OldValue"] = this._tblYearPeriodPrev.Rows[0]["EndDate"];
                        this._AuditLog["NewValue"] = yearPeriod["EndDate"];
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
                if (this._fiscalYear == "0" || this._period == 0)
                {
                    AppMessageBox.ShowExclamation("Please select " + this._title + " to delete");
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete " + this._title + "?") == DialogResult.No)
                    return;

                this._yearPeriod = this._tblYearPeriod.Rows[0];

                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._yearPeriod, true))
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

        //private void printToolStripButton_Click(object sender, EventArgs e)
        //{
        //    frmReportPreview RptPreviewForm = new frmReportPreview();
        //    RptPreviewForm.ReportConfig = new HillReportConfig(AppMain.HillApp.ReportPath + "\\Periods.rpt",
        //                                        "ViewYearPeriod", AppMain.HillMasterConnString);
        //    RptPreviewForm.ReportConfig.ReportDoc.DataDefinition.FormulaFields["CompName"].Text = HillUtility.Qchar(AppMain.Company.Name);
        //    RptPreviewForm.ReportConfig.PreviewReport("Periods (Print)", false);
        //    RptPreviewForm.Text = "Periods (Print)";
        //    AppMain.ShowControl(RptPreviewForm, true);
        //}

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            //this._fiscalYear = 0;
            this._period = 0;
            this.GetYearPeriodEntry(this._fiscalYear, this._period);
        }

        private void fiscalYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.fiscalYearLookUpEdit.EditValue == null || Convert.IsDBNull(this.fiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = "0";
                this._veiwYearPeriod.Rows.Clear();
            }
            else
            {
                this._fiscalYear = Convert.ToString(this.fiscalYearLookUpEdit.EditValue);
                this.GetYearPeriods(this._fiscalYear);
            }
            this.GetYearPeriodEntry(this._fiscalYear, this._period);
        }

        private void periodLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.periodLookUpEdit.EditValue == null || Convert.IsDBNull(this.periodLookUpEdit.EditValue))
            {
                this._period = 0;
            }
            else
            {
                this._period = Convert.ToInt32(this.periodLookUpEdit.EditValue);
            }
            this.GetYearPeriodEntry(this._fiscalYear, this._period);
        }

        private void gridPeriods_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridPeriods.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridPeriods.GetDataRow(focused);
                this._fiscalYear = Convert.ToString(curRow["FiscalYear"]);
                this._period = Convert.ToInt32(curRow["Period"]);
                this.GetYearPeriodEntry(this._fiscalYear, this._period);
                this.gridPeriods.FocusedRowHandle = focused;
            }
        }

        private void chkYearAll_CheckedChanged(object sender, EventArgs e)
        {
            this.InitForm(true);
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._yearPeriod = this._tblYearPeriod.NewRow();
                clDatacon.SetToDatabaseDefaults(this._yearPeriod, clMain.ConnString);
                if (this._fiscalYear != "0") this._yearPeriod["FiscalYear"] = this._fiscalYear;
                if (this._period != 0) this._yearPeriod["Period"] = this._period;
                this._yearPeriod["Closed"] = false;
                this._tblYearPeriod.Rows.Clear();
                this._tblYearPeriod.Rows.Add(this._yearPeriod);
                this._isLoadingEntry = false;
            }
        }

        private bool GetYearPeriodEntry(string fiscalYear, int period)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.YearPeriodExists(fiscalYear, period))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblYearPeriod, "SELECT * FROM tblYearPeriod WHERE FiscalYear='" + fiscalYear + "' AND Period=" + period);
                    DataObj.FillData(this._tblYearPeriodPrev, "SELECT * FROM tblYearPeriod WHERE FiscalYear='" + fiscalYear + "' AND Period=" + period);
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

        private bool YearPeriodExists(string fiscalYear, int period)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (fiscalYear == "0" || period == 0)
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT YearPeriod FROM tblYearPeriod WHERE FiscalYear='" + fiscalYear + "' AND Period=" + period;
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

        private void GetYearPeriods(string fiscalYear)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                DataObj.FillData(this._veiwYearPeriod, "SELECT * FROM ViewYearPeriod WHERE FiscalYear='" + fiscalYear + "' ORDER BY Period");
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

        private void GetPeiodofaYear(string budgetYear, int period)
        {
            int yearpeiod=0;
            int index = budgetYear.IndexOf('/');
            int startYear = Convert.ToInt32(budgetYear.Substring(0, budgetYear.IndexOf('/')));
            int endYear = Convert.ToInt32(budgetYear.Substring(budgetYear.IndexOf('/')+1));
            if (period > 6)
            {
                yearpeiod = (startYear * 100) + period;
                this._yearPeriod["YearPeriod"] = (startYear * 100) + period;
            }
            else
            {
                yearpeiod = (startYear * 100) + period;
                this._yearPeriod["YearPeriod"] = (endYear * 100) + period;
            }
            
        }

        private void startDateDateTimePicker_Validated(object sender, EventArgs e)
        {
            this.startDateEthTextBox.Text = clUtility.GetEthDate(this.startDateDateTimePicker.Value);
        }

        private void endDateDateTimePicker_Validated(object sender, EventArgs e)
        {
            this.endDateEthTextBox.Text = clUtility.GetEthDate(this.endDateDateTimePicker.Value);
        }

    }
}
