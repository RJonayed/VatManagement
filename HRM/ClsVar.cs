using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;



namespace POS
{
    public class ClsVar
    {
        public string BaseUrl { get; set; }
        public static string directPrint;

        public static string GblFindName;
        public static string GblHide;
        public static Int32 empAutoNo;
        public static string SqlUId;
        public static string GblMasterStockPageBreak;
        public static Boolean GblBarcode;
        public static string GblOP;
        public static string GblP;
        public static string GblC;

        public static string GblHrFrom;
        public static string GblMntFrom;
        public static string GblScndFrom;
        public static string GblEmpId = "";
        public static string GblHrTo;
        public static string GblMntTo;
        public static string GblScndTo;

        public static string GblFormulaFld1;
        public static string GblFormulaFld2;
        public static string GblFormulaFld3;

        public static Boolean SaveProject;
        public static Boolean DelProject;
        public static Boolean VwProject;

        public static Boolean VwHrReport;

        public static Boolean SaveRequisition;
        public static Boolean DelRequisition;
        public static Boolean VwRequisition;

    public static string GblRptDate;
    public static string  BackPicPath;
    public static Boolean SaveClient;
    public static Boolean DelClient;
    public static Boolean VwClient;
    public static Boolean SaveVoucher;
    public static Boolean General;
    public static Boolean Maintenance;

    public static Boolean HRM;
    public static Boolean Knitting;
    public static Boolean Sewing;

    public static Int32 GblEmpAutoNo;
    public static Boolean SaveDollarRate;
    public static Boolean DelDollarRate;
    public static Boolean VwDollarRate;
    public static double GblClosBalForLadger = 0;
    public static Boolean SaveAccHead;
    public static Boolean DelAccHead;
    //public static string cnString = "Persist Security Info=False;Password=ppl;Initial Catalog=HRM;Data Source=NUR";
    public static string GblRptHead1;
    public static string GblRptHead2;
    //public static string GblSelFor;
    public static double GblOpBalForLadger = 0;
    public static string GblSelFor;
    public static string GblRptName;
    public static string GblRptHead;
    public static string GblComName;
    public static string GblAddress;
    public static string GblPhone;
    public static string GblEmail;
    public static string GblHeadName;
    public static string GblPcName;
    public static string GblUserId;
    public static string GblUserName;
    public static string GblComId;
    public static string SqlPassword;
    public static string ServerName;
    public static string DataBaseName;
    public static string FileName;
    public static string FilePath;
    public static string GblFrmBackColor;
    public static Int32 GblFormWidth;
    public static Int32 GblFormHeight;
    public static Int32 GblMonthNo;
    public static Int32 GblMonthDays;
    public static Int32 GblDiffDays;
    public static string  GblFDate;
    public static string  GblLDate;
    public static Int32 GblVarForTimer;
   //---------------------for security-------------

    public static Boolean VwIDCard;
    public static Boolean SaveEmployeeInfo;
    public static Boolean DelEmployeeInfo;
    public static Boolean VwEmployeeInfo;
    public static Boolean EdtEmployeeInfo;

    public static Boolean SaveChartOfAc;
    public static Boolean DelChartOfAc;
    public static Boolean VwChartOfAc;
    public static Boolean EdtChartOfAc;

    public static Boolean SaveAccount;
    public static Boolean DelAccount;
    public static Boolean VwAccount;
    public static Boolean EdtAccount;

    public static string gblPwdFroShow;
    public static Boolean SaveEducationInfo;
    public static Boolean DelEducationInfo;
    public static Boolean VwEducationInfo;
    public static Boolean EdtEducationInfo;

    public static Boolean SaveEmpExpInfo;
    public static Boolean DelEmpExpInfo;
    public static Boolean VwEmpExpInfo;
    public static Boolean EdtEmpExpInfo;
   
    public static Boolean SaveSection;
    public static Boolean DelSection;
    public static Boolean VwSection;
    public static Boolean EdtSection;

    public static Boolean SaveDesignation;
    public static Boolean DelDesignation;
    public static Boolean VwDesignation;
    public static Boolean EdtDesignation;

    public static Boolean SaveLine;
    public static Boolean DelLine;
    public static Boolean VwLine;
    public static Boolean EdtLine;

    public static Boolean SaveBrance;
    public static Boolean DelBrance;
    public static Boolean VwBrance;
    public static Boolean EdtBrance;

    public static Boolean SaveMachineCreation;
    public static Boolean DelMachineCreation;
    public static Boolean VwMachineCreation;
    public static Boolean EdtMachineCreation;

    public static Boolean SaveMaterialType;
    public static Boolean DelMaterialType;
    public static Boolean VwMaterialType;
    public static Boolean EdtMaterialType;

