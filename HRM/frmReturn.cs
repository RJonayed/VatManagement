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
    public partial class frmReturn : Form
    {
        ClsMain SvCls = new ClsMain();

        double ItemAutoNo = 0;
        string VNo = "";
        string DrHeadID = "";
        string CrHeadID = "";
        string AutoRmk = "";

        public frmReturn()
        {
            InitializeComponent();
            this.Width = ClsVar.GblFormWidth;
            this.Height = ClsVar.GblFormHeight;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
                string SelectQry;
                string SaveQry;
                string EditQry;
                
                if (CboInvoiceNo.Text.Trim() == "")
                {
                    MessageBox.Show("Not Saved....!! \rPlease Insert Invoice No...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (CboReturnCode.Text.Trim() == "")
                {
                    MessageBox.Show("Not Saved....!! \rPlease Insert Return Code...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (CboSLNo.Text.Trim() == "")
                {
                    MessageBox.Show("Not Saved....!! \rPlease Insert SLNo...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (CboItemCode.Text.Trim() == "")
                {
                    MessageBox.Show("Not Saved....!! \rPlease Insert Item Code...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                SelectQry = "Select * from ItemReturn where InvoiceNo =" + CboInvoiceNo.Text.Trim() + " and RetCode ='" + CboReturnCode.Text.Trim() + "' and comid ='" + ClsVar.GblComId + "'";
                SaveQry = "insert into ItemReturn(RetCode,InvoiceNo,RetDate,SlNo,ItemCode,Qty,UnitPrice,TotPrice,Rmk,ItemAutoNo,ComId)values('" + CboReturnCode.Text.Trim() + "','" + CboInvoiceNo.Text.Trim() + "',Convert(Datetime,'" + DtpReturnDate.Text + "',103)," + CboSLNo.Text.Trim() + ",'" + CboItemCode.Text.Trim() + "'," + TxtQty.Text.Trim() + "," + TxtUnitPrice.Text.Trim() + "," + TxtTotal.Text.Trim() + ",'" + TxtRmk.Text.Trim() + "'," + ItemAutoNo + ",'" + ClsVar.GblComId + "')";
                EditQry = "Update ItemReturn set Qty =" + TxtQty.Text.Trim() + ", UnitPrice =" + TxtUnitPrice.Text.Trim() + ",TotalPrice=" + TxtTotal.Text.Trim() + ",Rmk ='" + TxtRmk.Text.Trim() + "',ItemCode ='" + CboItemCode.Text.Trim() + "',SaleDate=Convert(Datetime,'" + DtpReturnDate.Text + "',103),ItemAutoNo=" + ItemAutoNo + " where InvoiceNo ='" + CboInvoiceNo.Text.Trim() + "' and RetCode ='" + CboReturnCode.Text.Trim() + "' and comid ='" + ClsVar.GblComId + "'";

                if (SvCls.DataExist(SelectQry).ToString () == "0")
                {
                    SvCls.insertUpdate(SaveQry);
                    lblMgs.ForeColor = System.Drawing.Color.Green;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }
                else
                {
                    SvCls.insertUpdate(EditQry);
                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }

                
                CmdAddNew.Enabled = true;
                cmdSave.Text = "&Save";
                cmdSave.Enabled = false;
                GridHead();
                Account();
    
        }

        private void GridHead()
        {
            Grid.DataSource = SvCls.GblDataTable("select RetCode,InvoiceNo,RetDate,SlNo,ItemCode,Qty,UnitPrice,TotPrice,Rmk,ItemAutoNo from ItemReturn order by RetCode");
            Grid.Refresh();
        }

        private void GridHeadInvoice()
        {
            GridInvoice.DataSource = SvCls.GblDataTable("Select InvoiceNo,SaleDate,SlNO,ItemCode,Qty,UnitPrice,TotPrice from Sale  where comid='" + ClsVar.GblComId + "' and  InvoiceNo like '" + CboInvoiceNo.Text.Trim() + "%' order by InvoiceNo");
            GridInvoice.Refresh();
        }    
         
        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReturn_Load(object sender, EventArgs e)
        {
            if (ClsVar.GblFrmBackColor == "1")
            {
                ClsVar.BackPicPath = Application.StartupPath + "\\Pic\\" + "Back.jpg";
                this.BackgroundImage = new Bitmap(ClsVar.BackPicPath);

            }
            
            string Qry = "select InvoiceNo From Sale where Comid='" + ClsVar.GblComId + "' order by InvoiceNo";
            CboInvoiceNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboInvoiceNo.DisplayMember = "InvoiceNo";
            CboInvoiceNo.Text = "";

            Qry = "select RetCode From ItemReturn where Comid='" + ClsVar.GblComId + "' order by RetCode";
            CboReturnCode.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboReturnCode.DisplayMember = "RetCode";
            CboReturnCode.Text = "";

            GridHead();
                        
        }
              
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMgs.Visible = false;
            PicSave.Visible = false;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string DeleteQry;
            string SelectQry;

            SelectQry = "Select * from ItemReturn where InvoiceNo =" + CboInvoiceNo.Text.Trim() + " and RetCode ='" + CboReturnCode.Text.Trim() + "' and comid ='" + ClsVar.GblComId + "'";
            DeleteQry = "delete from ItemReturn where InvoiceNo=" + CboInvoiceNo.Text.Trim() + " and RetCode ='" + CboReturnCode.Text.Trim() + "'  and ComId ='" + ClsVar.GblComId + "'";

            if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                if (SvCls.DataExist(SelectQry).ToString() == "1")
                {
                    SvCls.insertUpdate(DeleteQry);
                    lblMgs.ForeColor = System.Drawing.Color.Red;
                    lblMgs.Visible = true;
                    lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                    PicSave.Visible = true;
                }

            btnClear_Click(null, null);
            
            GridHead();   
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
                int i;
                i = Grid.SelectedCells[0].RowIndex;
                CboReturnCode.Text = Grid.Rows[i].Cells[0].Value.ToString();
                CboInvoiceNo.Text = Grid.Rows[i].Cells[1].Value.ToString();
                CboSLNo.Text = Grid.Rows[i].Cells[3].Value.ToString();
                CboInvoiceNo_Leave(null, null);
                CboSLNo_Leave(null, null);

                cmdSave.Enabled = true;
                cmdSave.Text = "&Edit";
                cmdDelete.Enabled = true;       

        }
               
        private void CmdAddNew_Click(object sender, EventArgs e)
        {

            SvCls.toGetData("Select isnull(max(convert(money,RetCode)),0)+1 as Code from ItemReturn where COMID='" + ClsVar.GblComId + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    CboReturnCode.Text = SvCls.GblRdrToGetData["Code"].ToString();
                    SvCls.GblCon.Close();
                }

            DtpReturnDate.Text = DateTime.Now.ToString("dd/MM/yyyy"); ;
            CboSLNo.Text = "";
            CboItemCode.Text = "";
            TxtQty.Text = "0";
            TxtUnitPrice.Text = "0";
            TxtTotal.Text = "0";
            TxtRmk.Text = "";
            CboInvoiceNo.Select();           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CboInvoiceNo.Text = "";
            DtpReturnDate.Text = DateTime.Now.ToString("dd/MM/yyyy"); ;
            CboReturnCode.Text = "";
            CboSLNo.Text = "";
            CboItemCode.Text = "";
            TxtQty.Text = "0";
            TxtUnitPrice.Text = "0";
            TxtTotal.Text = "0";
            TxtRmk.Text = "";
            lblCusName.Text = "";
            lblItemDetails.Text = "";
            CmdAddNew.Select();

        }
                   
        private void CboInvoiceNo_Leave(object sender, EventArgs e)
        {
            if (CboInvoiceNo.Text.Trim()=="")
            {return;}

            string SelectQry = "select SaleDate,CusName from Sale where InvoiceNo =" + CboInvoiceNo.Text.Trim() + " and Comid ='" + ClsVar.GblComId + "'";
            if (SvCls.GblDataSet(SelectQry).Tables[0].Rows.Count > 0)
            {
                DtpReturnDate.Text = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["Saledate"].ToString();
                lblCusName.Text = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["CusName"].ToString();              
            }
            else
            {
                DtpReturnDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }



        }

        private void CboSLNo_Leave(object sender, EventArgs e)
        {
            string ItemName = "";
           string ItemType = "";
           string ItemSize = "";
           string ItemStyle = "";

            if (CboSLNo.Text.Trim() != "")
            {

                string SelectQry = "Select ItemCode,Qty,UnitPrice,TotPrice,Rmk,ItemAutoNo from Sale where SlNo ='" + CboSLNo.Text.Trim() + "' and InvoiceNo=" + CboInvoiceNo.Text.Trim() + " and Comid ='" + ClsVar.GblComId + "'";
                if (SvCls.GblDataSet(SelectQry).Tables[0].Rows.Count > 0)
                {
                    CboItemCode.Text = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["ItemCode"].ToString();
                    TxtQty.Text = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["Qty"].ToString();
                    TxtUnitPrice.Text = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["UnitPrice"].ToString();
                    TxtTotal.Text = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["TotPrice"].ToString();
                    TxtRmk.Text = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["Rmk"].ToString();
                    ItemAutoNo = Convert.ToDouble(SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["ItemAutoNo"]);
                }
                else
                {
                    CboItemCode.Text = "";
                    TxtQty.Text = "0";
                    TxtUnitPrice.Text = "0";
                    TxtTotal.Text = "0";
                    TxtRmk.Text = "";
                    ItemAutoNo = 0;
                }


                SelectQry = "select ItemName,ItemType,ItemSize,ItemStyle from Item where Autono =" + ItemAutoNo + " and Comid= '" + ClsVar.GblComId + "'";
                if (SvCls.GblDataSet(SelectQry).Tables[0].Rows.Count > 0)
                {
                    ItemName = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["ItemName"].ToString();
                    ItemType = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["ItemType"].ToString();
                    ItemSize = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["ItemSize"].ToString();
                    ItemStyle = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["ItemStyle"].ToString();
                }

                lblItemDetails.Text = "Name:'" + ItemName + "' / Type:'" + ItemType + "' / Size:'" + ItemSize + "' / Style:'" + ItemStyle + "'";

 
                
            }
        }
                   
        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                TxtRmk.Select();
            } 
        }

        private void TxtRmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSave.Select();
            } 
        }

        private void CboInvoiceNo_KeyUp(object sender, KeyEventArgs e)
        {
            GridHeadInvoice();
        }

        private void CboInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                DtpReturnDate.Select();
            } 
        }

        private void Account()
        {
            string SelectQry = "";

            AutoRmk = "Return from " + lblCusName.Text + (ClsVar.GblComId);
            SvCls.insertUpdate("Delete from voucher where autormk='" + AutoRmk + "'");

            SelectQry = "select Headid from head where headname='" + lblCusName.Text + "' and Comid= '" + ClsVar.GblComId + "'";
            if (SvCls.GblDataSet(SelectQry).Tables[0].Rows.Count > 0)
            {
                DrHeadID = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["Headid"].ToString();
            }

            SelectQry = "select headid from head where headname='Cash' and Comid= '" + ClsVar.GblComId + "'";
            if (SvCls.GblDataSet(SelectQry).Tables[0].Rows.Count > 0)
            {
                CrHeadID = SvCls.GblDataSet(SelectQry).Tables[0].Rows[0]["Headid"].ToString();
            }

            SvCls.toGetData("select isnull(max(convert(int,voucherno)),0)+1 as CodeNo from voucher where isnumeric(voucherno)=1");
            if (SvCls.GblRdrToGetData.Read())
            {
                VNo = SvCls.GblRdrToGetData["CodeNo"].ToString();
                SvCls.GblCon.Close();
            }
            SvCls.insertUpdate("insert into Voucher (VoucherNo,VDate,HeadId,Dr,Cr,VType,Slno,D_c,ComId,NoteRmk,Amount,Rmk,AutoRmk,headid2) values ('" + VNo + "',convert(datetime,'" + DtpReturnDate.Text + "',103)," + DrHeadID + "," + TxtTotal.Text.Trim() + ",0,'Debit','1','Dr','" + ClsVar.GblComId + "','" + AutoRmk + "'," + TxtTotal.Text.Trim() + ",'Return','" + AutoRmk + "'," + CrHeadID + ")");
            SvCls.insertUpdate("insert into Voucher (VoucherNo,VDate,HeadId,Dr,Cr,VType,Slno,D_c,ComId,NoteRmk,Amount,Rmk,AutoRmk,headid2) values ('" + VNo + "',convert(datetime,'" + DtpReturnDate.Text + "',103)," + CrHeadID + ",0," + TxtTotal.Text.Trim() + ",'Credit','2','Cr','" + ClsVar.GblComId + "','" + AutoRmk + "'," + TxtTotal.Text.Trim() + ",'Return','" + AutoRmk + "'," + CrHeadID + ")");

        }

        private void CboSLNo_Click(object sender, EventArgs e)
        {
            string Qry = "select SlNo From Sale where InvoiceNo=" + CboInvoiceNo.Text.Trim() + " and comid='" + ClsVar.GblComId + "' order by SlNo ";
            CboSLNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboSLNo.DisplayMember = "SlNo";
            CboSLNo.Text = "";
        }

        private void CboSLNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                TxtQty.Select();
            } 
        }

        private void DtpReturnDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CboSLNo.Select();
            }
        }

       


     
        
    }
}
