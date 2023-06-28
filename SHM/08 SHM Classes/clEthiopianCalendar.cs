using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHM
{
    class clEthiopianCalendar
    {
#region Fields
        //Era definition and private data

        public  const int JD_EPOCH_OFFSET_AMETE_ALEM = -285019;
        public  const int JD_EPOCH_OFFSET_AMETE_MIHRET = 1723856;
        public  const int JD_EPOCH_OFFSET_AMETE_COPTIC = 1824665;
        public  const int JD_EPOCH_OFFSET_AMETE_GREGORIAN = 1721426;
        public  const int JD_EPOCH_OFFSET_AMETE_UNSET = -1;

        private int jdoffset = JD_EPOCH_OFFSET_AMETE_UNSET;

        private int year = -1;
        private int month = -1;
        private int day = -1;
        private bool dateIsUnset = true;
        #endregion

        #region Constructors
        //constructor
        public clEthiopianCalendar() 
        {
        }
        public clEthiopianCalendar(int year, int month, int day, int era)
        {
            this.set(year, month, day, era);
        }
        public clEthiopianCalendar(int year, int month, int day)
        {
            this.set(year, month, day);
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        public void set(int year, int month, int day, int era)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            
            this.setEra(era);
            this.dateIsUnset = false;
        }
        public void set(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.dateIsUnset = false;
        }
        public int getDay() { return day; }
        public int getMonth() { return month; }
        public int getYear() { return year; }
        public int getEra() { return jdoffset; }
        public int[] getDate()
        {
            int[] date ={ year, month, day, jdoffset };
            return date;
        }
        public void setEra(int era)
        {
            if (JD_EPOCH_OFFSET_AMETE_ALEM == era)
            {
                jdoffset = era;
            }
            jdoffset = JD_EPOCH_OFFSET_AMETE_MIHRET;
        }
        public bool isEraSet()
        {
            return (JD_EPOCH_OFFSET_AMETE_UNSET == jdoffset) ? false : true;
        }
        public void unsetEra()
        {
            jdoffset = JD_EPOCH_OFFSET_AMETE_UNSET;
        }
        public void unset()
        {
            unsetEra();
            year = -1;
            month = -1;
            day = -1;
            dateIsUnset = true;
        }
        public bool isDateSet()
        {
            return (dateIsUnset) ? false : true;
        }
        #endregion

        #region ConversioToFromEthioAndGregorian
        //conversion methods to/from the ethiopic and gregorian calendar
        public int[] ethiopicToGregorian(int era)
        {
            return ethiopicToGregorian(this.year, this.month, this.day, era);

        }
        public int[] ethiopicToGregorian(int year, int month, int day, int era)
        {
            setEra(era);
            int[] date = ethiopicToGregorian(year, month, day);
            unsetEra();
            return date;
        }
        public int[] ethiopicToGregorian()
        {
            return ethiopicToGregorian(this.year, this.month, this.day);
        }
        public int[] ethiopicToGregorian(int year, int month, int day)
        {
            if (!isEraSet())
            {
                if (year <= 0)
                {
                    setEra(JD_EPOCH_OFFSET_AMETE_ALEM);
                }
                else
                {
                    setEra(JD_EPOCH_OFFSET_AMETE_MIHRET);
                }
            }
            int jdn = ethiopicToJDN(year, month, day);
            return jdnToGregorian(jdn);
        }
        public string ethiopicToGregorian(bool format)
        {
            string result;
            int[] resDate = this.ethiopicToGregorian();
            if (format)
            {
                result = resDate[2].ToString("00") + "/" + resDate[1].ToString("00") + "/" + resDate[0].ToString("0000");
            }
            else
            {
                result = resDate[2].ToString() + "/" + resDate[1].ToString() + "/" + resDate[0].ToString();
            }
            return result;
        }

        public string  ConvertethiopicToGregorian(int year, int month, int day)
        {
            if (!isEraSet())
            {
                if (year <= 0)
                {
                    setEra(JD_EPOCH_OFFSET_AMETE_ALEM);
                }
                else
                {
                    setEra(JD_EPOCH_OFFSET_AMETE_MIHRET);
                }
            }
            int jdn = ethiopicToJDN(year, month, day);
            int [] GrgDate= jdnToGregorian(jdn);
            return GrgDate[2].ToString("00") + "/" + GrgDate[1].ToString("00") + "/" + GrgDate[0].ToString("0000");
        }

        public int[] gregorianToEthiopic()
        {
            return gregorianToEthiopic(this.year, this.month, this.day);
        }
        public int[] gregorianToEthiopic(int year, int month, int day)
        {
            int jdn = gregorianToJDN(year, month, day);
            return jdnToEthiopic(jdn, guessEraFromJDN(jdn));
        }
        public string gregorianToEthiopic(bool format)
        {
            string result;
            int[] resDate = this.gregorianToEthiopic();
            if (format)
            {
                result = resDate[2].ToString("00") + "/" + resDate[1].ToString("00") + "/" + resDate[0].ToString("0000");
            }
            else
            {
                result = resDate[2].ToString() + "/" + resDate[1].ToString() + "/" + resDate[0].ToString();
            }
            return result;
        }

        public String  ConvertgregorianToEthiopic(int year, int month, int day)
        {
            int jdn = gregorianToJDN(year, month, day);
            int [] EthDate= jdnToEthiopic(jdn, guessEraFromJDN(jdn));
            return EthDate[2].ToString("00") + "/" + EthDate[1].ToString("00") + "/" + EthDate[0].ToString("0000");
        }
        public string GetStrDate(int DayNo, int Mth, int Yr)
        {
            return DayNo.ToString("00") + "/" + Mth.ToString("00") + "/" + Yr.ToString();

        }
        public int ethiopicToJDN(int year, int month, int day)
        {
            //return (isEraSet()) ? ethiopicToJDN(year, month, day,JD_EPOCH_OFFSET_AMETE_MIHRET) : ethiopicToJDN(year, month, day, jdoffset);
            return ethiopicToJDN(year, month, day, JD_EPOCH_OFFSET_AMETE_MIHRET); 
            
        }
        public int ethiopicToJDN(int year, int month, int day, int era)
        {
            return ethCopticToJDN(year, month, day, era);   
        }
        private int ethCopticToJDN(int year,int month,int day,int era)
        {
            int jdn = (JD_EPOCH_OFFSET_AMETE_MIHRET + 365) + 365 * (year - 1) + quotient(year, 4) + 30 * month + day - 31;
            return jdn;
        }
        #endregion

        #region ConversionToFromJulianDayNumbers
        //conversion methods to/from the julian day number
        private static int nMonths = 12;
        private static int[] monthDays ={ 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int quotient(long i, long j)
        {
            return (int)Math.Floor((double)i / j);
        }
        private int mod(long i, long j)
        {
            return (int)(i - (j * quotient(i, j)));
        }
        private int guessEraFromJDN(int jdn)
        {
            return (jdn >= (JD_EPOCH_OFFSET_AMETE_MIHRET + 365)) ? JD_EPOCH_OFFSET_AMETE_MIHRET : JD_EPOCH_OFFSET_AMETE_ALEM;
        }
        private bool isGregorianLeap(int year)
        {
            return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
        }
        public int[] jdnToGregorian(int j)
        {
            int r2000 = mod((j - JD_EPOCH_OFFSET_AMETE_GREGORIAN), 730485);
            int r400 = mod((j - JD_EPOCH_OFFSET_AMETE_GREGORIAN), 146097);
            int r100 = mod(r400, 36524);
            int r4 = mod(r100, 1461);

            int n = mod(r4, 365) + 365 * quotient(r4, 1460);
            int s = quotient(r4, 1095);

            int aprime = 400 * quotient((j - JD_EPOCH_OFFSET_AMETE_GREGORIAN), 146097)
                        + 100 * quotient(r400, 36524) + 4 * quotient(r100, 1461)
                        + quotient(r4, 365) - quotient(r4, 1460) - quotient(r2000, 730484);
            int year = aprime + 1;
            int t = quotient((364 + s - n), 306);
            int month=t*(quotient(n,31)+1)+(1-t)*(quotient((5*(n-s)+13),153)+1);
            //int day=t*(n-s-31*month-quotient((3*month-2),5)+33);

            n=n+(1-quotient(r2000,730484));
            int day=n;
            
            if((r100==0)&&(n==0)&&(r400!=0))
            {
                month=12;
                day=31;
            }
            else
            {
                monthDays[2]=(isGregorianLeap(year))?29:28;
                for(int i=1;i<=nMonths;++i)
                {
                    if(n<=monthDays[i])
                    {
                        day=n;
                        break;
                    }
                    n=n-monthDays[i];
                }
            }
            int[] outVal={year,month,day};
            return outVal;
        }

        public int gregorianToJDN(int year, int month, int day)
        {
            int s = quotient(year, 4) - quotient(year - 1, 4) - quotient(year, 100) + quotient(year - 1, 100) + quotient(year, 400) - quotient(year - 1, 400);
            int t = quotient(14 - month, 12);
            int n = 31 * t * (month - 1) + (1 - t) * (59 + s + 30 * (month - 3) + quotient((3 * month - 7), 5)) + day - 1;
            int j = JD_EPOCH_OFFSET_AMETE_GREGORIAN + 365 * (year - 1) + quotient(year - 1, 4) - quotient(year - 1, 100) + quotient(year - 1, 400) + n;
            return j;
        }
        public int[] jdnToEthiopic(int jdn)
        {
            return (isEraSet())?jdnToEthiopic(jdn,jdoffset):jdnToEthiopic(jdn,guessEraFromJDN(jdn));
        }
        public int[] jdnToEthiopic(int jdn,int era)
        {
            long r = mod((jdn - era), 1461);
            long n = mod(r, 365) + 365 * quotient(r, 1460);
            int year = 4 * quotient((jdn - era), 1461) + quotient(r, 365) - quotient(r, 1460);
            int month = quotient(n, 30) + 1;
            int day = mod(n, 30) + 1;
            return new int[] { year, month, day };
        }
        public int ethiopicToJDN()
        {
             return ethiopicToJDN(this.year, this.month, this.day);
        }
        #endregion
    }
}