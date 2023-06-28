using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SHM
{
    class clYearPeriod
    {
  #region Fields
        private int _periodId;
        private int _id;
        private string _periodFullName;
        private string _fiscalYear;
        private int _calendarYear;
        private DateTime _startDate;
        private string _startDateEth;
        private DateTime _endDate;
        private string _endDateEth;
        
        
        #endregion

        #region Properties
        public int PeriodId
        {
            get { return this._periodId; }
        }
        public int Id
        {
            get { return this._id; }
        }
        public string PeriodFullName
        {
            get { return this._periodFullName; }
        }
        public string FiscalYear
        {
            get { return this._fiscalYear; }
        }
        public int CalendarYear
        {
            get { return this._calendarYear; }
        }
        public DateTime StartDate
        {
            get { return this._startDate; }
        }
        public string StartDateEth
        {
            get { return this._startDateEth; }
        }
        public DateTime EndDate
        {
            get { return this._endDate; }
        }
        public string EndDateEth
        {
            get { return this._endDateEth; }
        }
       
        
        #endregion

        #region Methods
       
        public bool IsDateInsidePeriodDate(DateTime date)
        {
            if (date >= this._startDate && date <= this._endDate)
                return true;
            else
                return false;
        }

        public bool IsDateAfterPeriodStartDate(DateTime date)
        {
            if (date >= this._startDate)
                return true;
            else
                return false;
        }

        public bool IsDateBeforePeriodEndDate(DateTime date)
        {
            if (date <= this._endDate)
                return true;
            else
                return false;
        }
       
        public clYearPeriod(int yearPeriod)
        {
            DataSet Ds;
            string cmdText;
            clDatacon DataObjMast = new clDatacon(clMain.ConnString);
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObjMast.OpenConnection();
                cmdText = "SELECT * FROM tblYearPeriod WHERE YearPeriod=" + yearPeriod;
                Ds = DataObjMast.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    this._periodId = Convert.ToInt32(Ds.Tables[0].Rows[0]["YearPeriod"]);
                    this._id = Convert.ToInt32(Ds.Tables[0].Rows[0]["Period"]);
                    this._periodFullName = GetYearPeriodName(this._periodId);
                    this._fiscalYear = Convert.ToString(Ds.Tables[0].Rows[0]["FiscalYear"]);
                    this._calendarYear = Convert.ToInt32(Ds.Tables[0].Rows[0]["CalendarYear"]);
                    this._startDate = Convert.ToDateTime(Ds.Tables[0].Rows[0]["StartDate"]);
                    this._startDateEth = Convert.ToString(Ds.Tables[0].Rows[0]["StartDateEth"]);
                    this._endDate = Convert.ToDateTime(Ds.Tables[0].Rows[0]["EndDate"]);
                    this._endDateEth = Convert.ToString(Ds.Tables[0].Rows[0]["EndDateEth"]);
                }
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblPeriods WHERE PeriodId=" + yearPeriod;
                Ds = DataObj.GetDataSet(cmdText);
                
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
            }
            finally
            {
                DataObjMast.CloseConnection();
                DataObj.CloseConnection();
            }
        }

        public static bool IsPeriodClosed(int yearPeriod)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT Posted FROM tblPeriods WHERE PeriodId=" + yearPeriod;
                result = DataObj.GetDataScalar(cmdText);
                if (result != null && !Convert.IsDBNull(result))
                    return Convert.ToBoolean(result);
                else
                    return false;
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static int GetDaysInPeriod(int yearPeriod)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "select (datediff(d,startdate,enddate)+1) As NoOfDays From tblYearPeriod WHERE YearPeriod=" + yearPeriod;
                result = DataObj.GetDataScalar(cmdText);
                if (result != null && !Convert.IsDBNull(result))
                    return Convert.ToInt32(result);
                else
                    return -1;
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return -1;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static string GetYearPeriodName(int yearPeriod)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

                cmdText = "SELECT YearPeriodName FROM viewYearPeriod WHERE YearPeriod=" + yearPeriod;
                result = DataObj.GetDataScalar(cmdText);
                if (result != null)
                    return result.ToString();
                else
                    return null;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static bool IsDateInPeriod(DateTime date, int fiscalYear, int period)
        {
            return false;
        }

        public static bool IsDateInYear(DateTime date, int fiscalYear)
        {
            return false;
        }

        /// <summary>
        /// Returns number of days left before the end of the current period 
        /// for the application. Returns -1 if any error occurs
        /// </summary>
        public static int DaysLeftForPeriodEnd(string app)
        {
            return -1;
        }

        /// <summary>
        /// Returns number of days left before the end of the current fiscal year 
        /// for the application. Returns -1 if any error occurs
        /// </summary>
        public static int DaysLeftForYearEnd(string app)
        {
            
            return -1;
        }

        public static bool DoPeriodEnd()
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            

            try
            {
                DataObj.OpenConnection();
                
                //advances the current period of the application.
                cmdText = "UPDATE tblApplications SET CurrentPeriod=CurrentPeriod+1 ";
                DataObj.Execute(cmdText);

                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static bool DoYearEnd()
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            int nextPeriodId;

            //takes backup of the application's database.

            //restores the backup with proper naming and adds it to HillDatabases table.

            try
            {
                DataObj.OpenConnection();

                //advances the current year of the application.
                nextPeriodId = ((GetCurrentYear() + 1) * 100) + 1;
                
                cmdText = "UPDATE tblApplications SET CurrentPeriod=" + nextPeriodId ;
                DataObj.Execute(cmdText);

                return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static int GetCurrentYear()
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT CalendarYear as FiscalYear FROM tblYearPeriod WHERE YearPeriod=" + GetCurrentPeriod();
                result = DataObj.GetDataScalar(cmdText);
                if (result != null)
                    return Convert.ToInt32(result);
                else
                    return -1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return -1;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static int GetCurrentPeriod()
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT CurrentPeriod FROM tblApplications ";
                result = DataObj.GetDataScalar(cmdText);
                if (result != null)
                    return Convert.ToInt32(result);
                else
                    return -1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return -1;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }
        #endregion


        

    }
}

