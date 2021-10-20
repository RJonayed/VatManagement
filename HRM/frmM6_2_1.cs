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
    
    public partial class frmM6_2_1 : Form
    {
        double motPonnoPoriman;
        double motPonnoMullo;
        double ponnerPantikPoriman;
        double ponnerPantikMullo;
        ClsMain svCls = new ClsMain();
        //AutoCompleteStringCollection cols = new AutoCompleteStringCollection();
        public frmM6_2_1()
        {
            InitializeComponent();
        }

        private void frmM6_2_1_Load(object sender, EventArgs e)
        {

            btnAdd.Select();
            // Grid_Head();
            Grid.Visible = false;
            pnlGrid.Visible = false;
            picSave.Visible = false;

            pnlGrid.Width = 899;
            pnlGrid.Height = 548;
            pnlGrid.Left = 0;
            pnlGrid.Top = 41;
            btnSave.Text = "Save";
            //btnSave.Font = new Font("Tahoma", 12, FontStyle.Bold, GraphicsUnit.Point);
            Grid.RowHeadersDefaultCellStyle.Font = new Font("TangonMJ", 12F,GraphicsUnit.Pixel);

        }


        
        private void btnSave_Click(object sender, EventArgs e)
        {
           

            if (txtCromicNo.Text.Trim() == "")
            {
                MessageBox.Show("Cromic No  Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCromicNo.Select();
                return;
            }
            numberDefault();

           


            //if (txtBikretarNam.Text.Trim() == "")
            //{
            //    MessageBox.Show("Bikretar Nam Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    txtBikretarNam.Select();
            //    return;
            //}

            //if (txtKretarNam.Text.Trim() == "")
            //{
            //    MessageBox.Show("Kretar Nam Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    txtKretarNam.Select();
            //    return;
            //}


            string InsertQry;
            string checkqry;
            string EdtQry;


            InsertQry = "INSERT INTO M6_2_1(CromicNo,Tarik,BikroyJoggoPoriman,BikroyJoggoMullo,KroyPoriman,KroyMullo,MotPonnoPoriman,MotPonnoMullo,BikretarNam,BikretarThikana,BikretarPorichoiProtroNo," +
                "KroyChalanProtrerNo,KroyChalanProtrerTarik ,BikritoPonnerBiboron,BikritoPonnerPoriman,BikritoPonnerKorJoggoMullo,BikritoPonnerSolko,BikritoPonnerMusok,KretarNam,KretarThikana,KretarPorichoiProtroNo," +
                "BikroyChalanProtrerNo,BikroyChalanProtrerTarik,PonnerPantikPoriman,PonnerPantikMullo,Monttobo)" +
                " VALUES(" + txtCromicNo.Text.Trim() + ",CONVERT(datetime,'" + dtTarik.Text.Trim() + "',103)," + txtBikroyJoggoPoriman.Text.Trim() + "," + txtBikroyJoggoMullo.Text.Trim() + "," + txtKroyPoriman.Text.Trim() + "," + txtKroyMullo.Text.Trim() + "," +
                "" + txtMotPonnoPoriman.Text.Trim() + "," + txtMotPonnoMullo.Text.Trim() + ",'" + txtBikretarNam.Text.Trim() + "','" + txtBikretarThikana.Text.Trim() + "','" + txtBikretarPorichoiProtroNo.Text.Trim() + "','" + txtKroyChalanProtrerNo.Text.Trim() + "'," +
                "CONVERT(datetime,'" + dtKroyChalanProtrerTarik.Text.Trim() + "',103),'" + txtBikritoPonnerBiboron.Text.Trim() + "'," + txtBikritoPonnerPoriman.Text.Trim() + "," + txtBikritoPonnerKorJoggoMullo.Text.Trim() + "," + txtBikritoPonnerSolko.Text.Trim() + "," +
                "" + txtBikritoPonnerMusok.Text.Trim() + ",'" + txtKretarNam.Text.Trim() + "','" + txtKretarThikana.Text.Trim() + "','" + txtKretarPorichoiProtroNo.Text.Trim() + "','" + txtBikroyChalanProtrerNo.Text.Trim() + "',CONVERT(datetime,'" + dtBikroyChalanProtrerTarik.Text.Trim() + "',103)," +
                "" + txtPonnerPantikPoriman.Text.Trim() + "," + txtPonnerPantikMullo.Text.Trim() + ",'" + txtMonttobo.Text.Trim() + "')";



            checkqry = "select  convert(varchar, Tarik, 106) as Tarik, cast(BikroyJoggoPoriman as decimal(10,2)) as BikroyJoggoPoriman,cast(BikroyJoggoMullo as decimal(10,2)) as BikroyJoggoMullo," +
               "cast(KroyPoriman as decimal(10,2)) as KroyPoriman, cast(KroyMullo as decimal(10,2)) as KroyMullo, cast(MotPonnoPoriman as decimal(10,2)) as MotPonnoPoriman, cast(MotPonnoMullo as decimal(10,2)) as MotPonnoMullo," +
               "BikretarNam, BikretarThikana,BikretarPorichoiProtroNo, KroyChalanProtrerNo, convert(varchar, KroyChalanProtrerTarik, 106) as KroyChalanProtrerTarik, " +
               "BikritoPonnerBiboron, cast(BikritoPonnerPoriman as decimal(10,2)) as BikritoPonnerPoriman, cast(BikritoPonnerKorJoggoMullo as decimal(10,2)) as BikritoPonnerKorJoggoMullo, cast(BikritoPonnerSolko as decimal(10,2)) as BikritoPonnerSolko, " +
               "cast(BikritoPonnerMusok as decimal(10,2)) as BikritoPonnerMusok, KretarNam, KretarThikana, KretarPorichoiProtroNo," +
                "BikroyChalanProtrerNo, convert(varchar, BikroyChalanProtrerTarik, 106) as BikroyChalanProtrerTarik, cast(PonnerPantikPoriman as decimal(10,2)) as PonnerPantikPoriman, " +
                "cast(PonnerPantikMullo as decimal(10,2)) as PonnerPantikMullo, Monttobo from M6_2_1  " +
                "where CromicNo = " + txtCromicNo.Text.Trim() + "";


            EdtQry = "update M6_2_1 set " +
                   "tarik = convert(datetime, '" + dtTarik.Text.Trim() + "', 103)," +
                   "BikroyJoggoPoriman = " + txtBikroyJoggoPoriman.Text.Trim() + "," +
                   "BikroyJoggoMullo = " + txtBikroyJoggoMullo.Text.Trim() + "," +
                   "KroyPoriman = " + txtKroyPoriman.Text.Trim() + "," +
                   "KroyMullo = " + txtKroyMullo.Text.Trim() + "," +
                   "MotPonnoPoriman = " + txtMotPonnoPoriman.Text.Trim() + "," +
                   "MotPonnoMullo = " + txtMotPonnoMullo.Text.Trim() + "," +
                   "BikretarNam = '" + txtBikretarNam.Text.Trim() + "'," +
                   "BikretarThikana = '" + txtBikretarThikana.Text.Trim() + "'," +
                   "BikretarPorichoiProtroNo = '" + txtBikretarPorichoiProtroNo.Text.Trim() + "'" + "," +
                   "KroyChalanProtrerNo = '" + txtKroyChalanProtrerNo.Text.Trim() + "'," +
                   "KroyChalanProtrerTarik = convert(datetime, '" + dtKroyChalanProtrerTarik.Text.Trim() + "', 103)," +
                   "BikritoPonnerBiboron = '" + txtBikritoPonnerBiboron.Text.Trim() + "'," +
                   "BikritoPonnerPoriman = " + txtBikritoPonnerPoriman.Text.Trim() + "," +
                   "BikritoPonnerKorJoggoMullo = " + txtBikritoPonnerKorJoggoMullo.Text.Trim() + "," +
                   "BikritoPonnerSolko = " + txtBikritoPonnerSolko.Text.Trim() + "," +
                   "BikritoPonnerMusok = " + txtBikritoPonnerMusok.Text.Trim() + "," +
                   "KretarNam = '" + txtKretarNam.Text.Trim() + "'," +
                   "KretarThikana = '" + txtKretarThikana.Text.Trim() + "'," +
                   "KretarPorichoiProtroNo = '" + txtKretarPorichoiProtroNo.Text.Trim() + "'," +
                   "BikroyChalanProtrerNo = '" + txtBikroyChalanProtrerNo.Text.Trim() + "'," +
                   "BikroyChalanProtrerTarik = convert(datetime, '" + dtBikroyChalanProtrerTarik.Text.Trim() + "', 103)," +
                   "PonnerPantikPoriman = " + txtPonnerPantikPoriman.Text.Trim() + "," +
                   "PonnerPantikMullo = " + txtPonnerPantikMullo.Text.Trim() + "," +
                   "Monttobo = '" + txtMonttobo.Text.Trim() + "'" +
                   "where CromicNo = " + txtCromicNo.Text.Trim() + "";

            if (svCls.DataExist(checkqry).ToString() == "0")
            {
                svCls.insertUpdate(InsertQry);
                lblMsg.ForeColor = System.Drawing.Color.Blue;
                lblMsg.Visible = true;
                lblMsg.Text = "SAVED SUCCESSFULLY...!!";
                picSave.Visible = true;
               // Grid_Head();

                btnAdd.Focus();
            }

            else

            {
               
               
                svCls.insertUpdate(EdtQry);


                lblMsg.ForeColor = System.Drawing.Color.Blue;
                lblMsg.Visible = true;
                lblMsg.Text = "EDIT SUCCESSFULLY...!!";
                picSave.Visible = true;

                btnAdd.Focus();
                

                //Grid_Head();
            }
 
        }

 

        private void Grid_Head()
        {

          string gridQry = "select CromicNo,convert(varchar, Tarik, 103) as [Tarik], cast(BikroyJoggoPoriman as decimal(10,2)) as [BikroyJoggoPoriman],cast(BikroyJoggoMullo as decimal(10,2)) as BikroyJoggoMullo," +
               "cast(KroyPoriman as decimal(10,2)) as KroyPoriman, cast(KroyMullo as decimal(10,2)) as KroyMullo, cast(MotPonnoPoriman as decimal(10,2)) as MotPonnoPoriman, cast(MotPonnoMullo as decimal(10,2)) as MotPonnoMullo," +
               "BikretarNam, BikretarThikana,BikretarPorichoiProtroNo, KroyChalanProtrerNo, convert(varchar, KroyChalanProtrerTarik, 103) as KroyChalanProtrerTarik, " +
               "BikritoPonnerBiboron, cast(BikritoPonnerPoriman as decimal(10,2)) as BikritoPonnerPoriman, cast(BikritoPonnerKorJoggoMullo as decimal(10,2)) as BikritoPonnerKorJoggoMullo, cast(BikritoPonnerSolko as decimal(10,2)) as BikritoPonnerSolko, " +
               "cast(BikritoPonnerMusok as decimal(10,2)) as BikritoPonnerMusok, KretarNam, KretarThikana, KretarPorichoiProtroNo," +
                "BikroyChalanProtrerNo, convert(varchar, BikroyChalanProtrerTarik, 103) as BikroyChalanProtrerTarik, cast(PonnerPantikPoriman as decimal(10,2)) as PonnerPantikPoriman, " +
                "cast(PonnerPantikMullo as decimal(10,2)) as PonnerPantikMullo, Monttobo from M6_2_1";
            Grid.DataSource = svCls.GblDataTable(gridQry);

            for(int i = 0;i<Grid.Columns.Count;i++)
            {
                string qry = "select ban from Heading where eng = '"+ Grid.Columns[i].HeaderCell.Value.ToString() + "'";
                svCls.toGetData(qry);
                if (svCls.GblRdrToGetData.Read())
                {
                    Grid.Columns[i].HeaderCell.Value = svCls.GblRdrToGetData["ban"].ToString();
                }
            }
           
            Grid.Refresh();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
 
                svCls.toGetData("select isnull(max(CromicNo)+1,1) as Max from M6_2_1");

                if (svCls.GblRdrToGetData.Read())
                {
                    txtCromicNo.Text = svCls.GblRdrToGetData["Max"].ToString();
                    svCls.GblCon.Close();
                }

                txtCromicNo.Focus();
                btnSave.Text = "Save";
                dtTarik.Text = DateTime.Today.ToString();
                txtBikroyJoggoPoriman.Text = "";
                txtBikroyJoggoMullo.Text = "";
                txtKroyPoriman.Text = "";
                txtKroyMullo.Text = "";
                txtMotPonnoPoriman.Text = "";
                txtMotPonnoMullo.Text = "";
                txtBikretarNam.Text = "";
                txtBikretarThikana.Text = "";
                txtBikretarPorichoiProtroNo.Text = "";
                txtKroyChalanProtrerNo.Text = "";
                 dtKroyChalanProtrerTarik.Text = DateTime.Today.ToString();
                txtBikritoPonnerBiboron.Text = "";
                txtBikritoPonnerPoriman.Text = "";
                txtBikritoPonnerKorJoggoMullo.Text = "";
                txtBikritoPonnerSolko.Text = "";
                txtBikritoPonnerMusok.Text = "";
                txtKretarNam.Text = "";
                txtKretarThikana.Text = "";
                txtKretarPorichoiProtroNo.Text = "";
                txtBikroyChalanProtrerNo.Text = "";
                dtBikroyChalanProtrerTarik.Text = DateTime.Today.ToString();
                txtPonnerPantikPoriman.Text = "";
                txtPonnerPantikMullo.Text = "";
                txtMonttobo.Text = "";

              

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if(pnlGrid.Visible == true)
            {
                pnlGrid.Visible = false;
            }
            else
            {
                this.Close();
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            
            if (txtCromicNo.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Cromic NO...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCromicNo.Select();
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string checkDelQry = "select  convert(varchar, Tarik, 106) as Tarik, cast(BikroyJoggoPoriman as decimal(10,2)) as BikroyJoggoPoriman,cast(BikroyJoggoMullo as decimal(10,2)) as BikroyJoggoMullo," +
               "cast(KroyPoriman as decimal(10,2)) as KroyPoriman, cast(KroyMullo as decimal(10,2)) as KroyMullo, cast(MotPonnoPoriman as decimal(10,2)) as MotPonnoPoriman, cast(MotPonnoMullo as decimal(10,2)) as MotPonnoMullo," +
               "BikretarNam, BikretarThikana,BikretarPorichoiProtroNo, KroyChalanProtrerNo, convert(varchar, KroyChalanProtrerTarik, 106) as KroyChalanProtrerTarik, " +
               "BikritoPonnerBiboron, cast(BikritoPonnerPoriman as decimal(10,2)) as BikritoPonnerPoriman, cast(BikritoPonnerKorJoggoMullo as decimal(10,2)) as BikritoPonnerKorJoggoMullo, cast(BikritoPonnerSolko as decimal(10,2)) as BikritoPonnerSolko, " +
               "cast(BikritoPonnerMusok as decimal(10,2)) as BikritoPonnerMusok, KretarNam, KretarThikana, KretarPorichoiProtroNo," +
                "BikroyChalanProtrerNo, convert(varchar, BikroyChalanProtrerTarik, 106) as BikroyChalanProtrerTarik, cast(PonnerPantikPoriman as decimal(10,2)) as PonnerPantikPoriman, " +
                "cast(PonnerPantikMullo as decimal(10,2)) as PonnerPantikMullo, Monttobo from M6_2_1 " +
                "where CromicNo = " + txtCromicNo.Text.Trim() + "";
                svCls.toGetData(checkDelQry);

                if (svCls.GblRdrToGetData.Read())
                {
                    string delQry = "Delete from M6_2_1 where CromicNo='" + txtCromicNo.Text.Trim() + "'";
                    svCls.insertUpdate(delQry);
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Visible = true;
                    lblMsg.Text = "DELETE SUCCESSFULLY...!!";
                    picSave.Visible = true;
                }

                else
                {
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Visible = true;
                    lblMsg.Text = "NOT EXISTS CROMIC NO!!";
                    
                }




               

               // Grid_Head();

                btnAdd.Focus();   

            }
        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            picSave.Visible = false;
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            pnlGrid.Visible = true;
            Grid.Visible = true;
            Grid_Head();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Grid.Visible = false;
            pnlGrid.Visible = false;
           
        }


        private void numberDefault()
        {
            if (txtBikroyJoggoPoriman.Text == "")
            {
                txtBikroyJoggoPoriman.Text = "0";
            }

            if (txtBikroyJoggoMullo.Text == "")
            {
                txtBikroyJoggoMullo.Text = "0";
            }

            if (txtKroyPoriman.Text == "")
            {
                txtKroyPoriman.Text = "0";
            }

            if (txtKroyMullo.Text == "")
            {
                txtKroyMullo.Text = "0";
            }

            if (txtMotPonnoPoriman.Text == "")
            {
                txtMotPonnoPoriman.Text = "0";
            }

            if (txtMotPonnoMullo.Text == "")
            {
                txtMotPonnoMullo.Text = "0";
            }


            if (txtBikritoPonnerPoriman.Text == "")
            {
                txtBikritoPonnerPoriman.Text = "0";
            }

            if (txtBikritoPonnerKorJoggoMullo.Text == "")
            {
                txtBikritoPonnerKorJoggoMullo.Text = "0";
            }


            if (txtBikritoPonnerSolko.Text == "")
            {
                txtBikritoPonnerSolko.Text = "0";
            }

            if (txtBikritoPonnerMusok.Text == "")
            {
                txtBikritoPonnerMusok.Text = "0";
            }

            if (txtPonnerPantikPoriman.Text == "")
            {
                txtPonnerPantikPoriman.Text = "0";
            }

            if (txtPonnerPantikMullo.Text == "")
            {
                txtPonnerPantikMullo.Text = "0";
            }

            txtBikritoPonnerPoriman_KeyUp(null, null);
            txtBikritoPonnerKorJoggoMullo_KeyUp(null,null);

        }

  

   

  

       

        private void btnReport_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptHead = "";
            ClsVar.GblRptName = "M6_2_1.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }


        private void txtBikroyJoggoPoriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            


            if (e.KeyChar.ToString() == "\r")
            {
                txtBikroyJoggoMullo.Select();
            }
        }

        private void txtKroyPoriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKroyMullo.Select();
            }
        }

       

        private void btnAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtCromicNo.Select();
            }
        }

        private void txtCromicNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtTarik.Select();
            }
        }

        private void txtBikroyJoggoMullo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKroyPoriman.Select();
            }
        }

        private void dtTarik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                txtBikroyJoggoPoriman.Select();
            }
        }

        private void txtKroyMullo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMotPonnoPoriman.Select();
            }
        }

        private void txtMotPonnoPoriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMotPonnoMullo.Select();
            }
        }

        private void txtMotPonnoMullo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBikretarNam.Select();
            }
        }

        private void txtBikretarNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBikretarThikana.Select();
            }
        }

        private void txtBikretarThikana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBikretarPorichoiProtroNo.Select();
            }
        }

        private void txtKroyChalanProtrerNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtKroyChalanProtrerTarik.Select();
            }
        }

        private void txtBikretarPorichoiProtroNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "\r")
            {
                txtKroyChalanProtrerNo.Select();
            }
        }

        private void dtKroyChalanProtrerTarik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBikritoPonnerBiboron.Select();
            }
        }

        private void txtBikritoPonnerBiboron_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBikritoPonnerPoriman.Select();
            }
        }

        private void txtBikritoPonnerPoriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBikritoPonnerKorJoggoMullo.Select();
            }

        }

        private void txtBikritoPonnerKorJoggoMullo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBikritoPonnerSolko.Select();
            }
        }

        private void txtBikritoPonnerMusok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKretarNam.Select();
            }
        }

        private void txtBikritoPonnerSolko_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBikritoPonnerMusok.Select();
            }
        }

        private void txtKretarNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKretarThikana.Select();
            }
        }

       

        private void txtKretarThikana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtKretarPorichoiProtroNo.Select();
            }
        }

        private void txtKretarPorichoiProtroNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtBikroyChalanProtrerNo.Select();
            }
        }

        private void txtBikroyChalanProtrerNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtBikroyChalanProtrerTarik.Select();
            }
        }

        private void dtBikroyChalanProtrerTarik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPonnerPantikPoriman.Select();
            }
        }

        private void txtPonnerPantikPoriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPonnerPantikMullo.Select();
            }
        }

        private void txtPonnerPantikMullo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMonttobo.Select();
            }
        }

        private void txtMonttobo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnSave.Select();
            }
        }

        private void btnSearchFilter_Click(object sender, EventArgs e)
        {
            string filterQry = "select CromicNo,convert(varchar, Tarik, 103) as [Tarik], cast(BikroyJoggoPoriman as decimal(10,2)) as [BikroyJoggoPoriman],cast(BikroyJoggoMullo as decimal(10,2)) as BikroyJoggoMullo," +
               "cast(KroyPoriman as decimal(10,2)) as KroyPoriman, cast(KroyMullo as decimal(10,2)) as KroyMullo, cast(MotPonnoPoriman as decimal(10,2)) as MotPonnoPoriman, cast(MotPonnoMullo as decimal(10,2)) as MotPonnoMullo," +
               "BikretarNam, BikretarThikana,BikretarPorichoiProtroNo, KroyChalanProtrerNo, convert(varchar, KroyChalanProtrerTarik, 103) as KroyChalanProtrerTarik, " +
               "BikritoPonnerBiboron, cast(BikritoPonnerPoriman as decimal(10,2)) as BikritoPonnerPoriman, cast(BikritoPonnerKorJoggoMullo as decimal(10,2)) as BikritoPonnerKorJoggoMullo, cast(BikritoPonnerSolko as decimal(10,2)) as BikritoPonnerSolko, " +
               "cast(BikritoPonnerMusok as decimal(10,2)) as BikritoPonnerMusok, KretarNam, KretarThikana, KretarPorichoiProtroNo," +
                "BikroyChalanProtrerNo, convert(varchar, BikroyChalanProtrerTarik, 103) as BikroyChalanProtrerTarik, cast(PonnerPantikPoriman as decimal(10,2)) as PonnerPantikPoriman, " +
                "cast(PonnerPantikMullo as decimal(10,2)) as PonnerPantikMullo, Monttobo from M6_2_1  where Tarik between CONVERT(datetime,'" + dtStartDate.Text.Trim() + "',103) and  CONVERT(datetime,'" + dtEndDate.Text.Trim() + "',103)";

            Grid.DataSource = svCls.GblDataTable(filterQry);

            for (int i = 0; i < Grid.Columns.Count; i++)
            {
                string qry = "select ban from Heading where eng = '" + Grid.Columns[i].HeaderCell.Value + "'";
                svCls.toGetData(qry);
                if (svCls.GblRdrToGetData.Read())
                {
                    Grid.Columns[i].HeaderCell.Value = svCls.GblRdrToGetData["ban"].ToString();
                }
            }

            Grid.RowHeadersDefaultCellStyle.Font = new Font("TangonMJ", 12F, GraphicsUnit.Pixel);
            Grid.Refresh();
        }

    

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                pnlGrid.Visible = false;
                Grid.Visible = false;
                int i;
                i = Grid.SelectedCells[0].RowIndex;
                txtCromicNo.Text = Grid.Rows[i].Cells[0].Value.ToString();
                txtCromicNo_Leave(null, null);
            }


        }

        private void txtBikroyJoggoPoriman_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBikroyJoggoPoriman.Text == "" && txtKroyPoriman.Text == "")
            {
                motPonnoPoriman = 0.0;
            }

            if (txtBikroyJoggoPoriman.Text != "" && txtKroyPoriman.Text == "")
            {
                motPonnoPoriman = Convert.ToDouble(txtBikroyJoggoPoriman.Text);
            }

            if (txtBikroyJoggoPoriman.Text != "" && txtKroyPoriman.Text != "")
            {
                motPonnoPoriman = Convert.ToDouble(txtBikroyJoggoPoriman.Text) + Convert.ToDouble(txtKroyPoriman.Text);
            }

            txtMotPonnoPoriman.Text = motPonnoPoriman.ToString();
        }

        private void txtKroyPoriman_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBikroyJoggoPoriman.Text == "" && txtKroyPoriman.Text == "")
            {
                motPonnoPoriman = 0.0D;
            }

            if (txtBikroyJoggoPoriman.Text == "" && txtKroyPoriman.Text != "")
            {
                motPonnoPoriman = Convert.ToDouble(txtKroyPoriman.Text);
            }

            if (txtBikroyJoggoPoriman.Text != "" && txtKroyPoriman.Text != "")
            {
                motPonnoPoriman = Convert.ToDouble(txtBikroyJoggoPoriman.Text) + Convert.ToDouble(txtKroyPoriman.Text);
            }

            txtMotPonnoPoriman.Text = motPonnoPoriman.ToString();
        }

        private void txtBikroyJoggoMullo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBikroyJoggoMullo.Text == "" && txtKroyMullo.Text == "")
            {
                motPonnoMullo = 0.0;
            }


            if (txtBikroyJoggoMullo.Text != "" && txtKroyMullo.Text == "")
            {
                motPonnoMullo = Convert.ToDouble(txtBikroyJoggoMullo.Text);
            }


            if (txtBikroyJoggoMullo.Text != "" && txtKroyMullo.Text != "")
            {
                motPonnoMullo = Convert.ToDouble(txtBikroyJoggoMullo.Text) + Convert.ToDouble(txtKroyMullo.Text);
            }

            txtMotPonnoMullo.Text = motPonnoMullo.ToString();
        }

        private void txtKroyMullo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBikroyJoggoMullo.Text == "" && txtKroyMullo.Text == "")
            {
                motPonnoMullo = 0.0;
            }


            if (txtBikroyJoggoMullo.Text == "" && txtKroyMullo.Text != "")
            {
                motPonnoMullo = Convert.ToDouble(txtKroyMullo.Text);
            }


            if (txtBikroyJoggoMullo.Text != "" && txtKroyMullo.Text != "")
            {
                motPonnoMullo = Convert.ToDouble(txtBikroyJoggoMullo.Text) + Convert.ToDouble(txtKroyMullo.Text);
            }

            txtMotPonnoMullo.Text = motPonnoMullo.ToString();
        }

        

        private void txtCromicNo_Leave(object sender, EventArgs e)
        {
            if (txtCromicNo.Text.Trim() != "")
            {
                string checkQry = "select  convert(varchar, Tarik, 106) as Tarik, cast(BikroyJoggoPoriman as decimal(10,2)) as BikroyJoggoPoriman,cast(BikroyJoggoMullo as decimal(10,2)) as BikroyJoggoMullo," +
               "cast(KroyPoriman as decimal(10,2)) as KroyPoriman, cast(KroyMullo as decimal(10,2)) as KroyMullo, cast(MotPonnoPoriman as decimal(10,2)) as MotPonnoPoriman, cast(MotPonnoMullo as decimal(10,2)) as MotPonnoMullo," +
               "BikretarNam, BikretarThikana,BikretarPorichoiProtroNo, KroyChalanProtrerNo, convert(varchar, KroyChalanProtrerTarik, 106) as KroyChalanProtrerTarik, " +
               "BikritoPonnerBiboron, cast(BikritoPonnerPoriman as decimal(10,2)) as BikritoPonnerPoriman, cast(BikritoPonnerKorJoggoMullo as decimal(10,2)) as BikritoPonnerKorJoggoMullo, cast(BikritoPonnerSolko as decimal(10,2)) as BikritoPonnerSolko, " +
               "cast(BikritoPonnerMusok as decimal(10,2)) as BikritoPonnerMusok, KretarNam, KretarThikana, KretarPorichoiProtroNo," +
                "BikroyChalanProtrerNo, convert(varchar, BikroyChalanProtrerTarik, 106) as BikroyChalanProtrerTarik, cast(PonnerPantikPoriman as decimal(10,2)) as PonnerPantikPoriman, " +
                "cast(PonnerPantikMullo as decimal(10,2)) as PonnerPantikMullo, Monttobo from M6_2_1 " +
                "where CromicNo = " + txtCromicNo.Text.Trim() + "";

                svCls.toGetData(checkQry);
                if (svCls.GblRdrToGetData.Read())
                {
                    dtTarik.Text = svCls.GblRdrToGetData["Tarik"].ToString();
                    txtBikroyJoggoPoriman.Text = svCls.GblRdrToGetData["BikroyJoggoPoriman"].ToString();
                    txtBikroyJoggoMullo.Text = svCls.GblRdrToGetData["BikroyJoggoMullo"].ToString();
                    txtKroyPoriman.Text = svCls.GblRdrToGetData["KroyPoriman"].ToString();
                    txtKroyMullo.Text = svCls.GblRdrToGetData["KroyMullo"].ToString();
                    txtMotPonnoPoriman.Text = svCls.GblRdrToGetData["MotPonnoPoriman"].ToString();
                    txtMotPonnoMullo.Text = svCls.GblRdrToGetData["MotPonnoMullo"].ToString();
                    txtBikretarNam.Text = svCls.GblRdrToGetData["BikretarNam"].ToString();
                    txtBikretarThikana.Text = svCls.GblRdrToGetData["BikretarThikana"].ToString();
                    txtBikretarPorichoiProtroNo.Text = svCls.GblRdrToGetData["BikretarPorichoiProtroNo"].ToString();
                    txtKroyChalanProtrerNo.Text = svCls.GblRdrToGetData["KroyChalanProtrerNo"].ToString();
                    dtKroyChalanProtrerTarik.Text = svCls.GblRdrToGetData["KroyChalanProtrerTarik"].ToString();
                    txtBikritoPonnerBiboron.Text = svCls.GblRdrToGetData["BikritoPonnerBiboron"].ToString();
                    txtBikritoPonnerPoriman.Text = svCls.GblRdrToGetData["BikritoPonnerPoriman"].ToString();
                    txtBikritoPonnerKorJoggoMullo.Text = svCls.GblRdrToGetData["BikritoPonnerKorJoggoMullo"].ToString();
                    txtBikritoPonnerSolko.Text = svCls.GblRdrToGetData["BikritoPonnerSolko"].ToString();
                    txtBikritoPonnerMusok.Text = svCls.GblRdrToGetData["BikritoPonnerMusok"].ToString();
                    txtKretarNam.Text = svCls.GblRdrToGetData["KretarNam"].ToString();
                    txtKretarThikana.Text = svCls.GblRdrToGetData["KretarThikana"].ToString();
                    txtKretarPorichoiProtroNo.Text = svCls.GblRdrToGetData["KretarPorichoiProtroNo"].ToString();
                    txtBikroyChalanProtrerNo.Text = svCls.GblRdrToGetData["BikroyChalanProtrerNo"].ToString();
                    dtBikroyChalanProtrerTarik.Text = svCls.GblRdrToGetData["BikroyChalanProtrerTarik"].ToString();
                    txtPonnerPantikPoriman.Text = svCls.GblRdrToGetData["PonnerPantikPoriman"].ToString();
                    txtPonnerPantikMullo.Text = svCls.GblRdrToGetData["PonnerPantikMullo"].ToString();
                    txtMonttobo.Text = svCls.GblRdrToGetData["Monttobo"].ToString();
                    btnSave.Text = "Edit";
                }

                else
                {
                    btnSave.Text = "Save";
                }
            }
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void picSave_Click(object sender, EventArgs e)
        {

        }

        private void txtBikritoPonnerPoriman_KeyUp(object sender, KeyEventArgs e)
        {

            if (txtMotPonnoPoriman.Text == "" && txtBikritoPonnerPoriman.Text == "")
            {
                ponnerPantikPoriman = 0.0;
            }


            if (txtMotPonnoPoriman.Text != "" && txtBikritoPonnerPoriman.Text == "")
            {
                ponnerPantikPoriman = Convert.ToDouble(txtMotPonnoPoriman.Text);
            }

            if (txtMotPonnoPoriman.Text == "" && txtBikritoPonnerPoriman.Text != "")
            {
                ponnerPantikPoriman = 0- Convert.ToDouble(txtBikritoPonnerPoriman.Text);
            }


            if (txtMotPonnoPoriman.Text != "" && txtBikritoPonnerPoriman.Text != "")
            {
                ponnerPantikPoriman = Convert.ToDouble(txtMotPonnoPoriman.Text) - Convert.ToDouble(txtBikritoPonnerPoriman.Text);
            }

            txtPonnerPantikPoriman.Text = ponnerPantikPoriman.ToString();
        }

        private void txtBikritoPonnerKorJoggoMullo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMotPonnoMullo.Text == "" && txtBikritoPonnerKorJoggoMullo.Text == "")
            {
                ponnerPantikMullo = 0.0;
            }


            if (txtMotPonnoMullo.Text != "" && txtBikritoPonnerKorJoggoMullo.Text == "")
            {
                ponnerPantikMullo = Convert.ToDouble(txtMotPonnoMullo.Text);
            }

            if (txtMotPonnoMullo.Text == "" && txtBikritoPonnerKorJoggoMullo.Text != "")
            {
                ponnerPantikMullo = 0 - Convert.ToDouble(txtBikritoPonnerKorJoggoMullo.Text);
            }


            if (txtMotPonnoMullo.Text != "" && txtBikritoPonnerKorJoggoMullo.Text != "")
            {
                ponnerPantikMullo = Convert.ToDouble(txtMotPonnoMullo.Text) - Convert.ToDouble(txtBikritoPonnerKorJoggoMullo.Text);
            }

            txtPonnerPantikMullo.Text = ponnerPantikMullo.ToString();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void lblTrk_Click(object sender, EventArgs e)
        {

        }
    }


   

      
    
}


