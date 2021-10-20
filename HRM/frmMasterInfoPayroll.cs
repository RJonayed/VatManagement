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
    public partial class frmMasterInfoPayroll : Form
    {
        public frmMasterInfoPayroll()
        {
            InitializeComponent();
            this.Width = ClsVar.GblFormWidth;
            this.Height = ClsVar.GblFormHeight;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmMasterInfoPayroll_Load(object sender, EventArgs e)
        {

        }
    }
}
