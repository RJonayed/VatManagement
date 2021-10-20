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
    public partial class frmTimeGroup : Form
    {

     //---------------------- inheritenc class ------------------------------
        ClsMain svcls = new ClsMain();

        public frmTimeGroup()
        {
            InitializeComponent();
        }

 //--------------------------------  Form Load     ----------------------

        private void frmTimeGroup_Load(object sender, EventArgs e)
        {
            ClsVar.BackPicPath = Application.StartupPath + "\\Pic\\" + "Back.jpg";
            this.BackgroundImage = new Bitmap(ClsVar.BackPicPath);

            string qry;



            qry = "Select  convert(varchar,groupid)+'~'+groupname as gid from timeGroup where comid ='" + ClsVar.GblComId + "' Order by groupid";


            cbogrpno.DataSource = svcls.GblDataSet(qry).Tables[0];
            cbogrpno.DisplayMember = "gid";
            cbogrpno.Text = "";

            string qry1 = "select groupname as gname from timeGroup  where comid ='" + ClsVar.GblComId + "'Order by groupid";
            cbogname.DataSource = svcls.GblDataSet(qry1).Tables[0];
            cbogname.DisplayMember = "gname";
            cbogname.Text = "";

            Grid();


        }
//-------------------------------------- exit -------------------------

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//---------------------------------  show grid ------------------------
        private void Grid()
        {

            string qry = "select groupid,groupname,Namerpt,Intime,Outtime,MaxIntime,SetupDate,OTEnd,maxot from timeGroup where comid='" + ClsVar.GblComId +  "'";
            Gridtgrp.DataSource = svcls.GblDataTable(qry);

        }
//--------------------------- Data Save --------------------

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string SaveQry;
            string SelectQry;
            string EdtQry;


            SaveQry = "insert into timeGroup (groupid,groupname,Namerpt,Intime,Outtime,MaxInTime,SetupDate,OTEnd,maxot,comid,PcName,UserCode) values (" + cbogrpno.Text.Trim() + ",'" + cbogname.Text.Trim() + "','" + txtrpt.Text.Trim() + "',convert(datetime,'" + this.dtpintime.Value.ToString("HH:mm:ss") + "',108),convert(datetime,'" + this.dtpouttime.Value.ToString("HH:mm:ss") + "',108),convert(datetime,'" + this.dtpmaxintime.Value.ToString("HH:mm:ss") + "',108),convert(datetime,'" + this.dtpsdate.Value.ToString("dd/MM/yyyy") + "',103),convert(datetime,'" + this.dtpotend.Value.ToString("HH:mm:ss") + "',108)," + txtmaxot.Text.Trim() + ",'" + ClsVar.GblComId  + "','" + ClsVar.GblPcName  + "','" + ClsVar.GblUserId + "')";
            SelectQry = "select * from timeGroup where comid='"+ClsVar.GblComId +"' and  setupdate =convert(datetime,'" + dtpsdate.Text + "',103)and groupid=" + cbogrpno.Text;
            EdtQry = "update timeGroup set groupname='" + cbogname.Text + "',Namerpt='" + txtrpt.Text + "', Intime=convert(datetime,'" + this.dtpintime.Value.ToString("HH:mm:ss") + "',108),outtime =convert(datetime,'" + this.dtpouttime.Value.ToString("HH:mm:ss") + "',108),MaxIntime =convert(datetime,'" + this.dtpmaxintime.Value.ToString("HH:mm:ss") + "',108),setupdate =convert(datetime,'" + this.dtpsdate.Value.ToString("dd/MM/yyyy") + "',103),OTEnd= convert(datetime,'" + this.dtpotend.Value.ToString("HH:mm:ss") + "',103),maxot=" + txtmaxot.Text + ",comid='"+ ClsVar.GblComId  +"',PcName='"+ ClsVar.GblPcName  +"', UserCode ='" + ClsVar.GblUserId  + "' where comid ='" + ClsVar.GblComId + "' and groupid=" + cbogrpno.Text;

            if (svcls.DataExist(SelectQry).ToString() == "0")
            {

                svcls.insertUpdate(SaveQry);

                label10.Visible = true;
                label10.Text = "Save Successfully";


            }
            else
            {


                svcls.insertUpdate(EdtQry);
                label10.Visible = true;
                label10.Text = "Edited Successfully";



            }

            Grid();
           



        }
