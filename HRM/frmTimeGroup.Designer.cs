namespace HRM
{
    partial class frmTimeGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeGroup));
            this.dtpsdate = new System.Windows.Forms.DateTimePicker();
            this.cbogrpno = new System.Windows.Forms.ComboBox();
            this.dtpintime = new System.Windows.Forms.DateTimePicker();
            this.dtpmaxintime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpouttime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmaxot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpotend = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbogname = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrpt = new System.Windows.Forms.TextBox();
            this.Gridtgrp = new System.Windows.Forms.DataGridView();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdReport = new System.Windows.Forms.Button();
            this.cmdpicpath = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Gridtgrp)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpsdate
            // 
            this.dtpsdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpsdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpsdate.Location = new System.Drawing.Point(230, 35);
            this.dtpsdate.Name = "dtpsdate";
            this.dtpsdate.Size = new System.Drawing.Size(93, 21);
            this.dtpsdate.TabIndex = 0;
            this.dtpsdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpsdate_KeyPress);
            // 
            // cbogrpno
            // 
            this.cbogrpno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbogrpno.FormattingEnabled = true;
            this.cbogrpno.Location = new System.Drawing.Point(230, 57);
            this.cbogrpno.Name = "cbogrpno";
            this.cbogrpno.Size = new System.Drawing.Size(154, 21);
            this.cbogrpno.TabIndex = 1;
            this.cbogrpno.LostFocus += new System.EventHandler(this.cbogrpno_lostfocus);
            this.cbogrpno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbogrpno_KeyPress);
            // 
            // dtpintime
            // 
            this.dtpintime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpintime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpintime.Location = new System.Drawing.Point(230, 79);
            this.dtpintime.Name = "dtpintime";
            this.dtpintime.Size = new System.Drawing.Size(93, 21);
            this.dtpintime.TabIndex = 2;
            this.dtpintime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpintime_KeyPress);
            // 
            // dtpmaxintime
            // 
            this.dtpmaxintime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpmaxintime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpmaxintime.Location = new System.Drawing.Point(230, 101);
            this.dtpmaxintime.Name = "dtpmaxintime";
            this.dtpmaxintime.Size = new System.Drawing.Size(93, 21);
            this.dtpmaxintime.TabIndex = 3;
            this.dtpmaxintime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpmaxintime_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Group No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "In Time Start From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Late Count If In In Time Time After";
            // 
            // dtpouttime
            // 
            this.dtpouttime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpouttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpouttime.Location = new System.Drawing.Point(230, 123);
            this.dtpouttime.Name = "dtpouttime";
            this.dtpouttime.Size = new System.Drawing.Size(93, 21);
            this.dtpouttime.TabIndex = 4;
            this.dtpouttime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpouttime_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "OT Start From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Max Ot";
            // 
            // txtmaxot
            // 
            this.txtmaxot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaxot.Location = new System.Drawing.Point(230, 145);
            this.txtmaxot.Name = "txtmaxot";
            this.txtmaxot.Size = new System.Drawing.Size(150, 21);
            this.txtmaxot.TabIndex = 5;
            this.txtmaxot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmaxot_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "OT End Time";
            // 
            // dtpotend
            // 
            this.dtpotend.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpotend.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpotend.Location = new System.Drawing.Point(231, 168);
            this.dtpotend.Name = "dtpotend";
            this.dtpotend.Size = new System.Drawing.Size(91, 21);
            this.dtpotend.TabIndex = 6;
            this.dtpotend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpotend_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Group Name";
            // 
            // cbogname
            // 
            this.cbogname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbogname.FormattingEnabled = true;
            this.cbogname.Location = new System.Drawing.Point(527, 33);
            this.cbogname.Name = "cbogname";
            this.cbogname.Size = new System.Drawing.Size(154, 21);
            this.cbogname.TabIndex = 7;
            this.cbogname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbogname_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Name in Report";
            // 
            // txtrpt
            // 
            this.txtrpt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrpt.Location = new System.Drawing.Point(527, 56);
            this.txtrpt.Name = "txtrpt";
            this.txtrpt.Size = new System.Drawing.Size(154, 21);
            this.txtrpt.TabIndex = 8;
            this.txtrpt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrpt_KeyPress);
            // 
            // Gridtgrp
            // 
            this.Gridtgrp.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridtgrp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.Gridtgrp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridtgrp.Location = new System.Drawing.Point(2, 275);
            this.Gridtgrp.Name = "Gridtgrp";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridtgrp.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gridtgrp.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.Gridtgrp.Size = new System.Drawing.Size(721, 177);
            this.Gridtgrp.TabIndex = 126;
            this.Gridtgrp.DoubleClick += new System.EventHandler(this.Gridtgrp_DoubleClick);
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.Transparent;
            this.cmdDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.Image")));
            this.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdDelete.Location = new System.Drawing.Point(69, 245);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(67, 24);
            this.cmdDelete.TabIndex = 125;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.Transparent;
            this.cmdExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = ((System.Drawing.Image)(resources.GetObject("cmdExit.Image")));
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(136, 245);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(67, 24);
            this.cmdExit.TabIndex = 124;
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
            this.cmdSave.Location = new System.Drawing.Point(2, 245);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(67, 24);
            this.cmdSave.TabIndex = 123;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.GhostWhite;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(497, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 104);
            this.label10.TabIndex = 122;
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label10.Visible = false;
            // 
            // cmdReport
            // 
            this.cmdReport.BackColor = System.Drawing.Color.Transparent;
            this.cmdReport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReport.Image = ((System.Drawing.Image)(resources.GetObject("cmdReport.Image")));
            this.cmdReport.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdReport.Location = new System.Drawing.Point(534, 247);
            this.cmdReport.Name = "cmdReport";
            this.cmdReport.Size = new System.Drawing.Size(189, 24);
            this.cmdReport.TabIndex = 127;
            this.cmdReport.Text = "Sifting Time Group Report";
            this.cmdReport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cmdReport.UseVisualStyleBackColor = false;
            // 
            // cmdpicpath
            // 
            this.cmdpicpath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdpicpath.Location = new System.Drawing.Point(300, 248);
            this.cmdpicpath.Name = "cmdpicpath";
            this.cmdpicpath.Size = new System.Drawing.Size(218, 23);
            this.cmdpicpath.TabIndex = 128;
            this.cmdpicpath.Text = "Set Picture Path";
            this.cmdpicpath.UseVisualStyleBackColor = true;
            this.cmdpicpath.Click += new System.EventHandler(this.cmdpicpath_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTimeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(726, 452);
            this.Controls.Add(this.cmdpicpath);
            this.Controls.Add(this.cmdReport);
            this.Controls.Add(this.Gridtgrp);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtrpt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbogname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpotend);
            this.Controls.Add(this.txtmaxot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpouttime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpmaxintime);
            this.Controls.Add(this.dtpintime);
            this.Controls.Add(this.cbogrpno);
            this.Controls.Add(this.dtpsdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimeGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeGroup";
            this.Load += new System.EventHandler(this.frmTimeGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridtgrp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpsdate;
        private System.Windows.Forms.ComboBox cbogrpno;
        private System.Windows.Forms.DateTimePicker dtpintime;
        private System.Windows.Forms.DateTimePicker dtpmaxintime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpouttime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmaxot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpotend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbogname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrpt;
        private System.Windows.Forms.DataGridView Gridtgrp;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdReport;
        private System.Windows.Forms.Button cmdpicpath;
        private System.Windows.Forms.Timer timer1;
    }
}