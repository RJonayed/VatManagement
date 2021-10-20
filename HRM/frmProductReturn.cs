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
    public partial class frmProductReturn : Form
    {
        ClsMain SvCls = new ClsMain();
        public frmProductReturn()
        {
            InitializeComponent();

            this.Width = ClsVar.GblFormWidth;
            this.Height = ClsVar.GblFormHeight;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

       
       

        private void btnNew_Click(object sender, EventArgs e)
        {
            //try
            //{
                string Qry1 = "select TransactionNo  from StoreReturn";
                if (SvCls.DataExist(Qry1) == "1")
                {
                    SvCls.toGetData("select max(TransactionNo)+1 as Tid from StoreReturn where  isnumeric(TransactionNo)=1");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboTransactionId.Text = SvCls.GblRdrToGetData["Tid"].ToString();
                        SvCls.GblCon.Close();
                        //cboJobCard.Text = "";
                        cboMatName.Text = "";
                        txtStorSlip.Text = "";
                        dtpRetDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        txtQty.Text = "";
                        txtRemarks.Text = "";
                        txtMatId.Text = "";
                    }
                }
                else
                {
                    //cboJobCard.Text = "";
                    cboMatName.Text = "";
                    txtStorSlip.Text = "";
                    dtpRetDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    txtQty.Text = "";
                    txtRemarks.Text = "";
                    txtMatId.Text = "";
                }
            //}
                txtMatId.Select();
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }


        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Transaction_lostfocus()
        {

            try
            {

                string Qry = "select * from StoreReturn where TransactionNo ='" + cboTransactionId.Text.Trim() + "' and MaterialId='" + txtMatId.Text.Trim() + "' and JobCardNo='" + cboJobCard.Text.Trim() + "' ";
                SvCls.toGetData(Qry);

                if (SvCls.GblRdrToGetData.Read())
                {

                    DateTime Tdate = Convert.ToDateTime(SvCls.GblRdrToGetData["ReturnDate"]);
                    dtpRetDate.Text = Tdate.ToString();
                    txtMatId.Text = SvCls.GblRdrToGetData["materialid"].ToString();
                    txtStorSlip.Text = SvCls.GblRdrToGetData["StoreSlipNo"].ToString();
                    txtQty.Text = SvCls.GblRdrToGetData["QTY"].ToString();
                    txtRemarks.Text = SvCls.GblRdrToGetData["Remarks"].ToString();

                    SvCls.GblCon.Close();

                }

                else
                {
                    txtStorSlip.Text = "";
                    dtpRetDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    txtQty.Text = "";
                    txtRemarks.Text = "";
                    txtMatId.Text = "";


                }

                SvCls.toGetData("SELECT MaterialName from Masterstock where MaterialId='" + txtMatId.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMatName.Text = SvCls.GblRdrToGetData["MaterialName"].ToString();
                    SvCls.GblCon.Close();
                }
                else
                {
                    cboMatName.Text = "";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        
        
        }
        private void Heading()
        {
            Grid.DataSource = SvCls.GblDataTable("select S.TransactionNo,S.JobCardNo,S.StoreSlipNo,S.MaterialId,M.MaterialName,M.TypeName,S.ReturnDate,S.Qty,S.Remarks  from StoreReturn S,MasterStock M where  S.MaterialId=M.MaterialId and S.TransactionNo='" + cboTransactionId.Text.Trim() + "' order by S.TransactionNo asc");
            Grid.Refresh();
                
        }
        private void Head()
        {
            Grid.DataSource = SvCls.GblDataTable("select S.TransactionNo,S.JobCardNo,S.StoreSlipNo,S.MaterialId,M.MaterialName,M.TypeName,S.ReturnDate,S.Qty,S.Remarks  from StoreReturn S,MasterStock M where  S.MaterialId=M.MaterialId and S.JobCardNo='" + cboJobCard.Text.Trim() + "' order by S.TransactionNo asc");
            Grid.Refresh();

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveProductReturn  == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string SelectQry;
            string SaveQry;
            string EditQry;

            if (cboJobCard.Text.Trim() == "")
            {
                return;
            }

            if (cboTransactionId.Text.Trim() == "")
            {
                return;
            }

            SelectQry = "select * from StoreReturn where TransactionNo =" + cboTransactionId.Text.Trim() + " and MaterialId='" + txtMatId.Text.Trim() + "' and JobCardNo='" + cboJobCard.Text.Trim() + "'";
            SaveQry = "insert into StoreReturn(TransactionNo,JobCardNo,materialid,StoreSlipNo,ReturnDate,QTY,Remarks)values(" + cboTransactionId.Text.Trim() + ",'" + cboJobCard.Text.Trim() + "','" + txtMatId.Text.Trim() + "','" + txtStorSlip.Text.Trim() + "',convert(datetime,'" + dtpRetDate.Text  + "',103)," + txtQty.Text.Trim() + ",'" + txtRemarks.Text.Trim() + "')";
            EditQry = "Update StoreReturn set ReturnDate =convert(datetime,'" + dtpRetDate.Text + "',103),Qty=" + txtQty.Text.Trim() + ", StoreSlipNo='" + txtStorSlip.Text.Trim() + "',Remarks='" + txtRemarks.Text.Trim() + "' where TransactionNo =" + cboTransactionId.Text.Trim() + " and MaterialId='" + txtMatId.Text.Trim() + "' and JobCardNo='" + cboJobCard.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {


                SvCls.insertUpdate(SaveQry);
                //MasterStock()
                lblMgs.ForeColor = System.Drawing.Color.White;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Heading();


            }
            else
            {


                SvCls.insertUpdate(EditQry);
                lblMgs.ForeColor = System.Drawing.Color.White;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;
                Heading();
            }

            txtMatId.Select();
        }

        private void MasterStock()
        {

            string SaveQry = "Update MasterStock set QtyOut = QtyOut + " + Convert.ToDouble(txtQty.Text.Trim()) + ",QtyinHand= QtyIn + " + Convert.ToDouble(txtQty.Text.Trim()) + "  where materialid ='" + txtMatId.Text.Trim() + "'";
            SvCls.insertUpdate(SaveQry);




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMgs.Visible = false;
            PicSave.Visible = false;
        }

        

        private void cboTransactionId_Leave(object sender, EventArgs e)
        {
                if (cboTransactionId.Text.Trim() == "")
                {
                    return;
                }

                Transaction_lostfocus();
                Heading();


         }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelProductReturn== false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                string DeleteQry;
                string SelectQry;

                if (cboJobCard.Text.Trim() == "")
                {
                    return;
                }

                if (cboTransactionId.Text.Trim() == "")
                {
                    return;
                }

                SelectQry = "select * from StoreReturn where TransactionNo =" + cboTransactionId.Text.Trim() + " and MaterialId='" + txtMatId.Text.Trim() + "' and JobCardNo='" + cboJobCard.Text.Trim() + "'";
                DeleteQry = "delete  from StoreReturn where TransactionNo =" + cboTransactionId.Text.Trim() + " and MaterialId='" + txtMatId.Text.Trim() + "' and JobCardNo='" + cboJobCard.Text.Trim() + "'";

                if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (SvCls.DataExist(SelectQry).ToString() == "1")
                    {
                        SvCls.insertUpdate(DeleteQry);

                        //string SavQry = "Update MasterStock set QtyOut = QtyOut - " + Convert.ToDouble(txtQty.Text.Trim()) + ",QtyinHand= QtyIn - " + Convert.ToDouble(txtQty.Text.Trim()) + "  where materialid ='" + txtMatId.Text.Trim() + "'";
                        //SvCls.insertUpdate(SavQry);

                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        PicSave.Visible = true;

                        cboJobCard.Text = "";
                        cboMatName.Text = "";
                        txtStorSlip.Text = "";
                        dtpRetDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        txtQty.Text = "";
                        txtRemarks.Text = "";
                        txtMatId.Text = "";
                        cboTransactionId.Text="";
                        Heading();

                    }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboTransactionId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMatId.Select();
            }
        }


        private void cboJobCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboTransactionId.Select();
            }
        }

        private void cboMType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboMatName.Select();
            }
        }

        private void cboMid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtStorSlip.Select();
            }
        }



        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRemarks.Select();
            }
        }

        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSave.Select();
            }
        }

       




        private void frmProductReturn_Load(object sender, EventArgs e)
        {
            if (ClsVar.GblFrmBackColor == "1")
            {
                ClsVar.BackPicPath = Application.StartupPath + "\\Pic\\" + "Back.jpg";
                this.BackgroundImage = new Bitmap(ClsVar.BackPicPath);

            }
            string Qry = "select DISTINCT TransactionNo as Tid from StoreReturn order by TransactionNo asc";
            cboTransactionId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboTransactionId.DisplayMember = "Tid";
            cboTransactionId.Text = "";

            string Qry1 = "Select jobcardno from Orderdetails order by JobCardNo asc";
            cboJobCard.DataSource = SvCls.GblDataSet(Qry1).Tables[0];
            cboJobCard.DisplayMember = "jobcardno";
            cboJobCard.Text = "";

            string Mqry = "select MaterialName as Mid  from Masterstock  order by mid";
            cboMatName.DataSource = SvCls.GblDataSet(Mqry).Tables[0];
            cboMatName.DisplayMember = "Mid";
            cboMatName.Text = "";


        }

        private void cboMatName_Leave(object sender, EventArgs e)
        {
            //if (cboMatName.Text.Trim() == "")
            //{
            //    MessageBox.Show("Invalid Material..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}


            string Qry = "select materialid from Masterstock where Materialname='" + cboMatName.Text.Trim() + "'";
            SvCls.toGetData(Qry);

            if (SvCls.GblRdrToGetData.Read())
            {
                txtMatId.Text = SvCls.GblRdrToGetData["materialid"].ToString();
            }
            else
            {
                txtMatId.Text = "";
                MessageBox.Show("Invalid Material..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void cboJobCard_Leave(object sender, EventArgs e)
        {
            if (cboJobCard.Text.Trim() == "")
            {
                return;
            }

            Head();
        }

        private void txtStorSlip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpRetDate.Select();
            }
        }

        private void dtpRetDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Select();
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i = Grid.SelectedCells[0].RowIndex;
            cboTransactionId.Text = Grid.Rows[i].Cells[0].Value.ToString();
            txtMatId.Text = Grid.Rows[i].Cells[3].Value.ToString();
            cboJobCard.Text = Grid.Rows[i].Cells[1].Value.ToString();
            Transaction_lostfocus();
        }

        private void txtMatId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboMatName.Select();
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            //if (txtMatId.Text != "")
            //{
            //    ClsVar.GblSelFor = ClsVar.GblSelFor + "{StoreReturn.MaterialId}='" + txtMatId.Text + "' ";
            //}

            if (cboTransactionId.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{StoreReturn.TransactionNo}=" + cboTransactionId.Text + " and";
            }

            if (cboJobCard.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{StoreReturn.JobcardNo}='" + cboJobCard.Text + "' and ";
            }

            ClsVar.GblSelFor = ClsVar.GblSelFor + "{StoreReturn.ReturnDate}= Date(" + dtpRetDate.Value.Year.ToString() + "," + dtpRetDate.Value.Month.ToString() + "," + dtpRetDate.Value.Day.ToString() + ")";


            ClsVar.GblHeadName = "Product Return Information";
            ClsVar.GblRptName = "ProductReturn.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void txtMatId_Leave(object sender, EventArgs e)
        {
            string Qry = "select Materialname from Masterstock where materialid ='" + txtMatId.Text.Trim() + "'";
            SvCls.toGetData(Qry);

            if (SvCls.GblRdrToGetData.Read())
            {
                cboMatName.Text = SvCls.GblRdrToGetData["Materialname"].ToString();
            }
            else
            {
                txtMatId.Text = "";
                MessageBox.Show("Invalid Material ID..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtMatId.Select();
                return;
            }
            button1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Qry1 = "select StoreSlipNo  from StoreReturn";
            if (SvCls.DataExist(Qry1) == "1")
            {
                SvCls.toGetData("select max(StoreSlipNo)+1 as Tid from StoreReturn where  isnumeric(StoreSlipNo)=1");
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtStorSlip.Text = SvCls.GblRdrToGetData["Tid"].ToString();
                    SvCls.GblCon.Close();
                }
            }
            else
            {
                txtStorSlip.Text = "1";
            }
            txtQty.Select();
        }


    }
}
