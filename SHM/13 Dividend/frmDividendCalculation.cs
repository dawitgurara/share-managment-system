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
    public partial class frmDividendCalculation : Form
    {
        #region Fields

       
        private bool _CalculationStarted = false;
        private readonly int _normalFormHeight = 280;
        private readonly int _HieghtAfterCompletionCalc = 604;
       
        private DateTime _StartDate;
        private DateTime _EndDate;
        private DataTable _tblDividendEntitledList;


        
       

        private string _fiscalYear = "0";
        
        private DataTable _tblFiscalYear;
        private List<decimal> _DividendList = new List<decimal>();

        
        #endregion

        #region Properties
        public bool CalculationStarted
        {
            get { return this._CalculationStarted; }
            set
            {
                this._CalculationStarted = value;
                this.SetControlsProperties(!this._CalculationStarted);
            }
        }
        #endregion

        public frmDividendCalculation()
        {
            InitializeComponent();
        }

        private void frmDividendCalculation_Load(object sender, EventArgs e)
        {
            this.Height = _HieghtAfterCompletionCalc;
            BindControls();
            InitForm(true);
        }

        private void frmDividendCalculation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._CalculationStarted)
                e.Cancel = true;
        }

        private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                DataObj.OpenConnection();
               
                this._tblFiscalYear = DataObj.GetDataTable("ViewFiscalYears");
                this._tblDividendEntitledList = DataObj.GetDataTable("tblDividendEntitled");
                this._tblDividendEntitledList.Columns["CrtDt"].ReadOnly = true;
                this._tblDividendEntitledList.Columns["CrtWs"].ReadOnly = true;



                clMain.SetDataSource(this.gctDividendEntitled, this._tblDividendEntitledList);
               
                clMain.SetDataSource(this.budgetYearLookUpEdit, this._tblFiscalYear);
                

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
                if (All)
                {
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblFiscalYear, "SELECT top 1 a.FiscalYear,a.StartDate, a.EndDate FROM tblFiscalYears as a inner join tblShareRegBookYtd as b on a.FiscalYear=b.FiscalYear order by a.FiscalYear desc");
                    

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

        private void SetControlsProperties(bool value)
        {

            this.startButton.Enabled = value;
            this.cancelButton.Enabled = value;
            if (value)
                this.statusLabel.Text = "Ready";
            else
                this.statusLabel.Text = "Calculating...";
        }

        private void StartDividenedCalculationAndUpdate() 
        {
            

            
                clDatacon DataObj = new clDatacon(clMain.ConnString);
               
                DataSet ds = new DataSet();
                DataRow dr;
                List<decimal> DividendList = new List<decimal>();
               

                string cmdText = "";
                decimal RemainingDividend = 0;
                
                try
                {
                    DataObj.OpenConnection();
                   
                    if (this._fiscalYear == "0")
                    {
                        AppMessageBox.ShowExclamation("Please select Fiscal year");
                        return;
                    }



                    ds = DataObj.GetDataSet("select a.SHId,a.IsLBFounder,a.IsGBFounder,a.RegCode,a.FullName,b.PaidUpNoofShare,b.PaidUpShareAmt from tblShareholderDetail as a inner join tblShareRegBookYtd as b on a.SHId= b.SHId where b.FiscalYear='" + this._fiscalYear+"'");
                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                dr = ds.Tables[0].Rows[i];
                                
                                this.statusLabel.Text = "Calculating Dividend For " + Convert.ToString(dr["RegCode"]) + " - " + Convert.ToString(dr["FullName"]);
                                Application.DoEvents();
                                cmdText = "delete from tblDividendEntitled where SHId=" + Convert.ToInt32(dr["SHId"]) + " and FiscalYear='" + this._fiscalYear + "'";

                                DataObj.Execute(cmdText);


                                DividendList = clShareholder.GetDividendAmount(Convert.ToInt32(dr["SHId"]), Convert.ToDecimal(dr["PaidUpShareAmt"]), Convert.ToBoolean(dr["IsLBFounder"]), Convert.ToBoolean(dr["IsGBFounder"]), this._fiscalYear, this._StartDate, this._EndDate);

                                cmdText = "insert into tblDividendEntitled(FiscalYear,SHId,PaidupNoofShare,PaidupShareAmt,LFRRDiv,GFRRDiv,CommonDiv,DividendAmount,CrtBy)"+
                                "Values('" + this._fiscalYear + "'," + Convert.ToInt32(dr["SHId"]) + "," + Convert.ToDecimal(dr["PaidUpNoofShare"]) + "," + Convert.ToDecimal(dr["PaidUpShareAmt"]) + "," + DividendList[0] + "," + DividendList[1] +"," + DividendList[2] + ","+ DividendList[3] + ",'"+ clMain.User.UserName + "')";
                                DataObj.Execute(cmdText);
                              
                            }


                            if ((clShareholder.GetTotalCommonDividend(this._fiscalYear) - clShareholder.GetSumofCommonDividend(this._fiscalYear)) > 0)
                            {
                                ds.Clear();
                                ds = DataObj.GetDataSet("select a.SHId,a.IsLBFounder,a.IsGBFounder,a.RegCode,a.FullName,b.PaidUpNoofShare,b.PaidUpShareAmt from tblShareholderDetail as a inner join tblShareRegBookYtd as b on a.SHId= b.SHId where b.FiscalYear='" + this._fiscalYear + "'");

                                if (ds.Tables[0].Rows.Count > 0)
                                {

                                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                    {
                                        dr = ds.Tables[0].Rows[i];

                                        this.statusLabel.Text = "Calculating Remaining Dividend For " + Convert.ToString(dr["RegCode"]) + " - " + Convert.ToString(dr["FullName"]);
                                        Application.DoEvents();



                                        RemainingDividend = clShareholder.GetRemainingDividendAmount(Convert.ToDecimal(dr["PaidUpShareAmt"]), this._fiscalYear);

                                        cmdText = "Update tblDividendEntitled set RemainingDiv=" + RemainingDividend + ", DividendAmount=DividendAmount+" + RemainingDividend + " where FiscalYear='" + this._fiscalYear + "' and SHId=" + Convert.ToInt32(dr["SHId"]);

                                        DataObj.Execute(cmdText);

                                    }
                                }
                            }
                            AppMessageBox.ShowInformation("Dividend calculation completed successfully.");
                            this.statusLabel.Text = "Ready";
                            GetDividenedEntitledByFiscalYear(this._fiscalYear);
                        }



                    
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    DataObj.CloseConnection();
                }
                finally
                {
                    DataObj.CloseConnection();
                   
                }
            
        }

        private bool ValidateData()
        {

            if (this.budgetYearLookUpEdit.EditValue == null || DBNull.Value.Equals(this.budgetYearLookUpEdit.EditValue))
            {
                AppMessageBox.ShowError("Please select fisical year for dividend Calculation");
                return false;
            }
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            decimal totalAmountFordividend;
            try
            {
                DataObj.OpenConnection();
                totalAmountFordividend = clShareholder.GetTotalAmntForDividend(this._fiscalYear);
                if (totalAmountFordividend == 0)
                {
                    AppMessageBox.ShowExclamation("You didn't set Total Amount for Dividend  for the selected budget year.Please go to the Setup menu,click Dividend Parameter submenu   and enter total amount for dividend for the selected budget year.");
                    return false;
                }
                else
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

        private void budgetYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.budgetYearLookUpEdit.EditValue == null || Convert.IsDBNull(this.budgetYearLookUpEdit.EditValue))
                this._fiscalYear = "0";
            else
            {
                this._fiscalYear = Convert.ToString(this.budgetYearLookUpEdit.EditValue);
                this._StartDate = Convert.ToDateTime(this.budgetYearLookUpEdit.GetColumnValue("StartDate"));
                this._EndDate = Convert.ToDateTime(this.budgetYearLookUpEdit.GetColumnValue("EndDate"));
                GetDividenedEntitledByFiscalYear(this._fiscalYear);

            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Height = _HieghtAfterCompletionCalc;
            if (!ValidateData()) return;
            this.CalculationStarted = true;
            this.StartDividenedCalculationAndUpdate();
            this.CalculationStarted = false;
            this.Height = _HieghtAfterCompletionCalc;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetDividenedEntitledByFiscalYear(string fiscalyear)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                
                DataObj.OpenConnection();

                DataObj.FillData(this._tblDividendEntitledList, "SELECT a.*, round(convert(decimal(8,2),(a.DividendAmount*0.1)),2) as Tax,round(convert(decimal(10,2),(a.DividendAmount-a.DividendAmount*0.1)),2)as NetDividend,b.RegCode,b.IsLBFounder,b.IsGBFounder FROM tblDividendEntitled as a inner join tblShareholderDetail as b on a.SHId=b.SHId where a.FiscalYear='" + fiscalyear + "'");



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
            

      
       

       

       
       
       
        
       
    }
}
