using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SHM
{
   public class clSubReportConfig
    {
        #region Fields
        private string _subRptName;
        private string _dataObjName;
        private bool _isProcedure = false;
       
        private string _criteria = string.Empty;
        private List<SqlParameter> _dataParameters;
        #endregion

        #region Properties
        public string SubReportName
        {
            get { return _subRptName; }
        }
        public string DataObjectName
        {
            get { return _dataObjName; }
        }
        public bool IsProcedure
        {
            get { return _isProcedure; }
        }
       
        public string Criteria
        {
            get { return _criteria; }
            set { _criteria = value; }
        }
        public List<SqlParameter> DataParameters
        {
            get { return _dataParameters; }
            set { _dataParameters = value; }
        }
        #endregion

        #region Methods
        public clSubReportConfig(string subReportName, string dataObjectName)
        {
            this.InitSubConfiguration(subReportName, dataObjectName, this._isProcedure);
        }
        public clSubReportConfig(string subReportName, string dataObjectName, bool isProcedure)
        {
            this.InitSubConfiguration(subReportName, dataObjectName, isProcedure);
        }
        private void InitSubConfiguration(string subReportName, string dataObjectName, bool isProcedure)
        {
            this._subRptName = subReportName;
            this._dataObjName = dataObjectName;
            this._isProcedure = isProcedure;
            this._dataParameters = new List<SqlParameter>();
        }

        public bool GetSubReportData(ref DataSet mainRptDataSet)
        {
            string cmdText = string.Empty;
            SqlConnection Conn = new SqlConnection(clMain.ConnString);
            SqlDataAdapter Adpt = new SqlDataAdapter(cmdText, Conn);

            if (this._dataObjName.Trim() == string.Empty) return false;

            if (this._isProcedure)
            {
                Adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adpt.SelectCommand.CommandText = this._dataObjName;
                Adpt.SelectCommand.Parameters.AddRange(this._dataParameters.ToArray());
            }
            else
            {
                Adpt.SelectCommand.CommandType = CommandType.Text;
                cmdText = "SELECT * FROM " + this._dataObjName;
                if (this._criteria != null && this._criteria.Trim() != string.Empty) 
                    cmdText += " WHERE " + this._criteria;
                Adpt.SelectCommand.CommandText = cmdText;
            }

            if (mainRptDataSet.Tables[this._dataObjName] != null) mainRptDataSet.Tables[this._dataObjName].Clear();
            Adpt.Fill(mainRptDataSet, this._dataObjName);
            return true;
        }
        #endregion

    }
}