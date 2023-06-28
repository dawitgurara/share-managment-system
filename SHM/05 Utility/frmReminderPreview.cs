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
    public partial class frmReminderPreview : Form
    {
        #region Fields
        private clReminder _reminder;
        DataTable _tblPreview;
        #endregion

        public frmReminderPreview(int reminderId, string connString)
        {
            InitializeComponent();
            this._reminder = new clReminder(reminderId);
            this.Text = this._reminder.ReminderMessage;
        }

        private void frmReminderPreview_Load(object sender, EventArgs e)
        {
            BindControls();
        }

        private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                this._tblPreview = new DataTable();
                DataObj.FillData(this._tblPreview, this._reminder.DataSource);
                clMain.SetDataSource(this.gctRemPreview, this._tblPreview);
                this.gridRemPreview.BestFitColumns();
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
