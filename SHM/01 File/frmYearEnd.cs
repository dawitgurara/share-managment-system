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
    public partial class frmYearEnd : Form
    {
        
        #region Fields
        private string _title = "Year End";
        

        private string _fiscalYear = "0";

        
        private DataTable _tblFiscalYear;

        private DataTable _tblFiscalYearPrev;
        private DataTable _tblAuditLog;
        private DataRow _AuditLog;




        #endregion

        #region Properties
        
        #endregion

        public frmYearEnd()
        {

            InitializeComponent();
        }

        private void frmYearEnd_Load(object sender, EventArgs e)
        {

            BindControls();
            InitForm(true);
           
          
        }

        private void frmYearEnd_KeyDown(object sender, KeyEventArgs e)
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

                

                this._tblFiscalYearPrev = DataObj.GetDataTable("tblGeneralParameters");
                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;

                
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


                    DataObj.FillData(this._tblFiscalYear, "select  * from ViewFiscalYears where Closed=0 order by FiscalYear desc");
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

        private bool InsertAuditlog(DataRow _DividendParameters)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this._tblFiscalYearPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();

                    if (this._tblFiscalYearPrev.Rows[0]["TotalAmntForDividend"].ToString().Trim() != _DividendParameters["TotalAmntForDividend"].ToString().ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblFiscalYears";
                        this._AuditLog["KeyFld"] = "FiscalYear";
                        this._AuditLog["KeyFldValue"] = this._fiscalYear;
                        this._AuditLog["ActionTaken"] = "Year End Transacton and closing the current fiscal year";
                        this._AuditLog["FldChged"] = "TotalAmntForDividend";
                        this._AuditLog["OldValue"] = 0;
                        this._AuditLog["NewValue"] = 1;
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

        private void budgetYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.FiscalYearLookUpEdit.EditValue != null && !Convert.IsDBNull(this.FiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = Convert.ToString(this.FiscalYearLookUpEdit.EditValue);
               
            }
        }

        private void btnYearEnd_Click(object sender, EventArgs e)
        {




            if (AppMessageBox.ShowQuestion("Are you sure you want to do Year ?") == DialogResult.Yes)
            {
                
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            DataSet ds = new DataSet();
            DataRow dr;
           


            string cmdText = "";
            bool success=false;

            try
            {
               

                if (this._fiscalYear == "0")
                {
                    AppMessageBox.ShowExclamation("Please select Fiscal year");
                    return;
                }


                DataObj.OpenConnection();
                DataObj.BeginTransaction();
                cmdText = "update tblNameValueParameter set ParameterValue= convert(int,ParameterValue)+1 where ParameterName in ('GFRRCounter','LFRRCounter')";
                success = DataObj.Execute(cmdText);
                if (success)
                 {
                     cmdText = "update tblFiscalYears set Closed= 1";
                     success = DataObj.Execute(cmdText);
                     if (success)
                      {
                         success = clUtility.OpenNewBudgetYear(this._fiscalYear, ref DataObj);
                         if(success)
                          {
                             ds = DataObj.GetDataSet("select SHId,SubscribedShareNoModif,SubscribedShareAmtModif,PaidUpNoofShare,PaidUpShareAmt from tblShareRegBook where PaidUpShareAmt>=1000");
                             if (ds.Tables[0].Rows.Count > 0)
                              {

                                 for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                  {
                                    dr = ds.Tables[0].Rows[i];

                                    this.statusLabel.Text = "Archiving Registration book and Shareholder Details of  " + Convert.ToString(dr["SHId"]);
                                    Application.DoEvents();
                                    cmdText = "delete from tblShareRegBookYtd where SHId=" + Convert.ToInt32(dr["SHId"]) + " and FiscalYear='" + this._fiscalYear + "'";

                                     success = DataObj.Execute(cmdText);


                                     if (success)
                                     {

                                       cmdText = "insert into tblShareRegBookYtd(FiscalYear,SHId,SubscribedShareNoModif,SubscribedShareAmtModif,PaidUpNoofShare,PaidUpShareAmt,CrtBy)" +
                                       "Values('" + this._fiscalYear + "'," + Convert.ToInt32(dr["SHId"]) + "," + Convert.ToDecimal(dr["SubscribedShareNoModif"]) + "," + Convert.ToDecimal(dr["SubscribedShareAmtModif"]) + "," + Convert.ToDecimal(dr["PaidUpNoofShare"]) + "," + Convert.ToDecimal(dr["PaidUpShareAmt"]) + ",'" + clMain.User.UserName + "')";
                                        success = DataObj.Execute(cmdText);

                                     }
                                     else
                                     {
                                         DataObj.RollbackTransaction();

                                         AppMessageBox.ShowInformation("Year End transaction is failed");
                                         return;
                                     }
                                    


                                   }
                                 if (success)
                                 {
                                     DataObj.CommitTransaction();

                                     AppMessageBox.ShowInformation("Year End transaction is completed successfully");
                                     this.btnYearEnd.Enabled = false;

                                 }
                                 else
                                 {
                                     DataObj.RollbackTransaction();

                                     AppMessageBox.ShowInformation("Year End transaction is failed");
                                     return;
                                 }


                               }
                                
                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Year End transaction is failed");
                            }
                        }
                        else
                        {
                            DataObj.RollbackTransaction();
                            AppMessageBox.ShowInformation("Year End transaction is failed");
                        }
                    }
                    else
                    {
                        DataObj.RollbackTransaction();
                        AppMessageBox.ShowInformation("Year End transaction is failed");
                    }
                

            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.RollbackTransaction();
                DataObj.CloseConnection();
            }
            finally
            {
                DataObj.CloseConnection();

            }
        }
      }

        
    }
}

