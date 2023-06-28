namespace SHM
{
    partial class frmNameValueParameterSetup
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
            System.Windows.Forms.Label parameterNameLabel;
            System.Windows.Forms.Label parameterDescriptionLabel;
            System.Windows.Forms.Label parameterValueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNameValueParameterSetup));
            this.nameValueParametertoolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.gctNameValueParameter = new DevExpress.XtraGrid.GridControl();
            this.gridNameValueParameter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.parameterNameTextBox = new System.Windows.Forms.TextBox();
            this.parameterDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.parameterValueTextBox = new System.Windows.Forms.TextBox();
            parameterNameLabel = new System.Windows.Forms.Label();
            parameterDescriptionLabel = new System.Windows.Forms.Label();
            parameterValueLabel = new System.Windows.Forms.Label();
            this.nameValueParametertoolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctNameValueParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNameValueParameter)).BeginInit();
            this.SuspendLayout();
            // 
            // parameterNameLabel
            // 
            parameterNameLabel.AutoSize = true;
            parameterNameLabel.Location = new System.Drawing.Point(12, 43);
            parameterNameLabel.Name = "parameterNameLabel";
            parameterNameLabel.Size = new System.Drawing.Size(89, 13);
            parameterNameLabel.TabIndex = 7;
            parameterNameLabel.Text = "Parameter Name:";
            // 
            // parameterDescriptionLabel
            // 
            parameterDescriptionLabel.AutoSize = true;
            parameterDescriptionLabel.Location = new System.Drawing.Point(12, 71);
            parameterDescriptionLabel.Name = "parameterDescriptionLabel";
            parameterDescriptionLabel.Size = new System.Drawing.Size(114, 13);
            parameterDescriptionLabel.TabIndex = 8;
            parameterDescriptionLabel.Text = "Parameter Description:";
            // 
            // parameterValueLabel
            // 
            parameterValueLabel.AutoSize = true;
            parameterValueLabel.Location = new System.Drawing.Point(13, 102);
            parameterValueLabel.Name = "parameterValueLabel";
            parameterValueLabel.Size = new System.Drawing.Size(88, 13);
            parameterValueLabel.TabIndex = 9;
            parameterValueLabel.Text = "Parameter Value:";
            // 
            // nameValueParametertoolStrip
            // 
            this.nameValueParametertoolStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nameValueParametertoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.printToolStripButton,
            this.refreshToolStripButton,
            this.toolStripSeparator});
            this.nameValueParametertoolStrip.Location = new System.Drawing.Point(0, 0);
            this.nameValueParametertoolStrip.Name = "nameValueParametertoolStrip";
            this.nameValueParametertoolStrip.Size = new System.Drawing.Size(704, 25);
            this.nameValueParametertoolStrip.TabIndex = 4;
            this.nameValueParametertoolStrip.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(44, 22);
            this.deleteToolStripButton.Text = "&Delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.refreshToolStripButton.Text = "&Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // gctNameValueParameter
            // 
            this.gctNameValueParameter.EmbeddedNavigator.Name = "";
            this.gctNameValueParameter.Location = new System.Drawing.Point(16, 141);
            this.gctNameValueParameter.MainView = this.gridNameValueParameter;
            this.gctNameValueParameter.Name = "gctNameValueParameter";
            this.gctNameValueParameter.Size = new System.Drawing.Size(644, 320);
            this.gctNameValueParameter.TabIndex = 10;
            this.gctNameValueParameter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridNameValueParameter});
            this.gctNameValueParameter.DoubleClick += new System.EventHandler(this.gridNameValueParameter_DoubleClick);
            // 
            // gridNameValueParameter
            // 
            this.gridNameValueParameter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridNameValueParameter.GridControl = this.gctNameValueParameter;
            this.gridNameValueParameter.Name = "gridNameValueParameter";
            this.gridNameValueParameter.OptionsBehavior.Editable = false;
            this.gridNameValueParameter.OptionsView.ColumnAutoWidth = false;
            this.gridNameValueParameter.OptionsView.ShowDetailButtons = false;
            this.gridNameValueParameter.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Parameter Key";
            this.gridColumn1.FieldName = "ParameterName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 190;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Description";
            this.gridColumn2.FieldName = "ParameterDescription";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 200;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Parameter Value";
            this.gridColumn3.FieldName = "ParameterValue";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 220;
            // 
            // parameterNameTextBox
            // 
            this.parameterNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parameterNameTextBox.Location = new System.Drawing.Point(132, 41);
            this.parameterNameTextBox.Name = "parameterNameTextBox";
            this.parameterNameTextBox.Size = new System.Drawing.Size(411, 20);
            this.parameterNameTextBox.TabIndex = 65;
            this.parameterNameTextBox.Validated += new System.EventHandler(this.parameterNameTextBox_Validated);
            // 
            // parameterDescriptionTextBox
            // 
            this.parameterDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parameterDescriptionTextBox.Location = new System.Drawing.Point(132, 71);
            this.parameterDescriptionTextBox.Name = "parameterDescriptionTextBox";
            this.parameterDescriptionTextBox.Size = new System.Drawing.Size(411, 20);
            this.parameterDescriptionTextBox.TabIndex = 66;
            // 
            // parameterValueTextBox
            // 
            this.parameterValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parameterValueTextBox.Location = new System.Drawing.Point(132, 97);
            this.parameterValueTextBox.Name = "parameterValueTextBox";
            this.parameterValueTextBox.Size = new System.Drawing.Size(411, 20);
            this.parameterValueTextBox.TabIndex = 67;
            // 
            // frmNameValueParameterSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(704, 458);
            this.Controls.Add(this.parameterValueTextBox);
            this.Controls.Add(this.parameterDescriptionTextBox);
            this.Controls.Add(this.parameterNameTextBox);
            this.Controls.Add(this.gctNameValueParameter);
            this.Controls.Add(parameterNameLabel);
            this.Controls.Add(parameterDescriptionLabel);
            this.Controls.Add(parameterValueLabel);
            this.Controls.Add(this.nameValueParametertoolStrip);
            this.Name = "frmNameValueParameterSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name Value Parameter Entry Form";
            this.Load += new System.EventHandler(this.frmNameValueParameterSetup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNameValueParameterSetup_KeyDown);
            this.nameValueParametertoolStrip.ResumeLayout(false);
            this.nameValueParametertoolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctNameValueParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNameValueParameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip nameValueParametertoolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private DevExpress.XtraGrid.GridControl gctNameValueParameter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridNameValueParameter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.TextBox parameterNameTextBox;
        private System.Windows.Forms.TextBox parameterDescriptionTextBox;
        private System.Windows.Forms.TextBox parameterValueTextBox;
    }
}