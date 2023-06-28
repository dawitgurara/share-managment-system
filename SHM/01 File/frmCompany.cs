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
    public partial class frmCompany : Form
    {
        #region Fields
        private string _title = "Company";
       
       
        private DataTable _tblCompany;
        private DataRow _companyRow;
        #endregion
       
        public frmCompany()
        {
            InitializeComponent();
        }

        private void frmCompany_Load(object sender, EventArgs e)
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


                this._tblCompany = DataObj.GetDataTable("tblCompany");
                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.companyNameTextBox,
                    this.shortNameTextBox,
                    this.countryTextBox,
                    this.cityTextBox,
                    this.addressLine1TextBox,
                    this.addressLine2TextBox,
                    this.addressLine3TextBox,
                    this.addressLine4TextBox,
                    this.telephone1TextBox,
                    this.telephone2TextBox,
                    this.fax1TextBox,
                    this.fax2TextBox,
                    this.pOBoxTextBox,
                    this.emailTextBox,
                    this.websiteTextBox,
                    this.vATTinDateDateTimePicker,
                    this.vATTinDateEthTextBox,
                    this.vatNumberTextBox,
                    this.tinNumberTextBox,
                    
                    
                });

                clMain.BindControls(cntrsList, this._tblCompany);
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
                    DataObj.FillData(_tblCompany, "SELECT top 1 * FROM tblCompany");
                   
                    this.currentPeriodTextBox.Text = clYearPeriod.GetYearPeriodName(clMain.App.CurrentPeriod);
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
                    this._companyRow = this._tblCompany.Rows[0];
                    if (this._companyRow == null)
                    {
                        AppMessageBox.ShowExclamation("Record could not be loaded. Please correct the data and try again");
                        return;
                    }
                    if (DataObj.Update(this._title, this._companyRow, true))
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

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //frmReportPreview RptPreviewForm = new frmReportPreview();
            //RptPreviewForm.ReportConfig = new HillReportConfig(AppMain.HillApp.ReportPath + "\\CrystalReport1.rpt",
            //                                    "tblJobPosition", AppMain.AppConnString);
            //RptPreviewForm.ReportConfig.PreviewReport("Company (Print)", false);
            //RptPreviewForm.Text = "Company (Print)";
            //AppMain.ShowControl(RptPreviewForm);
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

        private void vATTinDateDateTimePicker_Validated(object sender, EventArgs e)
        {
            this.vATTinDateEthTextBox.Text = clUtility.GetEthDate(this.vATTinDateDateTimePicker.Value);
        }

    }
}
