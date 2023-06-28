using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;
using System.Configuration;


namespace SHM
{
   public class clMain
    {
        public static readonly string AppName = "SHM";
        public static readonly string AppDesc = "Share Holders Managment System";

        public static bool FinishedLoadFile;
        public static int gMaxDelayInMinuteForMarqueProgress;
        public static bool gLogAppPerformance = false;
        public static SqlConnection gAppPrfLogSqlCnn = new SqlConnection();

        //private static string CompanyName;
        private static string _connString;
        //private static string userName;
        private static int currentFiscalYear;
        //private static int currentPeriod;
        internal static clUser _user;
        
        
        private static clYearPeriod _currentPeriod;
        private static clCompany _company;
        private static clApplication _App;
        private static string currentPeriodName;
        //private static DevExpress.XtraGrid.GridControl _appReminder;
        private static Timer _appMainTimer = new Timer();


        internal static string ConnString
        {
            get { return _connString; }
            set { _connString = value; }
        }

        internal static clUser User
        {
            get { return _user; }
        }

        internal static clApplication App
        {
            get { return _App; }
            set { _App = value; }
        }

        //internal static string UserName
        //{
        //    get { return userName; }
        //    set { userName = value; }
        //}

        internal static clCompany Company
        {
            get { return _company; }
        }

        internal static int CurrentFiscalYear
        {
            get { return currentFiscalYear; }
            set { currentFiscalYear = value; }
        }

        internal static clYearPeriod CurrentPeriod
        {
            get { return _currentPeriod; }
            set { _currentPeriod = value; }
        }

        internal static string CurrentPeriodName
        {
            get { return currentPeriodName; }
            set { currentPeriodName = value; }
        }

        internal static void StartConfig(int userId)
        {
            // _connString = "Data Source =192.168.1.39;Initial Catalog=ELiGSHMData;User ID=sa;Password=sapass"; 
            _connString = Properties.Settings.Default.iCMCSHMDataConnectionString;//"Data Source =DESKTOP-4REBEOG;Initial Catalog=ELiGSHMData20201024;User ID=sa;Password=pass123*";
            _company = new clCompany();
            _user = new clUser(userId, AppName);
            _App = new clApplication();
            int curPeriod = clYearPeriod.GetCurrentPeriod();
            _currentPeriod = new clYearPeriod(curPeriod);
        }

        internal static void SetGridProperties(DevExpress.XtraGrid.GridControl gridControl, string tableName)
        {
            string cmdText;
            System.Data.DataTable tableCols;
            clDatacon dataObj = new clDatacon(_connString);
            try
            {
                dataObj.OpenConnection();
                cmdText = "SELECT sysobjects.name AS TableName, syscolumns.name AS FieldName, sysproperties.[value]" +
                     " FROM sysobjects INNER JOIN syscolumns ON sysobjects.id = syscolumns.id INNER JOIN " +
                     " sysproperties ON syscolumns.id = sysproperties.id AND syscolumns.colid = sysproperties.smallid " +
                    " where sysobjects.name='" + tableName + "'";

                tableCols = dataObj.GetDataSet(cmdText).Tables[0];

                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl.Views[0];
                foreach (System.Data.DataRow row in tableCols.Rows)
                {
                    gridView.Columns[row[1].ToString()].Caption = row[2].ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                dataObj.CloseConnection();
            }
        }

        internal static void SetDataSource(Control control, System.Data.DataTable table)
        {
            if (control.GetType() == typeof(System.Windows.Forms.ComboBox))
            {
                ((System.Windows.Forms.ComboBox)control).DataSource = table;
            }
            else if (control.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit))
            {
                ((DevExpress.XtraEditors.LookUpEdit)control).Properties.DataSource = table;
            }
            else if (control.GetType() == typeof(DevExpress.XtraGrid.GridControl))
            {
                DevExpress.XtraGrid.GridControl gridCntrl = (DevExpress.XtraGrid.GridControl)control;
                gridCntrl.DataSource = table;
                //SetGridProperties(gridCntrl, table.TableName);
            }
            else
            {
                MessageBox.Show("Unknown control type '" + control.GetType().FullName + "'", "", MessageBoxButtons.OK);
                
            }
        }

