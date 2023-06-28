using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace SHM
{
    public class clReportConfig
    {
     #region Fields
        private string _rptFileName;
        private string _dataObjName;
        private bool _isProcedure = false;
        private string _criteria = string.Empty;
        private List<SqlParameter> _dataParameters;
        private DataSet _rptDataSet = new DataSet();
        private string _rptTitle = "Report";
        private bool _displayGroupTree = false;
        private List<clSubReportConfig> _subConfigs;
        private ReportDocument _rptDoc;
        #endregion

        #region Properties
        public string ReportFileName
        {
            get { return this._rptFileName; }
        }
        public string DataObjectName
        {
            get { return this._dataObjName; }
        }
        public bool IsProcedure
        {
            get { return this._isProcedure; }
        }
       
        public string Criteria
        {
            get { return this._criteria; }
            set { this._criteria = value; }
        }
        public List<SqlParameter> DataParameters
        {
            get { return this._dataParameters; }
            set { this._dataParameters = value; }
        }
        public string ReportTitle
        {
            get { return this._rptTitle; }
        }
        public bool DisplayGroupTree
        {
            get { return this._displayGroupTree; }
        }
        public List<clSubReportConfig> SubConfigs
        {
            get { return this._subConfigs; }
        }
        public ReportDocument ReportDoc
        {
            get { return this._rptDoc; }
        }
        #endregion

        #region Methods
        public clReportConfig(string reportFileName, string dataObjectName)
        {
            this.InitConfiguration(reportFileName, dataObjectName, this._isProcedure);
        }
        public clReportConfig(string reportFileName, string dataObjectName, bool isProcedure)
        {
            this.InitConfiguration(reportFileName, dataObjectName, isProcedure);
        }
        public clReportConfig(string reportFileName, string dataObjectName, bool isProcedure, out Exception exception)
        {
            this.InitConfiguration(reportFileName, dataObjectName, isProcedure,  out exception);
        }
        private void InitConfiguration(string reportFileName, string dataObjectName, bool isProcedure,  out Exception exception)
        {
            try
            {
                this._rptFileName = reportFileName;
                this._dataObjName = dataObjectName;
                this._isProcedure = isProcedure;
               
                this._dataParameters = new List<SqlParameter>();
                this._subConfigs = new List<clSubReportConfig>();
                if (!this._rptFileName.EndsWith(".rpt")) this._rptFileName += ".rpt";
                this._rptDoc = new ReportDocument();
                this._rptDoc.Load(this._rptFileName);
                exception = null;
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message);
                exception = Ex;
            }
        }

        private void InitConfiguration(string reportFileName, string dataObjectName, bool isProcedure)
        {
            try
            {
                this._rptFileName = reportFileName;
                this._dataObjName = dataObjectName;
                this._isProcedure = isProcedure;
               
                this._dataParameters = new List<SqlParameter>();
                this._subConfigs = new List<clSubReportConfig>();
                if (!this._rptFileName.EndsWith(".rpt")) this._rptFileName += ".rpt";
                this._rptDoc = new ReportDocument();
                this._rptDoc.Load(this._rptFileName);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private bool GetDataSet()
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
                if (this._criteria.Trim() != string.Empty) 
                    cmdText += " WHERE " + this._criteria;
                Adpt.SelectCommand.CommandText = cmdText;
            }

            if (this._rptDataSet.Tables[this._dataObjName] != null) this._rptDataSet.Tables[this._dataObjName].Clear();
            
            Adpt.Fill(this._rptDataSet, this._dataObjName);
            return true;
        }

        private void SetReportData()
        {
            this.GetDataSet();
            if (this._subConfigs != null)
            {
                foreach (clSubReportConfig subConfig in this._subConfigs)
                {
                    subConfig.GetSubReportData(ref this._rptDataSet);
                }
            }
            this._rptDoc.SetDataSource(this._rptDataSet);
        }

        public void PrintReport(int nCopies, bool collated, int startPageN, int endPageN)
        {
            this.SetReportData();
            this._rptDoc.PrintToPrinter(nCopies, collated, startPageN, endPageN);
        }

        public void PreviewReport(string reportTitle, bool displayGroupTree)
        {
            this.SetReportData();
            this._rptTitle = reportTitle;
            this._displayGroupTree = displayGroupTree;
        }
        #endregion

    }
}

