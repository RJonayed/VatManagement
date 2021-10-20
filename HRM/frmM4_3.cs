using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class frmM4_3 : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        public frmM4_3()
        {
            InitializeComponent();
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void Grid_Head()
        {
            Grid.DataSource = SvCls.GblDataTable("Select KromicNo as[µwgK msL¨v],PrtName as[cÖwZôv‡bi bvg],PrtAddress as[wVKvbv],HSCode as[c‡Y¨i GBP Gm ‡KvW],PonnoNam as[‡mevi bvg I eY©bv],SrbEkak as[mieiv‡ni GKK],ItmDtl as[c‡Y¨i weeiY],DmgSohoPriman as[AcPqmn cwigvY],DPName as[`vwqZ¡cÖvß e¨w³i bvg],DkTr as[`vwL‡ji ZvwiL],SebaTrik as[‡mevi cÖ_g mieiv‡ni ZvwiL],Cast (DmgAmtPurPrice as decimal(10,0)) as[µq g~j¨],DmgAmt as[AcP‡qi cwigvY],PrcntHer as[kZKiv nvi],MulloSnjKhat as[g~j¨ ms‡hvR‡bi LvZ],Cast(SnjMullo as decimal(10,0)) as[ms‡hvR‡bi g~j¨],Podobi as[c`ex],Rmk as[gšÍe¨] from M4_3");
            Grid.Refresh();
        }

        private void Grid_Panel()
        {
            FilterGrid.DataSource = SvCls.GblDataTable("Select KromicNo as[µwgK msL¨v],PrtName as[cÖwZôv‡bi bvg],PrtAddress as[wVKvbv],HSCode as[c‡Y¨i GBP Gm ‡KvW],PonnoNam as[‡mevi bvg I eY©bv],SrbEkak as[mieiv‡ni GKK],ItmDtl as[c‡Y¨i weeiY],DmgSohoPriman as[AcPqmn cwigvY],DPName as[`vwqZ¡cÖvß e¨w³i bvg],DkTr as[`vwL‡ji ZvwiL],SebaTrik as[‡mevi cÖ_g mieiv‡ni ZvwiL],Cast (DmgAmtPurPrice as decimal(10,0)) as[µq g~j¨],DmgAmt as[AcP‡qi cwigvY],PrcntHer as[kZKiv nvi],MulloSnjKhat as[g~j¨ ms‡hvR‡bi LvZ],Cast(SnjMullo as decimal(10,0)) as[ms‡hvR‡bi g~j¨],Podobi as[c`ex],Rmk as[gšÍe¨] from M4_3/* where DkTr between CONVERT(datetime,'" + dtStartDate.Text.Trim() + "',103) and  CONVERT(datetime,'" + dtEndDate.Text.Trim() + "',103)*/");
            FilterGrid.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlGrid.Visible == true)
            {
                pnlGrid.Visible = false;
            }
            else
            {
                this.Close();
            }
            
        }

        private void CmdAddk_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(Max(KromicNo)+1,1) As Max from M4_3");

            if (SvCls.GblRdrToGetData.Read())
            {
                txtKrcNo.Text = SvCls.GblRdrToGetData["Max"].ToString();
                SvCls.GblCon.Close();
            }
            cmdSave.Text = "Save";

            txtPrtName.Focus();

            txtPrtName.Text = "";
            txtPrtAddress.Text = "";
            dtDtarik.Text = "";
            dtSrbTarik.Text = "";

            txtSHCode.Text = "0";
            txtItmDtlNum.Text = "";
            txtSrbEkak.Text = "";
            txtEkItmDtl.Text = "";
            txtDmgSAmt.Text = "0";
            txtDpName.Text = "";
            txtDPurPrice.Text = "0";
            txtDmgAmt.Text = "0";
            txtPrcnt.Text = "0";
            txtMulloKht.Text = "";
            txtSnjPrice.Text = "0";
            txtPodobi.Text = "";
            txtRmk.Text = "";

            Grid_Head();

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtKrcNo.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Kromic NO...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKrcNo.Select();
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
             //   cmdDelete_Click(null, null);

                SvCls.insertUpdate("Delete from M4_3 where KromicNo='" + txtKrcNo.Text.Trim() + "'");
                lblMgs.ForeColor = System.Drawing.Color.Red;
                lblMgs.Visible = true;
                lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Grid_Head();

                CmdAdd.Focus();

            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtKrcNo.Text.Trim() == "")
            {
                MessageBox.Show("Kromic NO Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtKrcNo.Select();
                return;
            }

            if (txtPrtName.Text.Trim() == "")
            {
                MessageBox.Show("Institute Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtPrtName.Select();
                return;
            }

            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert Into M4_3 (KromicNo,PrtName,PrtAddress,DkTr,SebaTrik,HSCode,PonnoNam,SrbEkak,ItmDtl,DmgSohoPriman,DPName,DmgAmtPurPrice,DmgAmt,PrcntHer,MulloSnjKhat,SnjMullo,Podobi,Rmk)values('" + txtKrcNo.Text.Trim() + "','" + txtPrtName.Text.Trim() + "','" + txtPrtAddress.Text.Trim() + "',convert(datetime,'" + dtDtarik.Text.Trim() + "',103),convert(datetime,'" + dtSrbTarik.Text.Trim() + "',103),'" + txtSHCode.Text.Trim() + "','" + txtItmDtlNum.Text.Trim() + "','" + txtSrbEkak.Text.Trim() + "','" + txtEkItmDtl.Text.Trim() + "','" + txtDmgSAmt.Text.Trim() + "','" + txtDpName.Text.Trim() + "'," + txtDPurPrice.Text.Trim() + ",'" + txtDmgAmt.Text.Trim() + "','" + txtPrcnt.Text.Trim() + "','" + txtMulloKht.Text.Trim() + "'," + txtSnjPrice.Text.Trim() + ",'" + txtPodobi.Text.Trim() +"','" + txtRmk.Text.Trim() + "')";
            SelectQry = "Select PrtName,PrtAddress,DkTr,SebaTrik,HSCode,PonnoNam,SrbEkak,ItmDtl,DmgSohoPriman,DPName,DmgAmtPurPrice,DmgAmt,PrcntHer,MulloSnjKhat,SnjMullo,Podobi,Rmk from M4_3 where KromicNo=' " + txtKrcNo.Text.Trim() + "'";
            EdtQry = "Update M4_3 set PrtName='" + txtPrtName.Text.Trim() + "',PrtAddress='" + txtPrtAddress.Text.Trim() + "',DkTr=(Convert(datetime,'" + dtDtarik.Text.Trim() + "',103)),SebaTrik=(Convert(datetime,'" + dtSrbTarik.Text.Trim() + "',103)),HSCode='" + txtSHCode.Text.Trim() + "',PonnoNam='" + txtItmDtlNum.Text.Trim() + "',SrbEkak='" + txtSrbEkak.Text.Trim() + "',ItmDtl='" + txtEkItmDtl.Text.Trim() + "',DmgSohoPriman='" + txtDmgSAmt.Text.Trim() + "',DPName='" + txtDpName.Text.Trim() + "',DmgAmtPurPrice=" + txtDPurPrice.Text.Trim() + ",DmgAmt='" + txtDmgAmt.Text.Trim() + "',PrcntHer='" + txtPrcnt.Text.Trim() + "',MulloSnjKhat='" + txtMulloKht.Text.Trim() + "',SnjMullo=" + txtSnjPrice.Text.Trim() + ",Podobi='" + txtPodobi.Text.Trim() + "',Rmk='" + txtRmk.Text.Trim() + "' where KromicNo='" + txtKrcNo.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {

                SvCls.insertUpdate(SaveQry);

                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Grid_Head();

                CmdAdd.Focus();

            }

            else

            {
                SvCls.insertUpdate(EdtQry);
                
                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;

                CmdAdd.Focus();

                Grid_Head();
            }
        }

        private void frmM4_3_Load(object sender, EventArgs e)
        {
            pnlGrid.Visible = false;

            pnlGrid.Width = 878;
            pnlGrid.Height = 547;
            pnlGrid.Left = 12;
            pnlGrid.Top =48;

            //Grid.RowHeadersDefaultCellStyle.Font = new Font("TangonMJ", 12F, GraphicsUnit.Pixel);

            Grid_Head();
            CmdAdd.Select();

            txtSHCode.Text = "0";        
            txtSrbEkak.Text = "";
            txtDmgSAmt.Text = "0";
            txtDPurPrice.Text = "0";
            txtDmgAmt.Text = "0";
            txtPrcnt.Text = "0";
            txtMulloKht.Text = "";
            txtSnjPrice.Text = "0";
            txtRmk.Text = "";
        }

        private void txtKrcNo_Leave(object sender, EventArgs e)
        {
            if (txtKrcNo.Text.Trim() != "")
            {
                //PrtName,PrtAddress,DkTr,SebaTrik,DPName,Podobi
                string SelectQry = "Select PrtName,PrtAddress,DkTr,SebaTrik,HSCode,PonnoNam,SrbEkak,ItmDtl,DmgSohoPriman,DPName,Cast(DmgAmtPurPrice as decimal(10,0))as DmgAmtPurPrice,DmgAmt,PrcntHer,MulloSnjKhat,Cast(SnjMullo as Decimal (10,0)) as SnjMullo,Podobi,Rmk from M4_3 where KromicNo='" + txtKrcNo.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtPrtName.Text = SvCls.GblRdrToGetData["PrtName"].ToString();
                    txtPrtAddress.Text = SvCls.GblRdrToGetData["PrtAddress"].ToString();
                    dtDtarik.Text = SvCls.GblRdrToGetData["DkTr"].ToString();
                    dtSrbTarik.Text = SvCls.GblRdrToGetData["SebaTrik"].ToString();

                    txtSHCode.Text = SvCls.GblRdrToGetData["HSCode"].ToString();
                    txtItmDtlNum.Text = SvCls.GblRdrToGetData["PonnoNam"].ToString();    
                    txtSrbEkak.Text = SvCls.GblRdrToGetData["SrbEkak"].ToString();
                    txtEkItmDtl.Text = SvCls.GblRdrToGetData["ItmDtl"].ToString();
                    txtDmgSAmt .Text = SvCls.GblRdrToGetData["DmgSohoPriman"].ToString();
                    txtDpName.Text = SvCls.GblRdrToGetData["DPName"].ToString();
                    txtDPurPrice.Text = SvCls.GblRdrToGetData["DmgAmtPurPrice"].ToString();
                    txtDmgAmt.Text = SvCls.GblRdrToGetData["DmgAmt"].ToString();
                    txtPrcnt.Text = SvCls.GblRdrToGetData["PrcntHer"].ToString();
                    txtMulloKht.Text = SvCls.GblRdrToGetData["MulloSnjKhat"].ToString();
                    txtSnjPrice.Text = SvCls.GblRdrToGetData["SnjMullo"].ToString();
                    txtPodobi.Text = SvCls.GblRdrToGetData["Podobi"].ToString();
                    txtRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();

                    Grid_Head();

                    cmdSave.Text = "Edit";

                }
                else
                {
                  
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            PicSave.Visible = false;
            lblMgs.Visible = false;
        }

        private void btnRpt_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (txtKrcNo.Text != "")
            {
                ClsVar.GblSelFor = "{M4_3.KromicNo}=" + txtKrcNo.Text.Trim() + "";
            }

            //if(DtpFrom.Text == "" && DtpTo.Text == "")
            //{
            //    ClsVar.GblSelFor =" in date(" + DtpFrom.Value.Year.ToString() + "," + DtpFrom.Value.Month.ToString() + "," + DtpFrom.Value.Day.ToString() + ") to Date(" + DtpTo.Value.Year.ToString() + "," + DtpTo.Value.Month.ToString() + "," + DtpTo.Value.Day.ToString() + ")";
            //}

            ClsVar.GblRptName = "M4_3.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void CmdAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPrtName.Select();
            }
        }

        private void txtPrtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPrtAddress.Select();
            }
        }

        private void txtPrtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtSHCode.Select();
            }
        }

        private void txtSHCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtItmDtlNum.Select();
            }
        }

        private void txtItmDtlNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtSrbEkak.Select();
            }
        }

        private void txtSrbEkak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtEkItmDtl.Select();
            }
        }

        private void txtEkItmDtl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtDmgSAmt.Select();
            }
        }

        private void txtDmgSAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtDpName.Select();
            }
        }

        private void txtDpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtDtarik.Select();
            }
        }

        private void dtSrbTarik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtDPurPrice.Select();
            }
        }

        private void dtDtarik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtSrbTarik.Select();
            }
        }

        private void txtDPurPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtDmgAmt.Select();
            }
        }

        private void txtDmgAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPrcnt.Select();
            }
        }

        private void txtPrcnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMulloKht.Select();
            }
        }

        private void txtMulloKht_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtSnjPrice.Select();
            }
        }

        private void txtSnjPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPodobi.Select();
            }
        }

        private void txtPodobi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRmk.Select();
            }
        }

        private void txtRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSave.Select();
            }
        }

        private void cmdSave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                CmdAdd.Select();
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            pnlGrid.Show();

            Grid_Panel();
        }

        private void btnSearchFilter_Click(object sender, EventArgs e)
        {
            FilterGrid.DataSource = SvCls.GblDataTable("Select KromicNo as[µwgK msL¨v],PrtName as[cÖwZôv‡bi bvg],PrtAddress as[wVKvbv],HSCode as[c‡Y¨i GBP Gm ‡KvW],PonnoNam as[‡mevi bvg I eY©bv],SrbEkak as[mieiv‡ni GKK],ItmDtl as[c‡Y¨i weeiY],DmgSohoPriman as[AcPqmn cwigvY],DPName as[`vwqZ¡cÖvß e¨w³i bvg],DkTr as[`vwL‡ji ZvwiL],SebaTrik as[‡mevi cÖ_g mieiv‡ni ZvwiL],Cast (DmgAmtPurPrice as decimal(10,0)) as[µq g~j¨],DmgAmt as[AcP‡qi cwigvY],PrcntHer as[kZKiv nvi],MulloSnjKhat as[g~j¨ ms‡hvR‡bi LvZ],Cast(SnjMullo as decimal(10,0)) as[ms‡hvR‡bi g~j¨],Podobi as[c`ex],Rmk as[gšÍe¨] from M4_3 where DkTr between CONVERT(datetime,'" + dtStartDate.Text.Trim() + "',103) and  CONVERT(datetime,'" + dtEndDate.Text.Trim() + "',103)");
            FilterGrid.Refresh();
        }

        private void FilterGrid_DoubleClick(object sender, EventArgs e)
        {
            Grid_DoubleClick(null,null);

            pnlGrid.Visible = false;
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            txtKrcNo.Text = Grid.Rows[i].Cells[0].Value.ToString();
            txtPrtName.Text = Grid.Rows[i].Cells[1].Value.ToString();
            txtPrtAddress.Text = Grid.Rows[i].Cells[2].Value.ToString();
            txtSHCode.Text = Grid.Rows[i].Cells[3].Value.ToString();
            txtItmDtlNum.Text = Grid.Rows[i].Cells[4].Value.ToString();
            txtSrbEkak.Text = Grid.Rows[i].Cells[5].Value.ToString();

            txtEkItmDtl.Text = Grid.Rows[i].Cells[6].Value.ToString();
            txtDmgSAmt.Text = Grid.Rows[i].Cells[7].Value.ToString();
            txtDpName.Text = Grid.Rows[i].Cells[8].Value.ToString();
            dtDtarik.Text = Grid.Rows[i].Cells[9].Value.ToString();
            dtSrbTarik.Text = Grid.Rows[i].Cells[10].Value.ToString();
            txtDPurPrice.Text = Grid.Rows[i].Cells[11].Value.ToString();
            txtDmgAmt.Text = Grid.Rows[i].Cells[12].Value.ToString();
            txtPrcnt.Text = Grid.Rows[i].Cells[13].Value.ToString();
            txtMulloKht.Text = Grid.Rows[i].Cells[14].Value.ToString();
            txtSnjPrice.Text = Grid.Rows[i].Cells[15].Value.ToString();
            txtPodobi.Text = Grid.Rows[i].Cells[16].Value.ToString();
            txtRmk.Text = Grid.Rows[i].Cells[17].Value.ToString();
        }
    }
}
