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
    public partial class frmDailyRecord : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        string SecCode = "";

        public frmDailyRecord()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDailyRecord_Load(object sender, EventArgs e)
        {
            string Qry = "Select SlNo from DailyRecord";
            cboSlNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSlNo.DisplayMember = "SlNo";
            cboSlNo.Text = "";

            Qry = "select EmpId from Employee where comid='" + ClsVar.GblComId + "'";
            cboEmpId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboEmpId.DisplayMember = "EmpId";
            cboEmpId.Text = "";

            Qry = "Select Name from SectionTbl";
            CboSecName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboSecName.DisplayMember = "Name";
            CboSecName.Text = "";       

            CmdAddNew.Select();

            Grid_Head();
        }

        private void Grid_Head()
        {
            Grid.DataSource = SvCls.GblDataTable("Select SlNo as[SL No],EmpId as[Employee ID],Note,SectionCode as[Section Name],AttnDate as[Attendance Date] from DailyRecord");
            Grid.Refresh();
        }
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (cboSlNo.Text.Trim() == "")
            {
                MessageBox.Show("Not Saved....!! \rPlease Insert Kromic NO...!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSlNo.Select();
                return;
            }

            if (MessageBox.Show("Do you realy want to delete ?", "Powerpoint Technologies.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                SvCls.insertUpdate("Delete from DailyRecord where SlNo='" + cboSlNo.Text.Trim() + "' and ComId='" + ClsVar.GblComId + "'");
                lblMgs.ForeColor = System.Drawing.Color.Red;
                lblMgs.Visible = true;
                lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Grid_Head();

                cboSlNo.Focus();

            }
        }
      
        private void cmdSave_Click(object sender, EventArgs e)
        {          
                SvCls.toGetData("Select SectionCode from SectionTbl where Name ='Accounts'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    SecCode = SvCls.GblRdrToGetData["SectionCode"].ToString();             
                }
               

            if (cboEmpId.Text.Trim() == "")
            {
                MessageBox.Show("Kromic NO Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboEmpId.Select();
                return;
            }

            if (txtNote.Text.Trim() == "")
            {
                MessageBox.Show("Institute Name Can't Blank", "Powerpoint Technologies", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtNote.Select();
                return;
            }

            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert into DailyRecord(SlNo,EmpId,Note,SectionCode,AttnDate,UserId,PcName,ComId)values(" + cboSlNo.Text.Trim() + ",'" + cboEmpId.Text.Trim() + "','" + txtNote.Text.Trim() + "','" + SecCode + "',convert(datetime,('" + dtpAttn.Text.Trim() + "'),103),'" + ClsVar.GblUserId + "','" + ClsVar.GblPcName + "','" + ClsVar.GblComId + "')";
            SelectQry = "Select EmpId,Note,SectionCode,AttnDate,UserId,PcName,ComId from DailyRecord where SlNo=" + cboSlNo.Text.Trim() + "";
            EdtQry = "Update DailyRecord Set EmpId=" + cboEmpId.Text.Trim() + ",Note='" + txtNote.Text.Trim() + "',SectionCode='" + SecCode + "',AttnDate=Convert(datetime,'" + dtpAttn.Text.Trim() + "',103),UserId='" + ClsVar.GblUserId + "',PcName='" + ClsVar.GblPcName + "',ComId='" + ClsVar.GblComId + "' where SlNo=" + cboSlNo.Text.Trim() + "";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {

                SvCls.insertUpdate(SaveQry);
                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Grid_Head();

                cboEmpId.Focus();

            }

            else

            {
                SvCls.insertUpdate(EdtQry);
                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;

                cmdSave.Text = "Save";

                cboEmpId.Focus();

                 Grid_Head();
            }
        }

        private void cboEmpId_Leave(object sender, EventArgs e)
        {
            if (cboEmpId.Text.Trim() != "")
            {
                SvCls.toGetData("select e.Name + '       DOJ: ' + convert(varchar,joindate,103) + '        Desg: ' +d.name as empName,e.empAutoNo from employee e,designation d where e.designationCode=d.designationCode and e.empid='" + cboEmpId.Text.Trim() + "' and e.comid='" + ClsVar.GblComId + "'");
                if (SvCls.GblRdrToGetData.Read())
                {
                    lebName.Visible = true;
                    lebName.Text = SvCls.GblRdrToGetData["empName"].ToString();
                    ClsVar.empAutoNo = Convert.ToInt32(SvCls.GblRdrToGetData["empAutoNo"].ToString());
                }
                else
                {
                    lebName.Visible = false;
                }               
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            lebName.Visible = false;

            try
            {
                int i = Grid.SelectedCells[0].RowIndex;
                cboSlNo.Text = Grid.Rows[i].Cells[0].Value.ToString();
                cboEmpId.Text = Grid.Rows[i].Cells[1].Value.ToString();
                txtNote.Text = Grid.Rows[i].Cells[2].Value.ToString();
                CboSecName.Text = Grid.Rows[i].Cells[3].Value.ToString();
                dtpAttn.Text = Grid.Rows[i].Cells[4].Value.ToString();

                cboEmpId_Leave(null, null);
                //cboAdvanceNo_LostFocus(null, null);               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cboSlNo.Text = "";
            cboEmpId.Text = "";
            txtNote.Text = "";
            CboSecName.Text = "";
        }

        private void cboEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() =="\r")
            {
                txtNote.Select();
            }
        }

        private void txtNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                CboSecName.Select();
            }
        }

        private void CboSecName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpAttn.Select();
            }
        }

        private void dtpAttn_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void dtpAttn_KeyPress(object sender, KeyPressEventArgs e)
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
                CmdAddNew.Select();
            }
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            SvCls.toGetData("Select isnull(Max(SlNo)+1,100) as Code from DailyRecord");

            if (SvCls.GblRdrToGetData.Read())
            {
                cboSlNo.Text = SvCls.GblRdrToGetData["Code"].ToString();
                SvCls.GblCon.Close();
            }
            cmdSave.Text = "Save";

            cboEmpId.Text = "";
            txtNote.Text = "";
            CboSecName.Text = "";
            dtpAttn.Text = "";

            Grid_Head();
        }

        private void cboSlNo_Leave(object sender, EventArgs e)
        {
            if (cboSlNo.Text.Trim() != "")
            {
                SvCls.toGetData("Select EmpId,Note,SectionCode,AttnDate from DailyRecord  where SlNo=" + cboSlNo.Text.Trim() + " ");
                if (SvCls.GblRdrToGetData.Read())
                {
                    lebName.Visible = true;
                    cboEmpId.Text = SvCls.GblRdrToGetData["EmpId"].ToString();
                    txtNote.Text = SvCls.GblRdrToGetData["Note"].ToString();
                    CboSecName.Text = SvCls.GblRdrToGetData["SectionCode"].ToString();
                    dtpAttn.Text = SvCls.GblRdrToGetData["AttnDate"].ToString();                   
                }
                else
                {
                    lebName.Visible = false;
                }
            }
        }
    }
}
