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
    public partial class frmLogin : Form
    {
        private int unsuccessfulLogCount = 0;
       
        private int DateDiff = 0;

       

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            int UserID;
            string cmdTxt;
            object result;
           
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                UserID = clUser.GetUserID(this.UserNameTextBox.Text, this.PasswordTextBox.Text);
                if (UserID == -1)
                {
                    unsuccessfulLogCount++;
                    if (unsuccessfulLogCount < clMain.App.NoOfUnsuccessAttempt)
                    {
                        MessageBox.Show("Invalid user name or password \n Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.PasswordTextBox.Text = string.Empty;
                        this.PasswordTextBox.Focus();
                        return;
                    }
                    else
                    {
                        
                        Application.Exit();
                    }
                    
                }
                else
                {
                    clMain._user = new clUser(UserID);
                    if (clMain.User.UserIsLocked)
                    {
                        MessageBox.Show("Your user account is locked. Please contact your system administrator");
                        return;
                    }
                    this.Hide();



                    DataObj.OpenConnection();
                    cmdTxt = "SELECT DATEDIFF(day, PasswordChangedOn, getdate()) FROM tblusers where userName='" + clMain.User.UserName + "'";
                    result = DataObj.GetDataScalar(cmdTxt);
                    if (result != null && !Convert.IsDBNull(result))
                        DateDiff = Convert.ToInt32(result);
                    

                    if (DateDiff > clMain.App.PasswordExpiryDays)
                    {
                        if (MessageBox.Show("Your Password is expired.\n Do you want to change it now? ", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            frmChangePassword changePassword = new frmChangePassword();
                            changePassword.ShowDialog();
                        }
                        else
                        {
                            cmdTxt = "update tblusers set GraceLogin=GraceLogin+1 where userName='" + clMain.User.UserName + "'";
                            DataObj.Execute(cmdTxt);

                            cmdTxt = "select gracelogin from tblusers where userName='" + clMain.User.UserName + "'";
                            result = DataObj.GetDataScalar(cmdTxt);
                            if (result != null && !Convert.IsDBNull(result))
                            {
                                if (Convert.ToInt32(result) >= clMain.App.GraceLogins)
                                {
                                    if (clMain.User.UserName != "administrator")
                                    {
                                        DataObj.Execute("update tblusers set UserIsLocked=1 where userName='" + clMain.User.UserName + "'");
                                        return;
                                    }
                                }
                            }
                        }

                    }
                    DoPeriodEnd();
                    clMain.User.UpdateLogInStatus();
                    TakeBackupOfPreviousDayAtFirstLogin();
                    frmMDI mdi = new frmMDI(clMain.User.UserID);
                    mdi.Show();
                    this.Hide(); 
                }
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }
        public static bool DoPeriodEnd()
        {
            string cmdText;
            DateTime curDate;
            int intCurPeriod = 0;
            int curYear = 0;
            string curMonth = "0";
            int periodDiff=0;
            clDatacon DataObj = new clDatacon(clMain.ConnString);



            try
            {
                DataObj.OpenConnection();
                curDate = clUtility.GetCurrentDate();
                curYear = curDate.Year;
                curMonth = curDate.Month.ToString();
                if (curMonth.Length < 2)
                    curMonth = "0" + curMonth;
                intCurPeriod = Convert.ToInt32((curYear.ToString()+curMonth));
                //advances the current period of the application.
                periodDiff = intCurPeriod-clYearPeriod.GetCurrentPeriod();
                if(periodDiff>0)
                {
                  cmdText = "UPDATE tblApplications SET CurrentPeriod=CurrentPeriod+"+periodDiff ;
                  DataObj.Execute(cmdText);
                }

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
        private bool TakeBackupOfPreviousDayAtFirstLogin()
        {
            string cmdText = string.Empty;
            object result;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            DateTime BackupDate;
            DateTime CurrentDate;
            
            try
            {
                DataObj.OpenConnection();
                cmdText = "select BackupDate from tblDefaults";
                result = DataObj.GetDataScalar(cmdText);
                if (result != null && !Convert.IsDBNull(result))
                {

                    BackupDate = Convert.ToDateTime(result);
                }
                else
                {
                    BackupDate = Convert.ToDateTime("01/01/1900");
                }

                CurrentDate = clUtility.GetCurrentDate();

                if (CurrentDate < BackupDate)
                {
                    MessageBox.Show("Please check your Backup Date or System Date,Backup date should be earlier than System Date. \n Contact your System Administrator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (Convert.ToDateTime(CurrentDate.ToShortDateString()) > Convert.ToDateTime(BackupDate.ToShortDateString()))
                {
                    if (!clDataUtility.BackupDatabase("DayEnd"))
                    {
                        MessageBox.Show("Backup could not be completed for the Day End successfully.\n Please Advise your System Administrator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmdText = "Insert into tblSHMDumpLog(UserId ,BackupStat,Remark) values( '" + clMain.User.UserName + "','Unable to take day end backup successfully','Unable to take day end backup successfully')";
                        DataObj.Execute(cmdText);
                        cmdText = "update tblDefaults set BackupDate=getdate()";
                        DataObj.Execute(cmdText);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Backup Completed for the Day End successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmdText = "update tblDefaults set BackupDate=getdate()";
                        DataObj.Execute(cmdText);
                        return true;
                    }
                }
                else
                {
                    return true;
                }




            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        
    }
}

