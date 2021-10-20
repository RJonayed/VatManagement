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

    public partial class frmM6_3 : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        public frmM6_3()
        {
            InitializeComponent();
        }

        private void frmM6_3_Load(object sender, EventArgs e)
        {
            pnlGrid.Visible = false;

            pnlGrid.Width = 878;
            pnlGrid.Height = 544;
            pnlGrid.Left = 12;
            pnlGrid.Top = 52;

            Grid_Head();
            CmdAdd.Select();
            txtKrcNo.Text = "";
            txtNBName.Text = "";
            txtNbBin.Text = "0";
            txtCPIsAddress.Text = "";
            txtkrtName.Text = "";
            txtKrtBin.Text = "0";
            txtDstn.Text = "";
            txtClNo.Text = "0";
            DtIssuDate.Text = "";
            txtItemDtl.Text = "";
            txtKorHer.Text = "0";
            txtKorAmt.Text = "0";
            txtPrice.Text = "0";
            txtSmkAmt.Text = "0";
            txtSrbEkak.Text = "0";
            txtTotPrice.Text = "0";
            txtAmt.Text = "0";
            txtAllPrice.Text = "0";
            txtDpName.Text = "";
            txtPodobi.Text = "";
        }

        private void Grid_Head()
        {
            Grid.DataSource = SvCls.GblDataTable("Select KromicNo as[µwgK bs],NbName as[wbewÜZ  e¨w³i bvg],NbBin as[wbewÜZ e¨w³i weAvBGb],CalanPIssAddress as[PvjvbcÎ Bm¨yi wVKvbv],KrtName as[‡µZvi bvg],BrandNum as[cY¨ ev †mevi eY©bv],CollectEkak as[mieiv‡ni GKK],Cast(Amt as decimal(10,0)) as [cwigvY],Cast(EkakTk as decimal(10,0))as [GKK g~j¨],DpName as[`vwqZ¡cÖvß e¨w³i bvg],KrtBin as[‡µZvi weAvBGb],SrbDestNi as[mieiv‡ni MšÍe¨¯’j],CalanPNo as[PvjvbcÖÎ b¤^i],IssuDt as[Bm¨yi ZvwiL],Cast(TotTk as decimal(10,0))as [‡gvU g~j¨],Cast(SmpSlkTk as decimal(10,0)) as [m¤ú~iK k~‡éi cwigvY],KorerHar as[g~j¨ ms‡hvRb K‡ii nvi],Cast(KorerTk as decimal(10,0)) as[g~j¨ ms‡hvRb K‡ii cwigvY],Cast(AllSulkKorTk as Decimal(10,0)) as [mKj cÖKvi k~é I Kimn g~j¨],Desing as[c`ex] from M6_3 /*where KromicNo='" + txtKrcNo.Text.Trim() + "'*/");
            Grid.Refresh();
        }

        private void Filter_Grid()
        {
            FilterGrid.DataSource = SvCls.GblDataTable("Select KromicNo as[µwgK bs],NbName as[wbewÜZ  e¨w³i bvg],NbBin as[wbewÜZ e¨w³i weAvBGb],CalanPIssAddress as[PvjvbcÎ Bm¨yi wVKvbv],KrtName as[‡µZvi bvg],BrandNum as[cY¨ ev †mevi eY©bv],CollectEkak as[mieiv‡ni GKK],Cast(Amt as decimal(10,0)) as [cwigvY],Cast(EkakTk as decimal(10,0))as [GKK g~j¨],DpName as[`vwqZ¡cÖvß e¨w³i bvg],KrtBin as[‡µZvi weAvBGb],SrbDestNi as[mieiv‡ni MšÍe¨¯’j],CalanPNo as[PvjvbcÖÎ b¤^i],IssuDt as[Bm¨yi ZvwiL],Cast(TotTk as decimal(10,0))as [‡gvU g~j¨],Cast(SmpSlkTk as decimal(10,0)) as [m¤ú~iK k~‡éi cwigvY],KorerHar as[g~j¨ ms‡hvRb K‡ii nvi],Cast(KorerTk as decimal(10,0)) as[g~j¨ ms‡hvRb K‡ii cwigvY],Cast(AllSulkKorTk as Decimal(10,0)) as [mKj cÖKvi k~é I Kimn g~j¨],Desing as[c`ex] from M6_3");
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
            SvCls.toGetData("select isnull(Max(KromicNo)+1,1) As Max from M6_3");

            if (SvCls.GblRdrToGetData.Read())
            {
                txtKrcNo.Text = SvCls.GblRdrToGetData["Max"].ToString();
                SvCls.GblCon.Close();
            }

            cmdSave.Text = "Save";

            txtNBName.Focus();

            txtNBName.Text = "";
            txtNbBin.Text = "0";
            txtCPIsAddress.Text = "";
            txtkrtName.Text = "";
            txtKrtBin.Text = "0";
            txtDstn.Text = "";
            txtClNo.Text = "0";
            DtIssuDate.Text = "";

            txtItemDtl.Text = "";
            txtKorHer.Text = "0";
            txtKorAmt.Text = "";
            txtPrice.Text = "0";
            txtSmkAmt.Text = "0";
            txtSrbEkak.Text = "0";
            txtTotPrice.Text = "0";
            txtAmt.Text = "0";
            txtAllPrice.Text = "0";
            txtDpName.Text = "";
            txtPodobi.Text = "";

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
                //cmdDelete_Click(null, null);

                SvCls.insertUpdate("Delete from M6_3 where KromicNo='" + txtKrcNo.Text.Trim() + "'");
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

            if (txtNBName.Text.Trim() == "")
            {
                MessageBox.Show("Supplier Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtNBName.Select();
                return;
            }

            string SaveQry;
            string SelectQry;
            string EdtQry;
          
            SaveQry = "Insert Into M6_3 (KromicNo,NbName,NbBin,CalanPIssAddress,KrtName,KrtBin,SrbDestNi,CalanPNo,IssuDt,BrandNum,CollectEkak,Amt,EkakTk,TotTk,SmpSlkTk,KorerHar,KorerTk,AllSulkKorTk,DpName,Desing)values('" + txtKrcNo.Text.Trim() + "','" + txtNBName.Text.Trim() + "','" + txtNbBin.Text.Trim() + "','" + txtCPIsAddress.Text.Trim() + "','" + txtkrtName.Text.Trim() + "','" + txtKrtBin.Text.Trim() + "','" + txtDstn.Text.Trim() + "','" + txtClNo.Text.Trim() + "',convert(datetime,'" + DtIssuDate.Text.Trim() + "',103),'" + txtItemDtl.Text.Trim() + "','" + txtSrbEkak.Text.Trim() + "'," + txtAmt.Text.Trim() + "," + txtPrice.Text.Trim() + "," + txtTotPrice.Text.Trim() + "," + txtSmkAmt.Text.Trim() + ",'" + txtKorHer.Text.Trim() + "'," + txtKorAmt.Text.Trim() + "," + txtAllPrice.Text.Trim() + ",'" + txtDpName.Text.Trim() + "','" + txtPodobi.Text.Trim() + "')";
            SelectQry = "Select NbName,NbBin,CalanPIssAddress,KrtName,KrtBin,SrbDestNi,CalanPNo,IssuDt,BrandNum,CollectEkak,Amt,EkakTk,TotTk,SmpSlkTk,KorerHar,KorerTk,AllSulkKorTk,DpName,Desing from M6_3 where KromicNo='" + txtKrcNo.Text.Trim() + "'";
            EdtQry = "Update M6_3 Set NbName='" + txtNBName.Text.Trim() + "',NbBin='" + txtNbBin.Text.Trim() + "',CalanPIssAddress='" + txtCPIsAddress.Text.Trim() + "',KrtName='" + txtkrtName.Text.Trim() + "',KrtBin='" + txtKrtBin.Text.Trim() + "',SrbDestNi='" + txtDstn.Text.Trim() + "',CalanPNo='" + txtClNo.Text.Trim() + "',IssuDt=convert(datetime,'" + DtIssuDate.Text.Trim() + "',103),BrandNum='" + txtItemDtl.Text.Trim() + "',CollectEkak='" + txtSrbEkak.Text.Trim() + "',Amt=" + txtAmt.Text.Trim() + ",EkakTk=" + txtPrice.Text.Trim() + ",TotTk=" + txtTotPrice.Text.Trim() + ",SmpSlkTk=" + txtSmkAmt.Text.Trim() + ",KorerHar='" + txtKorHer.Text.ToLower() + "',KorerTk=" + txtKorAmt.Text.Trim() + ",AllSulkKorTk=" + txtAllPrice.Text.Trim() + ",DpName='" + txtDpName.Text.Trim() + "',Desing='" + txtPodobi.Text.Trim() + "' where KromicNo='" + txtKrcNo.Text.Trim() + "'";

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

        private void txtKrcNo_Leave(object sender, EventArgs e)
        {
            if (txtKrcNo.Text.Trim() != "")
            {

                string SelectQry = "Select NbName,NbBin,CalanPIssAddress,KrtName,KrtBin,SrbDestNi,CalanPNo,IssuDt,BrandNum,CollectEkak,Cast(Amt as decimal(10,0)) as Amt,Cast(EkakTk as decimal(10,0))as EkakTk,Cast(TotTk as decimal(10,0))as TotTk,Cast(SmpSlkTk as decimal(10,0)) as SmpSlkTk,KorerHar,Cast(KorerTk as decimal(10,0)) as KorerTk,Cast(AllSulkKorTk as Decimal(10,0)) as AllSulkKorTk,DpName,Desing from M6_3 where KromicNo='" + txtKrcNo.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {

                    txtNBName.Text = SvCls.GblRdrToGetData["NbName"].ToString();
                    txtNbBin.Text = SvCls.GblRdrToGetData["NbBin"].ToString();
                    txtCPIsAddress.Text = SvCls.GblRdrToGetData["CalanPIssAddress"].ToString();
                    txtkrtName.Text = SvCls.GblRdrToGetData["KrtName"].ToString();
                    txtKrtBin.Text = SvCls.GblRdrToGetData["KrtBin"].ToString();
                    txtDstn.Text = SvCls.GblRdrToGetData["SrbDestNi"].ToString();
                    txtClNo.Text = SvCls.GblRdrToGetData["CalanPNo"].ToString();
                    DtIssuDate.Text = SvCls.GblRdrToGetData["IssuDt"].ToString();
                    txtItemDtl.Text = SvCls.GblRdrToGetData["BrandNum"].ToString();
                    txtSrbEkak.Text = SvCls.GblRdrToGetData["CollectEkak"].ToString();
                    txtAmt.Text = SvCls.GblRdrToGetData["Amt"].ToString();
                    txtPrice.Text = SvCls.GblRdrToGetData["EkakTk"].ToString();
                    txtTotPrice.Text = SvCls.GblRdrToGetData["TotTk"].ToString();
                    txtSmkAmt.Text = SvCls.GblRdrToGetData["SmpSlkTk"].ToString();
                    txtKorHer.Text = SvCls.GblRdrToGetData["KorerHar"].ToString();
                    txtKorAmt.Text = SvCls.GblRdrToGetData["KorerTk"].ToString();
                    txtAllPrice.Text = SvCls.GblRdrToGetData["AllSulkKorTk"].ToString();
                    txtDpName.Text = SvCls.GblRdrToGetData["DpName"].ToString();
                    txtPodobi.Text = SvCls.GblRdrToGetData["Desing"].ToString();

                    txtNBName.Select();

                    Grid_Head();

                    cmdSave.Text = "Edit";

                }
                else
                {
                    
                }
            }
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

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
                ClsVar.GblSelFor =  "{M6_3.KromicNo}=" + txtKrcNo.Text.Trim() + "";
            }
            ClsVar.GblRptName = "M6_3.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void txtNBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtNbBin.Select();
            }
        }

        private void txtNbBin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtCPIsAddress.Select();
            }
        }

        private void txtCPIsAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtkrtName.Select();
            }
        }

        private void txtkrtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtItemDtl.Select();
            }
        }

        private void txtKrtBin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtDstn.Select();
            }
        }

        private void txtDstn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtClNo.Select();
            }
        }

        private void txtClNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                DtIssuDate.Select();
            }
        }

        private void DtIssuDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtTotPrice.Select();
            }
        }

        private void CmdAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtItemDtl_KeyPress(object sender, KeyPressEventArgs e)
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
                txtAmt.Select();
            }
        }

        private void txtAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPrice.Select();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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
                txtKrtBin.Select();
            }
        }

        private void txtTotPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtSmkAmt.Select();
            }
        }

        private void txtSmkAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKorHer.Select();
            }
        }

        private void txtKorHer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKorAmt.Select();
            }
        }

        private void txtKorAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtAllPrice.Select();
            }
        }

        private void txtAllPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            pnlGrid.Show();
            Filter_Grid();
        }

        private void btnSearchFilter_Click(object sender, EventArgs e)
        {
            FilterGrid.DataSource = SvCls.GblDataTable("Select KromicNo as[µwgK bs],NbName as[wbewÜZ  e¨w³i bvg],NbBin as[wbewÜZ e¨w³i weAvBGb],CalanPIssAddress as[PvjvbcÎ Bm¨yi wVKvbv],KrtName as[‡µZvi bvg],BrandNum as[cY¨ ev †mevi eY©bv],CollectEkak as[mieiv‡ni GKK],Cast(Amt as decimal(10,0)) as [cwigvY],Cast(EkakTk as decimal(10,0))as [GKK g~j¨],DpName as[`vwqZ¡cÖvß e¨w³i bvg],KrtBin as[‡µZvi weAvBGb],SrbDestNi as[mieiv‡ni MšÍe¨¯’j],CalanPNo as[PvjvbcÖÎ b¤^i],IssuDt as[Bm¨yi ZvwiL],Cast(TotTk as decimal(10,0))as [‡gvU g~j¨],Cast(SmpSlkTk as decimal(10,0)) as [m¤ú~iK k~‡éi cwigvY],KorerHar as[g~j¨ ms‡hvRb K‡ii nvi],Cast(KorerTk as decimal(10,0)) as[g~j¨ ms‡hvRb K‡ii cwigvY],Cast(AllSulkKorTk as Decimal(10,0)) as [mKj cÖKvi k~é I Kimn g~j¨],Desing as[c`ex] from M6_3  where IssuDt between CONVERT(datetime,'" + dtStartDate.Text.Trim() + "',103) and  CONVERT(datetime,'" + dtEndDate.Text.Trim() + "',103)");
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
            //  txtKrcNo_Leave(null,null);
            txtKrcNo.Text = Grid.Rows[i].Cells[0].Value.ToString();
            txtNBName.Text = Grid.Rows[i].Cells[1].Value.ToString();
            txtNbBin.Text = Grid.Rows[i].Cells[2].Value.ToString();
            txtCPIsAddress.Text = Grid.Rows[i].Cells[3].Value.ToString();
            txtkrtName.Text = Grid.Rows[i].Cells[4].Value.ToString();
            txtItemDtl.Text = Grid.Rows[i].Cells[5].Value.ToString();
            txtSrbEkak.Text = Grid.Rows[i].Cells[6].Value.ToString();
            txtAmt.Text = Grid.Rows[i].Cells[7].Value.ToString();
            txtPrice.Text = Grid.Rows[i].Cells[8].Value.ToString();
            txtDpName.Text = Grid.Rows[i].Cells[9].Value.ToString();
            txtKrtBin.Text = Grid.Rows[i].Cells[10].Value.ToString();
            txtDstn.Text = Grid.Rows[i].Cells[11].Value.ToString();
            txtClNo.Text = Grid.Rows[i].Cells[12].Value.ToString();
            DtIssuDate.Text = Grid.Rows[i].Cells[13].Value.ToString();
            txtTotPrice.Text = Grid.Rows[i].Cells[14].Value.ToString();
            txtSmkAmt.Text = Grid.Rows[i].Cells[15].Value.ToString();
            txtKorHer.Text = Grid.Rows[i].Cells[16].Value.ToString();
            txtKorAmt.Text = Grid.Rows[i].Cells[17].Value.ToString();
            txtAllPrice.Text = Grid.Rows[i].Cells[18].Value.ToString();
            txtPodobi.Text = Grid.Rows[i].Cells[19].Value.ToString();
        }

        private void Grid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}