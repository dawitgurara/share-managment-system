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
    public partial class frmTerminateShareholder : Form
    {
        #region Fields
        private string _title = "Deactivate Shareholder";
        
        private int _SHId = 0;
        private int _TrnId = 0;
        private int _ReasonForTermination = 0;
        
        private string _EffectiveDate="";
        private string _EffectiveDateEth = "";
        
       
        private DataTable _tblReasonforTermination;
        private DataTable _tblDeactivateShareholder;
        private DataRow _DeactivateShareholder;
        private DataTable _tblDeactivateShareholderList;


        private DataTable _tblShareRegBookList;

        private DataTable _tblShareholderDetailList;

        private DataTable _tblShareRegBook;
        private DataRow _ShareRegBook;

        private DataTable _tblShareRegBookPrev;


        private DataTable _tblAuditLog;
        private DataRow _AuditLog;

        #endregion

        public frmTerminateShareholder()
        {
            InitializeComponent();

        }

        private void frmDeactivateShareholder_Load(object sender, EventArgs e)
        {
            

            BindControls();
            InitForm(true);

            BindControlsSH();
            InitFormSH(true);
        }

        private void frmSharePayment_KeyDown(object sender, KeyEventArgs e)
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

                this._tblReasonforTermination = DataObj.GetDataTable("tblReasonforTermination");
                this._tblShareholderDetailList = new DataTable("tblShareholderDetail");
                this._tblShareholderDetailList.Columns.Add("SHId", typeof(int));
                this._tblShareholderDetailList.Columns.Add("RegCode", typeof(string));
                this._tblShareholderDetailList.Columns.Add("FullName", typeof(string));
                this._tblShareholderDetailList.Columns.Add("SHRegCodeWithName", typeof(string));

                this._tblDeactivateShareholderList = DataObj.GetDataTable("tblDeactivateShareholder");
                
                clMain.SetDataSource(this.SHIdLookUpEdit, this._tblShareholderDetailList);

                
                clMain.SetDataSource(this.ReasonForTerminationLookUpEdit, this._tblReasonforTermination);
                clMain.SetRepositoryDataSource(this.rluReasonForTermination, this._tblReasonforTermination);

                this._tblShareRegBook = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBook.Columns["CrtDt"].ReadOnly = true;
                this._tblShareRegBook.Columns["CrtWs"].ReadOnly = true;

                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;

                this._tblShareRegBookList = DataObj.GetDataTable("tblShareRegBook");
                this._tblShareRegBookPrev = DataObj.GetDataTable("tblShareRegBook");
                this._tblDeactivateShareholder = DataObj.GetDataTable("tblDeactivateShareholder");
                this._tblDeactivateShareholder.Columns["CrtDt"].ReadOnly = true;
                this._tblDeactivateShareholder.Columns["CrtWs"].ReadOnly = true;
                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                
                this.SHIdLookUpEdit,
                this.EffectiveDateDateTimePicker,
                this.EffectiveDateEthTextBox,
                this.ReasonForTerminationLookUpEdit
                
               
                   
                });

                clMain.BindControls(cntrsList, this._tblDeactivateShareholder);
                cntrsList.Clear();

                clMain.SetDataSource(this.gctShareholderTerminate, this._tblDeactivateShareholderList);
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



                    DataObj.FillData(this._tblReasonforTermination, "SELECT * FROM tblReasonforTermination");
                    DataObj.FillData(this._tblShareholderDetailList, clShareholder.GetShareholderBrowseSql("SHStatus=1 and SHId in (select SHId from tblShareRegBook)"));
                    clMain.SetSearchBy(this.SHIdLookUpEdit, this.searchByComboBox);



                }

                DataObj.FillData(this._tblShareRegBookList, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                


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

        private void TerminateToolStripButton_Click(object sender, EventArgs e)
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
                    this._ShareRegBook = this._tblShareRegBookList.Rows[0];
                    this._DeactivateShareholder = this._tblDeactivateShareholder.Rows[0];
                    this._DeactivateShareholder["PaidupShareNo"] = this._ShareRegBook["PaidUpNoofShare"];
                    this._DeactivateShareholder["PaidupShareAmnt"] = this._ShareRegBook["PaidUpShareAmt"];
                   
                    
                        if (DataObj.Insert(this._title, this._DeactivateShareholder, false))
                        {
                            
                            if (InsertShareRegBook(DataObj))
                            {
                                if (InsertAuditlog(this._ShareRegBook, DataObj))
                                {
                                    DataObj.CommitTransaction();
                                    AppMessageBox.ShowInformation("Shareholder Termination Transaction is saved successfully");
                                }
                                else
                                {
                                    DataObj.RollbackTransaction();
                                    AppMessageBox.ShowInformation("Shareholder Termination Transaction is failed");
                                }
                            }
                            else
                            {
                                DataObj.RollbackTransaction();
                                AppMessageBox.ShowInformation("Shareholder Termination Transaction is failed");
                            }

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

        private bool InsertShareRegBook(clDatacon DataObj)
        {
           
            bool success = true;
            try
            {
                
                string cmdText = "UPDATE tblShareRegBook Set PaidUpNoofShare=0, PaidUpShareAmt=0,LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                success = DataObj.Execute(cmdText);
                if (success)
                {
                    cmdText = "UPDATE tblShareholderDetail Set SHStatus=0,LmBy='" + clMain.User.UserName + "' WHERE SHId=" + this._SHId;
                    success = DataObj.Execute(cmdText);
                }
                            
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
           
            return success;
        }

        private bool InsertAuditlog(DataRow _ShareRegBook, clDatacon DataObj)
        {
            
            bool success = true;
            try
            {
                
                if (this._tblShareRegBookPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();


                   
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Shareholder Termination";
                        this._AuditLog["FldChged"] = "PaidUpNoofShare";
                        this._AuditLog["OldValue"] = this._ShareRegBook["PaidUpNoofShare"];
                        this._AuditLog["NewValue"] = 0;
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                   
                   
                        this._AuditLog["TblName"] = "tblShareRegBook";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Shareholder Termination";
                        this._AuditLog["FldChged"] = "PaidUpShareAmt";
                        this._AuditLog["OldValue"] = this._ShareRegBook["PaidUpShareAmt"];
                        this._AuditLog["NewValue"] = 0;
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);


                        this._AuditLog["TblName"] = "tblShareholderDetail";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._SHId;
                        this._AuditLog["ActionTaken"] = "Shareholder Termination";
                        this._AuditLog["FldChged"] = "SHStatus";
                        this._AuditLog["OldValue"] = 1;
                        this._AuditLog["NewValue"] = 0;
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    


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
            this._EffectiveDate = "";
            this._EffectiveDateEth = "";
            this._ReasonForTermination = 0;
            GetNewEntry();
            
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
                GetShareRegBookListBySHId(this._SHId);
                
                GetDeactivatodShareholderHistory(this._SHId);
                

            }

           


        }

        private bool GetDeactivatodShareholderHistory(int shId)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                try
                {

                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblDeactivateShareholderList, "SELECT * FROM tblDeactivateShareholder WHERE SHId=" + shId);

                    if (this._tblDeactivateShareholderList.Rows.Count > 0)
                    {
                        this.TerminatedSareholdersGroupBox.Enabled = false;
                        this.tspTerminateSharehoders.Enabled = false;
                    }
                    else
                    {
                        this.TerminatedSareholdersGroupBox.Enabled = true;
                        this.tspTerminateSharehoders.Enabled = true;
                    }
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

        private void GetNewEntry()
        {

            this._DeactivateShareholder = this._tblDeactivateShareholder.NewRow();
            clDatacon.SetToDatabaseDefaults(this._DeactivateShareholder, clMain.ConnString);

            if (this._SHId != 0) this._DeactivateShareholder["SHId"] = this._SHId;
            if (this._EffectiveDate != "")
            {
                this._DeactivateShareholder["EffectiveDate"] = this._EffectiveDate;
                this._DeactivateShareholder["EffectiveDateEth"] = clUtility.GetEthDate(Convert.ToDateTime(this._EffectiveDate));
            }
            if (this._ReasonForTermination != 0) this._DeactivateShareholder["ReasonForTermination"] = this._ReasonForTermination;
            this._DeactivateShareholder["CrtBy"] = clMain.User.UserName;

            if (this._tblDeactivateShareholder.Rows.Count>0) this._tblDeactivateShareholder.Rows.Clear();
            this._tblDeactivateShareholder.Rows.Add(this._DeactivateShareholder);


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
                DataObj.FillData(this._tblShareRegBookPrev, "SELECT * FROM tblShareRegBook WHERE SHId=" + this._SHId);
                if (this._tblShareRegBookList.Rows.Count > 0)
                {

                    
                    return true;
                }
                else
                {
                    
                    return false;
                }
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

        private void EffectiveDateDateTimePicker_Validated(object sender, EventArgs e)
        {

            this.EffectiveDateEthTextBox.Text = clUtility.GetEthDate(this.EffectiveDateDateTimePicker.Value);
            this._EffectiveDate = EffectiveDateDateTimePicker.Value.ToShortDateString();

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

        private void ReasonForTerminationLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.ReasonForTerminationLookUpEdit.EditValue == null || Convert.IsDBNull(this.ReasonForTerminationLookUpEdit.EditValue))
            {
                this._ReasonForTermination = 0;
            }
            else
            {
                this._ReasonForTermination = Convert.ToInt32(this.ReasonForTerminationLookUpEdit.EditValue);
               
            }
        }

       












    }
}


