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
    public partial class UpdateItemInfo : Form
    {
        ClsMain SvCls = new ClsMain();

        public UpdateItemInfo()
        {
            InitializeComponent();
        }

        private void txtSrchFind_KeyDown(object sender, KeyEventArgs e)
        {
            //string kChar = e.KeyCode.ToString();

            if (e.KeyCode.ToString().ToLower() == "down")
            {
                GrdFnd.Focus();
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                btnClear.Select();
            }
        }

        private void GridHeadingForFind()
        {
            string sql = "";

            if (txtSrchFind.Text.Trim() != "")
            {
                sql = sql + " and (i.itemcode like '%" + txtSrchFind.Text.Trim() + "%' or i.itemname like '%" + txtSrchFind.Text.Trim() + "%' or i.BarCode like '%" + txtSrchFind.Text.Trim() + "%' or i.ItemType like '%" + txtSrchFind.Text.Trim() + "%' or i.ItemSize like '%" + txtSrchFind.Text.Trim() + "%')";
            }
            if (SrcItemSize.Text.Trim() != "")
            {
                sql = sql + " and i.ItemSize like '%" + SrcItemSize.Text.Trim() + "%'";
            }
            if (SrcItemType.Text.Trim() != "")
            {
                sql = sql + " and i.ItemType like '%" + SrcItemType.Text.Trim() + "%'";
            }
            //if (txtSalePriceFind.Text.Trim() != "")
            //{
            //    sql = sql + " and saleprice=%" + txtSalePriceFind.Text.Trim();
            //}

            try
            {

                //GrdFnd.DataSource = SvCls.GblDataTable("select i.AutoNo,i.ItemCode as [Item Code],i.ItemName as [Item Name],i.ItemType as [Item Type],i.ItemStyle as [Brand],i.ItemSize as [Item Size],cast(i.SalePrice as decimal(10,0)) as [Cash Sale Price],cast(i.MRP as decimal(10,0)) as [M.R.P], cast(i.WholeSalePrice as decimal(10,0)) as [Whole Sale], cast(i.CardSalePrice as decimal(10,0)) as [Card Price], cast(i.CreditSalePrice as decimal(10,0)) as [Credit Price], cast(s.InHandQty as decimal(10,0)) as [Total In Hand], cast(i.LatestPurchasePrice as decimal (10,0)) as [Purchase Price], i.BarCode from Item i, StockRpt s where i.AutoNo = s.ItemAutoNo and i.comid='" + ClsVar.GblComId + "' " + sql + " Order By i.ItemCode DESC"); //With all sale price

                GrdFnd.DataSource = SvCls.GblDataTable("select i.AutoNo,i.ItemCode as [Item Code],i.ItemName as [Item Name],i.ItemType as [Item Type],i.ItemStyle as [Brand],i.ItemSize as [Item Size],cast(i.SalePrice as decimal(10,0)) as [Cash Sale Price],cast(i.MRP as decimal(10,0)) as [M.R.P], cast(s.InHandQty as decimal(10,0)) as [Total In Hand], cast(i.LatestPurchasePrice as decimal (10,0)) as [Purchase Price], i.BarCode from Item i, StockRpt s where i.AutoNo = s.ItemAutoNo and i.comid='" + ClsVar.GblComId + "' " + sql + " Order By i.ItemCode DESC");
                GrdFnd.Refresh();
                GridColumnSize();
            }
            catch (Exception fnd)
            {
                MessageBox.Show(fnd.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtSrchFind_KeyUp(object sender, KeyEventArgs e)
        {
            GridHeadingForFind();

            lblTotalProduct.Text = "Total Product :" + " " + GrdFnd.Rows.Count.ToString();
        }

        private void UpdateItemInfo_Load(object sender, EventArgs e)
        {
            //this.Location = new System.Drawing.Point(202, 70);
            SvCls.toGetData("Select count(ItemCode) as total from Item");
            if (SvCls.GblRdrToGetData.Read())
            {
                lblTotalProduct.Text = "Total Product :" +" "+ SvCls.GblRdrToGetData["total"].ToString();
            }

            txtSrchFind.Select();

            string qry = ("select AutoNO,ItemCode as [Item Code],ItemName as [Item Name],ItemType as [Item Type],ItemStyle as [Brand],ItemSize as [Item Size],cast(SalePrice as decimal(10,0)) as [Sale Price],cast(MRP as decimal(10,0)) as [M.R.P], cast(OpBalQty as decimal(10,0)) as [Stock], cast(LatestPurchasePrice as decimal (10,0)) as [Purchase Price], BarCode from Item where comid='" + ClsVar.GblComId + "' and ItemCode = '0' Order By ItemCode Desc");

            GrdFnd.DataSource = SvCls.GblDataTable(qry);
            GrdFnd.Refresh();
            
            GridColumnSize();
            
        }
        
        private void GridColumnSize()
        {
            DataGridViewColumn column = GrdFnd.Columns[0];
            column = GrdFnd.Columns[0]; //Auto No
            column.Width = 0;
            column.Visible = false;

            column = GrdFnd.Columns[1]; //Item Code
            column.Width = 80;

            column = GrdFnd.Columns[2]; //Item Name
            column.Width = 400;

            column = GrdFnd.Columns[3]; //Item Type
            column.Width = 170;

            column = GrdFnd.Columns[4]; //Brand
            column.Width = 80;

            column = GrdFnd.Columns[5]; //Item Size
            column.Width = 170;

            column = GrdFnd.Columns[6]; //Sale
            column.Width = 90;

            column = GrdFnd.Columns[7]; //MRP
            column.Width = 90;


            column = GrdFnd.Columns[8]; //Stock
            column.Width = 120;

            column = GrdFnd.Columns[9]; //Purchase Price
            column.Width = 100;

            column = GrdFnd.Columns[10]; //Purchase Price
            column.Width = 130;
        }


        private void GrdFnd_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdFnd.CurrentCell.ColumnIndex == 3 || GrdFnd.CurrentCell.ColumnIndex == 5 || GrdFnd.CurrentCell.ColumnIndex == 6 || GrdFnd.CurrentCell.ColumnIndex == 7 || GrdFnd.CurrentCell.ColumnIndex == 9 || GrdFnd.CurrentCell.ColumnIndex == 10)
            {
                GrdFnd.BeginEdit(true);
            }
        }

        private void GrdFnd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Int32 ItemAutoNo = 0;
            string ItemName = "";
            string ItemType = "";
            string ItemSize = "";
            double SalePrice = 0;
            double MRP = 0;
            double WholeSalePrice = 0;
            double CardPrice = 0;
            double CreditPrice = 0;
            double Stock = 0;
            double rate = 0;
            string BarCode = "";

            string i = GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[6].Value.ToString();
            ItemAutoNo = Convert.ToInt32(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //ItemName = Convert.ToString(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[2].Value.ToString());
            ItemType = Convert.ToString(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[3].Value.ToString());
            ItemSize = Convert.ToString(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[5].Value.ToString());
            SalePrice = Convert.ToDouble(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[6].Value.ToString());
            MRP = Convert.ToDouble(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[7].Value.ToString());
            //WholeSalePrice = Convert.ToDouble(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[8].Value.ToString());
            //CardPrice = Convert.ToDouble(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[9].Value.ToString());
            //CreditPrice = Convert.ToDouble(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[10].Value.ToString());
            Stock = Convert.ToDouble(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[8].Value.ToString());
            rate = Convert.ToDouble(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[9].Value.ToString());
            BarCode = Convert.ToString(GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[10].Value.ToString());

            //Restriction For Duplicate Barcode
            SvCls.toGetData("Select BarCode From Item Where AutoNo <> " + ItemAutoNo + " and BarCode <> '00' AND BarCode = '" + BarCode + "'");
            if (SvCls.GblRdrToGetData.Read())
            {
                MessageBox.Show("Barcode Already Exist..!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridHeadingForFind();
                return;
            }

            if (BarCode == "bc")
            {
                String Qry = "select isnull(max(convert(int,barcode)),1000)+1 as CodeNo from Item where isnumeric(barcode)=1 and len(barcode)<=5 and comid='" + ClsVar.GblComId + "'";
                SvCls.toGetData(Qry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    BarCode = SvCls.GblRdrToGetData["CodeNo"].ToString();
                    GrdFnd.Rows[GrdFnd.CurrentCell.RowIndex].Cells[10].Value = BarCode;
                }
            }
            SvCls.insertUpdate("UPDATE Item SET ItemType = '" + ItemType + "', ItemSize = '" + ItemSize + "', SalePrice = " + SalePrice + ", MRP = " + MRP + ", WHoleSalePrice = " + WholeSalePrice + ", CardSalePrice = " + CardPrice + ", CreditSalePrice = " + CreditPrice + ", OpBalQty = " + Stock + ", LatestPurchasePrice = " + rate + ", BarCode = '" + BarCode + "' WHERE AutoNo = " + ItemAutoNo + "");
            lblMsg.Visible = true;
            lblMsg.Text = "Update Successfully...!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }
        
        private void GrdFnd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
         
        }

        private void GrdFnd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SrcItemSize_KeyUp(object sender, KeyEventArgs e)
        {
            GridHeadingForFind();
        }

        private void SrcItemType_KeyUp(object sender, KeyEventArgs e)
        {
            GridHeadingForFind();
        }

        private void SrcItemSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().ToLower() == "down")
            {
                GrdFnd.Focus();
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                btnClear.Select();
            }
        }

        private void SrcItemType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().ToLower() == "down")
            {
                GrdFnd.Focus();
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                btnClear.Select();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(chkIncom.Checked == true)
            {
                GrdIncomplete();
            }
            else
            {

                txtSrchFind.Text = "";
                SrcItemSize.Text = "";
                SrcItemType.Text = "";

                GridHeadingForFind();
                txtSrchFind.Select();

                lblTotalProduct.Text = "Total Product :" + " " + GrdFnd.Rows.Count.ToString();
            }

            if (SvCls.GblCon != null && SvCls.GblCon.State != ConnectionState.Closed)
            {
                SvCls.GblCon.Close();
            }

            string DtpIFrom = "01/01/2010";
            DateTime DtpITo = DateTime.Today;

            SvCls.GblCon.Open();
            SvCls.GblSqlCmd.Connection = SvCls.GblCon;
            SvCls.GblSqlCmd.CommandText = "SpStockRpt";
            SvCls.GblSqlCmd.CommandType = CommandType.StoredProcedure;

            SvCls.GblSqlCmd.Parameters.Add("@fromDate", SqlDbType.VarChar, 10);
            SvCls.GblSqlCmd.Parameters["@fromDate"].Value = DtpIFrom;

            SvCls.GblSqlCmd.Parameters.Add("@toDate", SqlDbType.VarChar, 10);
            SvCls.GblSqlCmd.Parameters["@toDate"].Value = DtpITo;

            SvCls.GblSqlCmd.Parameters.Add("@comId", SqlDbType.VarChar, 10);
            SvCls.GblSqlCmd.Parameters["@comId"].Value = ClsVar.GblComId;

            SvCls.GblSqlCmd.Parameters.Add("@pcName", SqlDbType.VarChar, 50);
            SvCls.GblSqlCmd.Parameters["@pcName"].Value = ClsVar.GblPcName;


            SvCls.GblSqlCmd.ExecuteNonQuery();
            SvCls.GblSqlCmd.Parameters.Clear();
            SvCls.GblCon.Close();
        }

        private void GrdFnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                txtSrchFind.Select();
            }

            if (e.Control &&  e.KeyCode == Keys.C)
            {
                btnClear.Select();
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                SrcItemSize.Select();
            }

            if (e.Control && e.KeyCode == Keys.T)
            {
                SrcItemType.Select();
            }

        }

        private void chkIncom_CheckedChanged(object sender, EventArgs e)
        {
            if(chkIncom.Checked == true)
            {
                GrdIncomplete();
            }
        }

        private void GrdIncomplete()
        {
            GrdFnd.DataSource = SvCls.GblDataTable("select AutoNO,ItemCode as [Item Code],ItemName as [Item Name],ItemType as [Item Type],ItemStyle as [Brand],ItemSize as [Item Size],cast(SalePrice as decimal(10,0)) as [Sale Price],cast(MRP as decimal(10,0)) as [M.R.P], cast(WholeSalePrice as decimal(10,0)) as [Whole Sale Price], cast(CardSalePrice as decimal(10,0)) as [Card Sale Price], cast(CreditSalePrice as decimal(10,0)) as [Credit Sale Price], cast(curStock as decimal(10,0)) as [Item Stock], cast(LatestPurchasePrice as decimal (10,0)) as [Purchase Price], BarCode from Item where comid='" + ClsVar.GblComId + "' and SalePrice = 0 or MRP = 0 or CardSalePrice = 0 or CreditSalePrice = 0 or WholeSalePrice = 0 or BarCode = '' Order By ItemType");
            GrdFnd.Refresh();
            lblTotalProduct.Text = "Total Product :" + " " + GrdFnd.Rows.Count.ToString();
        }

        private void GrdFnd_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int colIndex = GrdFnd.CurrentCell.ColumnIndex;

            string header = GrdFnd.Columns[colIndex].HeaderText.ToLower();

            //lebTem.Text = header;
            //            string Head = Grid.Rows[i].co.Value.ToString();

            TextBox tb = e.Control as TextBox;

            if (header.ToLower() == "item type")
            {

                if (tb != null)
                {
                    tb.AutoCompleteMode = AutoCompleteMode.Suggest;
                    tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

                    string Qry = "select distinct itemtype as codeno from item order by itemtype";
                    SvCls.toGetData(Qry);
                    while (SvCls.GblRdrToGetData.Read())
                    {
                        coll.Add(SvCls.GblRdrToGetData["codeno"].ToString());
                    }
                    tb.AutoCompleteCustomSource = coll;

                }
            }
            else
            {
                tb.AutoCompleteMode = AutoCompleteMode.None;
            }
        }   
    }
}
