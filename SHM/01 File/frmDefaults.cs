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
    public partial class frmDefaults : Form
    {
        #region Fields
        private string _title = "Defaults";
        private DataTable _tblDefaults;
        private DataRow _defaults;
        #endregion

        #region Methods
        public frmDefaults()
        {
            InitializeComponent();
        }

        private void frmDefaults_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void frmDefaults_KeyDown(object sender, KeyEventArgs e)
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

                this._tblDefaults = DataObj.GetDataTable("tblDefaults");
                this._tblDefaults.Columns["Id"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.PasswordExpiryDaysTextBox,
                    this.GraceLoginsTextBox,
                    this.NoOfUnsuccessAttemptTextBox,
                    this.MinimumPwdLengthTextBox
                  
                   
                });

                clMain.BindControls(cntrsList, this._tblDefaults);
                cntrsList.Clear();

              

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

                }
                DataObj.FillData(this._tblDefaults, "SELECT * FROM tblDefaults");
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                if (this.Validate())
                {
                    this._defaults = this._tblDefaults.Rows[0];
                    if (this._defaults == null)
                    {
                        AppMessageBox.ShowExclamation("Record could not be loaded. Please correct the data and try again");
                        return;
                    }
                    if (DataObj.Update(this._title, this._defaults, true))
                    {
                        InitForm(false);
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

        private void refreshToolStripButton1_Click(object sender, EventArgs e)
        {
            InitForm(true);
        }


        #endregion




    }
}
