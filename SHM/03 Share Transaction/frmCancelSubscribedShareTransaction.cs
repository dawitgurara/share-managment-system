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
    public partial class frmCancelSubscribedShareTransaction : Form
    {
        #region Fields
        private string _title = "Cancel Subscribed Share";
        private bool _isNew = true;
        private bool _isLoadingEntry = false;

        private int _SHId = 0;
        private int _TrnId = 0;
        
       

       
        private string _EffectiveDate = string.Empty;
        private DataTable _tblShareSubscribing;
        private DataRow _ShareSubscribing;
        private DataTable _tblShareSubscribingList;

        private DataTable _tblCancelShareSubscribingTransaction;
        private DataRow _CancelShareSubscribingTransaction;
        private DataTable _tblCancelShareSubscribingTransactionList;
       

        private DataTable _tblShareRegBookList;
       
        private DataTable _tblShareholderDetailList;

        private DataTable _tblShareRegBook;
        //private DataRow _ShareRegBook;

        private DataTable _tblShareRegBookPrev;
      

        private DataTable _tblAuditLog;
        private DataRow _AuditLog;

        #endregion

        public frmCancelSubscribedShareTransaction()
        {
            InitializeComponent();
            
        }

        private void frmCancelSubscribedShareTransaction_Load(object sender, EventArgs e)
        {

            this.SbscribtionDetailGroupBox.Enabled = false;
            BindControls();
            InitForm(true);
            
            BindControlsSH();
            InitFormSH(true);
        }

        private void frmCancelSubscribedShareTransaction_KeyDown(object sender, KeyEventArgs e)
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
                
                //this._tblShareholderDetailList = DataObj.GetDataTable("tblShareholderDetail");
                this._tblShareholderDetailList = new DataTable("tblShareholderDetail");
                this._tblShareholderDetailList.Columns.Add("SHId", typeof(int));
                this._tblShareholderDetailList.Columns.Add("RegCode", typeof(string));
                this._tblShareholderDetailList.Columns.Add("FullName", typeof(string));
                this._tblShareholderDetailList.Columns.Add("SHRegCodeWithName", typeof(string));

                this._tblShareSubscribingList = DataObj.GetDataTable("tblShareSubscribing");
                this._tblCancelShareSubscribingTransactionList = DataObj.GetDataTable("tblCancelShareSubscribingTransaction");
                this._tblShareRegBookPrev = DataObj.GetDataTable("tblShareRegBook");
                clMain.SetDataSource(this.SHIdLookUpEdit, this._tblShareholderDetailList);


                this._tblShareRegBook = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBook.Columns["CrtDt"].ReadOnly = true;
                this._tblShareRegBook.Columns["CrtWs"].ReadOnly = true;

                this._tblCancelShareSubscribingTransaction = DataObj.GetDataTable("tblCancelShareSubscribingTransaction");
                this._tblCancelShareSubscribingTransaction.Columns["CrtDt"].ReadOnly = true;
                this._tblCancelShareSubscribingTransaction.Columns["CrtWs"].ReadOnly = true;

                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;

                this._tblShareRegBookPrev = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBookList = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareSubscribing = DataObj.GetDataTable("tblShareSubscribing");
                this._tblShareSubscribing.Columns["CrtDt"].ReadOnly = true;
                this._tblShareSubscribing.Columns["CrtWs"].ReadOnly = true;
                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                this.SHIdLookUpEdit,
                this.EffectiveDateDateTimePicker,
                this.EffectiveDateEthTextBox,
                this.NoofShareSoldTextBox,
                this.AmntofShareSoldTextBox
               
                   
                });

                    clMain.BindControls(cntrsList, this._tblShareSubscribing);
                    cntrsList.Clear();

                    clMain.SetDataSource(this.gctShareSubscribe, this._tblShareSubscribingList);
                    clMain.SetDataSource(this.gctCancelSubscrb, this._tblCancelShareSubscribingTransactionList);

                    clMain.SetDataSource(this.gctSHRegBook, this._tblShareRegBookList);

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
                    DataObj.FillData(this._tblShareholderDetailList, clShareholder.GetShareholderBrowseSql(true));
                    clMain.SetSearchBy(this.SHIdLookUpEdit, this.searchByComboBox);

                    
                   
                }

                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId="+this._SHId);
                GetShareholderSubscribeHistory(this._SHId);
               
               
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshToolStripButton_Click(this, new EventArgs());
            }
        }

        private void CancelToolStripButton_Click(object sender, EventArgs e)
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
           
            try
            {
                if (AppMessageBox.ShowQuestion("If you cancel the subscribed share, all related transactions will be reversed. Are you sure you want to Cancel it?") == DialogResult.Yes)
                {
                    if (this.Validate())
                    {
                        if (this._SHId == 0)
                        {
                            AppMessageBox.ShowExclamation("Please select a shareholder");
                            return;
                        }

                        DataObj.OpenConnection();
                        DataObj.BeginTransaction();
                        this._CancelShareSubscribingTransaction = this._tblCancelShareSubscribingTransaction.Rows[0];
                        this._ShareSubscribing = this._tblShareSubscribing.Rows[0];


                        if (DataObj.Insert(this._title, this._CancelShareSubscribingTransaction, false))
                        {
                            if (UpdateShareRegBook(DataObj))
                            {
                                if (InsertAuditlog(this._ShareSubscribing, DataObj))
                                {
                                    DataObj.CommitTransaction();
                                    AppMessageBox.ShowInformation("Canceling subscription transaction is saved successfully");
                                }
                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Canceling share subscription transaction is failed");
                                }
                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Canceling share subscription transaction is failed");
                            }

                        }
                        else
                        {
                            DataObj.RollbackTransaction();
                            AppMessageBox.ShowInformation("Canceling share subscription transaction is failed");
                        }


                        InitForm(false);

                    }
                }
                
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.RollbackTransaction();
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshToolStripButton_Click(this, new EventArgs());
            }
        }

        private bool UpdateShareRegBook(clDatacon DataObj)
        {
            
            bool success = true;
            try
            {
                
                
                if (this.GetShareRegBookBySHId(this._SHId))
                {
                    GetShareRegBookListBySHId(this._SHId);
                    int SubscrbShareNo = 0;
                    decimal SubscrbShareAmnt = 0;

                  
                   
                    SubscrbShareNo = Convert.ToInt32(this._ShareSubscribing["NoofShareSold"]);
                    SubscrbShareAmnt = Convert.ToDecimal(this._ShareSubscribing["AmntofShareSold"]);

                    if (Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["PaidUpShareAmt"]) <= (Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["SubscribedShareAmtModif"]) - Convert.ToDecimal(this._ShareSubscribing["AmntofShareSold"])))
                    {
                        string cmdText = "UPDATE tblShareRegBook Set SubscribedShareNoModif=isnull(SubscribedShareNoModif,0)-" + SubscrbShareNo + ", SubscribedShareAmtModif=isnull(SubscribedShareAmtModif,0)-" + SubscrbShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                        success = DataObj.Execute(cmdText);
                        if (success)
                        {
                            cmdText = "UPDATE tblShareSubscribing Set IsCanceled=1  WHERE TrnId=" + this._TrnId;
                            success = DataObj.Execute(cmdText);
                        }
                       
                    }
                    else
                    {
                        AppMessageBox.ShowInformation("The subscribed share can not be less than the Paidup share. Please cancel first the paidup share, then after you can cancel the subscribed share.");
                        success = false;
                    }
                    
                    


                   
                }
                
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                success = false;
            }
            
            return success;
        }

        private bool InsertAuditlog(DataRow ShareSubscibing, clDatacon DataObj)
        {
           
            bool success = true;
            try
            {
               
                if (this._tblShareRegBookList.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();


                    if (Convert.ToInt32(ShareSubscibing["NoofShareSold"])>0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "TrnId";
                        this._AuditLog["KeyFldValue"] = this._TrnId;
                        this._AuditLog["ActionTaken"] = "Cancel Subscribed Share";
                        this._AuditLog["FldChged"] = "SubscribedShareNoModif";
                        this._AuditLog["OldValue"] = this._tblShareRegBookList.Rows[0]["SubscribedShareNoModif"];
                        this._AuditLog["NewValue"] = (Convert.ToInt32(this._tblShareRegBookList.Rows[0]["SubscribedShareNoModif"]) - Convert.ToInt32(ShareSubscibing["NoofShareSold"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && Convert.ToDecimal(ShareSubscibing["AmntofShareSold"])>0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "TrnId";
                        this._AuditLog["KeyFldValue"] = this._TrnId;
                        this._AuditLog["ActionTaken"] = "Cancel Subscribed Share";
                        this._AuditLog["FldChged"] = "SubscribedShareAmtModif";
                        this._AuditLog["OldValue"] = this._tblShareRegBookList.Rows[0]["SubscribedShareAmtModif"];
                        this._AuditLog["NewValue"] = (Convert.ToDecimal(this._tblShareRegBookList.Rows[0]["SubscribedShareAmtModif"]) - Convert.ToDecimal(ShareSubscibing["AmntofShareSold"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success)
                    {
                        this._AuditLog["TblName"] = "tblShareSubscibing";
                        this._AuditLog["KeyFld"] = "TrnId";
                        this._AuditLog["KeyFldValue"] = this._TrnId;
                        this._AuditLog["ActionTaken"] = "Cancel Subscribed Share";
                        this._AuditLog["FldChged"] = "IsCanceled";
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
           
            return success;
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._TrnId = 0;
            this._SHId = 0;
           
            
        }

        private void SHIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SHIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.SHIdLookUpEdit.EditValue))
            {
                this._SHId = 0;
               
                this._tblShareholderDetailBrowse.Rows.Clear();
            }
            else
            {
                this._SHId = Convert.ToInt32(this.SHIdLookUpEdit.EditValue);
                this.GetShareholderBrowse(this._SHId);
                


            }
            GetShareholderSubscribeHistory(this._SHId);
            GetShareRegBookListBySHId(this._SHId);
            
        }

        private void gridShareSubscribe_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridShareSubscribe.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridShareSubscribe.GetDataRow(focused);
                this._TrnId = Convert.ToInt32(curRow["TrnId"]);
                this._SHId = Convert.ToInt32(curRow["SHId"]);
               
                this.GetShareholderBrowse(this._SHId);
                this.GetShareholderSubscribeEntry(this._TrnId);
                GetNewEntry();
                this.gridShareSubscribe.FocusedRowHandle = focused;
            }
        }

        private bool GetShareholderSubscribeHistory(int shId)
        {
            if (!this._isLoadingEntry)
            {

                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {

                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblShareSubscribingList, "SELECT * FROM tblShareSubscribing WHERE IsCanceled=0 and SHId=" + shId);
                    DataObj.FillData(this._tblCancelShareSubscribingTransactionList, "SELECT * FROM tblCancelShareSubscribingTransaction WHERE  SHId=" + shId);
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
            else
                return false;
        }

        private bool GetShareholderSubscribeEntry(int trnId)
        {
            
                
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    
                    DataObj.OpenConnection();
                    if(DataObj.FillData(this._tblShareSubscribing, "SELECT * FROM tblShareSubscribing WHERE TrnId=" + trnId))
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

        private void GetNewEntry()
        {
            try
            {
                this._CancelShareSubscribingTransaction = this._tblCancelShareSubscribingTransaction.NewRow();
                clDatacon.SetToDatabaseDefaults(this._CancelShareSubscribingTransaction, clMain.ConnString);
                
                if (this._SHId != 0) this._CancelShareSubscribingTransaction["SHId"] = this._SHId;
                if (this._TrnId != 0) this._CancelShareSubscribingTransaction["TrnId"] = this._TrnId;


                this._CancelShareSubscribingTransaction["EffectiveDate"] = clUtility.GetCurrentDate();
                this._CancelShareSubscribingTransaction["EffectiveDateEth"] = clUtility.GetEthiopicDate(clUtility.GetCurrentDate());

                this._CancelShareSubscribingTransaction["CrtBy"] = clMain.User.UserName;
                this._tblCancelShareSubscribingTransaction.Rows.Clear();
                this._tblCancelShareSubscribingTransaction.Rows.Add(this._CancelShareSubscribingTransaction);
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                
            }
                
           
        }

        private bool GetShareRegBookBySHId(int ShId)
        {
            object result;
            string cmdText;
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                   
                    DataObj.OpenConnection();
                    cmdText = "SELECT SHId FROM tblShareRegBook WHERE SHId=" + ShId;
                     result = DataObj.GetDataScalar(cmdText);
                if (result != null)
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
                    this._isLoadingEntry = false;
                }
            
        }

        private void GetShareRegBookListBySHId(int ShId)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                   
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

        #region Shareholder Browse
        private DataTable _tblShareholderDetailBrowse;
        private DataTable _tblSexLu;
        

        private void BindControlsSH()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                this._tblSexLu = DataObj.GetDataTable("tblSexLu");
               
               
                clMain.SetDataSource(this.sexLookUpEdit, this._tblSexLu);


                this._tblShareholderDetailBrowse = DataObj.GetDataTable("tblShareholderDetail");
               
                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.sexLookUpEdit,
                    this.DORegDateTimePicker,
                    this.DORegEthTextBox,
                    this.RegCodeTextBox,
                    this.IsLBFounderCheckBox,
                    this.IsGBFounderCheckBox
                    
                });
                clMain.BindControls(cntrsList, this._tblShareholderDetailBrowse);
                cntrsList.Clear();

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

        private void InitFormSH(bool All)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (All)
                {
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblSexLu, "SELECT * FROM tblSexLu");
                    
                
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

        private void GetShareholderBrowse(int SHId)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                cmdText = "SELECT RegCode,Sex, DOReg, DORegEth, IsLBFounder, IsGBFounder  FROM tblShareholderDetail where SHId=" + SHId;
                

                DataObj.FillData(this._tblShareholderDetailBrowse, cmdText);

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

        private void searchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.searchByComboBox.SelectedIndex != -1)
            {
                this.SHIdLookUpEdit.Properties.DisplayMember = this.searchByComboBox.SelectedItem.ToString();
            }
        }

       
       

       










    }
}

