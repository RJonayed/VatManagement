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
    public partial class WarrantyCheck : Form
    {

        ClsMain SvCls = new ClsMain();

        string qry = "";
        int dateadd = 0;
        
        public WarrantyCheck()
        {
            InitializeComponent();
        }

        private void btnCheckWarraty_Click(object sender, EventArgs e)
        {
            if(txtProductSerial.Text == "")
            {
                MessageBox.Show("Enter Product Serial", "POWERPOINT TECHNOLOGIES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductSerial.Select();
                return;
            }

            qry = "SELECT InvoiceNo, SaleDate, Warranty, WarType FROM Sale WHERE PrSlNo = '"+ txtProductSerial.Text.Trim() +"'";
            SvCls.toGetData(qry);
            if(SvCls.GblRdrToGetData.Read())
            {
                txtInvoiceNo.Text = SvCls.GblRdrToGetData["InvoiceNO"].ToString();
                dtpSaleDate.Text = SvCls.GblRdrToGetData["SaleDate"].ToString();
                txtWarranty.Text = SvCls.GblRdrToGetData["Warranty"].ToString();
                dateadd = Convert.ToInt32(SvCls.GblRdrToGetData["Warranty"].ToString());

                string Countqry = "SELECT DATEADD(dd," + dateadd + ", CONVERT(DATETIME,'" + dtpSaleDate.Value.ToString("dd/MM/yyyy") + "',103)) as EndDate";
                SvCls.toGetData(Countqry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    dtpEndDate.Text = SvCls.GblRdrToGetData["EndDate"].ToString();

                    if (Convert.ToDateTime(dtpEndDate.Text) >= Convert.ToDateTime(dtpToday.Text))
                    {
                        this.BackColor = Color.Green;
                        lblMessage.Text = "Warranty Available..!";
                        lblMessage.BackColor = Color.DarkBlue;
                        lblMessage.ForeColor = Color.Lime;
                        lblMessage.Visible = true;
                        lblColor();
                    }
                    else
                    {
                        this.BackColor = Color.Red;
                        lblMessage.Text = "Warranty Expired..!";
                        lblMessage.BackColor = Color.DarkBlue;
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Visible = true;
                        lblColor();
                    }
                }
                else
                {
                    txtInvoiceNo.Text = "";
                    dtpSaleDate.Value = DateTime.Today;
                    dtpEndDate.Value = DateTime.Today;
                    txtWarranty.Text = "";
                    dtpToday.Value = DateTime.Today;
                }
            }
            else
            {
                lblMessage.Text = "You Enter a Wrong Serial..!";
                lblMessage.BackColor = Color.LightCoral;
                lblMessage.Visible = true;
            }
        }

        private void WarrantyCheck_Load(object sender, EventArgs e)
        {
            dtpToday.Value = DateTime.Today;
        }

        private void txtProductSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "\r")
            {
                btnCheckWarraty_Click(null, null);
            }
        }

        private void lblColor()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
        }
    }
}
