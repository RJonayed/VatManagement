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
    public partial class frmMarksEntry : Form
    {
        ClsMain SvCls = new ClsMain();
        public frmMarksEntry()
        {
            InitializeComponent();
            this.Width = ClsVar.GblFormWidth;
            this.Height = ClsVar.GblFormHeight;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmMarksEntry_Load(object sender, EventArgs e)
        {
            if (ClsVar.GblFrmBackColor == "1")
            {
                ClsVar.BackPicPath = Application.StartupPath + "\\Pic\\" + "Back.jpg";
                this.BackgroundImage = new Bitmap(ClsVar.BackPicPath);

            }
            string Qry = "select AutoNo from Student  where  comid ='" + ClsVar.GblComId + "'";
            CboStudent.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            CboStudent.DisplayMember = "AutoNo";
            CboStudent.Text = "";

            string Qry1 = "select convert(varchar,SubjID) + '~' + SubjName as SubjID from Subject  where  comid ='" + ClsVar.GblComId + "'";
            CboSub.DataSource = SvCls.GblDataSet(Qry1).Tables[0];
            CboSub.DisplayMember = "SubjID";
            CboSub.Text = "";
            GridHeading();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string SelectQry;
            string SaveQry;
            string EditQry;

            SelectQry = "select * from MarksEntry  where  comid ='" + ClsVar.GblComId + "' and STAutoNo='" + CboStudent.Text.Trim() + "'and ExamName='" + CboExam.Text.Trim() + "' and SubjID='" + CboSub.Text.Trim() + "'and ClassID='"+ CboClassID.Text.Trim () +"'";
            SaveQry = "insert into MarksEntry(STAutoNo,ExamName,SubjID,Marks,Rmk,Grade,ClassID,ComId,PcName) Values("+ CboStudent.Text.Trim () +",'"+ CboExam.Text.Trim () +"','"+ CboSub.Text.Trim () +"',"+TxtMarks.Text.Trim ()
                      +",'"+ TxtRemarks.Text.Trim ()+"','"+ CboGrade.Text.Trim () +"','"+ CboClassID.Text.Trim () +"','"+ ClsVar.GblComId  +"','"+ ClsVar.GblPcName  +"')";
            EditQry = "Update MarksEntry set Marks='" + TxtMarks.Text.Trim() + "',Rmk='" + TxtRemarks.Text.Trim() + "',Grade='" + CboGrade.Text.Trim() + "' where  comid ='" + ClsVar.GblComId + "' and STAutoNo='" + CboStudent.Text.Trim() + "'and ExamName='" + CboExam.Text.Trim() + "' and SubjID='" + CboSub.Text.Trim() + "'and ClassID='" + CboClassID.Text.Trim() + "'";
           
            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                lblMgs.Visible = true;
                lblMgs.Text = "Save Successfully";
             
            }
            else
            {
                SvCls.insertUpdate(EditQry);
                lblMgs.Visible = true;
                lblMgs.Text = "Edit Successfully";
            }
            GridHeading();
        }
        private void GridHeading()
        {
            GridSubject.DataSource = SvCls.GblDataTable("select STAutoNo as StudentRoll,ExamName,SubjID,Marks,Rmk,Grade,ClassID from MarksEntry ");
            GridSubject.Refresh();
        }

        private void Cbosub_Leave(object sender, EventArgs e)
        {
            if (CboSub.Text == "")
            {
                return;
            }

            try
            {
                CboSub.Text = CboSub.Text.Substring(0, CboSub.Text.IndexOf("~"));
            }
            catch
            {
            }
        }
    }
}
