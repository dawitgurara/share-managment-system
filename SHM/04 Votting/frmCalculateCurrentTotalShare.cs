using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SHM
{
    public partial class frmCalculateCurrentTotalShare : Form
    {
         #region Fields
        private string _title = "Total Share Calculated";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;
        
        private int _SessionId = 0;
        private int _SessionType = 0;
        

        private DataTable _tblMeetingSession;
        private DataTable _tblTotalShareCalculatedPerMeetingSession;
        private DataRow _TotalShareCalculatedPerMeetingSession;
        private DataTable _ViewTotalShareInfo;
        private DataTable _ViewTotalAtendeeShareholders;

        private DataTable _tblTotalShareCalculatedPerMeetingSessionList;
        private SqlParameter[] DataParameters = new SqlParameter[1];
       
       




        #endregion

        #region Properties
        public bool IsNew
        {
            get { return this._isNew; }
            set
            {
                this._isNew = value;
               
            }
        }
        #endregion

        public frmCalculateCurrentTotalShare()
        {

            InitializeComponent();
        }

        private void frmCalculateCurrentTotalShare_Load(object sender, EventArgs e)
        {
            
            BindControls();
            InitForm(true);
        }

        private void frmCalculateCurrentTotalShare_KeyDown(object sender, KeyEventArgs e)
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


                this._tblMeetingSession = DataObj.GetDataTable("tblMeetingSession");

                clMain.SetDataSource(this.SessionIdLookUpEdit, this._tblMeetingSession);


                this._tblTotalShareCalculatedPerMeetingSession = DataObj.GetDataTable("tblTotalShareCalculatedPerMeetingSession");
                this._ViewTotalShareInfo = DataObj.GetDataTable("ViewTotalShareInfo");
                
                this._ViewTotalAtendeeShareholders = DataObj.GetDataTable("ViewTotalAtendeeShareholders");
                this._tblTotalShareCalculatedPerMeetingSession.Columns["DateCalculated"].ReadOnly = true;
                this._tblTotalShareCalculatedPerMeetingSession.Columns["CrtDt"].ReadOnly = true;
                this._tblTotalShareCalculatedPerMeetingSession.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    
                    this.SessionIdLookUpEdit,
                    
                      
                });

                clMain.BindControls(cntrsList, this._tblTotalShareCalculatedPerMeetingSession);
                cntrsList.Clear();

                this._tblTotalShareCalculatedPerMeetingSessionList = DataObj.GetDataTable("tblTotalShareCalculatedPerMeetingSession");
                clMain.SetDataSource(this.gctTotalShare, this._tblTotalShareCalculatedPerMeetingSessionList);
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

                    DataObj.FillData(this._tblMeetingSession, "select SessionId,TypeOfMeeting,Description+' of Fiscal year '+FiscalYear+' on Date '+ convert(varchar(10),MeetingDate,103) as SessionName,Venue from tblMeetingSession inner join tbltypeOfMeeting on tbltypeOfMeeting.Id=TypeOfMeeting where IsActive=1 order by MeetingDate desc");
                   
                }
                else
                    DataObj.FillData(this._tblTotalShareCalculatedPerMeetingSessionList, "SELECT * FROM tblTotalShareCalculatedPerMeetingSession");
               


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

       
     
        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {


            this._SessionId = 0;
            

            this.GetTotalShareInfoEntry(this._SessionId);
            this.SessionIdLookUpEdit.Focus();

        }

      

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._TotalShareCalculatedPerMeetingSession = this._tblTotalShareCalculatedPerMeetingSession.NewRow();
                clDatacon.SetToDatabaseDefaults(this._TotalShareCalculatedPerMeetingSession, clMain.ConnString);

                if (this._SessionId != 0) this._TotalShareCalculatedPerMeetingSession["SessionId"] = this._SessionId;
               
                this._TotalShareCalculatedPerMeetingSession["CrtBy"] = clMain.User.UserName;

                this._tblTotalShareCalculatedPerMeetingSession.Rows.Clear();
                this._tblTotalShareCalculatedPerMeetingSession.Rows.Add(this._TotalShareCalculatedPerMeetingSession);
                this._isLoadingEntry = false;
            }
        }

        private bool TotalShareInfoExists(int sessionId)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (sessionId == 0)
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT SessionId FROM tblTotalShareCalculatedPerMeetingSession WHERE SessionId=" + sessionId;
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
         
        private void GetTotalShareInfoBySession(int SessionId)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                
                try
                {
                    
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblTotalShareCalculatedPerMeetingSessionList, "SELECT * FROM tblTotalShareCalculatedPerMeetingSession where SessionId=" + SessionId + " order by SessionId");


                   
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
            
        private bool GetTotalShareInfoEntry(int sessionId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.TotalShareInfoExists(sessionId))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblTotalShareCalculatedPerMeetingSession, "SELECT * FROM tblTotalShareCalculatedPerMeetingSession WHERE SessionId=" + sessionId );


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

        private void SessionIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SessionIdLookUpEdit.EditValue != null && !Convert.IsDBNull(this.SessionIdLookUpEdit.EditValue))
            {
                this._SessionId = Convert.ToInt32(this.SessionIdLookUpEdit.EditValue);
                this._SessionType = Convert.ToInt32(this.SessionIdLookUpEdit.GetColumnValue("TypeOfMeeting"));


                this.GetTotalShareInfoBySession(this._SessionId);
            }
        }

        private void CalculateandSaveButton_Click(object sender, EventArgs e)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (this.Validate())
                {

                    this.SessionIdLookUpEdit.Focus();
                    if (this._SessionId == 0)
                    {
                        AppMessageBox.ShowExclamation("Please select meeting Session");
                        this.SessionIdLookUpEdit.Focus();
                        return;
                    }

                    this._TotalShareCalculatedPerMeetingSession = this._tblTotalShareCalculatedPerMeetingSession.Rows[0];

                    DataObj.OpenConnection();
                    string cmdText;
                    cmdText = "delete from tblTotalShareCalculatedPerMeetingSession where SessionId="+this._SessionId;
                    DataObj.Execute(cmdText);
                    if (this._isNew)
                    {
                        
                       
                        
                        DataObj.FillData(this._ViewTotalShareInfo, "SELECT * FROM ViewTotalShareInfo");
                        if (this._SessionType == 2)
                        {
                            this._ViewTotalAtendeeShareholders = DataObj.GetDataTable("ViewTotalEmergencyAtendeeShareholders");
                            DataObj.FillData(this._ViewTotalAtendeeShareholders, "Select * from ViewTotalEmergencyAtendeeShareholders");
                        }
                        else
                        {
                            this._ViewTotalAtendeeShareholders = DataObj.GetDataTable("ViewTotalAtendeeShareholders");
                            DataObj.FillData(this._ViewTotalAtendeeShareholders, "Select * from ViewTotalAtendeeShareholders");
                        }
                        if (this._ViewTotalShareInfo.Rows.Count > 0 && Convert.ToInt32(this._ViewTotalAtendeeShareholders.Rows[0]["TotalNoOfAtendee"]) > 0)
                        {
                            this._TotalShareCalculatedPerMeetingSession["CurTotalSubscribedShareNo"] = _ViewTotalShareInfo.Rows[0]["TotalSubscribedShNo"];
                            this._TotalShareCalculatedPerMeetingSession["CurTotalSubscribedShareAmnt"] = _ViewTotalShareInfo.Rows[0]["TotalSubscribedShAmnt"];
                            this._TotalShareCalculatedPerMeetingSession["CurTotalPaidupShareNo"] = _ViewTotalShareInfo.Rows[0]["TotalPaidupShNo"];
                            this._TotalShareCalculatedPerMeetingSession["CurTotalPaidupShareAmnt"] = _ViewTotalShareInfo.Rows[0]["TotalPaidupShAmnt"];
                            this._TotalShareCalculatedPerMeetingSession["CurTotalNoOfShareholder"] = _ViewTotalShareInfo.Rows[0]["TotalNoOfShareholder"];
                            this._TotalShareCalculatedPerMeetingSession["TotalNoOfAtendeeShareholder"] = _ViewTotalAtendeeShareholders.Rows[0]["TotalNoOfAtendee"];
                            this._TotalShareCalculatedPerMeetingSession["TotalNoOfAtendeeShareSubscribe"] = _ViewTotalAtendeeShareholders.Rows[0]["TotalAtendeeShareNo"];
                            this._TotalShareCalculatedPerMeetingSession["TotalAmntOfAtendeeShareSubscribe"] = _ViewTotalAtendeeShareholders.Rows[0]["TotalAtendeeShereAmnt"];

                            if (DataObj.Insert(this._title, this._TotalShareCalculatedPerMeetingSession, true))
                            {
                                InitForm(false);
                            }
                        }
                        else
                        {
                            AppMessageBox.ShowExclamation("No attendee record is found to calculate total share");
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

       

       
       

    }
}

