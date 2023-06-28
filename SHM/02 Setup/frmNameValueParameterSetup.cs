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
    public partial class frmNameValueParameterSetup : Form
    {
         #region Fields
        private string _title = "Name Value Parameter Setup";
        private bool _isNew = false;
        private bool _isLoadingEntry = false;
        private string _paramaterName=string.Empty;
        private DataTable _tblNameValueParameter;
        private DataTable  _tblNameValueParameterList;
        private DataRow _NameValueParamter;
               
        #endregion

        #region Properties
        public bool IsNew
        {
            get { return this._isNew; }
            set 
            { 
                this._isNew = value;
                this.deleteToolStripButton.Enabled = !this._isNew;
                this.parameterNameTextBox.ReadOnly = !this._isNew;
                this.newToolStripButton.Enabled = this._isNew;
                

            }
        }
        #endregion

        
        
        public frmNameValueParameterSetup()
        {
            InitializeComponent();
        }

        
        private void frmNameValueParameterSetup_Load(object sender, EventArgs e)
        {
            //AppMain.UpdatePerformanceLogData(this.Name, 0);
            BindControls();
            InitForm(true);
            //AppMain.UpdatePerformanceLogData(this.Name, 1);
            
        }


        private void frmNameValueParameterSetup_KeyDown(object sender, KeyEventArgs e)
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
               
                this._tblNameValueParameterList = DataObj.GetDataTable("tblNameValueParameter");
                this._tblNameValueParameter = DataObj.GetDataTable("tblNameValueParameter");
                this._tblNameValueParameter.Columns["CrtDt"].ReadOnly = true;
                this._tblNameValueParameter.Columns["CrtWs"].ReadOnly = true;
                
                List<Control> cntrsList = new List<Control>();
                cntrsList.AddRange(new Control[]{
                    this.parameterNameTextBox,
                    this.parameterDescriptionTextBox,
                    this.parameterValueTextBox 
                });
                clMain.BindControls(cntrsList, this._tblNameValueParameter  );
                cntrsList.Clear();
                clMain.SetDataSource(this.gctNameValueParameter , this._tblNameValueParameterList );
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
                    DataObj.FillData(_tblNameValueParameterList, "Select * from tblNameValueParameter");
                    

                }
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObj.CloseConnection();
                this.refreshToolStripButton_Click(this, new EventArgs());
            }
        }
   
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (this.Validate())
                {                        
                    this._NameValueParamter  = this._tblNameValueParameter.Rows[0];
                        
                    DataObj.OpenConnection();
                    if (this._isNew)
                    {
                        if (DataObj.Insert(this._title, this._NameValueParamter , true, false))
                        {
                            InitForm(false);
                        }
                    }
                    else
                    {
                        if (DataObj.Update(this._title, this._NameValueParamter , true, false))
                        {
                            InitForm(false);
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

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                if (this._paramaterName  ==  string.Empty  || this._paramaterName==null )
                {
                    AppMessageBox.ShowExclamation("Please select " + this._title + " to delete");
                    return;
                }

                if (AppMessageBox.ShowQuestion("Are you sure you want to delete " + this._title + "?") == DialogResult.No)
                    return;

                this._NameValueParamter  = this._tblNameValueParameter.Rows[0];

                DataObj.OpenConnection();
                if (DataObj.Delete(this._title, this._NameValueParamter , true))
                {
                    InitForm(false);
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

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._paramaterName = string.Empty;
            this.IsNew = true;
            this.GetParamterTransactions();
            this._tblNameValueParameter.Rows.Clear();
            
            
        }

        private void GetNewEntry()
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                this.IsNew = true;
                this._NameValueParamter  = this._tblNameValueParameter.NewRow();
                clDatacon.SetToDatabaseDefaults(this._NameValueParamter , clMain.ConnString);
                if (this._paramaterName  != string.Empty ) this._NameValueParamter ["parametername"] = this._paramaterName ;
                this._NameValueParamter["CrtBy"] = clMain.User.UserName;
                this._tblNameValueParameter.Rows.Clear();
                this._tblNameValueParameter.Rows.Add(this._NameValueParamter);
                this._isLoadingEntry = false;
            }
        }

        private bool GetTransactionEntry(string parametername)
        {
            if (!this._isLoadingEntry)
            {
                this._isLoadingEntry = true;
                clDatacon DataObj = new clDatacon(clMain.ConnString);

                if (!IsParamterTransactionExist(parametername))
                {
                    this._isLoadingEntry = false;
                    this.GetNewEntry();
                    return true;
                }
                try
                {
                    this.IsNew = false;
                    DataObj.OpenConnection();
                    DataObj.FillData(this._tblNameValueParameter, "SELECT * FROM tblNameValueParameter WHERE ParameterName='" + parametername + "'");
                    return true;
                }
                catch (Exception Ex)
                {
                    AppMessageBox.ShowExclamation(Ex.Message);
                    return false;
                }
                finally
                {
                    DataObj.CloseConnection();
                    this._isLoadingEntry = false;
                }
            }
            else
                return false;
        }

        private bool  IsParamterTransactionExist(string parametername)
        {
            if (parametername == string.Empty) return false;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            object result;
            try
            {
                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("select parametername from tblNameValueParameter where parametername='" + parametername + "'");
                if (result == null || Convert.IsDBNull(result))
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                AppMessageBox.ShowError("Error on retriving data from database: \n" + ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }

        }

        private void GetParamterTransactions()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                DataObj.FillData(this._tblNameValueParameterList, "SELECT * FROM tblNameValueParameter order by ParameterName");
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

        private void gridNameValueParameter_DoubleClick(object sender, EventArgs e)
        {
            int focused = this.gridNameValueParameter.FocusedRowHandle;
            if (focused >= 0)
            {
                DataRow curRow = this.gridNameValueParameter.GetDataRow(focused);
                this._paramaterName  = Convert.ToString (curRow["ParameterName"]);
                this.GetTransactionEntry(_paramaterName);
                this.gridNameValueParameter.FocusedRowHandle = focused;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            GetNewEntry();
            this.newToolStripButton.Enabled = false;
            this.parameterNameTextBox.Focus();
        }

        private void parameterNameTextBox_Validated(object sender, EventArgs e)
        {
            if (parameterNameTextBox.Text!=string.Empty)
            {
                _paramaterName = parameterNameTextBox.Text;
                this.GetTransactionEntry(_paramaterName);
            }
        }

       

        


    }
}
