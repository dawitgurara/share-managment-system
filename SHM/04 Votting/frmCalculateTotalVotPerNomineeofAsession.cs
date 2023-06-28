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
    public partial class frmCalculateTotalVotPerNomineeofAsession : Form
    {
         #region Fields
        private string _title = "Total Vot per Nominee of Meeting Session";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;
        
        private int _SessionId = 0;
        

        private DataTable _tblMeetingSession;
        private DataTable _tblElectionCommitteeNominees;
        private DataTable _tblTotalCalculatedVotPerNomineeofAsession;
        private DataRow _TotalCalculatedVotPerNomineeofAsession;

        private DataTable _PS_TotalVotperNomineeofAsession;

        private DataTable _tblTotalCalculatedVotPerNomineeofAsessionList;
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

        public frmCalculateTotalVotPerNomineeofAsession()
        {

            InitializeComponent();
        }

        private void frmCalculateTotalVotPerNomineeofAsession_Load(object sender, EventArgs e)
        {
            
            BindControls();
            InitForm(true);
        }

        private void frmCalculateTotalVotPerAgendaofAsession_KeyDown(object sender, KeyEventArgs e)
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
                this._tblElectionCommitteeNominees = DataObj.GetDataTable("tblElectionCommitteeNominees");

                clMain.SetDataSource(this.SessionIdLookUpEdit, this._tblMeetingSession);
                clMain.SetRepositoryDataSource(this.rluNomineeSHId, this._tblElectionCommitteeNominees);

                this._tblTotalCalculatedVotPerNomineeofAsession = DataObj.GetDataTable("tblTotalCalculatedVotPerNomineeofAsession");
                
                DataParameters[0] = new SqlParameter("SessionId", this._SessionId);
                this._PS_TotalVotperNomineeofAsession = DataObj.GetDataTable("PS_TotalVotperNomineeofAsession", true, DataParameters);
                this._tblTotalCalculatedVotPerNomineeofAsession.Columns["CrtDt"].ReadOnly = true;
                this._tblTotalCalculatedVotPerNomineeofAsession.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    
                    this.SessionIdLookUpEdit,
                    
                      
                });

                clMain.BindControls(cntrsList, this._tblTotalCalculatedVotPerNomineeofAsession);
                cntrsList.Clear();

                this._tblTotalCalculatedVotPerNomineeofAsessionList = DataObj.GetDataTable("tblTotalCalculatedVotPerNomineeofAsession");
                clMain.SetDataSource(this.gctTotalVot, this._tblTotalCalculatedVotPerNomineeofAsessionList);
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
                    DataObj.FillData(this._tblElectionCommitteeNominees, "select * from tblElectionCommitteeNominees");
                    this.refreshToolStripButton_Click(this, new EventArgs());
                }
                else
                    DataObj.FillData(this._tblTotalCalculatedVotPerNomineeofAsessionList, "SELECT * FROM tblTotalCalculatedVotPerNomineeofAsession where SessionId=" + this._SessionId + " order by SessionId");
               


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


            this._SessionId = 0;
            

            this.GetTotalVotInfoEntry(this._SessionId);
            this.SessionIdLookUpEdit.Focus();

        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._TotalCalculatedVotPerNomineeofAsession = this._tblTotalCalculatedVotPerNomineeofAsession.NewRow();
                clDatacon.SetToDatabaseDefaults(this._TotalCalculatedVotPerNomineeofAsession, clMain.ConnString);

                if (this._SessionId != 0) this._TotalCalculatedVotPerNomineeofAsession["SessionId"] = this._SessionId;
               
                this._TotalCalculatedVotPerNomineeofAsession["CrtBy"] = clMain.User.UserName;

                this._tblTotalCalculatedVotPerNomineeofAsession.Rows.Clear();
                this._tblTotalCalculatedVotPerNomineeofAsession.Rows.Add(this._TotalCalculatedVotPerNomineeofAsession);
                this._isLoadingEntry = false;
            }
        }

        private bool TotalVotInfoExists(int sessionId)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (sessionId == 0)
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT SessionId FROM tblTotalCalculatedVotPerNomineeofAsession WHERE SessionId=" + sessionId;
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
         
        private void GetTotalVotInfoBySession(int SessionId)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                
                try
                {
                    
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblTotalCalculatedVotPerNomineeofAsessionList, "SELECT * FROM tblTotalCalculatedVotPerNomineeofAsession where SessionId=" + SessionId + " order by SessionId");


                   
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
            
        private bool GetTotalVotInfoEntry(int sessionId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.TotalVotInfoExists(sessionId))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblTotalCalculatedVotPerNomineeofAsession, "SELECT * FROM tblTotalCalculatedVotPerNomineeofAsession WHERE SessionId=" + sessionId);


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

                this.GetTotalVotInfoBySession(this._SessionId);
            }
        }

        private void CalculateandSaveButton_Click(object sender, EventArgs e)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = false;
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

                   

                    DataObj.OpenConnection();
                    string cmdText;
                    cmdText = "delete from tblTotalCalculatedVotPerNomineeofAsession where SessionId="+this._SessionId;
                    this._TotalCalculatedVotPerNomineeofAsession = this._tblTotalCalculatedVotPerNomineeofAsession.Rows[0];
                    DataObj.Execute(cmdText);
                    if (this._isNew)
                    {
                        
                        DataParameters[0] = new SqlParameter("SessionId", this._SessionId);

                        DataObj.FillData(this._PS_TotalVotperNomineeofAsession, "PS_TotalVotperNomineeofAsession", true, DataParameters);
                        if (this._PS_TotalVotperNomineeofAsession.Rows.Count > 0)
                        {
                            for (int i = 0; i < this._PS_TotalVotperNomineeofAsession.Rows.Count; i++)
                            {
                                this._TotalCalculatedVotPerNomineeofAsession["NomineeSHId"] = _PS_TotalVotperNomineeofAsession.Rows[i]["NomineeSHId"];
                                this._TotalCalculatedVotPerNomineeofAsession["TotalShareholderVoted"] = _PS_TotalVotperNomineeofAsession.Rows[i]["NoOfShareholderVoted"];
                                this._TotalCalculatedVotPerNomineeofAsession["TotalShareNoVoted"] = _PS_TotalVotperNomineeofAsession.Rows[i]["NoOfShareVoted"];
                              success=DataObj.Insert(this._title, this._TotalCalculatedVotPerNomineeofAsession, false);
                             
                            
                            }
                            if (success)
                            {
                                AppMessageBox.ShowInformation(this._title+" is successfully calculated and saved");
                                InitForm(false);
                            }
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


