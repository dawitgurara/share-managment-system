using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace SHM
{
    class clCompany
    {
        #region Fields
        private int _compID;
        private string _name;
        private Address _compAddress;
        private string _TinNumber;
        private string _VATNumber;
        private DateTime _vatTinDate;
       
        private int _passwordExpiryDays;
        private int _graceLogins;
        private int _MinimumPwdLength;
        private string _dataPath;
        private int _NoOfUnsuccessAttempt;
        private string _BenefitReqPrefix;
        private int _BenefitReqNumber;
        private int _MaxDeptLevel;
        #endregion

        #region Properties
        
        public int CompID
        {
            get { return this._compID; }
        }
      
        public string Name
        {
            get { return this._name; }
        }
       
        public Address CompAddress
        {
            get { return this._compAddress; }
        }
       
        public string VatTinNumber
        {
            get { return this._TinNumber; }
        }
       
        public DateTime VatTinDate
        {
            get { return this._vatTinDate; }
        }
       
       
        public int PasswordExpiryDays
        {
            get { return this._passwordExpiryDays; }
        }
       
        public int GraceLogins
        {
            get { return this._graceLogins; }
        }

        public int MinimumPwdLength
        {
            get { return this._MinimumPwdLength; }
        }
       
        public string DataPath
        {
            get { return this._dataPath; }
        }

        public int NoOfUnsuccessAttempt
        {
            get { return this._NoOfUnsuccessAttempt; }
        }

        public string BenefitReqPref
        {
            get { return this._BenefitReqPrefix; }
        }

        public int BenefitReqNumber
        {
            get { return this._BenefitReqNumber; }
        }

        public int MaxDeptLevel
        {
            get { return this._MaxDeptLevel; }
        }
        #endregion

        #region Methods
        
        public static string GetCompanyName()
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT CompanyName FROM tblCompany";
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
        /// <summary>
        /// Returns the ID number of the company using HillMark application.
        /// </summary>
        public static int GetCompanyID()
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT CompanyID FROM tblCompany";
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
        /// <summary>
        /// Returns the path from which ELiG application is running.
        /// </summary>
        public static string GetExePath()
        {
            return Application.StartupPath;
        }
        /// <summary>
        /// Returns the path the company uses to store data.
        /// </summary>
        public static string GetDataPath()
        {
            object result;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT DataPath FROM tblDefaults";
                result = DataObj.GetDataScalar(cmdText);
                if (result != null && !Convert.IsDBNull(result))
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
        /// <summary>
        /// Initializes a new instance of the ELiG.clCompany class.
        /// </summary>
        public clCompany()
        {
            DataSet Ds;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                cmdText = "SELECT * FROM tblCompany";
                Ds = DataObj.GetDataSet(cmdText);
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    this._compID = Convert.ToInt32(Ds.Tables[0].Rows[0]["CompanyID"]);
                    this._name = Convert.ToString(Ds.Tables[0].Rows[0]["CompanyName"]);
                    this._compAddress.Country = Convert.ToString(Ds.Tables[0].Rows[0]["Country"]);
                    this._compAddress.City = Convert.ToString(Ds.Tables[0].Rows[0]["City"]);
                    this._compAddress.AddressLine1 = Convert.ToString(Ds.Tables[0].Rows[0]["AddressLine1"]);
                    this._compAddress.AddressLine2 = Convert.ToString(Ds.Tables[0].Rows[0]["AddressLine2"]);
                    this._compAddress.AddressLine3 = Convert.ToString(Ds.Tables[0].Rows[0]["AddressLine3"]);
                    this._compAddress.AddressLine4 = Convert.ToString(Ds.Tables[0].Rows[0]["AddressLine4"]);
                    this._compAddress.Telephone1 = Convert.ToString(Ds.Tables[0].Rows[0]["Telephone1"]);
                    this._compAddress.Telephone2 = Convert.ToString(Ds.Tables[0].Rows[0]["Telephone2"]);
                    this._compAddress.Fax1 = Convert.ToString(Ds.Tables[0].Rows[0]["Fax1"]);
                    this._compAddress.Fax2 = Convert.ToString(Ds.Tables[0].Rows[0]["Fax2"]);
                    this._compAddress.POBox = Convert.ToString(Ds.Tables[0].Rows[0]["POBox"]);
                    this._compAddress.Email = Convert.ToString(Ds.Tables[0].Rows[0]["Email"]);
                    this._compAddress.Website = Convert.ToString(Ds.Tables[0].Rows[0]["Website"]);
                    this._TinNumber = Convert.ToString(Ds.Tables[0].Rows[0]["TinNumber"]);
                    this._VATNumber = Convert.ToString(Ds.Tables[0].Rows[0]["VatNumber"]);
                    if(!Convert.IsDBNull(Ds.Tables[0].Rows[0]["VatNumber"]))
                        this._vatTinDate = Convert.ToDateTime(Ds.Tables[0].Rows[0]["VatTinDate"]);
                   
                 

                    cmdText = "SELECT * FROM tblDefaults";
                    Ds = DataObj.GetDataSet(cmdText);
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        this._passwordExpiryDays = Convert.ToInt32(Ds.Tables[0].Rows[0]["PasswordExpiryDays"]);
                        this._graceLogins = Convert.ToInt32(Ds.Tables[0].Rows[0]["GraceLogins"]);
                        this._MinimumPwdLength = Convert.ToInt16(Ds.Tables[0].Rows[0]["MinimumPwdLength"]);
                        this._NoOfUnsuccessAttempt = Convert.ToInt16(Ds.Tables[0].Rows[0]["NoOfUnsuccessAttempt"]);
                        
                    }
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
        #endregion
    }

    /// <summary>
    /// Provides attributes to represent address of an object.
    /// </summary>
    public struct Address
    {
        public string Country;
        public string City;
        public string AddressLine1;
        public string AddressLine2;
        public string AddressLine3;
        public string AddressLine4;
        public string Telephone1;
        public string Telephone2;
        public string Fax1;
        public string Fax2;
        public string POBox;
        public string Email;
        public string Website;
    }

}