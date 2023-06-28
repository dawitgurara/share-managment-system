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
    public partial class frmTotalShareEnquiry : Form
    {
        private DataTable _tblTotalShareEnquiry;

        public frmTotalShareEnquiry()
        {
            InitializeComponent();
        }

        private void BindControls()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();




                this._tblTotalShareEnquiry = DataObj.GetDataTable("View_TotalShareEnquiry");
                clMain.SetDataSource(this.gctTotalShare, this._tblTotalShareEnquiry);
                

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

        private void frmTotalShareEnquiry_Load(object sender, EventArgs e)
        {
            BindControls();
            InitForm();
        }
        private void InitForm()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                DataObj.FillData(this._tblTotalShareEnquiry, "select * from View_TotalShareEnquiry  ");

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
