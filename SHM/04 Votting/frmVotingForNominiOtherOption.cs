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
    public partial class frmVotingForNominiOtherOption : Form
    {
        #region Fields

        private int _VotingId = 0;
        private int _VoterId = 0;
        private int _SessionId = 0;
        private int _NomineeId = 0;
        private int _NomineeSHId = 0;
        private string _NomineeFullName = "";
        private string _NomineeAmharicName = "";

        private DataTable _tblVotingForCommitteeMemberNominees;
        private DataTable _tblMeetingAttendee;
        private DataTable _tblShareholderDetailrlu;
        private DataTable _tblMeetingSession;
        private DataTable _tblElectionCommitteeNominees;
       

        #endregion

        public frmVotingForNominiOtherOption()
        {
            InitializeComponent();
        }

        private void frmVotingForNominiOtherOption_Load(object sender, EventArgs e)
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
                this._tblMeetingAttendee = DataObj.GetDataTable("tblMeetingAttendee");


                this._tblVotingForCommitteeMemberNominees = DataObj.GetDataTable("tblVotingForCommitteeMemberNominees");
                this._tblVotingForCommitteeMemberNominees.Columns["CrtDt"].ReadOnly = true;
                this._tblVotingForCommitteeMemberNominees.Columns["CrtWs"].ReadOnly = true;
                this._tblShareholderDetailrlu = DataObj.GetDataTable("tblShareholderDetail");
                clMain.SetDataSource(this.SessionIdLookUpEdit, this._tblMeetingSession);
                clMain.SetDataSource(this.NomineeSHIdLookUpEdit, this._tblElectionCommitteeNominees);
                clMain.SetRepositoryDataSource(this.rluSHIdNotVoted, this._tblShareholderDetailrlu);
                clMain.SetRepositoryDataSource(this.rluSHIdVoted, this._tblShareholderDetailrlu);
                this.SessionIdLookUpEdit.Properties.NullText = "-- Select Meeting Session --";
                this.NomineeSHIdLookUpEdit.Properties.NullText = "-- Select Election Comittee Nominee --";
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
                this.GetNomineesVot(this._SessionId, this._NomineeSHId);
                
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
                        AppMessageBox.ShowExclamation("Please select a meeting session");
                        this.SessionIdLookUpEdit.Focus();
                        return;
                    }
                    if (this._NomineeSHId == 0)
                    {
                        AppMessageBox.ShowExclamation("Please select a nominee");
                        this.NomineeSHIdLookUpEdit.Focus();
                        return;
                    }
                   
                    if (this._tblVotingForCommitteeMemberNominees.Rows.Count == 0 )
                    {
                        AppMessageBox.ShowExclamation("Please select atleast one voter Shareholder");
                        return;
                    }
                    DataObj.OpenConnection();
                    if (DataObj.UpdateTable(this._tblVotingForCommitteeMemberNominees))
                    {
                        AppMessageBox.ShowInformation("Vote for Nominee updated sucessfully");
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

                if (this._VotingId == 0)
                {
                    AppMessageBox.ShowExclamation("Please double click from the voter list to delete ");
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete the vot?") == DialogResult.No)
                    return;



                DataObj.OpenConnection();
                string cmdText = "delete from tblVotingForCommitteeMemberNominees where VotingId=" + this._VotingId;
                if (DataObj.Execute(cmdText))
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
                this._NomineeId = Convert.ToInt32(this.NomineeSHIdLookUpEdit.GetColumnValue("NomineeId"));
                this._NomineeFullName = this.NomineeSHIdLookUpEdit.GetColumnValue("NomineeFullName").ToString();
                this._NomineeAmharicName = this.NomineeSHIdLookUpEdit.GetColumnValue("NomineeFullNameAmharic").ToString();

                this.GetNomineesVot(this._SessionId,this._NomineeSHId);

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

        private void GetNomineesVot(int sessionId, int nomineShId)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                //DataObj.FillData(this._tblShareholderDetail, clShareholder.GetShareholderBrowseSql("SHStatus =1 and SHId NOT IN (SELECT SHId FROM tblMeetingAttendee WHERE SessionId=" + SessionId + ")"));
                DataObj.FillData(this._tblMeetingAttendee, "SELECT SHId, RegCode,ShareNo, ShareAmnt FROM tblMeetingAttendee  WHERE SessionId=" + sessionId + " and SHId NOT IN (SELECT VoterSHId FROM tblVotingForCommitteeMemberNominees WHERE SessionId=" + sessionId + " and NomineeSHId = " + nomineShId +") and SHId !="+nomineShId);
                DataObj.FillData(this._tblVotingForCommitteeMemberNominees, "SELECT  VotingId,SessionId, VoterSHId, RegCode,ShareNo,ShareAmnt FROM tblVotingForCommitteeMemberNominees   WHERE SessionId=" + sessionId + " and NomineeSHId = " + nomineShId);
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

        private int GetCountPerVotorPerSession(int SessionId,int voter)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            string cmdText = "";
            object obj;
            int count = 0;
            try
            {
                DataObj.OpenConnection();
                
                cmdText = "select count(VoterSHId) from tblVotingForCommitteeMemberNominees where VoterSHId=" + voter + " and SessionId=" + SessionId;
                obj = DataObj.GetDataScalar(cmdText);
                count=Convert.ToInt32(obj);
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
            }
            return count;
        }

        private void gridNotVotedSH_DoubleClick(object sender, EventArgs e)
        {
            if (this._SessionId == 0)
            {
                AppMessageBox.ShowExclamation("Please select the meeting session befor tying to select shareholder. ");
                return;
            }
            if (this._NomineeSHId == 0)
            {
                AppMessageBox.ShowExclamation("Please select the meeting agenda befor tying to select shareholder. ");
                return;
            }
            int focused = this.gridNotVotedSH.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridNotVotedSH.GetDataRow(focused);
                this._VoterId=Convert.ToInt32(curRow["SHId"]);
                int count=GetCountPerVotorPerSession(this._SessionId, this._VoterId);
                if (count >= 5)
                {
                    AppMessageBox.ShowExclamation("This Shareholder has already voted for five nominees. Not posible to vot for more than five nominees.");
                    return;
                }
                DataRow newRow;
                newRow = this._tblVotingForCommitteeMemberNominees.NewRow();
                newRow["SessionId"] = this._SessionId;
                newRow["NomineeId"] = this._NomineeId;
                newRow["NomineeSHId"] = this._NomineeSHId;
                newRow["NomineeFullName"] = this._NomineeFullName;
                newRow["NomineeFullNameAmharic"] = this._NomineeAmharicName;
                newRow["RegCode"] = curRow["RegCode"];
                newRow["VoterSHId"] = curRow["SHId"];
                newRow["ShareNo"] = curRow["ShareNo"];
                newRow["ShareAmnt"] = curRow["ShareAmnt"];
                newRow["CrtBy"] = clMain.User.UserName;
               
                this._tblVotingForCommitteeMemberNominees.Rows.Add(newRow);
                curRow.Delete();
            }
        }

        private void gridVotedSH_DoubleClick(object sender, EventArgs e)
        {
            if (this._SessionId == 0)
            {
                AppMessageBox.ShowExclamation("Please select the meeting session befor trying to select shareholder. ");
                return;
            }
            if (this._NomineeSHId == 0)
            {
                AppMessageBox.ShowExclamation("Please select the meeting agenda befor trying to select shareholder. ");
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
                newRow["RegCode"] = curRow["RegCode"];
                newRow["SHId"] = curRow["VoterSHId"];
                newRow["ShareNo"] = curRow["ShareNo"];
                newRow["ShareAmnt"] = curRow["ShareAmnt"];
               
                this._tblMeetingAttendee.Rows.Add(newRow);
                curRow.Delete();
            }
        }

       


    }
}
