namespace POS
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.CReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnExport = new System.Windows.Forms.Button();
            this.cboFormat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CReport
            // 
            this.CReport.ActiveViewIndex = -1;
            this.CReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CReport.DisplayGroupTree = false;
            this.CReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CReport.Location = new System.Drawing.Point(0, 0);
            this.CReport.Name = "CReport";
            this.CReport.SelectionFormula = "";
            this.CReport.Size = new System.Drawing.Size(820, 516);
            this.CReport.TabIndex = 0;
            this.CReport.ViewTimeSelectionFormula = "";
            this.CReport.Load += new System.EventHandler(this.CReport_Load);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(387, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExport.Size = new System.Drawing.Size(98, 25);
            this.btnExport.TabIndex = 141;
            this.btnExport.Text = "Export To";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cboFormat
            // 
            this.cboFormat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormat.FormattingEnabled = true;
            this.cboFormat.Items.AddRange(new object[] {
            "PDF",
            "EXCEL",
            "WORD"});
            this.cboFormat.Location = new System.Drawing.Point(489, 4);
            this.cboFormat.Name = "cboFormat";
            this.cboFormat.Size = new System.Drawing.Size(98, 21);
            this.cboFormat.TabIndex = 142;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 516);
            this.Controls.Add(this.cboFormat);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.CReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRptShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CReport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cboFormat;


    }
}