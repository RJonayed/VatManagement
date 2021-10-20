namespace HRM
{
    partial class frmOTEditInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOTEditInfo));
            System.Windows.Forms.Label lebFormHead;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEmpID = new System.Windows.Forms.ComboBox();
            this.baudRatelLabel = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.PicSave = new System.Windows.Forms.PictureBox();
            this.lblMgs = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtDed = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.txtotdelete = new System.Windows.Forms.TextBox();
            this.chkOtDel = new System.Windows.Forms.CheckBox();
            this.btnAttnProcess = new System.Windows.Forms.Button();
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
            lebFlag.Size = new System.Drawing.Size(913, 8);
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
            lebFormHead.Size = new System.Drawing.Size(913, 30);
            lebFormHead.TabIndex = 103;
            lebFormHead.Text = "*** Download Data From RTA 600 ***";
            lebFormHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 160;
            this.label1.Text = "Emp ID";
            // 
            // cboEmpID
            // 
            this.cboEmpID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Location = new System.Drawing.Point(111, 86);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(263, 21);
            this.cboEmpID.TabIndex = 1;
            this.cboEmpID.Leave += new System.EventHandler(this.cboEmpID_Leave);
            // 
            // baudRatelLabel
            // 
            this.baudRatelLabel.AutoSize = true;
            this.baudRatelLabel.BackColor = System.Drawing.Color.Transparent;
            this.baudRatelLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRatelLabel.Location = new System.Drawing.Point(415, 246);
            this.baudRatelLabel.Name = "baudRatelLabel";
            this.baudRatelLabel.Size = new System.Drawing.Size(34, 13);
            this.baudRatelLabel.TabIndex = 168;
            this.baudRatelLabel.Text = "OT +";
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.Transparent;
            this.cmdExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExit.BackgroundImage")));
            this.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(176, 155);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(65, 26);
            this.cmdExit.TabIndex = 178;
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
            this.cmdSave.Location = new System.Drawing.Point(111, 155);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(64, 26);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // PicSave
            // 
            this.PicSave.BackColor = System.Drawing.Color.Transparent;
            this.PicSave.Image = ((System.Drawing.Image)(resources.GetObject("PicSave.Image")));
            this.PicSave.Location = new System.Drawing.Point(414, 67);
            this.PicSave.Name = "PicSave";
            this.PicSave.Size = new System.Drawing.Size(172, 79);
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
            this.lblMgs.Location = new System.Drawing.Point(415, 151);
            this.lblMgs.Name = "lblMgs";
            this.lblMgs.Size = new System.Drawing.Size(36, 16);
            this.lblMgs.TabIndex = 179;
            this.lblMgs.Text = ".......";
            this.lblMgs.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(488, 192);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNew.Size = new System.Drawing.Size(84, 24);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Read";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 166;
            this.label4.Text = "OT -";
            // 
            // txtDed
            // 
            this.txtDed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDed.Location = new System.Drawing.Point(111, 131);
            this.txtDed.Name = "txtDed";
            this.txtDed.Size = new System.Drawing.Size(52, 21);
            this.txtDed.TabIndex = 3;
            this.txtDed.Text = "0";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(414, 222);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(52, 21);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "0";
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd_KeyPress);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(111, 64);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(89, 21);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.Leave += new System.EventHandler(this.dtpDate_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(56, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 188;
            this.label12.Text = "Date";
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.Transparent;
            this.cmdDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDelete.BackgroundImage")));
            this.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDelete.Location = new System.Drawing.Point(743, 79);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(74, 26);
            this.cmdDelete.TabIndex = 189;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Visible = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle11;
            this.Grid.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.Grid.Location = new System.Drawing.Point(59, 285);
            this.Grid.Name = "Grid";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Grid.RowTemplate.Height = 18;
            this.Grid.Size = new System.Drawing.Size(643, 164);
            this.Grid.TabIndex = 190;
            this.Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellValueChanged);
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // txtotdelete
            // 
            this.txtotdelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotdelete.Location = new System.Drawing.Point(823, 79);
            this.txtotdelete.Name = "txtotdelete";
            this.txtotdelete.Size = new System.Drawing.Size(42, 21);
            this.txtotdelete.TabIndex = 191;
            this.txtotdelete.Text = "0";
            this.txtotdelete.Visible = false;
            // 
            // chkOtDel
            // 
            this.chkOtDel.AutoSize = true;
            this.chkOtDel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOtDel.ForeColor = System.Drawing.Color.Maroon;
            this.chkOtDel.Location = new System.Drawing.Point(187, 113);
            this.chkOtDel.Name = "chkOtDel";
            this.chkOtDel.Size = new System.Drawing.Size(85, 18);
            this.chkOtDel.TabIndex = 193;
            this.chkOtDel.Text = "OT Delete";
            this.chkOtDel.UseVisualStyleBackColor = true;
            this.chkOtDel.Click += new System.EventHandler(this.chkOtDel_Click);
            // 
            // btnAttnProcess
            // 
            this.btnAttnProcess.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttnProcess.Location = new System.Drawing.Point(414, 190);
            this.btnAttnProcess.Name = "btnAttnProcess";
            this.btnAttnProcess.Size = new System.Drawing.Size(68, 26);
            this.btnAttnProcess.TabIndex = 194;
            this.btnAttnProcess.Text = "Send";
            this.btnAttnProcess.UseVisualStyleBackColor = true;
            this.btnAttnProcess.Visible = false;
            this.btnAttnProcess.Click += new System.EventHandler(this.btnAttnProcess_Click);
            // 
            // frmOTEditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(913, 604);
            this.Controls.Add(this.btnAttnProcess);
            this.Controls.Add(this.chkOtDel);
            this.Controls.Add(this.txtotdelete);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.txtDed);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.PicSave);
            this.Controls.Add(this.lblMgs);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.baudRatelLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEmpID);
            this.Controls.Add(lebFlag);
            this.Controls.Add(lebFormHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOTEditInfo";
            this.Text = "frmClintInfo";
            this.Load += new System.EventHandler(this.frmOTEditInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEmpID;
        private System.Windows.Forms.Label baudRatelLabel;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.PictureBox PicSave;
        private System.Windows.Forms.Label lblMgs;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDed;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtotdelete;
        private System.Windows.Forms.CheckBox chkOtDel;
        private System.Windows.Forms.Button btnAttnProcess;
    }
}