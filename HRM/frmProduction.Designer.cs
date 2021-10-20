namespace HRM
{
    partial class frmProduction
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
            System.Windows.Forms.Label lebFormHead;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduction));
            System.Windows.Forms.Label lebFlag;
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CmdReport = new System.Windows.Forms.Button();
            this.cboMacName = new System.Windows.Forms.ComboBox();
            this.CmdAddNew = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.PicSave = new System.Windows.Forms.PictureBox();
            this.lblMgs = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cboMacManName = new System.Windows.Forms.ComboBox();
            this.dtpProduction = new System.Windows.Forms.DateTimePicker();
            this.txtOverTime = new System.Windows.Forms.TextBox();
            this.txtMakReadyHour = new System.Windows.Forms.TextBox();
            this.txtTotWokHour = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboResonOfNoPro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboJobCardNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboShift = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapAchieved = new System.Windows.Forms.TextBox();
            this.txtDailyJobStatus = new System.Windows.Forms.TextBox();
            this.txtTotProduction = new System.Windows.Forms.TextBox();
            this.txtTarAchieved = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAWH = new System.Windows.Forms.TextBox();
            this.txtOTPro = new System.Windows.Forms.TextBox();
            this.txtAPro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOTWH = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboAssistant = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboHelper = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboApprentice = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bynConsumption = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnmp = new System.Windows.Forms.Button();
            this.btnyp = new System.Windows.Forms.Button();
            this.btnmper = new System.Windows.Forms.Button();
            this.btnYper = new System.Windows.Forms.Button();
            this.btnGrapic = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            lebFormHead = new System.Windows.Forms.Label();
            lebFlag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).BeginInit();
            this.SuspendLayout();
            // 
            // lebFormHead
            // 
            lebFormHead.BackColor = System.Drawing.Color.Green;
            lebFormHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lebFormHead.Dock = System.Windows.Forms.DockStyle.Top;
            lebFormHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lebFormHead.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lebFormHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            lebFormHead.Image = ((System.Drawing.Image)(resources.GetObject("lebFormHead.Image")));
            lebFormHead.Location = new System.Drawing.Point(0, 0);
            lebFormHead.Name = "lebFormHead";
            lebFormHead.Size = new System.Drawing.Size(958, 30);
            lebFormHead.TabIndex = 123;
            lebFormHead.Text = "*** PRODUCTION INFO ***";
            lebFormHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            lebFlag.Size = new System.Drawing.Size(958, 8);
            lebFlag.TabIndex = 124;
            lebFlag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CmdReport
            // 
            this.CmdReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdReport.BackgroundImage")));
            this.CmdReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CmdReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdReport.Location = new System.Drawing.Point(769, 162);
            this.CmdReport.Name = "CmdReport";
            this.CmdReport.Size = new System.Drawing.Size(173, 26);
            this.CmdReport.TabIndex = 122;
            this.CmdReport.Text = "Daily Production";
            this.CmdReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdReport.UseVisualStyleBackColor = true;
            this.CmdReport.Click += new System.EventHandler(this.CmdReport_Click);
            // 
            // cboMacName
            // 
            this.cboMacName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMacName.FormattingEnabled = true;
            this.cboMacName.Location = new System.Drawing.Point(147, 105);
            this.cboMacName.Name = "cboMacName";
            this.cboMacName.Size = new System.Drawing.Size(226, 21);
            this.cboMacName.TabIndex = 2;
            this.cboMacName.Leave += new System.EventHandler(this.cboMacName_Leave);
            this.cboMacName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMacName_KeyPress);
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.BackColor = System.Drawing.Color.Transparent;
            this.CmdAddNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddNew.Location = new System.Drawing.Point(274, 60);
            this.CmdAddNew.Name = "CmdAddNew";
            this.CmdAddNew.Size = new System.Drawing.Size(66, 21);
            this.CmdAddNew.TabIndex = 103;
            this.CmdAddNew.Text = " Add new";
            this.CmdAddNew.UseVisualStyleBackColor = false;
            this.CmdAddNew.Click += new System.EventHandler(this.CmdAddNew_Click);
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.GridColor = System.Drawing.Color.Green;
            this.Grid.Location = new System.Drawing.Point(12, 330);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(930, 251);
            this.Grid.TabIndex = 121;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            // 
            // PicSave
            // 
            this.PicSave.BackColor = System.Drawing.Color.Transparent;
            this.PicSave.Image = ((System.Drawing.Image)(resources.GetObject("PicSave.Image")));
            this.PicSave.Location = new System.Drawing.Point(274, 154);
            this.PicSave.Name = "PicSave";
            this.PicSave.Size = new System.Drawing.Size(118, 81);
            this.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSave.TabIndex = 120;
            this.PicSave.TabStop = false;
            this.PicSave.Visible = false;
            // 
            // lblMgs
            // 
            this.lblMgs.AutoSize = true;
            this.lblMgs.BackColor = System.Drawing.Color.Transparent;
            this.lblMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMgs.Location = new System.Drawing.Point(271, 242);
            this.lblMgs.Name = "lblMgs";
            this.lblMgs.Size = new System.Drawing.Size(36, 16);
            this.lblMgs.TabIndex = 119;
            this.lblMgs.Text = ".......";
            this.lblMgs.Visible = false;
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.Transparent;
            this.cmdDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDelete.BackgroundImage")));
            this.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDelete.Location = new System.Drawing.Point(73, 298);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(69, 26);
            this.cmdDelete.TabIndex = 117;
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
            this.cmdExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(143, 298);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(56, 26);
            this.cmdExit.TabIndex = 118;
            this.cmdExit.Text = "Exit";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Transparent;
            this.cmdSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdSave.Location = new System.Drawing.Point(11, 298);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(61, 26);
            this.cmdSave.TabIndex = 18;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cboMacManName
            // 
            this.cboMacManName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMacManName.FormattingEnabled = true;
            this.cboMacManName.Location = new System.Drawing.Point(147, 127);
            this.cboMacManName.Name = "cboMacManName";
            this.cboMacManName.Size = new System.Drawing.Size(226, 21);
            this.cboMacManName.TabIndex = 3;
            this.cboMacManName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMacManName_KeyPress);
            // 
            // dtpProduction
            // 
            this.dtpProduction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProduction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProduction.Location = new System.Drawing.Point(147, 61);
            this.dtpProduction.Name = "dtpProduction";
            this.dtpProduction.Size = new System.Drawing.Size(125, 21);
            this.dtpProduction.TabIndex = 0;
            this.dtpProduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpProduction_KeyPress);
            // 
            // txtOverTime
            // 
            this.txtOverTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverTime.Location = new System.Drawing.Point(1224, 90);
            this.txtOverTime.Name = "txtOverTime";
            this.txtOverTime.Size = new System.Drawing.Size(123, 21);
            this.txtOverTime.TabIndex = 6;
            this.txtOverTime.Visible = false;
            this.txtOverTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOverTime_KeyPress);
            // 
            // txtMakReadyHour
            // 
            this.txtMakReadyHour.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakReadyHour.Location = new System.Drawing.Point(514, 81);
            this.txtMakReadyHour.Name = "txtMakReadyHour";
            this.txtMakReadyHour.Size = new System.Drawing.Size(123, 21);
            this.txtMakReadyHour.TabIndex = 10;
            this.txtMakReadyHour.Text = "0";
            this.txtMakReadyHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMakReadyHour_KeyPress);
            // 
            // txtTotWokHour
            // 
            this.txtTotWokHour.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotWokHour.Location = new System.Drawing.Point(147, 260);
            this.txtTotWokHour.Name = "txtTotWokHour";
            this.txtTotWokHour.Size = new System.Drawing.Size(123, 21);
            this.txtTotWokHour.TabIndex = 9;
            this.txtTotWokHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotWokHour_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1123, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 115;
            this.label22.Text = "Over Time";
            this.label22.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(398, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 13);
            this.label21.TabIndex = 114;
            this.label21.Text = "Make Ready Hour";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 13);
            this.label18.TabIndex = 113;
            this.label18.Text = "Total Working Hour";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 112;
            this.label15.Text = "Machine Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "Production Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Name of Machine Man";
            // 
            // CboResonOfNoPro
            // 
            this.CboResonOfNoPro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboResonOfNoPro.FormattingEnabled = true;
            this.CboResonOfNoPro.Items.AddRange(new object[] {
            "N/J",
            "M/MNT",
            "OPOL"});
            this.CboResonOfNoPro.Location = new System.Drawing.Point(514, 170);
            this.CboResonOfNoPro.Name = "CboResonOfNoPro";
            this.CboResonOfNoPro.Size = new System.Drawing.Size(121, 21);
            this.CboResonOfNoPro.TabIndex = 14;
            this.CboResonOfNoPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboResonOfNoPro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Reason ";
            // 
            // cboJobCardNo
            // 
            this.cboJobCardNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJobCardNo.FormattingEnabled = true;
            this.cboJobCardNo.Location = new System.Drawing.Point(147, 83);
            this.cboJobCardNo.Name = "cboJobCardNo";
            this.cboJobCardNo.Size = new System.Drawing.Size(226, 21);
            this.cboJobCardNo.TabIndex = 1;
            this.cboJobCardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboJobCardNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "Job Card No.";
            // 
            // cboShift
            // 
            this.cboShift.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Items.AddRange(new object[] {
            "General",
            "A",
            "B"});
            this.cboShift.Location = new System.Drawing.Point(147, 149);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(123, 21);
            this.cboShift.TabIndex = 4;
            this.cboShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboShift_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 130;
            this.label4.Text = "Shift Name";
            // 
            // txtCapAchieved
            // 
            this.txtCapAchieved.Enabled = false;
            this.txtCapAchieved.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapAchieved.Location = new System.Drawing.Point(514, 147);
            this.txtCapAchieved.Name = "txtCapAchieved";
            this.txtCapAchieved.Size = new System.Drawing.Size(123, 21);
            this.txtCapAchieved.TabIndex = 13;
            this.txtCapAchieved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapAchieved_KeyPress);
            // 
            // txtDailyJobStatus
            // 
            this.txtDailyJobStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailyJobStatus.Location = new System.Drawing.Point(1224, 66);
            this.txtDailyJobStatus.Name = "txtDailyJobStatus";
            this.txtDailyJobStatus.Size = new System.Drawing.Size(123, 21);
            this.txtDailyJobStatus.TabIndex = 12;
            this.txtDailyJobStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDailyJobStatus_KeyPress);
            // 
            // txtTotProduction
            // 
            this.txtTotProduction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotProduction.Location = new System.Drawing.Point(514, 103);
            this.txtTotProduction.Name = "txtTotProduction";
            this.txtTotProduction.Size = new System.Drawing.Size(123, 21);
            this.txtTotProduction.TabIndex = 11;
            this.txtTotProduction.Leave += new System.EventHandler(this.txtTotProduction_Leave);
            this.txtTotProduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduction_KeyPress);
            // 
            // txtTarAchieved
            // 
            this.txtTarAchieved.Enabled = false;
            this.txtTarAchieved.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarAchieved.Location = new System.Drawing.Point(514, 125);
            this.txtTarAchieved.Name = "txtTarAchieved";
            this.txtTarAchieved.Size = new System.Drawing.Size(123, 21);
            this.txtTarAchieved.TabIndex = 12;
            this.txtTarAchieved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarAchieved_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 138;
            this.label5.Text = "Total Production";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 137;
            this.label6.Text = "Capacity Achieved";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1120, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 136;
            this.label7.Text = "Daily Job Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(398, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 135;
            this.label9.Text = "Target Achieved ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1224, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 29);
            this.button1.TabIndex = 147;
            this.button1.Text = "Import Working Hour from Payroll System > >>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // txtAWH
            // 
            this.txtAWH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAWH.Location = new System.Drawing.Point(147, 172);
            this.txtAWH.Name = "txtAWH";
            this.txtAWH.Size = new System.Drawing.Size(123, 21);
            this.txtAWH.TabIndex = 5;
            this.txtAWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAWH_KeyPress);
            // 
            // txtOTPro
            // 
            this.txtOTPro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTPro.Location = new System.Drawing.Point(147, 238);
            this.txtOTPro.Name = "txtOTPro";
            this.txtOTPro.Size = new System.Drawing.Size(123, 21);
            this.txtOTPro.TabIndex = 8;
            this.txtOTPro.Leave += new System.EventHandler(this.txtOTPro_Leave);
            this.txtOTPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOTPro_KeyPress);
            // 
            // txtAPro
            // 
            this.txtAPro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPro.Location = new System.Drawing.Point(147, 194);
            this.txtAPro.Name = "txtAPro";
            this.txtAPro.Size = new System.Drawing.Size(123, 21);
            this.txtAPro.TabIndex = 6;
            this.txtAPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPro_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 155;
            this.label13.Text = "OT Production";
            // 
            // txtOTWH
            // 
            this.txtOTWH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTWH.Location = new System.Drawing.Point(147, 216);
            this.txtOTWH.Name = "txtOTWH";
            this.txtOTWH.Size = new System.Drawing.Size(123, 21);
            this.txtOTWH.TabIndex = 7;
            this.txtOTWH.Leave += new System.EventHandler(this.txtOTWH_Leave);
            this.txtOTWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOTWH_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 152;
            this.label17.Text = "OT Working Hour";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 156;
            this.label16.Text = "Actucl Production";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 13);
            this.label14.TabIndex = 157;
            this.label14.Text = "Actucl Working Hour";
            // 
            // cboAssistant
            // 
            this.cboAssistant.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAssistant.FormattingEnabled = true;
            this.cboAssistant.Location = new System.Drawing.Point(514, 193);
            this.cboAssistant.Name = "cboAssistant";
            this.cboAssistant.Size = new System.Drawing.Size(230, 21);
            this.cboAssistant.TabIndex = 15;
            this.cboAssistant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAssistant_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(398, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 163;
            this.label10.Text = "Assistant";
            // 
            // cboHelper
            // 
            this.cboHelper.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHelper.FormattingEnabled = true;
            this.cboHelper.Location = new System.Drawing.Point(514, 216);
            this.cboHelper.Name = "cboHelper";
            this.cboHelper.Size = new System.Drawing.Size(230, 21);
            this.cboHelper.TabIndex = 16;
            this.cboHelper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboHelper_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 162;
            this.label11.Text = "Helper";
            // 
            // cboApprentice
            // 
            this.cboApprentice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboApprentice.FormattingEnabled = true;
            this.cboApprentice.Location = new System.Drawing.Point(514, 239);
            this.cboApprentice.Name = "cboApprentice";
            this.cboApprentice.Size = new System.Drawing.Size(230, 21);
            this.cboApprentice.TabIndex = 17;
            this.cboApprentice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboApprentice_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 161;
            this.label12.Text = "Apprentice";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(641, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 164;
            this.label19.Text = "%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(641, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 165;
            this.label20.Text = "%";
            // 
            // bynConsumption
            // 
            this.bynConsumption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bynConsumption.BackgroundImage")));
            this.bynConsumption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bynConsumption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bynConsumption.Location = new System.Drawing.Point(970, 41);
            this.bynConsumption.Name = "bynConsumption";
            this.bynConsumption.Size = new System.Drawing.Size(218, 26);
            this.bynConsumption.TabIndex = 195;
            this.bynConsumption.Text = "Consumption Report";
            this.bynConsumption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bynConsumption.UseVisualStyleBackColor = true;
            this.bynConsumption.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(970, 67);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(218, 26);
            this.btnRegister.TabIndex = 194;
            this.btnRegister.Text = "Received && Consumption";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Visible = false;
            // 
            // btnmp
            // 
            this.btnmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmp.BackgroundImage")));
            this.btnmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnmp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmp.Location = new System.Drawing.Point(770, 217);
            this.btnmp.Name = "btnmp";
            this.btnmp.Size = new System.Drawing.Size(173, 26);
            this.btnmp.TabIndex = 193;
            this.btnmp.Text = "Monthly Production";
            this.btnmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmp.UseVisualStyleBackColor = true;
            this.btnmp.Click += new System.EventHandler(this.btnmp_Click);
            // 
            // btnyp
            // 
            this.btnyp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnyp.BackgroundImage")));
            this.btnyp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnyp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyp.Location = new System.Drawing.Point(770, 244);
            this.btnyp.Name = "btnyp";
            this.btnyp.Size = new System.Drawing.Size(173, 26);
            this.btnyp.TabIndex = 192;
            this.btnyp.Text = "Yearly Production";
            this.btnyp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnyp.UseVisualStyleBackColor = true;
            this.btnyp.Click += new System.EventHandler(this.btnyp_Click);
            // 
            // btnmper
            // 
            this.btnmper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmper.BackgroundImage")));
            this.btnmper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnmper.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmper.Location = new System.Drawing.Point(770, 271);
            this.btnmper.Name = "btnmper";
            this.btnmper.Size = new System.Drawing.Size(173, 26);
            this.btnmper.TabIndex = 197;
            this.btnmper.Text = "Monthly Performance";
            this.btnmper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmper.UseVisualStyleBackColor = true;
            this.btnmper.Click += new System.EventHandler(this.btnmper_Click);
            // 
            // btnYper
            // 
            this.btnYper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYper.BackgroundImage")));
            this.btnYper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYper.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYper.Location = new System.Drawing.Point(770, 298);
            this.btnYper.Name = "btnYper";
            this.btnYper.Size = new System.Drawing.Size(173, 26);
            this.btnYper.TabIndex = 196;
            this.btnYper.Text = "Yearly Performance";
            this.btnYper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYper.UseVisualStyleBackColor = true;
            this.btnYper.Click += new System.EventHandler(this.btnYper_Click);
            // 
            // btnGrapic
            // 
            this.btnGrapic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGrapic.BackgroundImage")));
            this.btnGrapic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGrapic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrapic.Location = new System.Drawing.Point(769, 189);
            this.btnGrapic.Name = "btnGrapic";
            this.btnGrapic.Size = new System.Drawing.Size(173, 26);
            this.btnGrapic.TabIndex = 198;
            this.btnGrapic.Text = "Graphical Production";
            this.btnGrapic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrapic.UseVisualStyleBackColor = true;
            this.btnGrapic.Click += new System.EventHandler(this.btnGrapic_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(514, 262);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(230, 21);
            this.txtRemarks.TabIndex = 199;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label23.Location = new System.Drawing.Point(399, 264);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 13);
            this.label23.TabIndex = 200;
            this.label23.Text = "Remarks";
            // 
            // frmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 616);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnGrapic);
            this.Controls.Add(this.btnmper);
            this.Controls.Add(this.btnYper);
            this.Controls.Add(this.bynConsumption);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnmp);
            this.Controls.Add(this.btnyp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cboAssistant);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboHelper);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboApprentice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAWH);
            this.Controls.Add(this.txtOTPro);
            this.Controls.Add(this.txtAPro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtOTWH);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCapAchieved);
            this.Controls.Add(this.txtDailyJobStatus);
            this.Controls.Add(this.txtTotProduction);
            this.Controls.Add(this.txtTarAchieved);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboShift);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboJobCardNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboResonOfNoPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(lebFlag);
            this.Controls.Add(lebFormHead);
            this.Controls.Add(this.CmdReport);
            this.Controls.Add(this.cboMacName);
            this.Controls.Add(this.CmdAddNew);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.PicSave);
            this.Controls.Add(this.lblMgs);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cboMacManName);
            this.Controls.Add(this.dtpProduction);
            this.Controls.Add(this.txtOverTime);
            this.Controls.Add(this.txtMakReadyHour);
            this.Controls.Add(this.txtTotWokHour);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production Information";
            this.Load += new System.EventHandler(this.frmProduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CmdReport;
        private System.Windows.Forms.ComboBox cboMacName;
        private System.Windows.Forms.Button CmdAddNew;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.PictureBox PicSave;
        private System.Windows.Forms.Label lblMgs;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.ComboBox cboMacManName;
        private System.Windows.Forms.DateTimePicker dtpProduction;
        private System.Windows.Forms.TextBox txtOverTime;
        private System.Windows.Forms.TextBox txtMakReadyHour;
        private System.Windows.Forms.TextBox txtTotWokHour;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboResonOfNoPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboJobCardNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapAchieved;
        private System.Windows.Forms.TextBox txtDailyJobStatus;
        private System.Windows.Forms.TextBox txtTotProduction;
        private System.Windows.Forms.TextBox txtTarAchieved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAWH;
        private System.Windows.Forms.TextBox txtOTPro;
        private System.Windows.Forms.TextBox txtAPro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOTWH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboAssistant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboHelper;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboApprentice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button bynConsumption;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnmp;
        private System.Windows.Forms.Button btnyp;
        private System.Windows.Forms.Button btnmper;
        private System.Windows.Forms.Button btnYper;
        private System.Windows.Forms.Button btnGrapic;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label23;

    }
}