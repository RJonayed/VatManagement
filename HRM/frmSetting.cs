using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.DirectoryServices;
using System.Collections;
using System.Windows.Forms;

namespace POS
{
    public partial class frmSetting : Form
    {
        ClsMain SvCls = new ClsMain();

        public frmSetting()
        {
            InitializeComponent();
            this.Width = ClsVar.GblFormWidth;
            this.Height = ClsVar.GblFormHeight;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public class DialogState
        {
            public DialogResult result;
            public FileDialog dialog;

            public void ThreadProcShowDialog()
            {
                result = dialog.ShowDialog();
            }

        }

        private DialogResult STAShowDialog(FileDialog dialog)
        {
            DialogState state = new DialogState();
            state.dialog = dialog;
            System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.Join();
            return state.result;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdPicPath_Click(object sender, EventArgs e)
        {
            String Location = String.Empty;
            OpenFileDialog frm = new OpenFileDialog();

            frm.InitializeLifetimeService();
            frm.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
            frm.Title = "Browse Config file";

            DialogResult ret = STAShowDialog(frm);
            if (ret == DialogResult.OK)
                Location = frm.FileName;
            txtPicPath.Text = Location;

        }

        private void BlankAll()
        {
            txtMaxOT.Text = "";
            mskInTimeStart.Text = "";
            mskMaxInTime.Text = "";
            mskOTStart.Text = "";
            mskWorkStartFrom.Text = "";
            mskOutTime.Text = "";

            txtNameDesg.Text = "";
            txtBNameDesg.Text = "";
            txtRmkDesg.Text = "";
            txtMachineName.Text = "";
            txtNameBr.Text = "";
            txtBnameBr.Text = "";
            txtRmkBr.Text = "";
            txtHeadBr.Text = "";
            txtAddressBr.Text = "";
            txtMailBr.Text = "";
            txtPhoneBr.Text = "";
            txtMatTpName.Text = "";
            cboInkOthers.Text = "";
            chkActive.Checked = false;
            txtUnit.Text = "";
            txtNcrLable.Text = "";
            txtNameSection.Text = "";
            txtBNameSection.Text = "";
            txtRmkSection.Text = "";
            cboMachine.Text = "";
            txtMacUnit.Text = "";
            txtMacSize.Text = "";
            txtWSMax.Text = "";
            txtWSMin.Text = "";
            txtMacSpeed.Text = "";
            txtMacSpeedUnit.Text = "";
            txtLessDesp.Text = "";
            txtLessDespUnit.Text = "";
            txtPresCap.Text = "";
            txtPresCapUnit.Text = "";
            txtTarget.Text = "";
            txtTargetUnit.Text = "";
            cboSec.Text = "";
        }

        private void HideAllPnl()
        {
            PnlNcr.Visible = false;
            pnlMachimeDetails.Visible = false;
            PnlUnit.Visible = false;
            pnlMaterialType.Visible = false;
            pnlGrade.Visible = false;
            pnlBr.Visible = false;
            pnlDept.Visible = false;
            pnlGlobalSetup.Visible = false;
            pnlPassChange.Visible = false;
            pnlDollarRate.Visible = false;
            pnlDBaseBak.Visible = false;
            pnlUserCrate.Visible = false;
            pnlSecurity.Visible = false;
            pnlShift.Visible = false;
            pnlDesg.Visible = false;
            pnlSec.Visible = false;
            pnlLine.Visible = false;
            pnlMachine.Visible = false;
            pnlDollarRate.Visible = false;
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            //cmdExit.Top = 0;
            //cmdExit.Left = this.Width - 30;

            if (ClsVar.GblFrmBackColor == "1")
            {
                ClsVar.BackPicPath = Application.StartupPath + "\\Pic\\" + "Back.Jpg";
                this.BackgroundImage = new Bitmap(ClsVar.BackPicPath);
            }

            //if (ClsVar.HRM == true & ClsVar.Sewing == true & ClsVar.Knitting==true)
            //{ 
            //    btnSec.Visible = true;
            //    btnDept.Visible = true;
            //    btnDesg.Visible = true;
            //    btnLine.Visible = true;
            //    btnGrade.Visible = true;
            //    btnShifTimeSetup.Visible = true;
            //    btnDollarRate.Visible = true;
            //    btnGlobalSetup.Visible = true;
            //    return;
            //}

            //if (ClsVar.HRM == true)
            //{
            //    btnSec.Visible = true;
            //    btnDept.Visible = true;
            //    btnDesg.Visible = true;
            //    btnLine.Visible = true;
            //    btnGrade.Visible = true;
            //    btnShifTimeSetup.Visible = true;
            //    btnDollarRate.Visible = true;
            //    btnGlobalSetup.Visible = true;
            //    return;
            //}

            //if (ClsVar.Sewing == true)
            //{
            //    btnSec.Visible = false;
            //    btnDept.Visible = false;
            //    btnDesg.Visible = false;
            //    btnLine.Visible = false;
            //    btnGrade.Visible = false;
            //    btnShifTimeSetup.Visible = false;
            //    btnDollarRate.Visible = false;
            //    btnGlobalSetup.Visible = false;
            //    return;
            //}

            //if (ClsVar.Knitting == true)
            //{
            //    btnSec.Visible = false;
            //    btnDept.Visible = false;
            //    btnDesg.Visible = false;
            //    btnLine.Visible = false;
            //    btnGrade.Visible = false;
            //    btnShifTimeSetup.Visible = false;
            //    btnDollarRate.Visible = false;
            //    btnGlobalSetup.Visible = false;
            //    return;
            //}


            SvCls.toGetData("SELECT SalaryStyle as CodeNo from Setting where comid='" + ClsVar.GblComId + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                CboSalaryStyle.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                SvCls.GblCon.Close();
            }


            string BackImage = "";
            SvCls.toGetData("SELECT BackImage as CodeNo from Setting where comid='" + ClsVar.GblComId + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                BackImage = SvCls.GblRdrToGetData["CodeNo"].ToString();
                SvCls.GblCon.Close();
            }

            if (BackImage == "1")
            {
                chkBackImage.Checked = true;
            }
            else
            {
                chkBackImage.Checked = false;
            }

            lebHd.Left = 213;
            lebHd.Width = 700;
            lebHd.Text = "";

            //string SpLock = "";
            //SvCls.toGetData("SELECT SpLock as CodeNo,SPForMonth as Month,SPForYear as Year from Setting");
            //if (SvCls.GblRdrToGetData.Read())
            //{
            //    SpLock = SvCls.GblRdrToGetData["CodeNo"].ToString();
            //    cboMonth.Text = SvCls.GblRdrToGetData["Month"].ToString();
            //    cboYear.Text = SvCls.GblRdrToGetData["Year"].ToString();
            //    SvCls.GblCon.Close();
            //}

            //if (SpLock == "1")
            //{
            //    chkSpLock.Checked = true;
            //}
            //else
            //{
            //    chkSpLock.Checked = false;
            //}

            //string DollarRate = "";
            //SvCls.toGetData("SELECT DollarRate as CodeNo from Setting");
            //if (SvCls.GblRdrToGetData.Read())
            //{
            //    DollarRate = SvCls.GblRdrToGetData["CodeNo"].ToString();
            //    SvCls.GblCon.Close();
            //}

            //if (DollarRate == "1")
            //{
            //    chkDollarRate.Checked = true;
            //}
            //else
            //{
            //    chkDollarRate.Checked = false;
            //}

            //SvCls.toGetData("SELECT ForMonth as Month,ForYear as Year,Currency as Money from Setting");
            //if (SvCls.GblRdrToGetData.Read())
            //{
            //    txtCurrency.Text = SvCls.GblRdrToGetData["Money"].ToString();
            //    cboMonth.Text = SvCls.GblRdrToGetData["Month"].ToString();
            //    cboYear.Text = SvCls.GblRdrToGetData["Year"].ToString();
            //    SvCls.GblCon.Close();
            //}
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveGlobalSetup == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string qry = "select * from Setting where ComId='" + ClsVar.GblComId + "'";

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "update Setting set SalaryStyle='" + CboSalaryStyle.Text.Trim() + "',PhotoPath='" + txtPicPath.Text.Trim() + "',BackImage=" + Convert.ToInt32(chkBackImage.Checked) + ",PcName='" + ClsVar.GblPcName + "',DollarRate=" + Convert.ToInt32(chkDollarRate.Checked) + " where ComId='" + ClsVar.GblComId + "'";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "insert into Setting (SalaryStyle,PhotoPath,BackImage,PcName,comid,DollarRate) values ('" + CboSalaryStyle.Text + "','" + txtPicPath.Text + "'," + Convert.ToInt16(chkBackImage.Checked) + ",'" + ClsVar.GblPcName + "','" + ClsVar.GblComId + "'," + Convert.ToInt16(chkDollarRate.Checked) + ")";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                SvCls.insertUpdate(qry);

            }
        }



        private void cboMonth_LostFocus(object sender, EventArgs e)
        {
            string Qry = "select * from Setting where ForMonth='" + cboDMonth.Text + "'";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT ForYear,Currency From Setting where ForMonth='" + cboDMonth.Text + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboDYear.Text = SvCls.GblRdrToGetData["ForYear"].ToString();
                    txtRate.Text = SvCls.GblRdrToGetData["Currency"].ToString();

                    SvCls.GblCon.Close();
                }
            }

