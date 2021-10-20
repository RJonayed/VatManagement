using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRM
{
    public partial class frmProduction : Form
    {
        ClsMain SvCls = new ClsMain();

        public frmProduction()
        {
            InitializeComponent();
            this.Width = ClsVar.GblFormWidth;
            this.Height = ClsVar.GblFormHeight;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (cboMacName.Text.Trim() == "")
            {
                MessageBox.Show("Machine Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboJobCardNo.Text.Trim() == "")
            {
                MessageBox.Show("Job Card No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string qry = ("select * from Production where Machine='" + cboMacName.Text.Trim() + "' and Machineman='" + cboMacManName.Text.Trim() + "' and ProductionDate=convert(datetime,'" + this.dtpProduction.Value.ToString("dd/MM/yyyy") + "',103)");// and JobCardNo='" + cboJobCardNo.Text.Trim() + "'");

                string CHK = SvCls.DataExist(qry);


                if (CHK.ToString() == "1")
                {
                    qry = "update Production set JobCardNo='" + cboJobCardNo.Text.Trim() + "', Rmk='" + txtRemarks.Text.Trim() + "' ,MakeHoure='" + Convert.ToInt16(txtMakReadyHour.Text.Trim()) + "',Machineman='" + cboMacManName.Text.Trim() + "',Shift='" + cboShift.Text.Trim() + "',ActWHour='" + Convert.ToInt16(txtAWH.Text.Trim()) + "',OTWHour='" + Convert.ToInt16(txtOTWH.Text.Trim()) + "',OTProduction=CONVERT(money,'" + txtOTPro.Text.Trim() + "'),ActProduction=CONVERT(money,'" + txtAPro.Text.Trim() + "'),TotProduction=CONVERT(money,'" + txtTotProduction.Text.Trim() + "'),TotWHour='" + Convert.ToInt16(txtTotWokHour.Text.Trim()) + "',ReasonOfNoProduction='" + CboResonOfNoPro.Text.Trim() + "',TergetInPer=CONVERT(money,'" + txtTarAchieved.Text.Trim() + "'),CapacityInPer=CONVERT(money,'" + txtCapAchieved.Text.Trim() + "'),Assistant='" + cboAssistant.Text.Trim() + "',Helper='" + cboHelper.Text.Trim() + "',Apprentice='" + cboApprentice.Text.Trim() + "',Status='" + txtDailyJobStatus.Text.Trim() + "' Where Machine='" + cboMacName.Text.Trim() + "' and Machineman='" + cboMacManName.Text.Trim() + "' and  ProductionDate=convert(datetime,'" + this.dtpProduction.Value.ToString("dd/MM/yyyy") + "',103)";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else   
                {
                    qry = "insert into Production (Rmk,MakeHoure,Machine,Machineman,Shift,ActWHour,OTWHour,OTProduction,ActProduction,TotProduction,TotWHour,ReasonOfNoProduction ,TergetInPer,CapacityInPer,ProductionDate,JobCardNo,Assistant,Helper,Apprentice,Status) values ('" + txtRemarks.Text.Trim() + "','" + Convert.ToInt16(txtMakReadyHour.Text.Trim()) + "','" + cboMacName.Text.Trim() + "','" + cboMacManName.Text.Trim() + "','" + cboShift.Text.Trim() + "','" + Convert.ToInt16(txtAWH.Text.Trim()) + "','" + Convert.ToInt16(txtOTWH.Text.Trim()) + "',CONVERT(money,'" + txtOTPro.Text.Trim() + "'),CONVERT(money,'" + txtAPro.Text.Trim() + "'),CONVERT(money,'" + txtTotProduction.Text.Trim() + "'),'" + Convert.ToInt16(txtTotWokHour.Text.Trim()) + "','" + CboResonOfNoPro.Text.Trim() + "',CONVERT(money,'" + txtTarAchieved.Text.Trim() + "'),CONVERT(money,'" + txtCapAchieved.Text.Trim() + "'),convert(datetime,'" + this.dtpProduction.Value.ToString("dd/MM/yyyy") + "',103),'" + cboJobCardNo.Text.Trim() + "','" + cboAssistant.Text.Trim() + "','" + cboHelper.Text.Trim() + "','" + cboApprentice.Text.Trim() + "','" + txtDailyJobStatus.Text.Trim() + "')";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }

                SvCls.insertUpdate(qry);
                Grid_Head();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Grid_Head()
        {
            Grid.DataSource = SvCls.GblDataTable("select ProductionDate,JobCardNo,Machine,Machineman,Shift,ActWHour,OTWHour,OTProduction,ActProduction,TotProduction,TotWHour,MakeHoure,TergetInPer,CapacityInPer,ReasonOfNoProduction as Reason,Assistant,Helper,Apprentice,Rmk from Production where Machine='" + cboMacName.Text.Trim() + "' order by productiondate desc");
            Grid.Refresh();

            //Grid.SelectedCells = 16;
            //Grid.SelectedCells( 0) = "Machine Name";
            //Grid.SelectedCells( 1) = "Production Date";
            //Grid.SelectedCells( 2) = "Job Card No";
            //Grid.SelectedCells( 3) = "Machineman";
            //Grid.SelectedCells( 4) = "Shift";
            //Grid.SelectedCells( 5) = "TotalWorkingHour";
            //Grid.SelectedCells( 6) = "Over Time";
            //Grid.SelectedCells( 7) = "Make Ready Hour";
            //Grid.SelectedCells( 8) = "Production";
            //Grid.SelectedCells( 9) = "R.OfNoProduction ";
            //Grid.SelectedCells( 10) = "Target Achieved";
            //Grid.SelectedCells( 11) = "Capacity Achieved";
            //Grid.SelectedCells( 12) = "Assistant";
            //Grid.SelectedCells( 13) = "Helper";
            //Grid.SelectedCells( 14) = "Apprentice";
            //Grid.SelectedCells( 15) = "Daily Job Status";
 
        }

        private void frmProduction_Load(object sender, EventArgs e)
        {
            try
            {

                if (ClsVar.GblFrmBackColor == "1")
                {
                    ClsVar.BackPicPath = Application.StartupPath + "\\Pic\\" + "Back.Jpg";
                    this.BackgroundImage = new Bitmap(ClsVar.BackPicPath);
                }


                string Qry = "select Machine from Machine order by Machine asc";
                cboMacName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                cboMacName.DisplayMember = "Machine";
                cboMacName.Text = "";

                string Qry1 = "select rtrim(cast(EmpId as varchar))+'~'+EmpName as data from Machineman_AssistentInfo where Mman_Assis= 'Machineman' and Status='0' and (department = 'EPPL' or department = 'Both') order by EmpId asc";
                //string Qry1 = "select EmpName as data from Machineman_AssistentInfo where Mman_Assis= 'Machineman' and Status='0' and (department = 'EPPL' or department = 'Both') order by EmpId asc";
                cboMacManName.DataSource = SvCls.GblDataSet(Qry1).Tables[0];
                cboMacManName.DisplayMember = "data";
                cboMacManName.Text = "";

                string Qry3 = "select rtrim(cast(EmpId as varchar))+'~'+EmpName as data from Machineman_AssistentInfo where Mman_Assis= 'Assistant' and Status='0' and (department = 'EPPL' or department = 'Both') order by EmpId asc ";
                cboAssistant.DataSource = SvCls.GblDataSet(Qry3).Tables[0];
                cboAssistant.DisplayMember = "data";
                cboAssistant.Text = "";

                string Qry4 = "select rtrim(cast(EmpId as varchar))+'~'+EmpName as data from Machineman_AssistentInfo where Mman_Assis= 'Helper' and Status='0' and (department = 'EPPL' or department = 'Both') order by EmpId asc ";
                cboHelper.DataSource = SvCls.GblDataSet(Qry4).Tables[0];
                cboHelper.DisplayMember = "data";
                cboHelper.Text = "";

                string Qry5 = "select rtrim(cast(EmpId as varchar))+'~'+EmpName as data from Machineman_AssistentInfo where Mman_Assis= 'Apprentice' and Status='0' and (department = 'EPPL' or department = 'Both') order by EmpId asc";
                cboApprentice.DataSource = SvCls.GblDataSet(Qry5).Tables[0];
                cboApprentice.DisplayMember = "data";
                cboApprentice.Text = "";
                
                string Qry2 = "select JobCardNo from OrderDetails where status=0 order by JobCardNo asc ";
                cboJobCardNo.DataSource = SvCls.GblDataSet(Qry2).Tables[0];
                cboJobCardNo.DisplayMember = "JobCardNo";
                cboJobCardNo.Text = "";
                
                //Grid_Head();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (cboMacName.Text.Trim() == "")
            {
                MessageBox.Show("Machine Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboJobCardNo.Text.Trim() == "")
            {
                MessageBox.Show("Job Card No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                string qry = "select * from Production where Machine='" + cboMacName.Text.Trim() + "' and ProductionDate=convert(datetime,'" + this.dtpProduction.Value.ToString("dd/MM/yyyy") + "',103) and JobCardNo='" + cboJobCardNo.Text.Trim() + "'";

                string CHK = SvCls.DataExist(qry);

                if (MessageBox.Show(" Do You Realy Want To Delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (CHK.ToString() == "1")
                    {
                        qry = "delete from Production where Machine='" + cboMacName.Text.Trim() + "' and ProductionDate=convert(datetime,'" + this.dtpProduction.Value.ToString("dd/MM/yyyy") + "',103) and JobCardNo='" + cboJobCardNo.Text.Trim() + "'";

                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        PicSave.Visible = true;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                    }

                SvCls.insertUpdate(qry);
                Grid_Head();
                txtAWH.Text = "";
                txtAPro.Text = "";
                txtOTPro.Text = "";
                txtOTWH.Text = "";
                cboMacName.Text = "";
                cboMacManName.Text = "";
                cboShift.Text = "";
                txtTotWokHour.Text = "";
                txtOverTime.Text = "";
                txtMakReadyHour.Text = "";
                txtTotProduction.Text = "";
                txtTarAchieved.Text = "";
                txtCapAchieved.Text = "";
                cboJobCardNo.Text = "";
                CboResonOfNoPro.Text = "";
                txtDailyJobStatus.Text = "";
                cboAssistant.Text = "";
                cboHelper.Text = "";
                cboApprentice.Text = "";
                txtRemarks.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            txtRemarks.Text = "";
            txtAWH.Text = "";
            txtAPro.Text = "";
            txtOTPro.Text = "";
            txtOTWH.Text = "";
            cboMacName.Text = "";
            cboMacManName.Text = "";
            cboShift.Text = "";
            txtTotWokHour.Text = "";
            txtOverTime.Text = "";
            txtMakReadyHour.Text = "";
            txtTotProduction.Text = "";
            txtTarAchieved.Text = "";
            txtCapAchieved.Text = "";
            cboJobCardNo.Text = "";
            CboResonOfNoPro.Text = "";
            txtDailyJobStatus.Text = "";
            cboAssistant.Text = "";
            cboHelper.Text = "";
            cboApprentice.Text = "";
        }

        private void cboMacName_Leave(object sender, EventArgs e)
        {
            Grid_Head();

        }

        private void cboShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;

            if (e.KeyChar.ToString() == "\r")
            {
                txtAWH.Select();
            }
        }

        private void CboResonOfNoPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar.ToString() == "\r")
            {
                cboAssistant.Select();
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            dtpProduction.Text = Grid.Rows[i].Cells[0].Value.ToString();
            cboJobCardNo.Text = Grid.Rows[i].Cells[1].Value.ToString();
            cboMacName.Text = Grid.Rows[i].Cells[2].Value.ToString();
            cboMacManName.Text = Grid.Rows[i].Cells[3].Value.ToString();
            cboShift.Text = Grid.Rows[i].Cells[4].Value.ToString();
            txtAWH.Text = Grid.Rows[i].Cells[5].Value.ToString();
            txtOTWH.Text = Grid.Rows[i].Cells[6].Value.ToString();
            txtOTPro.Text = Grid.Rows[i].Cells[7].Value.ToString();
            txtAPro.Text = Grid.Rows[i].Cells[8].Value.ToString();
            txtTotProduction.Text = Grid.Rows[i].Cells[9].Value.ToString();
            txtTotWokHour.Text = Grid.Rows[i].Cells[10].Value.ToString();
            txtMakReadyHour.Text = Grid.Rows[i].Cells[11].Value.ToString();
            txtTarAchieved.Text = Grid.Rows[i].Cells[12].Value.ToString();
            txtCapAchieved.Text = Grid.Rows[i].Cells[13].Value.ToString();
            CboResonOfNoPro.Text = Grid.Rows[i].Cells[14].Value.ToString();
            txtDailyJobStatus.Text = Grid.Rows[i].Cells[15].Value.ToString();
            cboAssistant.Text = Grid.Rows[i].Cells[15].Value.ToString();
            cboHelper.Text = Grid.Rows[i].Cells[16].Value.ToString();
            cboApprentice.Text = Grid.Rows[i].Cells[17].Value.ToString();
            txtRemarks.Text = Grid.Rows[i].Cells[18].Value.ToString();
        }

        private void cboAssistant_Leave(object sender, EventArgs e)
        {
            try
            {
                int index = cboAssistant.Text.IndexOf("~") + 1;
                cboAssistant.Text = cboAssistant.Text.Substring(index);

           }
            catch
            {
            }

        }

        private void cboHelper_Leave(object sender, EventArgs e)
        {
            try
            {
                int index = cboHelper.Text.IndexOf("~") + 1;
                cboHelper.Text = cboHelper.Text.Substring(index);
            }
            catch
            {
            }
        }

        private void cboApprentice_Leave(object sender, EventArgs e)
        {
            try
            {
                int index = cboApprentice.Text.IndexOf("~") + 1;
                cboApprentice.Text = cboApprentice.Text.Substring(index);
            }
            catch
            {
            }
        }

        private void cboMacName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboMacManName.Select();
            }
        }

        private void cboMacManName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboShift.Select();
            }
        }

        private void txtTotWokHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtTotProduction.Select();
            }
        }

        private void txtOverTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMakReadyHour.Select();
            }
        }

        private void txtMakReadyHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtTotProduction.Select();
            }
        }

        private void txtProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                CboResonOfNoPro.Select();
                
            }
        }

        private void txtTarAchieved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtCapAchieved.Select();
            }
        }

        private void cboJobCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboMacName.Select();
            }
        }

        private void dtpProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboJobCardNo.Select();
            }
        }

        private void txtCapAchieved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                CboResonOfNoPro.Select();
            }
        }

        private void txtDailyJobStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboAssistant.Select();
            }
        }

        private void cboAssistant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar.ToString() == "\r")
            {
                cboHelper.Select();
            }
        }

        private void cboHelper_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar.ToString() == "\r")
            {
                cboApprentice.Select();
            }
        }

        private void cboApprentice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSave.Select();
            }
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboMacName.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Production.Machine}='" + cboMacName.Text + "' and";
            }


            if (cboJobCardNo.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Production.JobCardNo}='" + cboJobCardNo.Text + "' and ";
            }

            ClsVar.GblSelFor = ClsVar.GblSelFor + "{Production.ProductionDate}=Date(" + dtpProduction.Value.Year.ToString() + "," + dtpProduction.Value.Month.ToString() + "," + dtpProduction.Value.Day.ToString() + ")";
                    
            ClsVar.GblHeadName = "Production Information";
            ClsVar.GblRptName = "Production.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void txtOTWH_Leave(object sender, EventArgs e)
        {
            if (txtOTWH.Text.Trim() != "")
            {
                txtTotWokHour.Text = (Convert.ToDouble(txtAWH.Text.Trim()) + Convert.ToDouble(txtOTWH.Text.Trim())).ToString();
            }
            else
            {
                txtTotWokHour.Text = txtAWH.Text;
            }

        }

        private void txtOTPro_Leave(object sender, EventArgs e)
        {
            if (txtOTPro.Text.Trim() != "")
            {
                txtTotProduction.Text = (Convert.ToDouble(txtAPro.Text.Trim()) + Convert.ToDouble(txtOTPro.Text.Trim())).ToString();
            }

            else
            {
                txtTotProduction.Text = txtAPro.Text;
            }
        }

        private void txtTotProduction_Leave(object sender, EventArgs e)
        {
            string Target;
            string Capacity;

            string Qry = "select Target,Capacity from Machine where Machine ='" + cboMacName.Text.Trim() + "'";
            SvCls.toGetData(Qry);
            if (SvCls.GblRdrToGetData.Read())
            {
                Target = SvCls.GblRdrToGetData["Target"].ToString();
                Capacity = SvCls.GblRdrToGetData["Capacity"].ToString();
                SvCls.GblCon.Close();

                txtTarAchieved.Text = (Math.Round((Convert.ToDouble(txtTotProduction.Text.Trim()) * 100) / (Convert.ToDouble(txtTotWokHour.Text.Trim()) * Convert.ToDouble(Target)),2)).ToString();
                txtCapAchieved.Text = (Math.Round((Convert.ToDouble(txtTotProduction.Text.Trim()) * 100) / (Convert.ToDouble(txtTotWokHour.Text.Trim()) * Convert.ToDouble(Capacity)),2)).ToString();

            }

           
        }

        private void txtAWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtAPro.Select();
            }
        }

        private void txtAPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtOTWH.Select();
            }
        }

        private void txtOTWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtOTPro.Select();
            }
        }

        private void txtOTPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtTotWokHour.Select();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMgs.Visible = false;
            PicSave.Visible = false;
        }

        private void btnmp_Click(object sender, EventArgs e)
        {
            if (cboMacName.Text.Trim() == "")
            {
                MessageBox.Show("Please select Machine", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboMacName.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Production.Machine}='" + cboMacName.Text + "' and";
            }

            ClsVar.GblSelFor = ClsVar.GblSelFor + " Month({Production.ProductionDate})= " + dtpProduction.Value.Month + " and year({Production.ProductionDate})=" + dtpProduction.Value.Year + "";

            ClsVar.GblHeadName = "Monthly Production Information";
            ClsVar.GblRptName = "MonthlyProduction.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void btnyp_Click(object sender, EventArgs e)
        {
            if (cboMacName.Text.Trim() == "")
            {
                MessageBox.Show("Please select Machine", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboMacName.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Production.Machine}='" + cboMacName.Text + "' and";
            }

            ClsVar.GblSelFor = ClsVar.GblSelFor + " year({Production.ProductionDate})=" + dtpProduction.Value.Year + "";

            ClsVar.GblHeadName = "Yearly Production Information";
            ClsVar.GblRptName = "RptYearlyProductionPrint.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void btnmper_Click(object sender, EventArgs e)
        {
            if (cboMacName.Text.Trim() == "")
            {
                MessageBox.Show("Please select Machine", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboMacName.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Production.Machine}='" + cboMacName.Text + "' and";
            }

            ClsVar.GblSelFor = ClsVar.GblSelFor + " Month({Production.ProductionDate})= " + dtpProduction.Value.Month + " and year({Production.ProductionDate})=" + dtpProduction.Value.Year + "";

            ClsVar.GblHeadName = "Monthly Performance Information";
            ClsVar.GblRptName = "MonthlyPerformance.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void btnYper_Click(object sender, EventArgs e)
        {
            if (cboMacName.Text.Trim() == "")
            {
                MessageBox.Show("Please select Machine", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboMacName.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Production.Machine}='" + cboMacName.Text + "' and";
            }

            ClsVar.GblSelFor = ClsVar.GblSelFor + " year({Production.ProductionDate})=" + dtpProduction.Value.Year + "";

            ClsVar.GblHeadName = "Yearly Performance Information";
            ClsVar.GblRptName = "RptYearlyPerformancePrint.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void btnGrapic_Click(object sender, EventArgs e)
        {

            string Qry = "delete From DailyProduction";
            SvCls.insertUpdate(Qry);

            Qry = "insert DailyProduction (Machine,ProductionDate,Hour,Production) select m.Machine,p.ProductionDate,sum(p.TotWhour),sum(p.Totproduction) from machine M left join Production p on M.machine = P.machine group by m.Machine,p.ProductionDate";
            SvCls.insertUpdate(Qry);

            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            ClsVar.GblSelFor = ClsVar.GblSelFor + " Month({DailyProduction.ProductionDate})= " + dtpProduction.Value.Month + " and year({DailyProduction.ProductionDate})=" + dtpProduction.Value.Year + "";

            ClsVar.GblHeadName = "Monthly Production Information";
            ClsVar.GblRptName = "GrRepresentationOfMachPerfPrint.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

       




    }
}
