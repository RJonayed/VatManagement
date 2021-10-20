using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;


namespace POS
{
    public partial class MDIParent1 : Form
    {
        ClsMain SvCls = new ClsMain();
        ODBCManager odbcMgr = new ODBCManager();

        public MDIParent1()
            {
                InitializeComponent();
                txtUId1.Focus();
            }

        private void designationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SecurityAssign();

            frmSetting Setting = new frmSetting();
            Setting.MdiParent = this;
            Setting.Show();
           
              
            }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void SecurityAssign()
        {
            ClsMain SvCls = new ClsMain();


            string Qry = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' ";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.Sewing = Convert.ToBoolean(SvCls.GblRdrToGetData["Sw"]);
                    ClsVar.Knitting = Convert.ToBoolean(SvCls.GblRdrToGetData["Kn"]);
                    ClsVar.HRM = Convert.ToBoolean(SvCls.GblRdrToGetData["HRM"]);
                }

            }


            SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN ='HR REPORT'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ClsVar.VwHrReport = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);

            }

            SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN ='ID CARD'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ClsVar.VwIDCard = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);

            }

            SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN ='PROJECT INFO'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ClsVar.SaveProject = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                ClsVar.DelProject = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                ClsVar.VwProject = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
            }

            SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN ='REQUISITION INFO'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ClsVar.SaveRequisition = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                ClsVar.DelRequisition = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                ClsVar.VwRequisition = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
            }


            SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN like 'line%'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ClsVar.SaveLine = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                ClsVar.DelLine = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                ClsVar.VwLine = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                ClsVar.EdtLine = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                
            }

            SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN like 'accounts%'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ClsVar.SaveAccount = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                ClsVar.DelAccount = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                ClsVar.VwAccount = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                ClsVar.EdtAccount = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                ClsVar.SaveVoucher = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                
                
            }

            SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN like 'head creat%'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ClsVar.SaveChartOfAc = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                ClsVar.DelChartOfAc = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                ClsVar.VwChartOfAc = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                ClsVar.EdtChartOfAc = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                ClsVar.SaveAccHead = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                ClsVar.DelAccHead  = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                
                

            }

            
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='DOLLER RATE ENTRY'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveDollarRate = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelDollarRate = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwDollarRate = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);

                }


           
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN in ('CLIENT INFO','party information')");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveClient = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelClient = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwClient = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);

                }

           
            string QryItemInOutReturn = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='ITEM IN OUT AND RETURN INFO'";
            if (SvCls.DataExist(QryItemInOutReturn) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='ITEM IN OUT AND RETURN INFO'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveItemInOutReturn = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelItemInOutReturn = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwItemInOutReturn = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    
                }

            }


            string QryEmpInfo = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='EMPLOYEE INFORMATION'";
            if (SvCls.DataExist(QryEmpInfo) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='EMPLOYEE INFORMATION'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveEmployeeInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelEmployeeInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwEmployeeInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtEmployeeInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }

            }

            string QryEmpEdu = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='EMPLOYEE EDUCATION'";
            if (SvCls.DataExist(QryEmpEdu) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='EMPLOYEE EDUCATION'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveEducationInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelEducationInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwEducationInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtEducationInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);

                }

            }

            string QryEmpExp = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='EMPLOYEE EXPIRIENCE'";
            if (SvCls.DataExist(QryEmpExp) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='EMPLOYEE EXPIRIENCE'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveEmpExpInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelEmpExpInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwEmpExpInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtEmpExpInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }

            }

            string QryGlobalSetup = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='GLOBAL SETUP'";
            if (SvCls.DataExist(QryGlobalSetup) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='GLOBAL SETUP'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveGlobalSetup = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.VwGlobalSetup = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);

                }

            }



            string QryPullData = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='PULL DATA'";
            if (SvCls.DataExist(QryPullData) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='PULL DATA'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SavePullData = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    
                }

            }


            string QryDBBackup = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='BACKUP DATABASE'";
            if (SvCls.DataExist(QryDBBackup) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='BACKUP DATABASE'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveDatabaseBackup = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.VwDatabaseBackup = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                }
            }

            string QryUser = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='USER CREATION'";
            if (SvCls.DataExist(QryUser) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='USER CREATION'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveUserCreation = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.VwUserCreation = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);

                }
            }

            string QryPassword = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='CHANGE PASSWORD'";
            if (SvCls.DataExist(QryPassword) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='CHANGE PASSWORD'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SavePasswordChange = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.VwPasswordChange = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                }
            }
            string QrySection = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='SECTION'";
            if (SvCls.DataExist(QrySection) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='SECTION'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveSection = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelSection = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwSection = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtSection = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }
            }

            string QryDesignation = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='DESIGNATION'";
            if (SvCls.DataExist(QryDesignation) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='DESIGNATION'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveDesignation = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelDesignation = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwDesignation = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtDesignation = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);

                }

            }
            string QrySiftingTime = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='SHIFTING TIME SETUP'";
            if (SvCls.DataExist(QrySiftingTime) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='SHIFTING TIME SETUP'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveSiftingTime = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelSiftingTime = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.EdtSiftingTime = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                    ClsVar.VwSiftingTime = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                }

            }

            string QryBrance = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='BRANCH'";
            if (SvCls.DataExist(QryBrance) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='BRANCH'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveBrance = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelBrance = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwBrance = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtBrance = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }
            }

            string QryMachinCreation = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='MACHINE CREATION'";
            if (SvCls.DataExist(QryMachinCreation) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='MACHINE CREATION'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveMachineCreation = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelMachineCreation = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.EdtMachineCreation = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                    ClsVar.VwMachineCreation = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);

                }

            }

            string QryMaterialType = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='MATERIAL TYPE'";
            if (SvCls.DataExist(QryMaterialType) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='MATERIAL TYPE'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveMaterialType = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelMaterialType = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwMaterialType = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtMaterialType = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }
            }

            string QryUnitCreation = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='UNIT CREATION'";
            if (SvCls.DataExist(QryUnitCreation) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='UNIT CREATION'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveUnitInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelUnitInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwUnitInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtUnitInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);

                }

            }

            string QryMachineDetails = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='MACHINE DETAILS'";

            if (SvCls.DataExist(QryMachineDetails) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='MACHINE DETAILS'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveMachineDetails = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelMachineDetails  = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwMachineDetails = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtMachinDetails = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);

                }
            }

           SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN like 'sale%'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveNcrCreation = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelNcrCreation = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwNcrCreation = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtNcrCreation = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }


           
            string QrySecuirity = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN in ('SECURITY UPDATE','SECURITY')";

            //if (SvCls.DataExist(QrySecuirity) == "1")
            //{
            SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN in ('SECURITY UPDATE','SECURITY')");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveSecurity = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.VwSecurity = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtSecurity = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }
            //}

            string QryDailyAttn = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='DAILY ATTENDANCE'";
            if (SvCls.DataExist(QryDailyAttn) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='DAILY ATTENDANCE'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveDailyAttn = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelDailyAttn = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.EdtDailyAttn = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                    ClsVar.VwDailyAttn = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                }

            }


            string QryMonthlyAttn = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='MONTHLY ATTENDANCE'";
            if (SvCls.DataExist(QryMonthlyAttn) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='MONTHLY ATTENDANCE'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveMonthlyAttn = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelMonthlyAttn = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.EdtMontlyAttn = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                    ClsVar.VwMonthlyAttn = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);


                }
            }
            string QryHoliday = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='HOLIDAY ASSIGN'";

            if (SvCls.DataExist(QryHoliday) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='HOLIDAY ASSIGN'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveHolidayAssign = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelHolidayAssign = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.EdtHolidayAssign = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                    ClsVar.VwHolidayAssign = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                }
            }

            string QryLeaveTrn = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN IN ('LEAVE ENTRY','LEAVE TRANSACTION')";
            if (SvCls.DataExist(QryLeaveTrn) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN in ('LEAVE ENTRY','LEAVE TRANSACTION')");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveLeaveTransaction = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelLeaveTransaction = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwLeaveTransaction = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtLeaveTransaction = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }
            }

            string QryAdvance = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='ADVANCE'";

            if (SvCls.DataExist(QryAdvance) == "1")
            {
                SvCls.toGetData("select * from security where uid=" + ClsVar.GblUserId + " and SCREEN ='ADVANCE'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveAdvance = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelAdvance = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwAdvance = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtAdvance = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);

                }

            }
            string QryAdvanceDetails = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='ADVANCE DETAILS'";
            if (SvCls.DataExist(QryAdvanceDetails) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='ADVANCE DETAILS'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveAdvanceDetails = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelAdvanceDetails = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwAdvanceDetails = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtAdvanceDetails = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }
            }
            

                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='SALARY INCREMENT'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveSalaryIncrement = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelSalaryIncrement = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.EdtSalaryIncrement = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                    ClsVar.VwSalaryIncrement = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                }
            
            string QryEranleave = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='EARN LEAVE'";
            if (SvCls.DataExist(QryEranleave) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='EARN LEAVE'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveEarnLeave = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.VwEarnLeave = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);

                }

            }


                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN like 'MONTHLY SALARY%'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveSalaryReport = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.VwSalaryReport = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);

                }
            

                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN in ('ITEM INFORMATION','MASTER STOCK')");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveMasterStock = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelMasterStock = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwMasterStock = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtMasterStock = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }

                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN LIKE 'PURCHASE%'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SavePurchase = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelPurchase = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.vwPurchase = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtPurchase = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                }
            
            string QryEvaluation = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='EVALUATION'";

            if (SvCls.DataExist(QryEvaluation) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='EVALUATION'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveEvaluation = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelEvaluation = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwEvaluation = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtEvaluation = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);

                }
            }

            string QryConsumption = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='CONSUMPTION'";
            if (SvCls.DataExist(QryConsumption) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='CONSUMPTION'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveConsumption = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelConsumption = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.VwConsumption = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                    ClsVar.EdtConsumption = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);

                }
            }


                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN like 'Sale%'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveSale = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelSale = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.EdtSale = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                    ClsVar.VwSale = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                }

            string QryProductOut = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='PRODUCT RETURN'";
            if (SvCls.DataExist(QryProductOut) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='PRODUCT RETURN'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveProductReturn = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelProductReturn = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.EdtProductReturn = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                    ClsVar.VwProductReturn = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                }
            }
            string QryProduction = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='PRODUCTION INFO'";
            if (SvCls.DataExist(QryProduction) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='PRODUCTION INFO'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveProductionInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelProductionInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.EdtProductionInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                    ClsVar.VwProductionInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);
                }

            }
            string QryDelivery = "select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='DELIVERY'";
            if (SvCls.DataExist(QryDelivery) == "1")
            {
                SvCls.toGetData("select * from security where uid='" + ClsVar.GblUserId + "' and comid='" + ClsVar.GblComId + "' and SCREEN='DELIVERY'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.SaveDelivaryInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["s"]);
                    ClsVar.DelDelivaryInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["d"]);
                    ClsVar.EdtDelivaryInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["e"]);
                    ClsVar.VwDelivaryInfo = Convert.ToBoolean(SvCls.GblRdrToGetData["v"]);

                }

            }

        }
        
        private void MDIParent1_Load(object sender, EventArgs e)
            {
            
                this.Width = 551;
                this.Height = 309;
                this.pnlPwd1.Location = new System.Drawing.Point(0, 0);

                this.ControlBox = Visible = false;
                this.menuStrip.Visible = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;

                SetDateFormat();

            StreamReader sr = new StreamReader(Application.StartupPath + "\\check.txt");
            ClsVar.ServerName = sr.ReadLine();
            ClsVar.DataBaseName = sr.ReadLine();
            ClsVar.SqlPassword = sr.ReadLine();
            ClsVar.SqlUId = sr.ReadLine();
            ClsVar.gblPwdFroShow = sr.ReadLine();
            ClsVar.directPrint = sr.ReadLine();
            sr.Close();

            //ClsVar.ServerName = "119.18.147.47,49170\\MSSQL2012";
            //ClsVar.DataBaseName = "ROFASHA";
            //ClsVar.SqlPassword = "Asdf@1234";
            //ClsVar.SqlUId = "sa";

            ClsMain SvCls = new ClsMain();

                string Qry = "Select Name From branch order by Name";
                CboComName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                CboComName.DisplayMember = "Name";
                cboComId.DisplayMember = "Name";
                


                SvCls.toGetData("select name,comid,address from branch");
                if (SvCls.GblRdrToGetData.Read())
                {
                    lebLiscensedTo.Text = SvCls.GblRdrToGetData["name"].ToString();
                    CboComName.Text = SvCls.GblRdrToGetData["name"].ToString();
                    lblComName.Text = SvCls.GblRdrToGetData["name"].ToString();
                    ClsVar.GblComId = SvCls.GblRdrToGetData["comid"].ToString();
                    ClsVar.GblComName = SvCls.GblRdrToGetData["name"].ToString();
                    ClsVar.GblAddress  = SvCls.GblRdrToGetData["address"].ToString();
                }
                else
                {
                    return;
                }




                //Qry = "Select Name From branch order by Name";
                //cboComId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                //cboComId.DisplayMember = "Name";
                //cboComId.DisplayMember = "Name";



                //SvCls.toGetData("select * from branch");
                //if (SvCls.GblRdrToGetData.Read())
                //{
                //    ClsVar.GblComName = SvCls.GblRdrToGetData["name"].ToString();
                //    ClsVar.GblAddress = SvCls.GblRdrToGetData["address"].ToString();
                //    ClsVar.GblPhone = SvCls.GblRdrToGetData["Phone"].ToString();
                //    ClsVar.GblEmail = SvCls.GblRdrToGetData["Email"].ToString();
                //    ClsVar.GblComId = SvCls.GblRdrToGetData["ComId"].ToString();
                //}

                SvCls.toGetData("select host_name()");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.GblPcName = SvCls.GblRdrToGetData[""].ToString();
                }

                this.Text = "ERP System For " + ClsVar.GblComName + " (Connected to " + ClsVar.ServerName + ") (" + ClsVar.GblUserId + ")";
                            
            

   }
        
        private void SecurityUpdate()
        {
            ClsMain SvCls = new ClsMain();

            try
            {
                string Qry = "select * from Branch where Name='" + cboComId.Text + "'";
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("SELECT CodeNo,Name,Address,Phone From Branch where Name='" + cboComId.Text + "'");
                    if (SvCls.GblRdrToGetData.Read())
                        {
                            ClsVar.GblComId = SvCls.GblRdrToGetData["CodeNo"].ToString();
                            ClsVar.GblComName = SvCls.GblRdrToGetData["Name"].ToString();
                            ClsVar.GblAddress = SvCls.GblRdrToGetData["Address"].ToString();
                            ClsVar.GblPhone = SvCls.GblRdrToGetData["Phone"].ToString();
                            SvCls.GblCon.Close();
                        }

                }
            }
            catch (Exception)
            {

            }
        }

        private void holidayAssignToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
               
        private void leaveTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        
        private void dailyAttendancePullingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SecurityUpdate();
            //frmDailyAttn DailyAttn = new frmDailyAttn();
            //DailyAttn.MdiParent = this;
            //DailyAttn.Show();
        }

        private void initiliazationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void advanceDeductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnRef_Click(object sender, EventArgs e)
        {
            ClsMain SvCls = new ClsMain();

            string Qry = "select * from Branch where Name='" + cboComId.Text.ToString() + "'";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT comid,Name,Address,Phone From Branch where Name='" + cboComId.Text.ToString() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.GblComId = SvCls.GblRdrToGetData["comid"].ToString();
                    ClsVar.GblComName = SvCls.GblRdrToGetData["Name"].ToString();
                    ClsVar.GblAddress = SvCls.GblRdrToGetData["Address"].ToString();
                    ClsVar.GblPhone = SvCls.GblRdrToGetData["Phone"].ToString();
                    SvCls.GblCon.Close();
                }
                else
                {
                    ClsVar.GblComId = "";
                    ClsVar.GblComName = "";
                    ClsVar.GblAddress = "";
                    ClsVar.GblPhone = "";
                    SvCls.GblCon.Close();
                }

            }

            ClsVar.GblComId = "";
            ClsVar.GblComName = "";
            ClsVar.GblAddress = "";
            ClsVar.GblPhone = "";

        }

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void educationToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
        }

        private void experienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void holidayAssignToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void leaveEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void monthlyAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void oDBCCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\ODBC\\odbcCreation.exe");
        }
            
        private void monthlySalaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void advanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void advanceDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void masterStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void orderDetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productInToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void productOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecurityAssign();
            if (ClsVar.VwProductionInfo == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //frmProduction prdction = new frmProduction();
                //prdction.MdiParent = this;
                //prdction.Show();
            }
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            ClsMain SvCls = new ClsMain();
            string SelectQry = "select * from Loginuser  where UserName='" + txtUId.Text.Trim() + "' and Password= '" + txtPassword.Text.Trim() + "'";

            string userid = txtUId.Text;
            string password = txtPassword.Text;

            

            try
            {

                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.GblUserId = SvCls.GblRdrToGetData["UserCode"].ToString();
                    ClsVar.GblUserName = SvCls.GblRdrToGetData["UserName"].ToString();
                    pnlPwd.Visible = false;

                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password.\r\n Make Sure about your server name:" + ClsVar.ServerName + " \r\n your database name : " + ClsVar.DataBaseName, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUId.Select();
                    return;
                }

                //SqlConnection cnn = new SqlConnection("Persist Security Info=False;User ID=sa;password='" + ClsVar.SqlPassword + "';Initial Catalog=" + ClsVar.DataBaseName + ";Data Source=" + ClsVar.ServerName);
                
                //SqlCommand cmd2 = new SqlCommand("SELECT HOST_NAME()", cnn);
                //ClsVar.GblPcName = cmd2.ExecuteScalar().ToString();

                SvCls.toGetData("select host_name()");
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.GblPcName = SvCls.GblRdrToGetData["UserCode"].ToString();

                }

            }
            catch
            {

            }

            SecurityAssign();


            if (ClsVar.Maintenance == true & ClsVar.General == true)
            {
                //fileToolStripMenuItem.Enabled = true;
                //masterInfoToolStripMenuItem.Enabled = true;
                //employeeToolStripMenuItem.Enabled = true;
                //attendanceToolStripMenuItem.Enabled = true;
                //pACKSMARTToolStripMenuItem.Enabled = true;
                //fileToolStripMenuItem.Enabled = true;
                //toolInoutSpMn.Enabled = true;
                return;

            }


            if (ClsVar.Maintenance == true)
            {
                //fileToolStripMenuItem.Enabled = false;
                ////masterInfoToolStripMenuItem.Enabled = true;
                //masterInfoToolStripMenuItem.Enabled = false;

                //employeeToolStripMenuItem.Enabled = false;
                //attendanceToolStripMenuItem.Enabled = false;
                //pACKSMARTToolStripMenuItem.Enabled = false;
                //fileToolStripMenuItem.Enabled = false;
                //toolInoutSpMn.Enabled = true;

            }

            if (ClsVar.General == true)
            {

                //fileToolStripMenuItem.Enabled = true;
                //masterInfoToolStripMenuItem.Enabled = true;
                //employeeToolStripMenuItem.Enabled = true;
                //attendanceToolStripMenuItem.Enabled = true;
                //pACKSMARTToolStripMenuItem.Enabled = true;
                //fileToolStripMenuItem.Enabled = true;
                ////toolInoutSpMn.Enabled = true;
                //toolInoutSpMn.Enabled = false;

            }
        }

        private void cmdLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDateFormat()
        {
            //using Microsoft.Win32;
            //Get Data From Text Boxes


            string DateFormat = "dd/MM/yyyy";

            //string TimeFormat = txtTimeFormat.Text.Trim();

            //string Currency = txtCurrency.Text.Trim();



            //Registry Logic

            //Open Sub key

            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);

            ///Set Values

            //rkey.SetValue("sTimeFormat", TimeFormat);

            rkey.SetValue("sShortDate", DateFormat);

            //rkey.SetValue("sCurrency", Currency);

            //Close the Registry

            rkey.Close();


        }
            
        private void itemInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
             int j = 0;
                    string SCardno = "";
                    string STimeStr = "";
                    //double salary = 0;
            double amt=0;

                   
            ClsMain cm=new ClsMain();
            cm.GblCon.Open();
                  string SelectQry = "select empid,headid,amount from empsalaryBak where empid in (select empid from employee) order by empid,headid";
                    DataSet Ds = new DataSet();
                    SqlDataAdapter Da = new SqlDataAdapter(SelectQry, cm.GblCon );
                    Da.Fill(Ds);
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        //pbar.Maximum = Ds.Tables[0].Rows.Count + 1;
                        do
                        {

                            SCardno  = Ds.Tables[0].Rows[j]["empid"].ToString();
                            STimeStr = Ds.Tables[0].Rows[j]["Headid"].ToString();
                            amt  = Convert.ToDouble( Ds.Tables[0].Rows[j]["amount"].ToString());

                            lebProcess.Text = j.ToString();
                            lebProcess.Refresh();
                            string InsertQry = "insert into empsalary(Empid,headId,amount) values('" + SCardno + "','" + STimeStr + "'," + amt  + ")";
                            cm.insertUpdate(InsertQry);
                            
                            j = j + 1;
                        } while (j < Ds.Tables[0].Rows.Count);
                        
                    }

                    
               
        }

        private void clientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void oTEditeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            //if (ClsVar.VwMasterStock == false)
            //{
            //    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //else
            ////{
            AttLogsMain oT = new AttLogsMain();
            oT.MdiParent = this;
            oT.Show();
            //}
 
        }

        private void masterStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtUId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPassword.Select();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdLogIn.Select();
            }
        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application....?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                e.Cancel = true;
            } 
        }

        private void dailyJobStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //CboComName.Text = "EVEREST SWEATERS LTD.";
            //txtUId1.Text = "LEON";
            //txtPassword1.Text = "LEONXEON";

            if(ClsVar.GblPcName == "RAFI-PC")
            {
                txtUId1.Text = "rafi";
                txtPassword1.Text = "rafi@123";
                //button3.Visible = true;
            }


            if (CboComName.Text == "")
            {
                MessageBox.Show("Please Insert Company Name.....!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtUId1.Text == "")
            {
                MessageBox.Show("Please Insert Username.....!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPassword1.Text == "")
            {
                MessageBox.Show("Please Insert Password.....!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }






            ClsMain SvCls = new ClsMain();

            SvCls.insertUpdate("update security set uid=usercode");


            string SelectQry = "select * from Loginuser  where UserName='" + txtUId1.Text.Trim() + "' and Password= '" + txtPassword1.Text.Trim() + "' and Comid='" + ClsVar.GblComId + "'";

            string userid = txtUId1.Text;
            string password = txtPassword1.Text;

            try
            {
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    ClsVar.GblUserId = SvCls.GblRdrToGetData["UserCode"].ToString();
                    ClsVar.GblUserName = SvCls.GblRdrToGetData["UserName"].ToString();
                    pnlPwd1.Visible = false;

                    ClsVar.GblFormWidth = 960;
                    ClsVar.GblFormHeight = 600;
                    this.ControlBox = Visible = true;
                    this.menuStrip.Visible = false;
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Maximized;

                    SecurityAssign();

                    //if (ClsVar.HRM == true & ClsVar.Sewing == true & ClsVar.Knitting == true)
                    //{
                    //    attendanceToolStripMenuItem.Visible = true;
                    //    employeeToolStripMenuItem.Visible = true;
                    //    sectionToolStripMenuItem.Visible = true;
                    //    return;
                    //}

                    //if (ClsVar.Sewing == true)
                    //{
                    //    attendanceToolStripMenuItem.Visible = false;
                    //    employeeToolStripMenuItem.Visible = false;
                    //    sectionToolStripMenuItem.Visible = false;
   
                    //    return;
                    //}

                    //if (ClsVar.Knitting == true)
                    //{
                    //    attendanceToolStripMenuItem.Visible = false;
                    //    employeeToolStripMenuItem.Visible = false;
                    //    sectionToolStripMenuItem.Visible = false;
                    //    return;
                    //}

                    //if (ClsVar.HRM == true)
                    //{
                    //    pACKSMARTToolStripMenuItem.Visible = false;
                    //    toolInoutSpMn.Visible = false;
                    //    return;
                    //}

                }
                else
                {

                    MessageBox.Show("Invalid Username Or Password.\r\n Make Sure about your server name:" + ClsVar.ServerName + " \r\n your database name : " + ClsVar.DataBaseName, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword1.Select();
                    return;
                }

            }
            catch
            {

            }


            lblComName.Left = 10;
            lblComName.Top = this.Height - 90;

            lblLicens.Left = 30;
            lblLicens.Top = this.Height - 110;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtUId1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPassword1.Select();
            }
        }

        private void txtPassword1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                button2_Click(null,null);
            }
        }

        private void pACKSMARTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        private void MDIParent1_Activated(object sender, EventArgs e)
        {
            CboComName.Focus();
            txtUId1.Focus();
        }

        private void txtUId1_Leave(object sender, EventArgs e)
        {
            //if (txtUId1.Text == "")
            //{
            //    MessageBox.Show("Please Insert Username.....!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

        }

        private void txtPassword1_Leave(object sender, EventArgs e)
        {

            //if (txtPassword1.Text == "")
            //{
            //    MessageBox.Show("Please Insert Password.....!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
        }

        private void iDCardPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void projectInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CboComName_Leave(object sender, EventArgs e)
        {
            ClsMain SvCls = new ClsMain();


            SvCls.toGetData("select * from branch where Name= '" + CboComName.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ClsVar.GblComName = SvCls.GblRdrToGetData["name"].ToString();
                ClsVar.GblAddress = SvCls.GblRdrToGetData["address"].ToString();
                ClsVar.GblPhone = SvCls.GblRdrToGetData["Phone"].ToString();
                ClsVar.GblEmail = SvCls.GblRdrToGetData["Email"].ToString();
                ClsVar.GblComId = SvCls.GblRdrToGetData["ComId"].ToString();
                ClsVar.GblComName = SvCls.GblRdrToGetData["name"].ToString();

            }

            lblComName.Text = ClsVar.GblComName;

            //string  Qry = "Select Name From branch where Comid='" + ClsVar.GblComId + "'";
            //cboComId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            //cboComId.DisplayMember = "Name";
            //cboComId.DisplayMember = "Name";
        }

        private void CboComName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtUId1.Select();
            }
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cboComId_Leave(object sender, EventArgs e)
        {
            ClsMain SvCls = new ClsMain();

            SvCls.toGetData("select * from branch where Name= '" + cboComId.Text.Trim() + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                ClsVar.GblComName = SvCls.GblRdrToGetData["name"].ToString();
                ClsVar.GblAddress = SvCls.GblRdrToGetData["address"].ToString();
                ClsVar.GblPhone = SvCls.GblRdrToGetData["Phone"].ToString();
                ClsVar.GblEmail = SvCls.GblRdrToGetData["Email"].ToString();
                ClsVar.GblComId = SvCls.GblRdrToGetData["ComId"].ToString();
            }
        }

        private void hRReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rateEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void monthlyProductionEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void iDCardPrintToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void individualAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void banglaInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnItem_Click(object sender, EventArgs e)
        {
        }

        private void itemDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnParty_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmM6_1"];
            if (openFrm == null)
            {   

                frmM6_1 purchse = new frmM6_1();
                purchse.MdiParent = this;
                purchse.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
            
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnPurchaseRtn_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmSetting"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "SECURITY", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmSetting Setting = new frmSetting();
                Setting.MdiParent = this;
                Setting.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
            
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
        }

        private void btnShowRpt_Click(object sender, EventArgs e)
        {
                      
        }

        private void lblComName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pnlPwd1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            
            
        }

        private void MDIParent1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lebFlag_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UpdateItemInfo invRpt = new UpdateItemInfo();
            //invRpt.MdiParent = this;
            invRpt.Show();

            //CashCustomer invRpt = new CashCustomer();
            ////invRpt.MdiParent = this;
            //invRpt.Show();
        }

        private void pACKSMARTToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void menuStrip_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDailyCashEntry_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            
            
        }

        private void BtnCom_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmM6_2_1"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "EMPLOYEE INFORMATION", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmM6_2_1 Warranty = new frmM6_2_1();
                Warranty.MdiParent = this;
                Warranty.Show();


            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmM6_3"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "PURCHASE INFORMATION", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmM6_3 M = new frmM6_3();
                M.MdiParent = this;
                M.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmM6_10"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "PURCHASE INFORMATION", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmM6_10 M = new frmM6_10();
                M.MdiParent = this;
                M.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmM4_3"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "PURCHASE INFORMATION", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmM4_3 M = new frmM4_3();
                M.MdiParent = this;
                M.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmSetting"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "SECURITY", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmSetting Setting = new frmSetting();
                Setting.MdiParent = this;
                Setting.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void exiltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m43ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmM4_3"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "PURCHASE INFORMATION", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmM4_3 M = new frmM4_3();
                M.MdiParent = this;
                M.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void m61ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmM6_1"];
            if (openFrm == null)
            {

                frmM6_1 purchse = new frmM6_1();
                purchse.MdiParent = this;
                purchse.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void m621ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmM6_2_1"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "EMPLOYEE INFORMATION", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmM6_2_1 Warranty = new frmM6_2_1();
                Warranty.MdiParent = this;
                Warranty.Show();


            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void m63ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmM6_3"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "PURCHASE INFORMATION", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmM6_3 M = new frmM6_3();
                M.MdiParent = this;
                M.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void m610ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmM6_10"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "PURCHASE INFORMATION", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmM6_10 M = new frmM6_10();
                M.MdiParent = this;
                M.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void messagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["sms"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "PURCHASE INFORMATION", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                sms M = new sms();
                M.MdiParent = this;
                M.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
        }

        private void dailyRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsMain cm = new ClsMain();
            Form openFrm = Application.OpenForms["frmDailyRecord"];
            if (openFrm == null)
            {
                if (cm.GetPermissionSts(ClsVar.GblUserId, "PURCHASE INFORMATION", "v") == "0")
                {
                    //ClsMain cm = new ClsMain();
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmDailyRecord Rd = new frmDailyRecord();
                Rd.MdiParent = this;
                Rd.Show();
            }
            else
            {
                openFrm.BringToFront();
            }
        }
    }
}
