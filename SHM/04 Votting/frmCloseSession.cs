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
    public partial class frmCloseSession : Form
    {
       #region Fields
        private string _title = "Close Session";
       
        
        private int _SessionId = 0;
        private int _TypeofMeeting = 0;
       

        private DataTable _tblMeetingSession;
        

        #endregion

       
      

        public frmCloseSession()
        {

            InitializeComponent();
        }

        private void frmCloseSession_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void frmCloseSession_KeyDown(object sender, KeyEventArgs e)
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
        private void SessionIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SessionIdLookUpEdit.EditValue != null && !Convert.IsDBNull(this.SessionIdLookUpEdit.EditValue))
            {
                this._SessionId = Convert.ToInt32(this.SessionIdLookUpEdit.EditValue);
                this._TypeofMeeting = Convert.ToInt32(this.SessionIdLookUpEdit.GetColumnValue("TypeOfMeeting"));
                
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (this._SessionId == 0)
            {
                AppMessageBox.ShowExclamation(" Please select Session from the List box");
                return;
            }
            
           if (AppMessageBox.ShowQuestion("Are you sure you want to close the selected Session?") == DialogResult.No)
                    return;
            
            else
            {
                string cmdText;
                bool success = false;
                clDatacon DataObj = new clDatacon(clMain.ConnString);



                try
                {
                    DataObj.OpenConnection();
                   
                    
                        cmdText = "Update  tblMeetingSession set IsActive= 0  WHERE SessionId=" + this._SessionId;
                    
                    success=DataObj.Execute(cmdText);
                    if (success)
                    {
                        
                        AppMessageBox.ShowInformation("The selected session is closed successfully.");
                        this._SessionId = 0;
                    }
                    else
                        AppMessageBox.ShowInformation("The selected session is not closed");
                    
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
}

