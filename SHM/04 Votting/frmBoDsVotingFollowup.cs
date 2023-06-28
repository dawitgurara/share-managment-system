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
    public partial class frmBoDsVotingFollowup : Form
    {
        
    private DataTable _tblBoDsVotFollowup;

    public frmBoDsVotingFollowup()
        {
            InitializeComponent();
        }

    private void frmBoDsVotLiveFollowup_Load(object sender, EventArgs e)
        {
            
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Start();
            
            BindControls();
            InitForm(true);
            
        }
 
    private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                this._tblBoDsVotFollowup = DataObj.GetDataTable("ViewBoDsVotFollowup");
                clMain.SetDataSource(this.gctComtNomnee, this._tblBoDsVotFollowup);
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
            RefreshAttendeeInfo();
        }
        
    private void RefreshAttendeeInfo()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {

                DataObj.OpenConnection();

                DataObj.FillData(this._tblBoDsVotFollowup, "SELECT * FROM ViewBoDsVotFollowup where IsActive=1 and SessionId in(select top 1 SessionId from tblMeetingSession where TypeOfMeeting=1 order by SessionId desc) order by NomineeId"); 
               
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

    private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            this.CurrentTimeLabel.Text = clUtility.GetCurrentDate().Hour.ToString() + ":" + clUtility.GetCurrentDate().Minute.ToString() + ":" + clUtility.GetCurrentDate().Second.ToString();
            RefreshAttendeeInfo();
        }

       
        

    }
}

