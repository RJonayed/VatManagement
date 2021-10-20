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
    public partial class CashEntry : Form
    {
        ClsMain SvCls = new ClsMain();
        string Qry = "";
        DateTime TDate = DateTime.Today;

        Int32 TotalCollection = 0;
        Int32 TotalPay = 0;
        Int32 TotalBal = 0;
        public CashEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CboType.Text == "")
            {
                MessageBox.Show("Please, Select Payment Type", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CboType.Select();
                return;
            }

            if (txtAmount.Text == "")
            {
                MessageBox.Show("Amount can not be empty.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Select();
                return;
            }
            Qry = "UPDATE DailyCash SET EntDate = convert(datetime,'"+ TDate +"',103), Type = '" + CboType.Text.Trim() +"', Des = '"+ CboDescription.Text.Trim() +"', Amount = "+ txtAmount.Text.Trim() +" WHERE Sl = '"+ CboSl.Text.Trim() +"'";
            SvCls.insertUpdate(Qry);

            //Message
            BtnNew.Select();
            lblMsg.Visible = true;
            lblMsg.ForeColor = Color.Green;
            lblMsg.Text = "Save Successfully";

            CboSl.Enabled = true;
            GridData();
            Cal();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Qry = "DELETE FROM DailyCash WHERE Type='' AND ComId = '"+ ClsVar.GblComId +"' and UserCode = '"+ ClsVar.GblUserId +"'";
            SvCls.insertUpdate(Qry);

            Qry = "SELECT IsNull(MAX(SL)+1,100) as SlNo FROM DailyCash";
            SvCls.toGetData(Qry);
            if (SvCls.GblRdrToGetData.Read())
            {
                CboSl.Text = SvCls.GblRdrToGetData["SlNo"].ToString();
            }

            Qry = "INSERT INTO DailyCash (Sl, UserCode, PcName, ComId) VALUES ('"+ CboSl.Text.Trim() +"','"+ ClsVar.GblUserId +"','"+ ClsVar.GblPcName +"','"+ ClsVar.GblComId +"')";
            SvCls.insertUpdate(Qry);


            CboType.Select();
            CboSl.Enabled = false;
            BtnSave.Enabled = true;

            CboDescription.Text = "";
            txtAmount.Text = "";
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtAmount.Select();
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                BtnSave.Select();
            }
        }

        private void CboType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                CboDescription.Select();
                
            }
        }

        private void CboDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                txtAmount.Select();

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblMsg.ForeColor = Color.Red;
            lblMsg.Visible = false;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? \r You want to delete this entry.!", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Qry = "DELETE FROM DailyCash Where Sl = '" + CboSl.Text.Trim() + "'";
                SvCls.insertUpdate(Qry);

                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Delete Successfully";
                lblMsg.Visible = true;
            }

            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            BtnNew.Select();
            Cal();
            GridData();
        }

        private void Clear()
        {
            CboSl.Text = "";
            CboType.Text = "";
            CboDescription.Text = "";
            txtAmount.Text = "";
            BtnNew.Select();
        }

        private void CashEntry_Load(object sender, EventArgs e)
        {
            Qry = "SELECT Sl FROM DailyCash where comid='" + ClsVar.GblComId + "' and EntDate=convert(datetime,'"+ TDate +"',103)";
            CboSl.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboSl.DisplayMember = "Sl";
            CboSl.Text = "";


            BtnSave.Enabled = false;
            GridData();
            Cal();
        }

        private void Cal()
        {
            Qry = "SELECT CAST(isNull(SUM(Amount),0) as DECIMAL (10,0)) AS [TotCol] FROM DailyCash WHERE Type = 'Collection' and EntDate = convert(datetime,'" + TDate + "',103)";
            SvCls.toGetData(Qry);
            if(SvCls.GblRdrToGetData.Read())
            {
                TotalCollection = Convert.ToInt32(SvCls.GblRdrToGetData["TotCol"].ToString());
                lblTotCol.Text = "Total Collection : " + TotalCollection;
            }

            Qry = "SELECT CAST(isNull(SUM(Amount),0) as DECIMAL (10,0)) AS [TotPay] FROM DailyCash WHERE Type = 'Payment' and EntDate = convert(datetime,'" + TDate + "',103)";
            SvCls.toGetData(Qry);
            if (SvCls.GblRdrToGetData.Read())
            {
                TotalPay = Convert.ToInt32(SvCls.GblRdrToGetData["TotPay"].ToString());
                lblTotPay.Text = "Total Payment : " + TotalPay;
            }

            TotalBal = Convert.ToInt32(Convert.ToInt32(TotalCollection) - Convert.ToInt32(TotalPay));
            lblCashBal.Text = "Cash Balance : " + TotalBal;

            DailyCashMstr();

            if (TotalBal < 0)
            {
                lblCashBal.BackColor = Color.Red;
            }
            else { lblCashBal.BackColor = Color.LimeGreen; }
        }

        private void DailyCashMstr()
        {
            Qry = "SELECT * FROM DailyCashMstr WHERE CashDate = convert(datetime,'" + TDate +"',103)";
            SvCls.toGetData(Qry);
            if (SvCls.GblRdrToGetData.Read())
            {
                Qry = "UPDATE DailyCashMstr SET CashDate =convert(datetime,'" + TDate + "',103), TotCol =" + TotalCollection + ", TotPay=" + TotalPay + ", CashBal=" + TotalBal + ", ComId='" + ClsVar.GblComId + "'";
                SvCls.insertUpdate(Qry);
            }
            else
            {
                Qry = "INSERT INTO DailyCashMstr (CashDate, TotCol, TotPay, CashBal, ComId) VALUES (convert(datetime,'" + TDate + "',103)," + TotalCollection + "," + TotalPay + "," + TotalBal + ",'" + ClsVar.GblComId + "')";
                SvCls.insertUpdate(Qry);
            }
            
        }

        private void GridData()
        {
            Qry = "SELECT Sl as Serial, EntDate as Date, Des as Description, cast(Amount as decimal (10,0)) as Amount, Type as Type, EntryTime as [Entry Time] FROM DailyCash WHERE EntDate = convert(datetime,'"+ TDate +"',103) Order By Sl DESC";
            Grid.DataSource = SvCls.GblDataTable(Qry);
            Grid.Refresh();

            DataGridViewColumn column = Grid.Columns[0];
            column.Width = 50;

            column = Grid.Columns[1];
            column.Width = 100;

            column = Grid.Columns[2];
            column.Width = 470;

            column = Grid.Columns[3];
            column.Width = 80;
            
            column = Grid.Columns[4];
            column.Width = 90;

            column = Grid.Columns[5];
            column.Width = 150;
            
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CboSl_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void CboSl_Leave(object sender, EventArgs e)
        {
            Qry = "SELECT Type, Des, cast(Amount as decimal (10,0)) as Amount FROM DailyCash WHERE Sl='" + CboSl.Text.Trim() + "' and EntDate = convert(datetime,'" + TDate + "',103)";
            SvCls.toGetData(Qry);
            if (SvCls.GblRdrToGetData.Read())
            {
                CboType.Text = SvCls.GblRdrToGetData["Type"].ToString();
                CboDescription.Text = SvCls.GblRdrToGetData["Des"].ToString();
                txtAmount.Text = SvCls.GblRdrToGetData["Amount"].ToString();

                BtnDel.Enabled = true;
                BtnSave.Enabled = true;
            }
            else
            {

            }
        }

        private void CboSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                txtAmount.Select();
                CboSl_Leave(null, null);
            }
        }
    }
}
