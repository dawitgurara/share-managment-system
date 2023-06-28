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
    public partial class frmDividendParameters : Form
    {
        #region Fields
        private string _title = "Dividend Parameter";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

        private string _fiscalYear = "0";

        private DataTable _tblDividendParameters;
        private DataRow _DividendParameters;

        private DataTable _tblDividendParametersList;
        private DataTable _tblFiscalYear;

        private DataTable _tblDividendParametersPrev;
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

        public frmDividendParameters()
        {

            InitializeComponent();
        }

        private void frmDividendParameters_Load(object sender, EventArgs e)
        {

            BindControls();
            InitForm(true);
        }

        private void frmDividendParameters_KeyDown(object sender, KeyEventArgs e)
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


                this._tblFiscalYear = DataObj.GetDataTable("ViewFiscalYears");


                clMain.SetDataSource(this.FiscalYearLookUpEdit, this._tblFiscalYear);

                this._tblDividendParameters = DataObj.GetDataTable("tblDividendParameters");
                this._tblDividendParameters.Columns["CrtDt"].ReadOnly = true;
                this._tblDividendParameters.Columns["CrtWs"].ReadOnly = true;

                this._tblDividendParametersPrev = DataObj.GetDataTable("tblGeneralParameters");
                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    
                    this.FiscalYearLookUpEdit,
                    this.TotalAmntForDividendTextBox,
                    
                    
                    
                });

                clMain.BindControls(cntrsList, this._tblDividendParameters);
                cntrsList.Clear();

                this._tblDividendParametersList = DataObj.GetDataTable("tblDividendParameters");
                clMain.SetDataSource(this.gctDividendParam, this._tblDividendParametersList);
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
                        DataObj.FillData(this._tblFiscalYear, "select* from ViewFiscalYears order by FiscalYear desc");
                    else
                        
                        DataObj.FillData(this._tblFiscalYear, "select top 2 * from ViewFiscalYears order by FiscalYear desc");
                }
                else
                    DataObj.FillData(this._tblDividendParametersList, "SELECT * FROM tblDividendParameters order by FiscalYear desc");
               


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

                    this.FiscalYearLookUpEdit.Focus();
                    this._DividendParameters = this._tblDividendParameters.Rows[0];

                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._DividendParameters, true))
                        {
                            InitForm(false);
                        }
                    }
                    else
                    {

                        if (DataObj.Update(this._title, this._DividendParameters, false))
                        {
                            if (InsertAuditlog(this._DividendParameters))
                            {
                                DataObj.CommitTransaction();
                                AppMessageBox.ShowInformation("Dividend parameter detail is updated successfully");
                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Dividend parameter detail updating is failed");
                            }
                            InitForm(false);
                        }
                    }

                }
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                this.refreshToolStripButton_Click(this, new EventArgs());
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private bool InsertAuditlog(DataRow _DividendParameters)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this._tblDividendParametersPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();

                    if (this._tblDividendParametersPrev.Rows[0]["TotalAmntForDividend"].ToString().Trim() != _DividendParameters["TotalAmntForDividend"].ToString().ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblDividendParameters";
                        this._AuditLog["KeyFld"] = "FiscalYear";
                        this._AuditLog["KeyFldValue"] = this._tblDividendParametersPrev.Rows[0]["FiscalYear"];
                        this._AuditLog["ActionTaken"] = "Dividend Parameter value Changed";
                        this._AuditLog["FldChged"] = "TotalAmntForDividend";
                        this._AuditLog["OldValue"] = this._tblDividendParametersPrev.Rows[0]["TotalAmntForDividend"];
                        this._AuditLog["NewValue"] = _DividendParameters["TotalAmntForDividend"];
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

                if (this._fiscalYear == "0")
                {
                    AppMessageBox.ShowExclamation("Please double click from the list to delete " + this._title);
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete " + this._title + "?") == DialogResult.No)
                    return;

                this._DividendParameters = this._tblDividendParameters.Rows[0];

                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._DividendParameters, true))
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

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {


            this._fiscalYear = "0";

            this.GetDividenedParamEntry(this._fiscalYear);
            this.FiscalYearLookUpEdit.Focus();

        }

        private void gridDividendParam_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridDividendParam.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridDividendParam.GetDataRow(focused);

                this._fiscalYear = Convert.ToString(curRow["FiscalYear"]);
                this.GetDividenedParamEntry(this._fiscalYear);
                this.gridDividendParam.FocusedRowHandle = focused;
            }
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._DividendParameters = this._tblDividendParameters.NewRow();
                clDatacon.SetToDatabaseDefaults(this._DividendParameters, clMain.ConnString);

                if (this._fiscalYear != "0") this._DividendParameters["FiscalYear"] = this._fiscalYear;
                this._DividendParameters["CrtBy"] = clMain.User.UserName;

                this._tblDividendParameters.Rows.Clear();
                this._tblDividendParameters.Rows.Add(this._DividendParameters);
                this._isLoadingEntry = false;
            }
        }

        private bool DividendParamExists(string fiscalyear)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (fiscalyear == "0")
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT FiscalYear FROM tblDividendParameters WHERE FiscalYear='" + fiscalyear + "'";
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
         
        private void GetDividenedParamByFiscalYear(string fiscalyear)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                
                try
                {
                    
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblDividendParametersList, "SELECT * FROM tblDividendParameters where FiscalYear='"+fiscalyear+"'");


                   
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
            
        private bool GetDividenedParamEntry(string fiscalyear)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.DividendParamExists(fiscalyear))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblDividendParameters, "SELECT * FROM tblDividendParameters WHERE FiscalYear='" + fiscalyear + "'");
                    DataObj.FillData(this._tblDividendParametersPrev, "SELECT * FROM tblDividendParameters WHERE FiscalYear='" + fiscalyear + "'");

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

        private void budgetYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.FiscalYearLookUpEdit.EditValue != null && !Convert.IsDBNull(this.FiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = Convert.ToString(this.FiscalYearLookUpEdit.EditValue);
                GetDividenedParamByFiscalYear(this._fiscalYear);
                this.GetDividenedParamEntry(this._fiscalYear);
            }
        }

        private void chkYearAll_CheckedChanged(object sender, EventArgs e)
        {
            this.InitForm(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clUtility.UpdateRegDateEth())
            {
                AppMessageBox.ShowInformation("Done Successfully !");
            }
            else
            {
                AppMessageBox.ShowExclamation("Error In Updating!");
            }
        }

    }
}
