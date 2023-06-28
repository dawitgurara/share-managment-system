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
    public partial class frmAuditLog : Form
    {
        #region Fields
        private bool _isLoadingEntry = false;
        private string _tableName = null;
        private string _columnName = null;
        private int _dataObjId = -1;
        private DataTable _tblDataObjName;
        private DataTable _tblColumn;
        private DataTable _tblAction;
        private DataTable _tblKeyValue;

        private DataTable _tblAuditLog;
        private DataRow _auditLog;
        private DataTable _tblAuditLogList;

        #endregion

        public frmAuditLog()
        {
            InitializeComponent();
        }

        private void frmAuditLog_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void frmAuditLog_KeyDown(object sender, KeyEventArgs e)
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
                this._tblDataObjName = new DataTable("tblDataObjName");
                this._tblDataObjName.Columns.Add("ObjName", typeof(string));
                this._tblColumn = new DataTable("tblColumn");
                this._tblColumn.Columns.Add("ColumnName", typeof(string));
                this._tblAction = new DataTable("tblAction");
                this._tblAction.Columns.Add("ActionName", typeof(string));
                this._tblKeyValue = new DataTable("tblKeyValue");
                this._tblKeyValue.Columns.Add("KeyValue", typeof(string));
                clMain.SetDataSource(this.tblNameLookUpEdit, this._tblDataObjName);
                clMain.SetDataSource(this.fldChgLookUpEdit, this._tblColumn);
                clMain.SetDataSource(this.actionTakenLookUpEdit, this._tblAction);
                clMain.SetDataSource(this.keyFldLookUpEdit, this._tblKeyValue);

                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns.Add("FromDate", typeof(DateTime));
                this._tblAuditLog.Columns.Add("ToDate", typeof(DateTime));
                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.tblNameLookUpEdit,
                    this.fldChgLookUpEdit,
                    this.actionTakenLookUpEdit,
                    this.keyFldLookUpEdit,
                    this.fromDateDateTimePicker,
                    this.toDateDateTimePicker
                });

                clMain.BindControls(cntrsList, this._tblAuditLog);
                cntrsList.Clear();

                this._tblAuditLogList = new DataTable("tblAuditLog");
                clMain.SetDataSource(this.gctAuditLog, this._tblAuditLogList);
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
                    DataObj.FillData(this._tblDataObjName, "SELECT [Name] As DataObjName FROM sysObjects WHERE xtype='u' AND [Name] NOT LIKE 'dt%' ORDER BY [Name]");
                    object[] values = new object[] { new object[]{"New"},
                                                        new object[]{"Change"},
                                                        new object[]{"Delete"}
                                                    };
                    foreach (object[] value in values)
                        this._tblAction.Rows.Add(value);
                }
                this.GetNewEntry();
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

        private void showToolStripButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this._tableName))
            {
                AppMessageBox.ShowExclamation("Please select Table");
                return;
            }

            this.GetAuditLog();

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (this._tableName != null)
            {
               

                frmReportPreview RptPreviewForm = new frmReportPreview();
                RptPreviewForm.ReportConfig = new clReportConfig(clMain.App.ReportPath + "\\AuditLog.rpt",
                                                    "tblAuditLog");
                RptPreviewForm.ReportConfig.Criteria = this.GetCriteria();
                RptPreviewForm.ReportConfig.ReportDoc.DataDefinition.FormulaFields["CompName"].Text = clUtility.Qchar(clMain.Company.Name);
                RptPreviewForm.ReportConfig.ReportDoc.DataDefinition.FormulaFields["RepName"].Text = clUtility.Qchar("Audit Log");
                RptPreviewForm.ReportConfig.PreviewReport("Audit Log (Print)", false);
                RptPreviewForm.Text = "Audit Log (Print)";
                RptPreviewForm.Show();
               
                this.Close();
                
            }
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.tblNameLookUpEdit.EditValue = null;
        }

        private void tblNameLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.tblNameLookUpEdit.EditValue == null || Convert.IsDBNull(this.tblNameLookUpEdit.EditValue))
            {
                this._tableName = null;
                this._dataObjId = -1;
                this._tblColumn.Rows.Clear();
                this.GetNewEntry();
            }
            else
            {
                this._tableName = Convert.ToString(this.tblNameLookUpEdit.EditValue);
                this._dataObjId = this.GetDataObjId(this._tableName);
                this.GetColumns(this._dataObjId);
            }

        }

        private void fldChgLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.fldChgLookUpEdit.EditValue == null || Convert.IsDBNull(this.fldChgLookUpEdit.EditValue))
            {
                this._columnName = null;
                this._tblKeyValue.Rows.Clear();
            }
            else
            {
                this._columnName = Convert.ToString(this.fldChgLookUpEdit.EditValue);
                this.GetKeyValues(this._tableName, this._columnName);
            }
        }
       

        private void GetColumns(int dataObjId)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT syscolumns.[name] As ColumnName FROM sysColumns WHERE id=" + dataObjId + " ORDER BY ColId";
                DataObj.FillData(this._tblColumn, cmdText);
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

        private void GetKeyValues(string tableName, string columnName)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "select Distinct KeyFld As KeyValue from tblAuditLog where TblName='" + tableName + "' and FldChg='" + columnName + "'";
                DataObj.FillData(this._tblKeyValue, cmdText);
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

        private void GetAuditLog()
        {
            string criteria;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                criteria = this.GetCriteria();
                cmdText = "SELECT * FROM tblAuditLog WHERE " + criteria + " ORDER BY LogId";
                DataObj.FillData(this._tblAuditLogList, cmdText);
                this.gridAuditLog.BestFitColumns();
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

        private string GetCriteria()
        {
            string result;

            result = "TblName='" + this._tableName + "'";

            if (this.fldChgLookUpEdit.EditValue != null && !Convert.IsDBNull(this.fldChgLookUpEdit.EditValue))
                result = result + " AND FldChg='" + this.fldChgLookUpEdit.EditValue + "'";

            if (this.actionTakenLookUpEdit.EditValue != null && !Convert.IsDBNull(this.actionTakenLookUpEdit.EditValue))
                result = result + " AND ActionTaken='" + this.actionTakenLookUpEdit.EditValue + "'";

            if (this.fromDateDateTimePicker.Value != null && !Convert.IsDBNull(this.fromDateDateTimePicker.Value))
                result = result + " AND LogDt>='" + this.fromDateDateTimePicker.Value.ToShortDateString() + "'";

            if (this.toDateDateTimePicker.Value != null && !Convert.IsDBNull(this.toDateDateTimePicker.Value))
                result = result + " AND LogDt<='" + this.toDateDateTimePicker.Value.ToShortDateString() + "'";

            if (this.keyFldLookUpEdit.EditValue != null && !Convert.IsDBNull(this.keyFldLookUpEdit.EditValue))
                result = result + " AND KeyFld='" + this.keyFldLookUpEdit.EditValue + "'";

            return result;

        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this._auditLog = this._tblAuditLog.NewRow();
                //this._auditLog["FromDate"] = HillUtility.GetServerDate();
                //this._auditLog["ToDate"] = HillUtility.GetServerDate();
                this._tblAuditLog.Rows.Clear();
                this._tblAuditLog.Rows.Add(this._auditLog);
                this._tblAuditLogList.Rows.Clear();
                this._isLoadingEntry = false;
            }
        }

        private int GetDataObjId(string dataObjName)
        {
            object result;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                result = DataObj.GetValue("sysobjects", "id", "name='" + dataObjName + "'");
                if (result == null || Convert.IsDBNull(result))
                    return -1;
                else
                    return Convert.ToInt32(result);
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

        private bool ValidateData()
        {
            if (this._tableName == null)
            {
                AppMessageBox.ShowExclamation("Please select Table");
                return false;
            }
            return true;
        }

       




    }
}