        internal static void SetRepositoryDataSource(DevExpress.XtraEditors.Repository.RepositoryItem control, System.Data.DataTable table)
        {
            if (control.GetType() == typeof(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit))
            {
                ((DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)control).DataSource = table;
            }
            else
            {
                MessageBox.Show("Unknown repository control type'" + control.GetType().FullName + "'", "", MessageBoxButtons.OK);
               
            }
        }

        internal static void BindControls(List<Control> controls, System.Data.DataTable table)
        {
            BindControls(controls, table, false, true);
        }

        internal static void BindControls(List<Control> controls, System.Data.DataTable table, bool setDefaultDate)
        {
            BindControls(controls, table, setDefaultDate, true);
        }

        internal static void BindControls(List<Control> controls, System.Data.DataTable table, bool setDefaultDate, bool switchCalendar)
        {
            string columnName;
            string[] splitStr;

            //bool searchOther = false;
            foreach (Control control in controls)
            {
                splitStr = control.Name.Split(new string[] { control.GetType().Name }, StringSplitOptions.RemoveEmptyEntries);
                columnName = splitStr[0];


                if (!table.Columns.Contains(columnName))
                {
                    MessageBox.Show("Control '" + control.Name + "' could not be bound to column '" + columnName + "'", "", MessageBoxButtons.OK);

                    continue;
                }

                if (control.GetType() == typeof(System.Windows.Forms.TextBox))
                {

                    control.DataBindings.Add("Text", table, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    //searchOther = false;
                }
                else if (control.GetType() == typeof(System.Windows.Forms.RichTextBox))
                {
                    control.DataBindings.Add("Text", table, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    //searchOther = false;
                }

                else if (control.GetType() == typeof(System.Windows.Forms.DateTimePicker))
                {
                    control.DataBindings.Add("Value", table, columnName, true);
                    //searchOther = false;

                }
                else if (control.GetType() == typeof(System.Windows.Forms.CheckBox))
                {
                    control.DataBindings.Add("Checked", table, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    //searchOther = false;
                }
                else if (control.GetType() == typeof(System.Windows.Forms.RadioButton))
                {
                    control.DataBindings.Add("Checked", table, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    //searchOther = false;
                }
                else if (control.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    control.DataBindings.Add("SelectedValue", table, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    //searchOther = false;
                }
                else if (control.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit))
                {
                    control.DataBindings.Add("EditValue", table, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    //searchOther = false;
                }
                else if (control.GetType() == typeof(DevExpress.XtraEditors.SpinEdit))
                {
                    control.DataBindings.Add("EditValue", table, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    //searchOther = false;
                }
                else if (control.GetType() == typeof(DevExpress.XtraEditors.SpinEdit))
                {
                    control.DataBindings.Add("EditValue", table, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    //searchOther = false;
                }
                else
                {
                    // MessageBox.Show("Unknown control type '" + control.GetType().FullName + "'", "", MessageBoxButtons.OK);
                    //AppMessageBox.ShowExclamation("Unknown control type '" + control.GetType().FullName + "'");
                    //searchOther = false;
                    control.DataBindings.Add("Text", table, columnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    //searchOther = false;
                }
            }
        }

        internal static void SetDefaultDate(Form frm)
        {

            


            foreach (Control control in frm.Controls)
            {
                if (control.GetType() == typeof(System.Windows.Forms.DateTimePicker))
                {



                    DateTimePicker calander = (DateTimePicker)control;
                    calander.Value = clUtility.GetCurrentDate();
                    break;
                }          

            }
        }
        
        public static void SetSearchBy(DevExpress.XtraEditors.LookUpEdit lookUpEdit, System.Windows.Forms.ToolStripComboBox comboBox)
        {
            DataTable table = (DataTable)lookUpEdit.Properties.DataSource;
            comboBox.Items.Clear();
            foreach (DataColumn col in table.Columns)
            {
                comboBox.Items.Add(col.ColumnName);
            }
        }
        
        internal static void ShowControl(Control control)
        {
            Form RptForm = (Form)control;
            RptForm.MdiParent = new frmMDI();
            RptForm.WindowState = FormWindowState.Maximized;
            RptForm.AutoScroll = true;
            RptForm.Show();


        }

        public static void ChangeControl(ref Control periodControl, ControlType changeTo)
        {
            ChangeControl(ref periodControl, changeTo, null, null, null);
        }

        public static void ChangeControl(ref Control control, ControlType changeTo, DataTable dataSource, string displayMember, string valueMember)
        {
            string columnName;
            string[] splitStr;

            Control copyOfControl = control;
            Control parentControl = control.Parent;
            DataTable boundTable = (DataTable)control.DataBindings[0].DataSource;

            splitStr = control.Name.Split(new string[] { control.GetType().Name }, StringSplitOptions.RemoveEmptyEntries);
            columnName = splitStr[0];
            control.Parent = null;

            if (changeTo == ControlType.TextBox)
            {
                control = new TextBox();
                ((TextBox)control).BorderStyle = BorderStyle.FixedSingle;
                
            }
            else if (changeTo == ControlType.DateTimePicker)
            {
                control = new DateTimePicker();
                ((DateTimePicker)control).Format = DateTimePickerFormat.Short;
            }
            else if (changeTo == ControlType.LookUpEdit)
            {
                control = new LookUpEdit();
                ((LookUpEdit)control).Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                ((LookUpEdit)control).Properties.NullText = string.Empty;
                ((LookUpEdit)control).Properties.DisplayMember = displayMember;
                ((LookUpEdit)control).Properties.ValueMember = valueMember;
                ((LookUpEdit)control).Properties.ShowHeader = false;
                ((LookUpEdit)control).Properties.ShowFooter = false;
                ((LookUpEdit)control).Properties.DataSource = dataSource;
            }

            control.Location = copyOfControl.Location;
            control.Name = columnName + changeTo.ToString();
            control.Size = copyOfControl.Size;
            control.TabIndex = copyOfControl.TabIndex;
            control.TabStop = copyOfControl.TabStop;

            control.Parent = parentControl;

            List<Control> cntrlList = new List<Control>();
            cntrlList.Add(control);
            clMain.BindControls(cntrlList, boundTable, false, false);
        }

        internal static void setMarqueeVisible(int maxDelayInMinute)
        {
            FinishedLoadFile = true;
            Control.CheckForIllegalCrossThreadCalls = false;
            if (maxDelayInMinute == 0) maxDelayInMinute = 2;
            gMaxDelayInMinuteForMarqueProgress = maxDelayInMinute;
            FinishedLoadFile = false;
            System.Threading.Thread Mtrd = new System.Threading.Thread(new System.Threading.ThreadStart(clMain.ShowMarquee));
            Mtrd.Start();

        }

        internal static void ShowMarquee()
        {
            frmMarqueeProgress frmObj = new frmMarqueeProgress();
            frmObj.DescriptionLabel = "Loading Report Data Please wait...";
            frmObj.ShowDialog();
        }

        public static void UpdatePerformanceLogData(string frmName, int actionTypeId)
        {
            if (!gLogAppPerformance) return;
            string cmdText = "Insert into mAppProformanceLog(AppShortName,FrmName,ActionType,ActionTakenBy) values(" +
                          " '" + clMain.AppName + "','" + frmName + "'," + actionTypeId + ",'" + clMain.User.UserName + "')";
            SqlCommand cmd = new SqlCommand(cmdText, gAppPrfLogSqlCnn);
            cmd.ExecuteNonQuery();
        }

       

       
      
       
       



    }

    public enum ControlType
    {
        TextBox = 1,
        DateTimePicker = 2,
        LookUpEdit = 3
    }
}
