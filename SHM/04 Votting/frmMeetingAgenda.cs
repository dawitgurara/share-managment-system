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
    public partial class frmMeetingAgenda : Form
    {
       #region Fields
        private string _title = "Meeting Agenda";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;
        
        private int _SessionId = 0;
        private string _Agenda="";
        private int _AgendaId=0;

        private DataTable _tblMeetingSession;
        private DataTable _tblMeetingAgenda;
        private DataRow _MeetingAgenda;

        private DataTable _tblMeetingAgendaList;
       




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

        public frmMeetingAgenda()
        {

            InitializeComponent();
        }

        private void frmMeetingAgenda_Load(object sender, EventArgs e)
        {
            
            BindControls();
            InitForm(true);
        }

        private void frmMeetingAgenda_KeyDown(object sender, KeyEventArgs e)
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


                this._tblMeetingAgenda = DataObj.GetDataTable("tblMeetingAgenda");
                this._tblMeetingAgenda.Columns["CrtDt"].ReadOnly = true;
                this._tblMeetingAgenda.Columns["CrtWs"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    
                    this.SessionIdLookUpEdit,
                    this.AgendaTextBox,
                    this.AgendaAmharicTextBox
                      
                });

                clMain.BindControls(cntrsList, this._tblMeetingAgenda);
                cntrsList.Clear();

                this._tblMeetingAgendaList = DataObj.GetDataTable("tblMeetingAgenda");
                clMain.SetDataSource(this.gctMeetingAgenda, this._tblMeetingAgendaList);
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

                    DataObj.FillData(this._tblMeetingAgendaList, "SELECT * FROM tblMeetingAgenda where SessionId=" + this._SessionId+" order by AgendaId");
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

                    this.SessionIdLookUpEdit.Focus();
                    this._MeetingAgenda = this._tblMeetingAgenda.Rows[0];

                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._MeetingAgenda, true))
                        {
                            InitForm(false);
                        }
                    }
                    else
                    {

                        if (DataObj.Update(this._title, this._MeetingAgenda, true))
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

                this._MeetingAgenda = this._tblMeetingAgenda.Rows[0];

                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._MeetingAgenda, true))
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
            this._AgendaId = 0;

            this.GetMeetingAgendaEntry(this._SessionId, this._AgendaId);
            this.SessionIdLookUpEdit.Focus();

        }

        private void gridMeetingAgenda_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridMeetingAgenda.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridMeetingAgenda.GetDataRow(focused);

                this._AgendaId = Convert.ToInt32(curRow["AgendaId"]);
                this._SessionId = Convert.ToInt32(curRow["SessionId"]);
                this._Agenda = Convert.ToString(curRow["Agenda"]);
                this.GetMeetingAgendaEntry(this._SessionId, this._AgendaId);
                this.gridMeetingAgenda.FocusedRowHandle = focused;
            }
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._MeetingAgenda = this._tblMeetingAgenda.NewRow();
                clDatacon.SetToDatabaseDefaults(this._MeetingAgenda, clMain.ConnString);

                if (this._SessionId != 0)
                {
                    this._MeetingAgenda["SessionId"] = this._SessionId;
                    this._MeetingAgenda["AgendaId"] = this.GetNextAgendaId(this._SessionId);
                }
                if (this._Agenda != "") this._MeetingAgenda["Agenda"] = this._Agenda;
                this._MeetingAgenda["CrtBy"] = clMain.User.UserName;

                this._tblMeetingAgenda.Rows.Clear();
                this._tblMeetingAgenda.Rows.Add(this._MeetingAgenda);
                this._isLoadingEntry = false;
            }
        }

        private bool MeetingAgendaExists(int sessionId,int agendaId)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (sessionId == 0)
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT SessionId FROM tblMeetingAgenda WHERE SessionId=" + sessionId + " and  AgendaId=" + agendaId;
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

        private bool MeetingAgendaExists(int sessionId, string agenda)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            if (sessionId == 0)
                return false;

            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT SessionId FROM tblMeetingAgenda WHERE SessionId=" + sessionId + " and  Agenda='" + agenda+"'";
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
         
        private void GetMeetingAgendaBySession(int SessionId)
        {
            
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                
                try
                {
                    
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblMeetingAgendaList, "SELECT * FROM tblMeetingAgenda where SessionId="+SessionId+" order by AgendaId");


                   
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
            
        private bool GetMeetingAgendaEntry(int sessionId, int agendaId)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);
                if (!this.MeetingAgendaExists(sessionId, agendaId))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();

                    DataObj.FillData(this._tblMeetingAgenda, "SELECT * FROM tblMeetingAgenda WHERE SessionId=" + sessionId + " and  AgendaId=" + agendaId);


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

                this.GetMeetingAgendaBySession(this._SessionId);
                GetMeetingAgendaEntry(this._SessionId, this._AgendaId);
            }
        }

        private void AgendaTextBox_Validated(object sender, EventArgs e)
        {
            this._Agenda = this.AgendaTextBox.Text;
            if (MeetingAgendaExists(this._SessionId, this._Agenda))
            {
                AppMessageBox.ShowExclamation("Agenda should be unique please try again!");
                this.AgendaTextBox.Focus();
            }
        }

        private int GetNextAgendaId(int sessionId)
        {
            int nextId = 0;
            
            object result;


            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {

                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("SELECT max(AgendaId) As MaxAgendaId FROM tblMeetingAgenda where SessionId=" + sessionId);
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
       
       

    }
}
