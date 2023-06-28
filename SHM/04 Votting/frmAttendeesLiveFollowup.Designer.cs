namespace SHM
{
    partial class frmAttendeesLiveFollowup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gctSummaryofatendee = new DevExpress.XtraGrid.GridControl();
            this.gridSummaryofAttendee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSessionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSubscribedShNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAttendeeSubscribedShNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentageofAttendeeSubscrShNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercOfSHSupsdToAtndRegMeeting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvarianceReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNoOfShareholder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNoOfAttendee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentageofAttendee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSubscribedShAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAttendeeSubscribedShAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPaidupShAmnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPaidupShNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvarianceEmergency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercOfSHSupsdToAtndEmrgMeeting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rluCatagory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluBudgetYear = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluMeetingType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rluAgenda = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.AmharicMessageLabel = new System.Windows.Forms.Label();
            this.EnglishMessageLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentPercentagelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MeetinRoundLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gctSummaryofatendee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummaryofAttendee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // gctSummaryofatendee
            // 
            this.gctSummaryofatendee.EmbeddedNavigator.Name = "";
            this.gctSummaryofatendee.Location = new System.Drawing.Point(15, 441);
            this.gctSummaryofatendee.MainView = this.gridSummaryofAttendee;
            this.gctSummaryofatendee.Name = "gctSummaryofatendee";
            this.gctSummaryofatendee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rluCatagory,
            this.rluBudgetYear,
            this.rluMeetingType,
            this.rluAgenda});
            this.gctSummaryofatendee.Size = new System.Drawing.Size(1354, 187);
            this.gctSummaryofatendee.TabIndex = 22;
            this.gctSummaryofatendee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSummaryofAttendee});
            // 
            // gridSummaryofAttendee
            // 
            this.gridSummaryofAttendee.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 48F);
            this.gridSummaryofAttendee.Appearance.Row.Options.UseFont = true;
            this.gridSummaryofAttendee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSessionId,
            this.colTotalSubscribedShNo,
            this.colTotalAttendeeSubscribedShNo,
            this.colPercentageofAttendeeSubscrShNo,
            this.colPercOfSHSupsdToAtndRegMeeting,
            this.colvarianceReg,
            this.colTotalNoOfShareholder,
            this.colTotalNoOfAttendee,
            this.colPercentageofAttendee,
            this.colTotalSubscribedShAmnt,
            this.colTotalAttendeeSubscribedShAmnt,
            this.colTotalPaidupShAmnt,
            this.colTotalPaidupShNo,
            this.colvarianceEmergency,
            this.colPercOfSHSupsdToAtndEmrgMeeting});
            this.gridSummaryofAttendee.CustomizationFormBounds = new System.Drawing.Rectangle(1062, 472, 208, 170);
            this.gridSummaryofAttendee.GridControl = this.gctSummaryofatendee;
            this.gridSummaryofAttendee.Name = "gridSummaryofAttendee";
            this.gridSummaryofAttendee.OptionsBehavior.Editable = false;
            this.gridSummaryofAttendee.OptionsView.ColumnAutoWidth = false;
            this.gridSummaryofAttendee.OptionsView.ShowColumnHeaders = false;
            this.gridSummaryofAttendee.OptionsView.ShowGroupPanel = false;
            this.gridSummaryofAttendee.RowHeight = 70;
            this.gridSummaryofAttendee.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            // 
            // colSessionId
            // 
            this.colSessionId.Caption = "SessionId";
            this.colSessionId.FieldName = "SessionId";
            this.colSessionId.Name = "colSessionId";
            // 
            // colTotalSubscribedShNo
            // 
            this.colTotalSubscribedShNo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.colTotalSubscribedShNo.AppearanceCell.Options.UseFont = true;
            this.colTotalSubscribedShNo.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 12.75F, System.Drawing.FontStyle.Bold);
            this.colTotalSubscribedShNo.AppearanceHeader.Options.UseFont = true;
            this.colTotalSubscribedShNo.Caption = "-Q§§ yxKs!×N B²T";
            this.colTotalSubscribedShNo.FieldName = "TotalSubscribedShNo";
            this.colTotalSubscribedShNo.Name = "colTotalSubscribedShNo";
            this.colTotalSubscribedShNo.Visible = true;
            this.colTotalSubscribedShNo.VisibleIndex = 0;
            this.colTotalSubscribedShNo.Width = 246;
            // 
            // colTotalAttendeeSubscribedShNo
            // 
            this.colTotalAttendeeSubscribedShNo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.colTotalAttendeeSubscribedShNo.AppearanceCell.Options.UseFont = true;
            this.colTotalAttendeeSubscribedShNo.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 12.75F, System.Drawing.FontStyle.Bold);
            this.colTotalAttendeeSubscribedShNo.AppearanceHeader.Options.UseFont = true;
            this.colTotalAttendeeSubscribedShNo.Caption = "ytú¬ðãC yxKs!×N B²T";
            this.colTotalAttendeeSubscribedShNo.FieldName = "TotalAttendeeSubscribedShNo";
            this.colTotalAttendeeSubscribedShNo.Name = "colTotalAttendeeSubscribedShNo";
            this.colTotalAttendeeSubscribedShNo.Visible = true;
            this.colTotalAttendeeSubscribedShNo.VisibleIndex = 1;
            this.colTotalAttendeeSubscribedShNo.Width = 162;
            // 
            // colPercentageofAttendeeSubscrShNo
            // 
            this.colPercentageofAttendeeSubscrShNo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.colPercentageofAttendeeSubscrShNo.AppearanceCell.Options.UseFont = true;
            this.colPercentageofAttendeeSubscrShNo.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 12.75F, System.Drawing.FontStyle.Bold);
            this.colPercentageofAttendeeSubscrShNo.AppearanceHeader.Options.UseFont = true;
            this.colPercentageofAttendeeSubscrShNo.Caption = "ytú¬ðãC yxKs!×N B²T bmè¾";
            this.colPercentageofAttendeeSubscrShNo.FieldName = "PercentageofAttendeeSubscrShNo";
            this.colPercentageofAttendeeSubscrShNo.Name = "colPercentageofAttendeeSubscrShNo";
            this.colPercentageofAttendeeSubscrShNo.OptionsColumn.ReadOnly = true;
            this.colPercentageofAttendeeSubscrShNo.Visible = true;
            this.colPercentageofAttendeeSubscrShNo.VisibleIndex = 2;
            this.colPercentageofAttendeeSubscrShNo.Width = 186;
            // 
            // colPercOfSHSupsdToAtndRegMeeting
            // 
            this.colPercOfSHSupsdToAtndRegMeeting.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.colPercOfSHSupsdToAtndRegMeeting.AppearanceCell.Options.UseFont = true;
            this.colPercOfSHSupsdToAtndRegMeeting.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 12.75F, System.Drawing.FontStyle.Bold);
            this.colPercOfSHSupsdToAtndRegMeeting.AppearanceHeader.Options.UseFont = true;
            this.colPercOfSHSupsdToAtndRegMeeting.Caption = "tf§g!ý Zqt¾ MLxt g#Æx@ bmè¾";
            this.colPercOfSHSupsdToAtndRegMeeting.FieldName = "PercOfSHSupsdToAtndRegMeeting";
            this.colPercOfSHSupsdToAtndRegMeeting.Name = "colPercOfSHSupsdToAtndRegMeeting";
            this.colPercOfSHSupsdToAtndRegMeeting.Visible = true;
            this.colPercOfSHSupsdToAtndRegMeeting.VisibleIndex = 3;
            this.colPercOfSHSupsdToAtndRegMeeting.Width = 140;
            // 
            // colvarianceReg
            // 
            this.colvarianceReg.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.colvarianceReg.AppearanceCell.Options.UseFont = true;
            this.colvarianceReg.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 12.75F, System.Drawing.FontStyle.Bold);
            this.colvarianceReg.AppearanceHeader.Options.UseFont = true;
            this.colvarianceReg.Caption = "L†nT";
            this.colvarianceReg.FieldName = "varianceReg";
            this.colvarianceReg.Name = "colvarianceReg";
            this.colvarianceReg.OptionsColumn.ReadOnly = true;
            this.colvarianceReg.Visible = true;
            this.colvarianceReg.VisibleIndex = 4;
            this.colvarianceReg.Width = 126;
            // 
            // colTotalNoOfShareholder
            // 
            this.colTotalNoOfShareholder.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.colTotalNoOfShareholder.AppearanceCell.Options.UseFont = true;
            this.colTotalNoOfShareholder.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 15.75F, System.Drawing.FontStyle.Bold);
            this.colTotalNoOfShareholder.AppearanceHeader.Options.UseFont = true;
            this.colTotalNoOfShareholder.Caption = "-Q§§ yxKs!×N B²T";
            this.colTotalNoOfShareholder.FieldName = "TotalNoOfShareholder";
            this.colTotalNoOfShareholder.Name = "colTotalNoOfShareholder";
            this.colTotalNoOfShareholder.Visible = true;
            this.colTotalNoOfShareholder.VisibleIndex = 5;
            this.colTotalNoOfShareholder.Width = 167;
            // 
            // colTotalNoOfAttendee
            // 
            this.colTotalNoOfAttendee.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.colTotalNoOfAttendee.AppearanceCell.Options.UseFont = true;
            this.colTotalNoOfAttendee.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 12.75F, System.Drawing.FontStyle.Bold);
            this.colTotalNoOfAttendee.AppearanceHeader.Options.UseFont = true;
            this.colTotalNoOfAttendee.Caption = "-Q§§ ytú¬ð B²T";
            this.colTotalNoOfAttendee.FieldName = "TotalNoOfAttendee";
            this.colTotalNoOfAttendee.Name = "colTotalNoOfAttendee";
            this.colTotalNoOfAttendee.Visible = true;
            this.colTotalNoOfAttendee.VisibleIndex = 6;
            this.colTotalNoOfAttendee.Width = 145;
            // 
            // colPercentageofAttendee
            // 
            this.colPercentageofAttendee.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.colPercentageofAttendee.AppearanceCell.Options.UseFont = true;
            this.colPercentageofAttendee.AppearanceHeader.Font = new System.Drawing.Font("VG2 Main", 12.75F, System.Drawing.FontStyle.Bold);
            this.colPercentageofAttendee.AppearanceHeader.Options.UseFont = true;
            this.colPercentageofAttendee.Caption = "ytú¬ð B²T bmè¾";
            this.colPercentageofAttendee.FieldName = "PercentageofAttendee";
            this.colPercentageofAttendee.Name = "colPercentageofAttendee";
            this.colPercentageofAttendee.OptionsColumn.ReadOnly = true;
            this.colPercentageofAttendee.Visible = true;
            this.colPercentageofAttendee.VisibleIndex = 7;
            this.colPercentageofAttendee.Width = 137;
            // 
            // colTotalSubscribedShAmnt
            // 
            this.colTotalSubscribedShAmnt.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 42F);
            this.colTotalSubscribedShAmnt.AppearanceCell.Options.UseFont = true;
            this.colTotalSubscribedShAmnt.Caption = "TotalSubscribedShAmnt";
            this.colTotalSubscribedShAmnt.FieldName = "TotalSubscribedShAmnt";
            this.colTotalSubscribedShAmnt.Name = "colTotalSubscribedShAmnt";
            // 
            // colTotalAttendeeSubscribedShAmnt
            // 
            this.colTotalAttendeeSubscribedShAmnt.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 42F);
            this.colTotalAttendeeSubscribedShAmnt.AppearanceCell.Options.UseFont = true;
            this.colTotalAttendeeSubscribedShAmnt.Caption = "TotalAttendeeSubscribedShAmnt";
            this.colTotalAttendeeSubscribedShAmnt.FieldName = "TotalAttendeeSubscribedShAmnt";
            this.colTotalAttendeeSubscribedShAmnt.Name = "colTotalAttendeeSubscribedShAmnt";
            // 
            // colTotalPaidupShAmnt
            // 
            this.colTotalPaidupShAmnt.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 42F);
            this.colTotalPaidupShAmnt.AppearanceCell.Options.UseFont = true;
            this.colTotalPaidupShAmnt.Caption = "TotalPaidupShAmnt";
            this.colTotalPaidupShAmnt.FieldName = "TotalPaidupShAmnt";
            this.colTotalPaidupShAmnt.Name = "colTotalPaidupShAmnt";
            // 
            // colTotalPaidupShNo
            // 
            this.colTotalPaidupShNo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 42F);
            this.colTotalPaidupShNo.AppearanceCell.Options.UseFont = true;
            this.colTotalPaidupShNo.Caption = "TotalPaidupShNo";
            this.colTotalPaidupShNo.FieldName = "TotalPaidupShNo";
            this.colTotalPaidupShNo.Name = "colTotalPaidupShNo";
            // 
            // colvarianceEmergency
            // 
            this.colvarianceEmergency.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 42F);
            this.colvarianceEmergency.AppearanceCell.Options.UseFont = true;
            this.colvarianceEmergency.Caption = "varianceEmergency";
            this.colvarianceEmergency.FieldName = "varianceEmergency";
            this.colvarianceEmergency.Name = "colvarianceEmergency";
            this.colvarianceEmergency.OptionsColumn.ReadOnly = true;
            // 
            // colPercOfSHSupsdToAtndEmrgMeeting
            // 
            this.colPercOfSHSupsdToAtndEmrgMeeting.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 42F);
            this.colPercOfSHSupsdToAtndEmrgMeeting.AppearanceCell.Options.UseFont = true;
            this.colPercOfSHSupsdToAtndEmrgMeeting.Caption = "PercOfSHSupsdToAtndEmrgMeeting";
            this.colPercOfSHSupsdToAtndEmrgMeeting.FieldName = "PercOfSHSupsdToAtndEmrgMeeting";
            this.colPercOfSHSupsdToAtndEmrgMeeting.Name = "colPercOfSHSupsdToAtndEmrgMeeting";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // rluCatagory
            // 
            this.rluCatagory.AutoHeight = false;
            this.rluCatagory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluCatagory.DisplayMember = "Description";
            this.rluCatagory.Name = "rluCatagory";
            this.rluCatagory.NullText = "";
            this.rluCatagory.ValueMember = "Id";
            // 
            // rluBudgetYear
            // 
            this.rluBudgetYear.AutoHeight = false;
            this.rluBudgetYear.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluBudgetYear.Name = "rluBudgetYear";
            this.rluBudgetYear.NullText = "";
            // 
            // rluMeetingType
            // 
            this.rluMeetingType.AutoHeight = false;
            this.rluMeetingType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluMeetingType.DisplayMember = "Description";
            this.rluMeetingType.Name = "rluMeetingType";
            this.rluMeetingType.NullText = "";
            this.rluMeetingType.ValueMember = "Id";
            // 
            // rluAgenda
            // 
            this.rluAgenda.AutoHeight = false;
            this.rluAgenda.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluAgenda.DisplayMember = "Agenda";
            this.rluAgenda.Name = "rluAgenda";
            this.rluAgenda.NullText = "";
            this.rluAgenda.ValueMember = "AgendaId";
            // 
            // AmharicMessageLabel
            // 
            this.AmharicMessageLabel.Font = new System.Drawing.Font("VG2 Main", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmharicMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AmharicMessageLabel.Location = new System.Drawing.Point(33, 68);
            this.AmharicMessageLabel.Name = "AmharicMessageLabel";
            this.AmharicMessageLabel.Size = new System.Drawing.Size(1218, 62);
            this.AmharicMessageLabel.TabIndex = 23;
            this.AmharicMessageLabel.Text = "MLxt g#Æx@ý Slä§ SBsÆýN mjmR YÒ§LÝÝ";
            // 
            // EnglishMessageLabel
            // 
            this.EnglishMessageLabel.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.EnglishMessageLabel.Location = new System.Drawing.Point(23, 140);
            this.EnglishMessageLabel.Name = "EnglishMessageLabel";
            this.EnglishMessageLabel.Size = new System.Drawing.Size(1331, 108);
            this.EnglishMessageLabel.TabIndex = 24;
            this.EnglishMessageLabel.Text = "The minimum required quorum has been attained . Now it is possible to start the m" +
                "eeting.";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("VG2 Main", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(923, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 29);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "s›TÝ";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeLabel.Location = new System.Drawing.Point(983, 3);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(281, 29);
            this.CurrentTimeLabel.TabIndex = 61;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("VG2 Main", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.welcomeLabel.Location = new System.Drawing.Point(23, 40);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(1331, 102);
            this.welcomeLabel.TabIndex = 62;
            this.welcomeLabel.Text = "XNµ*N wd   ¾ý yÆlxKs!×ñC ›m¬êE mdb¾ -Q§§ g#Æx@ bdHÂ mÈCh# ÝÝ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("VG2 Main", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(12, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 41);
            this.label2.TabIndex = 63;
            this.label2.Text = "ytú¬ðãC xKs!×N B²T bmè¾Ý";
            // 
            // currentPercentagelabel
            // 
            this.currentPercentagelabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPercentagelabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.currentPercentagelabel.Location = new System.Drawing.Point(712, -1);
            this.currentPercentagelabel.Name = "currentPercentagelabel";
            this.currentPercentagelabel.Size = new System.Drawing.Size(160, 41);
            this.currentPercentagelabel.TabIndex = 64;
            this.currentPercentagelabel.Click += new System.EventHandler(this.currentPercentagelabel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("VG2 Main", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 112);
            this.label3.TabIndex = 75;
            this.label3.Text = "የተሳታፊዎች የአክሲዮን ብዛት";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("VG2 Main", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 112);
            this.label4.TabIndex = 74;
            this.label4.Text = "ጠቅላላ የአክሲዮን ብዛት";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("VG2 Main", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 112);
            this.label5.TabIndex = 76;
            this.label5.Text = "የተሳታፊዎች የአክሲዮን ብዛት በመቶኛ";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("VG2 Main", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(627, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 111);
            this.label6.TabIndex = 77;
            this.label6.Text = "ምልአተ ጉባኤ በመቶኛ";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("VG2 Main", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(766, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 112);
            this.label7.TabIndex = 78;
            this.label7.Text = "ልዩነት በመቶኛ";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("VG2 Main", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(893, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 112);
            this.label8.TabIndex = 79;
            this.label8.Text = "የባለአክሲዮኖች ብዛት";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("VG2 Main", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1205, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 112);
            this.label9.TabIndex = 80;
            this.label9.Text = "የተሳታፊ ባለአክሲዮኖች  በመቶኛ";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("VG2 Main", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1057, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 112);
            this.label10.TabIndex = 81;
            this.label10.Text = " የተሳታፊ ባለአክሲዮኖች ብዛት በመቶኛ";
            // 
            // MeetinRoundLabel
            // 
            this.MeetinRoundLabel.AutoSize = true;
            this.MeetinRoundLabel.Font = new System.Drawing.Font("Times New Roman", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetinRoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MeetinRoundLabel.Location = new System.Drawing.Point(257, 40);
            this.MeetinRoundLabel.Name = "MeetinRoundLabel";
            this.MeetinRoundLabel.Size = new System.Drawing.Size(66, 51);
            this.MeetinRoundLabel.TabIndex = 82;
            this.MeetinRoundLabel.Text = "10";
            // 
            // frmAttendeesLiveFollowup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 635);
            this.Controls.Add(this.MeetinRoundLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentPercentagelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.EnglishMessageLabel);
            this.Controls.Add(this.AmharicMessageLabel);
            this.Controls.Add(this.gctSummaryofatendee);
            this.Name = "frmAttendeesLiveFollowup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ySBsÆ tú¬ðãC mk¬TÃ g{";
            this.Load += new System.EventHandler(this.frmAttendeesLiveFollowup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gctSummaryofatendee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummaryofAttendee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluBudgetYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluMeetingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctSummaryofatendee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSummaryofAttendee;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluAgenda;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluCatagory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluBudgetYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluMeetingType;
        private System.Windows.Forms.Label AmharicMessageLabel;
        private System.Windows.Forms.Label EnglishMessageLabel;
        private System.Windows.Forms.Label Label1;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionId;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNoOfShareholder;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNoOfAttendee;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentageofAttendee;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSubscribedShNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAttendeeSubscribedShNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentageofAttendeeSubscrShNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSubscribedShAmnt;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAttendeeSubscribedShAmnt;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPaidupShAmnt;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPaidupShNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPercOfSHSupsdToAtndRegMeeting;
        private DevExpress.XtraGrid.Columns.GridColumn colvarianceReg;
        private DevExpress.XtraGrid.Columns.GridColumn colvarianceEmergency;
        private DevExpress.XtraGrid.Columns.GridColumn colPercOfSHSupsdToAtndEmrgMeeting;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentPercentagelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label MeetinRoundLabel;
    }
}