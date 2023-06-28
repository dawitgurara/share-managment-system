using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SHM
{
    public class clReminder
    {
         #region Fields
        
        private int _remId;
        private string _remMessage;
        private string _dataSource;
        private bool _isActive;
        #endregion

        #region Properties
       
        public int ReminderId
        {
            get { return this._remId; }
        }
        public string ReminderMessage
        {
            get { return this._remMessage; }
        }
        public string DataSource
        {
            get { return this._dataSource; }
        }
        public bool IsActive
        {
            get { return this._isActive; }
        }
        #endregion


         public clReminder(int reminderId)
        {
            
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblReminders WHERE RemId=" + reminderId;
                Ds = DataObj.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = Ds.Tables[0].Rows[0];
                    this._remId = Convert.ToInt32(row["RemId"]);
                    this._remMessage = Convert.ToString(row["RemMessage"]);
                    this._dataSource = Convert.ToString(row["DataSource"]);
                    this._isActive = Convert.ToBoolean(row["IsActive"]);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }
    }
}
