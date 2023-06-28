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
    public partial class frmEmergencyMeetingAttendeesLiveFollowup : Form
    {
          private DataTable _tblMeetingSession;
       
        private DataTable _View_AttendeesSummaryLive;
        private decimal _minPercentageReg = 25;
        private decimal _minPercentageEmerg = 50;
        private decimal _currentAtendeePercentage = 0;



        public frmEmergencyMeetingAttendeesLiveFollowup()
        {

            InitializeComponent();
        }

        private void frmEmergencyMeetingAttendeesLiveFollowup_Load(object sender, EventArgs e)
        {

            this.MeetinRoundLabel.Text = clUtility.GetMeetingRoundRoundNumber(2).ToString();
            this.welcomeLabel.Visible = true;
            this.MeetinRoundLabel.Visible = true;
            this.currentPercentagelabel.Text = "0";
            this.AmharicMessageLabel.Visible = false;
            this.EnglishMessageLabel.Visible = false;
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Start();
            
            BindControls();
            InitForm(true);
            
        }

        private void frmEmergencyMeetingAttendeesLiveFollowup_KeyDown(object sender, KeyEventArgs e)
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



                this._View_AttendeesSummaryLive = DataObj.GetDataTable("View_AttendeesSummaryOfEmrgmtngLive");
                clMain.SetDataSource(this.gctSummaryofatendee, this._View_AttendeesSummaryLive);
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

                //DataObj.FillData(this._View_AttendeesSummaryLive, "SELECT * FROM View_AttendeesSummaryLive where SessionId in(select top 1 SessionId from tblMeetingSession where TypeOfMeeting=1 order by SessionId desc)");
                DataObj.FillData(this._View_AttendeesSummaryLive, "SELECT * FROM View_AttendeesSummaryOfEmrgmtngLive ");
                if (_View_AttendeesSummaryLive.Rows.Count > 0)
                {
                    this._minPercentageReg = Convert.ToDecimal(_View_AttendeesSummaryLive.Rows[0]["PercOfSHSupsdToAtndRegMeeting"]);
                    this._minPercentageEmerg = Convert.ToDecimal(_View_AttendeesSummaryLive.Rows[0]["PercOfSHSupsdToAtndEmrgMeeting"]);
                    this._currentAtendeePercentage = Convert.ToDecimal(_View_AttendeesSummaryLive.Rows[0]["PercentageofAttendeeSubscrShNo"]);
                    this.currentPercentagelabel.Text = this._currentAtendeePercentage.ToString();
                    if ((this._minPercentageEmerg - this._currentAtendeePercentage) <= 0)
                    {
                        this.AmharicMessageLabel.Visible = true;
                        this.EnglishMessageLabel.Visible = true;
                        this.MeetinRoundLabel.Visible = false;
                        this.welcomeLabel.Visible = false;
                    }

                    else
                    {
                        this.AmharicMessageLabel.Visible = false;
                        this.EnglishMessageLabel.Visible = false;
                        this.MeetinRoundLabel.Visible = true;
                        this.welcomeLabel.Visible = true;
                    }



                }
                else
                {
                    this.AmharicMessageLabel.Visible = false;
                    this.EnglishMessageLabel.Visible = false;
                    this.welcomeLabel.Visible = true;
                    this.currentPercentagelabel.Text = "0";
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


        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            this.CurrentTimeLabel.Text = clUtility.GetCurrentDate().Hour.ToString() + ":" + clUtility.GetCurrentDate().Minute.ToString() + ":" + clUtility.GetCurrentDate().Second.ToString();
           
            RefreshAttendeeInfo();
        }

        private void currentPercentagelabel_Click(object sender, EventArgs e)
        {

        }

        

    }
}

