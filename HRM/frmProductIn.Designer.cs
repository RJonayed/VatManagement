namespace HRM
{
    partial class frmProductIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductIn));
            System.Windows.Forms.Label lebFormHead;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTransactionId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChalan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.PicSave = new System.Windows.Forms.PictureBox();
            this.lblMgs = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Grid = new System.Windows.Forms.DataGridView();
            this.CmdReport = new System.Windows.Forms.Button();
            this.mskTDate = new System.Windows.Forms.DateTimePicker();
            this.cboMatName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lebTotRows = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.cboMetarialID = new System.Windows.Forms.ComboBox();
            this.btnIdAdd = new System.Windows.Forms.Button();
            this.txtLastBal = new System.Windows.Forms.TextBox();
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            this.txtAvgUnitPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnBlank = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.dtpTo = new System.Windows.Forms.MaskedTextBox();
            this.dtpFrom = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnReport = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lebProcess = new System.Windows.Forms.Label();
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
            lebFlag.Size = new System.Drawing.Size(1007, 8);
            lebFlag.TabIndex = 102;
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
            lebFormHead.Size = new System.Drawing.Size(1007, 30);
            lebFormHead.TabIndex = 101;
            lebFormHead.Text = "*** Product In (Inventory)***";
            lebFormHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 158;
            this.label1.Text = "Transaction ID";
            // 
            // cboTransactionId
            // 
            this.cboTransactionId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTransactionId.FormattingEnabled = true;
            this.cboTransactionId.Location = new System.Drawing.Point(135, 57);
            this.cboTransactionId.Name = "cboTransactionId";
            this.cboTransactionId.Size = new System.Drawing.Size(123, 21);
            this.cboTransactionId.TabIndex = 1;
            this.cboTransactionId.Leave += new System.EventHandler(this.cboTransactionId_Leave);
            this.cboTransactionId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTransactionId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 160;
            this.label2.Text = "Material Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 162;
            this.label12.Text = "Transaction Date";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(30, 173);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(56, 13);
            this.label48.TabIndex = 164;
            this.label48.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(135, 168);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(135, 21);
            this.txtQty.TabIndex = 6;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 166;
            this.label3.Text = "Item Form";
            // 
            // cboItem
            // 
            this.cboItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Items.AddRange(new object[] {
            "Local",
            "Foreign"});
            this.cboItem.Location = new System.Drawing.Point(503, 57);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(190, 21);
            this.cboItem.TabIndex = 9;
            this.cboItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboItem_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 168;
            this.label4.Text = "Chalan No";
            // 
            // txtChalan
            // 
            this.txtChalan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChalan.Location = new System.Drawing.Point(503, 79);
            this.txtChalan.Name = "txtChalan";
            this.txtChalan.Size = new System.Drawing.Size(190, 21);
            this.txtChalan.TabIndex = 10;
            this.txtChalan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChalan_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 170;
            this.label5.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(503, 102);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(190, 21);
            this.txtRemarks.TabIndex = 11;
            this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
            // 
            // PicSave
            // 
            this.PicSave.BackColor = System.Drawing.Color.Transparent;
            this.PicSave.Image = ((System.Drawing.Image)(resources.GetObject("PicSave.Image")));
            this.PicSave.Location = new System.Drawing.Point(699, 50);
            this.PicSave.Name = "PicSave";
            this.PicSave.Size = new System.Drawing.Size(155, 73);
            this.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSave.TabIndex = 176;
            this.PicSave.TabStop = false;
            this.PicSave.Visible = false;
            // 
            // lblMgs
            // 
            this.lblMgs.AutoSize = true;
            this.lblMgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMgs.Location = new System.Drawing.Point(696, 129);
            this.lblMgs.Name = "lblMgs";
            this.lblMgs.Size = new System.Drawing.Size(36, 16);
            this.lblMgs.TabIndex = 175;
            this.lblMgs.Text = ".......";
            this.lblMgs.Visible = false;
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.Transparent;
            this.cmdDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDelete.BackgroundImage")));
            this.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDelete.Location = new System.Drawing.Point(91, 250);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(74, 26);
            this.cmdDelete.TabIndex = 173;
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
            this.cmdExit.Location = new System.Drawing.Point(165, 250);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(65, 26);
            this.cmdExit.TabIndex = 174;
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
            this.cmdSave.Location = new System.Drawing.Point(27, 250);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(64, 26);
            this.cmdSave.TabIndex = 12;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(259, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(92, 24);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.Grid.Location = new System.Drawing.Point(27, 280);
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
            this.Grid.Size = new System.Drawing.Size(896, 301);
            this.Grid.TabIndex = 177;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // CmdReport
            // 
            this.CmdReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdReport.BackgroundImage")));
            this.CmdReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CmdReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdReport.Location = new System.Drawing.Point(236, 250);
            this.CmdReport.Name = "CmdReport";
            this.CmdReport.Size = new System.Drawing.Size(76, 26);
            this.CmdReport.TabIndex = 178;
            this.CmdReport.Text = "Report";
            this.CmdReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdReport.UseVisualStyleBackColor = true;
            this.CmdReport.Click += new System.EventHandler(this.CmdReport_Click);
            // 
            // mskTDate
            // 
            this.mskTDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskTDate.Location = new System.Drawing.Point(135, 79);
            this.mskTDate.Name = "mskTDate";
            this.mskTDate.Size = new System.Drawing.Size(89, 21);
            this.mskTDate.TabIndex = 2;
            this.mskTDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskTDate_KeyDown);
            // 
            // cboMatName
            // 
            this.cboMatName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMatName.FormattingEnabled = true;
            this.cboMatName.Location = new System.Drawing.Point(135, 124);
            this.cboMatName.Name = "cboMatName";
            this.cboMatName.Size = new System.Drawing.Size(283, 21);
            this.cboMatName.TabIndex = 4;
            this.cboMatName.Leave += new System.EventHandler(this.cboMatName_Leave);
            this.cboMatName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMatName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 190;
            this.label6.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(135, 190);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(216, 21);
            this.txtUnitPrice.TabIndex = 8;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.Leave += new System.EventHandler(this.txtUnitPrice_Leave);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 191;
            this.label7.Text = "Material ID";
            // 
            // cboType
            // 
            this.cboType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(135, 146);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(216, 21);
            this.cboType.TabIndex = 5;
            this.cboType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboType_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 193;
            this.label8.Text = "Material Type";
            // 
            // lebTotRows
            // 
            this.lebTotRows.AutoSize = true;
            this.lebTotRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lebTotRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebTotRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lebTotRows.Location = new System.Drawing.Point(318, 255);
            this.lebTotRows.Name = "lebTotRows";
            this.lebTotRows.Size = new System.Drawing.Size(12, 16);
            this.lebTotRows.TabIndex = 194;
            this.lebTotRows.Text = ".";
            this.lebTotRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboUnit
            // 
            this.cboUnit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(275, 168);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(75, 21);
            this.cboUnit.TabIndex = 7;
            this.cboUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboUnit_KeyPress);
            // 
            // cboMetarialID
            // 
            this.cboMetarialID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetarialID.FormattingEnabled = true;
            this.cboMetarialID.Location = new System.Drawing.Point(135, 101);
            this.cboMetarialID.Name = "cboMetarialID";
            this.cboMetarialID.Size = new System.Drawing.Size(136, 21);
            this.cboMetarialID.TabIndex = 3;
            this.cboMetarialID.SelectedIndexChanged += new System.EventHandler(this.cboMetarialID_SelectedIndexChanged);
            this.cboMetarialID.Leave += new System.EventHandler(this.cboMetarialID_Leave);
            this.cboMetarialID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMetarialID_KeyPress);
            // 
            // btnIdAdd
            // 
            this.btnIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIdAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnIdAdd.Image")));
            this.btnIdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdAdd.Location = new System.Drawing.Point(271, 99);
            this.btnIdAdd.Name = "btnIdAdd";
            this.btnIdAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnIdAdd.Size = new System.Drawing.Size(132, 24);
            this.btnIdAdd.TabIndex = 195;
            this.btnIdAdd.Text = "New Material ID ";
            this.btnIdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIdAdd.UseVisualStyleBackColor = true;
            this.btnIdAdd.Click += new System.EventHandler(this.btnIdAdd_Click);
            // 
            // txtLastBal
            // 
            this.txtLastBal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastBal.Location = new System.Drawing.Point(894, 83);
            this.txtLastBal.Name = "txtLastBal";
            this.txtLastBal.Size = new System.Drawing.Size(123, 21);
            this.txtLastBal.TabIndex = 196;
            this.txtLastBal.Visible = false;
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastPrice.Location = new System.Drawing.Point(894, 59);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.Size = new System.Drawing.Size(123, 21);
            this.txtLastPrice.TabIndex = 197;
            this.txtLastPrice.Visible = false;
            // 
            // txtAvgUnitPrice
            // 
            this.txtAvgUnitPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgUnitPrice.Location = new System.Drawing.Point(135, 212);
            this.txtAvgUnitPrice.Name = "txtAvgUnitPrice";
            this.txtAvgUnitPrice.Size = new System.Drawing.Size(117, 21);
            this.txtAvgUnitPrice.TabIndex = 198;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(32, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 199;
            this.label10.Text = "Average Price";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(537, 249);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(76, 26);
            this.btnFind.TabIndex = 200;
            this.btnFind.TabStop = false;
            this.btnFind.Text = "Search";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnBlank
            // 
            this.btnBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBlank.Image = ((System.Drawing.Image)(resources.GetObject("btnBlank.Image")));
            this.btnBlank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlank.Location = new System.Drawing.Point(469, 249);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBlank.Size = new System.Drawing.Size(68, 27);
            this.btnBlank.TabIndex = 201;
            this.btnBlank.Text = "Blank";
            this.btnBlank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlank.UseVisualStyleBackColor = true;
            this.btnBlank.Click += new System.EventHandler(this.btnBlank_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(894, 143);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(64, 21);
            this.txtAdd.TabIndex = 202;
            this.txtAdd.Visible = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(503, 145);
            this.dtpTo.Mask = "00/00/0000";
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(78, 21);
            this.dtpTo.TabIndex = 219;
            this.dtpTo.ValidatingType = typeof(System.DateTime);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(503, 124);
            this.dtpFrom.Mask = "00/00/0000";
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(78, 21);
            this.dtpFrom.TabIndex = 218;
            this.dtpFrom.ValidatingType = typeof(System.DateTime);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(451, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 221;
            this.label17.Text = "To Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(436, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 220;
            this.label18.Text = "From Date";
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.Transparent;
            this.BtnReport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.Image")));
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnReport.Location = new System.Drawing.Point(504, 165);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(76, 26);
            this.BtnReport.TabIndex = 217;
            this.BtnReport.Text = "Report";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(254, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 222;
            this.label9.Text = "(With This Unit Price)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 223;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lebProcess
            // 
            this.lebProcess.AutoSize = true;
            this.lebProcess.BackColor = System.Drawing.Color.DarkGreen;
            this.lebProcess.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebProcess.ForeColor = System.Drawing.Color.Chartreuse;
            this.lebProcess.Location = new System.Drawing.Point(438, 206);
            this.lebProcess.Name = "lebProcess";
            this.lebProcess.Size = new System.Drawing.Size(64, 23);
            this.lebProcess.TabIndex = 224;
            this.lebProcess.Text = ".........";
            this.lebProcess.Visible = false;
            // 
            // frmProductIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1007, 611);
            this.Controls.Add(this.lebProcess);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnBlank);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtAvgUnitPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLastPrice);
            this.Controls.Add(this.txtLastBal);
            this.Controls.Add(this.btnIdAdd);
            this.Controls.Add(this.cboMetarialID);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.lebTotRows);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.mskTDate);
            this.Controls.Add(this.cboMatName);
            this.Controls.Add(this.CmdReport);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.PicSave);
            this.Controls.Add(this.lblMgs);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChalan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTransactionId);
            this.Controls.Add(lebFlag);
            this.Controls.Add(lebFormHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductIn";
            this.Text = "frmProductIn";
            this.Load += new System.EventHandler(this.frmProductIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTransactionId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChalan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.PictureBox PicSave;
        private System.Windows.Forms.Label lblMgs;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button CmdReport;
        private System.Windows.Forms.DateTimePicker mskTDate;
        private System.Windows.Forms.ComboBox cboMatName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lebTotRows;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.ComboBox cboMetarialID;
        private System.Windows.Forms.Button btnIdAdd;
        private System.Windows.Forms.TextBox txtLastBal;
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.TextBox txtAvgUnitPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.MaskedTextBox dtpTo;
        private System.Windows.Forms.MaskedTextBox dtpFrom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lebProcess;
    }
}