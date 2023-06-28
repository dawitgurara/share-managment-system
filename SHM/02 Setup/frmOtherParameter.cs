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
    public partial class frmOtherParameter : Form
    {

        #region Fields
        private string _title = "Other Parameter";

        private int _parameterId = 0;
        private string _tableName = string.Empty;
        private DataTable _tblOtherParameter;
        private DataRow _otherParameterRow;
        private clOtherParameter _otherParameter;
        int _columnCount = 0;
        

        private DataTable _tblParameterValue;
        private DataRow _parameterValue;
        #endregion

        public frmOtherParameter()
        {
            InitializeComponent();
        }

        private void frmOtherParameter_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                this._tblOtherParameter = DataObj.GetDataTable("tblOtherParameter");
                clMain.SetDataSource(this.gctOtherParameter, this._tblOtherParameter);

                this._tblParameterValue = new DataTable();
                clMain.SetDataSource(this.gctParameterValue, this._tblParameterValue);
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
                //DataObj.FillData(this._tblOtherParameter, "SELECT * FROM tblOtherParameter WHERE Id IN (SELECT ParameterId FROM View_UserOtherParameterRights WHERE UserName='" + clMain.UserName + "') ORDER BY Description");
                //DataObj.FillData(this._tblOtherParameter, "SELECT * FROM tblOtherParameter WHERE Id IN (SELECT ParameterId FROM View_UserOtherParameterRights)  ORDER BY Description");
                DataObj.FillData(this._tblOtherParameter, "SELECT * FROM tblOtherParameter  ORDER BY Description");

                this.gridGlobalParameter.BestFitColumns();
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
            //frmTransactionTypeEdit frmTranEdit = new frmTransactionTypeEdit(-1);
            //if (frmTranEdit.ShowDialog() == DialogResult.OK)
            //{
            //    InitForm(true);
            //}
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (this.Validate())
                {

                    if (this._tblParameterValue.GetChanges() == null)
                    {
                        return;
                    }

                    DataObj.OpenConnection();

                    if(DataObj.UpdateTable(this._tblParameterValue))
                        AppMessageBox.ShowInformation(this._otherParameterRow["Description"] + " updated successfully");
                    //if (DataObj.UpdateTable(this._tblParameterValue, (this._parameterModules.Count == 0)))
                    //{
                    //    int j = 0;

                    //    AppMessageBox.ShowInformation(this._otherParameterRow["Description"] + " updated successfully");
                    //}
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

                if (this._parameterValue == null)
                {
                    AppMessageBox.ShowExclamation("Please select " + this._title + " to delete");
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete '" + this._otherParameterRow["Description"].ToString() + "'?") == DialogResult.No)
                    return;

                if (clDataUtility.Delete(this._parameterValue, this._tblParameterValue, true, clMain.ConnString))
                {
                    //this.refreshPosEduToolStripButton_Click(null, null);
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
            this.gctParameterValue.ShowPrintPreview();
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            //InitForm(true);
        }

        private void gridOtherParameter_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this._otherParameterRow = this.gridGlobalParameter.GetDataRow(e.FocusedRowHandle);
            if (this._otherParameterRow != null)
            {
                this._parameterId = Convert.ToInt32(this._otherParameterRow["Id"]);
                this._tableName = Convert.ToString(this._otherParameterRow["TableName"]);
                this.toolStripTextBox1.Text = Convert.ToString(this._otherParameterRow["Description"]) + " Setup";
            }
            else
            {
                this._parameterId = 0;
                this._tableName = string.Empty;
                this.toolStripTextBox1.Text = string.Empty;
            }
            this.gridOtherParameter_Click(null, null);
        }

        private void gridOtherParameter_Click(object sender, EventArgs e)
        {
           
            //DataTable tblGlobalParameterColumns;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                if (this._tableName != string.Empty)
                {
                    this._tblParameterValue = DataObj.GetDataTable(this._tableName);
                    this._tblParameterValue.Columns["CrtBy"].ReadOnly = true;
                    this._tblParameterValue.Columns["CrtDt"].ReadOnly = true;
                    this._tblParameterValue.Columns["CrtWs"].ReadOnly = true;
                    DataObj.FillData(this._tblParameterValue, "SELECT * FROM " + this._tableName);
                }
                clMain.SetDataSource(this.gctParameterValue, this._tblParameterValue);
                this.gridParameterValue.PopulateColumns();
                foreach (DataColumn col in this._tblParameterValue.Columns)
                {
                    if (col.ReadOnly || col.AutoIncrement)
                        this.gridParameterValue.Columns[col.ColumnName].OptionsColumn.AllowEdit = false;
                }
                this.gridParameterValue.Columns["LmBy"].OptionsColumn.AllowEdit = false;
                this.gridParameterValue.Columns["LmDt"].OptionsColumn.AllowEdit = false;
                this.gridParameterValue.Columns["LmWs"].OptionsColumn.AllowEdit = false;

                this.CreateEditorControls(this._parameterId);

                this.gridParameterValue.BestFitColumns();
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

      

        private void gridParameterValue_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this._parameterValue = this.gridParameterValue.GetDataRow(e.FocusedRowHandle);
        }

        private void gridOtherParameter_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    this.gridGlobalParameter_Click(null, null);
        }

        private void gridParameterValue_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.gridParameterValue.GetDataRow(e.RowHandle)["CrtBy"] = clMain.User.UserName;
            this.gridParameterValue.GetDataRow(e.RowHandle)["CrtDt"] = clUtility.GetCurrentDate();
            this.gridParameterValue.GetDataRow(e.RowHandle)["CrtWs"] = clUtility.GetCurrentWorkstation();
        }

        private void gridParameterValue_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            this.gridParameterValue.GetDataRow(e.RowHandle)["LmBy"] = clMain.User.UserName;
            this.gridParameterValue.GetDataRow(e.RowHandle)["LmDt"] = clUtility.GetCurrentDate();
            this.gridParameterValue.GetDataRow(e.RowHandle)["LmWs"] = clUtility.GetCurrentWorkstation();
        }

        private void CreateEditorControls(int parameterId)
        {
            this._otherParameter = new clOtherParameter(parameterId, clMain.ConnString);

            for (int i = 0; i < this.gridParameterValue.Columns.Count; i++)
            {
                this.gridParameterValue.Columns[i].Caption = clDataUtility.GetColumnDescription(this._otherParameter.TableName, this.gridParameterValue.Columns[i].FieldName, clMain.ConnString);
            }

            if (this._otherParameter.GlobalParameterColumns == null)
                return;

            else
            {
                for (int i = 0; i < this._otherParameter.GlobalParameterColumns.Count; i++)
                {
                    this._columnCount = i;

                    if (this._otherParameter.GlobalParameterColumns[i].Caption != null && this._otherParameter.GlobalParameterColumns[i].Caption.Length != 0)
                        this.gridParameterValue.Columns[this._otherParameter.GlobalParameterColumns[i].FieldName].Caption = this._otherParameter.GlobalParameterColumns[i].Caption;

                    if (this._otherParameter.GlobalParameterColumns[i].ControlType == null || this._otherParameter.GlobalParameterColumns[i].ControlType.Length == 0)
                        continue;

                    switch (this._otherParameter.GlobalParameterColumns[i].ControlType)
                    {
                        case "DevExpress.XtraEditors.LookUpEdit":
                            this.AutoCreateLookUpEdit();
                            break;
                        default:
                            AppMessageBox.ShowExclamation("Unkown control type: " + this._otherParameter.GlobalParameterColumns[i].ControlType);
                            break;
                    }
                }
            }
        }

        private void AutoCreateLookUpEdit()
        {
            otherParameterColumn parameterColumn = this._otherParameter.GlobalParameterColumns[this._columnCount];
            string fieldName, width, caption;
            int j;
            DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit columnLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            columnLookUpEdit.Name = "paramLookUpEdit" + this._columnCount.ToString();
            columnLookUpEdit.Properties.NullText = string.Empty;
            columnLookUpEdit.Properties.DisplayMember = parameterColumn.DisplayMember;
            columnLookUpEdit.Properties.ValueMember = parameterColumn.ValueMember;
            string[] values = parameterColumn.ListFields.Split(new char[] { otherParameterColumn.ListFieldSeparator });
            for (int i = 0; i < values.Length; i = i + 3)
            {
                j = i;
                fieldName = values[j];
                width = values[j + 1];
                if (width == null || width == string.Empty)
                    width = "20";
                caption = values[j + 2];
                columnLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(fieldName, Convert.ToInt32(width), caption));
            }

            DataTable paramTable = new DataTable();
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            DataObj.FillData(paramTable, parameterColumn.DataSource);
            columnLookUpEdit.Properties.DataSource = paramTable;

            //this._globalParameter.GlobalParameterColumns[this._columnCount].Control = (Control)columnLookUpEdit;

            this.gridParameterValue.Columns[parameterColumn.FieldName].ColumnEdit = columnLookUpEdit;
        }

    }
}