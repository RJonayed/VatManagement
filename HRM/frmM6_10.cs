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

    public partial class frmM6_10 : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        public frmM6_10()
        {
            InitializeComponent();
        }

        private void lblMgs_Click(object sender, EventArgs e)
        {

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

        private void frmM6_10_Load(object sender, EventArgs e)
        {
            pnlGrid.Visible = false;
            pnlGrid.Width = 883;
            pnlGrid.Height = 544;
            pnlGrid.Left = 12;
            pnlGrid.Top = 52;
          
            CmdAddk.Select();

            Grid_HeadB();

            txtChlNok.Text = "";
            dtpIssuTrkK.Text = "";
            txtPrcPrice.Text = "0";
            txtBkNum.Text = "";
            txtBMullo.Text = "0";
            txtBkAddress.Text = "";
            txtBkNID.Text = "";
            txtChlNoKha.Text = "";
            dtBTarik.Text = "";
            txtSlPrice.Text = "0";
            txtKrtNum.Text = "";
            txtKAddress.Text = "";
            txtKNID.Text = "";
        }

        private void Grid_HeadB()
        {
            GridB.DataSource = SvCls.GblDataTable("Select KromikNoA as[µwgK bs K],TbbName as[ZvwjKvfz³ e¨w³i bvg],Bin as[weAvBGb],ChalanNo as [PvjvicÎ bs K],IssuDt as [Bm¨yi ZvwiL K],Cast(kroyMullo as decimal(10,0)) as [µq g~j¨],BikretarNum as [we‡µZi bvg],KAddress as [we‡µZi  wVKvbv],KNID as [ we‡µZi Gb AvB wW],KromikNoB as[µwgK bs L],ChalanNoB as[PvjvicÎ bs L],IssuDtB as [Bm¨yi ZvwiL L],Cast(kroyMulloB as decimal(10,0)) as [weµq g~j¨],kretarNumB as[‡µZi bvg],KrtAddressB as[‡µZvi  wVKvbv],NIDb as[ ‡µZvi Gb AvB wW],DbName as[`vwqZ¡cÖvß e¨w³i bvg] from M6_10Ka /*where KromikNoA='" + txtKrcNok.Text.Trim() + "'*/");
            GridB.Refresh();
        }
        private void Grid_Filter()
        {
            FilterGrid.DataSource = SvCls.GblDataTable("Select KromikNoA as[µwgK bs K],TbbName as[ZvwjKvfz³ e¨w³i bvg],Bin as[weAvBGb],ChalanNo as [PvjvicÎ bs K],IssuDt as [Bm¨yi ZvwiL K],Cast(kroyMullo as decimal(10,0)) as [µq g~j¨],BikretarNum as [we‡µZi bvg],KAddress as [we‡µZi  wVKvbv],KNID as [ we‡µZi Gb AvB wW],KromikNoB as[µwgK bs L],ChalanNoB as[PvjvicÎ bs L],IssuDtB as [Bm¨yi ZvwiL L],Cast(kroyMulloB as decimal(10,0)) as [weµq g~j¨],kretarNumB as[‡µZi bvg],KrtAddressB as[‡µZvi  wVKvbv],NIDb as[ ‡µZvi Gb AvB wW],DbName as[`vwqZ¡cÖvß e¨w³i bvg] from M6_10Ka /*where KromikNoA='" + txtKrcNok.Text.Trim() + "'*/");
            FilterGrid.Refresh();
        }
        private void CmdAddk_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(Max(KromikNoA)+1,1) As Max from M6_10Ka");

            if (SvCls.GblRdrToGetData.Read())
            {
                txtKrcNok.Text = SvCls.GblRdrToGetData["Max"].ToString();
                SvCls.GblCon.Close();
            }
            cmdSave.Text = "Save";

            Grid_HeadB();

            txtTBName.Focus();

            txtTBName.Text = "";
            txtBIN.Text = "";
            txtChlNok.Text = "";
            dtpIssuTrkK.Text = "";
            txtPrcPrice.Text = "0";
            txtBkNum.Text = "";
            txtBkAddress.Text = "0";
            txtBkNID.Text = "";

            button2_Click_1(null, null);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
         }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtKrcNok.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Kromic NO...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKrcNok.Select();
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //cmdDelete_Click(null, null);

                SvCls.insertUpdate("Delete from M6_10Ka where KromikNoA='" + txtKrcNok.Text.Trim() + "'");
                lblMgs.ForeColor = System.Drawing.Color.Red;
                lblMgs.Visible = true;
                lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Grid_HeadB();

                txtTBName.Focus();

            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            if (txtKrcNok.Text.Trim() == "")
            {
                MessageBox.Show("Kromic NO Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtKrcNok.Select();
                return;
            }

            if (txtTBName.Text.Trim() == "")
            {
                MessageBox.Show("Registered Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTBName.Select();
                return;
            }


            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert into M6_10Ka(KromikNoA,TbbName,Bin,ChalanNo,IssuDt,kroyMullo,BikretarNum,KAddress,KNID,KromikNoB,ChalanNoB,IssuDtB,kroyMulloB,kretarNumB,KrtAddressB,NIDb,DbName)values('" + txtKrcNok.Text.Trim() + "','" + txtTBName.Text.Trim() + "','" + txtBIN.Text.Trim() + "','" + txtChlNok.Text.Trim() + "',convert(datetime,'" + dtpIssuTrkK.Text.Trim() + "',103)," + txtPrcPrice.Text.Trim() + ",'" + txtBkNum.Text.Trim() + "','" + txtBkAddress.Text.Trim() + "','" + txtBkNID.Text.Trim() + "','" + txtKrcNoB.Text.Trim() + "','" + txtChlNoKha.Text.Trim() + "',Convert(datetime,'" + dtBTarik.Text.Trim() + "',103)," + txtBMullo.Text.Trim() + ",'" + txtKrtNum.Text.Trim() + "','" + txtKAddress.Text.Trim() + "','" + txtKNID.Text.Trim() + "','" + txtDPName.Text.Trim() + "')";
            SelectQry = "select TbbName,Bin,ChalanNo,IssuDt,kroyMullo,BikretarNum,KAddress,KNID,KromikNoB,ChalanNoB,IssuDtB,kroyMulloB,kretarNumB,KrtAddressB,NIDb from M6_10Ka where KromikNoA='" + txtKrcNok.Text.Trim() + "'";
            EdtQry = "Update M6_10Ka set TbbName='" + txtTBName.Text.Trim() + "',Bin='" + txtBIN.Text.Trim() + "',ChalanNo='" + txtChlNok.Text.Trim() + "',IssuDt=convert(datetime,'" + dtpIssuTrkK.Text.Trim() + "',103),kroyMullo=" + txtPrcPrice.Text.Trim() + ",BikretarNum='" + txtBkNum.Text.Trim() + "',KAddress='" + txtBkAddress.Text.Trim() + "',KNID='" + txtBkNID.Text.Trim() + "',KromikNoB='" + txtKrcNoB.Text.Trim() + "',ChalanNoB='" + txtChlNoKha.Text.Trim() + "',IssuDtB=Convert(datetime,'" + dtBTarik.Text.Trim() + "',103),kroyMulloB=" + txtBMullo.Text.Trim() + ",kretarNumB='" + txtKrtNum.Text.Trim() + "',KrtAddressB='" + txtKAddress.Text.Trim() + "',NIDb='" + txtKNID.Text.Trim() + "',DbName='" + txtDPName.Text.Trim() + "' where KromikNoA='" + txtKrcNok.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {


                //cmdSave_Click(null, null);

                SvCls.insertUpdate(SaveQry);

                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Grid_HeadB();

                CmdAddk.Focus();

            }

            else

            {
                SvCls.insertUpdate(EdtQry);


                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;

                CmdAddk.Focus();

                Grid_HeadB();
            }

        }

        private void txtKrcNok_Leave(object sender, EventArgs e)
        {
            
            string SelectQry = "select TbbName,Bin,ChalanNo,IssuDt,Cast(kroyMullo as Decimal(10,0))as kroyMullo,BikretarNum,KAddress,KNID,KromikNoB,ChalanNoB,IssuDtB,Cast(kroyMulloB as Decimal(10,0)) as kroyMulloB,kretarNumB,KrtAddressB,NIDb,DbName from M6_10Ka where KromikNoA='" + txtKrcNok.Text.Trim() + "'";
            SvCls.toGetData(SelectQry);
            if (SvCls.GblRdrToGetData.Read())
            {
                txtTBName.Text = SvCls.GblRdrToGetData["TbbName"].ToString();
                txtBIN.Text = SvCls.GblRdrToGetData["Bin"].ToString();
                txtChlNok.Text = SvCls.GblRdrToGetData["ChalanNo"].ToString();
                dtpIssuTrkK.Text = SvCls.GblRdrToGetData["IssuDt"].ToString();
                txtPrcPrice.Text = SvCls.GblRdrToGetData["kroyMullo"].ToString();
                txtBkNum.Text = SvCls.GblRdrToGetData["BikretarNum"].ToString();
                txtBkAddress.Text = SvCls.GblRdrToGetData["KAddress"].ToString();
                txtBkNID.Text = SvCls.GblRdrToGetData["KNID"].ToString();

                txtKrcNoB.Text = SvCls.GblRdrToGetData["KromikNoB"].ToString();
                txtChlNoKha.Text = SvCls.GblRdrToGetData["ChalanNoB"].ToString();
                dtBTarik.Text = SvCls.GblRdrToGetData["IssuDtB"].ToString();
                txtBMullo.Text = SvCls.GblRdrToGetData["kroyMulloB"].ToString();
                txtKrtNum.Text = SvCls.GblRdrToGetData["kretarNumB"].ToString();
                txtKAddress.Text = SvCls.GblRdrToGetData["KrtAddressB"].ToString();
                txtKNID.Text = SvCls.GblRdrToGetData["NIDb"].ToString();
                txtDPName.Text = SvCls.GblRdrToGetData["DbName"].ToString();

                cmdSave.Text = "Edit";

                Grid_HeadB();
            }
           
        }

        private void btmSvKha_Click(object sender, EventArgs e)
        {

        }

        private void txtKrcNoB_Leave(object sender, EventArgs e)
        {
         
           
        }

        private void btnDelKha_Click(object sender, EventArgs e)
        {

            
        }

        private void txtKrcNoB_TextChanged(object sender, EventArgs e)
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

            if (txtKrcNok.Text != "")
            {
                ClsVar.GblSelFor = "{VwM6_10Ka.KromikNoA}=" + txtKrcNok.Text.Trim() + "";
            }

            //if(DtpFrom.Text!="")
            //{
            //    ClsVar.GblSelFor = "";
            //}

            ClsVar.GblRptName = "M6_10.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(Max(KromikNoB)+1,1) As Max from M6_10Ka");

            if (SvCls.GblRdrToGetData.Read())
            {
                txtKrcNoB.Text = SvCls.GblRdrToGetData["Max"].ToString();
                SvCls.GblCon.Close();
            }
            cmdSave.Text = "Save";

            Grid_HeadB();

            dtBTarik.Text = "";
            txtChlNoKha.Text = "0";
            txtBMullo.Text = "0";
            txtKrtNum.Text = "";
            txtKAddress.Text = "";
            txtKNID.Text = "";
            txtDPName.Text = "";

        }

        private void GridB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtTBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBIN.Select();
            }
        }

        private void txtBIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtChlNok.Select();
            }
        }

        private void CmdAddk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtTBName.Select();
            }
        }

        private void txtChlNok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpIssuTrkK.Select();
            }
        }

        private void CmdAddk_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dtpIssuTrkK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPrcPrice.Select();
            }
        }

        private void txtPrcPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBkNum.Select();
            }
        }

        private void txtBkNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBkAddress.Select();
            }
        }

        private void txtBkAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBkNID.Select();
            }
        }

        private void txtBkNID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKrcNoB.Select();
            }
        }

        private void txtKrcNoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtChlNoKha.Select();
            }
        }

        private void txtChlNoKha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtBTarik.Select();
            }
        }

        private void dtBTarik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBMullo.Select();
            }
        }

        private void txtBMullo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKrtNum.Select();
            }
        }

        private void txtKrtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKAddress.Select();
            }
        }

        private void txtKAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKNID.Select();
            }
        }

        private void txtKNID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtDPName.Select();
            }
        }

        private void txtDPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSave.Select();
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            pnlGrid.Show();
            Grid_Filter();
        }

        private void btnSearchFilter_Click(object sender, EventArgs e)
        {
            FilterGrid.DataSource = SvCls.GblDataTable("Select KromikNoA as[µwgK bs K],TbbName as[ZvwjKvfz³ e¨w³i bvg],Bin as[weAvBGb],ChalanNo as [PvjvicÎ bs K],IssuDt as [Bm¨yi ZvwiL K],Cast(kroyMullo as decimal(10,0)) as [µq g~j¨],BikretarNum as [we‡µZi bvg],KAddress as [we‡µZi  wVKvbv],KNID as [ we‡µZi Gb AvB wW],KromikNoB as[µwgK bs L],ChalanNoB as[PvjvicÎ bs L],IssuDtB as [Bm¨yi ZvwiL L],Cast(kroyMulloB as decimal(10,0)) as [weµq g~j¨],kretarNumB as[‡µZi bvg],KrtAddressB as[‡µZvi  wVKvbv],NIDb as[ ‡µZvi Gb AvB wW],DbName as[`vwqZ¡cÖvß e¨w³i bvg] from M6_10Ka where IssuDt between CONVERT(datetime,'" + dtStartDate.Text.Trim() + "',103) and  CONVERT(datetime,'" + dtEndDate.Text.Trim() + "',103)");
            FilterGrid.Refresh();
        }

        private void FilterGrid_DoubleClick(object sender, EventArgs e)
        {
           
            GridB_DoubleClick(null,null);

            pnlGrid.Visible = false;
        }

        private void GridB_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = GridB.SelectedCells[0].RowIndex;
            txtChlNok.Text = GridB.Rows[i].Cells[0].Value.ToString();
            txtTBName.Text = GridB.Rows[i].Cells[1].Value.ToString();
            txtBIN.Text = GridB.Rows[i].Cells[2].Value.ToString();
            txtKrcNok.Text = GridB.Rows[i].Cells[3].Value.ToString();
            dtpIssuTrkK.Text = GridB.Rows[i].Cells[4].Value.ToString();
            txtPrcPrice.Text = GridB.Rows[i].Cells[5].Value.ToString();
            txtKrtNum.Text = GridB.Rows[i].Cells[6].Value.ToString();
            txtKAddress.Text = GridB.Rows[i].Cells[7].Value.ToString();
            txtBkNID.Text = GridB.Rows[i].Cells[8].Value.ToString();
            txtKrcNoB.Text = GridB.Rows[i].Cells[9].Value.ToString();
            txtChlNoKha.Text = GridB.Rows[i].Cells[10].Value.ToString();
            dtBTarik.Text = GridB.Rows[i].Cells[11].Value.ToString();
            txtBMullo.Text = GridB.Rows[i].Cells[12].Value.ToString();
            txtBkNum.Text = GridB.Rows[i].Cells[13].Value.ToString();
            txtBkAddress.Text = GridB.Rows[i].Cells[14].Value.ToString();
            txtKNID.Text = GridB.Rows[i].Cells[15].Value.ToString();
            txtDPName.Text = GridB.Rows[i].Cells[16].Value.ToString();
        }
    }
}
