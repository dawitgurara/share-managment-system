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
    public partial class frmVotingEnquiry : Form
    {
        #region Fields
        

        private int _SessionId = 0;
        private int _typeId = 0;
        private string _dataSource = string.Empty;
        private DataTable _tblVottingEnquiryType;
        private DataRow _VottingEnquiryType;

        private DataTable _tblVottingEnquiryValue;
       

        private DataTable _tblMeetingSession;
        #endregion

        public frmVotingEnquiry()
        {
            InitializeComponent();
        }

        private void frmVotingEnquiry_Load(object sender, EventArgs e)
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
                this._tblMeetingSession = new DataTable("tblMeetingSession");
                clMain.SetDataSource(this.SessionIdLookUpEdit, this._tblMeetingSession);
                this.SessionIdLookUpEdit.Properties.NullText = "-- Select Meeting Session --";

                this._tblVottingEnquiryType = DataObj.GetDataTable("tblVottingEnquiry");
                clMain.SetDataSource(this.gctVotEnquiryType, this._tblVottingEnquiryType);

                this._tblVottingEnquiryValue = new DataTable();
                clMain.SetDataSource(this.gctVotEnquiryValue, this._tblVottingEnquiryValue);

               
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

                }
                DataObj.FillData(this._tblMeetingSession, "select SessionId,TypeOfMeeting,'Meeting of Fiscal year '+FiscalYear+' on Date '+ convert(varchar(10),MeetingDate,103) as SessionNane,Venue from tblMeetingSession order by MeetingDate desc");
                DataObj.FillData(this._tblVottingEnquiryType, "SELECT * FROM tblVottingEnquiry ORDER BY Id");

                this.gridVotEnquiryType.BestFitColumns();

                
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshToolStripButton_Click(null, null);
            }
        }

      

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.SessionIdLookUpEdit.EditValue = null;
        }

        private void SessionIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SessionIdLookUpEdit.EditValue == null || Convert.IsDBNull(this.SessionIdLookUpEdit.EditValue))
            {
                this._SessionId = 0;
               
                this._tblVottingEnquiryValue.Rows.Clear();
            }
            else
            {
                this._SessionId = Convert.ToInt32(this.SessionIdLookUpEdit.EditValue);
               
                this.GetVotEnquiry(this._SessionId, this._typeId);
            }
        }

        private void gridVotEnquiryType_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this._VottingEnquiryType = this.gridVotEnquiryType.GetDataRow(e.FocusedRowHandle);
            if (this._VottingEnquiryType != null)
            {
                this._typeId = Convert.ToInt32(this._VottingEnquiryType["Id"]);
                this._dataSource = Convert.ToString(this._VottingEnquiryType["DataSource"]);
            }
            else
            {
                this._typeId = 0;
                this._dataSource = string.Empty;
            }
            this.gridVotEnquiryType_Click(null, null);
        }

        private void gridVotEnquiryType_Click(object sender, EventArgs e)
        {
            this.GetVotEnquiry(this._SessionId, this._typeId);
        }

        private void GetVotEnquiry(int sessionId, int tyepId)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                this._tblVottingEnquiryValue = new DataTable();
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("SessionId", sessionId));
                if (this._SessionId > 0 && this._typeId > 0)
                    DataObj.FillData(this._tblVottingEnquiryValue, this._dataSource, false, parameters.ToArray());
                clMain.SetDataSource(this.gctVotEnquiryValue, this._tblVottingEnquiryValue);
                this.gridVotEnquiryValue.PopulateColumns();
                this.gridVotEnquiryValue.BestFitColumns();
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