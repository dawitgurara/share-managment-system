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
    public partial class frmCashPayable : Form
    {
        #region Fields
        private string _title = "Cash Payable Record";
        private bool _isNew = true;
        private bool _isLoadingEntry = false;

        private int _SHId = 0;
        private int _TrnId = 0;

        private string _Message = string.Empty;
        private string _ReceiptNo = string.Empty;
        
        private string _fiscalYear = "0";
        private string _CRVNo = "";


        /*this field is a cash payable which is less than one thausand if a share holder paid extra amount or less amont 
        any less than thaousand amount should be recoded as cash payable
         */
        private decimal _cashtobePaid = 0;




        private DataTable _tblFiscalYear;
        //tblDividendPaid
        private DataTable _tblCashPayable;
        private DataRow _CashPayable;
        private DataTable _tblCashPayableList;
        

        private DataTable _tblShareRegBookList;

        private DataTable _tblShareholderDetailList;

        private DataTable _tblShareRegBook;

        private DataTable _tblShareRegBookPrev;

        


        
        
        #endregion

        #region Properties
        public bool IsNew
        {
            get { return this._isNew; }
            set
            {
                this._isNew = value;
                this.deleteToolStripButton.Enabled = !this._isNew;
            }
        }
        #endregion

        public frmCashPayable()
        {
            InitializeComponent();
        }

        private void frmCashPayable_Load(object sender, EventArgs e)
        {
            this.printToolStripButton.Visible = false;


            BindControls();
            BindControlsSH();
            InitForm(true);
            InitFormSH(true);
        }

        private void frmCashPayable_KeyDown(object sender, KeyEventArgs e)
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


                this._tblShareholderDetailList = new DataTable("tblShareholderDetail");
                this._tblShareholderDetailList.Columns.Add("SHId", typeof(int));
                this._tblShareholderDetailList.Columns.Add("RegCode", typeof(string));
                this._tblShareholderDetailList.Columns.Add("FullName", typeof(string));
                this._tblShareholderDetailList.Columns.Add("SHRegCodeWithName", typeof(string));
                clMain.SetDataSource(this.SHIdLookUpEdit, this._tblShareholderDetailList);

                this._tblCashPayableList = DataObj.GetDataTable("tblCashPayable");
                
                this._tblFiscalYear = new DataTable("tblFisicalYear");
                this._tblFiscalYear.Columns.Add("FiscalYear", typeof(string));
                clMain.SetDataSource(this.FiscalYearLookUpEdit, this._tblFiscalYear);




                this._tblShareRegBook = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBook.Columns["CrtDt"].ReadOnly = true;
                this._tblShareRegBook.Columns["CrtWs"].ReadOnly = true;

                
                this._tblShareRegBookList = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBookPrev = DataObj.GetDataTable("tblShareRegBook");
                this._tblCashPayable = DataObj.GetDataTable("tblCashPayable");
                this._tblCashPayable.Columns["CrtDt"].ReadOnly = true;
                this._tblCashPayable.Columns["CrtWs"].ReadOnly = true;
                this._tblCashPayable.Columns["IsPaid"].ReadOnly = true;
                this._tblCashPayable.Columns["TrNo"].ReadOnly = true;

                
                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                this.FiscalYearLookUpEdit,
                this.SHIdLookUpEdit,
                this.RVNoTextBox,
                this.PayableAmountTextBox
                
               
                   
                });

                clMain.BindControls(cntrsList, this._tblCashPayable);
                cntrsList.Clear();

                clMain.SetDataSource(this.gctCashPayable, this._tblCashPayableList);
                clMain.SetDataSource(this.gctCashPayable, this._tblCashPayableList);
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

                    DataObj.FillData(this._tblFiscalYear, "select  FiscalYear from tblFiscalYears where closed=0 order by FiscalYear desc");


                }
                DataObj.FillData(this._tblShareholderDetailList, clShareholder.GetShareholderBrowseSql("SHStatus=1 and SHId in (select SHId from tblShareRegBook)"));
                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                DataObj.FillData(this._tblCashPayableList, "SELECT * FROM tblCashPayable ");
                
                clMain.SetSearchBy(this.SHIdLookUpEdit, this.searchByComboBox);

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


                    this._CashPayable = this._tblCashPayable.Rows[0];

                    if (this._isNew)
                    {

                        
                        if (DataObj.Insert(this._title, this._CashPayable, false))
                        {


                            InitForm(false);
                            //this.refreshToolStripButton_Click(this, new EventArgs());


                        }

                    }
                    else
                    {
                        if(DataObj.Update(this._title, this._CashPayable, false))
                        {
                            InitForm(false);
                            //this.refreshToolStripButton_Click(this, new EventArgs());
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

                if (this._TrnId == 0)
                {
                    AppMessageBox.ShowExclamation("Please double click from the Cash Payable list ");
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete the cash payable record?") == DialogResult.No)
                    return;



                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._CashPayable, false))
                {
                    InitForm(false);
                    this.refreshToolStripButton_Click(this, new EventArgs());
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

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._TrnId = 0;
            this._SHId = 0;
            this._fiscalYear = "";

            
            this.GetShareholderBrowse(this._SHId);
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
            GetShareRegBookListBySHId(this._SHId);
            GetCashPayableHistory(this._SHId, this._fiscalYear);
            if (this.IsNew)
              this.GetCashPayableEntry(this._SHId, this._fiscalYear);
        }

        private void FiscalYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.FiscalYearLookUpEdit.EditValue != null && !Convert.IsDBNull(this.FiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = Convert.ToString(this.FiscalYearLookUpEdit.EditValue);
                
                GetCashPayableHistoryByFisicalYear(this._fiscalYear);

            }
        }

        private void gridCashPayable_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridCashPayable.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridCashPayable.GetDataRow(focused);
                this._TrnId = Convert.ToInt32(curRow["TrNo"]);
                this._SHId = Convert.ToInt32(curRow["SHId"]);

                this.GetShareholderBrowse(this._SHId);
                this.GetCashPayableEntry(this._TrnId);

                this.gridCashPayable.FocusedRowHandle = focused;
            }
        }

        private bool GetCashPayableHistory(int shId, string fiscalyear)
        {


            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {

                DataObj.OpenConnection();
                DataObj.FillData(this._tblCashPayableList, "SELECT * FROM tblCashPayable WHERE  IsPaid=0 and SHId=" + shId + " and FiscalYear='" + fiscalyear + "'");
                

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

        private bool GetCashPayableHistoryByFisicalYear(string fiscalyear)
        {


            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {

                DataObj.OpenConnection();
                
                DataObj.FillData(this._tblCashPayableList, "SELECT * FROM tblCashPayable WHERE  FiscalYear='" + fiscalyear + "'");

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

        private bool GetCashPayableEntry(int trnId)
        {


            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblCashPayable, "SELECT FiscalYear, SHId,PayableAmount,RVNo  FROM tblCashPayable WHERE TrNo=" + trnId);
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
            //clDatacon DataObj = new clDatacon(clMain.ConnString);

            //try
            //{

            //    DataObj.OpenConnection();
            //    DataObj.FillData(this._tblCashPayable, "SELECT FiscalYear, SHId,PayableAmount  FROM tblCashPayable WHERE TrNo=" + trnId);
            //    return true;
            //}
            //catch (Exception Ex)
            //{
            //    AppMessageBox.ShowExclamation(Ex.Message);
            //    return false;
            //}
            //finally
            //{
            //    DataObj.CloseConnection();

            //}

        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
            this._CashPayable = this._tblCashPayable.NewRow();
            clDatacon.SetToDatabaseDefaults(this._CashPayable, clMain.ConnString);
            if (this._fiscalYear != "0") this._CashPayable["FiscalYear"] = this._fiscalYear;
            if (this._SHId != 0) this._CashPayable["SHId"] = this._SHId;
            if (this._CRVNo != "") this._CashPayable["RVNo"] = this._CRVNo;
            if (this._cashtobePaid != 0) this._CashPayable["PayableAmount"] = this._cashtobePaid;
            
            this._CashPayable["CrtBy"] = clMain.User.UserName;
            this._tblCashPayable.Rows.Clear();
            this._tblCashPayable.Rows.Add(this._CashPayable);
            this._isLoadingEntry = false;
            }
        }

        public bool CashPayableExists(int SHId, string fiscalYear, string CRVNo)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (SHId == 0 || fiscalYear == "" || CRVNo == "")
                return false;
            try
            {
                DataObj.OpenConnection();
                
                cmdText = "SELECT *  FROM tblCashPayable WHERE IsPaid=0 and SHId=" + SHId + " AND FiscalYear='" + fiscalYear + "' and RVNo='" + this._CRVNo + "'";
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

        private bool GetCashPayableEntry(int SHId, string FiscalYear)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.CashPayableExists(SHId, this._fiscalYear,this._CRVNo))
                {
                    this._isLoadingEntry = false;

                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblCashPayable, "SELECT *  FROM tblCashPayable WHERE IsPaid=0 and SHId=" + SHId + " AND FiscalYear='" + FiscalYear + "' and RVNo='"+this._CRVNo+"'");
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

            }

        }

        private bool GetShareRegBookListBySHId(int ShId)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                
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
            return true;

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

                cmdText = "SELECT RegCode,Sex, DOReg, DORegEth, IsLBFounder, IsGBFounder  FROM tblShareholderDetail  where SHId=" + SHId ;
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

        private void RVNoTextBox_Validated(object sender, EventArgs e)
        {
            this._CRVNo = RVNoTextBox.Text;
            this.GetCashPayableEntry(this._SHId, this._fiscalYear);
        }

        private void PayableAmountTextBox_Validated(object sender, EventArgs e)
        {
            this._cashtobePaid = Convert.ToDecimal(this.PayableAmountTextBox.Text);
        }

       


        



















    }
}




