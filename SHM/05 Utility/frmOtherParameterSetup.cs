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
    public partial class frmOtherParameterSetup : Form
    {
        #region Fields
        private string _title = "Other Parameter Setup";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

       
        private int _parameterId = -1;
        private DataTable _tblOtherParameter;
        private DataRow _OtherParameter;

        private DataTable _tblOtherParameterList;
        private DataTable _tblDataObjType;
        private DataTable _tblDataObjName;

        #region Parameter Columns
        private string _titleColumn = "Other Parameter Column";
        private bool _isNewColumn = false;
        private bool _isLoadingEntryColumn = false;

        private string _fieldName = null;
        private int _dataObjId = -1;
        private DataTable _tblOterParameterColumns;
        private DataRow _OterParameterColumns;

        private DataTable _tblOtherParameterColumnsList;
        private DataTable _tblColumn;
        private DataTable _tblControlType;
        private DataTable _tblDataSourceType;
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
                this.idTextBox.ReadOnly = !this._isNew;
            }
        }
        public bool IsNewColumn
        {
            get { return this._isNewColumn; }
            set
            {
                this._isNewColumn = value;
                this.removeColumnToolStripButton.Enabled = !this._isNewColumn;
            }
        }
       

        #endregion

        public frmOtherParameterSetup()
        {
            InitializeComponent();
        }

        private void frmOtherParameterSetup_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void frmOtherParameterSetup_KeyDown(object sender, KeyEventArgs e)
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

               
                this._tblOtherParameterList = DataObj.GetDataTable("tblOtherParameter");
                this._tblDataObjType = new DataTable("tblDataObjType");
                this._tblDataObjType.Columns.Add("TypeId", typeof(string));
                this._tblDataObjType.Columns.Add("TypeName", typeof(string));
                this._tblDataObjName = new DataTable("tblDataObjName");
                this._tblDataObjName.Columns.Add("ObjName", typeof(string));
               
                clMain.SetDataSource(this.idLookUpEdit, this._tblOtherParameterList);
                clMain.SetDataSource(this.tableNameLookUpEdit, this._tblDataObjName);
                
                this.idLookUpEdit.Properties.NullText = "-- Select " + this._title + " --";

                this._tblOtherParameter = DataObj.GetDataTable("tblOtherParameter");

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.idTextBox,
                    this.descriptionTextBox,
                    this.tableNameLookUpEdit
                });

                clMain.BindControls(cntrsList, this._tblOtherParameter);
                cntrsList.Clear();

                #region Parameter Columns
                this._tblColumn = new DataTable("tblColumn");
                this._tblColumn.Columns.Add("ColumnName", typeof(string));
                this._tblControlType = new DataTable("tblControlType");
                this._tblControlType.Columns.Add("ControlTypeFullName", typeof(string));
                this._tblControlType.Columns.Add("ControlTypeName", typeof(string));
                this._tblDataSourceType = new DataTable("tblDataSourceType");
                this._tblDataSourceType.Columns.Add("DataSourceTypeName", typeof(string));
                clMain.SetDataSource(this.fieldNameLookUpEdit, this._tblColumn);
                clMain.SetDataSource(this.controlTypeLookUpEdit, this._tblControlType);
                clMain.SetDataSource(this.dataSourceTypeLookUpEdit, this._tblDataSourceType);
                clMain.SetRepositoryDataSource(this.rluFieldName, this._tblColumn);
                clMain.SetRepositoryDataSource(this.rluControlType, this._tblControlType);

                this._tblOterParameterColumns = DataObj.GetDataTable("tblOtherParameterColumns");

                cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.captionTextBox,
                    this.fieldNameLookUpEdit,
                    this.controlTypeLookUpEdit,
                    this.displayMemberTextBox,
                    this.valueMemberTextBox,
                    this.dataSourceTextBox,
                    this.dataSourceTypeLookUpEdit,
                    this.listFieldsTextBox
                });

                clMain.BindControls(cntrsList, this._tblOterParameterColumns);
                cntrsList.Clear();

                this._tblOtherParameterColumnsList = DataObj.GetDataTable("tblOtherParameterColumns");
               clMain.SetDataSource(this.gctParameterColumns, this._tblOtherParameterColumnsList);
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

                    this.GetDataObjects("u");
                    this.GetOtherParametersList();
                    //Control Type
                    object[] values = new object[] { 
                                                        new object[]{"DevExpress.XtraEditors.LookUpEdit","LookUpEdit"}
                                                    };
                    this._tblControlType.Rows.Clear();
                    foreach (object[] value in values)
                        this._tblControlType.Rows.Add(value);

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
                    this.idLookUpEdit.Focus();

                    if ( this._parameterId == -1)
                    {
                        AppMessageBox.ShowExclamation("Please select or add new " + this._title);
                        this.idLookUpEdit.Focus();
                        return;
                    }

                   
                    this._OtherParameter = this._tblOtherParameter.Rows[0];

                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._OtherParameter, true))
                        {
                            DataObj.UpdateTable(this._tblOtherParameterColumnsList);
                           
                            InitForm(true);
                        }
                    }
                    else
                    {
                        if (DataObj.Update(this._title, this._OtherParameter, true))
                        {
                            DataObj.UpdateTable(this._tblOtherParameterColumnsList);
                           
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
                if ( this._parameterId == -1)
                {
                    AppMessageBox.ShowExclamation("Please select " + this._title + " to delete");
                    this.idLookUpEdit.Focus();
                    return;
                }

                
                if (AppMessageBox.ShowQuestion("Are you sure you want to delete " + this._title + "?") == DialogResult.No)
                    return;

                this._OtherParameter = this._tblOtherParameter.Rows[0];

                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._OtherParameter, true))
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
            
                this.idLookUpEdit.EditValue = this.GetNextOtherParameterId();
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.idLookUpEdit.EditValue = null;
        }

        private void idLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.idLookUpEdit.EditValue == null || Convert.IsDBNull(this.idLookUpEdit.EditValue))
            {
                this._parameterId = -1;
                this._tblOtherParameterColumnsList.Rows.Clear();
               
            }
            else
            {
                this._parameterId = Convert.ToInt32(this.idLookUpEdit.EditValue);
                this.GetParameterColumns(this._parameterId);
                
            }
            this.GetOtherParameterEntry(this._parameterId);
        }

        private void idTextBox_Validated(object sender, EventArgs e)
        {
            if (!this.idTextBox.ReadOnly && this.idTextBox.Text != string.Empty)
            {
                this.idLookUpEdit.EditValue = this.idTextBox.Text;
                if (!this._isNew && this.idLookUpEdit.Text == string.Empty)
                {
                    AppMessageBox.ShowExclamation("You don't have the privilage to edit this " + this._title);
                }
            }
        }


        private void GetOtherParametersList()
        {
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                
                DataObj.OpenConnection();
                DataObj.FillData(this._tblOtherParameterList, "SELECT * FROM tblOtherParameter");
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

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._OtherParameter = this._tblOtherParameter.NewRow();
                clDatacon.SetToDatabaseDefaults(this._OtherParameter, clMain.ConnString);
                if (this._parameterId != -1) this._OtherParameter["Id"] = this._parameterId;
                this._tblOtherParameter.Rows.Clear();
                this._tblOtherParameter.Rows.Add(this._OtherParameter);
                this._isLoadingEntry = false;
            }
        }

        private bool GetOtherParameterEntry(int parameterId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
               
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                if (parameterId == -1)
                {
                    this.IsNew = false;
                    this._tblOtherParameter.Rows.Clear();
                    this._isLoadingEntry = false;
                    return true;
                }
                if (!this.OtherParameterExists(parameterId))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    this.idTextBox.Focus();
                    return true;
                }
                try
                {
                    
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblOtherParameter, "SELECT * FROM tblOtherParameter WHERE Id=" + parameterId);
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

        private bool OtherParameterExists(int parameterId)
        {
            object result;
            string cmdText;
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (parameterId == -1)
                return false;

            try
            {
                
                DataObj.OpenConnection();
                cmdText = "SELECT Id FROM tblOtherParameter WHERE Id=" + parameterId;
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

        private int GetNextOtherParameterId()
        {
            object result;
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                
                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("SELECT max(Id) As MaxId FROM tblOtherParameter");
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

        private void tableNameLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.tableNameLookUpEdit.EditValue == null || Convert.IsDBNull(this.tableNameLookUpEdit.EditValue))
            {
                this._dataObjId = -1;
                this._tblColumn.Rows.Clear();
            }
            else
            {
                this._dataObjId = this.GetDataObjId(Convert.ToString(this.tableNameLookUpEdit.EditValue));
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

        #region Parameter Columns
        private void addColumnToolStripButton_Click(object sender, EventArgs e)
        {
            this.idTextBox.Focus();

            if (this._parameterId == -1)
            {
                AppMessageBox.ShowExclamation("Please select or add new " + this._title);
                this.idTextBox.Focus();
                return;
            }

            this._OterParameterColumns = this._tblOterParameterColumns.Rows[0];
            if (this._OterParameterColumns["DataSource"] != null)
            {
                this._OterParameterColumns["DataSource"] = this._OterParameterColumns["DataSource"].ToString().Replace("`", "'");
            }

            if (this._isNewColumn)
            {
                if (clDataUtility.Insert(this._OterParameterColumns, this._tblOtherParameterColumnsList, true, clMain.ConnString))
                {
                    this.refreshColumnToolStripButton_Click(null, null);
                }
            }
            else
            {
                if (clDataUtility.Update(this._OterParameterColumns, this._tblOtherParameterColumnsList, true, clMain.ConnString))
                {
                    this.refreshColumnToolStripButton_Click(null, null);
                }
            }
        }

        private void removeColumnToolStripButton_Click(object sender, EventArgs e)
        {
            if (this._parameterId == -1 || this._fieldName == null)
            {
                AppMessageBox.ShowExclamation("Please select " + this._titleColumn + " to remove");
                return;
            }

            this._OterParameterColumns = this._tblOterParameterColumns.Rows[0];

            if (clDataUtility.Delete(this._OterParameterColumns, this._tblOtherParameterColumnsList, true, clMain.ConnString))
            {
                this.refreshColumnToolStripButton_Click(null, null);
            }
        }

        private void refreshColumnToolStripButton_Click(object sender, EventArgs e)
        {
            this._fieldName = null;
            this.GetParameterColumnEntry(this._parameterId, this._fieldName);
        }

        private void gridParameterColumns_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridParameterColumns.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridParameterColumns.GetDataRow(focused);
                this._fieldName = Convert.ToString(curRow["FieldName"]);
                this.GetParameterColumnEntry(this._parameterId, this._fieldName);
                this.gridParameterColumns.FocusedRowHandle = focused;
            }
        }

        private void fieldNameLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.fieldNameLookUpEdit.EditValue == null || Convert.IsDBNull(this.fieldNameLookUpEdit.EditValue))
            {
                this._fieldName = null;
            }
            else
            {
                this._fieldName = Convert.ToString(this.fieldNameLookUpEdit.EditValue);
            }
            this.GetParameterColumnEntry(this._parameterId, this._fieldName);
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

        private void GetNewParameterColumnEntry()
        {
            if (!this._isLoadingEntryColumn)
            {
                this._isLoadingEntryColumn = true;
                this.IsNewColumn = true;
                this._OterParameterColumns = this._tblOterParameterColumns.NewRow();
                clDatacon.SetToDatabaseDefaults(this._OterParameterColumns, clMain.ConnString);
                if (this._parameterId != -1) this._OterParameterColumns["ParameterId"] = this._parameterId;
                if (this._fieldName != null) this._OterParameterColumns["FieldName"] = this._fieldName;
                this._OterParameterColumns["DataSourceType"] = "SQL";
                this._OterParameterColumns["DataSource"] = "-";
                this._tblOterParameterColumns.Rows.Clear();
                this._tblOterParameterColumns.Rows.Add(this._OterParameterColumns);
                this._isLoadingEntryColumn = false;
            }
        }

        private bool GetParameterColumnEntry(int parameterId, string fieldName)
        {
            if (!this._isLoadingEntryColumn)
            {
                this._isLoadingEntryColumn = true;
                if (!this.ParameterColumnExists(parameterId, fieldName))
                {
                    this._isLoadingEntryColumn = false;
                    this.GetNewParameterColumnEntry();
                    return true;
                }
                try
                {
                    this.IsNewColumn = false;
                    this._OterParameterColumns = this._tblOterParameterColumns.NewRow();
                    this._OterParameterColumns.ItemArray = this._tblOtherParameterColumnsList.Rows.Find(new object[] { parameterId, fieldName }).ItemArray;
                    this._tblOterParameterColumns.Rows.Clear();
                    this._tblOterParameterColumns.Rows.Add(this._OterParameterColumns);
                    return true;
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    return false;
                }
                finally
                {
                    this._isLoadingEntryColumn = false;
                }
            }
            else
                return false;
        }

        private bool ParameterColumnExists(int parameterId, string fieldName)
        {
            if (parameterId == -1 || fieldName == null)
                return false;

            try
            {
                DataRow row = this._tblOtherParameterColumnsList.Rows.Find(new object[] { parameterId, fieldName });
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

        private void GetParameterColumns(int parameterId)
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                DataObj.FillData(this._tblOtherParameterColumnsList, "SELECT * FROM tblOtherParameterColumns WHERE ParameterId=" + parameterId);
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshColumnToolStripButton_Click(null, null);
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
        #endregion
 

    }
}
