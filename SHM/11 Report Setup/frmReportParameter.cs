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
    public partial class frmReportParameter : Form
    {
        int _parameterCount = 0;
        int _topHeight = 60;
        int _height = 35;
        int _xCordControl = 150;
        int _xCordLabel = 35;
        int _labelIndentHeight = 3;
        int _controlWidth = 100;
        int _controlHeight = 20;
        clReport _report;
        private Form _mdiForm;
        object[,] _tableWithQuery;

        public frmReportParameter(int reportId, Form mdiForm)
        {
            InitializeComponent();
            _mdiForm = mdiForm;
            this._report = new clReport(reportId, clMain.ConnString);

            //Create an object collectionto contain
            //[TableName],[LookUpEdit 2B Filled],[LookUpName Associated with fill event],[Query 2 fill table]
            this._tableWithQuery = new object[this._report.ReportParameters.Count, 4];


            if (this._report.ReportParameters == null)
            {
                this.printToolStripButton_Click(null, null);
            }
            else
            {
                for (int i = 0; i < this._report.ReportParameters.Count; i++)
                {
                    this._parameterCount = i;

                    //initialize every element
                    this._tableWithQuery[i, 0] = null;
                    this._tableWithQuery[i, 1] = null;
                    this._tableWithQuery[i, 2] = null;
                    this._tableWithQuery[i, 3] = null;

                    if (this._report.ReportParameters[i].ControlType != "System.Windows.Forms.CheckBox")
                    {
                        this.AutoCreateLable(this._report.ReportParameters[i].Description + ":");
                    }
                    switch (this._report.ReportParameters[i].ControlType)
                    {
                        case "System.Windows.Forms.TextBox":
                            this.AutoCreateTextBox();
                            break;
                        case "System.Windows.Forms.DateTimePicker":
                            this.AutoCreateDateTimePicker();
                            break;
                        case "DevExpress.XtraEditors.LookUpEdit":
                            this.AutoCreateLookUpEdit();
                            break;
                        case "System.Windows.Forms.CheckBox":
                            this.AutoCreateCheckBox(this._report.ReportParameters[i].Description);
                            break;
                        default:
                            AppMessageBox.ShowExclamation("Unkown control type: " + this._report.ReportParameters[i].ControlType);
                            break;
                    }
                }
            }
        }

        private void frmReportSelection_Load(object sender, EventArgs e)
        {
            if (this._report.ReportParameters.Count == 0)
            {
                this.printToolStripButton_Click(null, null);
            }
        }

        private void frmReportParameter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void AutoCreateLable(string caption)
        {
            Label paramLable = new Label();
            paramLable.AutoSize = true;
            paramLable.Location = new System.Drawing.Point(this._xCordLabel, ((this._topHeight + this._labelIndentHeight) + (this._parameterCount * this._height)));
            paramLable.Name = "paramLable" + this._parameterCount.ToString();
            paramLable.Size = new System.Drawing.Size(35, 13);
            paramLable.Text = caption;
            this.Controls.Add(paramLable);
        }

        private void AutoCreateCheckBox(string LabelText)
        {
            clReportParameter repParam = this._report.ReportParameters[this._parameterCount];
            System.Windows.Forms.CheckBox paramCheckBox = new System.Windows.Forms.CheckBox();
            paramCheckBox.Text = LabelText;
            paramCheckBox.ThreeState = false;
            paramCheckBox.Location = new Point(this._xCordControl, (this._topHeight + (this._parameterCount * this._height)));
            paramCheckBox.Name = "paramCheckBox" + this._parameterCount.ToString();
            paramCheckBox.TabIndex = this._parameterCount;
            this._report.ReportParameters[this._parameterCount].Control = paramCheckBox;
            this.Controls.Add(paramCheckBox);
        }

        private void AutoCreateTextBox()
        {
            clReportParameter repParam = this._report.ReportParameters[this._parameterCount];
            System.Windows.Forms.TextBox paramTextBox = new TextBox();
           
            paramTextBox.Location = new Point(this._xCordControl, (this._topHeight + (this._parameterCount * this._height)));
            paramTextBox.Name = "paramTextBox" + this._parameterCount.ToString();
            paramTextBox.Size = new Size((2 * this._controlWidth), this._controlHeight);
            paramTextBox.BorderStyle = BorderStyle.FixedSingle;
            paramTextBox.TabIndex = this._parameterCount;
            
            this._report.ReportParameters[this._parameterCount].Control = paramTextBox;
            this.Controls.Add(paramTextBox);
        }

        private void AutoCreateDateTimePicker()
        {
            clReportParameter repParam = this._report.ReportParameters[this._parameterCount];
            System.Windows.Forms.DateTimePicker paramCalendar = new DateTimePicker();
            paramCalendar.Location = new Point(this._xCordControl, (this._topHeight + (this._parameterCount * this._height)));
            paramCalendar.Name = "paramDateTimePicker" + this._parameterCount.ToString();
            paramCalendar.Size = new Size(100, this._controlHeight);
            paramCalendar.TabIndex = this._parameterCount;
           
            this._report.ReportParameters[this._parameterCount].Control = paramCalendar;
            this.Controls.Add(paramCalendar);
        }

        private void AutoCreateLookUpEdit()
        {
            clReportParameter repParam = this._report.ReportParameters[this._parameterCount];
            string fieldName, width, caption;
            int j;
            DevExpress.XtraEditors.LookUpEdit paramLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            paramLookUpEdit.Location = new Point(this._xCordControl, (this._topHeight + (this._parameterCount * this._height)));
            paramLookUpEdit.Name = "paramLookUpEdit" + this._parameterCount.ToString();
            paramLookUpEdit.Size = new Size((3 * this._controlWidth), this._controlHeight);
            paramLookUpEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            paramLookUpEdit.TabIndex = this._parameterCount;
            paramLookUpEdit.Properties.NullText = string.Empty;
            paramLookUpEdit.Properties.DisplayMember = repParam.DisplayMember;
            paramLookUpEdit.Properties.ValueMember = repParam.ValueMember;
            string[] values = repParam.ListFields.Split(new char[] { clReportParameter.ListFieldSeparator });
            for (int i = 0; i < values.Length; i = i + 3)
            {
                j = i;
                fieldName = values[j];
                width = values[j + 1];
                if (width == null || width == string.Empty)
                    width = "20";
                caption = values[j + 2];
                paramLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(fieldName, Convert.ToInt32(width), caption));
            }

            DataTable paramTable = new DataTable();
            clDatacon dataObj = new clDatacon(this._report.ConnString);
            if (repParam.DataSource.Contains("paramLookUpEdit"))
            {
                string controlName = "", cmdText = "";
                if (repParam.DataSource.Contains("."))
                {
                    controlName = (repParam.DataSource.Substring(repParam.DataSource.IndexOf("paramLookUpEdit"))).Split(new char[] { '.' })[0];
                }

                ((DevExpress.XtraEditors.LookUpEdit)this.Controls[controlName]).EditValueChanged += this.LookUpEdit_EditValueChanged;

                cmdText = repParam.DataSource.Replace("`", "'");

                //cmdText = cmdText.Remove(repParam.DataSource.IndexOf("paramLookUpEdit"), controlName.Length + 10);

                //fill object values into
                //[TableName],[LookUpEdit 2B Filled],[LookUpName Invoking the Fill Method],[Query 2 fill table]

                DataTable tbl = new DataTable(paramLookUpEdit.Name);
                this._tableWithQuery[this._parameterCount, 0] = tbl;
                this._tableWithQuery[this._parameterCount, 1] = paramLookUpEdit;
                this._tableWithQuery[this._parameterCount, 2] = controlName;
                this._tableWithQuery[this._parameterCount, 3] = cmdText;
            }
            else
            {
                dataObj.FillData(paramTable, repParam.DataSource.Replace("`", "'"));
            }
            paramLookUpEdit.Properties.DataSource = paramTable;

            this._report.ReportParameters[this._parameterCount].Control = paramLookUpEdit;
            this.Controls.Add(paramLookUpEdit);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //clMain.setMarqueeVisible(0);
               
                this.tspReportParameter.Enabled = false;
                this.Focus();
                bool isProcedure;
                if (!this._report.GetParameterValues(true))
                {
                    this.tspReportParameter.Enabled = true;
                    return;
                }

                isProcedure = (this._report.DataObjType == "P");

                frmReportPreview RptPreviewForm = new frmReportPreview();
                string path = clMain.App.ReportPath + "\\" + this._report.ReportFileName;
               // string path = @"D:\Personal\ICMC\SHM Last Update\SHM Last Update\SHM\SHM\06 Report" + "\\" + this._report.ReportFileName;
              RptPreviewForm.ReportConfig = new clReportConfig(clMain.App.ReportPath + "\\" + this._report.ReportFileName, this._report.DataObjName, isProcedure);
                //RptPreviewForm.ReportConfig = new clReportConfig(@"D:\ELiG\ELiG\ELiG App\ELiGSHMProj\SHM\SHM\06 Report"   + "\\" + this._report.ReportFileName, this._report.DataObjName, isProcedure);
                if (isProcedure)
                {
                    foreach (clReportParameter repParam in this._report.ReportParameters)
                    {
                        if (repParam.DataType == "datetime")
                            RptPreviewForm.ReportConfig.DataParameters.Add(new System.Data.SqlClient.SqlParameter(repParam.FieldName, clUtility.ToMDYDate(Convert.ToDateTime(repParam.Value))));
                        else
                            RptPreviewForm.ReportConfig.DataParameters.Add(new System.Data.SqlClient.SqlParameter(repParam.FieldName, repParam.Value));
                    }
                }
                else
                {
                    RptPreviewForm.ReportConfig.Criteria = (this._report.CriteriaWithValues.Replace("LoginUser", "'" + clMain.User.UserName + "'"));
                    RptPreviewForm.ReportConfig.Criteria = (RptPreviewForm.ReportConfig.Criteria.Replace("`", "'"));
                }
                foreach (CrystalDecisions.CrystalReports.Engine.FormulaFieldDefinition definition in RptPreviewForm.ReportConfig.ReportDoc.DataDefinition.FormulaFields)
                {
                    if (definition.Name == "CompName")
                    {
                        RptPreviewForm.ReportConfig.ReportDoc.DataDefinition.FormulaFields["CompName"].Text = clUtility.Qchar(clMain.Company.Name);
                    }
                    if (definition.Name == "RepName")
                    {
                        RptPreviewForm.ReportConfig.ReportDoc.DataDefinition.FormulaFields["RepName"].Text = clUtility.Qchar(this._report.RepName);
                    }
                    if (definition.Name == "RepNameAmharic")
                    {
                        RptPreviewForm.ReportConfig.ReportDoc.DataDefinition.FormulaFields["RepNameAmharic"].Text = clUtility.Qchar(this._report.RepNameAmharic);
                    }
                    if (definition.Name == "CritStr")
                    {
                        RptPreviewForm.ReportConfig.ReportDoc.DataDefinition.FormulaFields["CritStr"].Text = clUtility.Qchar(this._report.ReportHeadWithValues);
                    }
                    if (definition.Name == "UserName")
                    {
                        RptPreviewForm.ReportConfig.ReportDoc.DataDefinition.FormulaFields["UserName"].Text = clUtility.Qchar(clMain.User.UserName);
                    }
                    
                   

                }


                if (this._report.SubReports != null)
                {
                    for (int i = 0; i < this._report.SubReports.Count; i++)
                    {
                        RptPreviewForm.ReportConfig.SubConfigs.Add(new clSubReportConfig(this._report.SubReports[i].SubRepId, this._report.SubReports[i].DataObjName));
                        RptPreviewForm.ReportConfig.SubConfigs[i].Criteria = this._report.SubReports[i].Criteria;//CriteriaWithValues;
                        if (RptPreviewForm.ReportConfig.SubConfigs[i].Criteria != "")
                        {
                            foreach (clReportParameter repParam in this._report.ReportParameters)
                            {
                               RptPreviewForm.ReportConfig.SubConfigs[i].Criteria = RptPreviewForm.ReportConfig.SubConfigs[i].Criteria.Replace(repParam.Control.Name + ".EditValue", repParam.Value.ToString());
                            }
                        }
                    }
                }
                RptPreviewForm.ReportConfig.PreviewReport(this._report.RepName, true);

                RptPreviewForm.Text = this._report.RepName;
                RptPreviewForm.WindowState = FormWindowState.Maximized;
                RptPreviewForm.MdiParent = _mdiForm;
                RptPreviewForm.Show();
                RptPreviewForm.BringToFront();
                
                //clMain.FinishedLoadFile = true;
                this.Close();

               
            }
            catch (Exception Ex)
            {
               // clMain.FinishedLoadFile = true;
                AppMessageBox.ShowExclamation(Ex.Message);
                this.Close();
                return;
            }
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            this._report.RefreshParameterValues();
        }

        private void LookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            clDatacon dataObj = new clDatacon(this._report.ConnString);
            for (int i = 0; i < this._report.ReportParameters.Count; i++)
            {
                if (this._tableWithQuery[i, 0] != null)
                {
                    if (Convert.ToString(this._tableWithQuery[i, 2]) == ((DevExpress.XtraEditors.LookUpEdit)sender).Name)
                    {
                        string criteria = Convert.ToString(((DevExpress.XtraEditors.LookUpEdit)this.Controls[Convert.ToString(this._tableWithQuery[i, 2])]).EditValue);
                        DataTable tblTemp = ((DataTable)this._tableWithQuery[i, 0]);
                        //dataObj.FillData(tblTemp, Convert.ToString(this._tableWithQuery[i, 3])+" "+criteria);
                        dataObj.FillData(tblTemp, Convert.ToString(this._tableWithQuery[i, 3]).Replace((this._tableWithQuery[i, 2].ToString() + ".EditValue"), criteria));
                        if (this.Controls.Contains((Control)this._tableWithQuery[i, 1]))
                        {
                            ((DevExpress.XtraEditors.LookUpEdit)this.Controls[((DevExpress.XtraEditors.LookUpEdit)this._tableWithQuery[i, 1]).Name]).Properties.DataSource = tblTemp;
                        }
                    }
                }
            }
        }

    }
}
