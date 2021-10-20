using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace POS
{
    class ClsMain
    {

        public SqlDataReader GblRdrToGetData;
        //public SqlConnection GblCon = new SqlConnection("Persist Security Info=False;User ID=sa;Password='';Initial Catalog='PackSmart';Data Source='NUR';");
        public SqlConnection GblCon = new SqlConnection("Persist Security Info=False;User ID=sa;Password='" + ClsVar.SqlPassword + "';Initial Catalog='" + ClsVar.DataBaseName + "';Data Source='" + ClsVar.ServerName + "';Connection Timeout=200;");
        public SqlCommand GblSqlCmd = new SqlCommand();

        public void toGetData(string QryForRetrieve)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            GblCon.Open();
            SqlCommand GblCmd = new SqlCommand(QryForRetrieve, GblCon);
            GblRdrToGetData = GblCmd.ExecuteReader();

        }

        public void toRunStoredProc(string SPName)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            GblCon.Open();
            SqlCommand GblCmd = new SqlCommand(SPName, GblCon);
            
            GblCmd.CommandType = CommandType.StoredProcedure;
            //GblCmd.Parameters.Add(new SqlParameter("@D_BaseMedia", SqlDbType.VarChar, 100));
            //GblCmd.Parameters["@D_BaseMedia"].Value = ClsVar.FileName;
            //GblCmd.Parameters.Add(new SqlParameter("@D_BasePath", SqlDbType.VarChar, 300));
            //GblCmd.Parameters["@D_BasePath"].Value = ClsVar.FilePath;
            //GblCmd.Parameters.Add(new SqlParameter("@D_BaseNAme", SqlDbType.VarChar, 30));
            //GblCmd.Parameters["@D_BaseNAme"].Value = ClsVar.DataBaseName;
            GblCmd.ExecuteNonQuery();


        }
        public string GetPermissionSts(string Uid, string scrennNm, string SEVD)
        {
            string sts = "";

            toGetData("select [" + SEVD + "] as fn from [security] where uid='" + Uid + "' and screen='" + scrennNm + "'");
            if (GblRdrToGetData.Read())
            {

                sts = GblRdrToGetData["fn"].ToString().ToLower();

                if (sts == "false" || sts == "0")
                {
                    return "0";
                }
                else
                {
                    return "1";
                }
            }
            else
            {
                return "1";
            }
        }
        public string ChkEditAvility(DateTime EntryDT)
        {
            DateTime DeniedDate = DateTime.Today;
            DateTime Today = DateTime.Today;

            string Countqry = "SELECT DATEADD(dd,3,CONVERT(DATETIME,'" + EntryDT + "',103)) as EditDenied";
            toGetData(Countqry);
            if(GblRdrToGetData.Read())
            {
                DeniedDate = Convert.ToDateTime(GblRdrToGetData["EditDenied"].ToString());
            }
            if (DeniedDate > Today)
            {
                return ClsVar.EditSts = "Yes";
                //MessageBox.Show("Permission Denied", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                return ClsVar.EditSts = "No";
            }
   
        }
        public string ChkEntryDate(DateTime EntryDT)
        {
            DateTime EntryAllowDate = DateTime.Today;
            DateTime Today = DateTime.Today;

            string Countqry = "SELECT DATEADD(dd,-3,CONVERT(DATETIME,'" + EntryDT + "',103)) as AllowDate";
            toGetData(Countqry);
            if (GblRdrToGetData.Read())
            {
                EntryAllowDate = Convert.ToDateTime(GblRdrToGetData["AllowDate"].ToString());
            }
            if (EntryDT < EntryAllowDate)
            {
                return ClsVar.EditSts = "No";
                //MessageBox.Show("Permission Denied", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                return ClsVar.EditSts = "Yes";
            }


        }
        public Boolean DateCheck(string dt)
        {
            try
            {
                DateTime DtCheck = Convert.ToDateTime(dt);
            }
            catch (Exception msk)
            {
                return false ;
            }
            return true;
        }
        public Int32 GetDateDiffDay(string FDt,string LDt)
        {

            int yFrom = Convert.ToInt32(FDt.Substring(6, 4));
            int mFrom = Convert.ToInt32(FDt.Substring(3, 2));
            int dFrom = Convert.ToInt32(FDt.Substring(0, 2));
            int yTo = Convert.ToInt32(LDt.Substring(6, 4));
            int mTo = Convert.ToInt32(LDt.Substring(3, 2));
            int dTo = Convert.ToInt32(LDt.Substring(0, 2));

            //TimeSpan ts = Convert.ToDateTime(txtToDate.Text).Subtract(Convert.ToDateTime(txtFromDate.Text));


            DateTime a = new DateTime(yFrom, mFrom, dFrom);
            DateTime b = new DateTime(yTo, mTo, dTo);
            int totDay = Convert.ToInt32(b.Subtract(a).TotalDays) + 1;
            return totDay;
        }

        public string GetDtSelFormulaForDateTwo(string FDt, string LDt)
        {

            string yFrom =FDt.Substring(6, 4);
            string mFrom = FDt.Substring(3, 2);
            string dFrom = FDt.Substring(0, 2);
            string yTo = LDt.Substring(6, 4);
            string mTo = LDt.Substring(3, 2);
            string dTo = LDt.Substring(0, 2);

            //TimeSpan ts = Convert.ToDateTime(txtToDate.Text).Subtract(Convert.ToDateTime(txtFromDate.Text));

            string frmla = "Date(" + yFrom + "," + mFrom + "," + dFrom + ") to Date(" + yTo + "," + mTo + "," + dTo + ")";
            return frmla;
        }

        public string GetDtSelFormulaForDateOne(string FDt)
        {

            string yFrom = FDt.Substring(6, 4);
            string mFrom = FDt.Substring(3, 2);
            string dFrom = FDt.Substring(0, 2);

            string frmla = "Date(" + yFrom + "," + mFrom + "," + dFrom + ")";
            return frmla;
        }
        public DataSet GblDataSet(string GblQryForCombo)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            DataSet GblDs = new DataSet();
            SqlDataAdapter GblAdp = new SqlDataAdapter(GblQryForCombo, GblCon);
            GblAdp.Fill(GblDs);
            return GblDs;
        }

        public DataTable GblDataTable(string GblQryForGrid)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            DataTable GblDt = new DataTable();
            GblCon.Open();
            SqlDataAdapter GblAdp = new SqlDataAdapter(GblQryForGrid, GblCon);
            GblAdp.Fill(GblDt);
            GblCon.Close();
            return GblDt;
        }
        public void GetMonthYear(string MNm,string Yr)
        {
            if (MNm == "January")
            {
                ClsVar.GblMonthNo = 1;
                ClsVar.GblMonthDays  = 31;
                ClsVar.GblFDate  = "01/01/" + Yr ;
                ClsVar.GblLDate = "31/01/" + Yr;
            }

            if (MNm == "February")
            {
                ClsVar.GblMonthNo = 2;
                    
                ClsVar.GblMonthDays = 28;
                ClsVar.GblFDate = "01/02/" + Yr;
                ClsVar.GblLDate = "28/02/" + Yr;

                if (Convert.ToInt32(Yr) % 400 == 0 || (Convert.ToInt32(Yr) % 100 != 0 && Convert.ToInt32(Yr) % 4 == 0))
                {
                    ClsVar.GblMonthDays = 29;
                }
            }
            if (MNm == "March")
            {
                ClsVar.GblMonthNo = 3;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/03/" + Yr;
                ClsVar.GblLDate = "31/03/" + Yr;
            }
            if (MNm == "April")
            {
                ClsVar.GblMonthNo = 4;
                ClsVar.GblMonthDays = 30;
                ClsVar.GblFDate = "01/04/" + Yr;
                ClsVar.GblLDate = "30/04/" + Yr;
            }
            if (MNm == "May")
            {
                ClsVar.GblMonthNo = 5;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/05/" + Yr;
                ClsVar.GblLDate = "31/05/" + Yr;
            }
            if (MNm == "June")
            {
                ClsVar.GblMonthNo = 6;
                ClsVar.GblMonthDays = 30;
                ClsVar.GblFDate = "01/06/" + Yr;
                ClsVar.GblLDate = "30/06/" + Yr;
            }
            if (MNm == "July")
            {
                ClsVar.GblMonthNo = 7;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/07/" + Yr;
                ClsVar.GblLDate = "31/07/" + Yr;
            }
            if (MNm == "August")
            {
                ClsVar.GblMonthNo = 8;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/08/" + Yr;
                ClsVar.GblLDate = "31/08/" + Yr;
            }

            if (MNm == "September")
            {
                ClsVar.GblMonthNo = 9;
                ClsVar.GblMonthDays = 30;
                ClsVar.GblFDate = "01/09/" + Yr;
                ClsVar.GblLDate = "30/09/" + Yr;
            }

            if (MNm == "October")
            {
                ClsVar.GblMonthNo = 10;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/10/" + Yr;
                ClsVar.GblLDate = "31/10/" + Yr;
            }

            if (MNm == "November")
            {
                ClsVar.GblMonthNo = 11;
                ClsVar.GblMonthDays = 30;
                ClsVar.GblFDate = "01/11/" + Yr;
                ClsVar.GblLDate = "30/11/" + Yr;
            }
            if (MNm == "December")
            {
                ClsVar.GblMonthNo = 12;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/12/" + Yr;
                ClsVar.GblLDate = "31/12/" + Yr;
            }
        }
        public void insertUpdate(string GblQry)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            SqlCommand GblCmd = new SqlCommand(GblQry, GblCon);
            GblCon.Open();
            GblCmd.ExecuteNonQuery();
            GblCon.Close();
        }

        public String DataExist(string DataExistQry)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            GblCon.Open();
            SqlCommand GblCmd = new SqlCommand(DataExistQry, GblCon);
            SqlDataReader GblRdr = GblCmd.ExecuteReader();

            if (GblRdr.Read())
            {
                GblCon.Close();
                return "1";
            }
            else
            {
                GblCon.Close();
                return "0";
            }

        }

    }


}