            else
            {
                cboDYear.Text = "";
                txtRate.Text = "";
            }
        }
        private void cboYear_LostFocus(object sender, EventArgs e)
        {
            string Qry = "select * from Setting where ForYear='" + cboDYear.Text + "'";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT Currency From Setting where ForMonth='" + cboDMonth.Text + "' and ForYear='" + cboDYear.Text + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtRate.Text = SvCls.GblRdrToGetData["Currency"].ToString();

                    SvCls.GblCon.Close();
                }
            }

            else
            {
                txtRate.Text = "";
            }
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            lebHd.Text = "[ MONTHLY SETUP ]";

            HideAllPnl();
            pnlDollarRate.Visible = true;
            pnlDollarRate.Left = 213;
            pnlDollarRate.Top = 48;
            pnlDollarRate.Width = 700;
            pnlDollarRate.Height = 500;
            GridDollarRate.Width = 680;
            GridDollarRate.Height = 350;
            cboDMonth.Text = DateTime.Today.ToString("MMMMM");
            cboDYear.Text = DateTime.Today.ToString("yyyy");
            GridDollarRate.DataSource = SvCls.GblDataTable("select * FROM MonthlySetup where comid='" + ClsVar.GblComId + "' order by LDate");
            GridDollarRate.Refresh();
        }

        private void btnGlobalSetup_Click(object sender, EventArgs e)
        {
            ////SecurityAssign();

            if (ClsVar.VwGlobalSetup == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                HideAllPnl();
                pnlGlobalSetup.Visible = true;
                pnlGlobalSetup.Left = 213;
                pnlGlobalSetup.Top = 48;
                pnlGlobalSetup.Width = 700;
                pnlGlobalSetup.Height = 500;

                lebHd.Text = "[ GLOBAL SETUP ]";

                string qry = "Select SaleFormLocationX as X, SaleFormLocationY as Y, BtnDelInvoice as DelBtn, PayMode as pay, NuhashGL From SettingSingle Where ComId = '" + ClsVar.GblComId + "'";
                SvCls.toGetData(qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtLocationX.Text = SvCls.GblRdrToGetData["X"].ToString();
                    txtLocationY.Text = SvCls.GblRdrToGetData["Y"].ToString();
                    int DelBtn = Convert.ToInt32(SvCls.GblRdrToGetData["DelBtn"].ToString());
                    int PayMode = Convert.ToInt32(SvCls.GblRdrToGetData["pay"].ToString());
                    int NuhashGl = Convert.ToInt32(SvCls.GblRdrToGetData["NuhashGl"].ToString());

                    if (DelBtn == 1)
                    {
                        chkShowFullInvoiceDelBtn.Checked = true;
                    }
                    else
                    {
                        chkShowFullInvoiceDelBtn.Checked = false;
                    }
                    if (PayMode == 1)
                    {
                        chkPayMode.Checked = true;
                    }
                    else
                    {
                        chkPayMode.Checked = false;
                    }
                    if (NuhashGl == 1)
                    {
                        ChkNuhashGl.Checked = true;
                    }
                    else
                    {
                        ChkNuhashGl.Checked = false;
                    }

                }

                SvCls.toGetData("select * from Setting where comid='" + ClsVar.GblComId + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboSalaryStyle.Text = SvCls.GblRdrToGetData["SalaryStyle"].ToString();
                    chkDollarRate.Checked = Convert.ToBoolean(SvCls.GblRdrToGetData["dollarrate"]);
                    txtPicPath.Text = SvCls.GblRdrToGetData["photoPath"].ToString();
                    chkBackImage.Checked = Convert.ToBoolean(SvCls.GblRdrToGetData["backImage"]);
                    SvCls.GblCon.Close();
                }
                else
                {
                    CboSalaryStyle.Text = "";
                    chkDollarRate.Checked = false;
                    txtPicPath.Text = "";
                    chkBackImage.Checked = false;
                }
            }

        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwPasswordChange == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lebHd.Text = "[ PASSWORD CHANGE ]";
                BlankAll();
                HideAllPnl();
                pnlPassChange.Visible = true;
                pnlPassChange.Left = 213;
                pnlPassChange.Top = 48;
                pnlPassChange.Width = 700;
                pnlPassChange.Height = 500;

                txtOldPwd.Select();

                lebUsrId.Text = "User Code:  " + ClsVar.GblUserId + "    User Name:  " + ClsVar.GblUserName;
            }
        }

        private void btnDbaseBak_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwDatabaseBackup == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                lebHd.Text = "[ DATABASE BACKUP ]";

                HideAllPnl();
                pnlDBaseBak.Visible = true;
                pnlDBaseBak.Left = 213;
                pnlDBaseBak.Top = 48;
                pnlDBaseBak.Width = 700;
                pnlDBaseBak.Height = 500;

                btnSelectBakLocation.Select();
            }
        }

        private void btnUserCreate_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwUserCreation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {

                lebHd.Text = "[ USER CREATION ]";
                BlankAll();
                HideAllPnl();
                pnlUserCrate.Visible = true;
                pnlUserCrate.Left = 213;
                pnlUserCrate.Top = 48;
                pnlUserCrate.Width = 700;
                pnlUserCrate.Height = 500;
                //GridSection.Width = 680;
                //GridSection.Height = 350;
                btnAddNewUser.Select();
                GridNewUser.DataSource = SvCls.GblDataTable("select UserCode,UserName FROM LoginUser where comid='" + ClsVar.GblComId + "'  order by UserCode ");
                GridNewUser.Refresh();
            }
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwSecurity == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
            lebHd.Text = "[ SECURITY UPDATE ]";

            HideAllPnl();
            pnlSecurity.Visible = true;
            pnlSecurity.Left = 213;
            pnlSecurity.Top = 48;
            pnlSecurity.Width = 700;
            pnlSecurity.Height = 500;
            GrdUserList.Width = 200;
            GridSection.Height = 250;

            GrdUserList.DataSource = SvCls.GblDataTable("select UserCode,UserName,ComID FROM LoginUser where comid='" + ClsVar.GblComId + "' order by UserCode");
            GrdUserList.Refresh();
            }
        }

        private void cmdExit_Click_1(object sender, EventArgs e)
        {
          
            
            this.Close();
        }

        private void btnShifTimeSetup_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwSiftingTime == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            { 
            lebHd.Text = "[ SHIFTING TIME SETUP ]";
            BlankAll();
            HideAllPnl();
            pnlShift.Visible = true;
            pnlShift.Left = 227;
            pnlShift.Top = 70;
            pnlShift.Width = 700;
            pnlShift.Height = 500;
            GridShift.Width = 680;
            GridShift.Height = 350;

            cboGroupName.Select();

            string Qry = "select distinct GroupID as CodeNo  from TimeGroup where comid='" + ClsVar.GblComId + "'";
            cboGroupName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboGroupName.DisplayMember = "CodeNo";
            cboGroupName.Text = "";
            GridShift.DataSource = SvCls.GblDataTable("select convert(varchar,SetupDate,103) as EffectiveFromDate,GroupId as ShiftName,convert(varchar,intimestartfrom,108) as InTimeStartFrom,convert(varchar,intime,108) as WorkStartFrom,convert(varchar,maxintime,108) as LateIfInTimeAfter,convert(varchar,OTStart,108) as OTStart,MaxOT as MaxOTForBuyer from timeGroup where comid='" + ClsVar.GblComId + "' order by setupdate desc");
            GridShift.Refresh();

            }
        }

        private void btnDesg_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwDesignation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lebHd.Text = "[ DESIGNATION INFORMATION ]";
                BlankAll();
                HideAllPnl();
                pnlDesg.Visible = true;
                pnlDesg.Left = 227;
                pnlDesg.Top = 70;
                pnlDesg.Width = 700;
                pnlDesg.Height = 500;
                GridDesg.Width = 680;
                GridDesg.Height = 350;

                CmdAddNewDesg.Select();

                string Qry = "select convert(varchar,CodeNo) + '~' + Name as codeno  from Designation where ComId='" + ClsVar.GblComId + "'";
                CboCodeNoDesg.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                CboCodeNoDesg.DisplayMember = "codeno";
                CboCodeNoDesg.Text = "";
                Grid_Head_Desg();
            }
        }

        private void CmdAddNewDesg_Click(object sender, EventArgs e)
        { //try
            //{
            string Qry1 = "select CodeNo from designation where ComId='" + ClsVar.GblComId + "'";
            if (SvCls.DataExist(Qry1) == "1")
            {
                SvCls.toGetData("select max(convert(int,CodeNo))+1 as CodeNo from designation where ComId='" + ClsVar.GblComId + "' and isnumeric(CodeNo)=1");
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboCodeNoDesg.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                    SvCls.GblCon.Close();
                }
            }
            else
            {
                CboCodeNoDesg.Text = "1";
            }

            txtNameDesg.Text = "";
            txtBNameDesg.Text = "";
            txtRmkDesg.Text = "";
            txtNameDesg.Select();

            txtNameDesg.Select();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void Grid_Head_Desg()
        {
            GridDesg.DataSource = SvCls.GblDataTable("select * FROM Designation where  ComId='" + ClsVar.GblComId + "' order by convert(money,codeno) ");
            GridDesg.Refresh();
        }

        private void cmdSaveDesg_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveDesignation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (CboCodeNoDesg.Text.Trim() == "")
                {
                    MessageBox.Show("Code No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    string qry = ("select * from designation where codeno=" + Convert.ToInt32(CboCodeNoDesg.Text.Trim()) + " and ComId='" + ClsVar.GblComId) + "'";

                    string CHK = SvCls.DataExist(qry);


                    if (CHK.ToString() == "1")
                    {
                        qry = "update designation set name='" + txtNameDesg.Text.Trim() + "',bname='" + txtBNameDesg.Text.Trim() + "', rmk='" + txtRmkDesg.Text.Trim() + "',PcName='" + ClsVar.GblPcName + "',UserCode=" + ClsVar.GblUserId + ",ComId='" + ClsVar.GblComId + "' where codeno=" + Convert.ToInt32(CboCodeNoDesg.Text.Trim());

                        lblMgs.ForeColor = System.Drawing.Color.Blue;
                        lblMgs.Visible = true;
                        lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                        PicSave.Visible = true;
                    }
                    else
                    {
                        qry = "insert into designation (codeno,name,bname,rmk,PcName,UserCode,ComId) values (" + CboCodeNoDesg.Text.Trim() + ",'" + txtNameDesg.Text.Trim() + "','" + txtBNameDesg.Text.Trim() + "','" + txtRmkDesg.Text.Trim() + "','" + ClsVar.GblPcName + "'," + ClsVar.GblUserId + ",'" + ClsVar.GblComId + "')";

                        lblMgs.ForeColor = System.Drawing.Color.Blue;
                        lblMgs.Visible = true;
                        lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                        PicSave.Visible = true;
                    }

                    SvCls.insertUpdate(qry);
                    Grid_Head_Desg();
                    CmdAddNewDesg.Select();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cmdDeleteDesg_Click(object sender, EventArgs e)
        {

            if (ClsVar.DelDesignation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (CboCodeNoDesg.Text.Trim() == "")
                {
                    MessageBox.Show("Code No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {

                    string qry = "select * from designation where codeno=" + CboCodeNoDesg.Text.Trim() + " and ComId='" + ClsVar.GblComId + "'";

                    string CHK = SvCls.DataExist(qry);

                    if (MessageBox.Show(" Do You Realy Want To Delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                        if (CHK.ToString() == "1")
                        {
                            qry = "delete from designation where codeno=" + CboCodeNoDesg.Text.Trim() + " and ComId='" + ClsVar.GblComId + "'";

                            lblMgs.ForeColor = System.Drawing.Color.Red;
                            PicSave.Visible = true;
                            lblMgs.Visible = true;
                            lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        }

                    SvCls.insertUpdate(qry);
                    Grid_Head_Desg();
                    CboCodeNoDesg.Text = "";
                    txtNameDesg.Text = "";
                    txtBNameDesg.Text = "";
                    txtRmkDesg.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CmdReportDesg_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (CboCodeNoDesg.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Designation.codeno}=" + CboCodeNoDesg.Text.Trim() + " and ";
            }

            if (ClsVar.GblSelFor != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + " {Designation.codeno}<>0";
            }

            ClsVar.GblHeadName = "Designation Information";
            ClsVar.GblRptName = "Designation.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();

        }

        private void GridDesg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridDesg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i = GridDesg.SelectedCells[0].RowIndex;
                CboCodeNoDesg.Text = GridDesg.Rows[i].Cells[0].Value.ToString();

                string Qry = "select * from designation where codeno=" + CboCodeNoDesg.Text.Trim() + " and ComId='" + ClsVar.GblComId + "'";
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("SELECT Name,BName,Rmk From designation where codeno=" + CboCodeNoDesg.Text.Trim() + " and ComId='" + ClsVar.GblComId + "'");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameDesg.Text = SvCls.GblRdrToGetData["Name"].ToString();
                        txtBNameDesg.Text = SvCls.GblRdrToGetData["BName"].ToString();
                        txtRmkDesg.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                        SvCls.GblCon.Close();
                    }
                }

                else
                {
                    txtNameDesg.Text = "";
                    txtBNameDesg.Text = "";
                    txtRmkDesg.Text = "";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwSection == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lebHd.Text = "[ SECITON INFORMATION ]";
                BlankAll();
                HideAllPnl();
                pnlSec.Visible = true;
                pnlSec.Left = 227;
                pnlSec.Top = 70;
                pnlSec.Width = 700;
                pnlSec.Height = 500;
                GridSection.Width = 680;
                GridSection.Height = 350;

                CmdAddNewSection.Select();

                string Qry = "select convert(varchar,CodeNo) + '~' + Name as codeno  from SectionTbl where ComId='" + ClsVar.GblComId + "'";
                CboCodeNoSection.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                CboCodeNoSection.DisplayMember = "codeno";
                CboCodeNoSection.Text = "";
                Grid_Head_Section();
            }
        }

        private void CmdAddNewSection_Click(object sender, EventArgs e)
        {
            string Qry1 = "select CodeNo from SectionTbl where ComId=" + ClsVar.GblComId;
            if (SvCls.DataExist(Qry1) == "1")
            {
                SvCls.toGetData("select max(convert(int,CodeNo))+1 as CodeNo from SectionTbl where comid='" + ClsVar.GblComId + "' and isnumeric(CodeNo)=1");
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboCodeNoSection.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                    SvCls.GblCon.Close();
                }
            }
            else
            {
                CboCodeNoSection.Text = "1";
            }
            txtNameSection.Text = "";
            txtBNameSection.Text = "";
            txtRmkSection.Text = "";
            txtNameSection.Select();

            txtNameSection.Select();
        }

        private void GridHeadDollarRate()
        {
            GridDollarRate.DataSource = SvCls.GblDataTable("select * FROM MonthlyTbl");
            GridDollarRate.Refresh();
        }

        private void Grid_Head_Section()
        {
            GridSection.DataSource = SvCls.GblDataTable("select * FROM SectionTbl where ComId=" + ClsVar.GblComId);
            GridSection.Refresh();
        }
        private void Grid_Head_Machine()
        {
            MachineGrid.DataSource = SvCls.GblDataTable("select Blockid as MachineID,BlockName as MachineName FROM Block Order By convert(MOney,BlockId)");
            MachineGrid.Refresh();
        }
        private void cmdSaveSection_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveSection == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (CboCodeNoSection.Text.Trim() == "")
                {
                    MessageBox.Show("Code No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string qry = "select * from SectionTbl where codeno=" + CboCodeNoSection.Text.Trim() + " and ComId=" + ClsVar.GblComId;

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "update SectionTbl set name='" + txtNameSection.Text.Trim() + "',bname='" + txtBNameSection.Text.Trim() + "', rmk='" + txtRmkSection.Text.Trim() + "',PcName='" + ClsVar.GblPcName + "',UserCode='" + ClsVar.GblUserId + "' where codeno=" + CboCodeNoSection.Text + " and ComId=" + ClsVar.GblComId;

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "insert into SectionTbl (codeno,name,bname,rmk,PcName,UserCode,ComId) values (" + CboCodeNoSection.Text.Trim() + ",'" + txtNameSection.Text.Trim() + "','" + txtBNameSection.Text.Trim() + "','" + txtRmkSection.Text.Trim() + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "','" + ClsVar.GblComId + "')";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }

                SvCls.insertUpdate(qry);

                Grid_Head_Section();
                CmdAddNewSection.Select();
            }
        }

        private void CmdReportSection_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (CboCodeNoSection.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{SectionTbl.codeno}=" + CboCodeNoSection.Text.Trim() + " and ";
            }

            if (ClsVar.GblSelFor != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + " {SectionTbl.codeno}<>0";
            }

            ClsVar.GblHeadName = "Section Information";
            ClsVar.GblRptName = "Section.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void GridSection_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i = GridSection.SelectedCells[0].RowIndex;
                CboCodeNoSection.Text = GridSection.Rows[i].Cells[0].Value.ToString();

                string Qry = "select * from SectionTbl where codeno=" + CboCodeNoSection.Text.Trim();
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("SELECT Name,BName,Rmk From SectionTbl where codeno=" + CboCodeNoSection.Text.Trim());
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameSection.Text = SvCls.GblRdrToGetData["Name"].ToString();
                        txtBNameSection.Text = SvCls.GblRdrToGetData["BName"].ToString();
                        txtRmkSection.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                        SvCls.GblCon.Close();

                    }
                }

                else
                {
                    txtNameSection.Text = "";
                    txtBNameSection.Text = "";
                    txtRmkSection.Text = "";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CboCodeNoSection_Leave(object sender, EventArgs e)
        {
            string temCodeNo = "";

            if (CboCodeNoSection.Text.Trim() == "")
            {
                txtNameSection.Text = "";
                txtBNameSection.Text = "";
                txtRmkSection.Text = "";
                return;
            }

            try
            {
                temCodeNo = CboCodeNoSection.Text.Trim().Substring(0, CboCodeNoSection.Text.Trim().IndexOf("~"));
            }
            catch
            {
                if (temCodeNo == "")
                {
                    temCodeNo = CboCodeNoSection.Text.Trim();
                }
            }
            string Qry = "select * from SectionTbl where codeno=" + Convert.ToInt32(temCodeNo) + " and ComId='" + ClsVar.GblComId + "'";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT CodeNo,Name,BName,Rmk From SectionTbl where codeno=" + Convert.ToInt32(temCodeNo));
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboCodeNoSection.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                    txtNameSection.Text = SvCls.GblRdrToGetData["Name"].ToString();
                    txtBNameSection.Text = SvCls.GblRdrToGetData["BName"].ToString();
                    txtRmkSection.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                    cmdSaveSection.Text = "&Edit";
                    SvCls.GblCon.Close();
                }
            }

            else
            {
                txtNameSection.Text = "";
                txtBNameSection.Text = "";
                txtRmkSection.Text = "";
                cmdSaveSection.Text = "&Save";
            }

        }


        private void CboCodeNoDesg_Leave(object sender, EventArgs e)
        {
             string temCodeNo = "";

            if (CboCodeNoDesg.Text.Trim() == "")
            {
                 return;
            }

            try
            {
                temCodeNo = CboCodeNoDesg.Text.Trim().Substring(0, CboCodeNoDesg.Text.Trim().IndexOf("~"));
            }
            catch
            {
                if (temCodeNo == "")
                {
                    temCodeNo = CboCodeNoDesg.Text.Trim();
                }
            } 
                
                string Qry = "select * from designation where codeno=" + Convert.ToInt32(temCodeNo) + " and ComId='" + ClsVar.GblComId + "'";
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("SELECT Name,BName,Rmk From designation where codeno=" + CboCodeNoDesg.Text.Trim() + " and ComId='" + ClsVar.GblComId + "'");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameDesg.Text = SvCls.GblRdrToGetData["Name"].ToString();
                        txtBNameDesg.Text = SvCls.GblRdrToGetData["BName"].ToString();
                        txtRmkDesg.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                        cmdSaveDesg.Text = "&Edit";
                        SvCls.GblCon.Close();
                    }


                    else
                    {
                        txtNameDesg.Text = "";
                        txtBNameDesg.Text = "";
                        txtRmkDesg.Text = "";
                        cmdSaveDesg.Text = "&Save";
                    }


                }


        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            lebHd.Text = "[ LINE INFORMATION ]";

            HideAllPnl();
            pnlLine.Visible = true;
            pnlLine.Left = 227;
            pnlLine.Top = 70;
            pnlLine.Width = 700;
            pnlLine.Height = 500;
            GridLine.Width = 680;
            GridLine.Height = 300;
            string Qry = "select convert(varchar,CodeNo) + '~' + Name as codeno  from Line where ComId='" + ClsVar.GblComId + "'";
            CboCodeNoLine.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboCodeNoLine.DisplayMember = "codeno";
            CboCodeNoLine.Text = "";
            Grid_Head_Line();
        }

        private void Grid_Head_Line()
        {
            GridLine.DataSource = SvCls.GblDataTable("select * from Line where ComId='" + ClsVar.GblComId + "'");
            GridLine.Refresh();
        }

        private void cmdSaveLine_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveLine == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string qry = "select * from Line where codeno=" + Convert.ToInt32(CboCodeNoLine.Text.Trim()) + " and ComId='" + ClsVar.GblComId + "'";

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "update Line set name='" + txtNameLine.Text.Trim() + "',bname='" + txtBNameLine.Text.Trim() + "', rmk='" + txtRmkLine.Text.Trim() + "',PcName='" + ClsVar.GblPcName + "',UserCode=" + ClsVar.GblUserId + " where codeno=" + Convert.ToInt32(CboCodeNoLine.Text) + " and ComId='" + ClsVar.GblComId + "'";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "insert into Line (codeno,name,bname,rmk,PcName,UserCode,ComId) values (" + Convert.ToInt32(CboCodeNoLine.Text.Trim()) + ",'" + txtNameLine.Text.Trim() + "','" + txtBNameLine.Text.Trim() + "','" + txtRmkLine.Text.Trim() + "','" + ClsVar.GblPcName + "'," + ClsVar.GblUserId + ",'" + ClsVar.GblComId + "')";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }

                SvCls.insertUpdate(qry);

                Grid_Head_Line();
            }
        }

        private void cmdDeleteLine_Click(object sender, EventArgs e)
        {

            if (ClsVar.DelLine == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string qry = "select * from Line where codeno=" + Convert.ToInt32(CboCodeNoLine.Text.Trim()) + " and ComId='" + ClsVar.GblComId + "'";

                string CHK = SvCls.DataExist(qry);

                if (MessageBox.Show(" Do You Realy Want To Delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (CHK.ToString() == "1")
                    {
                        qry = "delete from Line where codeno=" + Convert.ToInt32(CboCodeNoLine.Text.Trim()) + " and ComId='" + ClsVar.GblComId + "'";

                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        PicSave.Visible = true;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                    }

                SvCls.insertUpdate(qry);

                Grid_Head_Line();
                CboCodeNoLine.Text = "";
                txtNameLine.Text = "";
                txtBNameLine.Text = "";
                txtRmkLine.Text = "";
            }
        }

        private void CboCodeNoLine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboCodeNoLine_Leave(object sender, EventArgs e)
        {
            string temCodeNo = "0";

            try
            {
                if (CboCodeNoLine.Text.Trim() == "")
                {
                    txtNameLine.Text = "";
                    txtBNameLine.Text = "";
                    txtRmkLine.Text = "";
                    return;
                }


                temCodeNo = CboCodeNoLine.Text.Trim().Substring(0, CboCodeNoLine.Text.Trim().IndexOf("~"));

                string Qry = "select * from Line where codeno=" + Convert.ToInt32(temCodeNo) + " and ComId='" + ClsVar.GblComId + "'";
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("SELECT codeno,Name,BName,Rmk From Line where codeno=" + Convert.ToInt32(temCodeNo) + " and ComId='" + ClsVar.GblComId + "'");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        CboCodeNoLine.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                        txtNameLine.Text = SvCls.GblRdrToGetData["Name"].ToString();
                        txtBNameLine.Text = SvCls.GblRdrToGetData["BName"].ToString();
                        txtRmkLine.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                        SvCls.GblCon.Close();
                    }
                }
                else
                {
                    txtNameLine.Text = "";
                    txtBNameLine.Text = "";
                    txtRmkLine.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GridLine_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i = GridLine.SelectedCells[0].RowIndex;
                CboCodeNoLine.Text = GridLine.Rows[i].Cells[0].Value.ToString();

                string Qry = "select * from Line where codeno=" + CboCodeNoLine.Text.Trim() + " and ComId='" + ClsVar.GblComId + "'";
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("SELECT Name,BName,Rmk From Line where codeno=" + Convert.ToInt32(CboCodeNoLine.Text.Trim()) + " and ComId='" + ClsVar.GblComId + "'");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameLine.Text = SvCls.GblRdrToGetData["Name"].ToString();
                        txtBNameLine.Text = SvCls.GblRdrToGetData["BName"].ToString();
                        txtRmkLine.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                        SvCls.GblCon.Close();
                    }
                }
                else
                {
                    txtNameLine.Text = "";
                    txtBNameLine.Text = "";
                    txtRmkLine.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void GridLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmdAddNewLine_Click(object sender, EventArgs e)
        {
            string Qry1 = "select CodeNo from Line where ComId='" + ClsVar.GblComId + "'";
            if (SvCls.DataExist(Qry1) == "1")
            {
                SvCls.toGetData("select max(convert(int,CodeNo))+1 as CodeNo from Line where ComId=" + ClsVar.GblComId + " and isnumeric(CodeNo)=1");
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboCodeNoLine.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                    SvCls.GblCon.Close();
                }
            }
            else
            {
                CboCodeNoLine.Text = "1";
            }

            txtNameLine.Text = "";
            txtBNameLine.Text = "";
            txtRmkLine.Text = "";
        }

        private void btnSelectBakLocation_Click(object sender, EventArgs e)
        {

            string dback;
            dback = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");



            String Location = String.Empty;
            SaveFileDialog svf = new SaveFileDialog();

            svf.InitializeLifetimeService();
            svf.Filter = "SQL SERVER BACKUP(*.Bak)|*.Bak";


            ClsVar.FileName = ClsVar.DataBaseName + "-" + dback;
            svf.FileName = ClsVar.FileName;

            DialogResult ret = STAShowDialog(svf);
            if (ret == DialogResult.OK)

                Location = svf.FileName;
            ClsVar.FilePath = Location;

            txtDBakPath.Text = Location;
            btnSaveDBak.Select();

        }

        private void btnSaveDBak_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveDatabaseBackup == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txtDBakPath.Text.Trim() == "")
                {
                    MessageBox.Show("Please Select Location to Save Backup", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection cnn = new SqlConnection("Persist Security Info=False;User ID=sa;Password='" + ClsVar.SqlPassword + "';Initial Catalog='" + ClsVar.DataBaseName + "';Data Source='" + ClsVar.ServerName + "'");


                try
                {
                    cnn.Open();


                    SqlCommand cmd = new SqlCommand("DBase_backup", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@D_BaseMedia", SqlDbType.VarChar, 100));
                    cmd.Parameters["@D_BaseMedia"].Value = ClsVar.FileName;
                    cmd.Parameters.Add(new SqlParameter("@D_BasePath", SqlDbType.VarChar, 300));
                    cmd.Parameters["@D_BasePath"].Value = ClsVar.FilePath;
                    cmd.Parameters.Add(new SqlParameter("@D_BaseNAme", SqlDbType.VarChar, 30));
                    cmd.Parameters["@D_BaseNAme"].Value = ClsVar.DataBaseName;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Database backup Complete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cnn.Close();
            }
        }

        private void btnSavePwd_Click(object sender, EventArgs e)
        {
            if (ClsVar.SavePasswordChange == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txtOldPwd.Text.Trim() == "")
                {
                    MessageBox.Show("OLD Password Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string qry = "select * from loginuser where usercode='" + ClsVar.GblUserId + "' and password='" + txtOldPwd.Text.Trim() + "' and comid='" + ClsVar.GblComId + "'";

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "update loginuser set password='" + txtNewPwd.Text.Trim() + "' where usercode=" + ClsVar.GblUserId + " and comid='" + ClsVar.GblComId + "'";
                    SvCls.insertUpdate(qry);
                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "PASSWORD CHANGED SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    lblMgs.ForeColor = System.Drawing.Color.Red;
                    lblMgs.Visible = true;
                    lblMgs.Text = "WRONG OLD PASSWORD...!!";
                    //PicSave.Visible = true;
                }
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            btnAddNewUser.Enabled = false;
            txtUserName.Select();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveUserCreation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("Please Write User Name", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //btnAddNewUser.Enabled = true;
                string qry = "";

                if (btnAddNewUser.Enabled == false)
                {
                    qry = "insert into LoginUser (userName,password,comid) values ('" + txtUserName.Text + "','" + txtPwd.Text + "','" + ClsVar.GblComId + "')";
                    SvCls.insertUpdate(qry);
                    lblMgs.ForeColor = System.Drawing.Color.Red;
                    lblMgs.Visible = true;
                    lblMgs.Text = "Save Successfully...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "update LoginUser set userName='" + txtUserName.Text.Trim() + "',password='" + txtPwd.Text.Trim() + "' where usercode=" + Convert.ToInt32(txtNewUserCode.Text.Trim()) + " and comid='" + ClsVar.GblComId + "'";
                    SvCls.insertUpdate(qry);
                    lblMgs.ForeColor = System.Drawing.Color.Red;
                    lblMgs.Visible = true;
                    lblMgs.Text = "Edited Successfully...!!";
                    PicSave.Visible = true;
                }

                GridNewUser.DataSource = SvCls.GblDataTable("select UserCode,UserName FROM LoginUser where  comid='" + ClsVar.GblComId + "' order by UserCode");
                GridNewUser.Refresh();

            }
        }

        private void GridNewUser_DoubleClick(object sender, EventArgs e)
        {

            int i = GridNewUser.SelectedCells[0].RowIndex;
            txtNewUserCode.Text = GridNewUser.Rows[i].Cells[0].Value.ToString();
            if (txtNewUserCode.Text == "")
            {
                return;
            }
            string Qry = "select * from loginuser where usercode=" + Convert.ToInt32(txtNewUserCode.Text.Trim());
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT username,password From loginuser where usercode=" + Convert.ToInt32(txtNewUserCode.Text.Trim()));
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtUserName.Text = SvCls.GblRdrToGetData["userName"].ToString();
                    txtPwd.Text = SvCls.GblRdrToGetData["password"].ToString();
                    //txtRmkSection.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                    SvCls.GblCon.Close();

                }
            }

            else
            {

                txtPwd.Text = "";
                txtUserName.Text = "";
            }

        }
        
        private void btnSaveShift_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveSiftingTime == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cboGroupName.Text.Trim() == "")
                {
                    MessageBox.Show("Shift Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string qry = "select * from timeGroup where setupdate=convert(datetime,'" + DtpFromDate.Value.ToShortDateString() + "',103) and groupId='" + cboGroupName.Text.Trim() + "' and ComId='" + ClsVar.GblComId + "'";

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "update timegroup set intime=convert(datetime,'" + mskWorkStartFrom.Text.Trim() + "',103),outtime=convert(datetime,'" + mskOutTime.Text.Trim() + "',103),intimestartfrom=convert(datetime,'" + mskInTimeStart.Text.Trim() + "',103),otstart=convert(datetime,'" + mskOTStart.Text.Trim() + "',103),maxintime=convert(datetime,'" + mskMaxInTime.Text.Trim() + "',103),maxot=" + Convert.ToDouble(txtMaxOT.Text.Trim()) + " where setupdate=convert(datetime,'" + DtpFromDate.Value.ToShortDateString() + "',103) AND groupid='" + cboGroupName.Text.Trim() + "' and ComId='" + ClsVar.GblComId + "'";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "insert into Timegroup (GroupId,Setupdate,InTime,Outtime,IntimeStartFrom,OtStart,MaxOT,MaxInTime,ComId) values ('" + cboGroupName.Text.Trim() + "',convert(datetime,'" + DtpFromDate.Value.ToShortDateString() + "',103),convert(datetime,'" + mskWorkStartFrom.Text.Trim() + "',103),convert(datetime,'" + mskOutTime.Text.Trim() + "',103),convert(datetime,'" + mskInTimeStart.Text.Trim() + "',103),convert(datetime,'" + mskOTStart.Text.Trim() + "',103)," + Convert.ToDouble(txtMaxOT.Text.Trim()) + ",convert(datetime,'" + mskMaxInTime.Text.Trim() + "',103),'" + ClsVar.GblComId + "')";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }

                SvCls.insertUpdate(qry);

                GridShift.DataSource = SvCls.GblDataTable("select convert(varchar,SetupDate,103) as EffectiveFromDate,GroupId as ShiftName,convert(varchar,intimestartfrom,108) as InTimeStartFrom,convert(varchar,intime,108) as WorkStartFrom,convert(varchar,maxintime,108) as LateIfInTimeAfter,convert(varchar,OTStart,108) as OTStart,MaxOT as MaxOTForBuyer from timeGroup where comid='" + ClsVar.GblComId + "'");
                GridShift.Refresh();
            }
        }

        private void GridShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridShift_DoubleClick(object sender, EventArgs e)
        {
            int i = GridShift.SelectedCells[0].RowIndex;
            cboGroupName.Text = GridShift.Rows[i].Cells[1].Value.ToString();
            DtpFromDate.Text = GridShift.Rows[i].Cells[0].Value.ToString();

            string Qry = "select convert(varchar,SetupDate,103) as EffectiveFromDate,GroupId as ShiftName,convert(varchar,intimestartfrom,108) as InTimeStartFrom,convert(varchar,intime,108) as WorkStartFrom,convert(varchar,maxintime,108) as LateIfInTimeAfter,convert(varchar,OutTime,108) as OutTime,convert(varchar,OTStart,108) as OTStart,MaxOT as MaxOTForBuyer from timeGroup where groupid='" + cboGroupName.Text.Trim() + "' and setupdate=convert(datetime,'" + DtpFromDate.Value.ToShortDateString() + "',103) and comid='" + ClsVar.GblComId + "'";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtMaxOT.Text = SvCls.GblRdrToGetData["MaxOTForBuyer"].ToString();
                    mskInTimeStart.Text = SvCls.GblRdrToGetData["InTimeStartFrom"].ToString();
                    mskMaxInTime.Text = SvCls.GblRdrToGetData["lateIfIntimeAfter"].ToString();
                    mskOTStart.Text = SvCls.GblRdrToGetData["OTStart"].ToString();
                    mskWorkStartFrom.Text = SvCls.GblRdrToGetData["WorkStartFrom"].ToString();
                    mskOutTime.Text = SvCls.GblRdrToGetData["OutTime"].ToString();

                    SvCls.GblCon.Close();
                }
            }
        }

        private void btnDelShift_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelSiftingTime == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cboGroupName.Text.Trim() == "")
                {
                    MessageBox.Show("Shift Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string qry = "select * from timeGroup where setupdate=convert(datetime,'" + DtpFromDate.Value.ToShortDateString() + "',103) and groupId='" + cboGroupName.Text.Trim() + "' and ComId='" + ClsVar.GblComId + "'";

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "delete from timegroup  where setupdate=convert(datetime,'" + DtpFromDate.Value.ToShortDateString() + "',103) and groupid='" + cboGroupName.Text.Trim() + "' and ComId='" + ClsVar.GblComId + "'";
                    SvCls.insertUpdate(qry);

                    GridShift.DataSource = SvCls.GblDataTable("select convert(varchar,SetupDate,103) as EffectiveFromDate,GroupId as ShiftName,convert(varchar,intimestartfrom,108) as InTimeStartFrom,convert(varchar,intime,108) as WorkStartFrom,convert(varchar,maxintime,108) as LateIfInTimeAfter,convert(varchar,OTStart,108) as OTStart,MaxOT as MaxOTForBuyer from timeGroup where comid='" + ClsVar.GblComId + "'");
                    GridShift.Refresh();

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "DELETED SUCCESSFULLY...!!";
                    PicSave.Visible = true;

                }
                else
                {

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "NO ITEM FOUND TO DELETE...!!";
                    PicSave.Visible = true;
                }


            }
        }

        private void cmdSaveBr_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveBrance == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (CboCodeBr.Text.Trim() == "")
                {
                    MessageBox.Show("Code No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string SaveQry;
                string SelectQry;
                string EdtQry;

                SaveQry = "insert into Branch (comid,name,bname,rmk,Address,Phone,Email,Rpthead,PcName,UserCode) values ('" + CboCodeBr.Text + "','" + txtNameBr.Text.Trim() + "','" + txtBnameBr.Text.Trim() + "','" + txtRmkBr.Text.Trim() + "','" + txtAddressBr.Text.Trim() + "','" + txtPhoneBr.Text.Trim() + "','" + txtMailBr.Text.Trim() + "','" + txtHeadBr.Text.Trim() + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
                SelectQry = "select * from Branch where comid='" + CboCodeBr.Text.Trim() + "'";
                EdtQry = "update Branch set name='" + txtNameBr.Text.Trim() + "',bname='" + txtBnameBr.Text.Trim() + "', rmk='" + txtRmkBr.Text.Trim() + "',Address='" + txtAddressBr.Text.Trim() + "',Phone='" + txtPhoneBr.Text.Trim() + "',Email='" + txtMailBr.Text.Trim() + "',Rpthead='" + txtHeadBr.Text.Trim() + "',PcName='" + ClsVar.GblPcName + "',UserCode ='" + ClsVar.GblUserId + "' where comid='" + CboCodeBr.Text.Trim() + "'";



                if (SvCls.DataExist(SelectQry).ToString() == "0")
                {
                    


                    SvCls.GblCon.Open();
                    SvCls.GblSqlCmd.Connection = SvCls.GblCon;
                    SvCls.GblSqlCmd.CommandText = "SpInsertMstrData";
                    SvCls.GblSqlCmd.CommandType = CommandType.StoredProcedure;

                    SvCls.GblSqlCmd.Parameters.Add("@PCName", SqlDbType.VarChar, 100);
                    SvCls.GblSqlCmd.Parameters["@PCName"].Value = ClsVar.GblPcName;
                    SvCls.GblSqlCmd.Parameters.Add("@CompanyName", SqlDbType.VarChar, 100);
                    SvCls.GblSqlCmd.Parameters["@CompanyName"].Value = txtNameBr.Text.Trim();
                    SvCls.GblSqlCmd.Parameters.Add("@phone", SqlDbType.VarChar, 100);
                    SvCls.GblSqlCmd.Parameters["@phone"].Value = txtPhoneBr.Text.Trim();

                    SvCls.GblSqlCmd.ExecuteNonQuery();
                    SvCls.GblSqlCmd.Parameters.Clear();
                    SvCls.GblCon.Close();

                    //SvCls.insertUpdate(SaveQry);

                    lblMgs.Visible = true;
                    lblMgs.Text = "Save Successfully";



                }
                else
                {
                    SvCls.insertUpdate(EdtQry);


                    lblMgs.Visible = true;
                    lblMgs.Text = "Edited Successfully";



                }

                PicSave.Visible = true;

                GridBr.DataSource = SvCls.GblDataTable("select * from Branch");
                //GridBr.Refresh;
            }
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwBrance == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lebHd.Text = "[ BRANCH INFORMATION ]";
                BlankAll();
                HideAllPnl();
                pnlBr.Visible = true;
                pnlBr.Left = 213;
                pnlBr.Top = 48;
                pnlBr.Width = 700;
                pnlBr.Height = 500;
                GridBr.Width = 680;
                GridBr.Height = 250;
                string qry;

                cmdAddBr.Select();

                qry = "Select comid + '~' + name as code from Branch Order by comid";

                CboCodeBr.DataSource = SvCls.GblDataSet(qry).Tables[0];
                CboCodeBr.DisplayMember = "code";
                CboCodeBr.Text = "";

                GridBr.DataSource = SvCls.GblDataTable("select * from Branch");
            }//GridBr.Refresh;
        }

        private void cmdAddBr_Click(object sender, EventArgs e)
        {

            string selectqry;
            selectqry = "select max(convert(int,comid))+1 as comid from Branch";
            SvCls.toGetData(selectqry);
            if (SvCls.GblRdrToGetData.Read())
            {

                CboCodeBr.Text = SvCls.GblRdrToGetData["comid"].ToString();
                SvCls.GblCon.Close();

            }
            if (CboCodeBr.Text == "")
            {
                CboCodeBr.Text = "1";
            }



            txtNameBr.Text = "";
            txtBnameBr.Text = "";
            txtRmkBr.Text = "";
            txtHeadBr.Text = "";
            txtAddressBr.Text = "";
            txtMailBr.Text = "";
            txtPhoneBr.Text = "";

            txtNameBr.Select();
        }

        private void cmdDeleteBr_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelBrance == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (CboCodeBr.Text.Trim() == "")
                {
                    MessageBox.Show("Code No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string deleteQry;
                string selectQry;


                selectQry = "select * from Branch where comid='" + CboCodeBr.Text + "'";
                deleteQry = "delete from Branch where comid='" + CboCodeBr.Text + "'";



                if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)


                    if (SvCls.DataExist(selectQry).ToString() == "1")
                    {
                        SvCls.insertUpdate(deleteQry);
                        label1.Visible = true;
                        label1.Text = "Delete Successfully";
                        //label1.BackColor = System.Drawing.Color.MistyRose;

                        txtNameBr.Text = "";
                        txtBnameBr.Text = "";
                        txtRmkBr.Text = "";
                        txtPhoneBr.Text = "";
                        txtMailBr.Text = "";
                        txtHeadBr.Text = "";
                        txtAddressBr.Text = "";
                        GridBr.DataSource = SvCls.GblDataTable("select * from Branch");
                    }
            }
        }
        
        private void CboCodeBr_Leave(object sender, EventArgs e)
        {

            if (CboCodeBr.Text.Trim() == "")
            {
                return;
            }


            try
            {
                CboCodeBr.Text = CboCodeBr.Text.Substring(0, CboCodeBr.Text.IndexOf("~"));
            }
            catch
            {

            }

            try
            {


                string selectQry;
                selectQry = "select * from Branch where comid=" + CboCodeBr.Text;
                if (SvCls.DataExist(selectQry).ToString() == "1")
                {
                    SvCls.toGetData("select name,bname,rmk,Phone,Email,Rpthead,Address from Branch where comid='" + CboCodeBr.Text + "'");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameBr.Text = SvCls.GblRdrToGetData["name"].ToString();
                        txtBnameBr.Text = SvCls.GblRdrToGetData["bname"].ToString();
                        txtRmkBr.Text = SvCls.GblRdrToGetData["rmk"].ToString();
                        txtPhoneBr.Text = SvCls.GblRdrToGetData["Phone"].ToString();
                        txtMailBr.Text = SvCls.GblRdrToGetData["Email"].ToString();
                        txtHeadBr.Text = SvCls.GblRdrToGetData["Rpthead"].ToString();
                        txtAddressBr.Text = SvCls.GblRdrToGetData["Address"].ToString();
                        cmdSaveBr.Text = "&Edit";
                        //pic1.Image = rdr["pht"].ToString();
                        SvCls.GblCon.Close();
                        //imageshow();
                    }

                    else
                    {
                        txtNameBr.Text = "";
                        txtBnameBr.Text = "";
                        txtRmkBr.Text = "";
                        txtAddressBr.Text = "";
                        txtHeadBr.Text = "";
                        txtMailBr.Text = "";
                        txtPhoneBr.Text = "";
                        SvCls.GblCon.Close();
                        cmdSaveBr.Text = "&Save";
                    }
                }


                //imageshow();

            }

            catch
            {
            }

        }

        private void GridBr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridBr_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = GridBr.SelectedCells[0].RowIndex;
                CboCodeBr.Text = GridBr.Rows[i].Cells[0].Value.ToString();
                string selectQry;
                selectQry = "select * from Branch where comid='" + CboCodeBr.Text.Trim() + "'";
                if (SvCls.DataExist(selectQry).ToString() == "1")
                {
                    SvCls.toGetData("select name,bname,rmk,Phone,Email,Rpthead,Address from Branch where comid='" + CboCodeBr.Text.Trim() + "'");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameBr.Text = SvCls.GblRdrToGetData["name"].ToString();
                        txtBnameBr.Text = SvCls.GblRdrToGetData["bname"].ToString();
                        txtRmkBr.Text = SvCls.GblRdrToGetData["rmk"].ToString();
                        txtPhoneBr.Text = SvCls.GblRdrToGetData["Phone"].ToString();
                        txtMailBr.Text = SvCls.GblRdrToGetData["Email"].ToString();
                        txtHeadBr.Text = SvCls.GblRdrToGetData["Rpthead"].ToString();
                        txtAddressBr.Text = SvCls.GblRdrToGetData["Address"].ToString();
                        ClsVar.GblAddress  = SvCls.GblRdrToGetData["Address"].ToString();
                        ClsVar.GblComName = SvCls.GblRdrToGetData["name"].ToString();
                        ClsVar.GblComId  = CboCodeBr.Text.Trim();
                        //pic1.Image = rdr["pht"].ToString();
                        SvCls.GblCon.Close();
                    }

                    else
                    {
                        txtNameBr.Text = "";
                        txtBnameBr.Text = "";
                        txtRmkBr.Text = "";
                        txtAddressBr.Text = "";
                        txtHeadBr.Text = "";
                        txtMailBr.Text = "";
                        txtPhoneBr.Text = "";
                        SvCls.GblCon.Close();
                    }
                }
            }
            catch
            {
            }
        }

        private void GridDesg_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridDesg_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                int i = GridDesg.SelectedCells[0].RowIndex;
                CboCodeNoDesg.Text = GridDesg.Rows[i].Cells[0].Value.ToString();

                string Qry = "select * from designation where codeno=" + Convert.ToInt32(CboCodeNoDesg.Text.Trim()) + " and ComId='" + ClsVar.GblComId + "'";
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("SELECT Name,BName,Rmk From designation where codeno=" + Convert.ToInt32(CboCodeNoDesg.Text.Trim()) + " and ComId=" + ClsVar.GblComId + " ");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameDesg.Text = SvCls.GblRdrToGetData["Name"].ToString();
                        txtBNameDesg.Text = SvCls.GblRdrToGetData["BName"].ToString();
                        txtRmkDesg.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                        SvCls.GblCon.Close();
                    }
                }

                else
                {
                    txtNameDesg.Text = "";
                    txtBNameDesg.Text = "";
                    txtRmkDesg.Text = "";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            lebHd.Text = "[ DEPARTMENT INFORMATION ]";

            HideAllPnl();
            pnlDept.Visible = true;
            pnlDept.Left = 227;
            pnlDept.Top = 70;
            pnlDept.Width = 700;
            pnlDept.Height = 500;
            GridDepartment.Width = 680;
            GridDepartment.Height = 350;
            string Qry = "select convert(varchar,CodeNo) + '~' + Name as codeno  from Department where ComId='" + ClsVar.GblComId + "'";
            CboCodeDept.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboCodeDept.DisplayMember = "codeno";
            CboCodeDept.Text = "";

            Qry = "select codeno,name,bname,rmk from Department where comid ='" + ClsVar.GblComId + "'";

            GridDepartment.DataSource = SvCls.GblDataTable(Qry);
        }

        private void cmdAddDept_Click(object sender, EventArgs e)
        {

            string selectqry;
            selectqry = "select max(convert(int,CodeNo))+1 as CodeNo from Department where comid='" + ClsVar.GblComId + "' and isnumeric(codeno)=1";
            SvCls.toGetData(selectqry);

            if (SvCls.GblRdrToGetData.Read())
            {
                CboCodeDept.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                SvCls.GblCon.Close();
            }

            if (CboCodeDept.Text == "")
            {
                CboCodeDept.Text = "100";
            }
            txtNameDept.Text = "";
            txtBNameDept.Text = "";
            txtRmkDept.Text = "";

        }

        private void cmdSaveDept_Click(object sender, EventArgs e)
        {
            
            string SaveQry;
            string SelectQry;
            string EdtQry;


            SaveQry = "insert into Department (codeno,name,bname,rmk,comid,PcName,UserCode) values (" + CboCodeDept.Text.Trim() + ",'" + txtNameDept.Text.Trim() + "','" + txtBNameDept.Text.Trim() + "','" + txtRmkDept.Text.Trim() + "','" + ClsVar.GblComId + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            SelectQry = "select * from Department where comid='" + ClsVar.GblComId + "' and  codeno=" + CboCodeDept.Text;
            EdtQry = "update Department set name='" + txtNameDept.Text.Trim() + "',bname='" + txtBNameDept.Text.Trim() + "', rmk='" + txtRmkDept.Text.Trim() + "',PcName='" + ClsVar.GblPcName + "',UserCode ='" + ClsVar.GblUserId + "' where comid='" + ClsVar.GblComId + "'  and  codeno=" + CboCodeDept.Text;

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {


                SvCls.insertUpdate(SaveQry);
                label1.Visible = true;
                label1.Text = "Save Successfully";


            }
            else
            {
                SvCls.insertUpdate(EdtQry);


                label1.Visible = true;
                label1.Text = "Edited Successfully";



            }
            string qry = "select codeno,name,bname,rmk from Department where comid ='" + ClsVar.GblComId + "'";

            GridDepartment.DataSource = SvCls.GblDataTable(qry);
        }

        private void cmdDeleteDept_Click(object sender, EventArgs e)
        {

            string deleteQry;
            string selectQry;


            selectQry = "select * from Department where comid= '" + ClsVar.GblComId + "' and codeno=" + CboCodeDept.Text;
            deleteQry = "delete from Department where comid= '" + ClsVar.GblComId + "' and codeno=" + CboCodeDept.Text;



            if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                if (SvCls.DataExist(selectQry).ToString() == "1")
                {
                    SvCls.insertUpdate(deleteQry);
                    label1.Visible = true;
                    label1.Text = "Delete Successfully";


                    txtNameDept.Text = "";
                    txtBNameDept.Text = "";
                    txtRmkDept.Text = "";
                    string qry = "select codeno,name,bname,rmk from Department where comid ='" + ClsVar.GblComId + "'";

                    GridDepartment.DataSource = SvCls.GblDataTable(qry);
                }


        }

        private void CboCodeDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboCodeDept_Leave(object sender, EventArgs e)
        {
            if (CboCodeDept.Text.Trim() == "")
            {
                return;
            }

            try
            {
                CboCodeDept.Text = CboCodeDept.Text.Substring(0, CboCodeDept.Text.IndexOf("~"));
            }

            catch
            {

            }



            try
            {


                string selectQry;

                selectQry = "select * from Department where comid='" + ClsVar.GblComId + "' and codeno = " + Convert.ToInt32(CboCodeDept.Text.Trim());

                if (SvCls.DataExist(selectQry) == "1")
                {
                    SvCls.toGetData("select name,bname,rmk from Department where  comid ='" + ClsVar.GblComId + "' and codeno =" + Convert.ToInt32(CboCodeDept.Text.Trim()));
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameDept.Text = SvCls.GblRdrToGetData["name"].ToString();
                        txtBNameDept.Text = SvCls.GblRdrToGetData["bname"].ToString();
                        txtRmkDept.Text = SvCls.GblRdrToGetData["rmk"].ToString();
                        SvCls.GblCon.Close();
                    }
                }

                else
                {
                    txtNameDept.Text = "";
                    txtBNameDept.Text = "";
                    txtRmkDept.Text = "";
                    SvCls.GblCon.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void GridDepartment_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = GridDepartment.SelectedCells[0].RowIndex;
                CboCodeDept.Text = GridDepartment.Rows[i].Cells[0].Value.ToString();
                string selectQry;

                selectQry = "select * from Department where comid= '" + ClsVar.GblComId + "' and codeno=" + Convert.ToInt32(CboCodeDept.Text.Trim());


                if (SvCls.DataExist(selectQry) == "1")
                {
                    SvCls.toGetData("select name,bname,rmk from Department where comid= '" + ClsVar.GblComId + "' and codeno=" + Convert.ToInt32(CboCodeDept.Text.Trim()));
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameDept.Text = SvCls.GblRdrToGetData["name"].ToString();
                        txtBNameDept.Text = SvCls.GblRdrToGetData["bname"].ToString();
                        txtRmkDept.Text = SvCls.GblRdrToGetData["rmk"].ToString();
                        SvCls.GblCon.Close();
                    }
                }

                else
                {
                    txtNameDept.Text = "";
                    txtBNameDept.Text = "";
                    txtRmkDept.Text = "";
                    SvCls.GblCon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            lebHd.Text = "[ GRADE INFORMATION ]";


            HideAllPnl();
            pnlGrade.Visible = true;
            pnlGrade.Left = 227;
            pnlGrade.Top = 70;
            pnlGrade.Width = 700;
            pnlGrade.Height = 500;
            GridGrade.Width = 680;
            GridGrade.Height = 300;
            string Qry = "select convert(varchar,CodeNo) + '~' + Name as codeno  from Grade where ComId='" + ClsVar.GblComId + "'";
            CboCodeGrade.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboCodeGrade.DisplayMember = "codeno";
            CboCodeGrade.Text = "";

            GridGrade.DataSource = SvCls.GblDataTable("select * FROM Grade where comid='" + ClsVar.GblComId + "'");
            GridGrade.Refresh();

        }

        private void cmdAddGrade_Click(object sender, EventArgs e)
        {


            string qry;
            string selectqry;
            qry = "select * from Grade where comid ='" + ClsVar.GblComId + "'";

            selectqry = "select max(CodeNo)+1 as CodeNo from Grade where comid= '" + ClsVar.GblComId + "' and isnumeric(CodeNo)=1";
            if (SvCls.DataExist(qry).ToString() == "1")
            {

                SvCls.toGetData(selectqry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboCodeGrade.Text = SvCls.GblRdrToGetData["CodeNo"].ToString();
                    SvCls.GblCon.Close();
                }


                else
                {
                    CboCodeGrade.Text = "1";
                }
            }
            txtNameGrade.Text = "";
            txtBNameGrade.Text = "";
            txtRmkGrade.Text = "";


        }

        private void cmdSaveGrade_Click(object sender, EventArgs e)
        {
            
            string SaveQry;
            string SelectQry;
            string EdtQry;


            SaveQry = "insert into Grade (codeno,name,bname,rmk,comid,PcName,UserCode) values (" + CboCodeGrade.Text.Trim() + ",'" + txtNameGrade.Text.Trim() + "','" + txtBNameGrade.Text.Trim() + "','" + txtRmkGrade.Text.Trim() + "','" + ClsVar.GblComId + "','" + ClsVar.GblPcName + "','" + ClsVar.GblUserId + "')";
            SelectQry = "select * from Grade where comid= '" + ClsVar.GblComId + "' and codeno=" + CboCodeGrade.Text;
            EdtQry = "update Grade set name='" + txtNameGrade.Text.Trim() + "',bname='" + txtBNameGrade.Text.Trim() + "', rmk='" + txtRmkGrade.Text.Trim() + "',comid='" + ClsVar.GblComId + "',PcName='" + ClsVar.GblPcName + "',Usercode='" + ClsVar.GblUserId + "' where comid= '" + ClsVar.GblComId + "' and codeno=" + CboCodeGrade.Text;





            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {

                SvCls.insertUpdate(SaveQry);

                label1.Visible = true;
                label1.Text = "Save Successfully";


            }
            else
            {


                SvCls.insertUpdate(EdtQry);
                label1.Visible = true;
                label1.Text = "Edited Successfully";



            }

            GridGrade.DataSource = SvCls.GblDataTable("select * FROM Grade where comid='" + ClsVar.GblComId + "'");
            GridGrade.Refresh();
        }

        private void cmdDeleteGrade_Click(object sender, EventArgs e)
        {


            string deleteQry;
            string selectQry;


            selectQry = "select * from Grade where comid= '" + ClsVar.GblComId + "' and codeno=" + CboCodeGrade.Text;
            deleteQry = "delete from Grade where comid= '" + ClsVar.GblComId + "' and codeno=" + CboCodeGrade.Text;



            if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)


                if (SvCls.DataExist(selectQry) == "1")
                {

                    SvCls.insertUpdate(deleteQry);
                    label1.Visible = true;
                    label1.Text = "Delete Successfully";


                    txtNameGrade.Text = "";
                    txtBNameGrade.Text = "";
                    txtRmkGrade.Text = "";
                    GridGrade.DataSource = SvCls.GblDataTable("select * FROM Grade");
                    GridGrade.Refresh();
                }


        }

        private void CboCodeGrade_Leave(object sender, EventArgs e)
        {

            if (CboCodeGrade.Text.Trim() == "")
            {
                return;
            }


            try
            {
                CboCodeGrade.Text = CboCodeGrade.Text.Substring(0, CboCodeGrade.Text.IndexOf("~"));
            }
            catch
            {

            }

            try
            {


                string selectQry;

                selectQry = "select * from Grade where comid= '" + ClsVar.GblComId + "' and codeno=" + CboCodeGrade.Text;


                if (SvCls.DataExist(selectQry) == "1")
                {
                    SvCls.toGetData("select name,bname,rmk from Grade where comid= '" + ClsVar.GblComId + "' and codeno =" + CboCodeGrade.Text);
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameGrade.Text = SvCls.GblRdrToGetData["name"].ToString();
                        txtBNameGrade.Text = SvCls.GblRdrToGetData["bname"].ToString();
                        txtRmkGrade.Text = SvCls.GblRdrToGetData["rmk"].ToString();
                        SvCls.GblCon.Close();
                    }
                }

                else
                {
                    txtNameGrade.Text = "";
                    txtBNameGrade.Text = "";
                    txtRmkGrade.Text = "";
                    SvCls.GblCon.Close();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SvCls.GblCon.Close();
            }
        }

        private void GridGrade_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = GridGrade.SelectedCells[0].RowIndex;
                CboCodeGrade.Text = GridGrade.Rows[i].Cells[0].Value.ToString();
                string selectQry;

                selectQry = "select * from Grade where comid= '" + ClsVar.GblComId + "' and codeno=" + CboCodeGrade.Text;


                if (SvCls.DataExist(selectQry) == "1")
                {
                    SvCls.toGetData("select name,bname,rmk from Grade where comid= '" + ClsVar.GblComId + "' and codeno='" + CboCodeGrade.Text + "'");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtNameGrade.Text = SvCls.GblRdrToGetData["name"].ToString();
                        txtBNameGrade.Text = SvCls.GblRdrToGetData["bname"].ToString();
                        txtRmkGrade.Text = SvCls.GblRdrToGetData["rmk"].ToString();
                        SvCls.GblCon.Close();
                    }
                }

                else
                {
                    txtNameGrade.Text = "";
                    txtBNameGrade.Text = "";
                    txtRmkGrade.Text = "";
                    SvCls.GblCon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GrdUserList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i = GrdUserList.SelectedCells[0].RowIndex;
                txtUserCodeSecurity.Text = GrdUserList.Rows[i].Cells[0].Value.ToString();

                string Qry = "select * from loginuser where comid='" + ClsVar.GblComId + "' and usercode=" + Convert.ToInt32(txtUserCodeSecurity.Text.Trim());
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("SELECT username From loginuser where comid='" + ClsVar.GblComId + "' and  usercode=" + Convert.ToInt32(txtUserCodeSecurity.Text.Trim()));
                    if (SvCls.GblRdrToGetData.Read())
                    {
                       lebUserNameSecurity.Text = SvCls.GblRdrToGetData["userName"].ToString();
                       SvCls.GblCon.Close();


                    }


                    SvCls.toGetData("SELECT * From security where comid='" + ClsVar.GblComId + "' and  uid=" + Convert.ToInt32(txtUserCodeSecurity.Text.Trim()) + "");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        string G = SvCls.GblRdrToGetData["Kn"].ToString();
                        string M = SvCls.GblRdrToGetData["Sw"].ToString();
                        string H = SvCls.GblRdrToGetData["HRm"].ToString();
                        SvCls.GblCon.Close();

                        if (G == "1")
                        {
                            chkG.Checked = true;
                        }
                        else
                        {
                            chkG.Checked = false;
                        }

                        if (M == "1")
                        {
                            chkM.Checked = true;
                        }
                        else
                        {
                            chkM.Checked = false;
                        }

                        if (H == "1")
                        {
                            chkHrm.Checked = true;
                        }
                        else
                        {
                            chkHrm.Checked = false;
                        }
                    }

                    else
                    {
                        chkG.Checked = false;
                        chkM.Checked = false;
                        chkHrm.Checked = false;
                    }

                    if (chkCopy.Checked  == false)
                    {
                        GrdSecurity.DataSource = SvCls.GblDataTable("select SCREEN,Convert(bit,S) as SaveSts,convert(bit,E) as EditSts,convert(bit,D) as DelSts,convert(bit,V) as VWSts FROM security where  comid='" + ClsVar.GblComId + "' and UserCode=" + Convert.ToInt32(txtUserCodeSecurity.Text.Trim()) + "  order by SCREEN");
                        GrdSecurity.Refresh();
                    }
                }

                else
                {
                    lebUserNameSecurity.Text = "";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void GrdSecurity_KeyPress(object sender, KeyPressEventArgs e)
        {

            //GrdSecurity.ReadOnly = true;

        }

        private void btnSaveSecurity_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveSecurity == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int cnt = 0;

                cnt = GrdSecurity.Rows.Count;

                string qry = "delete from security where comid='" +  ClsVar.GblComId + "' and Uid=" + Convert.ToInt32((txtUserCodeSecurity.Text.Trim()));
                SvCls.insertUpdate(qry);

                int i = 0;
                do
                {
                    qry = "insert security (usercode,SCREEN,S,E,D,V,comid,uid) Values( " + Convert.ToInt32(txtUserCodeSecurity.Text.Trim()) + ",'" + GrdSecurity.Rows[i].Cells[0].Value.ToString() + "'," + Convert.ToInt16(GrdSecurity.Rows[i].Cells[1].Value) + "," + Convert.ToInt16(GrdSecurity.Rows[i].Cells[2].Value) + "," + Convert.ToInt16(GrdSecurity.Rows[i].Cells[3].Value) + "," + Convert.ToInt16(GrdSecurity.Rows[i].Cells[4].Value) + ",'" + ClsVar.GblComId + "','" + txtUserCodeSecurity.Text.Trim() + "')";
                    SvCls.insertUpdate(qry);
                    i = i + 1;
                } while (i < GrdSecurity.Rows.Count - 1);

                chkCopy.Checked  = false;

                lblMgs.ForeColor = System.Drawing.Color.Green;
                lblMgs.Visible = true;
                lblMgs.Text = "Save Successfully...!!";
                PicSave.Visible = true;


                if (txtUserCodeSecurity.Text.Trim() == "")
                {
                    return;
                }

                string MQry = "Update Security Set Sw =" + Convert.ToInt16(chkM.Checked) + " where UID =" + txtUserCodeSecurity.Text.Trim() + "";
                SvCls.insertUpdate(MQry);

                string GQry = "Update Security Set Kn = " + Convert.ToInt16(chkG.Checked) + " where UID =" + txtUserCodeSecurity.Text.Trim() + "";
                SvCls.insertUpdate(GQry);

                string HrmQry = "Update Security Set Hrm = " + Convert.ToInt16(chkHrm.Checked) + " where UID =" + txtUserCodeSecurity.Text.Trim() + "";
                SvCls.insertUpdate(HrmQry);

            }
        }

        private void btnSel1_Click(object sender, EventArgs e)
        {

            int i = 0;
            do
            {
                if (btnSel1.Text.Trim() == "Sel All")
                {
                    GrdSecurity.Rows[i].Cells[1].Value = true;

                }
                else
                {
                    GrdSecurity.Rows[i].Cells[1].Value = false;
                }

                i = i + 1;
            } while (i < GrdSecurity.Rows.Count - 1);

            if (btnSel1.Text.Trim() == "Sel All")
            {
                btnSel1.Text = "Unsel All";
            }
            else
            {
                btnSel1.Text = "Sel All";
            }

        }

        private void btnSel2_Click(object sender, EventArgs e)
        {

            int i = 0;
            do
            {
                if (btnSel2.Text.Trim() == "Sel All")
                {
                    GrdSecurity.Rows[i].Cells[2].Value = true;

                }
                else
                {
                    GrdSecurity.Rows[i].Cells[2].Value = false;
                }

                i = i + 1;
            } while (i < GrdSecurity.Rows.Count - 1);

            if (btnSel2.Text.Trim() == "Sel All")
            {
                btnSel2.Text = "Unsel All";
            }
            else
            {
                btnSel2.Text = "Sel All";
            }
        }

        private void btnSel3_Click(object sender, EventArgs e)
        {

            int i = 0;
            do
            {
                if (btnSel3.Text.Trim() == "Sel All")
                {
                    GrdSecurity.Rows[i].Cells[3].Value = true;

                }
                else
                {
                    GrdSecurity.Rows[i].Cells[3].Value = false;
                }

                i = i + 1;
            } while (i < GrdSecurity.Rows.Count - 1);

            if (btnSel3.Text.Trim() == "Sel All")
            {
                btnSel3.Text = "Unsel All";
            }
            else
            {
                btnSel3.Text = "Sel All";
            }
        }

        private void btnSel4_Click(object sender, EventArgs e)
        {

            int i = 0;
            do
            {
                if (btnSel4.Text.Trim() == "Sel All")
                {
                    GrdSecurity.Rows[i].Cells[4].Value = true;

                }
                else
                {
                    GrdSecurity.Rows[i].Cells[4].Value = false;
                }

                i = i + 1;
            } while (i < GrdSecurity.Rows.Count - 1);

            if (btnSel4.Text.Trim() == "Sel All")
            {
                btnSel4.Text = "Unsel All";
            }
            else
            {
                btnSel4.Text = "Sel All";
            }
        }

        private void pnlShift_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdDeleteSection_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelSection == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (CboCodeNoSection.Text.Trim() == "")
                {
                    MessageBox.Show("Code No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {

                    string qry = "select * from SectionTBl where codeno=" + CboCodeNoSection.Text.Trim() + " and ComId='" + ClsVar.GblComId + "'";

                    string CHK = SvCls.DataExist(qry);

                    if (MessageBox.Show(" Do You Realy Want To Delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                        if (CHK.ToString() == "1")
                        {
                            qry = "delete from SectionTBl where codeno=" + CboCodeNoSection.Text.Trim() + " and ComId='" + ClsVar.GblComId + "'";

                            lblMgs.ForeColor = System.Drawing.Color.Red;
                            PicSave.Visible = true;
                            lblMgs.Visible = true;
                            lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        }

                    SvCls.insertUpdate(qry);
                    Grid_Head_Section();
                    CboCodeNoSection.Text = "";
                    txtNameSection.Text = "";
                    txtBNameSection.Text = "";
                    txtRmkSection.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PicSave.Visible = false;
            lblMgs.Visible = false;
        }

        private void CmdMachine_Click(object sender, EventArgs e)
        {
            //SecurityAssign();

            if (ClsVar.VwMachineCreation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lebHd.Text = "[ MACHINE INFORMATION ]";
                BlankAll();
                HideAllPnl();
                pnlMachine.Visible = true;
                pnlMachine.Left = 227;
                pnlMachine.Top = 70;
                pnlMachine.Width = 700;
                pnlMachine.Height = 500;
                MachineGrid.Width = 680;
                MachineGrid.Height = 350;

                CmdAddNewMachine.Select();

                string Qry = "select convert(varchar,BlockID) + '~' + BlockName as codeno  from Block Order By convert(MOney,BlockId)";
                cboMachineID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                cboMachineID.DisplayMember = "codeno";
                cboMachineID.Text = "";
                Grid_Head_Machine();
            }


        }

        private void BtnMachineSave_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveMachineCreation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cboMachineID.Text.Trim() == "")
                {
                    MessageBox.Show("Machine ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string qry = "select * from Block where BlockID='" + cboMachineID.Text.Trim() + "'";

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "update Block set Blockname='" + txtMachineName.Text.Trim() + "' where BlockID='" + cboMachineID.Text + "'";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "insert into Block (BlockID,Blockname) values ('" + cboMachineID.Text.Trim() + "','" + txtMachineName.Text.Trim() + "')";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }

                SvCls.insertUpdate(qry);

                Grid_Head_Machine();
                CmdAddNewMachine.Select();
            }
        }

        private void BtnMachineDelete_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelMachineCreation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cboMachineID.Text.Trim() == "")
                {
                    MessageBox.Show("Machine ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {

                    string qry = "select * from Block where BlockID='" + cboMachineID.Text.Trim() + "'";

                    string CHK = SvCls.DataExist(qry);

                    if (MessageBox.Show(" Do You Realy Want To Delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                        if (CHK.ToString() == "1")
                        {
                            qry = "delete from Block where BlockID='" + cboMachineID.Text.Trim() + "'";

                            lblMgs.ForeColor = System.Drawing.Color.Red;
                            PicSave.Visible = true;
                            lblMgs.Visible = true;
                            lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        }

                    SvCls.insertUpdate(qry);
                    Grid_Head_Machine();
                    cboMachineID.Text = "";
                    txtMachineName.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CmdAddNewMachine_Click(object sender, EventArgs e)
        {
            string Qry1 = "select BlockId from Block";
            if (SvCls.DataExist(Qry1) == "1")
            {
                SvCls.toGetData("select max(BlockId)+1 as BlockId from Block");/// where isnumeric(BlockId)=1");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMachineID.Text = SvCls.GblRdrToGetData["BlockId"].ToString();
                    SvCls.GblCon.Close();
                }
            }
            else
            {
                cboMachineID.Text = "1";
            }
            txtMachineName.Select();

        }

        private void MachineGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i = MachineGrid.SelectedCells[0].RowIndex;
                cboMachineID.Text = MachineGrid.Rows[i].Cells[0].Value.ToString();

                string Qry = "select * from Block where BlockID='" + cboMachineID.Text.Trim() + "'";
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("SELECT BlockID,BlockName From Block where BlockID='" + cboMachineID.Text.Trim() + "'");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtMachineName.Text = SvCls.GblRdrToGetData["BlockName"].ToString();
                        SvCls.GblCon.Close();

                    }
                }

                else
                {
                    txtMachineName.Text = "";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboMachineID_Leave(object sender, EventArgs e)
        {
            
            string temCodeNo = "";

            if (cboMachineID.Text.Trim() == "")
            {
                return;
            }

            try
            {
                temCodeNo = cboMachineID.Text.Trim().Substring(0, cboMachineID.Text.Trim().IndexOf("~"));
            }
            catch
            {
                if (temCodeNo == "")
                {
                    temCodeNo = cboMachineID.Text.Trim();
                }
            }







            string Qry = "select * from Block where BlockID=" + Convert.ToInt32(temCodeNo);
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT BlockID,BlockName From Block where BlockID=" + Convert.ToInt32(temCodeNo));
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMachineID.Text = SvCls.GblRdrToGetData["BlockID"].ToString();
                    txtMachineName.Text = SvCls.GblRdrToGetData["BlockName"].ToString();
                    BtnMachineSave.Text = "&Edit";
                    SvCls.GblCon.Close();
                }
            }

            else
            {
                txtNameSection.Text = "";
                BtnMachineSave.Text = "&Edit";

            }
        }

        private void cboMachineID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMachineName.Select();
            }
        }

        private void btnMaterialType_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwMaterialType == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                lebHd.Text = "[ Material Type INFORMATION ]";
                BlankAll();
                HideAllPnl();
                pnlMaterialType.Visible = true;
                pnlMaterialType.Left = 227;
                pnlMaterialType.Top = 70;
                pnlMaterialType.Width = 700;
                pnlMaterialType.Height = 500;
                MaterialGrid.Width = 680;
                MaterialGrid.Height = 350;

                cmdMaterialTypeAddnew.Select();

                string qry = "Select TypeId + '~' + Typename as code from MaterialType Order by convert(money,TypeId)";
                cboMatTpID.DataSource = SvCls.GblDataSet(qry).Tables[0];
                cboMatTpID.DisplayMember = "code";
                cboMatTpID.Text = "";

                Grid_Head_MaterialType();
            }

        }

        private void cmdMaterialTypeAddnew_Click(object sender, EventArgs e)
        {
            string Qry1 = "select TypeId from MaterialType";
            if (SvCls.DataExist(Qry1) == "1")
            {

                SvCls.toGetData("select max(convert(numeric,TypeId))+1 as TypeId from MaterialType ");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMatTpID.Text = SvCls.GblRdrToGetData["TypeId"].ToString();
                    SvCls.GblCon.Close();
                }
            }
            else
            {
                cboMachineID.Text = "1";
            }

            txtMatTpName.Text = "";
            cboInkOthers.Text = "";
            chkActive.Checked = false;
            txtMatTpName.Select();

        }

        private void Grid_Head_MaterialType()
        {
            MaterialGrid.DataSource = SvCls.GblDataTable("select * FROM MaterialType Order by convert(money,TypeId)");
            MaterialGrid.Refresh();
        }

        private void buttonMaterialTypeSave_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveMaterialType == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cboMatTpID.Text.Trim() == "")
                {
                    MessageBox.Show("Material Type ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string qry = "select * from MaterialType where TypeId='" + cboMatTpID.Text.Trim() + "'";

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "update MaterialType set TypeName='" + txtMatTpName.Text.Trim() + "',TypeOrigin='" + cboInkOthers.Text.Trim() + "',Status=" + Convert.ToInt16(chkActive.Checked) + " where TypeId='" + cboMatTpID.Text.Trim() + "'";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "insert into MaterialType (TypeId,TypeName,TypeOrigin,Status) values (" + cboMatTpID.Text.Trim() + ",'" + txtMatTpName.Text.Trim() + "','" + cboInkOthers.Text.Trim() + "'," + Convert.ToInt16(chkActive.Checked) + ")";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;

                }
                SvCls.insertUpdate(qry);
                Grid_Head_MaterialType();
                cmdMaterialTypeAddnew.Select();
            }
        }

        private void cboMatTpID_Leave(object sender, EventArgs e)
        {
            string temCodeNo = "";

            if (cboMatTpID.Text.Trim() == "")
            {
                txtMatTpName.Text = "";
                cboInkOthers.Text = "";
                return;
            }

            try
            {
                temCodeNo = cboMatTpID.Text.Trim().Substring(0, cboMatTpID.Text.Trim().IndexOf("~"));
            }
            catch
            {
                if (temCodeNo == "")
                {
                    temCodeNo = cboMatTpID.Text.Trim();
                }
            }
            string Qry = "select * from MaterialType where TypeId=" + Convert.ToInt32(temCodeNo) + "";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT TypeId,TypeName,TypeOrigin,Status From MaterialType where TypeId=" + Convert.ToInt32(temCodeNo) + "");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMatTpID.Text = SvCls.GblRdrToGetData["TypeId"].ToString();
                    txtMatTpName.Text = SvCls.GblRdrToGetData["TypeName"].ToString();
                    cboInkOthers.Text = SvCls.GblRdrToGetData["TypeOrigin"].ToString();
                    string Active = SvCls.GblRdrToGetData["Status"].ToString();

                    if (Active == "1")
                    {
                        chkActive.Checked = true;
                    }
                    else
                    {
                        chkActive.Checked = false;
                    }

                    buttonMaterialTypeSave.Text = "&Edit";

                    SvCls.GblCon.Close();
                }
            }

            else
            {
                buttonMaterialTypeSave.Text = "&Save";
                txtMatTpName.Text = "";
                cboInkOthers.Text = "";
            }
        }

        private void MaterialGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i = MaterialGrid.SelectedCells[0].RowIndex;
                cboMatTpID.Text = MaterialGrid.Rows[i].Cells[0].Value.ToString();

                string Qry = "select * from MaterialType where TypeId=" + cboMatTpID.Text.Trim();
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("SELECT TypeName,TypeOrigin,Status From MaterialType where TypeId=" + cboMatTpID.Text.Trim());
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtMatTpName.Text = SvCls.GblRdrToGetData["TypeName"].ToString();
                        cboInkOthers.Text = SvCls.GblRdrToGetData["TypeOrigin"].ToString();
                        string Active = SvCls.GblRdrToGetData["Status"].ToString();

                        if (Active == "1")
                        {
                            chkActive.Checked = true;
                        }
                        else
                        {
                            chkActive.Checked = false;
                        }

                        SvCls.GblCon.Close();

                    }

                }

                else
                {
                    chkActive.Checked = false;
                    txtMatTpName.Text = "";
                    cboInkOthers.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonMaterialTypeDelete_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelMaterialType == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cboMatTpID.Text.Trim() == "")
                {
                    MessageBox.Show("Material Type ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {

                    string qry = "select * from MaterialType where TypeId='" + cboMatTpID.Text.Trim() + "'";
                    string CHK = SvCls.DataExist(qry);

                    if (MessageBox.Show(" Do You Realy Want To Delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                        if (CHK.ToString() == "1")
                        {
                            qry = "delete from MaterialType where TypeId='" + cboMatTpID.Text.Trim() + "'";

                            lblMgs.ForeColor = System.Drawing.Color.Red;
                            PicSave.Visible = true;
                            lblMgs.Visible = true;
                            lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        }

                    SvCls.insertUpdate(qry);
                    Grid_Head_MaterialType();
                    cboMatTpID.Text = "";
                    txtMatTpName.Text = "";
                    cboInkOthers.Text = "";
                    chkActive.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnUnit_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwUnitInfo == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lebHd.Text = "[ UNIT INFORMATION ]";
                BlankAll();
                HideAllPnl();
                PnlUnit.Visible = true;
                PnlUnit.Left = 227;
                PnlUnit.Top = 70;
                PnlUnit.Width = 700;
                PnlUnit.Height = 500;
                GridUnit.Width = 680;
                GridUnit.Height = 400;
                string qry;

                CmdAddNewUnit.Select();

                qry = "Select UnitId + '~' + UnitDescription as code from UnitInfo Order by convert(money,UnitId) asc";

                CboUnitID.DataSource = SvCls.GblDataSet(qry).Tables[0];
                CboUnitID.DisplayMember = "code";
                CboUnitID.Text = "";
                Grid_Head_Unit();
            }

        }

        private void CmdAddNewUnit_Click(object sender, EventArgs e)
        {
            string Qry1 = "select UnitId from UnitInfo";
            if (SvCls.DataExist(Qry1) == "1")
            {

                SvCls.toGetData("select max(convert(numeric,UnitId))+1 as UnitId from UnitInfo ");
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboUnitID.Text = SvCls.GblRdrToGetData["UnitId"].ToString();
                    SvCls.GblCon.Close();
                }
            }
            else
            {
                CboUnitID.Text = "1";
            }
            txtUnit.Text = "";
            txtUnit.Select();

        }

        private void Grid_Head_Unit()
        {
            GridUnit.DataSource = SvCls.GblDataTable("select * from UnitInfo Order by convert(money,UnitId) asc");
            GridUnit.Refresh();
        }

        private void cmdSaveUnit_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveUnitInfo == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (CboUnitID.Text.Trim() == "")
                {
                    MessageBox.Show("Unit ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string qry = "select * from UnitInfo where UnitId='" + CboUnitID.Text.Trim() + "'";

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "update UnitInfo set UnitDescription='" + txtUnit.Text.Trim() + "' where UnitId='" + CboUnitID.Text.Trim() + "'";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "insert into UnitInfo (UnitId,UnitDescription) values ('" + CboUnitID.Text.Trim() + "','" + txtUnit.Text.Trim() + "')";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;

                }

                SvCls.insertUpdate(qry);
                Grid_Head_Unit();
                CmdAddNewUnit.Select();
            }
        }

        private void CmdDeleteUnit_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelUnitInfo == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (CboUnitID.Text.Trim() == "")
                {
                    MessageBox.Show("Unit ID Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string qry = "select * from UnitInfo where UnitId='" + CboUnitID.Text.Trim() + "'";
                string CHK = SvCls.DataExist(qry);

                if (MessageBox.Show(" Do You Realy Want To Delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (CHK.ToString() == "1")
                    {
                        qry = "delete from UnitInfo where UnitId='" + CboUnitID.Text.Trim() + "'";

                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        PicSave.Visible = true;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                    }

                SvCls.insertUpdate(qry);
                Grid_Head_Unit();
                CboUnitID.Text = "";
                txtUnit.Text = "";
            }
             }

        private void CboUnitID_Leave(object sender, EventArgs e)
        {
            string temCodeNo = "";

            if (CboUnitID.Text.Trim() == "")
            {
                txtMatTpName.Text = "";
                return;
            }

            try
            {
                temCodeNo = CboUnitID.Text.Trim().Substring(0, CboUnitID.Text.Trim().IndexOf("~"));
            }
            catch
            {
                if (temCodeNo == "")
                {
                    temCodeNo = CboUnitID.Text.Trim();
                }
            }
            string Qry = "select * from UnitInfo where UnitId=" + Convert.ToInt32(temCodeNo) + "";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT UnitId,UnitDescription From UnitInfo where UnitId=" + Convert.ToInt32(temCodeNo) + "");
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboUnitID.Text = SvCls.GblRdrToGetData["UnitId"].ToString();
                    txtUnit.Text = SvCls.GblRdrToGetData["UnitDescription"].ToString();
                    cmdSaveUnit.Text = "&Edit";
                    SvCls.GblCon.Close();
                }
            }

            else
            {
                txtUnit.Text = "";
                cmdSaveUnit.Text = "&Save";
             }
        }

        private void GridUnit_DoubleClick(object sender, EventArgs e)
        {
            int i = GridUnit.SelectedCells[0].RowIndex;
            CboUnitID.Text = GridUnit.Rows[i].Cells[0].Value.ToString();

            string Qry = "select * from UnitInfo where UnitId=" + CboUnitID.Text.Trim();
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT UnitId,UnitDescription From UnitInfo where UnitId=" + CboUnitID.Text.Trim());
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboUnitID.Text = SvCls.GblRdrToGetData["UnitId"].ToString();
                    txtUnit.Text = SvCls.GblRdrToGetData["UnitDescription"].ToString();
                    SvCls.GblCon.Close();

                }

            }

            else
            {
                txtUnit.Text = "";
            }
        }

        private void btnMachineDetails_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwMachineDetails == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lebHd.Text = "[ MACHINE DETILS ]";
                BlankAll();
                HideAllPnl();
                pnlMachimeDetails.Visible = true;
                pnlMachimeDetails.Left = 227;
                pnlMachimeDetails.Top = 70;
                pnlMachimeDetails.Width = 700;
                pnlMachimeDetails.Height = 500;
                GridMachineDetails.Width = 680;
                GridMachineDetails.Height = 300;

                cboMachine.Select();

                string Qry = "select Machine from Machine order by Machine asc";
                cboMachine.DataSource = SvCls.GblDataSet(Qry).Tables[0];
                cboMachine.DisplayMember = "Machine";
                cboMachine.Text = "";

                string Qry1 = "select distinct sec from Machine order by sec";
                cboSec.DataSource = SvCls.GblDataSet(Qry1).Tables[0];
                cboSec.DisplayMember = "sec";
                cboSec.Text = "";

                Grid_Head_MachineDetails();
            }
        }

        private void Grid_Head_MachineDetails()
        {
            GridMachineDetails.DataSource = SvCls.GblDataTable("select * from Machine order by Machine asc");
            GridMachineDetails.Refresh();
        }

        private void cmdMacDetailsSave_Click(object sender, EventArgs e)

        {
            if (ClsVar.SaveMachineDetails == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cboMachine.Text.Trim() == "")
                {
                    MessageBox.Show("Machine Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string qry = "select * from Machine where Machine='" + cboMachine.Text.Trim() + "'";

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "update Machine set Unit='" + txtMacUnit.Text.Trim() + "',MachineSize='" + txtMacSize.Text.Trim() + "',WorkingSizeMax='" + txtWSMax.Text.Trim() + "',WorkingSizeMin='" + txtWSMin.Text.Trim() + "',MachineSpeed='" + txtMacSpeed.Text.Trim() + "',MachineSpeedUnit='" + txtMacSpeedUnit.Text.Trim() + "',LessDepriciation='" + txtLessDesp.Text.Trim() + "',LessDepriciationUnit='" + txtLessDespUnit.Text.Trim() + "',Capacity='" + txtPresCap.Text.Trim() + "',CapacityUnit='" + txtPresCapUnit.Text.Trim() + "',Target='" + txtTarget.Text.Trim() + "',TargetUnit='" + txtTargetUnit.Text.Trim() + "',sec='" + cboSec.Text.Trim() + "' where Machine='" + cboMachine.Text + "'";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "insert into Machine (Machine,Unit,MachineSize,WorkingSizeMax,WorkingSizeMin,MachineSpeed,MachineSpeedUnit,LessDepriciation,LessDepriciationUnit,Capacity,CapacityUnit,Target,TargetUnit,sec) values ('" + cboMachine.Text.Trim() + "','" + txtMacUnit.Text.Trim() + "','" + txtMacSize.Text.Trim() + "','" + txtWSMax.Text.Trim() + "','" + txtWSMin.Text.Trim() + "','" + txtMacSpeed.Text.Trim() + "','" + txtMacSpeedUnit.Text.Trim() + "','" + txtLessDesp.Text.Trim() + "','" + txtLessDespUnit.Text.Trim() + "','" + txtPresCap.Text.Trim() + "','" + txtPresCapUnit.Text.Trim() + "','" + txtTarget.Text.Trim() + "','" + txtTargetUnit.Text.Trim() + "','" + cboSec.Text.Trim() + "')";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }

                SvCls.insertUpdate(qry);

                Grid_Head_MachineDetails();
            }
        }

        private void cmdMacDetailsDelete_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelMachineDetails == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cboMachine.Text.Trim() == "")
                {
                    MessageBox.Show("Machine Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string qry = "select * from Machine where Machine='" + cboMachine.Text.Trim() + "'";

                string CHK = SvCls.DataExist(qry);

                if (MessageBox.Show(" Do You Realy Want To Delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (CHK.ToString() == "1")
                    {
                        qry = "delete from Machine where Machine='" + cboMachine.Text.Trim() + "'";

                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        PicSave.Visible = true;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                    }

                SvCls.insertUpdate(qry);

                Grid_Head_MachineDetails();
                cboMachine.Text = "";
                txtMacUnit.Text = "";
                txtMacSize.Text = "";
                txtWSMax.Text = "";
                txtWSMin.Text = "";
                txtMacSpeed.Text = "";
                txtMacSpeedUnit.Text = "";
                txtLessDesp.Text = "";
                txtLessDespUnit.Text = "";
                txtPresCap.Text = "";
                txtPresCapUnit.Text = "";
                txtTarget.Text = "";
                txtTargetUnit.Text = "";
                cboSec.Text = "";
            }
        }

        private void cboMachine_Leave(object sender, EventArgs e)
        {

            string Qry = "select * from Machine where Machine='" + cboMachine.Text.Trim()  + "'";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT Machine,Unit,MachineSize,WorkingSizeMax,WorkingSizeMin,MachineSpeed,MachineSpeedUnit,LessDepriciation,LessDepriciationUnit,Capacity,CapacityUnit,Target,TargetUnit,sec From Machine where Machine='" + cboMachine.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMachine.Text = SvCls.GblRdrToGetData["Machine"].ToString();
                    txtMacUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                    txtMacSize.Text = SvCls.GblRdrToGetData["MachineSize"].ToString();
                    txtWSMax.Text = SvCls.GblRdrToGetData["WorkingSizeMax"].ToString();
                    txtWSMin.Text = SvCls.GblRdrToGetData["WorkingSizeMin"].ToString();
                    txtMacSpeed.Text = SvCls.GblRdrToGetData["MachineSpeed"].ToString();
                    txtMacSpeedUnit.Text = SvCls.GblRdrToGetData["MachineSpeedUnit"].ToString();
                    txtLessDesp.Text = SvCls.GblRdrToGetData["LessDepriciation"].ToString();
                    txtLessDespUnit.Text = SvCls.GblRdrToGetData["LessDepriciationUnit"].ToString();
                    txtPresCap.Text = SvCls.GblRdrToGetData["Capacity"].ToString();
                    txtPresCapUnit.Text = SvCls.GblRdrToGetData["CapacityUnit"].ToString();
                    txtTarget.Text = SvCls.GblRdrToGetData["Target"].ToString();
                    txtTargetUnit.Text = SvCls.GblRdrToGetData["TargetUnit"].ToString();
                    cboSec.Text = SvCls.GblRdrToGetData["Sec"].ToString();
                    cmdMacDetailsSave.Text = "&Edit";
                    SvCls.GblCon.Close();
                }
            }

            else
            {
                txtMacUnit.Text = "";
                txtMacSize.Text = "";
                txtWSMax.Text = "";
                txtMacSpeed.Text = "";
                txtMacSpeedUnit.Text = "";
                txtLessDesp.Text = "";
                txtLessDespUnit.Text = "";
                txtPresCap.Text = "";
                txtPresCapUnit.Text = "";
                txtTarget.Text = "";
                txtTargetUnit.Text = "";
                cboSec.Text = "";
                cmdMacDetailsSave.Text = "&Save";

            }
        }

        private void GridMachineDetails_DoubleClick(object sender, EventArgs e)
        {
            int i = GridMachineDetails.SelectedCells[0].RowIndex;
            cboMachine.Text = GridMachineDetails.Rows[i].Cells[0].Value.ToString();

            string Qry = "select * from Machine where Machine='" + cboMachine.Text.Trim() + "'";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT Machine,Unit,MachineSize,WorkingSizeMax,WorkingSizeMin,MachineSpeed,MachineSpeedUnit,LessDepriciation,LessDepriciationUnit,Capacity,CapacityUnit,Target,TargetUnit,sec From Machine where Machine='" + cboMachine.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMachine.Text = SvCls.GblRdrToGetData["Machine"].ToString();
                    txtMacUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                    txtMacSize.Text = SvCls.GblRdrToGetData["MachineSize"].ToString();
                    txtWSMax.Text = SvCls.GblRdrToGetData["WorkingSizeMax"].ToString();
                    txtWSMin.Text = SvCls.GblRdrToGetData["WorkingSizeMin"].ToString();
                    txtMacSpeed.Text = SvCls.GblRdrToGetData["MachineSpeed"].ToString();
                    txtMacSpeedUnit.Text = SvCls.GblRdrToGetData["MachineSpeedUnit"].ToString();
                    txtLessDesp.Text = SvCls.GblRdrToGetData["LessDepriciation"].ToString();
                    txtLessDespUnit.Text = SvCls.GblRdrToGetData["LessDepriciationUnit"].ToString();
                    txtPresCap.Text = SvCls.GblRdrToGetData["Capacity"].ToString();
                    txtPresCapUnit.Text = SvCls.GblRdrToGetData["CapacityUnit"].ToString();
                    txtTarget.Text = SvCls.GblRdrToGetData["Target"].ToString();
                    txtTargetUnit.Text = SvCls.GblRdrToGetData["TargetUnit"].ToString();
                    cboSec.Text = SvCls.GblRdrToGetData["Sec"].ToString();
                    SvCls.GblCon.Close();
                }
            }

            else
            {
                txtMacUnit.Text = "";
                txtMacSize.Text = "";
                txtWSMax.Text = "";
                txtMacSpeed.Text = "";
                txtMacSpeedUnit.Text = "";
                txtLessDesp.Text = "";
                txtLessDespUnit.Text = "";
                txtPresCap.Text = "";
                txtPresCapUnit.Text = "";
                txtTarget.Text = "";
                txtTargetUnit.Text = "";
                cboSec.Text = "";

            }
        }

        private void btnNCR_Click(object sender, EventArgs e)
        {
            //SecurityAssign();
            if (ClsVar.VwNcrCreation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lebHd.Text = "[ NCR INFORMATION ]";

                BlankAll();
                HideAllPnl();
                PnlNcr.Visible = true;
                PnlNcr.Left = 227;
                PnlNcr.Top = 70;
                PnlNcr.Width = 700;
                PnlNcr.Height = 500;
                GridNcr.Width = 680;
                GridNcr.Height = 350;
                string qry;

                cmdNcrAddnew.Select();

                qry = "Select NCRNo + '~' + NCRLabel as code from NCR Order by convert(money,NCRNo) asc";

                cboNcrNo.DataSource = SvCls.GblDataSet(qry).Tables[0];
                cboNcrNo.DisplayMember = "code";
                cboNcrNo.Text = "";
                Grid_Head_NCR();
            }
        }

        private void Grid_Head_NCR()
        {
            GridNcr.DataSource = SvCls.GblDataTable("select * from NCR Order by convert(money,NCRNo) asc");
            GridNcr.Refresh();
        }

        private void cmdNcrAddnew_Click(object sender, EventArgs e)
        {
            string Qry1 = "select NCRNo from NCR";
            if (SvCls.DataExist(Qry1) == "1")
            {

                SvCls.toGetData("select max(convert(numeric,NCRNo))+1 as NCRNo from NCR ");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboNcrNo.Text = SvCls.GblRdrToGetData["NCRNo"].ToString();
                    SvCls.GblCon.Close();
                }
            }
            else
            {
                cboNcrNo.Text = "1";
            }
            txtNcrLable.Text = "";
            txtNcrLable.Select();
        }

        private void cboNcrNo_Leave(object sender, EventArgs e)
        {
            string temCodeNo = "";

            if (cboNcrNo.Text.Trim() == "")
            {
                return;
            }


            try
            {
                temCodeNo = cboNcrNo.Text.Trim().Substring(0, cboNcrNo.Text.Trim().IndexOf("~"));
            }
            catch
            {
                if (temCodeNo == "")
                {
                    temCodeNo = cboNcrNo.Text.Trim();
                }
            }
            string Qry = "select * from NCR where NCRNo=" + Convert.ToInt32(temCodeNo) + "";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT NCRNo,NCRLabel From NCR where NCRNo=" + Convert.ToInt32(temCodeNo) + "");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboNcrNo.Text = SvCls.GblRdrToGetData["NCRNo"].ToString();
                    txtNcrLable.Text = SvCls.GblRdrToGetData["NCRLabel"].ToString();
                    cmdNcrSave.Text = "&Edit";
                    SvCls.GblCon.Close();
                }
            }

            else
            {
                txtNcrLable.Text = "";
                cmdNcrSave.Text = "&Save";
            }
        }

        private void cmdNcrSave_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveNcrCreation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                if (cboNcrNo.Text.Trim() == "")
                {
                    MessageBox.Show("NCR No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string qry = "select * from NCR where NCRNo='" + cboNcrNo.Text.Trim() + "'";

                string CHK = SvCls.DataExist(qry);

                if (CHK.ToString() == "1")
                {
                    qry = "update NCR set NCRLabel='" + txtNcrLable.Text.Trim() + "' where NCRNo='" + cboNcrNo.Text.Trim() + "'";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "insert into NCR (NCRNo,NCRLabel) values ('" + cboNcrNo.Text.Trim() + "','" + txtNcrLable.Text.Trim() + "')";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;

                }

                SvCls.insertUpdate(qry);
                Grid_Head_NCR();
                cmdNcrAddnew.Select();
            }
        }

        private void cmdNcrDelete_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelNcrCreation == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cboNcrNo.Text.Trim() == "")
                {
                    MessageBox.Show("NCR No Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string qry = "select * from NCR where NCRNo='" + cboNcrNo.Text.Trim() + "'";
                string CHK = SvCls.DataExist(qry);

                if (MessageBox.Show(" Do You Realy Want To Delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (CHK.ToString() == "1")
                    {
                        qry = "delete from NCR where NCRNo='" + cboNcrNo.Text.Trim() + "'";

                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        PicSave.Visible = true;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                    }

                SvCls.insertUpdate(qry);
                Grid_Head_NCR();
                cboNcrNo.Text = "";
                txtNcrLable.Text = "";
            }
        }

        private void GridNcr_DoubleClick(object sender, EventArgs e)
        {
            int i = GridNcr.SelectedCells[0].RowIndex;
            cboNcrNo.Text = GridNcr.Rows[i].Cells[0].Value.ToString();

            string Qry = "select * from NCR where NCRNo='" + cboNcrNo.Text.Trim() + "'";
            if (SvCls.DataExist(Qry) == "1")
            {
                SvCls.toGetData("SELECT NCRNo,NCRLabel From NCR where NCRNo='" + cboNcrNo.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboNcrNo.Text = SvCls.GblRdrToGetData["NCRNo"].ToString();
                    txtNcrLable.Text = SvCls.GblRdrToGetData["NCRLabel"].ToString();
                    SvCls.GblCon.Close();
                }
            }

            else
            {
                txtNcrLable.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboNcrNo.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{NCR.NCRNo}='" + cboNcrNo.Text.Trim() + "' and ";
            }

            if (ClsVar.GblSelFor != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + " {NCR.NCRNo}<>'0'";
            }

            ClsVar.GblHeadName = "NCR Information";
            ClsVar.GblRptName = "NCR.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void cmdmacDetailsCelear_Click(object sender, EventArgs e)
        {
            cboMachine.Text = "";
            txtMacUnit.Text = "";
            txtMacSize.Text = "";
            txtWSMax.Text = "";
            txtWSMin.Text = "";
            txtMacSpeed.Text = "";
            txtMacSpeedUnit.Text = "";
            txtLessDesp.Text = "";
            txtLessDespUnit.Text = "";
            txtPresCap.Text = "";
            txtPresCapUnit.Text = "";
            txtTarget.Text = "";
            txtTargetUnit.Text = "";
            cboSec.Text = "";
        }

        private void cboMachine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMacUnit.Select();
            }
        }

        private void txtMacUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMacSize.Select();
            }
        }

        private void txtMacSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtWSMax.Select();
            }
        }

        private void txtWSMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtWSMin.Select();
            }
        }

        private void txtWSMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMacSpeed.Select();
            }
        }

        private void cboNcrNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtNcrLable.Select();
            }
        }

        private void txtNcrLable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdNcrSave.Select();
            }
        }

        private void CboUnitID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtUnit.Select();
            }
        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSaveUnit.Select();
            }
        }

        private void cboMatTpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMatTpName.Select();
            }
        }

        private void txtMatTpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboInkOthers.Select();
            }
        }

        private void cboInkOthers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                chkActive.Select();
            }
        }

        private void chkActive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                buttonMaterialTypeSave.Select();
            }
        }

        private void CboCodeBr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtNameBr.Select();
            }
        }

        private void txtNameBr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBnameBr.Select();
            }
        }

        private void txtBnameBr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtAddressBr.Select();
            }
        }

        private void txtAddressBr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPhoneBr.Select();
            }
        }

        private void txtPhoneBr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMailBr.Select();
            }
        }

        private void txtMailBr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtHeadBr.Select();
            }
        }

        private void txtHeadBr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRmkBr.Select();
            }
        }

        private void txtRmkBr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSaveBr.Select();
            }
        }

        private void txtMachineName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                BtnMachineSave.Select();
            }
        }

        private void cboGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                DtpFromDate.Select();
            }
        }

        private void DtpFromDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                mskInTimeStart.Select();
            }
        }

        private void mskInTimeStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                mskWorkStartFrom.Select();
            }
        }

        private void mskWorkStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                mskOutTime.Select();
            }
        }

        private void mskOutTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                mskOTStart.Select();
            }
        }

        private void mskOTStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                mskMaxInTime.Select();
            }
        }

        private void mskMaxInTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMaxOT.Select();
            }
        }

        private void txtMaxOT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSaveShift.Select();
            }
        }

        private void CboCodeNoDesg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtNameDesg.Select();
            }
        }

        private void txtNameDesg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBNameDesg.Select();
            }
        }

        private void txtBNameDesg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRmkDesg.Select();
            }
        }

        private void txtRmkDesg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSaveDesg.Select();
            }
        }

        private void CboCodeNoSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtNameSection.Select();
            }
        }

        private void txtNameSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBNameSection.Select();
            }
        }

        private void txtBNameSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRmkSection.Select();
            }
        }

        private void txtRmkSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSaveSection.Select();
            }
        }

        
        private void txtOldPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtNewPwd.Select();
            }
        }

        private void txtNewPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSavePwd.Select();
            }
        }

        private void txtNewUserCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtUserName.Select();
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPwd.Select();
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSaveUser.Select();
            }
        }

        private void cboSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdMacDetailsSave.Select();
            }
        }

        private void txtMacSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMacSpeedUnit.Select();
            }
        }

        private void txtMacSpeedUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtLessDesp.Select();
            }
        }

        private void txtLessDesp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtLessDespUnit.Select();
            }
        }

        private void txtLessDespUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPresCap.Select();
            }
        }

        private void txtPresCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPresCapUnit.Select();
            }
        }

        private void txtPresCapUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtTarget.Select();
            }
        }

        private void txtTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtTargetUnit.Select();
            }
        }

        private void txtTargetUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboSec.Select();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboMachine.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Machine.Machine}='" + cboMachine.Text.Trim() + "' and ";
            }

            if (ClsVar.GblSelFor != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + " {Machine.Machine}<>''";
            }

            ClsVar.GblHeadName = "Machine Information";
            ClsVar.GblRptName = "RptMachine.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (CboUnitID.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{UnitInfo.UnitId}='" + CboUnitID.Text.Trim() + "' and ";
            }

            if (ClsVar.GblSelFor != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + " {UnitInfo.UnitId}<>'0'";
            }

            ClsVar.GblHeadName = "Unit Information";
            ClsVar.GblRptName = "Unit.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void buttonMaterialTypeRpt_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboMatTpID.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{MaterialType.TypeId}='" + cboMatTpID.Text.Trim() + "' and ";
            }

            if (ClsVar.GblSelFor != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + " {MaterialType.TypeId}<>'0'";
            }

            ClsVar.GblHeadName = "Material Type Information";
            ClsVar.GblRptName = "MaterialType.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void cmdReportBr_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
           
            ClsVar.GblHeadName = "Branch Information";
            ClsVar.GblRptName = "Branch.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void BtnMachineRpt_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboMachineID.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Block.BlockID}=" + cboMachineID.Text.Trim() + " and ";
            }

            if (ClsVar.GblSelFor != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + " {Block.BlockID}<>0";
            }

            ClsVar.GblHeadName = "Machine Information";
            ClsVar.GblRptName = "Machine.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboGroupName.Text !="")
            {
            ClsVar.GblSelFor = ClsVar.GblSelFor + "{timeGroup.GroupId}='" + cboGroupName.Text + "' ";
            }
            
            ClsVar.GblHeadName = "Shift Information";
            ClsVar.GblRptName = "TimeGroupReport.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void cmdSaveGrid_Click(object sender, EventArgs e)
        {

            //Label1.Text = "Records inserted successfully";

            int i = 0;
            do
            {
                string qry = "update designation set  AttnBonus =" + GridDesg.Rows[i].Cells[7].Value + " where DesignationCode ='" + GridDesg.Rows[i].Cells[13].Value + "' AND COMID='" + ClsVar.GblComId + "'";
                SvCls.insertUpdate(qry);
                //string qry = "update designation set  DesiGp ='" + GridDesg.Rows[i].Cells[13].Value + "' where codeno ='" + GridDesg.Rows[i].Cells[0].Value + "'";
               

            i = i + 1;
            } while (i < GridDesg.Rows.Count - 1);
            MessageBox.Show("C..O..M..P..L..E..T..E..D...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string dback;
            dback = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");



            String Location = String.Empty;
            SaveFileDialog svf = new SaveFileDialog();

            svf.InitializeLifetimeService();
            svf.Filter = "SQL SERVER BACKUP(*.Bak)|*.Bak";


            ClsVar.FileName = "RMS_A_" + ClsVar.DataBaseName  + "-" + dback;
            svf.FileName = ClsVar.FileName;

            DialogResult ret = STAShowDialog(svf);
            if (ret == DialogResult.OK)

                Location = svf.FileName;
            ClsVar.FilePath = Location;

            txtDBakPath.Text = Location;
            btnRmsDBk.Select();
        }

        private void bynDollarDelete_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelDollarRate == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (ClsVar.DelSection == false)
                {
                    MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string qry = "select * from MonthlyTbl where formonth='" + cboDMonth.Text.Trim() + "' and foryear='" + cboDYear.Text.Trim() + "'";

                    string CHK = SvCls.DataExist(qry);

                    if (MessageBox.Show(" Do You Realy Want To Delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                        if (CHK.ToString() == "1")
                        {
                            qry = "delete from MonthlyTbl where formonth='" + cboDMonth.Text.Trim() + "' and foryear='" + cboDYear.Text.Trim() + "'";

                            lblMgs.ForeColor = System.Drawing.Color.Red;
                            PicSave.Visible = true;
                            lblMgs.Visible = true;
                            lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        }

                    SvCls.insertUpdate(qry);
                    GridHeadDollarRate();
                    txtRate.Text = "";
                }

            }
        }

        private void btnSaveDollarRate_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveDollarRate == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string qry = "select * from MonthlyTbl where formonth='" + cboDMonth.Text.Trim() + "' and foryear='" + cboDYear.Text.Trim() + "'";

                string CHK = SvCls.DataExist(qry);

                SvCls.GetMonthYear(cboDMonth.Text.Trim(), cboDYear.Text.Trim());


                if (CHK.ToString() == "1")
                {
                    qry = "update MonthlyTbl set dollarrate=" + Convert.ToDouble(txtRate.Text.Trim()) + ",monthdays=" + ClsVar.GblMonthDays + ",monthno=" + ClsVar.GblMonthNo + " where formonth='" + cboDMonth.Text.Trim() + "' and foryear='" + cboDYear.Text.Trim() + "'";

                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    qry = "insert into MonthlyTbl (formonth,foryear,monthdays,monthno,dollarrate) values ('" + cboDMonth.Text.Trim() + "','" + cboDYear.Text.Trim() + "'," + ClsVar.GblMonthDays + "," + ClsVar.GblMonthNo + "," + Convert.ToDouble(txtRate.Text.Trim()) + ")";

                    lblMgs.ForeColor = System.Drawing.Color.White;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                SvCls.insertUpdate(qry);
                SvCls.insertUpdate("update monthlytbl set fdate=convert(datetime,'01/' + convert(varchar,monthno) + '/' + foryear,103)");
                SvCls.insertUpdate("update monthlytbl set ldate=convert(datetime,convert(varchar,monthdays) +'/' + convert(varchar,monthno) + '/' + foryear,103)");
                GridHeadDollarRate();
            }
        }

        private void GridDollarRate_DoubleClick(object sender, EventArgs e)
        {
            int i = GridDollarRate.SelectedCells[0].RowIndex;
            cboDMonth.Text = GridDollarRate.Rows[i].Cells[1].Value.ToString();
            cboDYear.Text = GridDollarRate.Rows[i].Cells[0].Value.ToString();
            txtRate.Text = GridDollarRate.Rows[i].Cells[4].Value.ToString();

        }

        private void cboDMonth_Leave(object sender, EventArgs e)
        {
            txtRate.Text = "";
        }

        private void cboDYear_Leave(object sender, EventArgs e)
        {
            txtRate.Text = "";
        }

        private void cboDMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboDYear.Select();
            }
        }

        private void cboDYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRate.Select();
            }
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSaveDollarRate.Select();
            }
        }

        private void GridMonthlySetup_DoubleClick(object sender, EventArgs e)
        {

        }

        private void GridMonthlySetup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveMonthly_Click(object sender, EventArgs e)
        {

        }

        private void btnRMS_Click(object sender, EventArgs e)
        {
            String Location = String.Empty;
            OpenFileDialog frm = new OpenFileDialog();

            frm.InitializeLifetimeService();
            //frm.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
            frm.Title = "Browse Config file";

            DialogResult ret = STAShowDialog(frm);
            if (ret == DialogResult.OK)
                Location = frm.FileName;
            txtRMSPath.Text = Location;
        }

        private void pnlGlobalSetup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridSection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkG_Click(object sender, EventArgs e)
        {

            

        }

        private void chkM_Click(object sender, EventArgs e)
        {
            
            
        }

        private void chkM_Leave(object sender, EventArgs e)
        {
            
        }

        private void chkG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkG_Leave(object sender, EventArgs e)
        {
        }

        private void GrdUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridDesg_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int psn = 0;
            psn = GridDesg.CurrentCell.ColumnIndex;
            if (GridDesg.CurrentCell.ColumnIndex == 7)
            {
                GridDesg.BeginEdit(true);
            }

            //if (GridDesg.CurrentCell.ColumnIndex == 6)
            //{
            //    GridDesg.BeginEdit(true);
            //}

            //if (GridDesg.CurrentCell.ColumnIndex == 4)
            //{
            //    GridDesg.BeginEdit(true);
            //}

            //if (GridDesg.CurrentCell.ColumnIndex == 5)
            //{
            //    GridDesg.BeginEdit(true);
            //}


            Int32 pos = GridDesg.CurrentCell.ColumnIndex;
        }

        private void btnRmsDBk_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveDatabaseBackup == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txtDBakPath.Text.Trim() == "")
                {
                    MessageBox.Show("Please Select Location to Save Backup", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection cnn = new SqlConnection("Persist Security Info=False;User ID=sa;Password='" + ClsVar.SqlPassword + "';Initial Catalog='RMS_A';Data Source='" + ClsVar.ServerName + "'");


                    cnn.Open();


                    SqlCommand cmd = new SqlCommand("DBase_backup", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@D_BaseMedia", SqlDbType.VarChar, 100));
                    cmd.Parameters["@D_BaseMedia"].Value = ClsVar.FileName;
                    cmd.Parameters.Add(new SqlParameter("@D_BasePath", SqlDbType.VarChar, 300));
                    cmd.Parameters["@D_BasePath"].Value = ClsVar.FilePath;
                    cmd.Parameters.Add(new SqlParameter("@D_BaseNAme", SqlDbType.VarChar, 30));
                    cmd.Parameters["@D_BaseNAme"].Value = "RMS_A";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("RMS Database backup Complete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
        }

        private void btnDollarRate_Click(object sender, EventArgs e)
        {
            if (ClsVar.VwDollarRate == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lebHd.Text = "[ DOLLAR RATE INFORMATION ]";

                HideAllPnl();
                pnlDollarRate.Visible = true;
                pnlDollarRate.Left = 227;
                pnlDollarRate.Top = 70;
                pnlDollarRate.Width = 700;
                pnlDollarRate.Height = 500;
                GridDollarRate.Width = 680;
                GridDollarRate.Height = 350;

                cboDMonth.Text = DateTime.Today.ToString("MMMMM");
                cboDYear.Text = DateTime.Today.ToString("yyyy");
                GridHeadDollarRate();
                cboDMonth.Select();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SvCls.insertUpdate("exec spDelEmp");
            MessageBox.Show("Done...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveSaleScrnLocation_Click(object sender, EventArgs e)
        {
            SvCls.insertUpdate("Update SettingSingle Set SaleFormLocationX = '" + txtLocationX.Text.Trim() + "', SaleFormLocationY = '" + txtLocationY.Text.Trim() +"' Where ComId = '" + ClsVar.GblComId + "'");

            lblMgs.ForeColor = System.Drawing.Color.White;
            lblMgs.Visible = true;
            lblMgs.Text = "SAVED SUCCESSFULLY...!!";
            PicSave.Visible = true;
        }

        private void chkShowFullInvoiceDelBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowFullInvoiceDelBtn.Checked == true)
            {
                SvCls.insertUpdate("Update SettingSingle SET BtnDelInvoice = '1' Where ComId = '" + ClsVar.GblComId + "'");
            }
            else
            {
                SvCls.insertUpdate("Update SettingSingle SET BtnDelInvoice = '0' Where ComId = '" + ClsVar.GblComId + "'");
            }
        }

        private void chkPayMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPayMode.Checked == true)
            {
                SvCls.insertUpdate("Update SettingSingle SET PayMode = '1' Where ComId = '" + ClsVar.GblComId + "'");
            }
            else
            {
                SvCls.insertUpdate("Update SettingSingle SET PayMode = '0' Where ComId = '" + ClsVar.GblComId + "'");
            }
        }

        private void ChkNuhashGl_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkNuhashGl.Checked == true)
            {
                SvCls.insertUpdate("Update SettingSingle SET NuhashGL = '1' Where ComId = '" + ClsVar.GblComId + "'");
            }
            else
            {
                SvCls.insertUpdate("Update SettingSingle SET NuhashGL = '0' Where ComId = '" + ClsVar.GblComId + "'");
            }
        }

        private void BtnSaveMobileNo_Click(object sender, EventArgs e)
        {
            string qry = "Update SettingSingle set MobileNo = '"+ txtMobile.Text.Trim() + "' WHERE AutoNo = 1";
            SvCls.insertUpdate(qry);
            lblMgs.Text = "Save Successfully";
            lblMgs.Visible = true;
            PicSave.Visible = true;
        }

        private void BtnShowMobile_Click(object sender, EventArgs e)
        {
            string qry = "Select MobileNo from SettingSingle WHERE AutoNo = 1";
            SvCls.toGetData(qry);
            if(SvCls.GblRdrToGetData.Read())
            {
                txtMobile.Text = SvCls.GblRdrToGetData["MobileNo"].ToString();
            }
        }
    }
       

    }
 