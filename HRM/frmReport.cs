using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows;
using System.Windows.Forms;


namespace POS
{
    public partial class frmReport : Form
    {
        ReportDocument RptDoc;

        public frmReport()
        {
            InitializeComponent();
        }

        private void FrmRptShow_Load(object sender, EventArgs e)
        {
            this.Text = ClsVar.GblHeadName;

            CReport.ShowExportButton = true;
            CReport.ShowExportButton = Enabled;

            if (ClsVar.GblSelFor != "" && ClsVar.GblRptName.ToLower() != "invoicesmall")
            {
                CReport.SelectionFormula = ClsVar.GblSelFor;
            }
            try
            {

                RptDoc = new ReportDocument();

                
                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;



                string RptPath = Application.StartupPath + "\\rpt\\" + ClsVar.GblRptName;
                RptDoc.Load(RptPath);

                crConnectionInfo.ServerName = ClsVar.ServerName;
                crConnectionInfo.DatabaseName = ClsVar.DataBaseName;
                crConnectionInfo.UserID = "sa";
                crConnectionInfo.Password = ClsVar.SqlPassword;

                CrTables = RptDoc.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                if (ClsVar.GblRptName.ToLower() == "invoicesmall.rpt" || ClsVar.GblRptName.ToLower() == "invoicea4.rpt")
                {
                    RptDoc.RecordSelectionFormula = ClsVar.GblSelFor;
                    RptDoc.DataDefinition.FormulaFields["CompanyName"].Text = "'" + ClsVar.GblComName + "'";
                    RptDoc.DataDefinition.FormulaFields["Address"].Text = "'" + ClsVar.GblAddress + "'";
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                }

                if (ClsVar.GblRptName.ToLower() == "partyinfo.rpt")
                {
                    RptDoc.RecordSelectionFormula = ClsVar.GblSelFor;
                    RptDoc.DataDefinition.FormulaFields["CompanyName"].Text = "'" + ClsVar.GblComName + "'";
                    RptDoc.DataDefinition.FormulaFields["Address"].Text = "'" + ClsVar.GblAddress + "'";
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                }

                if (ClsVar.GblRptName.ToLower() == "bc.rpt")
                {
                    RptDoc.RecordSelectionFormula = ClsVar.GblSelFor;
                    RptDoc.DataDefinition.FormulaFields["CompanyName"].Text = "'" + ClsVar.GblComName + "'";
                    RptDoc.DataDefinition.FormulaFields["Address"].Text = "'" + ClsVar.GblAddress + "'";
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                }

                //RptDoc.DataDefinition.FormulaFields["CompanyName"].Text = "'" + ClsVar.GblComName + "'";
                //RptDoc.DataDefinition.FormulaFields["Address"].Text = "'" + ClsVar.GblAddress + "'";
                //RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";

                if (ClsVar.GblRptName.ToLower() == "LeaveReportMonthlySum.rpt".ToLower())
                {
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                    //RptDoc.DataDefinition.FormulaFields["mdAY"].Text = "'" + ClsVar.GblMonthDays.ToString() + "'";
                }

                if (ClsVar.GblRptName.ToLower() == "idcardbackw.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["Phone"].Text = "'" + ClsVar.GblPhone + "'";
                    RptDoc.DataDefinition.FormulaFields["Email"].Text = "'" + ClsVar.GblEmail + "'";
                }

                if (ClsVar.GblRptName.ToLower() == "idcardback.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["Phone"].Text = "'" + ClsVar.GblPhone + "'";
                    RptDoc.DataDefinition.FormulaFields["Email"].Text = "'" + ClsVar.GblEmail + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "salarysheetb.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                    //RptDoc.DataDefinition.FormulaFields["mdAY"].Text = "'" + ClsVar.GblMonthDays + "'";
                }


                if (ClsVar.GblRptName.ToLower() == "stock.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                }

                if (ClsVar.GblRptName.ToLower() == "monthlyattnsummary.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                    RptDoc.DataDefinition.FormulaFields["mdAY"].Text = "'" + ClsVar.GblMonthDays + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "ladger.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["CompanyName"].Text = "'" + ClsVar.GblComName + "'";
                    RptDoc.DataDefinition.FormulaFields["Address"].Text = "'" + ClsVar.GblAddress + "'";
                    RptDoc.DataDefinition.FormulaFields["Head1"].Text = "'" + ClsVar.GblRptHead1 + "'";
                    //RptDoc.DataDefinition.FormulaFields["Head2"].Text = "'" + ClsVar.GblRptHead2 + "'";
                    //RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                    //RptDoc.DataDefinition.FormulaFields["opbal"].Value = "'" + ClsVar.GblOpBalForLadger.ToString() + "'";
                    //RptDoc.DataDefinition.FormulaFields["closingbalance"].Text = "'" + ClsVar.GblClosBalForLadger.ToString() + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "timecard.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                    RptDoc.DataDefinition.FormulaFields["mdAY"].Text = "'" + ClsVar.GblMonthDays.ToString() + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "timecardb.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                    RptDoc.DataDefinition.FormulaFields["mdAY"].Text = "'" + ClsVar.GblMonthDays.ToString() + "'";
                }

                if (ClsVar.GblRptName.ToLower() == "otregister.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";

                }

                if (ClsVar.GblRptName.ToLower() == "attnregister.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "timecard.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["mdAY"].Text = "'" + ClsVar.GblMonthDays + "'";
                }

                if (ClsVar.GblRptName.ToLower() == "dailyjobstaus.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["Date"].Text = "'" + ClsVar.GblRptDate + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "rptstock.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["heading"].Text = "'" + ClsVar.GblRptHead + "'";

                }

                if (ClsVar.GblRptName.ToLower() == "dailyconsrpt.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["PageBreak"].Text = "'" + ClsVar.GblMasterStockPageBreak + "'";

                }

                if (ClsVar.GblRptName.ToLower() == "rptstockladger.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["opbal"].Text = "" + ClsVar.GblOpBalForLadger + "";

                }

                if (ClsVar.GblRptName.ToLower() == "delchallan.rpt")
                {

                    RptDoc.DataDefinition.FormulaFields[ClsVar.gblPwdFroShow.ToLower()].Text = "'" + ClsVar.GblRptHead + "'";

                }
                if (ClsVar.GblRptName.ToLower() == "SummaryOfEmpAttn.rpt".ToLower())
                {
                    RptDoc.DataDefinition.FormulaFields["totDays"].Text = ClsVar.GblDiffDays.ToString();
                    //RptDoc.DataDefinition.FormulaFields["P"].Text = "" + ClsVar.GblP + "";
                    //RptDoc.DataDefinition.FormulaFields["C"].Text = "" + ClsVar.GblC + "";

                }

                if (ClsVar.GblRptName.ToLower() == "1stLetterAfter10.rpt".ToLower())
                {
                    RptDoc.DataDefinition.FormulaFields["fromDtAbs"].Text = "'" + ClsVar.GblFormulaFld1.ToString() + "'";
                }

                if (ClsVar.GblRptName.ToLower() == "2ndLetterAfter10.rpt".ToLower())
                {
                    RptDoc.DataDefinition.FormulaFields["fromDtAbs"].Text = "'" + ClsVar.GblFormulaFld1.ToString() + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "3rdLetterAfter7.rpt".ToLower())
                {
                    RptDoc.DataDefinition.FormulaFields["fromDtAbs"].Text = "'" + ClsVar.GblFormulaFld1.ToString() + "'";
                    RptDoc.DataDefinition.FormulaFields["dtp1"].Text = "'" + ClsVar.GblFormulaFld2.ToString() + "'";
                    RptDoc.DataDefinition.FormulaFields["dtp2"].Text = "'" + ClsVar.GblFormulaFld3.ToString() + "'";
                }


                if (ClsVar.GblRptName.ToLower() == "MonthlyAttnSummaryOrg.rpt".ToLower())
                {
                    RptDoc.DataDefinition.FormulaFields["mday"].Text = ClsVar.GblDiffDays.ToString();
                }
                if (ClsVar.GblRptName.ToLower() == "MonthlyAttnSummary.rpt".ToLower())
                {
                    RptDoc.DataDefinition.FormulaFields["mday"].Text = ClsVar.GblDiffDays.ToString();
                }

                if (ClsVar.GblRptName.ToLower() == "yearlystock.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["PageBreak"].Text = "'" + ClsVar.GblMasterStockPageBreak + "'";
                }

                if (ClsVar.GblRptName.ToLower() == "yearlystock1.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["PageBreak"].Text = "'" + ClsVar.GblMasterStockPageBreak + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "tradac.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["head1"].Text = "'" + ClsVar.GblRptHead1 + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "trialbalance.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["head1"].Text = "'" + ClsVar.GblRptHead1 + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "plac.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["head1"].Text = "'" + ClsVar.GblRptHead1 + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "bs.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["head1"].Text = "'" + ClsVar.GblRptHead1 + "'";
                }
                if (ClsVar.GblRptName.ToLower() == "invoice.rpt" || ClsVar.GblRptName.ToLower() == "invoice_pad.rpt")
                {
                    RptDoc.DataDefinition.FormulaFields["sign"].Text = "'" + ClsVar.GblRptHead1 + "'";
                }
                //this function is for direct printing
                //if (ClsVar.directPrint.ToLower() == "yes" && ClsVar.GblRptName.ToLower() == "invoicesmall.rpt")
                //{
                //    RptDoc.PrintToPrinter(1, true, 1, 1);
                //    this.Close();
                //}
                //else
                //{
                    CReport.ShowExportButton = true;
                    CReport.ReportSource = RptDoc;
                    CReport.Refresh();
                //}


            }
            catch
            {
                MessageBox.Show("Not Found The Report..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

        }

        private void ExpToPDF()
        {
            try
            {
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();


                CrDiskFileDestinationOptions.DiskFileName = "e:\\" + ClsVar.GblRptName + ".pdf";
                CrExportOptions = RptDoc.ExportOptions;
                {
                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                }

                RptDoc.Export();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void ExpToEXCEL()
        {
            try
            {
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                ExcelFormatOptions CrFormatTypeOptions = new ExcelFormatOptions();


                CrDiskFileDestinationOptions.DiskFileName = "e:\\" + ClsVar.GblRptName + ".xls";
                CrExportOptions = RptDoc.ExportOptions;
                {
                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    CrExportOptions.ExportFormatType = ExportFormatType.Excel;
                    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                }


                RptDoc.Export();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void ExpToWORD()
        {
            try
            {
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();


                CrDiskFileDestinationOptions.DiskFileName = "e:\\" + ClsVar.GblRptName + ".doc";
                CrExportOptions = RptDoc.ExportOptions;
                {
                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    CrExportOptions.ExportFormatType = ExportFormatType.WordForWindows;
                    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                }


                RptDoc.Export();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //CReport.ShowExportButton = true;
            CReport.ShowExportButton = Enabled;
            //CReport.en

            if (cboFormat.Text.Trim() == "")
            {
                MessageBox.Show("Please Select The Export Format..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboFormat.Text.Trim().ToLower() == "pdf")
            {
                ExpToPDF();
            }

            if (cboFormat.Text.Trim().ToLower() == "excel")
            {
                ExpToEXCEL();
            }

            if (cboFormat.Text.Trim().ToLower() == "word")
            {
                ExpToWORD();
            }

        }

        private void btnPrnt_Click(object sender, EventArgs e)
        {
            //CReport.PrintReport();
            //PrintPreviewDialog PPD = new PrintPreviewDialog();
            //PPD.
            //PPD.ShowDialog(CReport);

        }

        private void CReport_Load(object sender, EventArgs e)
        {

        }




    }
}