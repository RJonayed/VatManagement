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
    public partial class frmProductInOutReturn : Form
    {
        ClsMain SvCls = new ClsMain();

        public frmProductInOutReturn()
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
                Grid.DataSource = SvCls.GblDataTable("select p.TranNo,p.TranDate,p.MatID,m.Materialname,m.TypeName,p.Qty,m.Unit,p.Uprice,p.ChalNo,p.SlipNo,p.ItemFrom,p.Rmk from ProductInOutReturn p,Masterstock m where p.MatID=m.materialID and  p.Type ='" + cbotype.Text.Trim() + "'and p.tranno='" + cboTransactionId.Text.Trim() + "' order by p.TranNo asc");
                Grid.Refresh();
            }
            else
            {
                Grid.DataSource = SvCls.GblDataTable("select p.TranNo,p.TranDate,p.MatID,m.Materialname,m.TypeName,p.Qty,m.Unit,p.Uprice,p.ChalNo,p.SlipNo,p.ItemFrom,p.Rmk from ProductInOutReturn p,Masterstock m where p.MatID=m.materialID and p.Type ='" + cbotype.Text.Trim() + "' order by p.TranNo asc");
                Grid.Refresh();
            }

            lebTotRows.Text = "Total Rows: " + (Grid.Rows.Count - 1).ToString();

        }



        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void cmdSave_Click(object sender, EventArgs e)
        {

            double inQty;
            double outQty;


            if (ClsVar.SaveItemInOutReturn == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string SelectQry;
            string SaveQry;
            string EditQry;
            string Tdate = dtpTranDate.Text.Trim();

            if (txtQty.Text.Trim() == "")
            {
               return;
            }

            if (txtUnitPrice.Text.Trim() == "")
            {
                return;
            }

            if (cbotype.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Type ...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTransactionId.Text.Trim() == "")
            {
                MessageBox.Show("Please Select TransactionId ...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        if(cbotype.Text=="OUT")
         {
            if (txtMatId.Text.Trim() != "" && txtQty.Text.Trim() != "")
            {
                inQty = 0;
                outQty = 0;

                SvCls.toGetData("SELECT isnull(sum(qty),0) as Bal From ProductInOutReturn  where type='IN' and matid ='" + txtMatId.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    inQty  = Convert.ToDouble(SvCls.GblRdrToGetData["Bal"]);
                    SvCls.GblCon.Close();
                }

                SvCls.toGetData("SELECT isnull(sum(qty),0) as Bal From ProductInOutReturn  where type='OUT' and matid ='" + txtMatId.Text.Trim() + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    outQty  = Convert.ToDouble(SvCls.GblRdrToGetData["Bal"]);
                    SvCls.GblCon.Close();
                }

               
                if ((inQty-outQty ) < Convert.ToDouble(txtQty.Text.Trim()))
                {
                    MessageBox.Show("Stock Are Not Available...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

            txtAdd.Text = "0";

            if (txtUnitPrice.Text.Trim() == "")
            {
                txtUnitPrice.Text = Convert.ToInt16(0).ToString();
            }

                SelectQry = "select * from ProductInOutReturn where TranNo ='" + cboTransactionId.Text.Trim() + "' and MatId='" + txtMatId.Text.Trim() + "' and Type='" + cbotype.Text.Trim() + "'";
                SaveQry = "insert into ProductInOutReturn(chalno,itemfrom,Uprice,TranNo,TranDate,matid,Qty,slipNo,Rmk,Type)values('" + cboChal.Text.Trim() + "','" + cboItemFrom.Text.Trim() + "'," + txtUnitPrice.Text.Trim() + ",'" + cboTransactionId.Text.Trim() + "',convert(datetime,'" + Tdate + "',103),'" + txtMatId.Text.Trim() + "'," + txtQty.Text.Trim() + ",'" + txtChalan.Text.Trim() + "','" + txtRemarks.Text.Trim() + "','" + cbotype.Text.Trim() + "')";
                EditQry = "Update ProductInOutReturn set chalno='" + cboChal.Text.Trim() + "',itemfrom='" + cboItemFrom.Text.Trim() + "',uprice=" + txtUnitPrice.Text.Trim() + ",Qty=" + txtQty.Text.Trim() + ",TranDate =convert(datetime,'" + Tdate + "',103),SLipNo='" + txtChalan.Text.Trim() + "',Rmk='" + txtRemarks.Text.Trim() + "' where TranNo ='" + cboTransactionId.Text.Trim() + "' and MatId='" + txtMatId.Text.Trim() + "' and Type='" + cbotype.Text.Trim() + "'";

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


                if (cbotype.Text.Trim() == "IN")
                {
                    if (MessageBox.Show("Do You Want To Update Master Stock....?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string Qry;
                        Qry = "select materialid from Masterstock where materialid='" + txtMatId.Text.Trim() + "' and Grp='Maintenance'";
                        SvCls.toGetData(Qry);

                        if (SvCls.GblRdrToGetData.Read())
                        {
                            Qry = "Update Masterstock set Grp='Maintenance',Unitprice=" + Convert.ToDouble(txtUnitPrice.Text.Trim()) + ",materialName='" + cboMatName.Text.Trim() + "' ,TypeName='" + cbomattype.Text.Trim() + "',Unit='" + cboUnit.Text.Trim() + "' where materialid='" + txtMatId.Text.Trim() + "' and Grp='Maintenance'";
                            SvCls.insertUpdate(Qry);
                        }
                        else
                        {
                            Qry = "insert into Masterstock (Unitprice,materialid,materialName,TypeName,Unit,Grp) values(" + Convert.ToDouble(txtUnitPrice.Text.Trim()) + ",'" + txtMatId.Text.Trim() + "','" + cboMatName.Text.Trim() + "','" + cbomattype.Text.Trim() + "','" + cboUnit.Text.Trim() + "','Maintenance')";
                            SvCls.insertUpdate(Qry);
                        }
                    }
                }

                txtMatId_Leave(null,null );
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbotype.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Type ...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Qry1 = "select TranNo from ProductInOutReturn where  Type='" + cbotype.Text.Trim() + "' and isnumeric(TranNo)=1";
            if (SvCls.DataExist(Qry1) == "1")
            {
                SvCls.toGetData("select max(convert(int,TranNo))+1 as Tid from ProductInOutReturn where  isnumeric(TranNo)=1");
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboTransactionId.Text = SvCls.GblRdrToGetData["Tid"].ToString();
                    SvCls.GblCon.Close();
                    //cbotype.Text = "";
                    //cboTransactionId.Text = "";
                    txtMatId.Text = "";
                    txtQty.Text = "";
                    cboMatName.Text = "";
                    txtChalan.Text = "";
                    txtRemarks.Text = "";
                    cboUnit.Text = "";
                    txtUnitPrice.Text = "";
                    cbomattype.Text = "";
                    dtpTranDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    cboChal.Text = "";
                    cboItemFrom.Text = "";

                }
            }
            else
            {
                //cbotype.Text = "";
                //cboTransactionId.Text = "";
                txtMatId.Text = "";
                txtQty.Text = "";
                cboMatName.Text = "";
                txtChalan.Text = "";
                txtRemarks.Text = "";
                cboUnit.Text = "";
                txtUnitPrice.Text = "";
                cbomattype.Text = "";
                dtpTranDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cboChal.Text = "";
                cboItemFrom.Text = "";
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
                //if (cboTransactionId.Text.Trim() == "")
                //{
                //    return;
                //}

                //    string Qry = "select * from ProductInOutReturn where Rtranno ='" + cboTransactionId.Text.Trim() + "'";
                //    SvCls.toGetData(Qry);

                //    if (SvCls.GblRdrToGetData.Read())
                //    {
                //        DateTime Tdate = Convert.ToDateTime(SvCls.GblRdrToGetData["RTranDate"]);
                //        dtpTranDate.Text = Tdate.ToString();
                //        txtMatId.Text = SvCls.GblRdrToGetData["Rmatid"].ToString();
                //        txtQty.Text = SvCls.GblRdrToGetData["RQTY"].ToString();
                //        txtChalan.Text = SvCls.GblRdrToGetData["RChallanNo"].ToString();
                //        txtRemarks.Text = SvCls.GblRdrToGetData["RRmk"].ToString();
                //        SvCls.GblCon.Close();
                //    }
                //    else
                //    {
                //        dtpTranDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                //        txtMatId.Text = "";
                //        txtQty.Text = "";
                //        txtChalan.Text = "";
                //        txtRemarks.Text = "";
                //    }


            Heading();
         
          
            }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelItemInOutReturn == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbotype.Text.Trim() == "")
            {
                return;
            }

            if (cboTransactionId.Text.Trim() == "")
            {
                return;
            }

            string DeleteQry;
            string SelectQry;


                SelectQry = "select * from ProductInOutReturn where TranNo ='" + cboTransactionId.Text.Trim() + "' and MatId='" + txtMatId.Text.Trim() + "' and Type='" + cbotype.Text.Trim() + "'";
                DeleteQry = "delete  from ProductInOutReturn where TranNo =" + cboTransactionId.Text.Trim() + " and MatId='" + txtMatId.Text.Trim() + "' and Type='" + cbotype.Text.Trim() + "'";

                if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (SvCls.DataExist(SelectQry).ToString() == "1")
                    {
                        SvCls.insertUpdate(DeleteQry);
                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        PicSave.Visible = true;

                        txtMatId.Text = "";
                        txtQty.Text = "";
                        txtChalan.Text = "";
                        txtRemarks.Text = "";
                        cboUnit.Text = "";
                        txtUnitPrice.Text = "";
                        cbomattype.Text = "";
                        cboTransactionId.Text = "";
                        cboChal.Text = "";
                        cboItemFrom.Text = "";
                        dtpTranDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        Heading();
                    }


                txtMatId_Leave(null, null);
        }

           

       
        private void cboTransactionId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpTranDate.Select();
            }
        }
  


        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar.ToString() == "\b")
            //{
            //    e.Handled = false;
            //}
            //else if ((e.KeyChar < '0') || (e.KeyChar > '9')) e.Handled = true;

            if (e.KeyChar.ToString() == "\r")
            {
                cboUnit.Select();
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
                txtMatId.Select();
            }
        }



        private void frmProductInOutReturn_Load(object sender, EventArgs e)
        {
            if (ClsVar.GblFrmBackColor == "1")
            {
                ClsVar.BackPicPath = Application.StartupPath + "\\Pic\\" + "Back.jpg";
                this.BackgroundImage = new Bitmap(ClsVar.BackPicPath);

            }

            string Qry = "select materialid as mat  from masterstock Where Grp='Maintenance' order by convert(int,materialid)";
            txtMatId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            txtMatId.DisplayMember = "mat";
            txtMatId.Text = "";

            Qry = "select distinct materialName as mat  from masterstock Where Grp='Maintenance' order by mat";
            cboMatName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboMatName.DisplayMember = "mat";
            cboMatName.Text = "";

            //Qry = "select distinct typename as mat  from masterstock Where Grp='Maintenance' order by mat";
            //cbomattype.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            //cbomattype.DisplayMember = "mat";
            //cbomattype.Text = "";

            string QryM = "select DISTINCT TypeName as Mid  from MaterialType order by TypeName";
            cbomattype.DataSource = SvCls.GblDataSet(QryM).Tables[0];
            cbomattype.DisplayMember = "Mid";
            cbomattype.Text = "";

            Qry = "select distinct unit as mat  from masterstock Where Grp='Maintenance' order by mat";
            cboUnit.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboUnit.DisplayMember = "mat";
            cboUnit.Text = "";
            

            Heading();

        }

        private void cboMatName_Leave(object sender, EventArgs e)
        {
            if (cboMatName.Text.Trim() != "")
            {
                string Qry = "select Materialid,TypeName,Unit from Masterstock where  Materialname='" + cboMatName.Text.Trim() + "' and Grp='Maintenance'";
                SvCls.toGetData(Qry);

                if (SvCls.GblRdrToGetData.Read())
                {
                    txtMatId.Text = SvCls.GblRdrToGetData["materialid"].ToString();
                    cbomattype.Text = SvCls.GblRdrToGetData["TypeName"].ToString();
                    cboUnit.Text = SvCls.GblRdrToGetData["Unit"].ToString();


                }
                else
                {
                    if (txtAdd.Text == "1")
                    { return; }

                    txtMatId.Text = "";
                    cboUnit.Text = "";
                    cbomattype.Text = "";
                    MessageBox.Show("Invalid Material..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
           
        }



        private void cbotype_Leave(object sender, EventArgs e)
        {
            string Qry = "select DISTINCT TranNo from ProductInOutReturn where type='" + cbotype.Text.Trim() + "' ";///order by TranNo asc";
            cboTransactionId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboTransactionId.DisplayMember = "TranNo";
            cboTransactionId.Text = "";

            Qry = "select DISTINCT SlipNo from ProductInOutReturn where type='" + cbotype.Text.Trim() + "' ";///order by TranNo asc";
            txtChalan.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            txtChalan.DisplayMember = "SlipNo";
            txtChalan.Text = "";

            Qry = "select DISTINCT ChalNo from ProductInOutReturn where type='" + cbotype.Text.Trim() + "' ";///order by TranNo asc";
            cboChal.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboChal.DisplayMember = "ChalNo";
            cboChal.Text = "";

            dtpTranDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtMatId.Text = "";
            cboMatName.Text = "";
            txtQty.Text = "";
            txtChalan.Text = "";
            txtRemarks.Text = "";
            cboUnit.Text = "";
            txtUnitPrice.Text = "";
            cbomattype.Text = "";

            Heading();

 
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            if (cbotype.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Type ...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int i = Grid.SelectedCells[0].RowIndex;
            //cbotype.Text = Grid.Rows[i].Cells[0].Value.ToString();
            cboTransactionId.Text = Grid.Rows[i].Cells[0].Value.ToString();
            txtMatId.Text = Grid.Rows[i].Cells[2].Value.ToString();

            string Qry = "select * from ProductInOutReturn where tranno ='" + cboTransactionId.Text.Trim() + "'and matid='" + txtMatId.Text.Trim() + "' and type='" + cbotype.Text.Trim() + "'";
                SvCls.toGetData(Qry);

                if (SvCls.GblRdrToGetData.Read())
                {
                    DateTime Tdate = Convert.ToDateTime(SvCls.GblRdrToGetData["TranDate"]);
                    dtpTranDate.Text = Tdate.ToString();
                    txtMatId.Text = SvCls.GblRdrToGetData["matid"].ToString();
                    txtQty.Text = SvCls.GblRdrToGetData["QTY"].ToString();
                    txtChalan.Text = SvCls.GblRdrToGetData["SlipNo"].ToString();
                    txtUnitPrice.Text = SvCls.GblRdrToGetData["Uprice"].ToString();
                    txtRemarks.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                    cboChal.Text = SvCls.GblRdrToGetData["ChalNo"].ToString();
                    cboItemFrom.Text = SvCls.GblRdrToGetData["ItemFrom"].ToString();
                    SvCls.GblCon.Close();
                }
                else
                {
                    dtpTranDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    txtMatId.Text = "";
                    txtQty.Text = "";
                    txtChalan.Text = "";
                    txtRemarks.Text = "";
                    txtUnitPrice.Text = "";
                    cboChal.Text = "";
                    cboItemFrom.Text = "";
                }

                Qry = "select Materialname,TypeName,unit from Masterstock where  Materialid='" + txtMatId.Text.Trim() + "' and Grp='Maintenance'";
                SvCls.toGetData(Qry);

                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMatName.Text = SvCls.GblRdrToGetData["Materialname"].ToString();
                    cbomattype.Text = SvCls.GblRdrToGetData["TypeName"].ToString();
                    cboUnit.Text = SvCls.GblRdrToGetData["unit"].ToString();
                }
                else
                {
                    cboMatName.Text = "";
                    cbomattype.Text = "";
                    cboUnit.Text = "";
                    //MessageBox.Show("Invalid Material ID..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Heading();
        }



        private void cbotype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cboTransactionId.Select();
            }
        }

        private void dtpTranDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtChalan.Select();
            }
        }

        private void cboMatName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cbomattype.Select();
            }
        }

        private void txtMatId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
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


            if (cbotype.Text == "")
            {
                MessageBox.Show("Please Select Type ...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cboTransactionId.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{ProductInOutReturn.Tranno}='" + cboTransactionId.Text + "' and ";
            }

            if (cboMatName.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{MasterStock.MaterialName}='" + cboMatName.Text + "' and ";
            }


            if (cbomattype.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{MasterStock.TypeName}='" + cbomattype.Text + "' and ";
            }


            if (txtMatId.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{ProductInOutReturn.Matid}='" + txtMatId.Text + "' and ";
            }

            if (dtpFrom.Text == "  /  /" && dtpTo.Text == "  /  /")
            {
                MessageBox.Show("Please Select From Date & To Date ...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClsVar.GblSelFor = ClsVar.GblSelFor + "{ProductInOutReturn.type}='" + cbotype.Text + "' and ";

            ClsVar.GblSelFor = ClsVar.GblSelFor + "{ProductInOutReturn.tranDate}in Date(" + Convert.ToDateTime(dtpFrom.Text).Year.ToString() + "," + Convert.ToDateTime(dtpFrom.Text).Month.ToString() + "," + Convert.ToDateTime(dtpFrom.Text).Day.ToString() + ") to Date(" + Convert.ToDateTime(dtpTo.Text).Year.ToString() + "," + Convert.ToDateTime(dtpTo.Text).Month.ToString() + "," + Convert.ToDateTime(dtpTo.Text).Day.ToString() + ") ";
       
            if (cbotype.Text.Trim()=="IN")
            {
            ClsVar.GblRptHead = "Product In Information";
            ClsVar.GblHeadName = "Product IN Information";
            ClsVar.GblRptName = "ProductInMan.rpt";
            }

            if (cbotype.Text.Trim() == "OUT")
            {
                ClsVar.GblRptHead = "Product Out Information";
                ClsVar.GblHeadName = "Product Out Information";
                ClsVar.GblRptName = "ConsumptionMan.rpt";
            }

            if (cbotype.Text.Trim() == "RETURN")
            {
                ClsVar.GblRptHead = "Product Return Information";
                ClsVar.GblHeadName = "Product Return Information";
                ClsVar.GblRptName = "ProductReturnMan.rpt";
            }

            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void txtMatId_Leave(object sender, EventArgs e)
        {
            if (txtMatId.Text.Trim() != "")
            {
                string Qry = "select Materialname,TypeName,unit,unitprice from Masterstock where  Materialid='" + txtMatId.Text.Trim() + "' and Grp='Maintenance'";
                SvCls.toGetData(Qry);

                if (SvCls.GblRdrToGetData.Read())
                {
                    cboMatName.Text = SvCls.GblRdrToGetData["Materialname"].ToString();
                    cbomattype.Text = SvCls.GblRdrToGetData["TypeName"].ToString();
                    cboUnit.Text = SvCls.GblRdrToGetData["unit"].ToString();

                    if (cbotype.Text.Trim() == "OUT")
                    {
                        txtUnitPrice.Text = SvCls.GblRdrToGetData["unitprice"].ToString();
                    }
                    else
                    {
                        txtUnitPrice.Text = "";
                    }
                }
                else
                {
                    if (txtAdd.Text == "1")
                    { return; }

                    cboMatName.Text = "";
                    cbomattype.Text = "";
                    cboUnit.Text = "";
                    MessageBox.Show("Invalid Material ID..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                        double inQty = 0;
                        double outQty = 0;

                        SvCls.toGetData("SELECT isnull(sum(qty),0) as Bal From ProductInOutReturn  where type='in' and matid ='" + txtMatId.Text.Trim() + "'");
                        if (SvCls.GblRdrToGetData.Read())
                        {
                            inQty = Convert.ToDouble(SvCls.GblRdrToGetData["Bal"]);
                            SvCls.GblCon.Close();
                        }


                        SvCls.toGetData("SELECT isnull(sum(qty),0) as Bal From ProductInOutReturn  where type='OUT' And TranDate<convert(datetime,'" + dtpTranDate.Text + "',103) and matid ='" + txtMatId.Text.Trim() + "'");
                        if (SvCls.GblRdrToGetData.Read())
                        {
                            outQty = Convert.ToDouble(SvCls.GblRdrToGetData["Bal"]);
                            SvCls.GblCon.Close();
                        }

                        lebStock.Text = "Stock: " + (inQty - outQty).ToString();
                    }

        }

        private void cbomattype_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRemarks.Select();
            }
        }

        private void txtChalan_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtMatId.Select();
            }
        }

        private void btnIdAdd_Click(object sender, EventArgs e)
        {
            txtAdd.Text = "1";

            if (cbomattype.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Material Type.!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Qry = "select convert(numeric,materialid) from Masterstock where TypeName ='" + cbomattype.Text.Trim() + "'";
                if (SvCls.DataExist(Qry) == "1")
                {
                    SvCls.toGetData("select max(convert(numeric,materialid))+1 as Tid from Masterstock where TypeName ='" + cbomattype.Text.Trim() + "' and isnumeric(materialid)=1");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        txtMatId.Text = SvCls.GblRdrToGetData["Tid"].ToString();
                        SvCls.GblCon.Close();

                    }
                
                }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (cbomattype.Text.Trim() != "")
            {
                sql = sql + " and m.typename='" + cbomattype.Text.Trim() + "'";
            }

            if (txtMatId.Text.Trim() != "")
            {
                sql = sql + " and m.MaterialId='" + txtMatId.Text.Trim() + "'";
            }

            if (cbotype.Text.Trim() != "")
            {
                sql = sql + "  and p.Type ='" + cbotype.Text.Trim() + "'";
            }


            if (dtpFrom.Text != "  /  /" && dtpTo.Text != "  /  /")
            {
                sql = sql + " and P.tranDate between convert(datetime,'" + dtpFrom.Text + "',103) and convert(datetime,'" + dtpTo.Text + "',103) ";

            }


            Grid.DataSource = SvCls.GblDataTable("select p.TranNo,convert(varchar,p.TranDate,103) as TransactionDate,p.MatId,m.Materialname,m.TypeName,p.Qty,m.Unit,p.Type,p.UPrice,p.ChalNo,p.SlipNo,p.ItemFrom,p.Rmk from masterstock m, ProductInOutReturn p where m.MaterialId=p.MatId " + sql + " order by P.tranDate");/////convert(money,p.matid)") materialid<>'0'
            Grid.Refresh();

            lebTotRows.Text = "Total Rows: " + (Grid.Rows.Count - 1).ToString();
        }

        private void btnBlank_Click(object sender, EventArgs e)
        {
            cboChal.Text = "";
            cboItemFrom.Text = "";
            cbotype.Text = "";
            cboTransactionId.Text = "";
            txtMatId.Text = "";
            txtQty.Text = "";
            cboMatName.Text = "";
            txtChalan.Text = "";
            txtRemarks.Text = "";
            cboUnit.Text = "";
            txtUnitPrice.Text = "";
            cbomattype.Text = "";
            dtpTranDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpFrom.Text="  /  /";
            dtpTo.Text = "  /  /";
        }

        private void txtMatId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        

    }
}
