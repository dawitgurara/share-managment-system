using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SHM
{
    public class clSecurity
    {
        #region Methods
        public static bool UpdateMenuDefinition(MenuStrip ms)
        {
           
            string menuName, menuDesc;
            string tab1 = "    ", tab2 = "        ", tab3 = "            ";
            int pos;
            int seqNo = 0;
            string cmdText, cmdInsert;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();

               

                cmdInsert = "INSERT INTO tblMenuDef(MenuName, Description,GroupCode, Depth, Granted) VALUES(";

                DataObj.Execute("UPDATE tblMenuDef SET GroupCode=9999");

                //Create the main menu Items from the menustrip (leve-0)
                for (int i = 0; i < ms.Items.Count; i++)
                {
                    seqNo++;
                    ToolStripMenuItem mi = (ToolStripMenuItem)ms.Items[i];
                    menuName = mi.Name;
                    menuDesc = mi.Text;
                    pos = menuDesc.IndexOf('&');
                    if (pos != -1)
                        menuDesc = mi.Text.Remove(pos, 1);
                    else
                        menuDesc = mi.Text;

                    if (DataObj.GetValue("tblMenuDef", "MenuName", "MenuName='" + menuName+"'") == null)
                        cmdText = cmdInsert +  "'" + menuName + "','" + menuDesc + "'," + seqNo + ", 0, NULL)";
                    else
                        cmdText = "UPDATE tblMenuDef SET Description='" + menuDesc + "',GroupCode=" + seqNo + ",Depth=0 WHERE MenuName='" + menuName+"'";
                    DataObj.Execute(cmdText);

                    //Create sub menu items for each menu (level-1)
                    for (int j = 0; j < mi.DropDown.Items.Count; j++)
                    {
                        if (mi.HasDropDownItems)
                        {
                            if (!(mi.DropDown.Items[j] is ToolStripSeparator))
                            {
                                seqNo++;
                                ToolStripMenuItem mi1 = (ToolStripMenuItem)mi.DropDown.Items[j];
                                menuName = mi1.Name;
                                menuDesc = mi1.Text;
                                pos = menuDesc.IndexOf('&');
                                if (pos != -1)
                                    menuDesc = mi1.Text.Remove(pos, 1);
                                else
                                    menuDesc = mi1.Text;

                                if (DataObj.GetValue("tblMenuDef", "MenuName", "MenuName='" + menuName+"'") == null)
                                    cmdText = cmdInsert + "'" + menuName + "','" + tab1 + menuDesc + "'," + seqNo + ", 1, NULL)";
                                else
                                    cmdText = "UPDATE tblMenuDef SET Description='" + tab1 + menuDesc + "',GroupCode=" + seqNo + ",Depth=1 WHERE MenuName='" + menuName+"'";
                                DataObj.Execute(cmdText);

                                //Create sub-sub menu items from the sub menu items (level-2)
                                for (int k = 0; k < mi1.DropDown.Items.Count; k++)
                                {
                                    if (mi1.HasDropDownItems)
                                    {
                                        if (!(mi1.DropDown.Items[k] is ToolStripSeparator))
                                        {
                                            seqNo++;
                                            ToolStripMenuItem mi2 = (ToolStripMenuItem)mi1.DropDown.Items[k];
                                            menuName = mi2.Name.ToString();
                                            menuDesc = mi2.Text.ToString();
                                            pos = menuDesc.IndexOf('&');
                                            if (pos != -1)
                                                menuDesc = mi2.Text.ToString().Remove(pos, 1);
                                            else
                                                menuDesc = mi2.Text.ToString();

                                            if (DataObj.GetValue("tblMenuDef", "MenuName", "MenuName='" + menuName+"'") == null)
                                                cmdText = cmdInsert + "'" + menuName + "','" + tab2 + menuDesc + "'," + seqNo + ", 2, NULL)";
                                            else
                                                cmdText = "UPDATE tblMenuDef SET Description='" + tab2 + menuDesc + "',GroupCode=" + seqNo + ",Depth=2 WHERE MenuName='" + menuName+"'" ;
                                            DataObj.Execute(cmdText);
                                            //create the sub-sub-sub menu items from sub-sub menu item (level-3)
                                            for (int l = 0; l < mi2.DropDown.Items.Count; l++)
                                            {
                                                if (mi2.HasDropDownItems)
                                                {
                                                    if (!(mi2.DropDown.Items[l] is ToolStripSeparator))
                                                    {
                                                        seqNo++;
                                                        ToolStripMenuItem mi3 = (ToolStripMenuItem)mi2.DropDown.Items[l];
                                                        menuName = mi3.Name.ToString();
                                                        menuDesc = mi3.Text.ToString();
                                                        pos = menuDesc.IndexOf('&');
                                                        if (pos != -1)
                                                            menuDesc = mi3.Text.ToString().Remove(pos, 1);
                                                        else
                                                            menuDesc = mi3.Text.ToString();

                                                        if (DataObj.GetValue("tblMenuDef", "MenuName", "MenuName='" + menuName+"'") == null)
                                                            cmdText = cmdInsert + "'" + menuName + "','" + tab3 + menuDesc + "'," + seqNo + ", 3, NULL)";
                                                        else
                                                            cmdText = "UPDATE tblMenuDef SET Description='" + tab3 + menuDesc + "',GroupCode=" + seqNo + ",Depth=3 WHERE MenuName='" + menuName+"'" ;
                                                        DataObj.Execute(cmdText);
                                                    }
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }

                DataObj.Execute("Delete from tblMenuDef where GroupCode=9999");
                MessageBox.Show("Menu Definition setup Completed Successfully");
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

        public static bool AssignApplicationRights(int userID, ToolStripMenuItem appMenu)
        {
            SqlDataReader Dr;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                HideApplicationMenus(appMenu);

                DataObj.OpenConnection();
                cmdText = "SELECT MenuName FROM tblApplications WHERE AppID IN (" + clUser.GetUserApplications(userID) + ") AND IsActive=1";
                Dr = DataObj.GetReader(cmdText);

                while (Dr.Read())
                {
                    for (int i = 0; i < appMenu.DropDownItems.Count - 3; i++)
                    {
                        if (Dr["MenuName"].ToString() == appMenu.DropDownItems[i].Name)
                            appMenu.DropDownItems[i].Visible = true;
                    }
                }
                Dr.Close();
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

        private static void HideApplicationMenus(ToolStripMenuItem appMenu)
        {
            for (int i = 0; i < appMenu.DropDownItems.Count - 3; i++)
            {
                appMenu.DropDownItems[i].Visible = false;
            }
        }

        public static bool AssignMenuRights(int userID,  ref MenuStrip ms)
        {
            SqlDataReader Dr;
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                if (userID == 1)
                    return true;
                else
                    SetMenuEnable(ms, false);

                DataObj.OpenConnection();
                cmdText = "SELECT MenuName FROM tblMenuDef WHERE CodeNo IN (" + clUser.GetMenuRights(userID) + ") AND Visible=1";
                Dr = DataObj.GetReader(cmdText);

                while (Dr.Read())
                {
                    foreach (ToolStripMenuItem mi in ms.Items)
                    {
                        if (Dr["MenuName"].ToString() == mi.Name || userID == 1)
                            mi.Enabled = true;
                        if (mi.HasDropDownItems)
                        {
                            for (int i = 0; i < mi.DropDown.Items.Count; i++)
                            {
                                if (mi.DropDown.Items[i] is ToolStripMenuItem)
                                {
                                    ToolStripMenuItem mi1 = (ToolStripMenuItem)mi.DropDown.Items[i];
                                    if (Dr["MenuName"].ToString() == mi1.Name || userID == 1)
                                        mi1.Enabled = true;
                                    if (mi1.HasDropDownItems)
                                    {
                                        for (int j = 0; j < mi1.DropDown.Items.Count; j++)
                                        {
                                            if (mi1.DropDown.Items[j] is ToolStripMenuItem)
                                            {
                                                ToolStripMenuItem mi2 = (ToolStripMenuItem)mi1.DropDown.Items[j];
                                                if (Dr["MenuName"].ToString() == mi2.Name || userID == 1)
                                                    mi2.Enabled = true;
                                                if (mi2.HasDropDownItems)
                                                {
                                                    for (int k = 0; k < mi2.DropDown.Items.Count; k++)
                                                    {
                                                        if (mi2.DropDown.Items[k] is ToolStripMenuItem)
                                                        {
                                                            ToolStripMenuItem mi3 = (ToolStripMenuItem)mi2.DropDown.Items[k];
                                                            if (Dr["MenuName"].ToString() == mi3.Name || userID == 1)
                                                                mi3.Enabled = true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }

                    }
                }
                Dr.Close();
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

        private static void SetMenuEnable(MenuStrip ms, bool enabled)
        {
            foreach (ToolStripMenuItem mi in ms.Items)
            {
                if (mi.HasDropDownItems)
                {
                    for (int i = 0; i < mi.DropDown.Items.Count; i++)
                    {
                        if (!(mi.DropDown.Items[i] is ToolStripSeparator))
                        {
                            ToolStripMenuItem item = (ToolStripMenuItem)mi.DropDown.Items[i];
                            if (item.HasDropDownItems)
                            {
                                for (int j = 0; j < item.DropDown.Items.Count; j++)
                                {
                                    if (!(item.DropDown.Items[j] is ToolStripSeparator))
                                    {
                                        item.DropDown.Items[j].Enabled = enabled;
                                    }
                                }
                            }
                            mi.DropDown.Items[i].Enabled = enabled;
                        }
                    }
                }
            }
        }

        public static bool UpdateAppMenuNames(ToolStripMenuItem appMenu)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                for (int i = 0; i < appMenu.DropDownItems.Count; i++)
                {
                    if (appMenu.DropDownItems[i].Tag != null)
                    {
                        if (DataObj.GetValue("tblApplications", "AppName", "AppName='" + appMenu.DropDownItems[i].Tag.ToString() + "'") == null)
                            cmdText = "INSERT INTO tblApplications (AppName, Description, MenuName) VALUES ('" + appMenu.DropDownItems[i].Tag.ToString() + "','" + appMenu.DropDownItems[i].Text + "','" + appMenu.DropDownItems[i].Name + "')";
                        else
                            cmdText = "UPDATE tblApplications SET MenuName='" + appMenu.DropDownItems[i].Name + "' WHERE AppName='" + appMenu.DropDownItems[i].Tag.ToString() + "'";
                        DataObj.Execute(cmdText);
                    }
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

        public static string GetApplicationRoles(string app)
        {
            return "SELECT RoleID FROM tblRoles WHERE Application=" + clApplication.GetAppID();
        }

        public static bool UpdateMenuRoles(int menuCode, DataTable tblMenuRoles)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                DataObj.BeginTransaction();
                cmdText = "DELETE FROM tblMenuRoles WHERE MenuCode=" + menuCode;
                DataObj.Execute(cmdText); ;
                foreach (DataRow row in tblMenuRoles.Rows)
                {
                    if (!Convert.IsDBNull(row["Granted"]))
                    {
                        if (Convert.ToBoolean(row["Granted"]) == true)
                        {
                            cmdText = "INSERT INTO tblMenuRoles VALUES(" + menuCode + ", " + row["RoleID"] + ")";
                            DataObj.Execute(cmdText);
                        }
                    }
                }
                DataObj.CommitTransaction();
                return true;
            }
            catch (Exception Ex)
            {
                DataObj.RollbackTransaction();
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static bool UpdateAppRights(int userID, DataTable tblAppRights)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                DataObj.BeginTransaction();
                cmdText = "DELETE FROM tblAppRights WHERE User=" + userID;
                DataObj.Execute(cmdText);
                foreach (DataRow row in tblAppRights.Rows)
                {
                    if (!Convert.IsDBNull(row["Granted"]))
                    {
                        if (Convert.ToBoolean(row["Granted"]) == true)
                        {
                            cmdText = "INSERT INTO tblAppRights VALUES(" + userID + ", " + row["AppID"] + ",0 , NULL)";
                            DataObj.Execute(cmdText);
                        }
                    }
                }
                DataObj.CommitTransaction();
                return true;
            }
            catch (Exception Ex)
            {
                DataObj.RollbackTransaction();
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static bool UpdateMenuRights(int userID,  DataTable tblMenuRights)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                DataObj.BeginTransaction();
                cmdText = "DELETE FROM tblMenuRights WHERE [User]=" + userID + " AND MenuCode IN (SELECT CodeNo FROM tblMenuDef )";
                DataObj.Execute(cmdText);
                foreach (DataRow row in tblMenuRights.Rows)
                {
                    if (!Convert.IsDBNull(row["Granted"]))
                    {
                        if (Convert.ToBoolean(row["Granted"]) == true)
                        {
                            cmdText = "INSERT INTO tblMenuRights VALUES(" + userID + ", " + row["CodeNo"] + ")";
                            DataObj.Execute(cmdText);
                        }
                    }
                }
                DataObj.CommitTransaction();
                return true;
            }
            catch (Exception Ex)
            {
                DataObj.RollbackTransaction();
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static bool UpdateRoleRights(int userID,  DataTable tblRoleRights)
        {
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                DataObj.OpenConnection();
                DataObj.BeginTransaction();
                cmdText = "DELETE FROM tblRoleRights WHERE UserId=" + userID + " AND Role IN (SELECT RoleID FROM tblRoles )";
                DataObj.Execute(cmdText);
                foreach (DataRow row in tblRoleRights.Rows)
                {
                    if (!Convert.IsDBNull(row["Granted"]))
                    {
                        if (Convert.ToBoolean(row["Granted"]) == true)
                        {
                            cmdText = "INSERT INTO tblRoleRights VALUES(" + userID + ", " + row["RoleID"] + ")";
                            DataObj.Execute(cmdText);
                        }
                    }
                }
                DataObj.CommitTransaction();
                return true;
            }
            catch (Exception Ex)
            {
                DataObj.RollbackTransaction();
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static bool UpdateReportRights(int userID,  DataTable tblReportRights)
        {
           
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                
                DataObj.OpenConnection();
                DataObj.BeginTransaction();
                cmdText = "DELETE FROM tblReportRights WHERE UserId=" + userID;
                DataObj.Execute(cmdText);
                foreach (DataRow row in tblReportRights.Rows)
                {
                    if (!Convert.IsDBNull(row["Granted"]))
                    {
                        if (Convert.ToBoolean(row["Granted"]) == true)
                        {
                            cmdText = "INSERT INTO tblReportRights VALUES(" + userID + ", " + row["RepId"] + ")";
                            DataObj.Execute(cmdText);
                        }
                    }
                }
                DataObj.CommitTransaction();
                return true;
            }
            catch (Exception Ex)
            {
                DataObj.RollbackTransaction();
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static bool UpdateRemiderRights(int userID,  DataTable tblReminderRights)
        {
            
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
               
                DataObj.OpenConnection();
                DataObj.BeginTransaction();
                cmdText = "DELETE FROM tblReminderRights WHERE UserId=" + userID;
                DataObj.Execute(cmdText);
                foreach (DataRow row in tblReminderRights.Rows)
                {
                    if (!Convert.IsDBNull(row["Granted"]))
                    {
                        if (Convert.ToBoolean(row["Granted"]) == true)
                        {
                            cmdText = "INSERT INTO tblReminderRights VALUES(" + userID + ", " + row["RemId"] + ")";
                            DataObj.Execute(cmdText);
                        }
                    }
                }
                DataObj.CommitTransaction();
                return true;
            }
            catch (Exception Ex)
            {
                DataObj.RollbackTransaction();
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

        public static bool UpdateOtherParameterRights(int userID,  DataTable tblGlobalParameterRights)
        {
           
            string cmdText;
            clDatacon DataObj = new clDatacon(clMain.ConnString);
            try
            {
                
                DataObj.OpenConnection();
                DataObj.BeginTransaction();
                cmdText = "DELETE FROM tblOtherParameterRights WHERE UserId=" + userID;
                DataObj.Execute(cmdText);
                foreach (DataRow row in tblGlobalParameterRights.Rows)
                {
                    if (!Convert.IsDBNull(row["Granted"]))
                    {
                        if (Convert.ToBoolean(row["Granted"]) == true)
                        {
                            cmdText = "INSERT INTO tblOtherParameterRights VALUES(" + userID + ", " + row["Id"] + ")";
                            DataObj.Execute(cmdText);
                        }
                    }
                }
                DataObj.CommitTransaction();
                return true;
            }
            catch (Exception Ex)
            {
                DataObj.RollbackTransaction();
                MessageBox.Show(Ex.Message);
                return false;
            }
            finally
            {
                DataObj.CloseConnection();
            }
        }

      

        #endregion

    }
}