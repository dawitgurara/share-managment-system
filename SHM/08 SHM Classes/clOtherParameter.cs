using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SHM
{
    class clOtherParameter
    {
   #region Fields
        private int _parameterId;
        private string _description;
        private string _tableName;
        private List<otherParameterColumn> _globalParameterColumns;
        private string _connString;
        #endregion

        #region Properties
        public int ParamId
        {
            get { return this._parameterId; }
            set { this._parameterId = value; }
        }

        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }
        public List<otherParameterColumn> GlobalParameterColumns
        {
            get { return this._globalParameterColumns; }
            set { this._globalParameterColumns = value; }
        }
        public string ConnString
        {
            get { return this._connString; }
        }
        #endregion


        public clOtherParameter(int parameterId, string connString)
        {
            this._connString = connString;
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(this._connString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblOtherParameter WHERE Id=" + parameterId;
                Ds = DataObj.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = Ds.Tables[0].Rows[0];
                    this._parameterId = Convert.ToInt32(row["Id"]);
                    this._description = Convert.ToString(row["Description"]);
                    this._tableName = Convert.ToString(row["TableName"]);

                    this.GetColumns();

                }
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

        private bool GetColumns()
        {
            otherParameterColumn parameterColumn;
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(this._connString);
            try
            {
                this._globalParameterColumns = new List<otherParameterColumn>();
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblOtherParameterColumns WHERE ParameterId=" + this._parameterId;
                Ds = DataObj.GetDataSet(cmdText);
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    parameterColumn = new otherParameterColumn();
                    parameterColumn.ParamId = Convert.ToInt32(row["ParameterId"]);
                    parameterColumn.FieldName = Convert.ToString(row["FieldName"]);
                    parameterColumn.Caption = Convert.ToString(row["Caption"]);
                    parameterColumn.ControlType = Convert.ToString(row["ControlType"]);

                    if (parameterColumn.ControlType == "DevExpress.XtraEditors.LookUpEdit")
                    {
                        if (row["DisplayMember"] != null && !Convert.IsDBNull(row["DisplayMember"]))
                            parameterColumn.DisplayMember = Convert.ToString(row["DisplayMember"]);
                        if (row["ValueMember"] != null && !Convert.IsDBNull(row["ValueMember"]))
                            parameterColumn.ValueMember = Convert.ToString(row["ValueMember"]);
                        if (row["DataSource"] != null && !Convert.IsDBNull(row["DataSource"]))
                            parameterColumn.DataSource = Convert.ToString(row["DataSource"]);
                        if (row["DataSourceType"] != null && !Convert.IsDBNull(row["DataSourceType"]))
                            parameterColumn.DataSourceType = Convert.ToString(row["DataSourceType"]);
                        if (row["ListFields"] != null && !Convert.IsDBNull(row["ListFields"]))
                            parameterColumn.ListFields = Convert.ToString(row["ListFields"]);
                        else
                            parameterColumn.ListFields = string.Empty;
                    }

                    this._globalParameterColumns.Add(parameterColumn);
                }
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

    }

    public class otherParameterColumn
    {
        #region Fields
        public static readonly char ListFieldSeparator = Convert.ToChar("^");
        private int _paramId;
        private string _fieldName;
        private string _caption;
        private string _controlType;

        private string _displayMember;
        private string _valueMember;
        private string _dataSource;
        private string _dataSourceType;
        private string _listFields;

        private Control _control;
        #endregion

        #region Properties
        public int ParamId
        {
            get { return this._paramId; }
            set { this._paramId = value; }
        }
       
       
        public string FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }
        public string Caption
        {
            get { return this._caption; }
            set { this._caption = value; }
        }
        
        public string ControlType
        {
            get { return this._controlType; }
            set { this._controlType = value; }
        }

        public string DisplayMember
        {
            get { return this._displayMember; }
            set { this._displayMember = value; }
        }
        public string ValueMember
        {
            get { return this._valueMember; }
            set { this._valueMember = value; }
        }
        public string DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }
        public string DataSourceType
        {
            get { return this._dataSourceType; }
            set { this._dataSourceType = value; }
        }
        public string ListFields
        {
            get { return this._listFields; }
            set { this._listFields = value; }
        }

        public Control Control
        {
            get { return this._control; }
            set { this._control = value; }
        }
        #endregion

    }
}
