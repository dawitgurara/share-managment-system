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
    public partial class frmElectionNomineesLiveFollowup : Form
    {
        private DataTable _tblMeetingSession;
        private DataTable _tblElectionCommitteeNominees;
       



        public frmElectionNomineesLiveFollowup()
        {

            InitializeComponent();
        }

        private void frmElectionNomineesLiveFollowup_Load(object sender, EventArgs e)
        {

            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Start();
            
            BindControls();
            InitForm(true);
            
        }

        private void frmElectionNomineesLiveFollowup_KeyDown(object sender, KeyEventArgs e)
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



                this._tblElectionCommitteeNominees = DataObj.GetDataTable("tblElectionCommitteeNominees");
                clMain.SetDataSource(this.gctComtNomnee, this._tblElectionCommitteeNominees);
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

                DataObj.FillData(this._tblElectionCommitteeNominees, "SELECT * FROM tblElectionCommitteeNominees where SessionId in(select top 1 SessionId from tblMeetingSession where TypeOfMeeting=1 order by SessionId desc)");
                
                
                   


               
               
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

            RefreshAttendeeInfo();

        }

       
        

    }
}

