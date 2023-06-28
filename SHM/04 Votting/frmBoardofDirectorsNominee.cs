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
    public partial class frmBoardofDirectorsNominee : Form
    {
        #region Fields
        private string _title = "Board of Directors Nominee";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

        private int _SessionId = 0;

        private int _SHId = 0;
        private int _NomineeId = 0;

        private DataTable _tblMeetingSession;
        private DataTable _tblBoDNominees;
        private DataRow _BoDNominees;

        private DataTable _tblBoDNomineesList;
        private DataTable _tblShareholderDetail;





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
        public frmBoardofDirectorsNominee()
        {
            InitializeComponent();
        }
        private void frmBoardofDirectorsNominee_Load(object sender, EventArgs e)
        {

            BindControls();
            InitForm(true);
        }

        private void frmBoardofDirectorsNominee_KeyDown(object sender, KeyEventArgs e)
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
                this._tblShareholderDetail = new DataTable("tblShareholderDetail");
                clMain.SetDataSource(this.SessionIdLookUpEdit, this._tblMeetingSession);
                clMain.SetDataSource(this.NomineeSHIdLookUpEdit, this._tblShareholderDetail);
                clMain.SetRepositoryDataSource(rluNomineeLookUpEdit, this._tblShareholderDetail);

                this._tblBoDNominees = DataObj.GetDataTable("tblBoDNominees");
                this._tblBoDNominees.Columns["CrtDt"].ReadOnly = true;
                this._tblBoDNominees.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    
                    this.SessionIdLookUpEdit,
                    this.NomineeSHIdLookUpEdit,
                    this.DoNDateTimePicker,
                    this.DoNEthTextBox,
                    this.RemarkTextBox,
                    this.IsNombyNonInfluenceCheckBox,
                    this.IsFormerBoDsCheckBox,
                    this.IsActiveCheckBox,
                    this.IsInwaitingListCheckBox
                   
                      
                });

                clMain.BindControls(cntrsList, this._tblBoDNominees);
                cntrsList.Clear();

                this._tblBoDNomineesList = DataObj.GetDataTable("tblBoDNominees");
                clMain.SetDataSource(this.gctBoDNomnee, this._tblBoDNomineesList);
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

                    DataObj.FillData(this._tblMeetingSession, "select SessionId,TypeOfMeeting,Description+' of Fiscal year '+FiscalYear+' on Date '+ convert(varchar(10),MeetingDate,103) as SessionNane,Venue from tblMeetingSession inner join tbltypeOfMeeting on tbltypeOfMeeting.Id=TypeOfMeeting where IsActive=1 order by MeetingDate desc");

                }
                else
                {

                    DataObj.FillData(this._tblBoDNomineesList, "SELECT * FROM tblBoDNominees where SessionId=" + this._SessionId + " order by NomineeId");
                }
                DataObj.FillData(this._tblShareholderDetail, clShareholder.GetShareholderBrowseSql(true));
                clMain.SetSearchBy(this.NomineeSHIdLookUpEdit, this.searchByComboBox);


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

                    this.SessionIdLookUpEdit.Focus();
                    this._BoDNominees = this._tblBoDNominees.Rows[0];
                    this._BoDNominees["NomineeFullName"] = this.NomineeSHIdLookUpEdit.GetColumnValue("FullName");
                    this._BoDNominees["NomineeFullNameAmharic"] = GetNomineeAmharicName(this._SHId);
                    this._BoDNominees["NomineeRegCode"] = this.NomineeSHIdLookUpEdit.GetColumnValue("RegCode");

                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._BoDNominees, true))
                        {
                            InitForm(false);
                        }
                    }
                    else
                    {

                        if (DataObj.Update(this._title, this._BoDNominees, true))
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

                if (this._SessionId == 0)
                {
                    AppMessageBox.ShowExclamation("Please double click from the list to delete " + this._title);
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete " + this._title + "?") == DialogResult.No)
                    return;

                this._BoDNominees = this._tblBoDNominees.Rows[0];

                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._BoDNominees, true))
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

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {


            this._SessionId = 0;
            this._SHId = 0;

            this.GetElectionCommitteeNomineeEntry(this._SessionId, this._SHId);
            this.SessionIdLookUpEdit.Focus();

        }

        private void gridComtNominee_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridBoDNominee.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridBoDNominee.GetDataRow(focused);

                this._SHId = Convert.ToInt32(curRow["NomineeSHId"]);
                this._SessionId = Convert.ToInt32(curRow["SessionId"]);
                this._NomineeId = Convert.ToInt32(curRow["NomineeId"]);
                this.GetElectionCommitteeNomineeEntry(this._SessionId, this._SHId);
                this.gridBoDNominee.FocusedRowHandle = focused;
            }
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._BoDNominees = this._tblBoDNominees.NewRow();
                clDatacon.SetToDatabaseDefaults(this._BoDNominees, clMain.ConnString);

                if (this._SessionId != 0)
                {
                    this._BoDNominees["SessionId"] = this._SessionId;
                    this._BoDNominees["NomineeId"] = this.GetNextNomineeId(this._SessionId);
                }
                if (this._SHId != 0) this._BoDNominees["NomineeSHId"] = this._SHId;
                if (this.DoNDateTimePicker.Text != "") this._BoDNominees["DoN"] = this.DoNDateTimePicker.Value;
                if (this.DoNEthTextBox.Text != "") this._BoDNominees["DoNEth"] = this.DoNEthTextBox.Text;
                this._BoDNominees["CrtBy"] = clMain.User.UserName;

                this._tblBoDNominees.Rows.Clear();
                this._tblBoDNominees.Rows.Add(this._BoDNominees);
                this._isLoadingEntry = false;
            }
        }

        private bool ElectionCommitteeNomineeExists(int sessionId, int ShId)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (sessionId == 0)
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT NomineeSHId FROM tblBoDNominees WHERE SessionId=" + sessionId + " and  NomineeSHId=" + ShId;
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

        private void GetElectionCommitteeNomineeBySession(int SessionId)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {

                DataObj.OpenConnection();

                DataObj.FillData(this._tblBoDNomineesList, "SELECT * FROM tblBoDNominees where SessionId=" + SessionId + " order by NomineeId");
                //DataObj.FillData(this._tblElectionCommitteeNomineesList, "SELECT a.*, b.RegCode FROM tblElectionCommitteeNominees as a inner join tblShareholderDetail as b on a.NomineeSHId= b.SHId where SessionId=" + SessionId + " order by NomineeId");



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

        private bool GetElectionCommitteeNomineeEntry(int sessionId, int SHId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.ElectionCommitteeNomineeExists(sessionId, SHId))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblBoDNominees, "SELECT * FROM tblBoDNominees WHERE SessionId=" + sessionId + " and  NomineeSHId=" + SHId);


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

                this.GetElectionCommitteeNomineeBySession(this._SessionId);
            }
        }

        private void SHIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.NomineeSHIdLookUpEdit.EditValue != null && !Convert.IsDBNull(this.SessionIdLookUpEdit.EditValue))
            {
                this._SHId = Convert.ToInt32(this.NomineeSHIdLookUpEdit.EditValue);

                this.GetNomineeAmharicName(this._SHId);
                GetElectionCommitteeNomineeEntry(this._SessionId, this._SHId);
            }
        }

        private string GetNomineeAmharicName(int SHId)
        {

            clDatacon DataObj = new clDatacon(clMain.ConnString);
            string amharicName = "";
            try
            {

                DataObj.OpenConnection();
                string cmdText;

                cmdText = "select FullNameAmharic from tblShareholderDetail where SHId=" + SHId;
                amharicName = DataObj.GetDataScalar(cmdText).ToString();

            }

            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);

            }
            finally
            {
                DataObj.CloseConnection();

            }
            return amharicName;

        }

        private int GetNextNomineeId(int sessionId)
        {
            int nextId = 0;

            object result;


            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {

                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("SELECT max(NomineeId) As MaxNomineeId FROM tblBoDNominees where SessionId=" + sessionId);
                if (result == null || Convert.IsDBNull(result))
                {
                    nextId = 1;

                }
                else
                {
                    nextId = Convert.ToInt32(result);
                    nextId++;



                }
                return nextId;
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return nextId;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void DoNDateTimePicker_Validated(object sender, EventArgs e)
        {
            this.DoNEthTextBox.Text = clUtility.GetEthiopicDate(this.DoNDateTimePicker.Value);
        }

        private void searchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.searchByComboBox.SelectedIndex != -1)
            {
                this.NomineeSHIdLookUpEdit.Properties.DisplayMember = this.searchByComboBox.SelectedItem.ToString();
            }
        }



    }
}


