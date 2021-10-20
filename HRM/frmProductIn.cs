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
    public partial class frmProductIn : Form
    {
        ClsMain SvCls = new ClsMain();

        public frmProductIn()
        {
            InitializeComponent();

            this.Width = ClsVar.GblFormWidth;
            this.Height = ClsVar.GblFormHeight;
            this.StartPosition = FormStartPosition.CenterScreen;

        }


        private void Heading()
        {
            if (cboTransactionId.Text.Trim() != "")
            {
                Grid.DataSource = SvCls.GblDataTable("select TransactionNo,convert(varchar,TransactionDate,103) as TransactionDate,MaterialId,Qty,UnitPrice,ItemFrom,ChallanNo,Remarks from ProductIN where TransactionNo='" + cboTransactionId.Text.Trim() + "' order by convert(money,MaterialId)");
                Grid.Refresh();
            }
            //else
            //{
            //    Grid.DataSource = SvCls.GblDataTable("select TransactionNo,convert(varchar,TransactionDate,103) as TransactionDate,MaterialId,Qty,UnitPrice,ItemFrom,ChallanNo,Remarks from ProductIN order by convert(money,MaterialId) ");
            //    Grid.Refresh();
            //}

            lebTotRows.Text = "Total Rows: " + (Grid.Rows.Count).ToString();


            //lebTotRows.Text = "Total Rows: " + (Grid.Rows.Count - 1).ToString();
        }

        private void frmProductIn_Load(object sender, EventArgs e)
        {
            if (ClsVar.GblFrmBackColor == "1")
            {
                ClsVar.BackPicPath = Application.StartupPath + "\\Pic\\" + "Back.jpg";
                this.BackgroundImage = new Bitmap(ClsVar.BackPicPath);

            }
            string Qry = "select DISTINCT TransactionNo as Tid from ProductIN order by TransactionNo asc";
            cboTransactionId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboTransactionId.DisplayMember = "Tid";
            cboTransactionId.Text = "";

            Qry = "select  MaterialID as Mid  from Masterstock order by convert(int,MaterialID)";
            cboMetarialID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboMetarialID.DisplayMember = "Mid";
            cboMetarialID.Text = "";

            string QryMat = "select  MaterialName as Mid  from Masterstock order by MaterialName";
            cboMatName.DataSource = SvCls.GblDataSet(QryMat).Tables[0];
            cboMatName.DisplayMember = "Mid";
            cboMatName.Text = "";

            //string QryM = "select DISTINCT TypeName as Mid  from Masterstock order by TypeName";
            //cboType.DataSource = SvCls.GblDataSet(QryM).Tables[0];
            //cboType.DisplayMember = "Mid";
            //cboType.Text = "";


            string QryM = "select DISTINCT TypeName as Mid  from MaterialType order by TypeName";
            cboType.DataSource = SvCls.GblDataSet(QryM).Tables[0];
            cboType.DisplayMember = "Mid";
            cboType.Text = "";

            string QrM = "select DISTINCT ItemFrom as Mid  from ProductIN order by ItemFrom";
            cboItem.DataSource = SvCls.GblDataSet(QrM).Tables[0];
            cboItem.DisplayMember = "Mid";
            cboItem.Text = "";

            QrM = "select DISTINCT Unit as Mid  from Masterstock order by Unit";
            cboUnit.DataSource = SvCls.GblDataSet(QrM).Tables[0];
            cboUnit.DisplayMember = "Mid";
            cboUnit.Text = "";

            btnAdd.Select();
            Heading();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransationId_lostfocus()
        {
            try
            {

                string Qry = "select * from ProductIn where TransactionNo =" + cboTransactionId.Text.Trim() + "";
                SvCls.toGetData(Qry);

                if (SvCls.GblRdrToGetData.Read())
                {

                    DateTime Tdate = Convert.ToDateTime(SvCls.GblRdrToGetData["TransactionDate"]);
                    mskTDate.Text = Tdate.ToString();

                    cboMetarialID.Text = SvCls.GblRdrToGetData["materialid"].ToString();
                    cboMatName.Text = SvCls.GblRdrToGetData["MatName"].ToString();
                    txtQty.Text = SvCls.GblRdrToGetData["QTY"].ToString();
                    cboItem.Text = SvCls.GblRdrToGetData["ItemFrom"].ToString();
                    txtUnitPrice.Text = SvCls.GblRdrToGetData["UnitPrice"].ToString();
                    txtChalan.Text = SvCls.GblRdrToGetData["ChallanNo"].ToString();
                    txtRemarks.Text = SvCls.GblRdrToGetData["Remarks"].ToString();
                    cboType.Text = SvCls.GblRdrToGetData["MatType"].ToString();
                    cboUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();

                    SvCls.GblCon.Close();

                }

                else
                {
                    mskTDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                    cboMetarialID.Text = "";
                    cboMatName.Text = "";
                    txtQty.Text = "";
                    cboItem.Text = "";
                    txtUnitPrice.Text = "";
                    txtChalan.Text = "";
                    txtRemarks.Text = "";
                    cboType.Text = "";
                    cboUnit.Text = "";
                    
                }

                //SvCls.toGetData("SELECT MaterialName from Masterstock where MaterialId='" + cboMetarialID.Text.Trim() + "'");
                //if (SvCls.GblRdrToGetData.Read())
                //{
                //    cboMatName.Text = SvCls.GblRdrToGetData["MaterialName"].ToString();
                //    SvCls.GblCon.Close();
                //}
                //else
                //{
                //    cboMatName.Text = "";
                //}

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveSale == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (cboMatName.Text.Trim() == "")
            {
                MessageBox.Show("Material Can't Be Null..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboMetarialID.Text.Trim() == "")
            {
                MessageBox.Show("Material ID Can't Be Null..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtQty.Text.Trim() == "")
            {
                MessageBox.Show("Quantity Can't Be Null..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTransactionId.Text.Trim() == "")
            {
                MessageBox.Show("Transaction ID Can't Be Null..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtAdd.Text= "0";

            string SelectQry;
            string SaveQry;
            string EditQry;
            string Tdate = mskTDate.Text.Trim();


            SelectQry = "select * from ProductIn where TransactionNo =" + cboTransactionId.Text.Trim() + " and MaterialId='" + cboMetarialID.Text.Trim() + "'";
            SaveQry = "insert into ProductIn(UnitPrice,TransactionNo,materialid,TransactionDate,Qty,ItemFrom,ChallanNo,Remarks)values(" + Convert.ToDouble(txtUnitPrice.Text) + "," + cboTransactionId.Text.Trim() + ",'" + cboMetarialID.Text.Trim() + "',convert(datetime,'" + mskTDate.Text + "',103)," + txtQty.Text.Trim() + ",'" + cboItem.Text.Trim() + "','" + txtChalan.Text.Trim() + "','" + txtRemarks.Text.Trim() + "')";///
            EditQry = "Update ProductIn set UnitPrice=" + Convert.ToDouble(txtUnitPrice.Text) + ",Qty=" + txtQty.Text.Trim() + ",ItemFrom='" + cboItem.Text.Trim() + "',ChallanNo='" + txtChalan.Text.Trim() + "',Remarks='" + txtRemarks.Text.Trim() + "',TransactionDate =convert(datetime,'" + mskTDate.Text + "',103) where TransactionNo =" + cboTransactionId.Text.Trim() + " and MaterialId='" + cboMetarialID.Text.Trim() + "'";/// 

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
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

            btnAdd.Select();

            if (MessageBox.Show("Do You Want To Update Master Stock....?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtAvgUnitPrice.Text.Trim() == "")
                {
                    MessageBox.Show("Please Average Price Can't Be Null..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            string Qry;
            Qry = "select materialid from Masterstock where materialid='" + cboMetarialID.Text.Trim() + "'";
            SvCls.toGetData(Qry);

            if (SvCls.GblRdrToGetData.Read())
            {
                Qry = "Update Masterstock set Grp='General',Unitprice=Cast(" + Convert.ToDouble(txtAvgUnitPrice.Text.Trim()) + " As Decimal(10,2)),materialName='" + cboMatName.Text.Trim() + "' ,TypeName='" + cboType.Text.Trim() + "',Unit='" + cboUnit.Text.Trim() + "' where materialid='" + cboMetarialID.Text.Trim() + "'";
                SvCls.insertUpdate(Qry);
            }
            else
            {
                Qry = "insert into Masterstock (Unitprice,materialid,materialName,TypeName,Unit,Grp) values(" + Convert.ToDouble(txtAvgUnitPrice.Text.Trim()) + ",'" + cboMetarialID.Text.Trim() + "','" + cboMatName.Text.Trim() + "','" + cboType.Text.Trim() + "','" + cboUnit.Text.Trim() + "','General')";
                SvCls.insertUpdate(Qry);
            }

          }
      }

        private void cboMetarialID_Leave(object sender, EventArgs e)
        {
            if (cboMetarialID.Text.Trim() != "")
            {
                string Qry = "select Materialname,TypeName,Unit from Masterstock where materialid='" + cboMetarialID.Text.Trim() + "'";
                SvCls.toGetData(Qry);

                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMatName.Text = SvCls.GblRdrToGetData["Materialname"].ToString();
                    cboType.Text = SvCls.GblRdrToGetData["TypeName"].ToString();
                    cboUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                }
                else
                {
                    if (txtAdd.Text == "1")
                    { return; }

                    cboMatName.Text = "";
                    cboType.Text = "";
                    cboUnit.Text = "";
                    MessageBox.Show("Invalid Material ID..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;
                }

                txtQty.Text = "";
                txtUnitPrice.Text = "";
                txtAvgUnitPrice.Text = "";
                cboUnit.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

                string Qry1 = "select TransactionNo  from ProductIn";
                if (SvCls.DataExist(Qry1) == "1")
                {
                    SvCls.toGetData("select max(TransactionNo)+1 as Tid from ProductIn where  isnumeric(TransactionNo)=1");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboTransactionId.Text = SvCls.GblRdrToGetData["Tid"].ToString();
                        SvCls.GblCon.Close();
                        cboMetarialID.Text = "";
                        cboMatName.Text = "";
                        txtQty.Text = "";
                        cboItem.Text = "";
                        txtChalan.Text = "";
                        txtRemarks.Text = "";
                        txtUnitPrice.Text = "";
                        cboType.Text = "";
                        cboUnit.Text = "";
                        txtAvgUnitPrice.Text = "";
                        mskTDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    }
                }
                else
                {
                    cboMetarialID.Text = "";
                    cboMatName.Text = "";
                    txtQty.Text = "";
                    cboItem.Text = "";
                    txtChalan.Text = "";
                    txtRemarks.Text = "";
                    txtUnitPrice.Text = "";
                    cboType.Text = "";
                    cboUnit.Text = "";
                    mskTDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                }
                    cboTransactionId.Select();
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

                //TransationId_lostfocus();
                Heading();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelSale == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                string DeleteQry;
                string SelectQry;

                if (cboMatName.Text.Trim() == "")
                {
                    MessageBox.Show("Material Can't Be Null..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboMetarialID.Text.Trim() == "")
                {
                    MessageBox.Show("Material ID Can't Be Null..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtQty.Text.Trim() == "")
                {
                    MessageBox.Show("Quantity Can't Be Null..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboTransactionId.Text.Trim() == "")
                {
                    MessageBox.Show("Transaction ID Can't Be Null..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SelectQry = "select * from ProductIn where TransactionNo =" + cboTransactionId.Text.Trim() + " and MaterialId='" + cboMetarialID.Text.Trim() + "'";
                DeleteQry = "delete  from ProductIn where TransactionNo =" + cboTransactionId.Text.Trim() + " and MaterialId='" + cboMetarialID.Text.Trim() + "'";

                if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (SvCls.DataExist(SelectQry).ToString() == "1")
                    {
                        SvCls.insertUpdate(DeleteQry);
                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        PicSave.Visible = true;
                                                
                        cboTransactionId.Text = "";
                        cboMatName.Text = "";
                        cboMetarialID.Text = "";
                        txtQty.Text = "";
                        cboItem.Text = "";
                        txtChalan.Text = "";
                        txtRemarks.Text = "";
                        txtUnitPrice.Text = "";
                        cboType.Text = "";
                        cboUnit.Text = "";
                        mskTDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        Heading();
                        
                    }
                btnAdd.Select();
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {

            int i = Grid.SelectedCells[0].RowIndex;
            cboTransactionId.Text = Grid.Rows[i].Cells[0].Value.ToString();
            mskTDate.Value = Convert.ToDateTime(Grid.Rows[i].Cells[1].Value);
            cboMetarialID.Text = Grid.Rows[i].Cells[2].Value.ToString();
            txtQty.Text = Grid.Rows[i].Cells[3].Value.ToString();
            txtUnitPrice.Text = Grid.Rows[i].Cells[4].Value.ToString();
            cboItem.Text = Grid.Rows[i].Cells[5].Value.ToString();
            txtChalan.Text = Grid.Rows[i].Cells[6].Value.ToString();
            txtRemarks.Text = Grid.Rows[i].Cells[7].Value.ToString();

            string Qry = "select Materialname,TypeName,Unit from Masterstock where materialid='" + cboMetarialID.Text.Trim() + "'";
            SvCls.toGetData(Qry);

            if (SvCls.GblRdrToGetData.Read())
            {
                cboMatName.Text = SvCls.GblRdrToGetData["Materialname"].ToString();
                cboType.Text = SvCls.GblRdrToGetData["TypeName"].ToString();
                cboUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
            }
            else
            {
                cboMatName.Text = "";
                cboType.Text = "";
                cboUnit.Text = "";
                MessageBox.Show("Invalid Material ID..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }

        }

        private void cboTransactionId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                mskTDate.Select();
            }
        }

        private void cboMetarialID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboMatName.Select();
            }
        }

        private void mskTDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtQty.Select();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboUnit.Select();
            }
        }

        private void cboItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtChalan.Select();
            }
        }

        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSave.Select();
            }
        }

        private void txtChalan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRemarks.Select();
            }
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            ClsVar.GblSelFor = "";

            if (cboTransactionId.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{ProductIn.TransactionNo}=" + cboTransactionId.Text + " and";
            }


            if (cboMatName.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{MasterStock.MaterialName}='" + cboMatName.Text + "' and ";
            }


            if (cboType.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{MasterStock.TypeName}='" + cboType.Text + "' and ";
            }


            ClsVar.GblSelFor = ClsVar.GblSelFor + "{ProductIn.TransactionDate} = Date(" + mskTDate.Value.Year.ToString() + "," + mskTDate.Value.Month.ToString() + "," + mskTDate.Value.Day.ToString() + ")";

            ClsVar.GblRptHead = "Product IN Report For Date of  " + mskTDate.Text.ToString() + "";
            ClsVar.GblRptName = "ProductIn.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void cboMatName_Leave(object sender, EventArgs e)
        {
            if (cboMatName.Text.Trim()!="")
            {
                string Qry = "select materialid,TypeName,Unit from Masterstock where Materialname='" + cboMatName.Text.Trim() + "'";
                SvCls.toGetData(Qry);

                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMetarialID.Text = SvCls.GblRdrToGetData["materialid"].ToString();
                    cboType.Text = SvCls.GblRdrToGetData["TypeName"].ToString();
                    cboUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();
                }
                else
                {
                    //if (txtAdd.Text == "1")
                    //{ return; }

                    //cboMetarialID.Text = "";
                    //cboType.Text = "";
                    //cboUnit.Text = "";
                    MessageBox.Show("Invalid Material Name..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;
                }
        }
       }

        private void cboMatName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboType.Select();
            }
        }

        private void mskTDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboMetarialID.Select();
            }
        }

        private void cboMetarialID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
             
           if (e.KeyChar.ToString() == "\r")
            {
                cboMatName.Select();
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboItem.Select();
            }
        }

        private void cboType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtQty.Select();
            }
        }

        private void cboUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtUnitPrice.Select();
            }
        }

        private void cboMetarialID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIdAdd_Click(object sender, EventArgs e)
        {
            txtAdd.Text= "1";

            if (cboType.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Material Type.!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Qry = "select convert(numeric,materialid) from Masterstock where TypeName ='" + cboType.Text.Trim() + "'";
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("select max(convert(numeric,materialid))+1 as Tid from Masterstock where TypeName ='" + cboType.Text.Trim() + "' and isnumeric(materialid)=1");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboMetarialID.Text = SvCls.GblRdrToGetData["Tid"].ToString();
                        SvCls.GblCon.Close();

                    }
                }
                cboMatName.Select();
        }
        
        private void txtUnitPrice_Leave(object sender, EventArgs e)
        {
            if (txtUnitPrice.Text.Trim() == "")
            { return; }

            double TotUP = 0;
            double Cnt = 0;

            SvCls.toGetData("SELECT Cast(Avg(UnitPrice) As Decimal(10,4)) As AvgUp From Productin  where Qty > 0 and UnitPrice>0 and materialid ='" + cboMetarialID.Text.Trim() + "' And TransactionDate<=convert(datetime,'" + mskTDate.Text + "',103)");
            if (SvCls.GblRdrToGetData.Read())
            {
                txtAvgUnitPrice.Text = SvCls.GblRdrToGetData["AvgUp"].ToString();
                SvCls.GblCon.Close();
            }

            SvCls.toGetData("SELECT Cast(Sum(UnitPrice) As Decimal(12,4)) As AvgUp From Productin  where Qty > 0 and UnitPrice>0 and materialid ='" + cboMetarialID.Text.Trim() + "' And TransactionDate<=convert(datetime,'" + mskTDate.Text + "',103)");
            if (SvCls.GblRdrToGetData.Read())
            {
                TotUP = Convert.ToDouble(SvCls.GblRdrToGetData["AvgUp"]);
                SvCls.GblCon.Close();
            }

            SvCls.toGetData("SELECT Cast(count(Qty) As Decimal(12,4)) As AvgUp From Productin  where Qty > 0 and UnitPrice>0 and materialid ='" + cboMetarialID.Text.Trim() + "' And TransactionDate<=convert(datetime,'" + mskTDate.Text + "',103)");
            if (SvCls.GblRdrToGetData.Read())
            {
                Cnt = Convert.ToDouble(SvCls.GblRdrToGetData["AvgUp"]);
                SvCls.GblCon.Close();
            }
            //txtAvgUnitPrice.Text = (TotUP  / Cnt).ToString();
            txtAvgUnitPrice.Text = ((TotUP + Convert.ToDouble(txtUnitPrice.Text.Trim())) / (Cnt + 1)).ToString().Substring(0, 7);

            
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (cboType.Text.Trim() != "")
            {
                sql = sql + " and m.typename='" + cboType.Text.Trim() + "'";
            }

            if (cboMetarialID.Text.Trim() != "")
            {
                sql = sql + " and m.MaterialId='" + cboMetarialID.Text.Trim() + "'";
            }


            Grid.DataSource = SvCls.GblDataTable("select p.TransactionNo,convert(varchar,p.TransactionDate,103) as TransactionDate,p.MaterialId,p.Qty,p.UnitPrice,p.ItemFrom,p.ChallanNo,p.Remarks from masterstock m, ProductIN p where m.MaterialId=p.MaterialId " + sql + " order by convert(money,p.materialid)");/// materialid<>'0'
            Grid.Refresh();

            lebTotRows.Text = "Total Rows: " + (Grid.Rows.Count - 1).ToString();
        }

        private void btnBlank_Click(object sender, EventArgs e)
        {
            cboMetarialID.Text = "";
            cboMatName.Text = "";
            txtQty.Text = "";
            cboItem.Text = "";
            txtChalan.Text = "";
            txtRemarks.Text = "";
            txtUnitPrice.Text = "";
            cboType.Text = "";
            cboUnit.Text = "";
            txtAvgUnitPrice.Text = "";
            mskTDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboType.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Masterstock.typename}='" + cboType.Text + "' and ";
            }

            if (cboMetarialID.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Masterstock.MaterialId}='" + cboMetarialID.Text + "' and ";
            }

            if (dtpFrom.Text == "  /  /" && dtpTo.Text == "  /  /")
            {
                MessageBox.Show("Please Select From Date & To Date ...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ClsVar.GblSelFor = ClsVar.GblSelFor + "{VwProductRecInfo.QtyIn}<> 0 and ";

            ClsVar.GblSelFor = ClsVar.GblSelFor + "{VwProductRecInfo.transactiondate}in Date(" + Convert.ToDateTime(dtpFrom.Text).Year.ToString() + "," + Convert.ToDateTime(dtpFrom.Text).Month.ToString() + "," + Convert.ToDateTime(dtpFrom.Text).Day.ToString() + ") to Date(" + Convert.ToDateTime(dtpTo.Text).Year.ToString() + "," + Convert.ToDateTime(dtpTo.Text).Month.ToString() + "," + Convert.ToDateTime(dtpTo.Text).Day.ToString() + ") ";

            ClsVar.GblRptHead = "Product Receive Information";
            ClsVar.GblRptHead = "Product Receive for the Period of  " + dtpFrom.Text.ToString() + "  To  " + dtpTo.Text.ToString();
            ClsVar.GblRptName = "ProductInfo.rpt";

            frmReport Rpt = new frmReport();
            Rpt.Show();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            lebProcess.Visible = true;

            int j = 0;
            string MatId = "";
            DateTime TheDate;
            double AvgUnitPrice = 0;
            string JobCardNo = "";
            string InsertQry = "";

            SvCls.GblCon.Open();
            string qry = "select MaterialId,Condate,JobCardNo From MaterialUsed order By Convert(numeric,MaterialId)";
            DataSet Ds = new DataSet();
            Ds = SvCls.GblDataSet(qry);
            if (Ds.Tables[0].Rows.Count > 0)
            {
                do
                {
                    MatId = Ds.Tables[0].Rows[j]["MaterialId"].ToString();
                    TheDate = Convert.ToDateTime(Ds.Tables[0].Rows[j]["Condate"]);
                    JobCardNo = Ds.Tables[0].Rows[j]["JobCardNo"].ToString();

                    SvCls.toGetData("SELECT isnull(Cast(Avg(UnitPrice) As Decimal(10,2)),0) As AvgUp From Productin  where materialid ='" + MatId + "' And TransactionDate<=convert(datetime,'" + TheDate + "',103)");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        AvgUnitPrice = Convert.ToDouble(SvCls.GblRdrToGetData["AvgUp"]);
                        SvCls.GblCon.Close();
                    }

                    InsertQry = "update MaterialUsed set UnitPrice=" + Convert.ToDouble(AvgUnitPrice) + " where MaterialId='" + MatId + "' And Condate=convert(datetime,'" + TheDate + "',103) And JobCardNo='" + JobCardNo + "' ";
                    //SvCls.insertUpdate(InsertQry);


                    lebProcess.Text = j.ToString() + "  Completed out of  " + Ds.Tables[0].Rows.Count.ToString();
                    lebProcess.Refresh();

                    j = j + 1;
                } while (j < Ds.Tables[0].Rows.Count);
                lebProcess.Visible = false;

            }

        }

    }
}
