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
    public partial class frmVotingForAgenda : Form
    {
      #region Fields
      

        private int _SessionId = 0;
        private int _AgendaId = 0;
        private int _VotingId = 0;
        private int _MeetingType = 0;

        private DataTable _tblVotingForAgenda;
        private DataTable _tblMeetingAttendee;
        private DataTable _tblShareholderDetailrlu;
        private DataTable _tblMeetingSession;
        private DataTable _tblMeetingAgenda;
        private DataTable _tblMeetingAgendarlu;
       

        #endregion

        public frmVotingForAgenda()
        {
            InitializeComponent();
        }

        private void frmVotingForAgenda_Load(object sender, EventArgs e)
        {
            
            
            BindControls();
            InitForm(true);
        }

        private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                this._tblMeetingSession = DataObj.GetDataTable("tblMeetingSession");
                this._tblMeetingAgenda = DataObj.GetDataTable("tblMeetingAgenda");
                this._tblMeetingAttendee = DataObj.GetDataTable("ViewAttendeesWithAgenda");


                this._tblVotingForAgenda = DataObj.GetDataTable("tblVotingForAgenda");
                this._tblVotingForAgenda.Columns["CrtDt"].ReadOnly = true;
                this._tblVotingForAgenda.Columns["CrtWs"].ReadOnly = true;
                this._tblShareholderDetailrlu = DataObj.GetDataTable("tblShareholderDetail");
                this._tblMeetingAgendarlu = DataObj.GetDataTable("tblMeetingAgenda");
                clMain.SetDataSource(this.SessionIdLookUpEdit, this._tblMeetingSession);
                clMain.SetDataSource(this.AgendaIdLookUpEdit, this._tblMeetingAgenda);
                clMain.SetRepositoryDataSource(this.rluAgendaIdNotAttend, this._tblMeetingAgendarlu);
                clMain.SetRepositoryDataSource(this.rluAgendaIdAttend, this._tblMeetingAgendarlu);
                clMain.SetRepositoryDataSource(this.rluSHIdNotAtend, this._tblShareholderDetailrlu);
                clMain.SetRepositoryDataSource(this.rluSHIdAttend, this._tblShareholderDetailrlu);
                this.SessionIdLookUpEdit.Properties.NullText = "-- Select Meeting Session --";
                this.AgendaIdLookUpEdit.Properties.NullText = "-- Select Meeting Agenda --";
                clMain.SetDataSource(this.gctNotVotedSH, this._tblMeetingAttendee);
                clMain.SetDataSource(this.gctVotedSH, this._tblVotingForAgenda);

               
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
                    DataObj.FillData(this._tblShareholderDetailrlu, clShareholder.GetShareholderBrowseSql(true));
                    
                    
                }
                else
                    this.GetAgendaByaSession(this._SessionId);
                DataObj.FillData(this._tblMeetingSession, "select SessionId,TypeOfMeeting,Description+' of Fiscal year '+FiscalYear+' on Date '+ convert(varchar(10),MeetingDate,103) as SessionNane,Venue from tblMeetingSession inner join tbltypeOfMeeting on tbltypeOfMeeting.Id=TypeOfMeeting where IsActive=1 order by MeetingDate desc");
                DataObj.FillData(this._tblMeetingAgendarlu, "SELECT  AgendaId, Agenda FROM tblMeetingAgenda   WHERE SessionId in (select SessionId from tblMeetingSession where SessionId=" + this._SessionId + ")");
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();

                if (_MeetingType == 1)
                    this.GetAtendeesVot(this._SessionId, this._AgendaId);
                else if (_MeetingType == 2)
                    this.GetAtendeesVotforEmergMet(this._SessionId, this._AgendaId);
                
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (this.Validate())
                {
                    this.SessionIdLookUpEdit.Focus();

                    if (this._SessionId == 0)
                    {
                        AppMessageBox.ShowExclamation("Please select meeting session");
                        this.SessionIdLookUpEdit.Focus();
                        return;
                    }
                    
                   
                    if (this._tblVotingForAgenda.Rows.Count == 0 )
                    {
                        AppMessageBox.ShowExclamation("Please select atleast one atendee Shareholder");
                        return;
                    }
                    DataObj.OpenConnection();
                    if (DataObj.UpdateTable(this._tblVotingForAgenda))
                    {
                        this._VotingId = 0;
                        AppMessageBox.ShowInformation("A vote for agenda has been updated sucessfully");
                        InitForm(false);
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

                if (this._VotingId ==0)
                {
                    AppMessageBox.ShowExclamation("Please double click from the voter list to delete " );
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete the vot?") == DialogResult.No)
                    return;

                

                DataObj.OpenConnection();
                string cmdText = "delete from tblVotingForAgenda where VotingId=" + this._VotingId;
                if(DataObj.Execute(cmdText))
                {
                    this._VotingId = 0;
                    AppMessageBox.ShowInformation("The Vote for agenda has been deleted sucessfully");
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

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._SessionId = 0;
            this._AgendaId = 0;
            this.SessionIdLookUpEdit.EditValue = null;
            this.AgendaIdLookUpEdit.EditValue = null;

            InitForm(true);
        }

        private void SessionIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SessionIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.SessionIdLookUpEdit.EditValue))
            {
                this._SessionId = 0;
                
               
            }
            else
            {
                this._SessionId = Convert.ToInt32(this.SessionIdLookUpEdit.EditValue);
                
                this.GetAgendaByaSession(this._SessionId);
                this._MeetingType = Convert.ToInt16(this.SessionIdLookUpEdit.GetColumnValue("TypeOfMeeting"));
                if (_MeetingType == 1)
                   this.GetAtendeesVot(this._SessionId, this._AgendaId);
                else if (_MeetingType == 2)
                   this.GetAtendeesVotforEmergMet(this._SessionId, this._AgendaId);
                
            }
        }

        private void AgendaIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.AgendaIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.AgendaIdLookUpEdit.EditValue))
            {
                this._AgendaId = 0;

                this._tblMeetingAttendee.Rows.Clear();
                this._tblVotingForAgenda.Rows.Clear();

            }
            else
            {
                this._AgendaId = Convert.ToInt32(this.AgendaIdLookUpEdit.EditValue);

                if (Convert.ToInt16(this.SessionIdLookUpEdit.GetColumnValue("TypeOfMeeting")) == 1)
                    this.GetAtendeesVot(this._SessionId, this._AgendaId);
                else if (Convert.ToInt16(this.SessionIdLookUpEdit.GetColumnValue("TypeOfMeeting")) == 2)
                    this.GetAtendeesVotforEmergMet(this._SessionId, this._AgendaId);

            }
        }

        private void GetAgendaByaSession(int SessionId)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();


                DataObj.FillData(this._tblMeetingAgenda, "SELECT  AgendaId, Agenda FROM tblMeetingAgenda   WHERE SessionId=" + SessionId);
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

        private void GetAtendeesVot(int sessionId,int agendaId)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                if (sessionId != 0)
                {
                    DataObj.FillData(this._tblMeetingAgendarlu, "SELECT  AgendaId, Agenda FROM tblMeetingAgenda   WHERE SessionId in (select SessionId from tblMeetingSession where SessionId=" + sessionId + ")");
                    if (agendaId != 0)
                    {
                        //DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, SHId, RegCode,ShareNo,ShareAmnt,AgendaId FROM ViewAttendeesWithAgenda WHERE AgendaId NOT IN (SELECT AgendaId FROM tblVotingForAgenda WHERE SessionId=" + sessionId + " and AgendaId != " + agendaId + ")");
                        DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, SHId, RegCode,ShareNo,ShareAmnt,AgendaId FROM ViewAttendeesWithAgenda WHERE AgendaId NOT IN (SELECT AgendaId FROM tblVotingForAgenda WHERE AgendaId != " + agendaId + ")and SessionId=" + sessionId);
                        this._AgendaId = 0;
                    }
                    else
                        DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, SHId, RegCode,ShareNo,ShareAmnt,AgendaId FROM ViewAttendeesWithAgenda WHERE SHId NOT IN (SELECT SHId FROM tblVotingForAgenda WHERE SessionId=" + sessionId + ")");
                    DataObj.FillData(this._tblVotingForAgenda, "SELECT  VotingId,SessionId, SHId, RegCode,ShareNo,ShareAmnt,AgendaId FROM tblVotingForAgenda   WHERE SessionId=" + sessionId);
                }
                else
                {
                    this._tblMeetingAttendee.Clear();
                    this._tblVotingForAgenda.Clear();
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

        private void GetAtendeesVotforEmergMet(int sessionId,int agendaId)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                if (sessionId != 0)
                {
                    DataObj.FillData(this._tblMeetingAgendarlu, "SELECT  AgendaId, Agenda FROM tblMeetingAgenda   WHERE SessionId in (select SessionId from tblMeetingSession where SessionId=" + sessionId + ")");
                    if (agendaId != 0)
                    {
                        //DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, SHId, RegCode,ShareNo,ShareAmnt,AgendaId FROM ViewAttendeesWithAgendaOfEmergmet WHERE AgendaId NOT IN (SELECT AgendaId FROM tblVotingForAgenda WHERE SessionId=" + sessionId + " and AgendaId != " + agendaId + ")");
                        DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, SHId, RegCode,ShareNo,ShareAmnt,AgendaId FROM ViewAttendeesWithAgendaOfEmergmet WHERE AgendaId NOT IN (SELECT AgendaId FROM tblVotingForAgenda WHERE AgendaId != " + agendaId + ")and SessionId=" + sessionId);
                        this._AgendaId = 0;
                    }
                    else
                        DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, SHId, RegCode,ShareNo,ShareAmnt,AgendaId FROM ViewAttendeesWithAgendaOfEmergmet WHERE SHId NOT IN (SELECT SHId FROM tblVotingForAgenda WHERE SessionId=" + sessionId + ")");
                        //DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, SHId, RegCode,ShareNo,ShareAmnt,AgendaId FROM ViewAttendeesWithAgendaOfEmergmet WHERE SHId NOT IN (SELECT SHId FROM tblVotingForAgenda where AgendaId in(select AgendaId from tblMeetingAgenda where SessionId=" + sessionId + ")) order by Regcode");
                        DataObj.FillData(this._tblVotingForAgenda, "SELECT  VotingId,SessionId, SHId, RegCode,ShareNo,ShareAmnt,AgendaId FROM tblVotingForAgenda   WHERE SessionId=" + sessionId);
                        
                }
                else
                {
                    this._tblMeetingAttendee.Clear();
                    this._tblVotingForAgenda.Clear();
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

        private void gridNotVotedSH_DoubleClick(object sender, EventArgs e)
        {
            if (this._SessionId == 0)
            {
                AppMessageBox.ShowExclamation("Please select the meeting session befor tying to select shareholder. ");
                return;
            }
           
            int focused = this.gridNotVotedSH.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridNotVotedSH.GetDataRow(focused);
                DataRow newRow;
                newRow = this._tblVotingForAgenda.NewRow();
                newRow["SessionId"] = this._SessionId;
                newRow["AgendaId"] = curRow["AgendaId"];
                newRow["RegCode"] = curRow["RegCode"];
                newRow["SHId"] = curRow["SHId"];
                newRow["ShareNo"] = curRow["ShareNo"];
                newRow["ShareAmnt"] = curRow["ShareAmnt"];
                newRow["CrtBy"] = clMain.User.UserName;
               
                this._tblVotingForAgenda.Rows.Add(newRow);
                curRow.Delete();
            }
        }

        private void gridVotedSH_DoubleClick(object sender, EventArgs e)
        {
            if (this._SessionId == 0)
            {
                AppMessageBox.ShowExclamation("Please select the meeting session befor trying to select Agenda. ");
                return;
            }
            
            int focused = this.gridVotedSH.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridVotedSH.GetDataRow(focused);
                this._VotingId = Convert.ToInt32(curRow["VotingId"]);
                DataRow newRow;
                newRow = this._tblMeetingAttendee.NewRow();
                newRow["SessionId"] = this._SessionId;
                newRow["AgendaId"] = curRow["AgendaId"];
                newRow["RegCode"] = curRow["RegCode"];
                newRow["SHId"] = curRow["SHId"];
                newRow["ShareNo"] = curRow["ShareNo"];
                newRow["ShareAmnt"] = curRow["ShareAmnt"];
               
                this._tblMeetingAttendee.Rows.Add(newRow);
                curRow.Delete();
            }
        }

       

       

       


    }
}
