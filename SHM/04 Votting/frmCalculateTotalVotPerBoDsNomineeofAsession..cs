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
    public partial class frmCalculateTotalVotPerBoDsNomineeofAsession : Form
    {
        #region Fields
        private string _title = "Total Vot per BoDs Nominee of Meeting Session";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

        private int _SessionId = 0;


        private DataTable _tblMeetingSession;
        private DataTable _tblBoDNominees;
        private DataTable _tblTotalCalculatedVotPerBoDsNomineeofAsession;
        private DataRow _TotalCalculatedVotPerBoDsNomineeofAsession;

        private DataTable _PS_TotalVotperBoDsNomineeofAsession;

        private DataTable _tblTotalCalculatedVotPerBoDsNomineeofAsessionList;
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

        public frmCalculateTotalVotPerBoDsNomineeofAsession()
        {
            InitializeComponent();
        }
        private void frmCalculateTotalVotPerBoDsNomineeofAsession_Load(object sender, EventArgs e)
        {

            BindControls();
            InitForm(true);
        }

        private void frmCalculateTotalVotPerBoDsNomineeofAsession_KeyDown(object sender, KeyEventArgs e)
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
                this._tblBoDNominees = DataObj.GetDataTable("tblBoDNominees");

                clMain.SetDataSource(this.SessionIdLookUpEdit, this._tblMeetingSession);
                clMain.SetRepositoryDataSource(this.rluNomineeSHId, this._tblBoDNominees);

                this._tblTotalCalculatedVotPerBoDsNomineeofAsession = DataObj.GetDataTable("tblTotalCalculatedVotPerBoDsNomineeofAsession");

                DataParameters[0] = new SqlParameter("SessionId", this._SessionId);
                this._PS_TotalVotperBoDsNomineeofAsession = DataObj.GetDataTable("PS_TotalVotperBoDsNomineeofAsession", true, DataParameters);
                this._tblTotalCalculatedVotPerBoDsNomineeofAsession.Columns["CrtDt"].ReadOnly = true;
                this._tblTotalCalculatedVotPerBoDsNomineeofAsession.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    
                    this.SessionIdLookUpEdit,
                    
                      
                });

                clMain.BindControls(cntrsList, this._tblTotalCalculatedVotPerBoDsNomineeofAsession);
                cntrsList.Clear();

                this._tblTotalCalculatedVotPerBoDsNomineeofAsessionList = DataObj.GetDataTable("tblTotalCalculatedVotPerBoDsNomineeofAsession");
                clMain.SetDataSource(this.gctTotalVot, this._tblTotalCalculatedVotPerBoDsNomineeofAsessionList);
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
                    DataObj.FillData(this._tblBoDNominees, "select * from tblBoDNominees where IsInwaitingList=0");
                    this.refreshToolStripButton_Click(this, new EventArgs());
                }
                else
                    //DataObj.FillData(this._tblTotalCalculatedVotPerBoDsNomineeofAsessionList, "SELECT * FROM tblTotalCalculatedVotPerBoDsNomineeofAsession where SessionId=" + this._SessionId + " order by SessionId");
                    DataObj.FillData(this._tblTotalCalculatedVotPerBoDsNomineeofAsessionList, "SELECT SessionId,NomineeSHId,IsNombyNonInfluence,NominiTypeForRecOrdering," +
                        " sum(TotalVotByNonInfluencial) as TotalVotByNonInfluencial," +
                        " sum(TotalVotByInfluencial)as TotalVotByInfluencial," +
                        " sum(NoOfNonInfluShareholderVoted) as NoOfNonInfluShareholderVoted," +
                        " sum(NoOfInfluShareholderVoted) as NoOfInfluShareholderVoted," +
                        " sum(TotalVotByNonInfluencial+TotalVotByInfluencial)as TotalVot," +
                        " sum(NoOfNonInfluShareholderVoted+NoOfInfluShareholderVoted)as TotalNoShareholderVoted" +
                        " FROM tblTotalCalculatedVotPerBoDsNomineeofAsession WHERE SessionId=" + this._SessionId +
                        " group by SessionId,IsNombyNonInfluence,NominiTypeForRecOrdering,NominiTypeForRecOrdering,NomineeSHId " +
                        " order by NominiTypeForRecOrdering,TotalVotByNonInfluencial desc");



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
                this._TotalCalculatedVotPerBoDsNomineeofAsession = this._tblTotalCalculatedVotPerBoDsNomineeofAsession.NewRow();
                clDatacon.SetToDatabaseDefaults(this._TotalCalculatedVotPerBoDsNomineeofAsession, clMain.ConnString);

                if (this._SessionId != 0) this._TotalCalculatedVotPerBoDsNomineeofAsession["SessionId"] = this._SessionId;

                this._TotalCalculatedVotPerBoDsNomineeofAsession["CrtBy"] = clMain.User.UserName;

                this._tblTotalCalculatedVotPerBoDsNomineeofAsession.Rows.Clear();
                this._tblTotalCalculatedVotPerBoDsNomineeofAsession.Rows.Add(this._TotalCalculatedVotPerBoDsNomineeofAsession);
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
                cmdText = "SELECT SessionId FROM tblTotalCalculatedVotPerBoDsNomineeofAsession WHERE SessionId=" + sessionId;
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

                DataObj.FillData(this._tblTotalCalculatedVotPerBoDsNomineeofAsessionList, "SELECT SessionId,NomineeSHId,IsNombyNonInfluence,NominiTypeForRecOrdering,"+
                         " sum(TotalVotByNonInfluencial) as TotalVotByNonInfluencial,"+
                         " sum(TotalVotByInfluencial)as TotalVotByInfluencial,"+
                         " sum(NoOfNonInfluShareholderVoted) as NoOfNonInfluShareholderVoted,"+
                         " sum(NoOfInfluShareholderVoted) as NoOfInfluShareholderVoted,"+
                         " sum(TotalVotByNonInfluencial+TotalVotByInfluencial)as TotalVot,"+
                         " sum(NoOfNonInfluShareholderVoted+NoOfInfluShareholderVoted)as TotalNoShareholderVoted"+
                         " FROM tblTotalCalculatedVotPerBoDsNomineeofAsession WHERE SessionId=" + this._SessionId +
                         " group by SessionId,IsNombyNonInfluence,NominiTypeForRecOrdering,NominiTypeForRecOrdering,NomineeSHId "+
                         " order by NominiTypeForRecOrdering,TotalVotByNonInfluencial desc");



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

                    DataObj.FillData(this._tblTotalCalculatedVotPerBoDsNomineeofAsession, "SELECT * FROM tblTotalCalculatedVotPerBoDsNomineeofAsession WHERE SessionId=" + sessionId + " order by NominiTypeForRecOrdering,TotalShareNoVoted,TotalShareholderVoted");


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
                    cmdText = "delete from tblTotalCalculatedVotPerBoDsNomineeofAsession where SessionId=" + this._SessionId;
                    this._TotalCalculatedVotPerBoDsNomineeofAsession = this._tblTotalCalculatedVotPerBoDsNomineeofAsession.Rows[0];
                    DataObj.Execute(cmdText);
                    if (this._isNew)
                    {

                        DataParameters[0] = new SqlParameter("SessionId", this._SessionId);

                        DataObj.FillData(this._PS_TotalVotperBoDsNomineeofAsession, "PS_TotalVotperBoDsNomineeofAsession", true, DataParameters);
                        if (this._PS_TotalVotperBoDsNomineeofAsession.Rows.Count > 0)
                        {
                            for (int i = 0; i < this._PS_TotalVotperBoDsNomineeofAsession.Rows.Count; i++)
                            {
                                this._TotalCalculatedVotPerBoDsNomineeofAsession["NomineeSHId"] = _PS_TotalVotperBoDsNomineeofAsession.Rows[i]["NomineeSHId"];
                                this._TotalCalculatedVotPerBoDsNomineeofAsession["IsNombyNonInfluence"] = _PS_TotalVotperBoDsNomineeofAsession.Rows[i]["IsNombyNonInfluence"];
                                this._TotalCalculatedVotPerBoDsNomineeofAsession["NominiTypeForRecOrdering"] = _PS_TotalVotperBoDsNomineeofAsession.Rows[i]["NominiTypeForRecOrdering"];
                                this._TotalCalculatedVotPerBoDsNomineeofAsession["NoOfNonInfluShareholderVoted"] = _PS_TotalVotperBoDsNomineeofAsession.Rows[i]["NoOfNonInfluShareholderVoted"];
                                this._TotalCalculatedVotPerBoDsNomineeofAsession["NoOfInfluShareholderVoted"] = _PS_TotalVotperBoDsNomineeofAsession.Rows[i]["NoOfInfluShareholderVoted"];
                                this._TotalCalculatedVotPerBoDsNomineeofAsession["TotalVotByNonInfluencial"] = _PS_TotalVotperBoDsNomineeofAsession.Rows[i]["NoOfShareVotedByNoninfluenc"];
                                this._TotalCalculatedVotPerBoDsNomineeofAsession["TotalVotByInfluencial"] = _PS_TotalVotperBoDsNomineeofAsession.Rows[i]["NoOfShareVotedByInfluenc"];
                                success = DataObj.Insert(this._title, this._TotalCalculatedVotPerBoDsNomineeofAsession, false);


                            }
                            if (success)
                            {
                                AppMessageBox.ShowInformation(this._title + " is successfully calculated and saved");
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