    public static Boolean SaveUnitInfo;
    public static Boolean DelUnitInfo;
    public static Boolean VwUnitInfo;
    public static Boolean EdtUnitInfo;

    public static Boolean SaveMachineDetails;
    public static Boolean DelMachineDetails;
    public static Boolean VwMachineDetails;

    public static Boolean EdtMachinDetails;

    public static Boolean SaveNcrCreation;
    public static Boolean DelNcrCreation;
    public static Boolean VwNcrCreation;
    public static Boolean EdtNcrCreation;

    public static Boolean SaveSecurity;
    public static Boolean VwSecurity;
    public static Boolean EdtSecurity;

    public static Boolean SaveSiftingTime;
    public static Boolean DelSiftingTime;
    public static Boolean VwSiftingTime;
    public static Boolean EdtSiftingTime;

    public static Boolean SaveDatabaseBackup;
    public static Boolean VwDatabaseBackup;

    public static Boolean SaveUserCreation;
    public static Boolean EdtUserCreation;
    public static Boolean VwUserCreation;

    public static Boolean SaveGlobalSetup;
    public static Boolean VwGlobalSetup;

    public static Boolean SavePasswordChange;
    public static Boolean VwPasswordChange;

    public static Boolean SaveProductionInfo;
    public static Boolean DelProductionInfo;
    public static Boolean VwProductionInfo;
    public static Boolean EdtProductionInfo;

    public static Boolean SaveDelivaryInfo;
    public static Boolean DelDelivaryInfo;
    public static Boolean VwDelivaryInfo;
    public static Boolean EdtDelivaryInfo;

    public static Boolean SaveSale;
    public static Boolean DelSale;
    public static Boolean VwSale;
    public static Boolean EdtSale;

    public static Boolean SaveProductReturn;
    public static Boolean DelProductReturn;
    public static Boolean VwProductReturn;
    public static Boolean EdtProductReturn;

    public static Boolean SaveDailyAttn;
    public static Boolean DelDailyAttn;
    public static Boolean VwDailyAttn;
    public static Boolean EdtDailyAttn;

    public static Boolean SaveMonthlyAttn;
    public static Boolean DelMonthlyAttn;
    public static Boolean VwMonthlyAttn;
    public static Boolean EdtMontlyAttn;

    public static Boolean SaveHolidayAssign;
    public static Boolean DelHolidayAssign;
    public static Boolean VwHolidayAssign;
    public static Boolean EdtHolidayAssign;


    public static Boolean SaveLeaveTransaction;
    public static Boolean DelLeaveTransaction;
    public static Boolean VwLeaveTransaction;
    public static Boolean EdtLeaveTransaction;

    public static Boolean SaveAdvance;
    public static Boolean DelAdvance;
    public static Boolean VwAdvance;
    public static Boolean EdtAdvance;

    public static Boolean SaveAdvanceDetails;
    public static Boolean DelAdvanceDetails;
    public static Boolean VwAdvanceDetails;
    public static Boolean EdtAdvanceDetails;

    public static Boolean SaveSalaryIncrement;
    public static Boolean DelSalaryIncrement;
    public static Boolean VwSalaryIncrement;
    public static Boolean EdtSalaryIncrement;

    public static Boolean SaveMasterStock;
    public static Boolean DelMasterStock;
    public static Boolean VwMasterStock;
    public static Boolean EdtMasterStock;

    public static Boolean SavePurchase;
    public static Boolean DelPurchase;
    public static Boolean vwPurchase;
    public static Boolean EdtPurchase;

    public static Boolean SaveEvaluation;
    public static Boolean DelEvaluation;
    public static Boolean VwEvaluation;
    public static Boolean EdtEvaluation;

    public static Boolean SaveConsumption;
    public static Boolean DelConsumption;
    public static Boolean VwConsumption;
    public static Boolean EdtConsumption;

    public static Boolean VwEarnLeave;
    public static Boolean SaveEarnLeave;

    public static Boolean VwSalaryReport;
    public static Boolean SaveSalaryReport;

    public static Boolean vwPurchaseInfo;

    public static Boolean SavePullData;


    public static Boolean SaveItemInOutReturn;
    public static Boolean DelItemInOutReturn;
    public static Boolean VwItemInOutReturn;
    public static Boolean EdtSaleOutReturn;

    public static string EditSts;

        public static int CmnFormHeight = 655;
        public static int CmnFormWidth = 1100;

        public static int CmnLeftPos = 220;
        public static int CmnUpperPos = 20;

        //form Back Color
        public static int R = 227;
        public static int G = 242;
        public static int B = 254;









    }

 }


