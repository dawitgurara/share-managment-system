using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace SHM
{
    class clUtility
    {
        public static bool ValidateDateRange(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
                return false;
            else
                return true;
        }

        public static decimal GetDurationInDays(DateTime ToDate, DateTime FromDate)
        {
            decimal NoofYr;
            TimeSpan tsp;
            tsp = ToDate.Subtract(FromDate);
            NoofYr = Convert.ToDecimal(tsp.TotalDays) + 1;
            return NoofYr;
        }

        public static decimal GetDurationInMonths(DateTime FromDate,DateTime ToDate)
        {
            object Result;
            string cmdText="";
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "select DATEDIFF(month,Convert(datetime,'" + FromDate + "',103),Convert(datetime,'" + ToDate + "',103))+ 1";
                Result=DataObj.GetDataScalar(cmdText);


            return Convert.ToDecimal(Result);

            //cmdText = "select DATEDIFF(day,Convert(datetime,'" + FromDate + "',103),Convert(datetime,'" + ToDate + "',103)-1)";

            //Result = DataObj.GetDataScalar(cmdText);

            //Result = Convert.ToDecimal(Result) / Convert.ToDecimal(30);
            }
            catch(Exception Ex)
            {
              AppMessageBox.ShowError(Ex.Message);
                return 0;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static string GetEthiopicDate(DateTime gregorianDate)
        {
            string result = null;
            clEthiopianCalendar Cal = new clEthiopianCalendar();
            result = Cal.ConvertgregorianToEthiopic(gregorianDate.Year, gregorianDate.Month, gregorianDate.Day);
            return result;
        }

        public static string GetEthDate(DateTime grgDate)
        {
            try
            {
                if (grgDate == null)
                    return string.Empty;
                clEthiopianCalendar cal = new clEthiopianCalendar();
                return cal.ConvertgregorianToEthiopic(grgDate.Year, grgDate.Month, grgDate.Day);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
        }

        public static DateTime GetGrgDate(string ethDate)
        {
            try
            {
                if (ethDate == null || ethDate == string.Empty)
                    return DateTime.MinValue;
                clEthiopianCalendar cal = new clEthiopianCalendar();
                string[] splitStr = ethDate.Split(new string[] { "/" }, StringSplitOptions.None);
                string result = cal.ConvertethiopicToGregorian(Convert.ToInt32(splitStr[2]), Convert.ToInt32(splitStr[1]), Convert.ToInt32(splitStr[0]));
                return Convert.ToDateTime(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return DateTime.MinValue;
            }
        }

        public static DateTime GetDateDifferenceInDateTime(DateTime dateFrom, DateTime dateTo)
        {

            try
            {
                TimeSpan ageDtFrmTs = dateFrom - new DateTime(1, 1, 1);
                DateTime DiffDate = dateTo.Subtract(ageDtFrmTs);
                //DiffDate = DiffDate.AddYears(-1);
                //DiffDate = DiffDate.AddMonths(-1);
                DiffDate = DiffDate.AddDays(-1);
                return DiffDate;
            }
            catch (Exception ex)
            {
                AppMessageBox.ShowError(ex.Message);
                return new DateTime(1901, 01, 01);
            }

        }

        public static string ToMDYDate(DateTime date)
        {
            return date.ToString("M/d/yyyy");
        }

        public static string ToDMYDate(DateTime date)
        {
            return date.ToString("d/M/yyyy");
        }

        public static DateTime GetCurrentDate()
        {
            object result;
            string cmdText;
            clDatacon Conn = new clDatacon(clMain.ConnString);
            try
            {
                Conn.OpenConnection();
                cmdText = "SELECT getdate()";
                result = Conn.GetDataScalar(cmdText);
                if (result != null)
                    return Convert.ToDateTime(result);
                else
                    return new DateTime(1900, 1, 1);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return new DateTime(1900, 1, 1);
            }
            finally
            {
                Conn.CloseConnection();
            }
        }

        public static string MakeStringValdForSql(string strValue)
        {
            return strValue.Replace("'", "`");
        }

        public static string MakeStringValdForSql(object strValue)
        {
            return Convert.ToString(strValue).Replace("'", "`");
        }

        public static string Qchar(string str)
        {
            return "'" + str.Replace("'", "`").Trim() + "'";
        }

        public static string UnQchar(string str)
        {
            return str.Replace("'", "");
        }

        public static bool GenericIDNoExist(string paramKey)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);

            try
            {
                DataObj.OpenConnection();
                cmdText = "select ParameterValue from tblNameValueParameter where ParameterName='" + paramKey + "'";

                result = DataObj.GetDataScalar(cmdText);
                if (result != null && !Convert.IsDBNull(result))
                {

                    return true;
                }
                else
                {
                    return false;
                }
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

        public static string GetNextNumber(string nextNumberParam, string prefixParam)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            string prefix = null, nextNumber = null, result;
            try
            {
                DataObj.OpenConnection();
                prefix = Convert.ToString(DataObj.GetDataScalar("SELECT  ParameterValue FROM tblNameValueParameter WHERE ParameterName='" + prefixParam + "'"));
                nextNumber = Convert.ToString(DataObj.GetDataScalar("SELECT ParameterValue FROM tblNameValueParameter WHERE ParameterName='" + nextNumberParam + "'"));
                result = prefix + "_" + nextNumber;

                return result;
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowError(Ex.Message);
                return null;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static decimal GetParameterValueByKeyField(string parametername, decimal returnType)
        {
            object result;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("select ParameterValue from tblNameValueParameter where ParameterName='" + parametername + "'");
                if (result == null || Convert.IsDBNull(result))
                    return 0;
                else
                    return Convert.ToDecimal(result);

            }
            catch (Exception ex)
            {
                AppMessageBox.ShowError("Unable to get parameter value for key field " + parametername + ": \n" + ex.Message);
                return 0;
            }

            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static string GetParameterValueByKeyField(string parametername, string returnType)
        {
            object result;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("select ParameterValue from tblNameValueParameter where ParameterName='" + parametername + "'");
                if (result == null || Convert.IsDBNull(result))
                    return string.Empty;
                else
                    return Convert.ToString(result);

            }
            catch (Exception ex)
            {
                AppMessageBox.ShowError("Unable to get parameter value for key field " + parametername + ": \n" + ex.Message);
                return string.Empty;
            }

            finally
            {
                DataObj.CloseConnection();
            }
        }
       
        public static decimal GetTotal(decimal[] numericArray)
        {
            decimal result = new decimal();
            for (int j = 0; j < numericArray.Length; j++)
            {
                result += numericArray[j];
            }
            return result;
        }

        public static bool TextContainsNumber(string text)
        {
            for (int i = 0; i < 10; i++)
            {
                if (text.Contains(i.ToString()))
                    return true;
            }
            return false;
        }

        public static void UpdateParameterNextValue(string parametername)
        {
            object result;
            int prevValue;
            int nextValue;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("select ParameterValue from tblNameValueParameter where ParameterName='" + parametername + "'");
                if (result == null || Convert.IsDBNull(result))
                    prevValue = 0;
                else
                    prevValue = Convert.ToInt32(result);

                prevValue++;
                nextValue = prevValue;
                DataObj.Execute("Update tblNameValueParameter set ParameterValue='" + nextValue + "' where ParameterName='" + parametername + "'");
            }
            catch (Exception ex)
            {
                AppMessageBox.ShowError("Unable to get parameter value for key field " + parametername + ": \n" + ex.Message);
            }

            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static bool IsLeapYear(int year)
        {
            if ((year % 400) == 0 || ((year % 100 != 0) && (year % 4 == 0)))
                return true;

            else
                return false;

        }

        public static void ReplaceInvalidChars(ref DataRow dr)
        {
            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {
                if (!(dr.Table.Columns[i].ReadOnly || dr.Table.Columns[i].AutoIncrement || dr.Table.Columns[i].DataType != typeof(string)))
                    dr[i] = dr[i].ToString().Replace("'", "`");
            }
        }

        internal static bool IsNumeric(string str)
        {
            if (str == string.Empty)
                return false;
            char[] strArray = new char[str.Length];
            strArray = str.ToCharArray();
            char ch;
            bool numeric = true;

            for (int i = 0; i < strArray.Length; i++)
            {
                ch = strArray[i];
                if (Convert.ToInt32(ch) < 48 || Convert.ToInt32(ch) > 57)
                {
                    numeric = false;
                    return numeric;
                }

            }
            return numeric;
        }

        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        internal static bool IsDecimalNumeric(string str)
        {
            if (str == string.Empty)
                return false;
            char[] strArray = new char[str.Length];
            strArray = str.ToCharArray();
            char ch;
            bool numeric = true;

            for (int i = 0; i < strArray.Length; i++)
            {
                ch = strArray[i];
                if ((Convert.ToInt32(ch) < 48 && Convert.ToInt32(ch) != 46 && Convert.ToInt32(ch) != 45) || Convert.ToInt32(ch) > 57)
                {
                    numeric = false;
                    return numeric;
                }

            }
            return numeric;
        }

        internal static bool IsAlphaNumeric(string str)
        {
            char[] strArray = new char[str.Length];
            strArray = str.ToCharArray();
            char ch;
            bool numeric = false;
            bool alphabetic = false;
            for (int i = 0; i < strArray.Length; i++)
            {
                ch = strArray[i];
                if (Convert.ToInt32(ch) >= 48 && Convert.ToInt32(ch) <= 57)
                    numeric = true;
                if (Convert.ToInt32(ch) >= 65 && Convert.ToInt32(ch) <= 90)
                    alphabetic = true;
                else if (Convert.ToInt32(ch) >= 97 && Convert.ToInt32(ch) <= 122)
                    alphabetic = true;
            }
            if (numeric && alphabetic)
                return true;
            else
                return false;


        }

        internal static bool IsValidEmailFormat(string str)
        {
            if (str == "")
                return true;

            char[] strArray = new char[str.Length];
            strArray = str.ToCharArray();
            char ch;
            int AtIndex = 0;
            int DotIndex = 0;
            bool AtFound = false;
            bool DotFound = false;
            bool AtFoundTwice = false;
            bool DotFoundTwice = false;
            for (int i = 0; i < strArray.Length; i++)
            {
                ch = strArray[i];
                if (Convert.ToString(ch) == "@")
                {
                    if (!AtFound)
                    {
                        AtFound = true;
                        AtIndex = i;
                    }
                    else
                        AtFoundTwice = true;
                }
                else if (Convert.ToString(ch) == ".")
                {
                    if (!DotFound)
                    {
                        DotFound = true;
                        DotIndex = i;
                    }
                    //else
                    //    DotFoundTwice = true;
                }

            }
            if (AtFoundTwice || DotFoundTwice)
                return false;
            else if (!AtFound || !DotFound)
                return false;
            //else if (DotIndex <= AtIndex)
            //    return false;
            else if (DotIndex == AtIndex + 1)
                return false;
            else if (AtIndex == 0)
                return false;
            else if (DotIndex == strArray.Length - 1)
                return false;
            else return true;



        }

        public static string GetCurrentWorkstation()
        {
            object result;
            string cmdText;
            clDatacon Conn = new clDatacon(clMain.ConnString);
            try
            {
                Conn.OpenConnection();
                cmdText = "SELECT host_name()";
                result = Conn.GetDataScalar(cmdText);
                if (result != null)
                    return Convert.ToString(result);
                else
                    return string.Empty;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return string.Empty;
            }
            finally
            {
                Conn.CloseConnection();
            }
        }

        public static string EncryptStr(string str)
        {
            string resultString = string.Empty;
            string tempString = string.Empty;
            char[] strArray = new char[str.Length];
            strArray = str.ToCharArray();
            char ch;
            for (int i = 0; i < strArray.Length; i++)
            {
                ch = strArray[i];
                tempString = Convert.ToString((Convert.ToInt32(ch) * 2) + 2);
                resultString = resultString + tempString;
            }
            return resultString;
        }

        public static string GetRefNo(string useAutoName, string prefixName, string nextNoName)
        {
            clDatacon Conn = new clDatacon(clMain.ConnString);
            string refNo = string.Empty;
            string cmdText = string.Empty;
            string Prefix = string.Empty;
            string NextNoStr = string.Empty;
            int NextNo = 0;
            object result;
            try
            {
                Conn.OpenConnection();
                cmdText = "select Value from tblDefaultNM where Name='" + useAutoName + "'";
                result = Conn.GetDataScalar(cmdText);
                if (result == null || Convert.IsDBNull(result))
                {
                    refNo = string.Empty;
                    //this.orderNoTextBox.ReadOnly = false;
                    //this.orderNoTextBox.Focus();
                }
                else if (Convert.ToString(result).ToLower() == "yes")
                {
                    cmdText = "select Value from tblDefaultNM where Name='" + prefixName + "'";
                    result = Conn.GetDataScalar(cmdText);
                    if (result == null || Convert.IsDBNull(result))
                        Prefix = string.Empty;
                    else
                        Prefix = Convert.ToString(result);
                    cmdText = "select Value from tblDefaultNM where Name='" + nextNoName + "'";
                    result = Conn.GetDataScalar(cmdText);
                    if (result == null || Convert.IsDBNull(result))
                    {
                        MessageBox.Show("Unable to generate automatic reference number\n Please insert valid next number on Name value defaults in Setup menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        refNo = string.Empty;

                    }
                    else
                    {
                        NextNo = Convert.ToInt32(result);

                        NextNoStr = Prefix + NextNo.ToString("000000");
                        refNo = NextNoStr;
                        //this.orderNoTextBox.ReadOnly = true;
                    }



                }
                else
                {
                    refNo = string.Empty;
                }
                return refNo;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return string.Empty;
            }
            finally
            {
                Conn.CloseConnection();
            }
        }

        public static void UpdateNextNo(string useAutoName, string nextNoName)
        {
            object result;
            string CmdText;
            int NextNo = 0;
            clDatacon Conn = new clDatacon(clMain.ConnString);
            try
            {
                Conn.OpenConnection();
                CmdText = "select Value from tblDefaultNM where Name='" + useAutoName + "'";
                result = Conn.GetDataScalar(CmdText);
                if (result != null && !Convert.IsDBNull(result))
                {
                    if (Convert.ToString(result).ToLower() == "yes")
                    {
                        CmdText = "select Value from tblDefaultNM where Name='" + nextNoName + "'";
                        result = Conn.GetDataScalar(CmdText);
                        if (result != null && !Convert.IsDBNull(result))
                        {
                            NextNo = 0;
                            NextNo = Convert.ToInt32(result);
                            NextNo = NextNo + 1;
                            CmdText = "update tblDefaultNM set Value='" + NextNo + "' where Name='" + nextNoName + "'";
                            Conn.Execute(CmdText);
                            NextNo = 0;

                        }

                    }

                }



            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
            finally
            {
                Conn.CloseConnection();
            }
        }
        
        public static decimal GetShareNoByShareAmount(decimal ShareAmnt)
        {


            decimal sharNo = 0;
            sharNo = Math.Round(Convert.ToDecimal(ShareAmnt / 1000),2);
            return sharNo;

        }

        public static bool OpenNewBudgetYear(string oldBudgetYear,ref clDatacon DataObj)
        {
            bool result= false;
            string cmdText ;
            string FisicalYear;
            int BegningYear;
            int EndingYear;
            DateTime StartDate;
            string StartDateEth;
            DateTime EndDate;
            string EndDateEth;
            //clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                //DataObj.OpenConnection();
                int index=oldBudgetYear.IndexOf("/");
                BegningYear = Convert.ToInt32(oldBudgetYear.Substring(index + 1)) + 1;
               //Commented by Dawit EndingYear = BegningYear + 1;
                EndingYear = BegningYear  ; //Added by Dawit
               // FisicalYear = BegningYear.ToString() + "/" + EndingYear.ToString();
                FisicalYear = BegningYear.ToString();
              //  StartDate = Convert.ToDateTime("01/07/" + BegningYear);
                StartDate = Convert.ToDateTime("01/01/" + BegningYear);
                StartDateEth = clUtility.GetEthDate(StartDate);
               // EndDate = Convert.ToDateTime("30/06/" + EndingYear);
                EndDate = Convert.ToDateTime("31/12/" + EndingYear);
                EndDateEth = clUtility.GetEthDate(EndDate);
                cmdText = "insert into tblFiscalYears(FiscalYear,StartDate,StartDateEth,EndDate,EndDateEth,Closed,CrtBy)"+
                "values('" + FisicalYear + "','" + StartDate + "','" + StartDateEth + "','" + EndDate + "','" + EndDateEth+"',0,'"+clMain.User.UserName+"')";
                result=DataObj.Execute(cmdText);
                return result;
                
            }
            catch (Exception ex)
            {
                AppMessageBox.ShowError(ex.Message);
                return result;
            }

            //finally
            //{
            //    DataObj.CloseConnection();
            //}
        }

        public static int GetStartYearOfFisicalYear(string fisicalYear)
        {
            int indexofSlash = 0;
            int startYear;
            indexofSlash = fisicalYear.IndexOf('/');
            startYear = Convert.ToInt32(fisicalYear);//Convert.ToInt32(fisicalYear.Substring(0, indexofSlash));
            return startYear;

        }


        public static string GetCurrentFiscalYear()
        {
            object result;
            string fiscalyear="";
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                result = DataObj.GetDataScalar("select top 1 FiscalYear from tblFiscalYears where  closed=0 order by FiscalYear desc");
                if (result == null || Convert.IsDBNull(result))
                    fiscalyear= string.Empty;
                else
                    fiscalyear= Convert.ToString(result);

            }
            catch (Exception ex)
            {
                AppMessageBox.ShowError(ex.Message);
                
            }

            finally
            {
                DataObj.CloseConnection();
            }
            return fiscalyear;
        }

        public static int GetMeetingRoundRoundNumber(int MeetingType)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            int RoundNumber=0;
            
            try
            {
                DataObj.OpenConnection();
                RoundNumber = Convert.ToInt32(DataObj.GetDataScalar("SELECT  top 1 RoundNo FROM tblMeetingSession WHERE TypeOfMeeting=" + MeetingType + " order by SessionId desc" ));


                
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowError(Ex.Message);
                
            }
            finally
            {
                DataObj.CloseConnection();
            }
            return RoundNumber;
        }

        public static bool UpdateRegDateEth()
        {
            bool result = false;
            string cmdText;
            string DateEth;
            string sDateEth;
            string eDateEth;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
          
                //cmdText = "SELECT RegCode,DOReg,DORegEth FROM tblShareholderDetail ";
                cmdText = "SELECT YearPeriod,StartDate,EndDate,StartDateEth,EndDateEth FROM tblYearPeriod";

                DataTable tblSHList =new DataTable();
                DataObj.FillData(tblSHList, cmdText);
                foreach (DataRow row in tblSHList.Rows)
                {
                   // DateEth = clUtility.GetEthDate(Convert.ToDateTime(row["DOReg"]));
                    sDateEth = clUtility.GetEthDate(Convert.ToDateTime(row["StartDate"]));
                    eDateEth = clUtility.GetEthDate(Convert.ToDateTime(row["EndDate"]));
                    //cmdText = "UPDATE tblShareholderDetail SET DORegEth='" + DateEth + "' WHERE RegCode='" + row["RegCode"].ToString() + "'";
                    cmdText = "UPDATE tblYearPeriod SET StartDateEth='" + sDateEth + "',EndDateEth='" + eDateEth + "' WHERE YearPeriod='" + row["YearPeriod"].ToString() + "'";
                    result = DataObj.Execute(cmdText);
                    if (result == false)
                        return result;
                }
                
              //  result = DataObj.Execute(cmdText);
                return result;

            }
            catch (Exception ex)
            {
                AppMessageBox.ShowError(ex.Message);
                return result;
            }

            finally
            {
                DataObj.CloseConnection();
            }
        }

    }

     

    class AppMessageBox
    {
        private const string AppMessageBoxCaption = "iCMC - Shareholder Management System";

        public static DialogResult ShowInformation(string text)
        {
            return MessageBox.Show(text, AppMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowExclamation(string text)
        {
            return MessageBox.Show(text, AppMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult ShowError(string text)
        {
            return MessageBox.Show(text, AppMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowQuestion(string text)
        {
            return MessageBox.Show(text, AppMessageBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult ShowQuestion(string text, MessageBoxButtons buttons)
        {
            return MessageBox.Show(text, AppMessageBoxCaption, buttons, MessageBoxIcon.Question);
        }

    }
}
