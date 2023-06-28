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
    public partial class frmReportSelection : Form
    {
        private int _reportGroup;
        private int _reportId;
        DataTable _tblReports;
        private Form _mdiForm;

        public frmReportSelection(int reportGroup)
        {
            object result;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            this._reportGroup = reportGroup;
            InitializeComponent();
            try
            {
                DataObj.OpenConnection();
                result = DataObj.GetValue("tblReportGroup", "RepGroupName", "RepGroupId=" + this._reportGroup);
                if (result != null && !Convert.IsDBNull(result))
                {
                    this.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                AppMessageBox.ShowExclamation(ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void frmReportSelection_Load(object sender, EventArgs e)
        {
            _mdiForm = this.MdiParent;
            BindControls();
            InitForm(true);
        }

        private void frmReportSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.InitForm(true);
            }
        }

        private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                this._tblReports = DataObj.GetDataTable("tblReports");
                clMain.SetDataSource(this.gctRepSelection, this._tblReports);
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
            string cmdText;
            try
            {
                DataObj.OpenConnection();
                // cmdText = "SELECT RepId, RepName FROM tblReports WHERE ReportGroup=" + this._reportGroup + " AND IsActive=1 AND RepId IN (SELECT RepId FROM View_UserReportRights WHERE UserName='" + AppMain.User.UserName + "') ORDER BY RepName";
                //if (clMain.User.UserID == 1)
                    cmdText = "SELECT RepId, RepName FROM tblReports WHERE ReportGroup=" + this._reportGroup + " AND IsActive=1 ORDER BY RepName";
                //else
                //    cmdText = "SELECT RepId, RepName FROM tblReports WHERE ReportGroup=" + this._reportGroup + " AND IsActive=1 AND RepId IN (" + clUser.GetReportRights(clMain.User.UserID, clMain.AppName) + ") ORDER BY RepName";


                if (All)
                {
                    DataObj.FillData(this._tblReports, cmdText);
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

        private void gridRepSelection_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridRepSelection.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridRepSelection.GetDataRow(focused);
                this._reportId = Convert.ToInt32(curRow["RepId"]);
                frmReportParameter frmRepParam = new frmReportParameter(this._reportId, _mdiForm);
                frmRepParam.Text += (" for " + Convert.ToString(curRow["RepName"]));
                frmRepParam.ShowDialog();
                this.gridRepSelection.FocusedRowHandle = focused;
            }
        }

        private void gridRepSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.gridRepSelection_DoubleClick(sender, new EventArgs());
            }
        }



    }
}
