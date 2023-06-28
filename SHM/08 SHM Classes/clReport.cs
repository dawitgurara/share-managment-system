using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace SHM
{
    class clReport
    {
   #region Fields
        private int _repId;
        private string _repName;
        private string _repNameAmharic;
        private string _reportFileName;
        private string _dataObjType;
        private string _dataObjName;
        private string _criteria;
        private string _sortBy;
        private string _reportHead;
        private int _reportGroup;
        private string _application;
        private bool _isByUser;
        private string _userNameField;
        private string _connString;
        private List<clReportParameter> _reportParameters;
        private List<clSubReport> _subReports;
        #endregion

        #region Properties
        public int RepId
        {
            get { return this._repId; }
        }
        public string RepName
        {
            get { return this._repName; }
        }
        public string RepNameAmharic
        {
            get { return this._repNameAmharic; }
        }
        public string ReportFileName
        {
            get { return this._reportFileName; }
        }
        public string DataObjType
        {
            get { return this._dataObjType; }
        }
        public string DataObjName
        {
            get { return this._dataObjName; }
        }
        public string Criteria
        {
            get { return this._criteria; }
        }
        public string SortBy
        {
            get { return this._sortBy; }
        }
        public string ReportHead
        {
            get { return this._reportHead; }
        }
        public string ConnString
        {
            get { return this._connString; }
        }
        public List<clReportParameter> ReportParameters
        {
            get { return this._reportParameters; }
        }
         public List<clSubReport> SubReports
        {
            get { return this._subReports; }
        }
        public string CriteriaWithValues
        {
            get
            {
                string criteria;
                if (this._criteria == null)
                    criteria = string.Empty;
                else
                    criteria = this._criteria;

                if (this._reportParameters != null)
                {
                    for (int i = 0; i < this._reportParameters.Count; i++)
                    {
                        if (criteria != string.Empty)
                            criteria += " AND ";
                        if (this._reportParameters[i].DataType == "varchar")
                            criteria += this._reportParameters[i].FieldName + " " + this._reportParameters[i].Comparision + " '" + this._reportParameters[i].Value + "'";
                        else if (this._reportParameters[i].DataType == "datetime")
                            criteria += this._reportParameters[i].FieldName + " " + this._reportParameters[i].Comparision + " '" + clUtility.ToMDYDate(Convert.ToDateTime(this._reportParameters[i].Value)) + "'";
                        else
                            criteria += this._reportParameters[i].FieldName + " " + this._reportParameters[i].Comparision + " " + this._reportParameters[i].Value;
                    }
                }
                return criteria;
            }
        }
        public string ReportHeadWithValues
        {
            get
            {
                string header;
                if (this._reportHead == null)
                    header = string.Empty;
                else
                    header = this._reportHead;

                if (this._reportParameters != null)
                {
                    for (int i = 0; i < this._reportParameters.Count; i++)
                    {
                        if (this._reportParameters[i].IncInHd)
                        {
                            if (this._reportParameters[i].ControlType == "System.Windows.Forms.DateTimePicker")
                            {
                                header += (this._reportParameters[i].Description + ": " + ((System.Windows.Forms.DateTimePicker)this._reportParameters[i].Control).Text + " ");
                            }
                            else if (this._reportParameters[i].ControlType == "DevExpress.XtraEditors.LookUpEdit")
                            {
                                header += (this._reportParameters[i].Description + ": " + ((DevExpress.XtraEditors.LookUpEdit)this._reportParameters[i].Control).Text + " ");
                            }
                            else
                            {
                                header += (this._reportParameters[i].Description + ": " + this._reportParameters[i].Value + " ");
                            }
                        }
                    }
                }
                return header;
            }
        }
            
        #endregion

        public clReport(int reportId, string connString)
        {
            this._connString = connString;
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(this._connString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblReports WHERE RepId=" + reportId;
                Ds = DataObj.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = Ds.Tables[0].Rows[0];
                    this._repId = Convert.ToInt32(row["RepId"]);
                    this._repName = Convert.ToString(row["RepName"]);
                    this._repNameAmharic = Convert.ToString(row["RepNameAmharic"]);
                    this._reportFileName = Convert.ToString(row["ReportFileName"]);
                    this._dataObjType = Convert.ToString(row["DataObjType"]);
                    this._dataObjName = Convert.ToString(row["DataObjName"]);
                    if(row["Criteria"] != null && !Convert.IsDBNull(row["Criteria"]))
                        this._criteria = Convert.ToString(row["Criteria"]);
                    if (row["SortBy"] != null && !Convert.IsDBNull(row["SortBy"]))
                        this._sortBy = Convert.ToString(row["SortBy"]);
                    if (row["ReportHead"] != null && !Convert.IsDBNull(row["ReportHead"]))
                        this._reportHead = Convert.ToString(row["ReportHead"]);

                    this.GetParameters();

                    this.GetSubReports();


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

        private bool GetParameters()
        {
            clReportParameter repParameter;
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(this._connString);
            try
            {
                this._reportParameters = new List<clReportParameter>();
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblReportParameter WHERE RepId=" + this._repId;
                Ds = DataObj.GetDataSet(cmdText);
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    repParameter = new clReportParameter();
                    repParameter.RepId = Convert.ToInt32(row["RepId"]);
                    repParameter.ParamId = Convert.ToInt32(row["ParamId"]);
                    repParameter.Description = Convert.ToString(row["Description"]);
                    repParameter.FieldName = Convert.ToString(row["FieldName"]);
                    if (row["Comparision"] != null && !Convert.IsDBNull(row["Comparision"]))
                        repParameter.Comparision = Convert.ToString(row["Comparision"]);
                    if (row["Conjunction"] != null && !Convert.IsDBNull(row["Conjunction"]))
                        repParameter.Conjunction = Convert.ToString(row["Conjunction"]);
                    repParameter.DataType = Convert.ToString(row["DataType"]);
                    repParameter.IncInHd = Convert.ToBoolean(row["IncInHd"]);
                    repParameter.ControlType = Convert.ToString(row["ControlType"]);

                    if (repParameter.ControlType == "DevExpress.XtraEditors.LookUpEdit")
                    {
                        if (row["DisplayMember"] != null && !Convert.IsDBNull(row["DisplayMember"]))
                            repParameter.DisplayMember = Convert.ToString(row["DisplayMember"]);
                        if (row["ValueMember"] != null && !Convert.IsDBNull(row["ValueMember"]))
                            repParameter.ValueMember = Convert.ToString(row["ValueMember"]);
                        if (row["DataSource"] != null && !Convert.IsDBNull(row["DataSource"]))
                            repParameter.DataSource = Convert.ToString(row["DataSource"]);
                        if (row["DataSourceType"] != null && !Convert.IsDBNull(row["DataSourceType"]))
                            repParameter.DataSourceType = Convert.ToString(row["DataSourceType"]);
                        if (row["ListFields"] != null && !Convert.IsDBNull(row["ListFields"]))
                            repParameter.ListFields = Convert.ToString(row["ListFields"]);
                        else
                            repParameter.ListFields = string.Empty;
                    }

                    this._reportParameters.Add(repParameter);
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

        public bool GetParameterValues()
        {
            return this.GetParameterValues(false);
        }

        public bool GetParameterValues(bool checkValues)
        {
            
            string checkValueMsg; 
            try
            {
                if (this._reportParameters == null)
                    return true;

                for (int i = 0; i < this._reportParameters.Count; i++)
                {
                    switch (this._reportParameters[i].ControlType)
                    {
                        case "System.Windows.Forms.TextBox":
                            if (((System.Windows.Forms.TextBox)this._reportParameters[i].Control).Text == string.Empty)
                                this._reportParameters[i].Value = null;
                            else
                                this._reportParameters[i].Value = ((System.Windows.Forms.TextBox)this._reportParameters[i].Control).Text;
                            break;
                        case "System.Windows.Forms.DateTimePicker":
                            if (((System.Windows.Forms.DateTimePicker)this._reportParameters[i].Control).Text == string.Empty)
                                this._reportParameters[i].Value = null;
                            else
                            {
                                
                              this._reportParameters[i].Value = (( System.Windows.Forms.DateTimePicker)this._reportParameters[i].Control).Text;
                            }
                            break;
                        case "DevExpress.XtraEditors.LookUpEdit":
                            this._reportParameters[i].Value = ((DevExpress.XtraEditors.LookUpEdit)this._reportParameters[i].Control).EditValue;
                            break;
                        default:
                            this._reportParameters[i].Value = null;
                            break;
                    }
                }
                if (checkValues)
                {
                    checkValueMsg = this.CheckParameterValues(); ;
                    if (checkValueMsg != string.Empty)
                    {
                        MessageBox.Show(checkValueMsg, "iCMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                //this.GetSubReportParameterValues();
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public string CheckParameterValues()
        {
            string result = string.Empty;
            try
            {
                for (int i = 0; i < this._reportParameters.Count; i++)
                {
                    if(this._reportParameters[i].Value == null || Convert.IsDBNull(this._reportParameters[i]))
                        result = result + " - " + this._reportParameters[i].Description + "\n";
                }
                if (result != string.Empty)
                {
                    result = "Please enter valid:\n\n" + result;
                }
                return result;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
        }

        public bool RefreshParameterValues()
        {
            try
            {
                for (int i = 0; i < this._reportParameters.Count; i++)
                {
                    switch (this._reportParameters[i].ControlType)
                    {
                        case "System.Windows.Forms.TextBox":
                            ((System.Windows.Forms.TextBox)this._reportParameters[i].Control).Text = string.Empty;
                            this._reportParameters[i].Value = null;
                            break;
                        case "System.Windows.Forms.DateTimePicker":
                            ((System.Windows.Forms.DateTimePicker)this._reportParameters[i].Control).Text = string.Empty;
                            this._reportParameters[i].Value = null;
                            break;
                        case "DevExpress.XtraEditors.LookUpEdit":
                            ((DevExpress.XtraEditors.LookUpEdit)this._reportParameters[i].Control).EditValue = null;
                            this._reportParameters[i].Value = null;
                            break;
                        default:
                            this._reportParameters[i].Value = null;
                            break;
                    }
                }
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public bool GetSubReports()
        {
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(this._connString);
            try
            {
                this._subReports = new List<clSubReport>();
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblSubReports WHERE RepId=" + this._repId;
                Ds = DataObj.GetDataSet(cmdText);
                clSubReport subRep;
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    subRep = new clSubReport();
                    subRep.RepId = Convert.ToInt32(row["RepId"]);
                    subRep.SubRepId = Convert.ToString(row["SubRepId"]);
                    subRep.DataObjType = Convert.ToString(row["DataObjType"]);
                    subRep.DataObjName = Convert.ToString(row["DataObjName"]);

                    if (row["Criteria"] != null && !Convert.IsDBNull(row["Criteria"]))
                        subRep.Criteria = Convert.ToString(row["Criteria"]);
                    if (row["SortBy"] != null && !Convert.IsDBNull(row["SortBy"]))
                        subRep.SortBy = Convert.ToString(row["SortBy"]);

                    this._subReports.Add(subRep);
                }

                //this.GetSubReportParameters();

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

        private bool GetSubReportParameters()
        {
           
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(this._connString);
            try
            {
                
                DataObj.OpenConnection();
                clSubReportParameter subRepParameter;
                for ( int i=0; i < this._subReports.Count; i++)
                {
                    this._subReports[i].SubReportParameters = new List<clSubReportParameter>();
                    cmdText = "SELECT * FROM tblSubReportParameter WHERE RepId=" + this._subReports[i].RepId + " AND SubRepId='" + this._subReports[i].SubRepId + "'";
                    Ds = DataObj.GetDataSet(cmdText);
                    foreach (DataRow row in Ds.Tables[0].Rows)
                    {
                        subRepParameter = new clSubReportParameter();
                        subRepParameter.RepId = Convert.ToInt32(row["RepId"]);
                        subRepParameter.SubRepId = Convert.ToString(row["SubRepId"]);
                        subRepParameter.SubRepParamId = Convert.ToInt32(row["SubRepParamId"]);
                        subRepParameter.ParamId = Convert.ToInt32(row["ParamId"]);
                        subRepParameter.FieldName = Convert.ToString(row["FieldName"]);
                        if (row["Comparision"] != null && !Convert.IsDBNull(row["Comparision"]))
                            subRepParameter.Comparision = Convert.ToString(row["Comparision"]);
                        if (row["Conjunction"] != null && !Convert.IsDBNull(row["Conjunction"]))
                            subRepParameter.Conjunction = Convert.ToString(row["Conjunction"]);
                        subRepParameter.DataType = Convert.ToString(row["DataType"]);

                        this._subReports[i].SubReportParameters.Add(subRepParameter);
                    }
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

        public bool GetSubReportParameterValues()
        {
            if (this._subReports == null) 
                return false;
            try
            {
                for (int j = 0; j < this._subReports.Count; j++)
                {
                    if (this._subReports[j].SubReportParameters == null)
                        continue;
                    for (int i = 0; i < this._subReports[j].SubReportParameters.Count; i++)
                    {
                        for(int k=0; k < this._reportParameters.Count; k++)
                        {
                            if (this._subReports[j].SubReportParameters[i].ParamId == this._reportParameters[k].ParamId)
                                this._subReports[j].SubReportParameters[i].Value = this._reportParameters[k].Value;
                            break;
                        }
                    }

                }
                this.SetSubReportCriteriaWithValues();
                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
        }

        public bool SetSubReportCriteriaWithValues()
        {
            string criteria;
            if (this._subReports == null)
                return true;
            for(int i = 0; i < this._subReports.Count; i++)
            {           
                if (this._subReports[i].Criteria == null)
                    criteria = string.Empty;
                else
                    criteria = this._subReports[i].Criteria;

                //if (this._subReports[i].SubReportParameters != null)
                //{
                //    for (int j = 0; j < this._reportParameters.Count; j++)
                //    {
                //        if (criteria != string.Empty)
                //            criteria += " AND ";
                //        if (this._subReports[i].SubReportParameters[j].DataType == "varchar")
                //            criteria += this._subReports[i].SubReportParameters[j].FieldName + " " + this._subReports[i].SubReportParameters[j].Comparision + " '" + this._subReports[i].SubReportParameters[j].Value + "'";
                //        else if (this._reportParameters[j].DataType == "datetime")
                //            criteria += this._subReports[i].SubReportParameters[j].FieldName + " " + this._subReports[i].SubReportParameters[j].Comparision + " '" + HillUtility.ToMDYDate(Convert.ToDateTime(this._subReports[i].SubReportParameters[j].Value)) + "'";
                //        else
                //            criteria += this._subReports[i].SubReportParameters[j].FieldName + " " + this._subReports[i].SubReportParameters[j].Comparision + " " + this._subReports[i].SubReportParameters[j].Value;
                //    }
                //    this._subReports[i].CriteriaWithValues = criteria;
                //}
            }
            return true;
        }

    }

    public class clSubReport
    {
        #region Fields
        private int _repId;
        private string _subRepId;
        private string _dataObjType;
        private string _dataObjName;
        private string _criteria;
        private string _sortBy;
       
        private List<clSubReportParameter> _subReportParameters;
        #endregion

        #region Properties
        public int RepId
        {
            get { return this._repId; }
            set { this._repId = value; }
        }
        public string SubRepId
        {
            get { return this._subRepId; }
            set { this._subRepId = value; }
        }
        public string DataObjType
        {
            get { return this._dataObjType; }
            set { this._dataObjType = value; }
        }
        public string DataObjName
        {
            get { return this._dataObjName; }
            set { this._dataObjName = value; }
        }
        public string Criteria
        {
            get { return this._criteria; }
            set { this._criteria = value; }
        }
        public string SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }
        public string CriteriaWithValues
        {
            //get { return this._criteriaWithValues; }
            get
            {
                string criteria;
                if (this._criteria == null)
                    criteria = string.Empty;
                else
                    criteria = this._criteria;

                return criteria;
            }
          
        }
        public List<clSubReportParameter> SubReportParameters
        {
            get { return this._subReportParameters; }
            set { this._subReportParameters = value; }
        }
        #endregion

        

        

    }

    public class clReportParameter
    {
        #region Fields
        public static readonly char ListFieldSeparator = Convert.ToChar("^");
        private int _repId;
        private int _paramId;
        private string _description;
        private string _fieldName;
        private string _comparision;
        private string _conjunction;
        private string _dataType;
        private bool _incInHd;
        private string _controlType;

        private string _displayMember;
        private string _valueMember;
        private string _dataSource;
        private string _dataSourceType;
        private string _listFields;

        private Control _control;
        private object _value;
        #endregion

        #region Properties
        public int RepId
        {
            get { return this._repId; }
            set { this._repId = value; }
        }
        public int ParamId
        {
            get { return this._paramId; }
            set { this._paramId = value; }
        }
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        public string FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }
        public string Comparision
        {
            get { return this._comparision; }
            set { this._comparision = value; }
        }
        public string Conjunction
        {
            get { return this._conjunction; }
            set { this._conjunction = value; }
        }
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }
        public bool IncInHd
        {
            get { return this._incInHd; }
            set { this._incInHd = value; }
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
        public object Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        #endregion

    }

    public class clSubReportParameter
    {
        #region Fields
        public static readonly char ListFieldSeparator = Convert.ToChar("^");
        private int _repId;
        private string _subRepId;
        private int _subRepParamId;
        private int _paramId;
        private string _fieldName;
        private string _comparision;
        private string _conjunction;
        private string _dataType;

        private Control _control;
        private object _value;
        #endregion

        #region Properties
        public int RepId
        {
            get { return this._repId; }
            set { this._repId = value; }
        }
        public string SubRepId
        {
            get { return this._subRepId; }
            set { this._subRepId = value; }
        }
        public int SubRepParamId
        {
            get { return this._subRepParamId; }
            set { this._subRepParamId = value; }
        }
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
        public string Comparision
        {
            get { return this._comparision; }
            set { this._comparision = value; }
        }
        public string Conjunction
        {
            get { return this._conjunction; }
            set { this._conjunction = value; }
        }
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }
        
        public Control Control
        {
            get { return this._control; }
            set { this._control = value; }
        }
        public object Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        #endregion

    }

   

}

