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
    public partial class frmReminderSelection : Form
    {
        #region Fields
        private int _reminderGroup;
        private int _remId;
        DataTable _tblReminders;
        #endregion

        #region Properties
        public DevExpress.XtraGrid.GridControl ReminderGrid
        {
            get { return this.gctRemSelection; }
        }
        #endregion

        public frmReminderSelection(int reminderGroup)
        {
            InitializeComponent();
           
        }

        private void frmReminderSelection_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void frmReminderSelection_KeyDown(object sender, KeyEventArgs e)
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
                this._tblReminders = DataObj.GetDataTable("tblReminders");
                clMain.SetDataSource(this.gctRemSelection, this._tblReminders);
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
                    DataObj.FillData(this._tblReminders, "SELECT RemId, RemMessage, DataSource FROM tblReminders WHERE IsActive=1");
                    foreach (DataRow row in this._tblReminders.Rows)
                    {
                        if (DataObj.GetDataScalar(row["DataSource"].ToString().Replace("LoginUser", clMain.User.UserName)) == null)
                        {
                            row.Delete();
                        }
                    }
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

        private void gridRemSelection_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridRemSelection.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridRemSelection.GetDataRow(focused);
                this._remId = Convert.ToInt32(curRow["RemId"]);
                frmReminderPreview frmRemPreview = new frmReminderPreview(this._remId, clMain.ConnString);
                frmRemPreview.Show();
                this.gridRemSelection.FocusedRowHandle = focused;
            }
        }

        private void gridRepSelection_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

