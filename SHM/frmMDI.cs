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
    public partial class frmMDI : Form
    {
       

        public frmMDI()
        {
            InitializeComponent();
        }
        public frmMDI(int userId)
        {
            InitializeComponent();
          
            clSecurity.AssignMenuRights(userId, ref menuStrip);
        }
          
        private void shareHolderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShareholderDetails ShareholderDetails = new frmShareholderDetails();
            ShareholderDetails.MdiParent = this;
            ShareholderDetails.Show();
       
        }

        private void dividenedParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDividendParameters DividendParameters = new frmDividendParameters();
            DividendParameters.MdiParent = this;
            DividendParameters.Show();
        }

        private void generalParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneralParameters GeneralParameters = new frmGeneralParameters();
            GeneralParameters.MdiParent = this;
            GeneralParameters.Show();
        }

        private void otherParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtherParameter OtherParameter = new frmOtherParameter();
            OtherParameter.MdiParent = this;
            OtherParameter.Show();
        }

        private void otherParametersSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtherParameterSetup OtherParameterSetup = new frmOtherParameterSetup();
            OtherParameterSetup.MdiParent = this;
            OtherParameterSetup.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany Company = new frmCompany();
            Company.MdiParent = this;
            Company.Show();
        }

        private void fiscalYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiscalYears FiscalYears = new frmFiscalYears();
            FiscalYears.MdiParent = this;
            FiscalYears.Show();
        }

        private void periodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriods Periods = new frmPeriods();
            Periods.MdiParent = this;
            Periods.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clMain.User.UpdateLogOutStatus();
            Application.Exit();
            //this.Close();
        }
        private void frmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            clMain.User.UpdateLogOutStatus();
            Application.Exit();
        }

        private void reportSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportSetup ReportSetup = new frmReportSetup();
            ReportSetup.MdiParent = this;
            ReportSetup.Show();
        }
        private void shareSubscribingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShareSubscribing ShareSubscribing = new frmShareSubscribing();
            ShareSubscribing.MdiParent = this;
            ShareSubscribing.Show();
        }
        private void sharePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSharePayment SharePayment = new frmSharePayment();
            SharePayment.MdiParent = this;
            SharePayment.Show();
        }

        private void shareTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShareTransfer ShareTransfer = new frmShareTransfer();
            ShareTransfer.MdiParent = this;
            ShareTransfer.Show();
        }

        private void createMeetinSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeetingSession MeetinSession = new frmMeetingSession();
            MeetinSession.MdiParent = this;
            MeetinSession.Show();
        }
        private void CalculateAndSaveCurrentTotalShareInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculateCurrentTotalShare CalculateCurrentTotalShare = new frmCalculateCurrentTotalShare();
            CalculateCurrentTotalShare.MdiParent = this;
            CalculateCurrentTotalShare.Show();
        }

        private void createAgendaForAMeetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeetingAgenda MeetingAgenda = new frmMeetingAgenda();
            MeetingAgenda.MdiParent = this;
            MeetingAgenda.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMeetingAttendee MeetingAttendee = new frmMeetingAttendee();
            MeetingAttendee.MdiParent = this;
            MeetingAttendee.Show();
        }

        private void votingForMeetingAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmVotingForMeetinAgenda VotingForMeetinAgenda = new frmVotingForMeetinAgenda();
            //VotingForMeetinAgenda.MdiParent = this;
            //VotingForMeetinAgenda.Show();
            frmVotingForAgenda VotingForAgenda = new frmVotingForAgenda();
            VotingForAgenda.MdiParent = this;
            VotingForAgenda.Show();
        }
        private void CalculateandSaveTotalVotperAgendaofASessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculateTotalVotPerAgendaofAsession CalculateTotalVotPerAgendaofAsession = new frmCalculateTotalVotPerAgendaofAsession();
            CalculateTotalVotPerAgendaofAsession.MdiParent = this;
            CalculateTotalVotPerAgendaofAsession.Show();
        }

        private void userAdminiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserAdmin UserAdmin = new frmUserAdmin();
            UserAdmin.MdiParent = this;
            UserAdmin.Show();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRole Role = new frmRole();
            Role.MdiParent = this;
            Role.Show();
        }

        private void vottingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportSelection ReportSelection = new frmReportSelection(1);
            ReportSelection.MdiParent = this;
            ReportSelection.Show();
        }

        private void MeetingSessionEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVotingEnquiry VotingEnquiry = new frmVotingEnquiry();
            VotingEnquiry.MdiParent = this;
            VotingEnquiry.Show();
        }

        private void closeMeetingSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCloseSession CloseSession = new frmCloseSession();
            CloseSession.MdiParent = this;
            CloseSession.Show();
        }

        private void AttendeesSummaryFollowupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendeesLiveFollowup AttendeesLiveFollowup = new frmAttendeesLiveFollowup();
            AttendeesLiveFollowup.MdiParent = this;
            AttendeesLiveFollowup.Show();
        }

        private void updateMenuDefnitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clSecurity.UpdateMenuDefinition(this.MainMenuStrip);
        }

        private void ApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplications Applications = new frmApplications();
            Applications.MdiParent = this;
            Applications.Show();
        }

        private void DefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDefaults Defaults = new frmDefaults();
            Defaults.MdiParent = this;
            Defaults.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePassword = new frmChangePassword();
            ChangePassword.MdiParent = this;
            ChangePassword.Show();
        }

        private void NameValueParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNameValueParameterSetup NameValueParameterSetup = new frmNameValueParameterSetup();
            NameValueParameterSetup.MdiParent = this;
            NameValueParameterSetup.Show();
        }

        private void dividendCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDividendCalculation DividendCalculation = new frmDividendCalculation();
            DividendCalculation.MdiParent = this;
            DividendCalculation.Show();
        }

        private void dividendReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportSelection ReportSelection = new frmReportSelection(2);
            ReportSelection.MdiParent = this;
            ReportSelection.Show();
        }

        private void YearEndStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearEnd YearEnd = new frmYearEnd();
            YearEnd.MdiParent = this;
            YearEnd.Show();
        }

        private void payDividendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayDividend PayDividend = new frmPayDividend();
            PayDividend.MdiParent = this;
            PayDividend.Show();
        }

        private void cancelSubscribedShareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelSubscribedShareTransaction CancelSubscribedShareTransaction = new frmCancelSubscribedShareTransaction();
            CancelSubscribedShareTransaction.MdiParent = this;
            CancelSubscribedShareTransaction.Show();
        }

        private void cancelPaidShareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelSharePayment CancelSharePayment = new frmCancelSharePayment();
            CancelSharePayment.MdiParent = this;
            CancelSharePayment.Show();
        }

        private void cancelTransferedShareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelShareTransfer CancelShareTransfer = new frmCancelShareTransfer();
            CancelShareTransfer.MdiParent = this;
            CancelShareTransfer.Show();
        }

        private void cancelPaidDivididendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelPaidDividend CancelPaidDividend = new frmCancelPaidDividend();
            CancelPaidDividend.MdiParent = this;
            CancelPaidDividend.Show();
        }

        private void totalShareEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTotalShareEnquiry TotalShareEnquiry = new frmTotalShareEnquiry();
            TotalShareEnquiry.MdiParent = this;
            TotalShareEnquiry.Show();
        }

        private void TerminateShareholderteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTerminateShareholder TerminateShareholder = new frmTerminateShareholder();
            TerminateShareholder.MdiParent = this;
            TerminateShareholder.Show();
        }

        private void shareTransactionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportSelection ReportSelection = new frmReportSelection(3);
            ReportSelection.MdiParent = this;
            ReportSelection.Show();
        }

        private void ElectionComitteeNomineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmElectionComitteeNominee ElectionComitteeNominee = new frmElectionComitteeNominee();
            ElectionComitteeNominee.MdiParent = this;
            ElectionComitteeNominee.Show();
        }

        private void VotForElectionCommitteNomineesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVotForElectionCommitteNominees VotForElectionCommitteNominees = new frmVotForElectionCommitteNominees();
            VotForElectionCommitteNominees.MdiParent = this;
            VotForElectionCommitteNominees.Show();
            //frmVotingForNominiOtherOption VotingForNominiOtherOption = new frmVotingForNominiOtherOption();
            //VotingForNominiOtherOption.MdiParent = this;
            //VotingForNominiOtherOption.Show();
        }

        private void ElectionNomineeFollowupFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmElectionNomineesLiveFollowup ElectionNomineesLiveFollowup = new frmElectionNomineesLiveFollowup();
            ElectionNomineesLiveFollowup.MdiParent = this;
            ElectionNomineesLiveFollowup.Show();
        }

        private void AttendeeExtraOrdinaryFollowupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmergencyMeetingAttendeesLiveFollowup EmergencyMeetingAttendeesLiveFollowup = new frmEmergencyMeetingAttendeesLiveFollowup();
            EmergencyMeetingAttendeesLiveFollowup.MdiParent = this;
            EmergencyMeetingAttendeesLiveFollowup.Show();
        }

        private void CalculateandSaveTotalVotperNomineeofASessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculateTotalVotPerNomineeofAsession CalculateTotalVotPerNomineeofAsession = new frmCalculateTotalVotPerNomineeofAsession();
            CalculateTotalVotPerNomineeofAsession.MdiParent = this;
            CalculateTotalVotPerNomineeofAsession.Show();
        }

        private void CaptureEmergencyMeetingAttendeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmergencyMeetingAttendee EmergencyMeetingAttendee = new frmEmergencyMeetingAttendee();
            EmergencyMeetingAttendee.MdiParent = this;
            EmergencyMeetingAttendee.Show();
        }

        private void shareholderDetailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportSelection ReportSelection = new frmReportSelection(4);
            ReportSelection.MdiParent = this;
            ReportSelection.Show();
        }

        private void PayDividendPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDividendPayable DividendPayable = new frmDividendPayable();
            DividendPayable.MdiParent = this;
            DividendPayable.Show();
        }

        private void CalendarConvertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalendarConvertor CalendarConvertor = new frmCalendarConvertor();
            CalendarConvertor.MdiParent = this;
            CalendarConvertor.Show();
        }

        private void CashPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCashPayable CashPayable = new frmCashPayable();
            CashPayable.MdiParent = this;
            CashPayable.Show();
        }

        private void PayCashPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPayCashPayable PayCashPayable = new frmPayCashPayable();
            PayCashPayable.MdiParent = this;
            PayCashPayable.Show();
        }

        private void cancelPaidDividendPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelPayDividendPayable CancelPayDividendPayable = new frmCancelPayDividendPayable();
            CancelPayDividendPayable.MdiParent = this;
            CancelPayDividendPayable.Show();
        }

        private void cancelPaidCashPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelPaidCashPayable CancelPaidCashPayable = new frmCancelPaidCashPayable();
            CancelPaidCashPayable.MdiParent = this;
            CancelPaidCashPayable.Show();
        }

        private void votingForBoDsElectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVotforBoDNominee VotforBoDNominee = new frmVotforBoDNominee();
            VotforBoDNominee.MdiParent = this;
            VotforBoDNominee.Show();
        }

        private void NominateBoDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoardofDirectorsNominee BordofDirectorsNominee = new frmBoardofDirectorsNominee();
            BordofDirectorsNominee.MdiParent = this;
            BordofDirectorsNominee.Show();
            
        }

        private void CalculateandSaveTotalVotperBoDsNomineeofaSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculateTotalVotPerBoDsNomineeofAsession CalculateTotalVotPerBoDsNomineeofAsession = new frmCalculateTotalVotPerBoDsNomineeofAsession();
            CalculateTotalVotPerBoDsNomineeofAsession.MdiParent = this;
            CalculateTotalVotPerBoDsNomineeofAsession.Show();
            
        }

        private void BoDsVotingFollowupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoDsVotingFollowup BoDsVotingFollowup = new frmBoDsVotingFollowup();
            BoDsVotingFollowup.MdiParent = this;
            //this.MainMenuStrip.Visible = false;
            BoDsVotingFollowup.Show();
        }

       
       
       
       
       
        

        

       

      
    }
}
