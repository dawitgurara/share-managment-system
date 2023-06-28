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
    public partial class frmEmergencyMeetingAttendee : Form
    {
         #region Fields
      

        private int _SessionId = 0;
        private int _SHId = 0;
       
        private DataTable _tblMeetingAttendee;
        private DataTable _tblShareholderDetail;
        private DataTable _tblShareholderDetailrlu;
        private DataTable _tblMeetingSession;
       

        #endregion

        public frmEmergencyMeetingAttendee()
        {
            InitializeComponent();
        }

        private void frmEmergencyMeetingAttendee_Load(object sender, EventArgs e)
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
                this._tblShareholderDetail = DataObj.GetDataTable("tblShareholderDetail");


                this._tblMeetingAttendee = DataObj.GetDataTable("tblEmergencyMeetingAttendee");
                this._tblMeetingAttendee.Columns["CrtDt"].ReadOnly = true;
                this._tblMeetingAttendee.Columns["CrtWs"].ReadOnly = true;
                this._tblShareholderDetailrlu = DataObj.GetDataTable("tblShareholderDetail");
                clMain.SetDataSource(this.SessionIdLookUpEdit, this._tblMeetingSession);
                clMain.SetRepositoryDataSource(this.rluSHIdNotAtend, this._tblShareholderDetailrlu);
                clMain.SetRepositoryDataSource(this.rluSHIdAtend, this._tblShareholderDetailrlu);
                this.SessionIdLookUpEdit.Properties.NullText = "-- Select Meeting Session --";
                clMain.SetDataSource(this.gctNotAtendedSH, this._tblShareholderDetail);
                clMain.SetDataSource(this.gctAtendedSH, this._tblMeetingAttendee);

               
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
                    this.GetMeetingAtendee(this._SessionId);
                DataObj.FillData(this._tblMeetingSession, "select SessionId,TypeOfMeeting,Description+' of Fiscal year '+FiscalYear+' on Date '+ convert(varchar(10),MeetingDate,103) as SessionName,Venue from tblMeetingSession inner join tbltypeOfMeeting on tbltypeOfMeeting.Id=TypeOfMeeting where IsActive=1 and TypeOfMeeting=2 order by MeetingDate desc");
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                //this.GetMeetingAtendee(this._SessionId);
                
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
                        AppMessageBox.ShowExclamation("Please select meeting Session");
                        this.SessionIdLookUpEdit.Focus();
                        return;
                    }

                   
                    if (this._tblMeetingAttendee.Rows.Count == 0 )
                    {
                        AppMessageBox.ShowExclamation("Please select atleast one atendee Shareholder");
                        return;
                    }
                    DataObj.OpenConnection();
                    if (DataObj.UpdateTable(this._tblMeetingAttendee))
                    {
                        AppMessageBox.ShowInformation("Meeting atendee/s has been updated sucessfully");
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
                if (this._SessionId == 0)
                {
                    AppMessageBox.ShowExclamation("Please select meeting Session");
                    this.SessionIdLookUpEdit.Focus();
                    return;
                }
                if (this._SHId == 0)
                {
                    AppMessageBox.ShowExclamation("Please double click from the attendee list to delete ");
                    return;
                }
                if (AttendeeVoted(this._SessionId, this._SHId))
                {
                    AppMessageBox.ShowExclamation("This attendee has already voted. Please go to the vot for agnda screen and delete the vot before trying to delete the attendee");
                    this.SessionIdLookUpEdit.Focus();
                    return;
                }
                if (AppMessageBox.ShowQuestion("Are you sure you want to delete the attendee?") == DialogResult.No)
                    return;



                DataObj.OpenConnection();
                string cmdText = "delete from tblEmergencyMeetingAttendee where sessionId=" + this._SessionId + " and SHId=" + this._SHId;
                if (DataObj.Execute(cmdText))
                {
                    this._SHId = 0;
                    AppMessageBox.ShowInformation("the attendee  has been deleted sucessfully");
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
            InitForm(false);
        }

        private void SessionIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SessionIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.SessionIdLookUpEdit.EditValue))
            {
                this._SessionId = 0;
                
                this._tblShareholderDetail.Rows.Clear();
                this._tblMeetingAttendee.Rows.Clear();
               
            }
            else
            {
                this._SessionId = Convert.ToInt32(this.SessionIdLookUpEdit.EditValue);
                
                this.GetMeetingAtendee(this._SessionId);
                
            }
        }

        private void GetMeetingAtendee(int SessionId)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                //DataObj.FillData(this._tblShareholderDetail, clShareholder.GetShareholderBrowseSql("SHStatus =1 and SHId NOT IN (SELECT SHId FROM tblMeetingAttendee WHERE SessionId=" + SessionId + ")"));
                //DataObj.FillData(this._tblShareholderDetail, "SELECT a.SHId, a.RegCode, a.FullName,b.SubscribedShareNoModif as ShareNo,b.SubscribedShareAmtModif as ShareAmnt FROM tblShareholderDetail as a inner join  tblShareRegBook as b on a.SHId= b.SHId WHERE a.SHStatus=1 and a.SHId NOT IN (SELECT SHId FROM tblMeetingAttendee WHERE SessionId=+" + SessionId + ")");
                DataObj.FillData(this._tblShareholderDetail, "SELECT a.SHId, a.RegCode, a.FullName,b.SubscribedShareNoModif as ShareNo,b.SubscribedShareAmtModif as ShareAmnt FROM tblShareholderDetail as a inner join  tblShareRegBook as b on a.SHId= b.SHId WHERE a.SHStatus=1 and a.SHId NOT IN (SELECT SHId FROM tblEmergencyMeetingAttendee WHERE SessionId in(select SessionId from tblMeetingSession where IsActive=1 and SessionId="+SessionId+"))");
                //DataObj.FillData(this._tblMeetingAttendee, "SELECT  SessionId, SHId, RegCode,ShareNo,ShareAmnt FROM tblMeetingAttendee   WHERE SessionId=" + SessionId);
                DataObj.FillData(this._tblMeetingAttendee, "SELECT  SessionId, SHId, RegCode,ShareNo,ShareAmnt FROM tblEmergencyMeetingAttendee   WHERE SessionId in(select SessionId from tblMeetingSession where IsActive=1 and SessionId=" + SessionId + ")");
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

        private void gridNotAtendedSH_DoubleClick(object sender, EventArgs e)
        {
            if (this._SessionId == 0)
            {
                AppMessageBox.ShowExclamation("Please select the meeting session befor tying to select shareholder. ");
                return;
            }
            int focused = this.gridNotAtendedSH.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridNotAtendedSH.GetDataRow(focused);
                DataRow newRow;
                newRow = this._tblMeetingAttendee.NewRow();
                newRow["SessionId"] = this._SessionId;
                newRow["RegCode"] = curRow["RegCode"];
                newRow["SHId"] = curRow["SHId"];
                newRow["ShareNo"] = curRow["ShareNo"];
                newRow["ShareAmnt"] = curRow["ShareAmnt"];
                newRow["CrtBy"] = clMain.User.UserName;
               
                this._tblMeetingAttendee.Rows.Add(newRow);
                curRow.Delete();
                //new block by dawit
                SaveAttendee(this._SessionId, this._SHId);
                //
            }
        }

        private void gridAtendedSH_DoubleClick(object sender, EventArgs e)
        {
            if (this._SessionId == 0)
            {
                AppMessageBox.ShowExclamation("Please select the meeting session befor trying to select atendee. ");
                return;
            }
            int focused = this.gridAtendedSH.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridAtendedSH.GetDataRow(focused);
                DataRow newRow;
                this._SHId = Convert.ToInt32(curRow["SHId"]); 
                newRow = this._tblShareholderDetail.NewRow();
                newRow["RegCode"] = curRow["RegCode"];
                newRow["SHId"] = curRow["SHId"]; 
                newRow["ShareNo"] = curRow["ShareNo"];
                newRow["ShareAmnt"] = curRow["ShareAmnt"];

                //new block by dawit
                if (AppMessageBox.ShowQuestion("Are you sure you want to delete the attendee?") == DialogResult.No)
                    return;
                //
                this._tblShareholderDetail.Rows.Add(newRow);
                curRow.Delete();
                //new block by dawit
                DeleteAttendee(this._SessionId, this._SHId);
                //
            }
        }

        private bool AttendeeVoted(int sessionId, int SHId)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

           

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT SHId FROM tblVotingForAgenda WHERE SessionId=" + sessionId + " and SHId=" + SHId ;
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

        private void DeleteAttendee(int sessionId, int SHId)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);




            if (AttendeeVoted(sessionId, SHId))
            {
                AppMessageBox.ShowExclamation("This attendee has already voted. Please go to the vot for agnda screen and delete the vot before trying to delete the attendee");
                this.SessionIdLookUpEdit.Focus();
                return;
            }

            try
            {
                DataObj.OpenConnection();
                cmdText = "delete from tblEmergencyMeetingAttendee where sessionId=" + this._SessionId + " and SHId=" + this._SHId;
                if (DataObj.Execute(cmdText))
                {
                    this._SHId = 0;
                    // AppMessageBox.ShowInformation("the attendee  has been deleted sucessfully");
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

        private void SaveAttendee(int sessionId, int SHID)
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


                    if (this._tblMeetingAttendee.Rows.Count == 0)
                    {
                        AppMessageBox.ShowExclamation("Please select atleast one atendee Shareholder");
                        return;
                    }
                    DataObj.OpenConnection();
                    if (DataObj.UpdateTable(this._tblMeetingAttendee))
                    {
                        AppMessageBox.ShowInformation("Meeting atendee/s has been updated sucessfully");
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


    }
}
