using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace SHM
{
    public class clShareholder
    {
      #region Fields
        private int _id;
        private string _RegCode;
       
        private bool _active;

       

        string cmdText = "";
        
      #endregion

      #region Properties
        public int SHId
        {
            get { return this._id; }
        }
        public string RegCode
        {
            get { return this._RegCode; }
        }
       
         public bool Active
        {
            get { return this._active; }
        }
     #endregion

     #region Methods
     public static string GetShareholderId(int id)
        {
            object result;
            string cmdText;
            clDatacon DataObj= new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT SHId FROM tblShareholderDetail WHERE SHId=" + id;
                result = DataObj.GetDataScalar(cmdText);
                if (result != null)
                    return result.ToString();
                else
                    return null;
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.CloseConnection();
                return null;
            }
           finally
            {
                DataObj.CloseConnection();
            }
        }

     public static string GetRegCode(string regCode)
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);;
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT RegCode FROM tblShareholderDetail WHERE RegCode='" + regCode+"'";
                result = DataObj.GetDataScalar(cmdText);
                if (result != null)
                    return Convert.ToString(result);
                else
                    return "";
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                return "";
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

     public clShareholder(int id)
        {
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblShareholderDetail WHERE SHId=" + id;
                Ds = DataObj.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    this._id = Convert.ToInt32(Ds.Tables[0].Rows[0]["SHId"]);
                    this._RegCode = Convert.ToString(Ds.Tables[0].Rows[0]["RegCode"]);
                    this._active = Convert.ToBoolean(Ds.Tables[0].Rows[0]["Active"]);
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

     public static string GetShareHolderBrowseSql()
        {
            return GetShareholderBrowseSql(string.Empty);
        }

     public static string GetShareholderBrowseSql(bool isActive)
        {
            return GetShareholderBrowseSql("SHStatus=" + Convert.ToInt32(isActive));
        }

     public static string GetShareholderBrowseSql(string criteria)
        {
            if (criteria != string.Empty) criteria = ("AND " + criteria);
            //if (AppMain.AppName == "HR" && AppMain.User.UserID == 1)
            //return "SELECT Id, EmployeeId, FullName+Isnull(' /'+Title+'/','') AS FullName, AccountNo, (FullName + ' - ' + EmployeeId) AS EmployeeIdWithName, (EmployeeId + ' - ' + FullName) AS IdWithFullName FROM tblEmployees WHERE 1=1 " + criteria + " ORDER BY EmployeeId";
            //else if (AppMain.AppName == "HR")
            //    return "SELECT Id, EmployeeId, FullName+Isnull(' /'+Title+'/','') AS FullName, AccountNo, (FullName + ' - ' + EmployeeId) AS EmployeeIdWithName, (EmployeeId + ' - ' + FullName) AS IdWithFullName FROM tblEmployees WHERE DeptCode IN (SELECT DeptCode FROM View_Hr_UserAllowedDept WHERE UserName='" + AppMain.User.UserName + "') " + criteria + " ORDER BY EmployeeId";
            //else if (AppMain.AppName == "PAY" && AppMain.User.UserID == 1)
            //    return "SELECT Id, EmployeeId, FullName+Isnull(' /'+Title+'/','') AS FullName, AccountNo, (FullName + ' - ' + EmployeeId) AS EmployeeIdWithName, (EmployeeId + ' - ' + FullName) AS IdWithFullName FROM tblEmployees WHERE 1=1 " + criteria + " ORDER BY EmployeeId";
            //else if (AppMain.AppName == "PAY")
            //    return "SELECT Id, EmployeeId, FullName+Isnull(' /'+Title+'/','') AS FullName, AccountNo, (FullName + ' - ' + EmployeeId) AS EmployeeIdWithName, (EmployeeId + ' - ' + FullName) AS IdWithFullName FROM tblEmployees WHERE DeptCode IN (SELECT ProgCode FROM View_Pay_UserAllowedDept WHERE UserName='" + AppMain.User.UserName + "') " + criteria + " ORDER BY EmployeeId";
            //else
            //    return string.Empty;


            return "SELECT SHId, RegCode, FullName+Isnull(' /'+Title+'/','') AS FullName, (RegCode + ' - ' + FullName) AS SHRegCodeWithName FROM tblShareholderDetail WHERE 1=1 " + criteria + " ORDER BY RegCode";
                //return "SELECT Id, AccountNo As EmployeeId, FullName+Isnull(' /'+Title+'/','') AS FullName, (AccountNo + ' - ' + FullName) AS EmployeeIdWithName, AccountNo FROM tblEmployees WHERE 1=1 " + criteria + " ORDER BY EmployeeId";
           
        }

     public static string GetShareHolder(int id)
        {
            return "Select * from tblShareholderDetail where SHId='" + id + "'";
        }

     public static bool ValidateShareholder(DataRow row)
        {
            if (!clShareholder.Validate(row))
            {
                return false;
            }
            if (!clShareholder.ValidateFullName(Convert.ToString(row["FullName"])))
            {
                return false;
            }

           /* if (!Convert.IsDBNull(row["Email1"]) || row["Email1"] != null || row["Email1"].ToString().Trim() != "" || row["Email1"].ToString().Trim() !="NA")
            {
                if (!clShareholder.ValidateEmailAddress(Convert.ToString(row["Email1"])))
                {
                    return false;
                }
               
            }
            if (!Convert.IsDBNull(row["Email2"]) || row["Email2"] != null || row["Email2"].ToString().Trim() != "" || row["Email2"].ToString().Trim() !="NA")
            {
                if (!clShareholder.ValidateEmailAddress(Convert.ToString(row["Email2"])))
                {
                    return false;
                }

            }
           */
            return true;
        }

     private static bool ValidateFullName(string fullName)
        {
            if (clUtility.TextContainsNumber(fullName))
            {
                AppMessageBox.ShowExclamation("Full name should contain letters only");
                return false;
            }
            return true;
        }

     private static bool Validate(DataRow row)
        {
            string checkMsg = clDataUtility.CheckValues(row, clMain.ConnString);
            if (checkMsg != string.Empty)
            {
                AppMessageBox.ShowExclamation(checkMsg);
                return false;
            }
            return true;
        }
     
     private static bool ValidateEmailAddress(string emailadd)
        {
            
            if (!clUtility.IsValidEmailFormat(emailadd))
            {
                
                return false;
            }
            return true;
        }

     public static Decimal GetTotalAmntForDividend(string fiscalYear)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            decimal totalDividendAmnt = 0;

            try
            {
                DataObj.OpenConnection();
                object result;
                
                result = DataObj.GetDataScalar("select TotalAmntForDividend from tblDividendParameters where  FiscalYear = '" + fiscalYear + "'");
                if (result != null)
                    totalDividendAmnt= Convert.ToDecimal(result);


            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.CloseConnection();
            }
            finally
            {
                DataObj.CloseConnection();
            }
            return totalDividendAmnt;

        }

     public static Decimal GetTotalPaidupCapital(string fiscalYear)
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            decimal totalDividendAmnt = 0;
            string cmdText;

            try
            {
                DataObj.OpenConnection();
                object result;
                cmdText="select sum(isnull((PaidUpShareAmt-(PaidUpShareAmt-convert(int,PaidUpShareAmt/1000)*1000)),0)) from tblShareRegBookYtd where FiscalYear='" + fiscalYear+"'";
                result = DataObj.GetDataScalar(cmdText);
                if (result != null)
                    totalDividendAmnt= Convert.ToDecimal(result);


            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.CloseConnection();
            }
            finally
            {
                DataObj.CloseConnection();
            }
            return totalDividendAmnt;

        }

     public static Decimal GetTotalPaidupCapitalofLF()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            decimal totalDividendAmnt = 0;

            try
            {
                DataObj.OpenConnection();
                object result;

                result = DataObj.GetDataScalar("select sum(isnull((PaidUpShareAmt-(PaidUpShareAmt-convert(int,PaidUpShareAmt/1000)*1000)),0)) from tblShareRegBookYtd where SHId in (select SHId from tblShareholderDetail where IsLBFounder=1 and SHStatus=1)");
                if (result != null)
                    totalDividendAmnt= Convert.ToDecimal(result);


            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.CloseConnection();
            }
            finally
            {
                DataObj.CloseConnection();
            }
            return totalDividendAmnt;

        }

     public static Decimal GetTotalPaidupCapitalofGF()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            decimal totalDividendAmnt = 0;

            try
            {
                DataObj.OpenConnection();
                object result;

                result = DataObj.GetDataScalar("select sum(isnull((PaidUpShareAmt-(PaidUpShareAmt-convert(int,PaidUpShareAmt/1000)*1000)),0)) from tblShareRegBookYtd where SHId in (select SHId from tblShareholderDetail where IsGBFounder=1 and SHStatus=1)");
                if (result != null)
                    totalDividendAmnt= Convert.ToDecimal(result);


            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.CloseConnection();
            }
            finally
            {
                DataObj.CloseConnection();
            }
            return totalDividendAmnt;

        }

     public static Decimal GetTotalCommonDividend(string fiscalYear)
     {
         
         
         decimal TotalamountForDividend = 0;
         decimal CommonAmountForDividend = 0;
         decimal TotalRemitanceRightForLF = 0;
         decimal TotalRemitanceRightForGF = 0;
         decimal GFPercentage = 0;
         decimal LFpercentage = 0;
         DataSet dsParam = new DataSet();
        
         try
         {
             


            
             TotalamountForDividend = GetTotalAmntForDividend(fiscalYear);

             if (GetLifeFoundersRemittanceRightCounter() < 3)
             {
                 dsParam = GetGeneralParam();
                 if (dsParam.Tables[0].Rows.Count > 0)
                 {
                     LFpercentage = Convert.ToDecimal(dsParam.Tables[0].Rows[0]["PercOfDividToLBF"]);
                 
                     TotalRemitanceRightForLF = TotalamountForDividend * (LFpercentage / 100);
                     
                 }
             }
             if (GetGeneralFoundersRemittanceRightCounter() < 3)
              {
                 dsParam = GetGeneralParam();
                 if (dsParam.Tables[0].Rows.Count > 0)
                 {
                     GFPercentage = Convert.ToDecimal(dsParam.Tables[0].Rows[0]["PercOfDividToGBF"]);

                     TotalRemitanceRightForGF = (TotalamountForDividend - TotalRemitanceRightForLF) * (GFPercentage / 100);

                 }

             }
             CommonAmountForDividend = (TotalamountForDividend - (TotalRemitanceRightForLF + TotalRemitanceRightForGF));

         }
         catch (Exception Ex)
         {
             AppMessageBox.ShowExclamation(Ex.Message);
             //DataObj.CloseConnection();
         }
         finally
         {
             //DataObj.CloseConnection();
         }
         return CommonAmountForDividend;

     }

     public static Decimal GetSumofCommonDividend(string fiscalYear)
     {

         decimal SumofCommonDividend = 0;
        
         DataSet ds = new DataSet();
         clDatacon DataObj = new clDatacon(clMain.ConnString);

         try
         {
             DataObj.OpenConnection();
             object result;
             string CmdText;
             CmdText = "select sum(CommonDiv)from tblDividendEntitled where FiscalYear='" + fiscalYear+"'";
             result=DataObj.GetDataScalar(CmdText);

             if (result != null)

                 SumofCommonDividend = Convert.ToDecimal(result);

            
                

         }
         catch (Exception Ex)
         {
             AppMessageBox.ShowExclamation(Ex.Message);
             DataObj.CloseConnection();
         }
         finally
         {
             DataObj.CloseConnection();
         }
         return SumofCommonDividend;

     }
     
     public static int GetLifeFoundersRemittanceRightCounter()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            int counter = 0;

            try
            {
                DataObj.OpenConnection();
                object result;
                
                result = DataObj.GetDataScalar("select ParameterValue from tblNameValueParameter where  ParameterName = 'LFRRCounter'");
                if (result != null)
                    counter= Convert.ToInt32(result);


            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.CloseConnection();
            }
            finally
            {
                DataObj.CloseConnection();
            }
            return counter;

        }

     public static int GetGeneralFoundersRemittanceRightCounter()
        {
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            int counter = 0;

            try
            {
                DataObj.OpenConnection();
                object result;

                result = DataObj.GetDataScalar("select ParameterValue from tblNameValueParameter where  ParameterName = 'GFRRCounter'");
                if (result != null)
                    counter= Convert.ToInt32(result);


            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.CloseConnection();
            }
            finally
            {
                DataObj.CloseConnection();
            }
            return counter;

        }

     public static DataSet GetGeneralParam()
     {
         clDatacon DataObj = new clDatacon(clMain.ConnString);
         DataSet ds = new DataSet();

         try
         {
             DataObj.OpenConnection();

             ds = DataObj.GetDataSet("select top 1 PercOfDividToLBF,PercOfDividToGBF from tblGeneralParameters");


         }
         catch (Exception Ex)
         {
             AppMessageBox.ShowExclamation(Ex.Message);
             DataObj.CloseConnection();
         }
         finally
         {
             DataObj.CloseConnection();
         }
         return ds;

     }

     private static DataSet GetShareTransferTransaction(string fiscalYear,DateTime startdate, DateTime enddate, int shId)
     {
         clDatacon DataObj = new clDatacon(clMain.ConnString);
         DataSet ds = new DataSet();

         try
         {
             DataObj.OpenConnection();

             ds = DataObj.GetDataSet("set dateformat dmy select TransferFromSHId,TransferToSHId,EffectiveDate,NoOfShareTransfered,AmntOfShareTransfered from tblShareTransfer where  IsCanceled=0 and  FiscalYear='" + fiscalYear + "' and EffectiveDate>'" + startdate + "' and EffectiveDate<'" + enddate + "' and TransferFromSHId=" + shId + " or TransferToSHId=" + shId + " order by EffectiveDate desc");


         }
         catch (Exception Ex)
         {
             AppMessageBox.ShowExclamation(Ex.Message);
             DataObj.CloseConnection();
         }
         finally
         {
             DataObj.CloseConnection();
         }
         return ds;

     }
     
     private static DataSet GetSharePayedTransaction(string fiscalYear, DateTime startdate, DateTime enddate, int shId)
     {
         clDatacon DataObj = new clDatacon(clMain.ConnString);
         DataSet ds = new DataSet();

         try
         {
             DataObj.OpenConnection();
             string ds_startdate = clUtility.ToDMYDate(startdate);
             string ds_enddate = clUtility.ToDMYDate(enddate);
             string cmd = "set dateformat dmy select SHId,EffectiveDate,NoofSharePaid,AmntofSharePaid from tblSharePayment where   IsCanceled=0 and FiscalYear='" + fiscalYear + "' and EffectiveDate>'" + ds_startdate + "' and EffectiveDate<'" + ds_enddate + "' and SHId=" + shId + " order by EffectiveDate desc";
             ds = DataObj.GetDataSet(cmd);


         }
         catch (Exception Ex)
         {
             AppMessageBox.ShowExclamation(Ex.Message);
             DataObj.CloseConnection();
         }
         finally
         {
             DataObj.CloseConnection();
         }
         return ds;

     }

     private static DataSet GetSharePayedNextTransaction(string fiscalYear, DateTime startdate, DateTime enddate, int shId)
     {
         clDatacon DataObj = new clDatacon(clMain.ConnString);
         DataSet ds = new DataSet();

         try
         {
             DataObj.OpenConnection();
             string ds_startdate = clUtility.ToDMYDate(startdate);
             string ds_enddate = clUtility.ToDMYDate(enddate);
             string cmd = "set dateformat dmy select SHId,EffectiveDate,NoofSharePaid,AmntofSharePaid from tblSharePayment where   IsCanceled=0 and FiscalYear='" + fiscalYear + "' and EffectiveDate>'" + ds_enddate + "' and SHId=" + shId + " order by EffectiveDate desc";
             ds = DataObj.GetDataSet(cmd);


         }
         catch (Exception Ex)
         {
             AppMessageBox.ShowExclamation(Ex.Message);
             DataObj.CloseConnection();
         }
         finally
         {
             DataObj.CloseConnection();
         }
         return ds;

     }
     public static List<decimal> GetDividendAmount(int SHId, decimal TotalPaidupAmnt, bool IsLBF, bool IsGBF, string fiscalYear, DateTime StartDate, DateTime EndDate)
        {
          
            DataSet dsPd = new DataSet();
            DataRow drPd;

            DataSet dsNxt = new DataSet();
            DataRow drNxt;

            DataSet dsTrn = new DataSet();
            DataRow drTrn;
         
            decimal NetDividend = 0;
            decimal LFRRDiv = 0;
            decimal GFRRDiv = 0;
            decimal CommonDiv = 0;
           
            decimal FullYearDividend=0;
            decimal FullYearPaidup = 0;
            decimal ParcialYearPaidup = 0;
            decimal ParcialYearTransfer = 0;
            decimal ParcialYearDividend=0;
            decimal ParcialYearRemittanceRightLF=0;
            decimal ParcialYearRemittanceRightGF=0;
            decimal FullYearRemittanceRightLF=0;
            decimal FullYearRemittanceRightGF=0;
            decimal TotalPaidupCapital=0;
            decimal LFTotalPaidupCapital=0;
            decimal GFTotalPaidupCapital=0;

           
            decimal remainder=0;
            decimal TotalamountForDividend = 0;
            decimal TotalCommonAmountForDividend = 0;
            decimal TotalRemitanceRightForLF=0;
            decimal TotalRemitanceRightForGF=0;

          
            List <decimal> NumberOfMonthsForPaid = new List<decimal>();
            List <decimal> NumberOfMonthsForTransfer = new List<decimal>();
            List <decimal> DividendList = new List<decimal>();
            List <decimal> RemitanceList = new List<decimal>();
            
            List<decimal> PaidList = new List<decimal>();
           
            List<decimal> TransferList = new List<decimal>();
           
           
            
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                dsPd = GetSharePayedTransaction(fiscalYear, StartDate, EndDate, SHId);
                dsNxt = GetSharePayedNextTransaction(fiscalYear, StartDate, EndDate, SHId);
                //dsTrn = GetShareTransferTransaction(fiscalYear,StartDate, EndDate, SHId);


                TotalPaidupCapital = GetTotalPaidupCapital(fiscalYear);
                TotalamountForDividend = GetTotalAmntForDividend(fiscalYear);
                FullYearPaidup=TotalPaidupAmnt;
               
                    
                if (dsPd.Tables[0].Rows.Count > 0)
                {  
                    decimal noOfMonths;
                    for (int i = 0; i < dsPd.Tables[0].Rows.Count; i++)
                    {
                        drPd = dsPd.Tables[0].Rows[i];
                        noOfMonths =clUtility.GetDurationInMonths(Convert.ToDateTime(drPd["EffectiveDate"]),EndDate);
                        if(noOfMonths<12)
                        {
                          FullYearPaidup=FullYearPaidup-Convert.ToDecimal(drPd["AmntofSharePaid"]);
                          PaidList.Add(Convert.ToDecimal(drPd["AmntofSharePaid"]));
                          NumberOfMonthsForPaid.Add(noOfMonths);
                        }
                        
                    }
                }
                if (dsNxt.Tables[0].Rows.Count > 0)
                {
                    decimal noOfMonths;
                    for (int i = 0; i < dsNxt.Tables[0].Rows.Count; i++)
                    {
                        drNxt = dsNxt.Tables[0].Rows[i];
                        FullYearPaidup = FullYearPaidup - Convert.ToDecimal(drNxt["AmntofSharePaid"]);

                    }
                }
               
                
                //if (dsTrn.Tables[0].Rows.Count > 0)
                //{   
                //    decimal noOfMonthsTo,noOfMonthsFrom;
                //    for (int i = 0; i < dsTrn.Tables[0].Rows.Count; i++)
                //    {
                //        drTrn = dsTrn.Tables[0].Rows[i];
                //        noOfMonthsTo=clUtility.GetDurationInMonths(Convert.ToDateTime(drTrn["EffectiveDate"]),EndDate);
                //        noOfMonthsFrom=clUtility.GetDurationInMonths(StartDate,Convert.ToDateTime(drTrn["EffectiveDate"]));
                        
                //        if(SHId==Convert.ToInt32(drTrn["TransferToSHId"]))
                //        {
                //          if(noOfMonthsTo<12)
                //           {
                //            FullYearPaidup=FullYearPaidup-Convert.ToDecimal(drTrn["AmntOfShareTransfered"]);
                //            TransferList.Add(Convert.ToDecimal(drTrn["AmntOfShareTransfered"]));
                //            NumberOfMonthsForTransfer.Add(noOfMonthsTo);
                            
                //          }
                //        }
                //        else if ((Convert.ToInt32(drTrn["TransferFromSHId"])!=Convert.ToInt32(drTrn["TransferToSHId"]))&& SHId == Convert.ToInt32(drTrn["TransferFromSHId"]))
                //        {
                //          if(noOfMonthsFrom<12)
                //           {
                //            TransferList.Add(Convert.ToDecimal(drTrn["AmntOfShareTransfered"]));
                //            NumberOfMonthsForTransfer.Add(noOfMonthsFrom);
                            
                //          }
                //        }
                       
                       
                //      }
                        
                //    }
                    remainder=FullYearPaidup%1000;
                    FullYearPaidup= FullYearPaidup-remainder;

                    if (GetLifeFoundersRemittanceRightCounter() < 3 || GetGeneralFoundersRemittanceRightCounter() < 3)
                    {
                        if (GetLifeFoundersRemittanceRightCounter() < 3)
                        {

                            DataSet dsParam = new DataSet();
                            decimal LFpercentage = 0;


                            dsParam = GetGeneralParam();
                            if (dsParam.Tables[0].Rows.Count > 0)
                            {
                                LFpercentage = Convert.ToDecimal(dsParam.Tables[0].Rows[0]["PercOfDividToLBF"]);
                                TotalRemitanceRightForLF = TotalamountForDividend * (LFpercentage / 100);
                                TotalCommonAmountForDividend = TotalamountForDividend - TotalRemitanceRightForLF;
                            }
                           
                        }



                        if (GetGeneralFoundersRemittanceRightCounter() < 3)
                        {

                            DataSet dsParam2 = new DataSet();
                            decimal GFPercentage = 0;


                            dsParam2 = GetGeneralParam();
                            if (dsParam2.Tables[0].Rows.Count > 0)
                            {
                                GFPercentage = Convert.ToDecimal(dsParam2.Tables[0].Rows[0]["PercOfDividToGBF"]);
                                TotalRemitanceRightForGF = (TotalamountForDividend - TotalRemitanceRightForLF) * (GFPercentage / 100);
                                TotalCommonAmountForDividend = (TotalamountForDividend - (TotalRemitanceRightForLF + TotalRemitanceRightForGF));
                            }  

                        }

                        if (IsLBF)
                        {
                            LFTotalPaidupCapital = GetTotalPaidupCapitalofLF();

                            FullYearDividend = (FullYearPaidup / TotalPaidupCapital) * TotalCommonAmountForDividend;
                            FullYearRemittanceRightLF = (FullYearPaidup / LFTotalPaidupCapital) * TotalRemitanceRightForLF;
                            for (int i = 0; i < PaidList.Count; i++)
                            {
                                ParcialYearPaidup = PaidList[i];

                                ParcialYearPaidup = ParcialYearPaidup + remainder;
                                if (ParcialYearPaidup % 1000 > 0)
                                {
                                    remainder = ParcialYearPaidup % 1000;
                                    ParcialYearPaidup = ParcialYearPaidup - remainder;
                                }
                                ParcialYearDividend = ParcialYearDividend + (ParcialYearPaidup / TotalPaidupCapital) * TotalCommonAmountForDividend * (NumberOfMonthsForPaid[i] / 12);
                                ParcialYearRemittanceRightLF = ParcialYearRemittanceRightLF + (ParcialYearPaidup / LFTotalPaidupCapital) * TotalRemitanceRightForLF * (NumberOfMonthsForPaid[i] / 12);
                            }

                            for (int i = 0; i < TransferList.Count; i++)
                            {
                                ParcialYearTransfer = TransferList[i];

                                ParcialYearTransfer = ParcialYearTransfer + remainder;
                                if (ParcialYearTransfer % 1000 > 0)
                                {
                                    remainder = ParcialYearTransfer % 1000;
                                    ParcialYearTransfer = ParcialYearTransfer - remainder;
                                }
                                ParcialYearDividend = ParcialYearDividend + (ParcialYearTransfer / TotalPaidupCapital) * TotalCommonAmountForDividend * (NumberOfMonthsForTransfer[i] / 12);
                                ParcialYearRemittanceRightLF = ParcialYearRemittanceRightLF + (ParcialYearTransfer / LFTotalPaidupCapital) * TotalRemitanceRightForLF * (NumberOfMonthsForTransfer[i] / 12);
                            }
                            LFRRDiv = FullYearRemittanceRightLF + ParcialYearRemittanceRightLF;
                            CommonDiv = FullYearDividend + ParcialYearDividend; 
                            NetDividend = FullYearDividend + ParcialYearDividend + FullYearRemittanceRightLF + ParcialYearRemittanceRightLF;
                            
                            DividendList.Add(LFRRDiv);
                            DividendList.Add(GFRRDiv);
                            DividendList.Add(CommonDiv);
                            DividendList.Add(NetDividend);
                        }

                        else if (IsGBF)
                        {
                            GFTotalPaidupCapital = GetTotalPaidupCapitalofGF();

                            FullYearDividend = (FullYearPaidup / TotalPaidupCapital) * TotalCommonAmountForDividend;
                            FullYearRemittanceRightGF = (FullYearPaidup / GFTotalPaidupCapital) * TotalRemitanceRightForGF;
                            for (int i = 0; i < PaidList.Count; i++)
                            {
                                ParcialYearPaidup = PaidList[i];

                                ParcialYearPaidup = ParcialYearPaidup + remainder;
                                if (ParcialYearPaidup % 1000 > 0)
                                {
                                    remainder = ParcialYearPaidup % 1000;
                                    ParcialYearPaidup = ParcialYearPaidup - remainder;
                                }
                                
                                ParcialYearDividend = ParcialYearDividend + (ParcialYearPaidup / TotalPaidupCapital) * TotalCommonAmountForDividend * (NumberOfMonthsForPaid[i] / 12);
                                ParcialYearRemittanceRightGF = ParcialYearRemittanceRightGF + (ParcialYearPaidup / LFTotalPaidupCapital) * TotalRemitanceRightForGF * (NumberOfMonthsForPaid[i] / 12);
                            }

                            for (int i = 0; i < TransferList.Count; i++)
                            {
                                ParcialYearTransfer = TransferList[i];

                                ParcialYearTransfer = ParcialYearTransfer + remainder;
                                if (ParcialYearTransfer % 1000 > 0)
                                {
                                    remainder = ParcialYearTransfer % 1000;
                                    ParcialYearTransfer = ParcialYearTransfer - remainder;
                                }
                                ParcialYearDividend = ParcialYearDividend + (ParcialYearPaidup / TotalPaidupCapital) * TotalCommonAmountForDividend * (NumberOfMonthsForTransfer[i] / 12);
                                ParcialYearRemittanceRightGF = ParcialYearRemittanceRightGF + (ParcialYearPaidup / LFTotalPaidupCapital) * TotalRemitanceRightForGF * (NumberOfMonthsForTransfer[i] / 12);
                            }
                            GFRRDiv = FullYearRemittanceRightGF + ParcialYearRemittanceRightGF;
                            CommonDiv = FullYearDividend + ParcialYearDividend;
                            NetDividend = FullYearDividend + ParcialYearDividend + FullYearRemittanceRightGF + ParcialYearRemittanceRightGF;
                            
                            DividendList.Add(LFRRDiv);
                            DividendList.Add(GFRRDiv);
                            DividendList.Add(CommonDiv);
                            DividendList.Add(NetDividend);
                        }
                        else
                        {

                            FullYearDividend = (FullYearPaidup / TotalPaidupCapital) * TotalCommonAmountForDividend;
                            
                            for (int i = 0; i < PaidList.Count; i++)
                            {
                                ParcialYearPaidup = PaidList[i];

                                ParcialYearPaidup = ParcialYearPaidup + remainder;
                                if (ParcialYearPaidup % 1000 > 0)
                                {
                                    remainder = ParcialYearPaidup % 1000;
                                    ParcialYearPaidup = ParcialYearPaidup - remainder;
                                }
                                ParcialYearDividend = ParcialYearDividend + (ParcialYearPaidup / TotalPaidupCapital) * TotalCommonAmountForDividend * (NumberOfMonthsForPaid[i] / 12);
                                
                            }

                            for (int i = 0; i < TransferList.Count; i++)
                            {
                                ParcialYearTransfer = TransferList[i];

                                ParcialYearTransfer = ParcialYearTransfer + remainder;
                                if (ParcialYearTransfer % 1000 > 0)
                                {
                                    remainder = ParcialYearTransfer % 1000;
                                    ParcialYearTransfer = ParcialYearTransfer - remainder;
                                }
                                ParcialYearDividend = ParcialYearDividend + (ParcialYearPaidup / TotalPaidupCapital) * TotalCommonAmountForDividend * (NumberOfMonthsForTransfer[i] / 12);
                                
                            }
                            CommonDiv = FullYearDividend + ParcialYearDividend;
                            NetDividend = FullYearDividend + ParcialYearDividend;

                            DividendList.Add(LFRRDiv);
                            DividendList.Add(GFRRDiv);
                            DividendList.Add(CommonDiv);
                            DividendList.Add(NetDividend);
                        }
                        
                    }
                    else
                    {
                        FullYearDividend = (FullYearPaidup / TotalPaidupCapital) * TotalamountForDividend;
                            
                            for (int i = 0; i < PaidList.Count; i++)
                            {
                                ParcialYearPaidup = PaidList[i];

                                ParcialYearPaidup = ParcialYearPaidup + remainder;
                                if (ParcialYearPaidup % 1000 > 0)
                                {
                                    remainder = ParcialYearPaidup % 1000;
                                    ParcialYearPaidup = ParcialYearPaidup - remainder;
                                }
                                ParcialYearDividend = ParcialYearDividend + (ParcialYearPaidup / TotalPaidupCapital) * TotalamountForDividend * (NumberOfMonthsForPaid[i] / 12);
                                
                            }

                            for (int i = 0; i < TransferList.Count; i++)
                            {
                                ParcialYearTransfer = TransferList[i];

                                ParcialYearTransfer = ParcialYearTransfer + remainder;
                                if (ParcialYearTransfer % 1000 > 0)
                                {
                                    remainder = ParcialYearTransfer % 1000;
                                    ParcialYearTransfer = ParcialYearTransfer - remainder;
                                }
                                ParcialYearDividend = ParcialYearDividend + (ParcialYearPaidup / TotalPaidupCapital) * TotalamountForDividend * (NumberOfMonthsForTransfer[i] / 12);
                                
                            }
                            CommonDiv = FullYearDividend + ParcialYearDividend;
                            NetDividend = FullYearDividend + ParcialYearDividend;

                            DividendList.Add(LFRRDiv);
                            DividendList.Add(GFRRDiv);
                            DividendList.Add(CommonDiv);
                            DividendList.Add(NetDividend);
                        }
              
                    
            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.CloseConnection();
            }
            finally
            {
                DataObj.CloseConnection();
            }
            return DividendList;

        }

     public static decimal GetRemainingDividendAmount(decimal TotalPaidupAmntofSh, string fiscalYear )
     {

          decimal TotalPaidupCapital=0;
          decimal TotalRemainingDiv = 0;
          decimal TotalCommonDividend = 0;
          decimal SumofCommonDividend = 0;
          decimal remainingDividendofSh = 0;
          decimal remainder=0;
     
         try
         {
             remainder=TotalPaidupAmntofSh%1000;
             TotalPaidupAmntofSh= TotalPaidupAmntofSh-remainder;
             TotalPaidupCapital = GetTotalPaidupCapital(fiscalYear);
             TotalCommonDividend=GetTotalCommonDividend(fiscalYear);
             SumofCommonDividend=GetSumofCommonDividend(fiscalYear);
             TotalRemainingDiv = TotalCommonDividend - SumofCommonDividend;
             remainingDividendofSh = (TotalPaidupAmntofSh / TotalPaidupCapital)*(TotalRemainingDiv);


             

         }
         catch (Exception Ex)
         {
             AppMessageBox.ShowExclamation(Ex.Message);
             
         }
         finally
         {
            
         }
         return remainingDividendofSh;

     }

     public static decimal GetSumofBegBalanceOfNoofShare( string fiscalYear)
     {

         decimal SumOfBegningBalaceofNoofShare = 0;
         string CmdText = "";

         clDatacon DataObj = new clDatacon(clMain.ConnString);

         

            try
            {
                DataObj.OpenConnection();
                object result;
                CmdText = "select SUM(paidUpNoofShare)as begningSumofPaidupNo from tblShareRegBookYtd where  FiscalYear='" + fiscalYear + "'";
                result = DataObj.GetDataScalar(CmdText);
                if (result != null)
                    SumOfBegningBalaceofNoofShare= Convert.ToDecimal(result);


            }
            catch (Exception Ex)
            {
                AppMessageBox.ShowExclamation(Ex.Message);
                DataObj.CloseConnection();
            }
            finally
            {
                DataObj.CloseConnection();
            }
            return SumOfBegningBalaceofNoofShare;



        
         

     }

     public static decimal GetSumofWeightedShareNoPaidDuringTheBugetYear(string fiscalYear)
     {

         decimal SumOfBegningBalaceofNoofShare = 0;
         string CmdText = "";

         clDatacon DataObj = new clDatacon(clMain.ConnString);



         try
         {
             DataObj.OpenConnection();
             object result;
             CmdText = "select SUM(paidUpNoofShare)as begningSumofPaidupNo from tblShareRegBookYtd where  FiscalYear='" + fiscalYear + "'";
             result = DataObj.GetDataScalar(CmdText);
             if (result != null)
                 SumOfBegningBalaceofNoofShare = Convert.ToDecimal(result);


         }
         catch (Exception Ex)
         {
             AppMessageBox.ShowExclamation(Ex.Message);
             DataObj.CloseConnection();
         }
         finally
         {
             DataObj.CloseConnection();
         }
         return SumOfBegningBalaceofNoofShare;






     }
     
     #endregion

    }

   
}
