namespace POS
{
    partial class frmDailyRecord
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
            System.Windows.Forms.Label lebFormHead;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailyRecord));
            System.Windows.Forms.Label lebFlag;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdExit = new System.Windows.Forms.Button();
            this.PicSave = new System.Windows.Forms.PictureBox();
            this.lblMgs = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.dtpAttn = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboEmpId = new System.Windows.Forms.ComboBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboSecName = new System.Windows.Forms.ComboBox();
            this.lebName = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.cboSlNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmdAddNew = new System.Windows.Forms.Button();
            lebFormHead = new System.Windows.Forms.Label();
            lebFlag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lebFormHead
            // 
            lebFormHead.BackColor = System.Drawing.Color.Green;
            lebFormHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lebFormHead.Dock = System.Windows.Forms.DockStyle.Top;
            lebFormHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lebFormHead.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lebFormHead.ForeColor = System.Drawing.Color.White;
            lebFormHead.Image = ((System.Drawing.Image)(resources.GetObject("lebFormHead.Image")));
            lebFormHead.Location = new System.Drawing.Point(0, 0);
            lebFormHead.Name = "lebFormHead";
            lebFormHead.Size = new System.Drawing.Size(884, 30);
            lebFormHead.TabIndex = 96;
            lebFormHead.Text = "*** DAILY RECORD ***";
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
            lebFlag.Size = new System.Drawing.Size(884, 8);
            lebFlag.TabIndex = 101;
            lebFlag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.Transparent;
            this.cmdExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExit.BackgroundImage")));
            this.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(852, 2);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(29, 26);
            this.cmdExit.TabIndex = 190;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // PicSave
            // 
            this.PicSave.BackColor = System.Drawing.Color.Transparent;
            this.PicSave.Image = ((System.Drawing.Image)(resources.GetObject("PicSave.Image")));
            this.PicSave.Location = new System.Drawing.Point(365, 159);
            this.PicSave.Name = "PicSave";
            this.PicSave.Size = new System.Drawing.Size(160, 81);
            this.PicSave.TabIndex = 196;
            this.PicSave.TabStop = false;
            this.PicSave.Visible = false;
            // 
            // lblMgs
            // 
            this.lblMgs.AutoSize = true;
            this.lblMgs.BackColor = System.Drawing.Color.Transparent;
            this.lblMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMgs.Location = new System.Drawing.Point(352, 277);
            this.lblMgs.Name = "lblMgs";
            this.lblMgs.Size = new System.Drawing.Size(36, 16);
            this.lblMgs.TabIndex = 195;
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
            this.cmdDelete.Location = new System.Drawing.Point(117, 277);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(68, 26);
            this.cmdDelete.TabIndex = 5;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Transparent;
            this.cmdSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdSave.Location = new System.Drawing.Point(53, 277);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(64, 26);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            this.cmdSave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdSave_KeyPress);
            // 
            // dtpAttn
            // 
            this.dtpAttn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttn.Location = new System.Drawing.Point(163, 175);
            this.dtpAttn.Name = "dtpAttn";
            this.dtpAttn.Size = new System.Drawing.Size(108, 22);
            this.dtpAttn.TabIndex = 3;
            this.dtpAttn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpAttn_KeyPress);
            this.dtpAttn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtpAttn_KeyUp);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(163, 121);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(223, 22);
            this.txtNote.TabIndex = 1;
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            // 
            // cboEmpId
            // 
            this.cboEmpId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpId.FormattingEnabled = true;
            this.cboEmpId.Location = new System.Drawing.Point(163, 94);
            this.cboEmpId.Name = "cboEmpId";
            this.cboEmpId.Size = new System.Drawing.Size(108, 22);
            this.cboEmpId.TabIndex = 0;
            this.cboEmpId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboEmpId_KeyPress);
            this.cboEmpId.Leave += new System.EventHandler(this.cboEmpId_Leave);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.GridColor = System.Drawing.Color.LightGreen;
            this.Grid.Location = new System.Drawing.Point(54, 334);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.RowTemplate.Height = 18;
            this.Grid.Size = new System.Drawing.Size(545, 213);
            this.Grid.TabIndex = 7;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(54, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 14);
            this.label15.TabIndex = 199;
            this.label15.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 200;
            this.label1.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 202;
            this.label2.Text = "Section Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 14);
            this.label3.TabIndex = 203;
            this.label3.Text = "Attendance Date";
            // 
            // CboSecName
            // 
            this.CboSecName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSecName.FormattingEnabled = true;
            this.CboSecName.Location = new System.Drawing.Point(163, 148);
            this.CboSecName.Name = "CboSecName";
            this.CboSecName.Size = new System.Drawing.Size(108, 22);
            this.CboSecName.TabIndex = 2;
            this.CboSecName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboSecName_KeyPress);
            // 
            // lebName
            // 
            this.lebName.AutoSize = true;
            this.lebName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebName.ForeColor = System.Drawing.Color.Navy;
            this.lebName.Location = new System.Drawing.Point(284, 98);
            this.lebName.Name = "lebName";
            this.lebName.Size = new System.Drawing.Size(13, 13);
            this.lebName.TabIndex = 204;
            this.lebName.Text = "..";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Location = new System.Drawing.Point(187, 277);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 26);
            this.button5.TabIndex = 6;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cboSlNo
            // 
            this.cboSlNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSlNo.FormattingEnabled = true;
            this.cboSlNo.Location = new System.Drawing.Point(163, 67);
            this.cboSlNo.Name = "cboSlNo";
            this.cboSlNo.Size = new System.Drawing.Size(63, 22);
            this.cboSlNo.TabIndex = 0;
            this.cboSlNo.Leave += new System.EventHandler(this.cboSlNo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 207;
            this.label4.Text = "SL No";
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.BackColor = System.Drawing.Color.Transparent;
            this.CmdAddNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddNew.Location = new System.Drawing.Point(230, 65);
            this.CmdAddNew.Name = "CmdAddNew";
            this.CmdAddNew.Size = new System.Drawing.Size(69, 26);
            this.CmdAddNew.TabIndex = 0;
            this.CmdAddNew.Text = "Add New";
            this.CmdAddNew.UseVisualStyleBackColor = false;
            this.CmdAddNew.Click += new System.EventHandler(this.CmdAddNew_Click);
            // 
            // frmDailyRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.CmdAddNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboSlNo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lebName);
            this.Controls.Add(this.CboSecName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.cboEmpId);
            this.Controls.Add(this.PicSave);
            this.Controls.Add(this.lblMgs);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.dtpAttn);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(lebFlag);
            this.Controls.Add(lebFormHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDailyRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDailyRecord";
            this.Load += new System.EventHandler(this.frmDailyRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.PictureBox PicSave;
        private System.Windows.Forms.Label lblMgs;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.DateTimePicker dtpAttn;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboEmpId;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboSecName;
        private System.Windows.Forms.Label lebName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cboSlNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CmdAddNew;
    }
}