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
    public partial class frmVotforBoDNominee : Form
    {
        #region Fields


        private int _SessionId = 0;
        private int _NomineeSHId = 0;
        private int _VotingId = 0;
        

        private DataTable _tblVotForBoDNominees;
        private DataTable _tblMeetingAttendee;
        private DataTable _tblShareholderDetailrlu;
        private DataTable _tblMeetingSession;
        private DataTable _tblBoDNominees;
        private DataTable _tblBoDNomineeslu;


        #endregion
        public frmVotforBoDNominee()
        {
            InitializeComponent();
        }
        private void frmVotforBoDNominee_Load(object sender, EventArgs e)
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
                this._tblBoDNominees = DataObj.GetDataTable("tblBoDNominees");
                this._tblMeetingAttendee = DataObj.GetDataTable("ViewAttendeesWithBoDNominee");


                this._tblVotForBoDNominees = DataObj.GetDataTable("tblVotForBoDNominees");
                this._tblVotForBoDNominees.Columns["CrtDt"].ReadOnly = true;
                this._tblVotForBoDNominees.Columns["CrtWs"].ReadOnly = true;
                this._tblShareholderDetailrlu = DataObj.GetDataTable("tblShareholderDetail");
                this._tblBoDNomineeslu = DataObj.GetDataTable("tblBoDNominees");
                clMain.SetDataSource(this.SessionIdLookUpEdit, this._tblMeetingSession);
                clMain.SetDataSource(this.NomineeSHIdLookUpEdit, this._tblBoDNominees);
                clMain.SetRepositoryDataSource(this.rluNomineeSHIdNotSelected, this._tblBoDNomineeslu);
                clMain.SetRepositoryDataSource(this.rluNomineeSHIdSelected, this._tblBoDNomineeslu);
                clMain.SetRepositoryDataSource(this.rluVoterSHId, this._tblShareholderDetailrlu);
                clMain.SetRepositoryDataSource(this.rluVoterSHIdVotted, this._tblShareholderDetailrlu);
                this.SessionIdLookUpEdit.Properties.NullText = "-- Select Meeting Session --";
                this.NomineeSHIdLookUpEdit.Properties.NullText = "-- Select BoDs Nominee --";
                clMain.SetDataSource(this.gctNotVotedSH, this._tblMeetingAttendee);
                clMain.SetDataSource(this.gctVotedSH, this._tblVotForBoDNominees);


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
                    DataObj.FillData(this._tblBoDNomineeslu, "SELECT  NomineeId,SessionId,NomineeSHId,NomineeFullName,NomineeFullNameAmharic FROM tblBoDNominees   WHERE SessionId in (select SessionId from tblMeetingSession where IsActive=1)");

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


                    if (this._tblVotForBoDNominees.Rows.Count == 0)
                    {
                        AppMessageBox.ShowExclamation("Please select atleast one atendee Shareholder");
                        return;
                    }
                    DataObj.OpenConnection();
                    if (DataObj.UpdateTable(this._tblVotForBoDNominees))
                    {
                        this._VotingId = 0;
                        AppMessageBox.ShowInformation("A vote for Board of Directors Nominee has been updated sucessfully");
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
                string cmdText = "delete from tblVotForBoDNominees where VotingId=" + this._VotingId;
                if (DataObj.Execute(cmdText))
                {
                    this._VotingId = 0;
                    AppMessageBox.ShowInformation("The Vote for Board of Directors Nominee has been deleted sucessfully");
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
            this.SessionIdLookUpEdit.EditValue = null;
            this.NomineeSHIdLookUpEdit.EditValue = null;
           

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


                DataObj.FillData(this._tblBoDNominees, "SELECT  NomineeId, NomineeSHId,NomineeRegCode,NomineeFullName,NomineeFullNameAmharic FROM tblBoDNominees   WHERE SessionId=" + SessionId);
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
                        DataObj.FillData(this._tblMeetingAttendee, "SELECT top 100 percent SessionId, SHId, RegCode,FullName,FullNameAmharic,ShareNo,ShareAmnt,NomineeId,NomineeRegCode,NomineeSHId,NomineeFullName,NomineeFullNameAmharic,IsNombyNonInfluence,IsNomineeformermBoDs,PecentageOfShareSubscribed FROM ViewAttendeesWithBoDNominee WHERE NomineeSHId NOT IN (SELECT NomineeSHId FROM tblVotForBoDNominees WHERE SessionId=" + sessionId + " and NomineeSHId != " + NomineeSHId + ")order by RegCode,nomineeId");
                        this._NomineeSHId = 0;
                    }
                    else
                        DataObj.FillData(this._tblMeetingAttendee, "SELECT  top 100 percent SessionId, SHId, RegCode,FullName,FullNameAmharic,ShareNo,ShareAmnt,NomineeId,NomineeSHId,NomineeRegCode,NomineeFullName,NomineeFullNameAmharic,IsNombyNonInfluence,IsNomineeformermBoDs,PecentageOfShareSubscribed FROM ViewAttendeesWithBoDNominee WHERE SHId NOT IN (SELECT VoterSHId FROM tblVotForBoDNominees WHERE SessionId=" + sessionId + ")order by RegCode,nomineeId");
                    DataObj.FillData(this._tblVotForBoDNominees, "SELECT  top 100 percent VotingId,SessionId, VoterSHId, RegCode,NomineeFullName,ShareNo,ShareAmnt,NomineeId,NomineeRegCode,NomineeSHId,IsNombyNonInfluence FROM tblVotForBoDNominees   WHERE SessionId=" + sessionId + "order by RegCode,nomineeId");
                }
                else
                {
                    this._tblMeetingAttendee.Clear();
                    this._tblVotForBoDNominees.Clear();
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
                if (this._tblVotForBoDNominees.Rows.Count > 0)
                {
                    do
                    {
                        if (Convert.ToInt32(this._tblVotForBoDNominees.Rows[i]["VoterSHId"]) == Convert.ToInt32(curRow["SHId"]))
                            counts++;
                        i++;
                    } while (counts < 9 && i < this._tblVotForBoDNominees.Rows.Count);
                    if (counts >= 9)
                    {
                        AppMessageBox.ShowExclamation("A shareholder can not vot for more than nine Nominees.");
                        return;
                    }
                }

                newRow = this._tblVotForBoDNominees.NewRow();




                newRow["SessionId"] = this._SessionId;
                newRow["NomineeId"] = curRow["NomineeId"];
                newRow["NomineeSHId"] = curRow["NomineeSHId"];
                newRow["NomineeRegCode"] = curRow["NomineeRegCode"];
                newRow["NomineeFullNameAmharic"] = curRow["NomineeFullNameAmharic"];
                newRow["NomineeFullName"] = curRow["NomineeFullName"];
                newRow["RegCode"] = curRow["RegCode"];
                newRow["VoterSHId"] = curRow["SHId"];
                newRow["ShareNo"] = curRow["ShareNo"];
                newRow["ShareAmnt"] = curRow["ShareAmnt"];
                decimal percentage = Convert.ToDecimal(curRow["PecentageOfShareSubscribed"]);
                newRow["IsNombyNonInfluence"] = curRow["IsNombyNonInfluence"];
                if (Convert.ToDecimal(curRow["PecentageOfShareSubscribed"]) >= 2)
                    newRow["IsVoterInfluencial"] = 1;
                else
                    newRow["IsVoterInfluencial"] = 0;
                newRow["IsNomineeformermBoDs"] = curRow["IsNomineeformermBoDs"];
                newRow["CrtBy"] = clMain.User.UserName;

                this._tblVotForBoDNominees.Rows.Add(newRow);

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
                newRow["NomineeRegCode"] = curRow["NomineeRegCode"];
                newRow["RegCode"] = curRow["RegCode"];
                newRow["SHId"] = curRow["VoterSHId"];
                newRow["NomineeFullName"] = curRow["NomineeFullName"];
                newRow["NomineeFullNameAmharic"] = curRow["NomineeFullNameAmharic"];
                newRow["ShareNo"] = curRow["ShareNo"];
                newRow["ShareAmnt"] = curRow["ShareAmnt"];
                newRow["IsNombyNonInfluence"] = curRow["IsNombyNonInfluence"];

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
                this._tblVotForBoDNominees.Rows.Clear();

            }
            else
            {
                this._NomineeSHId = Convert.ToInt32(this.NomineeSHIdLookUpEdit.EditValue);

                this.GetAtendeesVot(this._SessionId, this._NomineeSHId);

            }
        }


        private void SaveVote()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (this.Validate())
                {
                    this.SessionIdLookUpEdit.Focus();

                    if (SessionIdLookUpEdit.EditValue.ToString() == "0")
                    {
                        AppMessageBox.ShowExclamation("Please select meeting session");
                        this.SessionIdLookUpEdit.Focus();
                        return;
                    }


                    if (this._tblVotForBoDNominees.Rows.Count == 0)
                    {
                        AppMessageBox.ShowExclamation("Please select atleast one atendee Shareholder");
                        return;
                    }
                    DataObj.OpenConnection();
                    if (DataObj.UpdateTable(this._tblVotForBoDNominees))
                    {
                        this._VotingId = 0;
                        AppMessageBox.ShowInformation("A vote for Board of Directors Nominee has been updated sucessfully");
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

        private void DeleteVote()
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
                string cmdText = "delete from tblVotForBoDNominees where VotingId=" + this._VotingId;
                if (DataObj.Execute(cmdText))
                {
                    this._VotingId = 0;
                    AppMessageBox.ShowInformation("The Vote for Board of Directors Nominee has been deleted sucessfully");
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
        




    }
}


