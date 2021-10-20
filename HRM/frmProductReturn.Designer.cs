namespace HRM
{
    partial class frmProductReturn
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lebFlag;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductReturn));
            System.Windows.Forms.Label lebFormHead;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTransactionId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMatName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.PicSave = new System.Windows.Forms.PictureBox();
            this.lblMgs = new System.Windows.Forms.Label();
            this.CmdRptJob = new System.Windows.Forms.Button();
            this.cmdRptTransaction = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cboJobCard = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStorSlip = new System.Windows.Forms.TextBox();
            this.txtMatId = new System.Windows.Forms.TextBox();
            this.dtpRetDate = new System.Windows.Forms.DateTimePicker();
            this.BtnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            lebFlag = new System.Windows.Forms.Label();
            lebFormHead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lebFlag
            // 
            lebFlag.BackColor = System.Drawing.Color.Green;
            lebFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lebFlag.Dock = System.Windows.Forms.DockStyle.Top;
            lebFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lebFlag.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lebFlag.ForeColor = System.Drawing.Color.Black;
            lebFlag.Image = ((System.Drawing.Image)(resources.GetObject("lebFlag.Image")));
            lebFlag.Location = new System.Drawing.Point(0, 30);
            lebFlag.Name = "lebFlag";
            lebFlag.Size = new System.Drawing.Size(941, 8);
            lebFlag.TabIndex = 104;
            lebFlag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lebFormHead
            // 
            lebFormHead.BackColor = System.Drawing.Color.Green;
            lebFormHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lebFormHead.Dock = System.Windows.Forms.DockStyle.Top;
            lebFormHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lebFormHead.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lebFormHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            lebFormHead.Image = ((System.Drawing.Image)(resources.GetObject("lebFormHead.Image")));
            lebFormHead.Location = new System.Drawing.Point(0, 0);
            lebFormHead.Name = "lebFormHead";
            lebFormHead.Size = new System.Drawing.Size(941, 30);
            lebFormHead.TabIndex = 103;
            lebFormHead.Text = "*** Product Return (Inventory)***";
            lebFormHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 160;
            this.label1.Text = "Transaction ID";
            // 
            // cboTransactionId
            // 
            this.cboTransactionId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTransactionId.FormattingEnabled = true;
            this.cboTransactionId.Location = new System.Drawing.Point(141, 83);
            this.cboTransactionId.Name = "cboTransactionId";
            this.cboTransactionId.Size = new System.Drawing.Size(137, 21);
            this.cboTransactionId.TabIndex = 9;
            this.cboTransactionId.Leave += new System.EventHandler(this.cboTransactionId_Leave);
            this.cboTransactionId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTransactionId_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 168;
            this.label5.Text = "Metarial Name";
            // 
            // cboMatName
            // 
            this.cboMatName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMatName.FormattingEnabled = true;
            this.cboMatName.Location = new System.Drawing.Point(141, 127);
            this.cboMatName.Name = "cboMatName";
            this.cboMatName.Size = new System.Drawing.Size(263, 21);
            this.cboMatName.TabIndex = 11;
            this.cboMatName.Leave += new System.EventHandler(this.cboMatName_Leave);
            this.cboMatName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMid_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(57, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 170;
            this.label12.Text = "Return Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 172;
            this.label6.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(141, 193);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(90, 21);
            this.txtQty.TabIndex = 3;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 174;
            this.label7.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(141, 216);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(263, 21);
            this.txtRemarks.TabIndex = 4;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.Transparent;
            this.cmdDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDelete.BackgroundImage")));
            this.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDelete.Location = new System.Drawing.Point(204, 243);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(74, 26);
            this.cmdDelete.TabIndex = 6;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.Transparent;
            this.cmdExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExit.BackgroundImage")));
            this.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(280, 243);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(65, 26);
            this.cmdExit.TabIndex = 7;
            this.cmdExit.Text = "Exit";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Transparent;
            this.cmdSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdSave.Location = new System.Drawing.Point(138, 243);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(64, 26);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // PicSave
            // 
            this.PicSave.BackColor = System.Drawing.Color.Transparent;
            this.PicSave.Image = ((System.Drawing.Image)(resources.GetObject("PicSave.Image")));
            this.PicSave.Location = new System.Drawing.Point(460, 106);
            this.PicSave.Name = "PicSave";
            this.PicSave.Size = new System.Drawing.Size(134, 79);
            this.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSave.TabIndex = 180;
            this.PicSave.TabStop = false;
            this.PicSave.Visible = false;
            // 
            // lblMgs
            // 
            this.lblMgs.AutoSize = true;
            this.lblMgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMgs.Location = new System.Drawing.Point(459, 190);
            this.lblMgs.Name = "lblMgs";
            this.lblMgs.Size = new System.Drawing.Size(36, 16);
            this.lblMgs.TabIndex = 179;
            this.lblMgs.Text = ".......";
            this.lblMgs.Visible = false;
            // 
            // CmdRptJob
            // 
            this.CmdRptJob.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRptJob.Location = new System.Drawing.Point(431, 63);
            this.CmdRptJob.Name = "CmdRptJob";
            this.CmdRptJob.Size = new System.Drawing.Size(218, 25);
            this.CmdRptJob.TabIndex = 181;
            this.CmdRptJob.Text = "Product Out Rpt. for a JobCardNo";
            this.CmdRptJob.UseVisualStyleBackColor = true;
            this.CmdRptJob.Visible = false;
            // 
            // cmdRptTransaction
            // 
            this.cmdRptTransaction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRptTransaction.Location = new System.Drawing.Point(431, 36);
            this.cmdRptTransaction.Name = "cmdRptTransaction";
            this.cmdRptTransaction.Size = new System.Drawing.Size(231, 25);
            this.cmdRptTransaction.TabIndex = 182;
            this.cmdRptTransaction.Text = "Product Out Rpt. for a TransactionNo";
            this.cmdRptTransaction.UseVisualStyleBackColor = true;
            this.cmdRptTransaction.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(280, 81);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNew.Size = new System.Drawing.Size(87, 24);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Add New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.GridColor = System.Drawing.Color.LightGreen;
            this.Grid.Location = new System.Drawing.Point(12, 287);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.RowTemplate.Height = 18;
            this.Grid.Size = new System.Drawing.Size(905, 282);
            this.Grid.TabIndex = 20;
            this.Grid.TabStop = false;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 166;
            this.label4.Text = "Store Slip No";
            // 
            // cboJobCard
            // 
            this.cboJobCard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJobCard.FormattingEnabled = true;
            this.cboJobCard.Location = new System.Drawing.Point(141, 60);
            this.cboJobCard.Name = "cboJobCard";
            this.cboJobCard.Size = new System.Drawing.Size(137, 21);
            this.cboJobCard.TabIndex = 0;
            this.cboJobCard.Leave += new System.EventHandler(this.cboJobCard_Leave);
            this.cboJobCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboJobCard_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 164;
            this.label3.Text = "Job Card No";
            // 
            // txtStorSlip
            // 
            this.txtStorSlip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStorSlip.Location = new System.Drawing.Point(141, 149);
            this.txtStorSlip.Name = "txtStorSlip";
            this.txtStorSlip.Size = new System.Drawing.Size(149, 21);
            this.txtStorSlip.TabIndex = 12;
            this.txtStorSlip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStorSlip_KeyPress);
            // 
            // txtMatId
            // 
            this.txtMatId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatId.Location = new System.Drawing.Point(141, 105);
            this.txtMatId.Name = "txtMatId";
            this.txtMatId.Size = new System.Drawing.Size(113, 21);
            this.txtMatId.TabIndex = 10;
            this.txtMatId.Leave += new System.EventHandler(this.txtMatId_Leave);
            this.txtMatId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatId_KeyPress);
            // 
            // dtpRetDate
            // 
            this.dtpRetDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRetDate.Location = new System.Drawing.Point(142, 171);
            this.dtpRetDate.Name = "dtpRetDate";
            this.dtpRetDate.Size = new System.Drawing.Size(89, 21);
            this.dtpRetDate.TabIndex = 13;
            this.dtpRetDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpRetDate_KeyDown);
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.Transparent;
            this.BtnReport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.Image")));
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnReport.Location = new System.Drawing.Point(351, 244);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(71, 24);
            this.BtnReport.TabIndex = 8;
            this.BtnReport.Text = "Report";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(296, 149);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 188;
            this.label2.Text = "Metarial ID";
            // 
            // frmProductReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(941, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.dtpRetDate);
            this.Controls.Add(this.txtMatId);
            this.Controls.Add(this.txtStorSlip);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cmdRptTransaction);
            this.Controls.Add(this.CmdRptJob);
            this.Controls.Add(this.PicSave);
            this.Controls.Add(this.lblMgs);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMatName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboJobCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTransactionId);
            this.Controls.Add(lebFlag);
            this.Controls.Add(lebFormHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductReturn";
            this.Text = "frmProductReturn";
            this.Load += new System.EventHandler(this.frmProductReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTransactionId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMatName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.PictureBox PicSave;
        private System.Windows.Forms.Label lblMgs;
        private System.Windows.Forms.Button CmdRptJob;
        private System.Windows.Forms.Button cmdRptTransaction;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboJobCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStorSlip;
        private System.Windows.Forms.TextBox txtMatId;
        private System.Windows.Forms.DateTimePicker dtpRetDate;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}