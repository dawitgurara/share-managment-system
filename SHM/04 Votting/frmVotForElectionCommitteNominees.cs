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
    public partial class frmVotForElectionCommitteNominees : Form
    {
       #region Fields
      

        private int _SessionId = 0;
        private int _NomineeSHId = 0;
        private int _VotingId = 0;
        private int _NomineeId = 0;

        private DataTable _tblVotingForCommitteeMemberNominees;
        private DataTable _tblMeetingAttendee;
        private DataTable _tblShareholderDetailrlu;
        private DataTable _tblMeetingSession;
        private DataTable _tblElectionCommitteeNominees;
        private DataTable _tblElectionCommitteeNomineesrlu;
       

        #endregion

        public frmVotForElectionCommitteNominees()
        {
            InitializeComponent();
        }

        private void frmVotForElectionCommitteNominees_Load(object sender, EventArgs e)
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
                this._tblElectionCommitteeNominees = DataObj.GetDataTable("tblElectionCommitteeNominees");
                this._tblMeetingAttendee = DataObj.GetDataTable("ViewAttendeesWithNominee");


                this._tblVotingForCommitteeMemberNominees = DataObj.GetDataTable("tblVotingForCommitteeMemberNominees");
                this._tblVotingForCommitteeMemberNominees.Columns["CrtDt"].ReadOnly = true;
                this._tblVotingForCommitteeMemberNominees.Columns["CrtWs"].ReadOnly = true;
                this._tblShareholderDetailrlu = DataObj.GetDataTable("tblShareholderDetail");
                this._tblElectionCommitteeNomineesrlu = DataObj.GetDataTable("tblElectionCommitteeNominees");
                clMain.SetDataSource(this.SessionIdLookUpEdit, this._tblMeetingSession);
                clMain.SetDataSource(this.NomineeSHIdLookUpEdit, this._tblElectionCommitteeNominees);
                clMain.SetRepositoryDataSource(this.rluNomineeSHIdNotSelected, this._tblElectionCommitteeNomineesrlu);
                clMain.SetRepositoryDataSource(this.rluNomineeSHIdSelected, this._tblElectionCommitteeNomineesrlu);
                clMain.SetRepositoryDataSource(this.rluVoterSHId, this._tblShareholderDetailrlu);
                clMain.SetRepositoryDataSource(this.rluVoterSHIdVotted, this._tblShareholderDetailrlu);
                this.SessionIdLookUpEdit.Properties.NullText = "-- Select Meeting Session --";
                this.NomineeSHIdLookUpEdit.Properties.NullText = "-- Select Election Committee Nominee --";
                clMain.SetDataSource(this.gctNotVotedSH, this._tblMeetingAttendee);
                clMain.SetDataSource(this.gctVotedSH, this._tblVotingForCommitteeMemberNominees);

               
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
                    DataObj.FillData(this._tblElectionCommitteeNomineesrlu, "SELECT  NomineeId,SessionId,NomineeSHId,NomineeFullName,NomineeFullNameAmharic FROM tblElectionCommitteeNominees   WHERE SessionId in (select SessionId from tblMeetingSession where IsActive=1)");
                    
                }
                else
                    this.GetNomineeByaSession(this._SessionId);
                DataObj.FillData(this._tblMeetingSession, "select SessionId,TypeOfMeeting,Description+' of Fiscal year '+FiscalYear+' on Date '+ convert(varchar(10),MeetingDate,103) as SessionNane,Venue from tblMeetingSession inner join tbltypeOfMeeting on tbltypeOfMeeting.Id=TypeOfMeeting where IsActive=1 order by MeetingDate desc");
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.GetAtendeesVot(this._SessionId, this._NomineeSHId);
                
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
                    
                   
                    if (this._tblVotingForCommitteeMemberNominees.Rows.Count == 0 )
                    {
                        AppMessageBox.ShowExclamation("Please select atleast one atendee Shareholder");
                        return;
                    }
                    DataObj.OpenConnection();
                    if (DataObj.UpdateTable(this._tblVotingForCommitteeMemberNominees))
                    {
                        this._VotingId = 0;
                        AppMessageBox.ShowInformation("A vote for Election Committee Nominee has been updated sucessfully");
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
                string cmdText = "delete from tblVotingForCommitteeMemberNominees where VotingId=" + this._VotingId;
                if(DataObj.Execute(cmdText))
                {
                    this._VotingId = 0;
                    AppMessageBox.ShowInformation("The Vote for Election Committee Nominee has been deleted sucessfully");
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
            this._NomineeSHId = 0;

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
                
                this.GetNomineeByaSession(this._SessionId);
                this.GetAtendeesVot(this._SessionId, this._NomineeSHId);
                
            }
        }

        private void GetNomineeByaSession(int SessionId)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();


                DataObj.FillData(this._tblElectionCommitteeNominees, "SELECT  NomineeId, NomineeSHId,NomineeFullName,NomineeFullNameAmharic FROM tblElectionCommitteeNominees   WHERE SessionId=" + SessionId);
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

        private void GetAtendeesVot(int sessionId, int NomineeSHId)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                if (sessionId != 0)
                {
                    if (NomineeSHId != 0)
                    {
                        DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, SHId, RegCode,FullName,FullNameAmharic,ShareNo,ShareAmnt,NomineeSHId FROM ViewAttendeesWithNominee WHERE NomineeSHId NOT IN (SELECT NomineeSHId FROM tblVotingForCommitteeMemberNominees WHERE SessionId=" + sessionId + " and NomineeSHId != " + NomineeSHId + ")");
                        this._NomineeSHId = 0;
                    }
                    else
                        DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, SHId, RegCode,FullName,FullNameAmharic,ShareNo,ShareAmnt,NomineeSHId FROM ViewAttendeesWithNominee WHERE SHId NOT IN (SELECT SHId FROM tblVotingForCommitteeMemberNominees WHERE SessionId=" + sessionId + ")");
                    DataObj.FillData(this._tblVotingForCommitteeMemberNominees, "SELECT  VotingId,SessionId, SHId, RegCode,ShareNo,ShareAmnt,NomineeSHId FROM tblVotingForCommitteeMemberNominees   WHERE SessionId=" + sessionId);
                }
                else
                {
                    this._tblMeetingAttendee.Clear();
                    this._tblVotingForCommitteeMemberNominees.Clear();
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

        //private void GetAtendeesVot(int sessionId,int NomineeId)
        //{
        //    clDatacon DataObj = new clDatacon(clMain.ConnString);
        //    try
        //    {
        //        DataObj.OpenConnection();

        //        if (sessionId != 0)
        //        {
        //            DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, NomineeId,SHId, RegCode,NomineeFullName,NomineeFullNameAmharic,ShareNo,ShareAmnt,NomineeSHId FROM ViewAttendeesWithNominee");
        //            //if (NomineeId != 0)
        //            //{
        //            //    DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, NomineeId,SHId, RegCode,NomineeFullName,NomineeFullNameAmharic,ShareNo,ShareAmnt,NomineeSHId FROM ViewAttendeesWithNominee WHERE NomineeSHId NOT IN (SELECT NomineeSHId FROM tblVotingForCommitteeMemberNominees WHERE SessionId=" + sessionId + " and NomineeSHId != " + NomineeId + ")");
        //            //   this._NomineeSHId = 0;
        //            //}
        //            //else
        //            //    DataObj.FillData(this._tblMeetingAttendee, "SELECT SessionId, NomineeId,SHId, RegCode,NomineeFullName,NomineeFullNameAmharic,ShareNo,ShareAmnt,NomineeSHId FROM ViewAttendeesWithNominee WHERE NomineeSHId NOT IN (SELECT NomineeSHId FROM tblVotingForCommitteeMemberNominees WHERE SessionId=" + sessionId + ")");
        //            DataObj.FillData(this._tblVotingForCommitteeMemberNominees, "SELECT  VotingId,SessionId,NomineeId, VoterSHId, RegCode,NomineeFullName,NomineeFullNameAmharic,ShareNo,ShareAmnt,NomineeSHId FROM tblVotingForCommitteeMemberNominees   WHERE SessionId=" + sessionId);
        //        }
        //        else
        //        {
        //            this._tblMeetingAttendee.Clear();
        //            this._tblVotingForCommitteeMemberNominees.Clear();
        //        }
                
        //      }
        //    catch (Exception Ex)
        //    {
        //        AppMessageBox.ShowExclamation(Ex.Message);
        //    }
        //    finally
        //    {
        //        DataObj.CloseConnection();
        //    }
        //}

        private void gridNotVotedSH_DoubleClick(object sender, EventArgs e)
        {
            //DataRow[] dr = new DataRow[5];
            
            if (this._SessionId == 0)
            {
                AppMessageBox.ShowExclamation("Please select the meeting session befor trying to select Nominee. ");
                return;
            }
           
            int focused = this.gridNotVotedSH.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridNotVotedSH.GetDataRow(focused);
                DataRow newRow;
                int nominee, votor;
                
                nominee = Convert.ToInt32(curRow["NomineeSHId"]);
                votor = Convert.ToInt32(curRow["SHId"]);
                //if (Convert.ToInt32(curRow["NomineeSHId"]) == Convert.ToInt32(curRow["SHId"]))
                //{
                //    AppMessageBox.ShowExclamation("Self voting is not allowed.");
                //    return;
                //}
                int counts = 0;
                int i = 0;
                if (this._tblVotingForCommitteeMemberNominees.Rows.Count > 0)
                {
                    do
                    {
                        if (Convert.ToInt32(this._tblVotingForCommitteeMemberNominees.Rows[i]["VoterSHId"]) == Convert.ToInt32(curRow["SHId"]))
                            counts++;
                        i++;
                    } while (counts < 5 && i < this._tblVotingForCommitteeMemberNominees.Rows.Count);
                    if (counts >= 5)
                    {
                        AppMessageBox.ShowExclamation("A shareholder can not vot for more than five Nominees.");
                        return;
                    }
                }
                
                newRow = this._tblVotingForCommitteeMemberNominees.NewRow();
                
               
                

                newRow["SessionId"] = this._SessionId;
                newRow["NomineeId"] = curRow["NomineeId"];
                newRow["NomineeSHId"] = curRow["NomineeSHId"];
                newRow["NomineeFullNameAmharic"] = curRow["NomineeFullNameAmharic"];
                newRow["NomineeFullName"] = curRow["NomineeFullName"];
                newRow["RegCode"] = curRow["RegCode"];
                newRow["VoterSHId"] = curRow["SHId"];
                newRow["ShareNo"] = curRow["ShareNo"];
                newRow["ShareAmnt"] = curRow["ShareAmnt"];
                newRow["CrtBy"] = clMain.User.UserName;
               
                this._tblVotingForCommitteeMemberNominees.Rows.Add(newRow);
                
                curRow.Delete();
                this.gridNotVotedSH.FocusedRowHandle = focused;
            }
        }

        private void gridVotedSH_DoubleClick(object sender, EventArgs e)
        {
            if (this._SessionId == 0)
            {
                AppMessageBox.ShowExclamation("Please select the meeting session befor trying to select Nominee. ");
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
                newRow["NomineeSHId"] = curRow["NomineeSHId"];
                newRow["RegCode"] = curRow["RegCode"];
                newRow["SHId"] = curRow["VoterSHId"];
                newRow["NomineeFullName"] = curRow["NomineeFullName"];
                newRow["NomineeFullNameAmharic"] = curRow["NomineeFullNameAmharic"];
                newRow["ShareNo"] = curRow["ShareNo"];
                newRow["ShareAmnt"] = curRow["ShareAmnt"];
               
                this._tblMeetingAttendee.Rows.Add(newRow);
                curRow.Delete();
            }
        }

        private void NomineeSHIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.NomineeSHIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.NomineeSHIdLookUpEdit.EditValue))
            {
                this._NomineeSHId = 0;

                this._tblMeetingAttendee.Rows.Clear();
                this._tblVotingForCommitteeMemberNominees.Rows.Clear();

            }
            else
            {
                this._NomineeSHId = Convert.ToInt32(this.NomineeSHIdLookUpEdit.EditValue);

                this.GetAtendeesVot(this._SessionId, this._NomineeSHId);

            }
        }

       

       

       


    }
}

