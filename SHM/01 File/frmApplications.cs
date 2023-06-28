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
    public partial class frmApplications : Form
    {
        #region Fields
        private string _title = "Application";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;

        
        private DataTable _tblApplications;
        private DataRow _application;

      
        private DataTable _viewYearPeriod;
        #endregion

        #region Methods
        public frmApplications()
        {
            InitializeComponent();
        }

        private void frmApplications_Load(object sender, EventArgs e)
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
               
                this._viewYearPeriod = DataObj.GetDataTable("ViewYearPeriod");
              
                clMain.SetDataSource(this.currentPeriodLookUpEdit, this._viewYearPeriod);
              

                this._tblApplications = DataObj.GetDataTable("tblApplications");
                this._tblApplications.Columns["AppId"].ReadOnly = true;
                this._tblApplications.Columns["CurrentPeriod"].ReadOnly = true;
                this._tblApplications.Columns["DateInstalled"].ReadOnly = true;
                this._tblApplications.Columns["MenuName"].ReadOnly = true;

                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.appNameTextBox,
                    this.descriptionTextBox,
                    this.currentPeriodLookUpEdit,
                    this.MaximumPeriodTextBox,
                    this.appPathButtonEdit,
                    this.dataPathButtonEdit,
                    this.reportPathButtonEdit,
                   
                });

                clMain.BindControls(cntrsList, this._tblApplications);
                cntrsList.Clear();

                //AppMain.ChangeDateLabels(this.Controls);
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
                    DataObj.FillData(this._viewYearPeriod, "SELECT * FROM viewYearPeriod ORDER BY YearPeriod");
                    DataObj.FillData(this._tblApplications, "SELECT * FROM tblApplications ");
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (this.Validate())
                {
                   
                    this._application = this._tblApplications.Rows[0];

                    DataObj.OpenConnection();
                    if (DataObj.Update(this._title, this._application, true))
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

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this.InitForm(true);
        }

        private void periodEndToolStripButton_Click(object sender, EventArgs e)
        {
            
            if (AppMessageBox.ShowQuestion("Are you sure you want to do period end for this " + this._title + "?") == DialogResult.Yes)
            {
                if (clYearPeriod.DoPeriodEnd())
                {
                    AppMessageBox.ShowInformation("Period end completed successfully!");
                    this.InitForm(false);
                }
            }
        }

       
        private void appPathButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.fbdApplications.Description = "Select application folder";
            this.fbdApplications.SelectedPath = this.appPathButtonEdit.Text;
            DialogResult diagResult = this.fbdApplications.ShowDialog();
            if (diagResult != DialogResult.Cancel)
            {
                this.appPathButtonEdit.Text = this.fbdApplications.SelectedPath;
            }
        }

        private void dataPathButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.fbdApplications.Description = "Select data folder";
            this.fbdApplications.SelectedPath = this.dataPathButtonEdit.Text;
            DialogResult diagResult = this.fbdApplications.ShowDialog();
            if (diagResult != DialogResult.Cancel)
            {
                this.dataPathButtonEdit.Text = this.fbdApplications.SelectedPath;
            }
        }

        private void reportPathButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.fbdApplications.Description = "Select reports folder";
            this.fbdApplications.SelectedPath = this.reportPathButtonEdit.Text;
            DialogResult diagResult = this.fbdApplications.ShowDialog();
            if (diagResult != DialogResult.Cancel)
            {
                this.reportPathButtonEdit.Text = this.fbdApplications.SelectedPath;
            }
        }

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.InitForm(false);
        }

     
        #endregion

    }
}