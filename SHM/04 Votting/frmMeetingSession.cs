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
    public partial class frmMeetingSession : Form
    {
        #region Fields
        private string _title = "Meeting Session";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

        private string _fiscalYear = "0";
        private int _TypeOfMeeting = 0;
        private DateTime _MeetingDate;

        private DataTable _tblMeetingSession;
        private DataRow _MeetingSession;

        private DataTable _tblMeetingSessionList;
        private DataTable _tblFiscalYear;
        private DataTable _tblTypeOfMeeting;
        private int _Round = 0;

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

        public frmMeetingSession()
        {

            InitializeComponent();
        }

        private void frmMeetingSession_Load(object sender, EventArgs e)
        {
            this._MeetingDate = clUtility.GetCurrentDate();
            BindControls();
            InitForm(true);
        }

        private void frmMeetingSession_KeyDown(object sender, KeyEventArgs e)
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
                this._tblTypeOfMeeting = DataObj.GetDataTable("tblTypeOfMeeting");


                clMain.SetDataSource(this.FiscalYearLookUpEdit, this._tblFiscalYear);
                clMain.SetDataSource(this.TypeOfMeetingLookUpEdit, this._tblTypeOfMeeting);
                clMain.SetRepositoryDataSource(this.rluMeetingType, this._tblTypeOfMeeting);

                this._tblMeetingSession = DataObj.GetDataTable("tblMeetingSession");
                this._tblMeetingSession.Columns["CrtDt"].ReadOnly = true;
                this._tblMeetingSession.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    
                    this.FiscalYearLookUpEdit,
                    this.TypeOfMeetingLookUpEdit,
                    this.MeetingDateDateTimePicker,
                    this.MeetingDateEthTextBox,
                    this.StartTimeTextBox,
                    this.EndTimeTextBox,
                    this.RoundNoTextBox,
                    this.VenueTextBox,
                    this.venuAmharicTextBox
                    
                    
                });

                clMain.BindControls(cntrsList, this._tblMeetingSession);
                cntrsList.Clear();

                this._tblMeetingSessionList = DataObj.GetDataTable("tblMeetingSession");
                clMain.SetDataSource(this.gctMeetingSession, this._tblMeetingSessionList);
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
                    DataObj.FillData(this._tblTypeOfMeeting, "select* from tblTypeOfMeeting");
                    if (this.chkYearAll.Checked)
                        DataObj.FillData(this._tblFiscalYear, "select* from ViewFiscalYears order by FiscalYear desc");
                    else

                        DataObj.FillData(this._tblFiscalYear, "select top 2 * from ViewFiscalYears order by FiscalYear desc");
                }
                else
                {
                   
                    DataObj.FillData(this._tblMeetingSessionList, "SELECT top 1 * FROM tblMeetingSession where IsActive=1 order by SessionId, FiscalYear desc");
                }
               


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

                    this.FiscalYearLookUpEdit.Focus();
                    this._MeetingSession = this._tblMeetingSession.Rows[0];

                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._MeetingSession, true))
                        {
                            InitForm(false);
                        }
                    }
                    else
                    {

                        if (DataObj.Update(this._title, this._MeetingSession, true))
                        {
                            InitForm(false);
                        }
                    }

                }
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                this.refreshToolStripButton_Click(this, new EventArgs());
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

                if (this._fiscalYear == "0")
                {
                    AppMessageBox.ShowExclamation("Please double click from the list to delete " + this._title);
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete " + this._title + "?") == DialogResult.No)
                    return;

                this._MeetingSession = this._tblMeetingSession.Rows[0];

                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._MeetingSession, true))
                {
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

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {


            this._fiscalYear = "0";

            this.GetMeetingSessionEntry(this._fiscalYear,this._TypeOfMeeting,this._MeetingDate);
            this.FiscalYearLookUpEdit.Focus();

        }

        private void gridMeetingSession_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridMeetingSession.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridMeetingSession.GetDataRow(focused);

                this._fiscalYear = Convert.ToString(curRow["FiscalYear"]);
                this._MeetingDate = Convert.ToDateTime(curRow["MeetingDate"]);
                this._TypeOfMeeting = Convert.ToInt32(curRow["TypeOfMeeting"]);
                this.GetMeetingSessionEntry(this._fiscalYear,this._TypeOfMeeting,this._MeetingDate);
                this.gridMeetingSession.FocusedRowHandle = focused;
            }
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._MeetingSession = this._tblMeetingSession.NewRow();
                clDatacon.SetToDatabaseDefaults(this._MeetingSession, clMain.ConnString);

                if (this._fiscalYear != "0") this._MeetingSession["FiscalYear"] = this._fiscalYear;
                if (this._TypeOfMeeting != 0) this._MeetingSession["TypeOfMeeting"] = this._TypeOfMeeting;

                this._MeetingSession["MeetingDate"] = this._MeetingDate;
                this._MeetingSession["MeetingDateEth"] = clUtility.GetEthDate(this._MeetingDate);
                this._MeetingSession["CrtBy"] = clMain.User.UserName;

                this._tblMeetingSession.Rows.Clear();
                this._tblMeetingSession.Rows.Add(this._MeetingSession);
                this._isLoadingEntry = false;
            }
        }

        private bool MeetingSessionExists(string fiscalyear, int typeOfmeeting, DateTime meetingDate)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (fiscalyear == "0")
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "set dateformat dmy SELECT * FROM tblMeetingSession WHERE FiscalYear='" + fiscalyear + "' and TypeOfMeeting=" + typeOfmeeting + " and MeetingDate='" + meetingDate.ToShortDateString() + "'";
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
         
        private void GetMeetingSessionByFiscalYear(string fiscalyear)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                
                try
                {
                    
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblMeetingSessionList, "SELECT * FROM tblMeetingSession where IsActive=1 and FiscalYear='" + fiscalyear + "' order by FiscalYear desc");


                   
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
            
        private bool GetMeetingSessionEntry(string fiscalyear,int typeOfmeeting, DateTime meetingDate)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.MeetingSessionExists(fiscalyear, typeOfmeeting,meetingDate))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblMeetingSession, "set dateformat dmy SELECT * FROM tblMeetingSession WHERE FiscalYear='" + fiscalyear + "' and TypeOfMeeting="+typeOfmeeting+" and MeetingDate='" + meetingDate.ToShortDateString() + "'");


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

        private void FiscalYearLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.FiscalYearLookUpEdit.EditValue != null && !Convert.IsDBNull(this.FiscalYearLookUpEdit.EditValue))
            {
                this._fiscalYear = Convert.ToString(this.FiscalYearLookUpEdit.EditValue);

                this.GetMeetingSessionByFiscalYear(this._fiscalYear);
            }
        }

        private void chkYearAll_CheckedChanged(object sender, EventArgs e)
        {
            this.InitForm(true);
        }

        private void MeetingDateDateTimePicker_Validated(object sender, EventArgs e)
        {
            this.MeetingDateEthTextBox.Text = clUtility.GetEthDate(MeetingDateDateTimePicker.Value);
            this._MeetingDate = MeetingDateDateTimePicker.Value;
            GetMeetingSessionEntry(this._fiscalYear,this._TypeOfMeeting, this._MeetingDate);
        }

        private void TypeOfMeetingLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.TypeOfMeetingLookUpEdit.EditValue != null && !Convert.IsDBNull(this.TypeOfMeetingLookUpEdit.EditValue))
            {
                this._TypeOfMeeting = Convert.ToInt32(this.TypeOfMeetingLookUpEdit.EditValue);

                
            }
        }

    }
}
