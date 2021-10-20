
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace HRM
{
    public partial class frmServer : Form
    {

        public frmServer()
        {
            InitializeComponent();
        }
        public void RunPass()
        {
            //Application.Run(new frmPassword());
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Persist Security Info=False;User ID=sa;password='" + ClsVar.SqlPassword + "';Initial Catalog=" + ClsVar.DataBaseName + ";Data Source=" + ClsVar.ServerName);

            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\CHECK.txt");
                ClsVar.ServerName = sr.ReadLine();
                ClsVar.DataBaseName = sr.ReadLine();
                ClsVar.SqlPassword = sr.ReadLine();
                sr.Close();
                txtserver.Text = ClsVar.ServerName;
                txtdatabase.Text = ClsVar.DataBaseName;
                txtSqlPass.Text = ClsVar.SqlPassword;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\CHECK.txt");
                
                ClsVar.ServerName = txtserver.Text;
                ClsVar.DataBaseName = txtdatabase.Text;
                ClsVar.SqlPassword = txtSqlPass.Text ;
                sw.WriteLine(ClsVar.ServerName);
                sw.WriteLine(ClsVar.DataBaseName);
                sw.WriteLine(ClsVar.SqlPassword);
                sw.Close();

                Thread newThread = new Thread(new ThreadStart(RunPass));
                newThread.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtserver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtdatabase.Select();
            }
        }

        private void txtdatabase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                txtSqlPass.Select();
            }
        }

        private void txtSqlPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                cmdOk.Select();
            }
        }
    }
 }

        
    
