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
    public partial class frmGeneralParameters : Form
    {
        #region Fields
        private string _title = "General Parameters";


        private DataTable _tblGeneralParameters;
        private DataRow _GeneralParameters;

        private DataTable _tblGeneralParametersPrev;
        private DataTable _tblAuditLog;
        private DataRow _AuditLog;

        #endregion

        public frmGeneralParameters()
        {
            InitializeComponent();
        }

        private void frmGeneralParameters_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm(true);
        }

        private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            
            try
            {
                DataObj.OpenConnection();


                this._tblGeneralParameters = DataObj.GetDataTable("tblGeneralParameters");
                this._tblGeneralParametersPrev = DataObj.GetDataTable("tblGeneralParameters");
                this._tblAuditLog = DataObj.GetDataTable("tblAuditLog");
                this._tblAuditLog.Columns["LogDt"].ReadOnly = true;
                this._tblAuditLog.Columns["LogWs"].ReadOnly = true;
                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.PercOfDividToLBFTextBox,
                    this.PercOfDividToGBFTextBox,
                    this.PercOfSHSupsdToAtndEmrgMeetingTextBox,
                    this.PercOfSHSupsdToAtndRegMeetingTextBox
                    
                    
                });

                clMain.BindControls(cntrsList, this._tblGeneralParameters);
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
                if (All)
                {
                    DataObj.OpenConnection();
                    DataObj.FillData(_tblGeneralParameters, "SELECT top 1 * FROM tblGeneralParameters");
                    DataObj.FillData(_tblGeneralParametersPrev, "SELECT top 1 * FROM tblGeneralParameters");
                   
                   
                }
               
                
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                this.refreshToolStripButton_Click(this, new EventArgs());
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
                    this._GeneralParameters = this._tblGeneralParameters.Rows[0];
                    if (this._GeneralParameters == null)
                    {
                        AppMessageBox.ShowExclamation("Record could not be loaded. Please correct the data and try again");
                        return;
                    }
                    if (DataObj.Update(this._title, this._GeneralParameters, false))
                    {
                        if (InsertAuditlog(this._GeneralParameters))
                        {
                            DataObj.CommitTransaction();
                            AppMessageBox.ShowInformation("General parameter detail is updated successfully");
                        }
                        else
                        {
                            DataObj.RollbackTransaction();
                            AppMessageBox.ShowInformation("General parameter detail updating is failed");
                        }
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

        private bool InsertAuditlog(DataRow GeneralParameters)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            bool success = true;
            try
            {
                DataObj.OpenConnection();
                if (this._tblGeneralParametersPrev.Rows.Count > 0)
                {
                    this._AuditLog = this._tblAuditLog.NewRow();

                    if (this._tblGeneralParametersPrev.Rows[0]["PercOfDividToLBF"].ToString().Trim() != GeneralParameters["PercOfDividToLBF"].ToString().ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblGeneralParameters";
                        this._AuditLog["KeyFld"] = "ParamId";
                        this._AuditLog["KeyFldValue"] = this._tblGeneralParametersPrev.Rows[0]["ParamId"];
                        this._AuditLog["ActionTaken"] = "General Parameter value Changed";
                        this._AuditLog["FldChged"] = "PercOfDividToLBF";
                        this._AuditLog["OldValue"] = this._tblGeneralParametersPrev.Rows[0]["PercOfDividToLBF"];
                        this._AuditLog["NewValue"] = GeneralParameters["PercOfDividToLBF"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }
                    if (success && this._tblGeneralParametersPrev.Rows[0]["PerOfDividTGBF"].ToString().Trim() != GeneralParameters["PerOfDividTGBF"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblGeneralParameters";
                        this._AuditLog["KeyFld"] = "ParamId";
                        this._AuditLog["KeyFldValue"] = this._tblGeneralParametersPrev.Rows[0]["ParamId"];
                        this._AuditLog["ActionTaken"] = "General Parameter value Changed";
                        this._AuditLog["FldChged"] = "PerOfDividTGBF";
                        this._AuditLog["OldValue"] = this._tblGeneralParametersPrev.Rows[0]["PerOfDividTGBF"];
                        this._AuditLog["NewValue"] = GeneralParameters["PerOfDividTGBF"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }

                    if (success && this._tblGeneralParametersPrev.Rows[0]["PercOfSHSupsdToAtndEmrgMeeting"].ToString().Trim() != GeneralParameters["PercOfSHSupsdToAtndEmrgMeeting"].ToString().Trim())
                    {
                        this._AuditLog["TblName"] = "tblGeneralParameters";
                        this._AuditLog["KeyFld"] = "ParamId";
                        this._AuditLog["KeyFldValue"] = this._tblGeneralParametersPrev.Rows[0]["ParamId"];
                        this._AuditLog["ActionTaken"] = "General Parameter value Changed";
                        this._AuditLog["FldChged"] = "PercOfSHSupsdToAtndEmrgMeeting";
                        this._AuditLog["OldValue"] = this._tblGeneralParametersPrev.Rows[0]["PercOfSHSupsdToAtndEmrgMeeting"];
                        this._AuditLog["NewValue"] = GeneralParameters["PercOfSHSupsdToAtndEmrgMeeting"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
                    }

                    if (success && this._tblGeneralParametersPrev.Rows[0]["PercOfSHSupsdToAtndRegMeeting"].ToString() != GeneralParameters["PercOfSHSupsdToAtndRegMeeting"].ToString())
                    {
                        this._AuditLog["TblName"] = "tblGeneralParameters";
                        this._AuditLog["KeyFld"] = "ParamId";
                        this._AuditLog["KeyFldValue"] = this._tblGeneralParametersPrev.Rows[0]["ParamId"];
                        this._AuditLog["ActionTaken"] = "General Parameter value Changed";
                        this._AuditLog["FldChged"] = "PercOfSHSupsdToAtndRegMeeting";
                        this._AuditLog["OldValue"] = this._tblGeneralParametersPrev.Rows[0]["PercOfSHSupsdToAtndRegMeeting"];
                        this._AuditLog["NewValue"] = GeneralParameters["PercOfSHSupsdToAtndRegMeeting"];
                        this._AuditLog["UserId"] = clMain.User.UserName;
                        success = DataObj.Insert(this._title, this._AuditLog, false, false);
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
            return success;
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            InitForm(true);
        }

        private void frmCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

       

    }
}