//---------------------------- cbogrpno lostfocus -------------------

        private void cbogrpno_lostfocus(object sender, EventArgs e)
        {
            //this try is use to avoid error msg
            try
            {
                cbogrpno.Text = cbogrpno.Text.Substring(0, cbogrpno.Text.IndexOf("~"));
            }
            catch
            {
 
            }
            //end of try

            try
            {
                

                string selectQry;

                selectQry = "select * from timeGroup where setupdate =convert(datetime,'" + dtpsdate.Text + "',103)and comid ='" + ClsVar.GblComId + "' groupid=" + cbogrpno.Text;


                if (svcls.DataExist(selectQry) == "1")
                {
                    svcls.toGetData("select groupname,Namerpt,Intime,Outtime,MaxInTime,SetupDate,OTEnd,maxot from timeGroup where comid ='" + ClsVar.GblComId + "'setupdate =convert(datetime,'" + dtpsdate.Text + "',103) and groupid=" + cbogrpno.Text + "");
                    if (svcls.GblRdrToGetData.Read())
                    {
                        cbogname.Text = svcls.GblRdrToGetData["groupname"].ToString();
                        txtrpt.Text = svcls.GblRdrToGetData["Namerpt"].ToString();
                        dtpintime.Text = svcls.GblRdrToGetData["Intime"].ToString();
                        dtpouttime.Text = svcls.GblRdrToGetData["Outtime"].ToString();
                        dtpmaxintime.Text = svcls.GblRdrToGetData["MaxInTime"].ToString();
                        dtpsdate.Text = svcls.GblRdrToGetData["SetupDate"].ToString();
                        dtpotend.Text = svcls.GblRdrToGetData["OTEnd"].ToString();
                        txtmaxot.Text = svcls.GblRdrToGetData["maxot"].ToString();
                        svcls.GblCon.Close();
                    }
                }

                else
                {
                    cbogname.Text = "";
                    txtrpt.Text = "";
                    dtpintime.Text = DateTime.Now.ToString ("HH:mm:ss");
                    dtpouttime.Text =DateTime.Now.ToString("HH:mm:ss");
                    dtpmaxintime.Text =DateTime.Now.ToString("HH:mm:ss");
                    dtpsdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    dtpotend.Text = DateTime.Now.ToString("HH:mm:ss");
                    txtmaxot.Text = "";
                    svcls.GblCon.Close();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        
        
        
        }
//--------------------- data delete ------------------------------

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string deleteQry;
            string selectQry;


            selectQry = "select * from timeGroup where setupdate =convert(datetime,'" + dtpsdate.Text + "',103)and comid ='" + ClsVar.GblComId + "'and groupid=" + cbogrpno.Text;
            deleteQry = "delete from timeGroup where setupdate =convert(datetime,'" + dtpsdate.Text + "',103) and groupid=" + cbogrpno.Text;


            if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)


                if (svcls.DataExist(selectQry) == "1")
                {

                    svcls.insertUpdate(deleteQry);
                    label10.Visible = true;
                    label10.Text = "Delete Successfully";
                    cbogname.Text = "";
                    txtrpt.Text = "";
                    dtpintime.Text = DateTime.Now.ToString("HH:mm:ss");
                    dtpouttime.Text = DateTime.Now.ToString("HH:mm:ss");
                    dtpmaxintime.Text = DateTime.Now.ToString("HH:mm:ss");
                    dtpsdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    dtpotend.Text = DateTime.Now.ToString("HH:mm:ss");
                    txtmaxot.Text = "";


                   
                }



            Grid();
        }
//-------------------   Grid doubleClick  ------------------------

        private void Gridtgrp_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                int i;
          
                i = Gridtgrp.SelectedCells[0].RowIndex;

                cbogrpno.Text = Gridtgrp.Rows[i].Cells[0].Value.ToString();
                string selectQry;

                selectQry = "select * from timeGroup where setupdate =convert(datetime,'" + dtpsdate.Text + "',103) and comid ='" + ClsVar.GblComId + "'and groupid=" + cbogrpno.Text;


                if (svcls.DataExist(selectQry) == "1")
                {
                    svcls.toGetData("select groupname,Namerpt,Intime,Outtime,MaxInTime,SetupDate,OTEnd,maxot from timeGroup where setupdate =convert(datetime,'" + dtpsdate.Text + "',103) and groupid=" + cbogrpno.Text + "");
                    if (svcls.GblRdrToGetData.Read())
                    {
                        cbogname.Text = svcls.GblRdrToGetData["groupname"].ToString();
                        txtrpt.Text = svcls.GblRdrToGetData["Namerpt"].ToString();
                        dtpintime.Text = svcls.GblRdrToGetData["Intime"].ToString();
                        dtpouttime.Text = svcls.GblRdrToGetData["Outtime"].ToString();
                        dtpmaxintime.Text = svcls.GblRdrToGetData["MaxInTime"].ToString();
                        dtpsdate.Text = svcls.GblRdrToGetData["SetupDate"].ToString();
                        dtpotend.Text = svcls.GblRdrToGetData["OTEnd"].ToString();
                        txtmaxot.Text = svcls.GblRdrToGetData["maxot"].ToString();
                        svcls.GblCon.Close();
                    }
                }

                else
                {
                    cbogname.Text = "";
                    txtrpt.Text = "";
                    dtpintime.Text = DateTime.Now.ToString("HH:mm:ss");
                    dtpouttime.Text = DateTime.Now.ToString("HH:mm:ss");
                    dtpmaxintime.Text = DateTime.Now.ToString("HH:mm:ss");
                    dtpsdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    dtpotend.Text = DateTime.Now.ToString("HH:mm:ss");
                    txtmaxot.Text = "";
                    svcls.GblCon.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
//------------------------ setpicpath ----------------------------

        private void cmdpicpath_Click(object sender, EventArgs e)
        {
            frmSetting st = new frmSetting();
            st.Show();
        }
//------------------------- timer ---------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Visible = false;
        }
//----------------------- KeyPress --------------------------------
        private void dtpsdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cbogrpno.Select();
            }
        }

        private void cbogrpno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpintime.Select();
            }
        }

        private void dtpintime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpmaxintime.Select();
            }
        }

        private void dtpmaxintime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpouttime.Select();
            }

        }

        private void dtpouttime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtmaxot.Select();  
            }

        }

        private void txtmaxot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                dtpotend.Select();
            }
            
        }

        private void dtpotend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cbogname.Select();
            }
        }

        private void cbogname_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "\r")
            {
                txtrpt.Select();
            }
           
        }

        private void txtrpt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdSave.Select();
            }
        }
    }
}
