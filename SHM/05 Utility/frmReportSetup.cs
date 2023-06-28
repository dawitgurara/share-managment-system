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
    public partial class frmReportSetup : Form
    {
        #region Fields
        private string _title = "Report Setup";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

       
        private int _repId = -1;
        private DataTable _tblReports;
        private DataRow _report;

        private DataTable _tblReportsList;
        private DataTable _tblDataObjType;
        private DataTable _tblDataObjName;
        private DataTable _tblReportGroup;

        #region Parameters
        private string _titleParam = "Report Parameter";
        private bool _isNewParam = false;
        private bool _isLoadingEntryParam = false;

        private int _paramId = -1;
        private int _dataObjId = -1;
        private DataTable _tblReportParameter;
        private DataRow _reportParameter;

        private DataTable _tblReportParameterList;
        private DataTable _tblColumn;
        private DataTable _tblDataType;
        private DataTable _tblControlType;
        private DataTable _tblComparision;
        private DataTable _tblConjunction;
        private DataTable _tblIncInHd;
        private DataTable _tblDataSourceType;
        #endregion

        #region Subreports
        private string _titleSubrep = "Subreport";
        private bool _isNewSubrep = false;
        private bool _isLoadingEntrySubrep = false;

        private string _subRepId = null;
        private DataTable _tblSubReports;
        private DataRow _subReport;

        private DataTable _tblSubReportsList;
        private DataTable _tblDataObjNameSubrep;
        private DataTable _tblDataObjNameAll;
        #endregion

        #endregion

        #region Properties
        public bool IsNew
        {
            get { return this._isNew; }
            set
            {
                this._isNew = value;
                this.deleteToolStripButton.Enabled = !this._isNew;
                this.repIdTextBox.ReadOnly = !this._isNew;
            }
        }
        public bool IsNewParam
        {
            get { return this._isNewParam; }
            set
            {
                this._isNewParam = value;
                this.removeParameterToolStripButton.Enabled = !this._isNewParam;
                this.paramIdTextBox.ReadOnly = !this._isNewParam;
            }
        }
        public bool IsNewSubrep
        {
            get { return this._isNewSubrep; }
            set
            {
                this._isNewSubrep = value;
                this.removeSubrepToolStripButton.Enabled = !this._isNewSubrep;
                this.subRepIdTextBox.ReadOnly = !this._isNewSubrep;
            }
        }
        #endregion

        public frmReportSetup()
        {
            InitializeComponent();
        }

        private void frmReportSetup_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void frmReportSetup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BindControls()
        {
            
            clDatacon  DataObj =  new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();

               
                this._tblReportsList = DataObj.GetDataTable("tblReports");
                this._tblDataObjType = new DataTable("tblDataObjType");
                this._tblDataObjType.Columns.Add("TypeId", typeof(string));
                this._tblDataObjType.Columns.Add("TypeName", typeof(string));
                this._tblDataObjName = new DataTable("tblDataObjName");
                this._tblDataObjName.Columns.Add("ObjName", typeof(string));
                this._tblReportGroup = DataObj.GetDataTable("tblReportGroup");
               
                clMain.SetDataSource(this.repIdLookUpEdit, this._tblReportsList);
                clMain.SetDataSource(this.dataObjTypeLookUpEdit, this._tblDataObjType);
                clMain.SetDataSource(this.dataObjNameLookUpEdit, this._tblDataObjName);
                clMain.SetDataSource(this.reportGroupLookUpEdit, this._tblReportGroup);
                
                this.repIdLookUpEdit.Properties.NullText = "-- Select " + this._title + " --";

                this._tblReports = DataObj.GetDataTable("tblReports");
                this._tblReports.Columns["ReportSrcBy"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.repIdTextBox,
                    this.repNameTextBox,
                    this.RepNameAmharicTextBox,
                    this.reportFileNameTextBox,
                    this.dataObjTypeLookUpEdit,
                    this.dataObjNameLookUpEdit,
                    this.criteriaTextBox,
                    this.sortByTextBox,
                    this.reportHeadTextBox,
                    this.reportGroupLookUpEdit,
                    this.isByUserCheckBox,
                    this.usrNameFldTextBox
                });

                clMain.BindControls(cntrsList, this._tblReports);
                cntrsList.Clear();

                #region Parameters
                this._tblColumn = new DataTable("tblColumn");
                this._tblColumn.Columns.Add("ColumnName", typeof(string));
                this._tblDataType = new DataTable("tblDataType");
                this._tblDataType.Columns.Add("DataTypeName", typeof(string));
                this._tblControlType = new DataTable("tblControlType");
                this._tblControlType.Columns.Add("ControlTypeFullName", typeof(string));
                this._tblControlType.Columns.Add("ControlTypeName", typeof(string));
                this._tblComparision = new DataTable("tblComparision");
                this._tblComparision.Columns.Add("ComparisionName", typeof(string));
                this._tblConjunction = new DataTable("tblConjunction");
                this._tblConjunction.Columns.Add("ConjunctionName", typeof(string));
                this._tblIncInHd = new DataTable("tblIncInHd");
                this._tblIncInHd.Columns.Add("IncInHdId", typeof(bool));
                this._tblIncInHd.Columns.Add("IncInHdName", typeof(string));
                this._tblDataSourceType = new DataTable("tblDataSourceType");
                this._tblDataSourceType.Columns.Add("DataSourceTypeName", typeof(string));
                clMain.SetDataSource(this.fieldNameLookUpEdit, this._tblColumn);
                clMain.SetDataSource(this.dataTypeLookUpEdit, this._tblDataType);
                clMain.SetDataSource(this.controlTypeLookUpEdit, this._tblControlType);
                clMain.SetDataSource(this.comparisionLookUpEdit, this._tblComparision);
                clMain.SetDataSource(this.conjunctionLookUpEdit, this._tblConjunction);
                clMain.SetDataSource(this.incInHdLookUpEdit, this._tblIncInHd);
                clMain.SetDataSource(this.dataSourceTypeLookUpEdit, this._tblDataSourceType);
                clMain.SetRepositoryDataSource(this.rluFieldName, this._tblColumn);
                clMain.SetRepositoryDataSource(this.rluDataType, this._tblDataType);
                clMain.SetRepositoryDataSource(this.rluControlType, this._tblControlType);
                clMain.SetRepositoryDataSource(this.rluComparision, this._tblComparision);
                clMain.SetRepositoryDataSource(this.rluConjunction, this._tblConjunction);
                clMain.SetRepositoryDataSource(this.rluIncInHd, this._tblIncInHd);

                this._tblReportParameter = DataObj.GetDataTable("tblReportParameter");

                cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.paramIdTextBox,
                    this.descriptionTextBox,
                    this.fieldNameLookUpEdit,
                    this.dataTypeLookUpEdit,
                    this.controlTypeLookUpEdit,
                    this.comparisionLookUpEdit,
                    this.conjunctionLookUpEdit,
                    this.incInHdLookUpEdit,
                    this.displayMemberTextBox,
                    this.valueMemberTextBox,
                    this.dataSourceTextBox,
                    this.dataSourceTypeLookUpEdit,
                    this.listFieldsTextBox
                });

                clMain.BindControls(cntrsList, this._tblReportParameter);
                cntrsList.Clear();

                this._tblReportParameterList = DataObj.GetDataTable("tblReportParameter");
                clMain.SetDataSource(this.gctRepParameter, this._tblReportParameterList);
                #endregion

                #region Subreports
                this._tblDataObjNameSubrep = new DataTable("tblDataObjName");
                this._tblDataObjNameSubrep.Columns.Add("ObjName", typeof(string));
                this._tblDataObjNameAll = new DataTable("tblDataObjName");
                this._tblDataObjNameAll.Columns.Add("ObjName", typeof(string));
                clMain.SetDataSource(this.dataObjTypeLookUpEditSubrep, this._tblDataObjType);
                clMain.SetDataSource(this.dataObjNameLookUpEditSubrep, this._tblDataObjNameSubrep);
                clMain.SetRepositoryDataSource(this.rluDataObjType, this._tblDataObjType);
                clMain.SetRepositoryDataSource(this.rluDataObjName, this._tblDataObjNameAll);
                this._tblSubReports = DataObj.GetDataTable("tblSubReports");

                cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.subRepIdTextBox,
                    this.dataObjTypeLookUpEditSubrep,
                    this.dataObjNameLookUpEditSubrep,
                    this.criteriaTextBoxSubrep
                });

                clMain.BindControls(cntrsList, this._tblSubReports);
                cntrsList.Clear();

                this._tblSubReportsList = DataObj.GetDataTable("tblSubReports");
                clMain.SetDataSource(this.gctSubreport, this._tblSubReportsList);
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
                  

                    //Data Object Type
                    object[] values = new object[] { new object[]{"U", "Table"},
                                                        new object[]{"V","View"},
                                                        new object[]{"P","Stored Procedure"}
                                                    };
                    this._tblDataObjType.Rows.Clear();
                    foreach (object[] value in values)
                        this._tblDataObjType.Rows.Add(value);
                    //Control Type
                    values = new object[] { new object[]{"System.Windows.Forms.TextBox", "TextBox"},
                                                        new object[]{"System.Windows.Forms.DateTimePicker","DateTimePicker"},
                                                        new object[]{"DevExpress.XtraEditors.LookUpEdit","LookUpEdit"}
                                                    };
                    this._tblControlType.Rows.Clear();
                    foreach (object[] value in values)
                        this._tblControlType.Rows.Add(value);

                    DataObj.FillData(this._tblDataType, "SELECT [Name] As DataTypeName FROM sysTypes ORDER BY [Name]");
                    DataObj.FillData(this._tblReportGroup, "SELECT * FROM tblReportGroup ");
                    DataObj.FillData(this._tblReportsList, "SELECT * FROM tblReports");
                    DataObj.FillData(this._tblDataObjNameAll, "SELECT [Name] As DataObjName FROM sysobjects WHERE xtype IN ('u','v','p')");
                    //Comparision
                    values = new object[] { "=", ">=", "<=", ">", "<", "<>" };
                    this._tblComparision.Rows.Clear();
                    foreach (object value in values)
                        this._tblComparision.Rows.Add(new object[] { value });
                    //Conjunction
                    values = new object[] { "AND", "OR" };
                    this._tblConjunction.Rows.Clear();
                    foreach (object value in values)
                        this._tblConjunction.Rows.Add(new object[] { value });
                    //Include in header
                    values = new object[] { new object[]{true, "Yes"},
                                                        new object[]{false, "No"},
                                                    };
                    this._tblIncInHd.Rows.Clear();
                    foreach (object[] value in values)
                        this._tblIncInHd.Rows.Add(value);
                    //Data Source Type
                    values = new object[] { "SQL", "List" };
                    this._tblDataSourceType.Rows.Clear();
                    foreach (object value in values)
                        this._tblDataSourceType.Rows.Add(new object[] { value });

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
                    this.repIdLookUpEdit.Focus();

                    if ( this._repId == -1)
                    {
                        AppMessageBox.ShowExclamation("Please select or add new " + this._title);
                        this.repIdLookUpEdit.Focus();
                        return;
                    }

                    this._report = this._tblReports.Rows[0];

                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._report, true))
                        {
                            foreach (DataRow row in this._tblReportParameterList.Rows)
                                row["RepId"] = this._report["RepId"];

                            DataObj.UpdateTable(this._tblReportParameterList);
                            DataObj.UpdateTable(this._tblSubReportsList);
                            InitForm(true);
                        }
                    }
                    else
                    {
                        if (DataObj.Update(this._title, this._report, true))
                        {
                            DataObj.UpdateTable(this._tblReportParameterList);
                            DataObj.UpdateTable(this._tblSubReportsList);
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
                if ( this._repId == -1)
                {
                    AppMessageBox.ShowExclamation("Please select " + this._title + " to delete");
                    this.repIdLookUpEdit.Focus();
                    return;
                }
               

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete " + this._title + "?") == DialogResult.No)
                    return;

                this._report = this._tblReports.Rows[0];

                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._report, true))
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

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
           
                this.repIdLookUpEdit.EditValue = this.GetNextReportId();

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.repIdLookUpEdit.EditValue = null;
        }

        private void repIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.repIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.repIdLookUpEdit.EditValue))
            {
                this._repId = -1;
                this._tblReportParameterList.Rows.Clear();
                this._tblSubReportsList.Rows.Clear();
            }
            else
            {
                this._repId = Convert.ToInt32(this.repIdLookUpEdit.EditValue);
                this.GetRepParameters(this._repId);
                this.GetSubreports(this._repId);
            }
            this.GetReportEntry(this._repId);
        }

        private void repIdTextBox_Validated(object sender, EventArgs e)
        {
            if (!this.repIdTextBox.ReadOnly && this.repIdTextBox.Text != string.Empty)
            {
                this.repIdLookUpEdit.EditValue = this.repIdTextBox.Text;
                if (!this._isNew && this.repIdLookUpEdit.Text == string.Empty)
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
                this._report = this._tblReports.NewRow();
                clDatacon.SetToDatabaseDefaults(this._report, clMain.ConnString);
               
                if (this._repId != -1) this._report["RepId"] = this._repId;
                
                this._report["IsByUser"] = false;
                this._tblReports.Rows.Clear();
                this._tblReports.Rows.Add(this._report);
                this._isLoadingEntry = false;
            }
        }

        private bool GetReportEntry(int repId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
               
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                if (repId == -1)
                {
                    this.IsNew = false;
                    this._tblReports.Rows.Clear();
                    this._isLoadingEntry = false;
                    return true;
                }
                if (!this.ReportExists(repId))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    this.repIdTextBox.Focus();
                    return true;
                }
                try
                {
                    

                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblReports, "SELECT * FROM tblReports WHERE RepId=" + repId);
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

        private bool ReportExists(int repId)
        {
            object result;
            string cmdText;
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (repId == -1) return false;

            try
            {
               
                DataObj.OpenConnection();
                cmdText = "SELECT RepId FROM tblReports WHERE RepId=" + repId;
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

        private int GetNextReportId()
        {
            object result;
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("SELECT max(RepId) As MaxRepId FROM tblReports");
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

        private void dataObjTypeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.dataObjTypeLookUpEdit.EditValue == null || Convert.IsDBNull(this.dataObjTypeLookUpEdit.EditValue))
            {
                this._tblDataObjName.Rows.Clear();
            }
            else
            {
                this.GetDataObjects(Convert.ToString(this.dataObjTypeLookUpEdit.EditValue));
            }
        }

        private void dataObjNameLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.dataObjNameLookUpEdit.EditValue == null || Convert.IsDBNull(this.dataObjNameLookUpEdit.EditValue))
            {
                this._dataObjId = -1;
                this._tblColumn.Rows.Clear();
            }
            else
            {
                this._dataObjId = this.GetDataObjId(Convert.ToString(this.dataObjNameLookUpEdit.EditValue));
                this.GetColumns(this._dataObjId);
            }
        }

        private void GetDataObjects(string dataObjType)
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                DataObj.FillData(this._tblDataObjName, "SELECT [Name] As DataObjName FROM sysObjects WHERE xtype='" + dataObjType + "' AND [Name] NOT LIKE 'dt%' ORDER BY [Name]");
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

        private void GetColumns(int dataObjId)
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                DataObj.FillData(this._tblColumn, "SELECT syscolumns.[name] As ColumnName FROM sysColumns WHERE id=" + dataObjId + " ORDER BY ColId");
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

        #region Parameters
        private void addParamToolStripButton_Click(object sender, EventArgs e)
        {
            this.repIdTextBox.Focus();

            if ( this._repId == -1)
            {
                AppMessageBox.ShowExclamation("Please select or add new " + this._title);
                this.paramIdTextBox.Focus();
                return;
            }

            this._reportParameter = this._tblReportParameter.Rows[0];
            if (this._reportParameter["DataSource"] != null)
            {
                this._reportParameter["DataSource"] = this._reportParameter["DataSource"].ToString().Replace("`", "'");
            }

            if (this._isNewParam)
            {
                if (clDataUtility.Insert(this._reportParameter, this._tblReportParameterList, true, clMain.ConnString))
                {
                    this.refreshParamToolStripButton_Click(null, null);
                }
            }
            else
            {
                if (clDataUtility.Update(this._reportParameter, this._tblReportParameterList, true, clMain.ConnString))
                {
                    this.refreshParamToolStripButton_Click(null, null);
                }
            }
        }

        private void removeParamToolStripButton_Click(object sender, EventArgs e)
        {
            if (this._repId == -1 || this._paramId == -1)
            {
                AppMessageBox.ShowExclamation("Please select " + this._titleParam + " to remove");
                return;
            }

            this._reportParameter = this._tblReportParameter.Rows[0];

            if (clDataUtility.Delete(this._reportParameter, this._tblReportParameterList, true, clMain.ConnString))
            {
                this.refreshParamToolStripButton_Click(null, null);
            }
        }

        private void refreshParamToolStripButton_Click(object sender, EventArgs e)
        {
            this._paramId = -1;
            this.GetRepParameterEntry(this._repId, this._paramId);
        }

        private void paramIdTextBox_Validated(object sender, EventArgs e)
        {
            if (!this.paramIdTextBox.ReadOnly && this.paramIdTextBox.Text != string.Empty)
            {
                this._paramId = Convert.ToInt32(this.paramIdTextBox.Text);
                this.GetRepParameterEntry(this._repId, this._paramId);
            }
        }

        private void gridRepParameter_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridRepParameter.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridRepParameter.GetDataRow(focused);
                this._paramId = Convert.ToInt32(curRow["ParamId"]);
                this.GetRepParameterEntry(this._repId, this._paramId);
                this.gridRepParameter.FocusedRowHandle = focused;
            }
        }

        private void fieldNameLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.fieldNameLookUpEdit.EditValue == null || Convert.IsDBNull(this.fieldNameLookUpEdit.EditValue))
            {
                this.dataTypeLookUpEdit.EditValue = null;
            }
            else
            {
                this.dataTypeLookUpEdit.EditValue = this.GetDataTypeName(this.GetDataTypeId(this._dataObjId, Convert.ToString(this.fieldNameLookUpEdit.EditValue)));
            }
        }

        private void GetNewRepParameterEntry()
        {
            if (!this._isLoadingEntryParam)
            {
                this._isLoadingEntryParam = true;
                this.IsNewParam = true;
                this._reportParameter = this._tblReportParameter.NewRow();
                clDatacon.SetToDatabaseDefaults(this._reportParameter, clMain.ConnString);
                if (this._repId != -1) this._reportParameter["RepId"] = this._repId;
                if (this._paramId != -1) this._reportParameter["ParamId"] = this._paramId;
                this._reportParameter["IncInHd"] = true;
                this._reportParameter["ControlType"] = "System.Windows.Forms.TextBox";
                this._reportParameter["DataSourceType"] = "SQL";
                this._reportParameter["DataSource"] = "-";
                this._tblReportParameter.Rows.Clear();
                this._tblReportParameter.Rows.Add(this._reportParameter);
                this._isLoadingEntryParam = false;
            }
        }

        private bool GetRepParameterEntry(int repId, int paramId)
        {
            if (!this._isLoadingEntryParam)
            {
                this._isLoadingEntryParam = true;
                if (!this.RepParameterExists(repId, paramId))
                {
                    this._isLoadingEntryParam = false;
                    this.GetNewRepParameterEntry();
                    return true;
                }
                try
                {
                    this.IsNewParam = false;
                    this._reportParameter = this._tblReportParameter.NewRow();
                    this._reportParameter.ItemArray = this._tblReportParameterList.Rows.Find(new object[] { repId, paramId }).ItemArray;
                    this._tblReportParameter.Rows.Clear();
                    this._tblReportParameter.Rows.Add(this._reportParameter);
                    return true;
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    return false;
                }
                finally
                {
                    this._isLoadingEntryParam = false;
                }
            }
            else
                return false;
        }

        private bool RepParameterExists(int repId, int paramId)
        {
            if (repId == -1 || paramId == -1)
                return false;

            try
            {
                DataRow row = this._tblReportParameterList.Rows.Find(new object[] { repId, paramId });
                return (row != null);
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return false;
            }
            finally
            {
            }
        }

        private void GetRepParameters(int repId)
        {
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                
                DataObj.OpenConnection();
                DataObj.FillData(this._tblReportParameterList, "SELECT * FROM tblReportParameter WHERE RepId=" + repId);
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshParamToolStripButton_Click(null, null);
            }
        }
        #endregion

        #region Subreports
        private void addSubrepToolStripButton_Click(object sender, EventArgs e)
        {
            this.repIdTextBox.Focus();

            if ( this._repId == -1)
            {
                AppMessageBox.ShowExclamation("Please select or add new " + this._title);
                this.subRepIdTextBox.Focus();
                return;
            }

            this._subReport = this._tblSubReports.Rows[0];
            if (this._subReport["Criteria"] != null)
            {
                this._subReport["Criteria"] = this._subReport["Criteria"].ToString().Replace("`", "'");
            }

            if (this._isNewSubrep)
            {
                if (clDataUtility.Insert(this._subReport, this._tblSubReportsList, true, clMain.ConnString))
                {
                    this.refreshSubrepToolStripButton_Click(null, null);
                }
            }
            else
            {
                if (clDataUtility.Update(this._subReport, this._tblSubReportsList, true, clMain.ConnString))
                {
                    this.refreshSubrepToolStripButton_Click(null, null);
                }
            }
        }

        private void removeSubrepToolStripButton_Click(object sender, EventArgs e)
        {
            if (this._repId == -1 || this._subRepId == null)
            {
                AppMessageBox.ShowExclamation("Please select " + this._titleSubrep + " to remove");
                return;
            }

            this._subReport = this._tblSubReports.Rows[0];

            if (clDataUtility.Delete(this._subReport, this._tblSubReportsList, true, clMain.ConnString))
            {
                this.refreshSubrepToolStripButton_Click(null, null);
            }
        }

        private void refreshSubrepToolStripButton_Click(object sender, EventArgs e)
        {
            this._subRepId = null;
            this.GetSubreportEntry(this._repId, this._subRepId);
        }

        private void subRepIdTextBox_Validated(object sender, EventArgs e)
        {
            if (!this.subRepIdTextBox.ReadOnly && this.subRepIdTextBox.Text != string.Empty)
            {
                this._subRepId = Convert.ToString(this.subRepIdTextBox.Text);
                this.GetSubreportEntry(this._repId, this._subRepId);
            }
        }

        private void gridSubreport_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridSubreport.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridSubreport.GetDataRow(focused);
                this._subRepId = Convert.ToString(curRow["SubRepId"]);
                this.GetSubreportEntry(this._repId, this._subRepId);
                this.gridSubreport.FocusedRowHandle = focused;
            }
        }

        private void dataObjTypeLookUpEditSubrep_EditValueChanged(object sender, EventArgs e)
        {
            if (this.dataObjTypeLookUpEditSubrep.EditValue == null || Convert.IsDBNull(this.dataObjTypeLookUpEditSubrep.EditValue))
            {
                this._tblDataObjNameSubrep.Rows.Clear();
            }
            else
            {
                this.GetDataObjectsSubreport(Convert.ToString(this.dataObjTypeLookUpEditSubrep.EditValue));
            }
        }

        private void GetNewSubreportEntry()
        {
            if (!this._isLoadingEntrySubrep)
            {
                this._isLoadingEntrySubrep = true;
                this.IsNewSubrep = true;
                this._subReport = this._tblSubReports.NewRow();
                clDatacon.SetToDatabaseDefaults(this._subReport, clMain.ConnString);
                if (this._repId != -1) this._subReport["RepId"] = this._repId;
                if (this._subRepId != null) this._subReport["SubRepId"] = this._subRepId;
                this._tblSubReports.Rows.Clear();
                this._tblSubReports.Rows.Add(this._subReport);
                this._isLoadingEntrySubrep = false;
            }
        }

        private bool GetSubreportEntry(int repId, string subRepId)
        {
            if (!this._isLoadingEntrySubrep)
            {
                this._isLoadingEntrySubrep = true;
                if (!this.SubreportExists(repId, subRepId))
                {
                    this._isLoadingEntrySubrep = false;
                    this.GetNewSubreportEntry();
                    return true;
                }
                try
                {
                    this.IsNewSubrep = false;
                    this._subReport = this._tblSubReports.NewRow();
                    this._subReport.ItemArray = this._tblSubReportsList.Rows.Find(new object[] { repId, subRepId }).ItemArray;
                    this._tblSubReports.Rows.Clear();
                    this._tblSubReports.Rows.Add(this._subReport);
                    return true;
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    return false;
                }
                finally
                {
                    this._isLoadingEntrySubrep = false;
                }
            }
            else
                return false;
        }

        private bool SubreportExists(int repId, string subRepId)
        {
            if (repId == -1 || subRepId == null)
                return false;

            try
            {
                DataRow row = this._tblSubReportsList.Rows.Find(new object[] { repId, subRepId });
                return (row != null);
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return false;
            }
            finally
            {
            }
        }

        private void GetSubreports(int repId)
        {
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                DataObj.FillData(this._tblSubReportsList, "SELECT * FROM tblSubReports WHERE RepId=" + repId);
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshSubrepToolStripButton_Click(null, null);
            }
        }

        private void GetDataObjectsSubreport(string dataObjType)
        {
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                DataObj.FillData(this._tblDataObjNameSubrep, "SELECT [Name] As DataObjName FROM sysObjects WHERE xtype='" + dataObjType + "' AND [Name] NOT LIKE 'dt%' ORDER BY [Name]");
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

        private int GetDataTypeId(int dataObjId, string columnName)
        {
            object result;
          
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                result = DataObj.GetValue("syscolumns", "xtype", "id=" + dataObjId + " AND [name]='" + columnName + "'");
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

        private string GetDataTypeName(int dataTypeId)
        {
            object result;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                result = DataObj.GetValue("systypes", "name", "xtype=" + dataTypeId);
                if (result == null || Convert.IsDBNull(result))
                    return null;
                else
                    return Convert.ToString(result);
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void controlTypeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.controlTypeLookUpEdit.EditValue != null && !Convert.IsDBNull(this.controlTypeLookUpEdit.EditValue))
            {
                if (this.controlTypeLookUpEdit.EditValue.ToString().StartsWith("DevExpress"))
                {
                    this.lookUpEditPropertiesGroupBox.Visible = true;
                    return;
                }
            }
            this.lookUpEditPropertiesGroupBox.Visible = false;
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (this._repId > 0)
            {
                if (this.CopyReportSetup(this._repId))
                {
                    AppMessageBox.ShowInformation(this._title + " copied successfully");
                }
            }
        }

        private bool CopyReportSetup(int reportId)
        {
           
            int nextRepId = this.GetNextReportId();
            string cmdText;
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                cmdText = "INSERT INTO tblReports SELECT " + nextRepId + " As RepId, RepName, ReportFileName, DataObjType, DataObjName,Criteria,SortBy,ReportHead,ReportGroup,Application,ReportSrcBy,IsByUser,UsrNameFld,1 as IsActive FROM tblReports WHERE RepId=" + reportId;
                if (DataObj.Execute(cmdText))
                {
                    cmdText = "INSERT INTO tblReportParameter SELECT  " + nextRepId + " As RepId,ParamId,Description,FieldName,Comparision,Conjunction,DataType,IncInHd,ControlType,DisplayMember,ValueMember,DataSource,DataSourceType,ListFields FROM tblReportParameter WHERE RepId=" + reportId;
                    DataObj.Execute(cmdText);
                }
                this.InitForm(true);
                this.repIdLookUpEdit.EditValue = nextRepId;
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
            }
        }

       

        //private void GetAppReports()
        //{
           
        //    clDatacon DataObj = new clDatacon(clMain.ConnString);
        //    try
        //    {
                
        //        DataObj.OpenConnection();
        //        DataObj.FillData(this._tblReportGroup, "SELECT * FROM tblReportGroup ");
        //        DataObj.FillData(this._tblReportsList, "SELECT * FROM tblReports");
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    }
        //    finally
        //    {
        //        DataObj.CloseConnection();
        //        this.refreshToolStripButton_Click(null, null);
        //    }
        //}

        //private void GetAppDataObjects()
        //{
           
        //    clDatacon DataObj = new clDatacon(clMain.ConnString);
        //    try
        //    {
                
        //        DataObj.OpenConnection();
        //        DataObj.FillData(this._tblDataObjNameAll, "SELECT [Name] As DataObjName FROM sysobjects WHERE xtype IN ('u','v','p')");
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    }
        //    finally
        //    {
        //        DataObj.CloseConnection();
        //    }
        //}

       



    }
}
