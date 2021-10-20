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
    public partial class frmM6_1 : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();

        double Amt1 = 0;
        double Amt2= 0;
        double Amt3 = 0;
        double Ml1 = 0;
        double Ml2 = 0;
        double Ml3 = 0;
        public frmM6_1()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmM6_1_Load(object sender, EventArgs e)
        {
            pnlGrid.Visible = false;
            pnlGrid.Width = 883;
            pnlGrid.Height = 547;
            pnlGrid.Left = 7;
            pnlGrid.Top = 48;

          
            CmdAdd.Select();
            Grid_Head();

            txtMojudAmt.Text = "";
            dtpTarik1.Text = "";
            DtTarik2.Text = "";
            txtKrtpAmt.Text = "";
            txtTotUpAmt.Text = "";
            txtPnpsAmt.Text = "";
            txtPntJAmt.Text = "";
            txtMojudMullo.Text = "0";
            txtTotupMullo.Text = "0";
            txtPnpsMullo.Text = "0";
            txtPtjMullo.Text = "0";
            txtKrtpMullo.Text = "0";
            txtBilNo.Text = "0";
            txtMusok.Text = "0";
            txtSmSulko.Text = "0";

        }
        
        private void Grid_Head()
        {
            Grid.DataSource = SvCls.GblDataTable("select KromicNo as [µwgK bs],Tarik as[ZvwiL],MojudPoriman as [gRy` DcKi‡Yi ‡Ri cwigvb],cast(MojudMullo as Decimal(10,0)) as [gRy` DcKi‡Yi ‡Ri  g~j¨],BillNo as[wej bv¤^vi],BillTarik as[µ‡qi ZvwiL],Num as[we‡µZi bvg],BAddress as[we‡µZi wVKvbv],NID as[Gb AvB wW bs],Biboron as[µqK…Z DKi‡Yi weweiY],Amount as[µqK…Z DKi‡Yi  cwigvY],cast(KorBetitoMullo as decimal(10,0)) as [µqK…Z DKi‡Yi g~j¨],Cast(SmpSulko as decimal(10,0)) as [m¤ú~iKk~é],Cast(Musok as decimal(10,0)) as[g~mK],EkakAmt1 as[‡gvU DcKi‡Yi cwigvY],Cast(MulloAllKorbetito1 as decimal(10,0))as [‡gvU DcKi‡Yi g~j¨],EkakAmt2 as[cY¨ cÖ¯‘‡Zi cwigvY ],Cast(MulloAllKorbetito2 as decimal(10,0))as [cY¨ cÖ¯‘‡Zi g~j¨],UpoEkakAmt as [cÖvwšÍK ‡R‡ii  cwigvY ],Cast(UpoMulloAllKorbetito as decimal(10,0)) as [cÖvwšÍK ‡R‡ii g~j¨],Rmk as[gšÍe¨] from M6_1 /*where KromicNo='" + txtKromicNo.Text.Trim() + "'*/");
            Grid.Refresh();
        }
        private void Grid_Filter()
        {
            FilterGrid.DataSource = SvCls.GblDataTable("select KromicNo as [µwgK bs],Tarik as[ZvwiL],MojudPoriman as [gRy` DcKi‡Yi ‡Ri cwigvb],cast(MojudMullo as Decimal(10,0)) as [gRy` DcKi‡Yi ‡Ri  g~j¨],BillNo as[wej bv¤^vi],BillTarik as[µ‡qi ZvwiL],Num as[we‡µZi bvg],BAddress as[we‡µZi wVKvbv],NID as[Gb AvB wW bs],Biboron as[µqK…Z DKi‡Yi weweiY],Amount as[µqK…Z DKi‡Yi  cwigvY],cast(KorBetitoMullo as decimal(10,0)) as [µqK…Z DKi‡Yi g~j¨],Cast(SmpSulko as decimal(10,0)) as [m¤ú~iKk~é],Cast(Musok as decimal(10,0)) as[g~mK],EkakAmt1 as[‡gvU DcKi‡Yi cwigvY],Cast(MulloAllKorbetito1 as decimal(10,0))as [‡gvU DcKi‡Yi g~j¨],EkakAmt2 as[cY¨ cÖ¯‘‡Zi cwigvY ],Cast(MulloAllKorbetito2 as decimal(10,0))as [cY¨ cÖ¯‘‡Zi g~j¨],UpoEkakAmt as [cÖvwšÍK ‡R‡ii  cwigvY ],Cast(UpoMulloAllKorbetito as decimal(10,0)) as [cÖvwšÍK ‡R‡ii g~j¨],Rmk as[gšÍe¨] from M6_1 /*where KromicNo='" + txtKromicNo.Text.Trim() + "'*/");
            FilterGrid.Refresh();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
        
            {

                if (txtKromicNo.Text.Trim() == "")
                {
                    MessageBox.Show("Kromic NO Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtBkrName.Select();
                    return;
                }

                if (txtBkrName.Text.Trim() == "")
                {
                    MessageBox.Show("Supplier Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtBkrName.Select();
                    return;
                }

                //MojudPoriman,EkakAmt1,EkakAmt2,UpoEkakAmt,Amount
                string SaveQry;
                string SelectQry;
                string EdtQry;

                SaveQry = "Insert into M6_1(KromicNo,Tarik,MojudPoriman,MojudMullo,BillNo,BillTarik,Num,BAddress,NID,Biboron,Amount,KorBetitoMullo,SmpSulko,Musok,EkakAmt1,MulloAllKorbetito1,EkakAmt2,MulloAllKorbetito2,UpoEkakAmt,UpoMulloAllKorbetito,Rmk)values('" + txtKromicNo.Text.Trim() + "',convert(datetime,'" + dtpTarik1.Text.Trim() + "',103),'" + txtMojudAmt.Text.Trim() + "'," + txtMojudMullo.Text.Trim() + ",'" + txtBilNo.Text.Trim() + "',convert(datetime,'" + DtTarik2.Text.Trim() + "',103),'" + txtBkrName.Text.Trim() + "','" + txtAddress.Text.Trim() + "','" + txtNID.Text.Trim() +"','" + txtUpDetails.Text.Trim() + "','" + txtKrtpAmt.Text.Trim() + "'," + txtKrtpMullo.Text.Trim() + "," + txtSmSulko.Text.Trim() + "," + txtMusok.Text.Trim() + ",'" + txtTotUpAmt.Text.Trim() + "'," + txtTotupMullo.Text.Trim() + ",'" + txtPnpsAmt.Text.Trim() + "'," + txtPnpsMullo.Text.Trim() + ",'" + txtPntJAmt.Text.Trim() + "'," + txtPtjMullo.Text.Trim() + ",'" + txtRmk.Text.Trim() + "')";
                SelectQry = "select Tarik,MojudPoriman,MojudMullo,BillNo,BillTarik,Num,BAddress,NID,Biboron,Amount,KorBetitoMullo,SmpSulko,Musok,EkakAmt1,MulloAllKorbetito1,EkakAmt2,MulloAllKorbetito2,UpoEkakAmt,UpoMulloAllKorbetito,Rmk from M6_1 where KromicNo='" + txtKromicNo.Text.Trim() + "'";              
                EdtQry = "Update M6_1 set Tarik=convert(datetime,'" + dtpTarik1.Text.Trim() + "',103),MojudPoriman='" + txtMojudAmt.Text.Trim() + "',MojudMullo= " + txtMojudMullo.Text.Trim() + ",BillNo='" + txtBilNo.Text.Trim() + "',Num='" + txtBkrName.Text.Trim() + "',BAddress='" + txtAddress.Text.Trim() + "',NID='" + txtNID.Text.Trim() + "',Biboron='" + txtUpDetails.Text.Trim() + "',Amount='" + txtKrtpAmt.Text.Trim() + "',KorBetitoMullo=" + txtKrtpMullo.Text.Trim() + ",SmpSulko=" + txtSmSulko.Text.Trim() + ",Musok=" + txtMusok.Text.Trim() + ",EkakAmt1='" + txtTotUpAmt.Text.Trim() + "',MulloAllKorbetito1=" + txtTotupMullo.Text.Trim() + ",EkakAmt2='" + txtPnpsAmt.Text.Trim() +"',MulloAllKorbetito2=" + txtPnpsMullo.Text.Trim() + ",UpoEkakAmt='" + txtPntJAmt.Text.Trim() +"',UpoMulloAllKorbetito=" + txtPtjMullo.Text.Trim() + ",Rmk='" + txtRmk.Text.Trim() + "' where KromicNo='" + txtKromicNo.Text.Trim() + "'";

                if (SvCls.DataExist(SelectQry).ToString() == "0")
                {


                    //cmdSave_Click(null, null);

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

        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select isnull(Max(KromicNo)+1,1) As Max from M6_1");

            if (SvCls.GblRdrToGetData.Read())
            {
                txtKromicNo.Text = SvCls.GblRdrToGetData["Max"].ToString();
                SvCls.GblCon.Close();
            }
            cmdSave.Text = "Save";

            dtpTarik1.Focus();

            txtMojudAmt.Text = "";
            dtpTarik1.Text = "";
            DtTarik2.Text = "";
            txtKrtpAmt.Text = "";
            txtTotUpAmt.Text = "";
            txtPnpsAmt.Text = "";
            txtPntJAmt.Text = "";
            txtMojudMullo.Text = "0";
            txtTotupMullo.Text = "0";
            txtPnpsMullo.Text = "0";
            txtPtjMullo.Text = "0";
            txtKrtpMullo.Text = "0";

            txtBilNo.Text = "0";
            txtBkrName.Text = "";
            txtAddress.Text = "";
            txtRmk.Text = "";
            txtUpDetails.Text = "";
            txtNID.Text = "0";
            txtMusok.Text = "0";
            txtSmSulko.Text = "0";

            Grid_Head();   

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtKromicNo.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Kromic NO...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKromicNo.Select();
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               // cmdDelete_Click(null, null);

                SvCls.insertUpdate("Delete from M6_1 where KromicNo = '" + txtKromicNo.Text.Trim() + "'");
                lblMgs.ForeColor = System.Drawing.Color.Red;
                lblMgs.Visible = true;
                lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Grid_Head();

                CmdAdd.Focus();

            }
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

        private void txtKromicNo_Leave(object sender, EventArgs e)
        {
            if (txtKromicNo.Text.Trim() != "")
            {
               
                string SelectQry = "select Tarik,MojudPoriman ,cast(MojudMullo as decimal(10,0)) as MojudMullo,BillNo,BillTarik,Num,BAddress,NID,Biboron,Amount, cast(KorBetitoMullo as decimal(10,0)) as KorBetitoMullo,Cast(SmpSulko as decimal(10,0)) as SmpSulko,Cast(Musok as decimal(10,0))as Musok,EkakAmt1,Cast(MulloAllKorbetito1 as decimal(10,0))as MulloAllKorbetito1,EkakAmt2,Cast(MulloAllKorbetito2 as decimal(10,0))as MulloAllKorbetito2,UpoEkakAmt,Cast(UpoMulloAllKorbetito as decimal(10,0)) as UpoMulloAllKorbetito,Rmk from M6_1 where KromicNo='" + txtKromicNo.Text.ToLower() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    dtpTarik1.Text = SvCls.GblRdrToGetData["Tarik"].ToString();
                    txtMojudAmt.Text = SvCls.GblRdrToGetData["MojudPoriman"].ToString();
                    txtMojudMullo.Text = SvCls.GblRdrToGetData["MojudMullo"].ToString();
                    txtBilNo.Text = SvCls.GblRdrToGetData["BillNo"].ToString();
                    DtTarik2.Text = SvCls.GblRdrToGetData["BillTarik"].ToString();
                    txtBkrName.Text = SvCls.GblRdrToGetData["Num"].ToString();
                    txtAddress.Text = SvCls.GblRdrToGetData["BAddress"].ToString();

                    txtNID.Text = SvCls.GblRdrToGetData["NID"].ToString();
                    txtUpDetails.Text = SvCls.GblRdrToGetData["Biboron"].ToString();
                    txtKrtpAmt.Text = SvCls.GblRdrToGetData["Amount"].ToString();
                    txtKrtpMullo.Text = SvCls.GblRdrToGetData["KorBetitoMullo"].ToString();
                    txtSmSulko.Text = SvCls.GblRdrToGetData["SmpSulko"].ToString();
                    txtMusok.Text = SvCls.GblRdrToGetData["Musok"].ToString();

                    txtTotUpAmt.Text = SvCls.GblRdrToGetData["EkakAmt1"].ToString();
                    txtTotupMullo.Text = SvCls.GblRdrToGetData["MulloAllKorbetito1"].ToString();
                    txtPnpsAmt.Text = SvCls.GblRdrToGetData["EkakAmt2"].ToString();
                    txtPnpsMullo.Text = SvCls.GblRdrToGetData["MulloAllKorbetito2"].ToString();
                    txtPntJAmt.Text = SvCls.GblRdrToGetData["UpoEkakAmt"].ToString();
                    txtPtjMullo.Text = SvCls.GblRdrToGetData["UpoMulloAllKorbetito"].ToString();
                    txtRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();

                    cmdSave.Text = "Edit";

                    Grid_Head();
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
  
            if (txtKromicNo.Text != "")
            {
                ClsVar.GblSelFor = "{M6_1.KromicNo}='" + txtKromicNo.Text.Trim() + "'";
            }

            ClsVar.GblRptName = "M6_1.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void txtAmt1_TextChanged(object sender, EventArgs e)
        {
            if(txtMojudAmt.Text == "")
            {
                txtMojudAmt.Text = "0";
                
            }
            else
            {
                Amt1 = Convert.ToDouble(txtMojudAmt.Text.Trim());
            }
            if (txtKrtpAmt.Text == "")
            {
                txtKrtpAmt.Text = "0";
            }
            else
            {

                Amt2 = Convert.ToDouble(txtKrtpAmt.Text.Trim());
            }

            Amt3 = Amt1 + Amt2;
            txtTotUpAmt.Text = Convert.ToString(Amt3);

        }       
        private void txtAmt2_TextChanged(object sender, EventArgs e)
        {

            if (txtKrtpAmt.Text == "")
            {
                txtKrtpAmt.Text = "0";
            }
            else
            {
                Amt2 = Convert.ToDouble(txtKrtpAmt.Text.Trim());
            }
            if (txtMojudAmt.Text == "")
            {
                txtMojudAmt.Text = "0";
            }
            else
            {

                Amt1 = Convert.ToDouble(txtMojudAmt.Text.Trim());
            }

            Amt3 = Amt1 + Amt2;
            txtTotUpAmt.Text = Convert.ToString(Amt3);
        }

        private void txtMullo1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtAmt3_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void dtpTarik1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                txtMojudAmt.Select();
            }
        }

        private void txtAmt1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "\r")
            {
                txtMojudMullo.Select();
            }
        }

        private void txtMullo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBilNo.Select();
            }
        }

        private void txtBilNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                DtTarik2.Select();
            }
        }

        private void DtTarik2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBkrName.Select();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtAddress.Select();
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtNID.Select();
            }
        }

        private void txtNID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtUpDetails.Select();
            }
        }

        private void txtDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKrtpAmt.Select();
            }
        }

        private void txtAmt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKrtpMullo.Select();
            }
        }

        private void txtMulloEkak2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtSmSulko.Select();
            }
        }

        private void txtSulko_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMusok.Select();
            }
        }

        private void txtMusok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
              txtTotUpAmt.Select();
            }
        }

        private void txtAmt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtTotupMullo.Select();
            }
        }

        private void txtMullo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
               txtPnpsAmt.Select();
            }
        }

        private void txtAmt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPnpsMullo.Select();
            }
        }

        private void txtMullo4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
              txtPntJAmt.Select();
            }
        }

        private void txtAmt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
             txtPtjMullo.Select();
            }
        }

        private void txtMullo5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMojudMullo_TextChanged(object sender, EventArgs e)
        {
            if (txtMojudMullo.Text == "")
            {
                txtMojudMullo.Text = "0";
            }
            else
            {
                Ml1 = Convert.ToDouble(txtMojudMullo.Text.Trim());
            }
            if (txtKrtpMullo.Text == "")
            {
                txtKrtpMullo.Text = "0";
            }
            else
            {
                Ml2 = Convert.ToDouble(txtKrtpMullo.Text.Trim());
            }

            Ml3 = Ml1 + Ml2;
            txtTotupMullo.Text = Convert.ToString(Ml3);      
        }

        private void txtKrtpMullo_TextChanged(object sender, EventArgs e)
        {
            if (txtMojudMullo.Text == "")
            {
                txtMojudMullo.Text = "0";
            }
            else
            {
                Ml1 = Convert.ToDouble(txtMojudMullo.Text.Trim());
            }
            if (txtKrtpMullo.Text == "")
            {
                txtKrtpMullo.Text = "0";
            }
            else
            {
                Ml2 = Convert.ToDouble(txtKrtpMullo.Text.Trim());
            }

            Ml3 = Ml1 + Ml2;
            txtTotupMullo.Text = Convert.ToString(Ml3);
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {         
            pnlGrid.Show();
            Grid_Filter();

        }

        private void FilterGrid_DoubleClick(object sender, EventArgs e)
        {
            Grid_DoubleClick(null,null);
            pnlGrid.Visible = false;
        }

        private void btnSearchFilter_Click(object sender, EventArgs e)
        {
            FilterGrid.DataSource = SvCls.GblDataTable("select KromicNo as [µwgK bs],Tarik as[ZvwiL],MojudPoriman as [gRy` DcKi‡Yi ‡Ri cwigvb],cast(MojudMullo as Decimal(10,0)) as [gRy` DcKi‡Yi ‡Ri  g~j¨],BillNo as[wej bv¤^vi],BillTarik as[µ‡qi ZvwiL],Num as[we‡µZi bvg],BAddress as[we‡µZi wVKvbv],NID as[Gb AvB wW bs],Biboron as[µqK…Z DKi‡Yi weweiY],Amount as[µqK…Z DKi‡Yi  cwigvY],cast(KorBetitoMullo as decimal(10,0)) as [µqK…Z DKi‡Yi g~j¨],Cast(SmpSulko as decimal(10,0)) as [m¤ú~iKk~é],Cast(Musok as decimal(10,0)) as[g~mK],EkakAmt1 as[‡gvU DcKi‡Yi cwigvY],Cast(MulloAllKorbetito1 as decimal(10,0))as [‡gvU DcKi‡Yi g~j¨],EkakAmt2 as[cY¨ cÖ¯‘‡Zi cwigvY ],Cast(MulloAllKorbetito2 as decimal(10,0))as [cY¨ cÖ¯‘‡Zi g~j¨],UpoEkakAmt as [cÖvwšÍK ‡R‡ii  cwigvY ],Cast(UpoMulloAllKorbetito as decimal(10,0)) as [cÖvwšÍK ‡R‡ii g~j¨],Rmk as[gšÍe¨] from M6_1 where Tarik between CONVERT(datetime,'" + dtStartDate.Text.Trim() + "',103) and  CONVERT(datetime,'" + dtEndDate.Text.Trim() + "',103)");
            FilterGrid.Refresh();
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i;
            i = Grid.SelectedCells[0].RowIndex;
            txtKromicNo.Text = Grid.Rows[i].Cells[0].Value.ToString();
            dtpTarik1.Text = Grid.Rows[i].Cells[1].Value.ToString();
            txtMojudAmt.Text = Grid.Rows[i].Cells[2].Value.ToString();

            txtMojudMullo.Text = Grid.Rows[i].Cells[3].Value.ToString();
            txtBilNo.Text = Grid.Rows[i].Cells[4].Value.ToString();
            DtTarik2.Text = Grid.Rows[i].Cells[5].Value.ToString();
            txtBkrName.Text = Grid.Rows[i].Cells[6].Value.ToString();
            txtAddress.Text = Grid.Rows[i].Cells[7].Value.ToString();
            txtNID.Text = Grid.Rows[i].Cells[8].Value.ToString();
            txtUpDetails.Text = Grid.Rows[i].Cells[9].Value.ToString();
            txtKrtpAmt.Text = Grid.Rows[i].Cells[10].Value.ToString();

            txtKrtpMullo.Text = Grid.Rows[i].Cells[11].Value.ToString();
            txtSmSulko.Text = Grid.Rows[i].Cells[12].Value.ToString();
            txtMusok.Text = Grid.Rows[i].Cells[13].Value.ToString();
            txtTotUpAmt.Text = Grid.Rows[i].Cells[14].Value.ToString();

            txtTotupMullo.Text = Grid.Rows[i].Cells[15].Value.ToString();
            txtPnpsAmt.Text = Grid.Rows[i].Cells[16].Value.ToString();
            txtPnpsMullo.Text = Grid.Rows[i].Cells[17].Value.ToString();
            txtPntJAmt.Text = Grid.Rows[i].Cells[18].Value.ToString();
            txtPtjMullo.Text = Grid.Rows[i].Cells[19].Value.ToString();
            txtRmk.Text = Grid.Rows[i].Cells[20].Value.ToString();
        }
    }
    }

