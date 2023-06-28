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
    public partial class frmReportPreview : Form
    {
        #region Fields
        private clReportConfig _rptConfig;
        #endregion

        #region Properties
        public clReportConfig ReportConfig
        {
            get { return this._rptConfig; }
            set { this._rptConfig = value; }
        }
        #endregion

        #region Methods
        public frmReportPreview()
        {
            InitializeComponent();
        }

        private void frmReportPreview_Load(object sender, EventArgs e)
        {
            this.Text = this._rptConfig.ReportTitle;
            this.ctrlReportViewer.DisplayGroupTree = this._rptConfig.DisplayGroupTree;
            this.ctrlReportViewer.ShowGroupTreeButton = this._rptConfig.DisplayGroupTree;
            this.ctrlReportViewer.ReportSource = this._rptConfig.ReportDoc;
        }
        #endregion

    }
}
