using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace HRM
{
    public partial class frmOTEditInfo : Form
    {
        ClsMain SvCls = new ClsMain();

        //PropertyPage pp = new PropertyPage();

        //create an Serial Port object
        SerialPort sp = new SerialPort();
        //variables for storing values of baud rate and stop bits
        string baudR = "";
        string stopB = "";


        public frmOTEditInfo()
        {
            InitializeComponent();

            this.Width = ClsVar.GblFormWidth;
            this.Height = ClsVar.GblFormHeight;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public string bRate
        {
            get
            {
                return baudR;
            }
            set
            {
                baudR = value;
            }
        }

        public string sBits
        {
            get
            {
                return stopB;
            }
            set
            {
                stopB = value;
            }
        }

             

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                //clear the text box
                textBox.Text = "";
                //read serial port and displayed the data in text box
                textBox.Text = sp.ReadLine();
            }
            catch (System.Exception ex)
            {
                baudRatelLabel.Text = ex.Message;
            }

        }


        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Head()
        {
            Grid.DataSource = SvCls.GblDataTable("select o.empid,e.name,o.attndate,o.ad,o.ded from OTEdit o,employee e where e.empid=o.empid and  o.attndate =convert(datetime,'" + dtpDate.Text + "',103)");
            Grid.Refresh();

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            

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

                string DeleteQry;
                string SelectQry;

                if (cboEmpID.Text.Trim() == "")
                {
                    return;
                }

                SelectQry = "select * from OTEdit where EmpID ='" + cboEmpID.Text.Trim() + "' and AttnDate=convert(datetime,'" + dtpDate.Text + "',103)";
                DeleteQry = "delete  from OTEdit where EmpID ='" + cboEmpID.Text.Trim() + "' and AttnDate=convert(datetime,'" + dtpDate.Text + "',103)";
                if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (SvCls.DataExist(SelectQry).ToString() == "1")
                    {
                        SvCls.insertUpdate(DeleteQry);

                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        PicSave.Visible = true;

                        cboEmpID.Text = "";
                        textBox.Text = "";
                        txtDed.Text = "";
                        dtpDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        Head();

                    }

      }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            int i = Grid.SelectedCells[0].RowIndex;
            cboEmpID.Text = Grid.Rows[i].Cells[0].Value.ToString();
            dtpDate.Text = Grid.Rows[i].Cells[2].Value.ToString();
            textBox.Text = Grid.Rows[i].Cells[3].Value.ToString();
            txtDed.Text = Grid.Rows[i].Cells[4].Value.ToString();
            chkOtDel.Checked = false;
        }


        private void BtnReport_Click(object sender, EventArgs e)
        {
            //ClsVar.GblHeadName = "";
            //ClsVar.GblRptName = "";
            //ClsVar.GblSelFor = "";

            //if (cboEmpID.Text != "")
            //{
            //    ClsVar.GblSelFor = ClsVar.GblSelFor + "{OTEdit.ClientID}=" + Convert.ToInt32(cboEmpID.Text.Trim()) + "";
            //}

            //ClsVar.GblHeadName = "Client Information";
            //ClsVar.GblRptName = "OTEdit.rpt";
            //frmReport Rpt = new frmReport();
            //Rpt.Show();
        }
                    

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtDed.Select();
            }
        }

        private void cboEmpID_Leave(object sender, EventArgs e)
        {
            try
            {
                cboEmpID.Text = cboEmpID.Text.Substring(0, cboEmpID.Text.IndexOf("~"));
            }
            catch
            {

            }
            chkOtDel.Checked=false ;
        }


        private void frmOTEditInfo_Load(object sender, EventArgs e)
        {
            if (ClsVar.GblFrmBackColor == "1")
            {
                ClsVar.BackPicPath = Application.StartupPath + "\\Pic\\" + "Back.jpg";
                this.BackgroundImage = new Bitmap(ClsVar.BackPicPath);

            }

            string Qry = "Select EmpId+'~'+name as emp from Employee  Order by EmpId";
            cboEmpID.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboEmpID.DisplayMember = "emp";
            cboEmpID.Text = "";

            Head();

        }
              
       

        private void dtpDate_Leave(object sender, EventArgs e)
        {
            Head();
            
        }


        private void Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            do
            {
                string qry = "update OTEdit set Ad=" + Convert.ToDouble(Grid.Rows[i].Cells[3].Value) + ",Ded=" + Convert.ToDouble(Grid.Rows[i].Cells[4].Value) + " where empid=" + Convert.ToDouble(Grid.Rows[i].Cells[0].Value) + " and AttnDate=convert(datetime,'" + dtpDate.Text + "',103)";
                SvCls.insertUpdate(qry);
                i = i + 1;
            } while (i < Grid.Rows.Count);
            Head();
        }

        private void chkOtDel_Click(object sender, EventArgs e)
        {

            if (cboEmpID.Text.Trim() == "")
            {
                return;
            }

            string DeleteQry = "delete  from OTEdit where EmpID ='" + cboEmpID.Text.Trim() + "' and AttnDate=convert(datetime,'" + dtpDate.Text + "',103)";
            SvCls.insertUpdate(DeleteQry);

            Head();
            chkOtDel.Checked = false;

        }

        private void btnAttnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                //write line to serial port
                sp.WriteLine(textBox.Text);
                //clear the text box
                textBox.Text = "";
            }
            catch (System.Exception ex)
            {
                baudRatelLabel.Text = ex.Message;
            }



        }









    }
}
