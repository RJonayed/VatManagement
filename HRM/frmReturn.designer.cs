namespace HRM
{
    partial class frmReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturn));
            System.Windows.Forms.Label lebFormHead;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label20 = new System.Windows.Forms.Label();
            this.lblSlNo = new System.Windows.Forms.Label();
            this.CboReturnCode = new System.Windows.Forms.ComboBox();
            this.CboSLNo = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.CboItemCode = new System.Windows.Forms.ComboBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRmk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.lblMgs = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.CboInvoiceNo = new System.Windows.Forms.ComboBox();
            this.DtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.CmdAddNew = new System.Windows.Forms.Button();
            this.PicSave = new System.Windows.Forms.PictureBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.GridInvoice = new System.Windows.Forms.DataGridView();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblItemDetails = new System.Windows.Forms.Label();
            lebFlag = new System.Windows.Forms.Label();
            lebFormHead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice)).BeginInit();
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
            lebFlag.Size = new System.Drawing.Size(964, 8);
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
            lebFormHead.Size = new System.Drawing.Size(964, 30);
            lebFormHead.TabIndex = 97;
            lebFormHead.Text = "*** RETURN INFORMATION ***";
            lebFormHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 128);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 106;
            this.label20.Text = "Sale Date";
            // 
            // lblSlNo
            // 
            this.lblSlNo.AutoSize = true;
            this.lblSlNo.BackColor = System.Drawing.Color.Transparent;
            this.lblSlNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlNo.Location = new System.Drawing.Point(16, 152);
            this.lblSlNo.Name = "lblSlNo";
            this.lblSlNo.Size = new System.Drawing.Size(37, 13);
            this.lblSlNo.TabIndex = 105;
            this.lblSlNo.Text = "SL No";
            // 
            // CboReturnCode
            // 
            this.CboReturnCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboReturnCode.FormattingEnabled = true;
            this.CboReturnCode.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "Jun\t",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CboReturnCode.Location = new System.Drawing.Point(117, 79);
            this.CboReturnCode.Name = "CboReturnCode";
            this.CboReturnCode.Size = new System.Drawing.Size(211, 22);
            this.CboReturnCode.TabIndex = 1;
            // 
            // CboSLNo
            // 
            this.CboSLNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSLNo.FormattingEnabled = true;
            this.CboSLNo.Location = new System.Drawing.Point(117, 148);
            this.CboSLNo.Name = "CboSLNo";
            this.CboSLNo.Size = new System.Drawing.Size(108, 21);
            this.CboSLNo.TabIndex = 4;
            this.CboSLNo.Click += new System.EventHandler(this.CboSLNo_Click);
            this.CboSLNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboSLNo_KeyPress);
            this.CboSLNo.Leave += new System.EventHandler(this.CboSLNo_Leave);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(16, 174);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(66, 13);
            this.lblItemName.TabIndex = 108;
            this.lblItemName.Text = "Item Code";
            // 
            // CboItemCode
            // 
            this.CboItemCode.Enabled = false;
            this.CboItemCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboItemCode.FormattingEnabled = true;
            this.CboItemCode.Items.AddRange(new object[] {
            "Muslim",
            "Hindu",
            "Christian",
            "Buddhist"});
            this.CboItemCode.Location = new System.Drawing.Point(117, 171);
            this.CboItemCode.Name = "CboItemCode";
            this.CboItemCode.Size = new System.Drawing.Size(108, 22);
            this.CboItemCode.TabIndex = 5;
            // 
            // TxtQty
            // 
            this.TxtQty.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQty.Location = new System.Drawing.Point(117, 194);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(108, 21);
            this.TxtQty.TabIndex = 6;
            this.TxtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQty_KeyPress);
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Enabled = false;
            this.TxtUnitPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnitPrice.Location = new System.Drawing.Point(117, 216);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.Size = new System.Drawing.Size(108, 21);
            this.TxtUnitPrice.TabIndex = 7;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(16, 218);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(64, 13);
            this.lblUnitPrice.TabIndex = 112;
            this.lblUnitPrice.Text = "Unit Price ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Quantity ";
            // 
            // TxtRmk
            // 
            this.TxtRmk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRmk.Location = new System.Drawing.Point(117, 260);
            this.TxtRmk.Name = "TxtRmk";
            this.TxtRmk.Size = new System.Drawing.Size(211, 21);
            this.TxtRmk.TabIndex = 9;
            this.TxtRmk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRmk_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 123;
            this.label7.Text = "Remarks";
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Grid.GridColor = System.Drawing.Color.Green;
            this.Grid.Location = new System.Drawing.Point(19, 332);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(600, 254);
            this.Grid.TabIndex = 128;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // lblMgs
            // 
            this.lblMgs.AutoSize = true;
            this.lblMgs.BackColor = System.Drawing.Color.Transparent;
            this.lblMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMgs.Location = new System.Drawing.Point(353, 262);
            this.lblMgs.Name = "lblMgs";
            this.lblMgs.Size = new System.Drawing.Size(35, 13);
            this.lblMgs.TabIndex = 155;
            this.lblMgs.Text = ".......";
            this.lblMgs.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 164;
            this.label12.Text = "Invoice No";
            // 
            // CboInvoiceNo
            // 
            this.CboInvoiceNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboInvoiceNo.FormattingEnabled = true;
            this.CboInvoiceNo.Items.AddRange(new object[] {
            "Muslim",
            "Hindu",
            "Christian",
            "Buddhist"});
            this.CboInvoiceNo.Location = new System.Drawing.Point(117, 103);
            this.CboInvoiceNo.Name = "CboInvoiceNo";
            this.CboInvoiceNo.Size = new System.Drawing.Size(211, 21);
            this.CboInvoiceNo.TabIndex = 2;
            this.CboInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboInvoiceNo_KeyPress);
            this.CboInvoiceNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CboInvoiceNo_KeyUp);
            this.CboInvoiceNo.Leave += new System.EventHandler(this.CboInvoiceNo_Leave);
            // 
            // DtpReturnDate
            // 
            this.DtpReturnDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReturnDate.Location = new System.Drawing.Point(117, 125);
            this.DtpReturnDate.Name = "DtpReturnDate";
            this.DtpReturnDate.Size = new System.Drawing.Size(108, 21);
            this.DtpReturnDate.TabIndex = 3;
            this.DtpReturnDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpReturnDate_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 167;
            this.label13.Text = "Return Code";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(117, 238);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(108, 21);
            this.TxtTotal.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(16, 238);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 13);
            this.lblTotal.TabIndex = 117;
            this.lblTotal.Text = "Total";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::HRM.Properties.Resources.edit_clear1;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(216, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 25);
            this.btnClear.TabIndex = 237;
            this.btnClear.Text = "Clear All";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CmdAddNew.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddNew.Image")));
            this.CmdAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAddNew.Location = new System.Drawing.Point(334, 79);
            this.CmdAddNew.Name = "CmdAddNew";
            this.CmdAddNew.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CmdAddNew.Size = new System.Drawing.Size(88, 25);
            this.CmdAddNew.TabIndex = 0;
            this.CmdAddNew.Text = "Add New";
            this.CmdAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdAddNew.UseVisualStyleBackColor = true;
            this.CmdAddNew.Click += new System.EventHandler(this.CmdAddNew_Click);
            // 
            // PicSave
            // 
            this.PicSave.BackColor = System.Drawing.Color.Transparent;
            this.PicSave.Image = ((System.Drawing.Image)(resources.GetObject("PicSave.Image")));
            this.PicSave.Location = new System.Drawing.Point(356, 218);
            this.PicSave.Name = "PicSave";
            this.PicSave.Size = new System.Drawing.Size(93, 41);
            this.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSave.TabIndex = 151;
            this.PicSave.TabStop = false;
            this.PicSave.Visible = false;
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.Transparent;
            this.cmdDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDelete.BackgroundImage")));
            this.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDelete.Enabled = false;
            this.cmdDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDelete.Location = new System.Drawing.Point(83, 301);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(68, 26);
            this.cmdDelete.TabIndex = 12;
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
            this.cmdExit.Location = new System.Drawing.Point(150, 301);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(65, 26);
            this.cmdExit.TabIndex = 127;
            this.cmdExit.Text = "Exit";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Transparent;
            this.cmdSave.Enabled = false;
            this.cmdSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdSave.Location = new System.Drawing.Point(20, 301);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(64, 26);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // GridInvoice
            // 
            this.GridInvoice.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridInvoice.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridInvoice.GridColor = System.Drawing.Color.Green;
            this.GridInvoice.Location = new System.Drawing.Point(625, 332);
            this.GridInvoice.Name = "GridInvoice";
            this.GridInvoice.ReadOnly = true;
            this.GridInvoice.Size = new System.Drawing.Size(327, 254);
            this.GridInvoice.TabIndex = 270;
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.Location = new System.Drawing.Point(232, 131);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(16, 13);
            this.lblCusName.TabIndex = 271;
            this.lblCusName.Text = "...";
            // 
            // lblItemDetails
            // 
            this.lblItemDetails.AutoSize = true;
            this.lblItemDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDetails.Location = new System.Drawing.Point(229, 175);
            this.lblItemDetails.Name = "lblItemDetails";
            this.lblItemDetails.Size = new System.Drawing.Size(19, 13);
            this.lblItemDetails.TabIndex = 272;
            this.lblItemDetails.Text = "....";
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 598);
            this.Controls.Add(this.lblItemDetails);
            this.Controls.Add(this.lblCusName);
            this.Controls.Add(this.GridInvoice);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.CmdAddNew);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DtpReturnDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CboInvoiceNo);
            this.Controls.Add(this.lblMgs);
            this.Controls.Add(this.PicSave);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtRmk);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.CboItemCode);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblSlNo);
            this.Controls.Add(this.CboReturnCode);
            this.Controls.Add(this.CboSLNo);
            this.Controls.Add(lebFlag);
            this.Controls.Add(lebFormHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReturn";
            this.Load += new System.EventHandler(this.frmReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblSlNo;
        private System.Windows.Forms.ComboBox CboReturnCode;
        private System.Windows.Forms.ComboBox CboSLNo;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox CboItemCode;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRmk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.PictureBox PicSave;
        private System.Windows.Forms.Label lblMgs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CboInvoiceNo;
        private System.Windows.Forms.DateTimePicker DtpReturnDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CmdAddNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView GridInvoice;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblItemDetails;
    }
}