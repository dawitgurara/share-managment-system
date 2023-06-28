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
    public partial class frmShareSubscribing : Form
    {
        #region Fields
        private string _title = "Share Subscribing";
        private bool _isNew = true;
        private bool _isLoadingEntry = false;

        private int _SHId = 0;
        private int _TrnId = 0;
        //private DateTime _EffectiveDate = Convert.ToDateTime("01/01/1900");
       
        private string _EffectiveDate = string.Empty;
        private DataTable _tblShareSubscribing;
        private DataRow _ShareSubscribing;
        private DataTable _tblShareSubscribingList;
       

        private DataTable _tblShareRegBookList;
       
        private DataTable _tblShareholderDetailList;

        private DataTable _tblShareRegBook;
        private DataRow _ShareRegBook;

        private DataTable _tblShareRegBookPrev;
      

        private DataTable _tblAuditLog;
        private DataRow _AuditLog;

        #endregion

        #region Properties
        public bool IsNew
        {
            get { return this._isNew; }
            set
            {
                this._isNew = value;
                //this.deleteToolStripButton.Enabled = !this._isNew;
            }
        }
        #endregion

        public frmShareSubscribing()
        {
            InitializeComponent();
            
        }

        private void frmShareSubscribing_Load(object sender, EventArgs e)
        {
            
            
            BindControls();
            InitForm(true);
            
            BindControlsSH();
            InitFormSH(true);
        }

        private void frmShareSubscribing_KeyDown(object sender, KeyEventArgs e)
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
                this._tblShareRegBookPrev = DataObj.GetDataTable("tblShareRegBook");
                clMain.SetDataSource(this.SHIdLookUpEdit, this._tblShareholderDetailList);


                this._tblShareRegBook = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBook.Columns["CrtDt"].ReadOnly = true;
                this._tblShareRegBook.Columns["CrtWs"].ReadOnly = true;

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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
           
            try
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
                    this._ShareSubscribing = this._tblShareSubscribing.Rows[0];


                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._ShareSubscribing, false))
                        {
                            if (InsertShareRegBook())
                            {
                                if (InsertAuditlog(this._ShareSubscribing))
                                {
                                    DataObj.CommitTransaction();
                                    AppMessageBox.ShowInformation("Share subscription transaction is saved successfully");
                                }
                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Share subscription transaction is failed");
                                }
                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Share subscription transaction is failed");
                            }

                        }
                    }
                    else
                    {// updating is not required because if there is any modification, it should be canceled using canceling shareholder subscribtion transaction
                        //if (DataObj.Update(this._title, this._ShareSubscribing, true))
                        //{


                        //}
                    }



                    InitForm(false);

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

        private bool InsertShareRegBook()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this.GetShareRegBookBySHId(this._SHId))
                {

                    decimal addedShareNo = 0;
                    decimal addedShareAmnt = 0;
                    addedShareNo = Convert.ToDecimal(this._ShareSubscribing["NoofShareSold"]);
                    addedShareAmnt = Convert.ToDecimal(this._ShareSubscribing["AmntofShareSold"]);
                    string cmdText = "UPDATE tblShareRegBook Set SubscribedShareNoModif=isnull(SubscribedShareNoModif,0)+" + addedShareNo + ", SubscribedShareAmtModif=isnull(SubscribedShareAmtModif,0)+" + addedShareAmnt + ",LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                    success = DataObj.Execute(cmdText);

                    


                   
                }
                else
                {
                    this._ShareRegBook = this._tblShareRegBook.NewRow();
                    this._ShareRegBook["SHId"] = this._ShareSubscribing["SHId"];
                    this._ShareRegBook["SubscribedShareNoOrg"] = this._ShareSubscribing["NoofShareSold"];
                    this._ShareRegBook["SubscribedShareAmtOrg"] = this._ShareSubscribing["AmntofShareSold"];
                    this._ShareRegBook["SubscribedShareNoModif"] = this._ShareSubscribing["NoofShareSold"];
                    this._ShareRegBook["SubscribedShareAmtModif"] = this._ShareSubscribing["AmntofShareSold"];
                    this._ShareRegBook["CrtBy"] = clMain.User.UserName;

                    success = DataObj.Insert(this._title, this._ShareRegBook, false, false);
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

        private bool InsertAuditlog(DataRow ShareSubscibing)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this._tblShareRegBookPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();


                    if (Convert.ToDecimal(ShareSubscibing["NoofShareSold"].ToString())>0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Share Subscribtion";
                        this._AuditLog["FldChged"] = "SubscribedShareNoModif";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["SubscribedShareNoModif"];
                        this._AuditLog["NewValue"] = (Convert.ToDecimal(ShareSubscibing["NoofShareSold"]) + Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["SubscribedShareNoModif"]));
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && Convert.ToDecimal(ShareSubscibing["AmntofShareSold"])>0)
                    {
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Share Subscribtion";
                        this._AuditLog["FldChged"] = "SubscribedShareAmtModif";
                        this._AuditLog["OldValue"] = this._tblShareRegBookPrev.Rows[0]["SubscribedShareAmtModif"];
                        this._AuditLog["NewValue"] = (Convert.ToDecimal(ShareSubscibing["AmntofShareSold"]) + Convert.ToDecimal(this._tblShareRegBookPrev.Rows[0]["SubscribedShareAmtModif"]));
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

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._TrnId = 0;
            this._SHId = 0;
           
            this.GetShareholderSubscribeEntry(this._SHId,  this._EffectiveDate);
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
            if (this.IsNew)
                this.GetShareholderSubscribeEntry(this._SHId, this._EffectiveDate);
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
                    DataObj.FillData(this._tblShareSubscribingList, "SELECT * FROM tblShareSubscribing WHERE IsCanceled = 0 and SHId=" + shId);
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
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblShareSubscribing, "SELECT * FROM tblShareSubscribing WHERE TrnId=" + trnId);
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

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._ShareSubscribing = this._tblShareSubscribing.NewRow();
                clDatacon.SetToDatabaseDefaults(this._ShareSubscribing, clMain.ConnString);
                if (this._SHId != 0) this._ShareSubscribing["SHId"] = this._SHId;
                
                if (this._EffectiveDate != string.Empty)
                {
                    this._ShareSubscribing["EffectiveDate"] = this._EffectiveDate;
                    this._ShareSubscribing["EffectiveDateEth"] = clUtility.GetEthiopicDate(Convert.ToDateTime(this._EffectiveDate));
                }
                this._ShareSubscribing["CrtBy"] = clMain.User.UserName;
                this._tblShareSubscribing.Rows.Clear();
                this._tblShareSubscribing.Rows.Add(this._ShareSubscribing);
                this._isLoadingEntry = false;
            }
        }

        private bool GetShareholderSubscribeEntry(int SHId, string effectiveDate)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.ShareholderSubscribeExists(SHId, effectiveDate))
                {
                    this._isLoadingEntry = false;
                   
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblShareSubscribing, "set dateformat dmy SELECT * FROM tblShareSubscribing WHERE IsCanceled=0 and SHId=" + SHId + " AND EffectiveDate='" + effectiveDate + "'");
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

        public bool ShareholderSubscribeExists(int shId, string effectiveDate)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (shId == 0 || effectiveDate == string.Empty )
                return false;
            try
            {
                DataObj.OpenConnection();
                cmdText = "set dateformat dmy SELECT SHId FROM tblShareSubscribing WHERE IsCanceled=0 and SHId=" + shId + " AND EffectiveDate='" + effectiveDate + "'";
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

        private bool GetShareRegBookBySHId(int ShId)
        {
            object result;
            string cmdText;
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    this.IsNew = false;
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
            else
                return false;
        }

        private void GetShareRegBookListBySHId(int ShId)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                    DataObj.FillData(this._tblShareRegBookPrev, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
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

        private void EffectiveDateDateTimePicker_Validated(object sender, EventArgs e)
        {
                this.EffectiveDateEthTextBox.Text=clUtility.GetEthDate(this.EffectiveDateDateTimePicker.Value);
                this._EffectiveDate = this.EffectiveDateDateTimePicker.Value.ToShortDateString();

            
            if (this.IsNew)
                this.GetShareholderSubscribeEntry(this._SHId,  this._EffectiveDate);
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

        private void AmntofShareSoldTextBox_Validated(object sender, EventArgs e)
        {
            if (this.AmntofShareSoldTextBox.Text.Trim() == string.Empty)
                AppMessageBox.ShowExclamation("Please enter the share amount");
            else
            {
                object shareAmount = this.AmntofShareSoldTextBox.Text.Trim();
                if (!clUtility.IsNumeric(shareAmount))
                {
                    AppMessageBox.ShowExclamation("Please enter valid share amount");
                    this.AmntofShareSoldTextBox.Focus();
                }
                //else if (Convert.ToDecimal(shareAmount) < 1000)
                //{
                //    AppMessageBox.ShowExclamation("Share amount should not be less than 1000.");
                //    this.AmntofShareSoldTextBox.Focus();
                //}
                else
                    this.NoofShareSoldTextBox.Text = Convert.ToString(clUtility.GetShareNoByShareAmount(Convert.ToDecimal(this.AmntofShareSoldTextBox.Text.Trim())));
                        
            }
        }

        private void AmntofShareSoldTextBox_TextChanged(object sender, EventArgs e)
        {
            object shareAmount = AmntofShareSoldTextBox.Text.Trim();
            if (!shareAmount.Equals(string.Empty) && !clUtility.IsNumeric(shareAmount))
            {
                AppMessageBox.ShowExclamation("Please enter valid share amount");
                AmntofShareSoldTextBox.Text = "";
                this.NoofShareSoldTextBox.Text = "";
            }
        }










    }
}

