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
    public partial class frmClientInfo : Form
    {
        ClsMain SvCls = new ClsMain();
        public frmClientInfo()
        {
            InitializeComponent();

            this.Width = ClsVar.GblFormWidth;
            this.Height = ClsVar.GblFormHeight;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

             

        private void btnNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("select max(ClientID)+1 as Tid from ClientINfo where  isnumeric(ClientID)=1");
                    if (SvCls.GblRdrToGetData.Read())
                    {
                        cboID.Text = SvCls.GblRdrToGetData["Tid"].ToString();
                        SvCls.GblCon.Close();
                        cboName.Text = "";
                        txtAdd.Text = "";
                        txtPhone.Text = "";
                        txtEmail.Text = "";
                        txtRemarks.Text = "";

                    }
                    cboName.Select();

        }


        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Head()
        {
            Grid.DataSource = SvCls.GblDataTable("select * from ClientInfo Order By ClientName");
            Grid.Refresh();

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ClsVar.SaveClient  == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string SelectQry;
            string SaveQry;
            string EditQry;

            if (cboID.Text.Trim() == "")
            {
                return;
            }

            if (cboName.Text.Trim() == "")
            {
                return;
            }

            SelectQry = "select * from ClientInfo where ClientID =" + Convert.ToInt32(cboID.Text.Trim()) + "";
            SaveQry = "insert into ClientInfo(ClientID,ClientName,Address,Phone,Email,Rmk)values(" + Convert.ToInt32(cboID.Text.Trim()) + ",'" + cboName.Text.Trim() + "','" + txtAdd.Text.Trim() + "','" + txtPhone.Text.Trim() + "','" + txtEmail.Text.Trim() + "','" + txtRemarks.Text.Trim() + "')";
            EditQry = "Update ClientInfo set Address='" + txtAdd.Text.Trim() + "' ,Email='" + txtEmail.Text.Trim() + "', Phone='" + txtPhone.Text.Trim() + "',Rmk='" + txtRemarks.Text.Trim() + "' , ClientName ='" + cboName.Text.Trim() + "' where ClientID=" + Convert.ToInt32(cboID.Text.Trim()) + "";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                
                SvCls.insertUpdate(SaveQry);
                lblMgs.ForeColor = System.Drawing.Color.White;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Head();


            }
            else
            {


                SvCls.insertUpdate(EditQry);
                lblMgs.ForeColor = System.Drawing.Color.White;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;
                Head();
            }
            
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMgs.Visible = false;
            PicSave.Visible = false;
        }

        
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (ClsVar.DelClient == false)
            {
                MessageBox.Show("Access Denied...!!!", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                string DeleteQry;
                string SelectQry;

                if (cboID.Text.Trim() == "")
                {
                    return;
                }

                if (cboName.Text.Trim() == "")
                {
                    return;
                }

                SelectQry = "select * from ClientInfo where ClientID =" + Convert.ToInt32(cboID.Text.Trim()) + "";
                DeleteQry = "delete  from ClientInfo where ClientID =" + Convert.ToInt32(cboID.Text.Trim()) + "";

                if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (SvCls.DataExist(SelectQry).ToString() == "1")
                    {
                        SvCls.insertUpdate(DeleteQry);

                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        PicSave.Visible = true;

                        cboID.Text = "";
                        cboName.Text = "";
                        txtAdd.Text = "";
                        txtPhone.Text = "";
                        txtEmail.Text = "";
                        txtRemarks.Text = "";
                        Head();

                    }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSave.Select();
            }
        }

       
        private void frmClientInfo_Load(object sender, EventArgs e)
        {
            if (ClsVar.GblFrmBackColor == "1")
            {
                ClsVar.BackPicPath = Application.StartupPath + "\\Pic\\" + "Back.jpg";
                this.BackgroundImage = new Bitmap(ClsVar.BackPicPath);

            }
            string Qry = "select DISTINCT ClientName as Tid from ClientInfo order by ClientName asc";
            cboName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboName.DisplayMember = "Tid";
            cboName.Text = "";

            string Qry1 = "Select ClientID from ClientInfo order by convert(money,ClientID) ";
            cboID.DataSource = SvCls.GblDataSet(Qry1).Tables[0];
            cboID.DisplayMember = "ClientID";
            cboID.Text = "";

            Head();

        }



        private void Grid_DoubleClick(object sender, EventArgs e)
        {


            

            int i = Grid.SelectedCells[0].RowIndex;
            cboID.Text = Grid.Rows[i].Cells[0].Value.ToString();

            string Qry = "select * from ClientInfo where ClientID = " + Convert.ToInt32(cboID.Text.Trim()) + "";
            SvCls.toGetData(Qry);

            if (SvCls.GblRdrToGetData.Read())
            {
                cboName.Text = SvCls.GblRdrToGetData["ClientName"].ToString();
                txtAdd.Text = SvCls.GblRdrToGetData["Address"].ToString();
                txtPhone.Text = SvCls.GblRdrToGetData["Phone"].ToString();
                txtEmail.Text = SvCls.GblRdrToGetData["Email"].ToString();
                txtRemarks.Text = SvCls.GblRdrToGetData["Rmk"].ToString();

                SvCls.GblCon.Close();

            }

            else
            {
                cboName.Text = "";
                txtAdd.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtRemarks.Text = "";

            }

            if (chkDouble.Checked == true)
            {
            string DeleteQry = "delete  from ClientInfo where ClientID =" + Convert.ToInt32(cboID.Text.Trim()) + "";
            SvCls.insertUpdate(DeleteQry);

            lblMgs.Visible = true;
            }
            //Head();

        }


        private void BtnReport_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboID.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{ClientInfo.ClientID}=" + Convert.ToInt32(cboID.Text.Trim()) + "";
            }

            ClsVar.GblHeadName = "Client Information";
            ClsVar.GblRptName = "ClientInfo.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

        private void cboID_Leave(object sender, EventArgs e)
        {
            if (cboID.Text.Trim() == "")
            {
                return;
            }

            string Qry = "select * from ClientInfo where ClientID =" + Convert.ToInt32(cboID.Text.Trim()) + "";
            SvCls.toGetData(Qry);

            if (SvCls.GblRdrToGetData.Read())
            {
                cboName.Text = SvCls.GblRdrToGetData["ClientName"].ToString();
                txtAdd.Text = SvCls.GblRdrToGetData["Address"].ToString();
                txtPhone.Text = SvCls.GblRdrToGetData["Phone"].ToString();
                txtEmail.Text = SvCls.GblRdrToGetData["Email"].ToString();
                txtRemarks.Text = SvCls.GblRdrToGetData["Rmk"].ToString();

                SvCls.GblCon.Close();

            }

            else
            {
                cboName.Text = "";
                txtAdd.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtRemarks.Text = "";

            }
        }

        private void cboName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtAdd.Select();
            }
        }

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtPhone.Select();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtEmail.Select();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtRemarks.Select();
            }
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCPRpt_Click(object sender, EventArgs e)
        {
            ClsVar.GblHeadName = "";
            ClsVar.GblRptName = "";
            ClsVar.GblSelFor = "";

            if (cboName.Text != "")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Orderdetails.Client}='" + cboName.Text + "'and ";
            }

            if (dtpFrom.Text != "  /  /" && dtpTo.Text != "  /  /")
            {
                ClsVar.GblSelFor = ClsVar.GblSelFor + "{Orderdetails.OrderDate}in Date(" + Convert.ToDateTime(dtpFrom.Text).Year.ToString() + "," + Convert.ToDateTime(dtpFrom.Text).Month.ToString() + "," + Convert.ToDateTime(dtpFrom.Text).Day.ToString() + ") to Date(" + Convert.ToDateTime(dtpTo.Text).Year.ToString() + "," + Convert.ToDateTime(dtpTo.Text).Month.ToString() + "," + Convert.ToDateTime(dtpTo.Text).Day.ToString() + ") ";

            }

     

            ClsVar.GblHeadName = "Productions Information Of  Client";
            ClsVar.GblRptName = "ClientDelivery.rpt";
            frmReport Rpt = new frmReport();
            Rpt.Show();
        }

 



    }
}
