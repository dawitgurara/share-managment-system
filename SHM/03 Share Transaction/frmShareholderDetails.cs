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
    public partial class frmShareholderDetails : Form
    {
        #region Fields
        private string _title = "Shareholder Details";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

        private int _id = -1;
        private string _RegCode = "";
       
       
        private string _DOB = string.Empty;

        private DataTable _tblShareholderDetail;
        private DataRow _shareholderDetail;

        private DataTable _tblShareholderDetailPrev;
       
        private DataTable _tblShareholderDetailList;
        
       
        private DataTable _tblSexLu;
       
        private DataTable _tblStatus;
        private DataTable _tblTitleLu;
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
                this.deleteToolStripButton.Enabled = !this._isNew;
               
                this.RegCodeTextBox.ReadOnly = !this._isNew;
               
            }
        }
       
       
        #endregion

        public frmShareholderDetails()
        {
            InitializeComponent();
        }

        private void frmShareholderDetails_Load(object sender, EventArgs e)
        {
            this.printToolStripButton.Visible = false;
            this.deleteToolStripButton.Visible = false;
            BindControls();
            InitForm(true);
           
        }

        private void frmShareholderDetails_KeyDown(object sender, KeyEventArgs e)
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
               
                

                this._tblSexLu = new DataTable("tblSexLu");

                this._tblStatus = new DataTable("tblStatusLu");
                this._tblTitleLu = new DataTable("tblTitleLu");

                clMain.SetDataSource(this.SHIdLookUpEdit, this._tblShareholderDetailList);

                clMain.SetDataSource(this.SexLookUpEdit, this._tblSexLu);

                clMain.SetDataSource(this.SHStatusLookUpEdit, this._tblStatus);
                clMain.SetDataSource(this.TitleLookUpEdit, this._tblTitleLu);

                this.SHIdLookUpEdit.Properties.NullText = "-- Select " + this._title + " --";
                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;
                this._tblShareholderDetailPrev = DataObj.GetDataTable("tblShareholderDetail");
                this._tblShareholderDetail = DataObj.GetDataTable("tblShareholderDetail");
                this._tblShareholderDetail.Columns["SHId"].ReadOnly = true;
                //this._tblShareholderDetail.Columns["SHStatus"].ReadOnly = true;

                this._tblShareholderDetail.Columns["CrtDt"].ReadOnly = true;
                this._tblShareholderDetail.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.RegCodeTextBox,
                    this.TitleLookUpEdit,
                    this.FullNameTextBox,
                    this.FullNameAmharicTextBox,
                    this.SexLookUpEdit,
                    this.SHStatusLookUpEdit,
                    this.DORegDateTimePicker,
                    this.DORegEthTextBox,
                    this.NationalityTextBox,
                    this.RegionTextBox,
                    this.CityTextBox,
                    this.SubCityTextBox,
                    this.Woreda_KebeleTextBox,
                    this.HouseNoTextBox,
                    this.OfficeTelNoTextBox,
                    this.ResTelNoTextBox,
                    this.MobileNo1TextBox,
                    this.MobileNo2TextBox,
                    this.Email1TextBox,
                    this.Email2TextBox,
                    this.POBoxTextBox,
                    this.FaxTextBox,
                    this.IsLBFounderCheckBox,
                    this.IsGBFounderCheckBox
                   
                   
                });

                clMain.BindControls(cntrsList, this._tblShareholderDetail);
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
       
        private void InitForm(bool All)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                DataObj.OpenConnection();
                if (All)
                {
                    DataObj.OpenConnection();
                   
                    DataObj.FillData(this._tblSexLu, "SELECT * FROM tblSexLu");
                    DataObj.FillData(this._tblStatus, "SELECT * FROM tblStatus");
                    DataObj.FillData(this._tblTitleLu, "SELECT * FROM tblTitleLu");
                   
                }

                
                DataObj.FillData(this._tblShareholderDetailList, clShareholder.GetShareholderBrowseSql(true));
                clMain.SetSearchBy(this.SHIdLookUpEdit, this.searchByComboBox);

            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();

                this.refreshToolStripButton_Click(null, null);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                if (this.Validate())
                {
                    this.SHIdLookUpEdit.Focus();

                    if (this._id == -1 && this.RegCodeTextBox.Text == string.Empty)
                    {
                        AppMessageBox.ShowExclamation("Please select or add new " + this._title);
                        this.SHIdLookUpEdit.Focus();
                        return;
                    }

                    if (!this._isNew && this.SHIdLookUpEdit.Text == string.Empty)
                    {
                        AppMessageBox.ShowExclamation("You don't have the privilage to edit this " + this._title);
                        return;
                    }

                    this._shareholderDetail = this._tblShareholderDetail.Rows[0];


                    if (!clShareholder.ValidateShareholder(this._shareholderDetail))
                        return;
 
                }
                DataObj.OpenConnection();

                if (this._isNew)
                {
                    this._shareholderDetail["RegCode"] = this.GetNextSHRegCode();
                    if (DataObj.Insert(this._title, this._shareholderDetail, true))
                    {
                        this._RegCode = clShareholder.GetRegCode(this._shareholderDetail["RegCode"].ToString());

                        InitForm(false);
                            
                    }

                }
                else
                {
                    
                    DataObj.BeginTransaction();
                   
                    if (DataObj.Update(this._title, this._shareholderDetail, false))
                    {
                        
                        if (InsertAuditlog(this._shareholderDetail))
                        {
                            DataObj.CommitTransaction();
                            AppMessageBox.ShowInformation("Shareholder details is updated successfully");
                        }
                        else
                        {
                            DataObj.RollbackTransaction();
                            AppMessageBox.ShowInformation("Shareholder details  updating is failed");
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

            }
        }
       private bool InsertAuditlog(DataRow shareholderDetail)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this._tblShareholderDetailPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();
                   
                    
                   
                    if (this._tblShareholderDetailPrev.Rows[0]["FullName"].ToString().Trim() != shareholderDetail["FullName"].ToString().ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblShareholderDetail";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._id;
                        this._AuditLog["ActionTaken"] = "Shareholder Details Edited";
                        this._AuditLog["FldChged"] = "FullName";
                        this._AuditLog["OldValue"] = this._tblShareholderDetailPrev.Rows[0]["FullName"];
                        this._AuditLog["NewValue"] = shareholderDetail["FullName"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && this._tblShareholderDetailPrev.Rows[0]["FullNameAmharic"].ToString().Trim() != shareholderDetail["FullNameAmharic"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblShareholderDetail";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._id;
                        this._AuditLog["ActionTaken"] = "Shareholder Details Edited";
                        this._AuditLog["FldChged"] = "FullNameAmharic";
                        this._AuditLog["OldValue"] = this._tblShareholderDetailPrev.Rows[0]["FullNameAmharic"];
                        this._AuditLog["NewValue"] = shareholderDetail["FullNameAmharic"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }

                    if (success && this._tblShareholderDetailPrev.Rows[0]["DOReg"].ToString().Trim() != shareholderDetail["DOReg"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblShareholderDetail";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._id;
                        this._AuditLog["ActionTaken"] = "Shareholder Details Edited";
                        this._AuditLog["FldChged"] = "DOReg";
                        this._AuditLog["OldValue"] = this._tblShareholderDetailPrev.Rows[0]["DOReg"];
                        this._AuditLog["NewValue"] = shareholderDetail["DOReg"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                   
                    if (success && this._tblShareholderDetailPrev.Rows[0]["IsLBFounder"].ToString() != shareholderDetail["IsLBFounder"].ToString())
                    {
                        this._AuditLog["TblName"] = "tblShareholderDetail";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._id;
                        this._AuditLog["ActionTaken"] = "Shareholder Details Edited";
                        this._AuditLog["FldChged"] = "IsLBFounder";
                        this._AuditLog["OldValue"] = this._tblShareholderDetailPrev.Rows[0]["IsLBFounder"];
                        this._AuditLog["NewValue"] = shareholderDetail["IsLBFounder"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && this._tblShareholderDetailPrev.Rows[0]["IsGBFounder"].ToString() != shareholderDetail["IsGBFounder"].ToString())
                    {
                        this._AuditLog["TblName"] = "tblShareholderDetail";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._id;
                        this._AuditLog["ActionTaken"] = "Shareholder Details Edited";
                        this._AuditLog["FldChged"] = "IsGBFounder";
                        this._AuditLog["OldValue"] = this._tblShareholderDetailPrev.Rows[0]["IsGBFounder"];
                        this._AuditLog["NewValue"] = shareholderDetail["IsGBFounder"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && this._tblShareholderDetailPrev.Rows[0]["MobileNo1"].ToString().Trim() != shareholderDetail["MobileNo1"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblShareholderDetail";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._id;
                        this._AuditLog["ActionTaken"] = "Shareholder Details Edited";
                        this._AuditLog["FldChged"] = "MobileNo1";
                        this._AuditLog["OldValue"] = this._tblShareholderDetailPrev.Rows[0]["MobileNo1"];
                        this._AuditLog["NewValue"] = shareholderDetail["MobileNo1"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && this._tblShareholderDetailPrev.Rows[0]["MobileNo2"].ToString().Trim() != shareholderDetail["MobileNo2"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblShareholderDetail";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._id;
                        this._AuditLog["ActionTaken"] = "Shareholder Details Edited";
                        this._AuditLog["FldChged"] = "MobileNo2";
                        this._AuditLog["OldValue"] = this._tblShareholderDetailPrev.Rows[0]["MobileNo2"];
                        this._AuditLog["NewValue"] = shareholderDetail["MobileNo2"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && this._tblShareholderDetailPrev.Rows[0]["Email1"].ToString().Trim() != shareholderDetail["Email1"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblShareholderDetail";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._id;
                        this._AuditLog["ActionTaken"] = "Shareholder Details Edited";
                        this._AuditLog["FldChged"] = "Email1";
                        this._AuditLog["OldValue"] = this._tblShareholderDetailPrev.Rows[0]["Email1"];
                        this._AuditLog["NewValue"] = shareholderDetail["Email1"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && this._tblShareholderDetailPrev.Rows[0]["Email2"].ToString().Trim() != shareholderDetail["Email2"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblShareholderDetail";
                        this._AuditLog["KeyFld"] = "SHId";
                        this._AuditLog["KeyFldValue"] = this._id;
                        this._AuditLog["ActionTaken"] = "Shareholder Details Edited";
                        this._AuditLog["FldChged"] = "Email2";
                        this._AuditLog["OldValue"] = this._tblShareholderDetailPrev.Rows[0]["Email2"];
                        this._AuditLog["NewValue"] = shareholderDetail["Email2"];
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
      
        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            bool success = true;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                if (this._id == -1)
                {
                    AppMessageBox.ShowExclamation("Please select " + this._title + " to delete");
                    this.SHIdLookUpEdit.Focus();
                    return;
                }

                if (!this._isNew && this.SHIdLookUpEdit.Text == string.Empty)
                {
                    AppMessageBox.ShowExclamation("You don't have the privilage to edit this " + this._title);
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete " + this._title + "?") == DialogResult.No)
                    return;

                this._shareholderDetail = this._tblShareholderDetail.Rows[0];
               

                DataObj.OpenConnection();
                
                success = DataObj.Delete(this._title, this._shareholderDetail, false);
                

                if (success)
                {
                    AppMessageBox.ShowExclamation(this._title + " deleted sucessfully");
                    InitForm(false);
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

       
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            this.SHIdLookUpEdit.EditValue = -1;
            SHIdLookUpEdit_EditValueChanged(null, null);
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.SHIdLookUpEdit.EditValue = null;
        }

        private void SHIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SHIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.SHIdLookUpEdit.EditValue))
            {
                this._id = -1;
                this.GetShareholderEntry(this._id);
                this.SHIdLookUpEdit.Focus();

               

            }
            else
            {
                this._id = Convert.ToInt32(this.SHIdLookUpEdit.EditValue);
                string displaytext = this.SHIdLookUpEdit.Text;
                GetShareholderEntry(this._id);
                

            }
           

        }

        //private void RegCodeTextBox_Validated(object sender, EventArgs e)
        //{
        //    if (!this.RegCodeTextBox.ReadOnly)
        //    {
        //        string id = clShareholder.GetRegCode(this.RegCodeTextBox.Text);
        //        if (id == "") id = "0";
        //        this.SHIdLookUpEdit.EditValue = id;
        //        if (!this._isNew && this.SHIdLookUpEdit.Text == string.Empty)
        //        {
        //            AppMessageBox.ShowExclamation("You don't have the privilage to edit this " + this._title);
        //            return;
        //        }
        //    }
        //}

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;

                this._shareholderDetail = this._tblShareholderDetail.NewRow();
                clDatacon.SetToDatabaseDefaults(this._shareholderDetail, clMain.ConnString);
                if (this._id != -1) this._shareholderDetail["SHId"] = this._id;
                this._shareholderDetail["RegCode"] = this.GetNextSHRegCode();
                this._shareholderDetail["SHStatus"] = 1;
                this._shareholderDetail["CrtBy"] = clMain.User.UserName;
                this._tblShareholderDetail.Rows.Clear();
                this._tblShareholderDetail.Rows.Add(this._shareholderDetail);
                this._isLoadingEntry = false;
            }
        }

        private bool GetShareholderEntry(int id)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

               /* if (id == -1)
                {
                    this.IsNew = false;
                    this._tblShareholderDetail.Rows.Clear();

                   
                    this._isLoadingEntry = false;
                    return true;
                }*/
                if (!this.ShareholderExists(id))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    this.RegCodeTextBox.Focus();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblShareholderDetail, "SELECT * FROM tblShareholderDetail WHERE SHId=" + id);
                    DataObj.FillData(this._tblShareholderDetailPrev, "SELECT FullName,FullNameAmharic,DOReg,IsLBFounder,IsGBFounder,MobileNo1,MobileNo2,Email1,Email2 FROM tblShareholderDetail WHERE SHId=" + id);

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

        private bool ShareholderExists(int id)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (id == -1)
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT SHId FROM tblShareholderDetail WHERE SHId=" + id;
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

        private string GetNextSHRegCode()
        {
            string nextId = "0";
            string CurrentId = "0";
            int CurrentIdint = 0;
            string leadingZeros = "";
            int onlyNumber = 0;
           
            object result;
            
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                
                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("SELECT max(RegCode) As MaxRegCode FROM tblShareholderDetail");
                if (result == null || Convert.IsDBNull(result))
                {
                    nextId = "0001";
                    
                }
                else
                {
                    CurrentId = Convert.ToString(result);

                    
                    if (CurrentId.IndexOf("0") == 0)
                    {
                        int firstindexofZero=0;
                       
                        do{
                            leadingZeros = leadingZeros + getLeadingZero(CurrentId);
                            CurrentId = CurrentId.Substring(firstindexofZero + 1);
                            firstindexofZero = CurrentId.IndexOf("0");
                        }while(firstindexofZero==0);
                        onlyNumber = Convert.ToInt32(CurrentId);
                        onlyNumber++;
                       
                        if (onlyNumber <= 9)
                            nextId = leadingZeros + onlyNumber;
                        else if (onlyNumber > 9 && onlyNumber <= 99)
                            nextId = leadingZeros.Substring(leadingZeros.IndexOf("0"), 2) + onlyNumber;
                        else if (onlyNumber > 99 && onlyNumber <= 999)
                            nextId = leadingZeros.Substring(leadingZeros.IndexOf("0"), 1)+onlyNumber;
                        else
                            nextId = Convert.ToString(onlyNumber);
                    }
                    else
                    {
                        CurrentIdint = Convert.ToInt32(result);
                        CurrentIdint++;
                        nextId = Convert.ToString(CurrentIdint);
                    }
                    
                }
                return nextId;
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return "";
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private string getLeadingZero(string expression)
        {
           
            try
            {

                if (expression.IndexOf("0") == 0)
                    return "0";
                else
                    return "1";
                   
                
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return "";
            }
            
        }

        private void DORegDateTimePicker_Validated(object sender, EventArgs e)
        {
            this.DORegEthTextBox.Text = clUtility.GetEthDate(this.DORegDateTimePicker.Value);
        }
       
        private void searchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.searchByComboBox.SelectedIndex != -1)
            {
                this.SHIdLookUpEdit.Properties.DisplayMember = this.searchByComboBox.SelectedItem.ToString();
            }
        }

        




    }

}



