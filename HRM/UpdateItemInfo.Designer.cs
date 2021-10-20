namespace POS
{
    partial class UpdateItemInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItemInfo));
            this.txtSrchFind = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GrdFnd = new System.Windows.Forms.DataGridView();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SrcItemSize = new System.Windows.Forms.TextBox();
            this.SrcItemType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkIncom = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFnd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSrchFind
            // 
            this.txtSrchFind.BackColor = System.Drawing.Color.Black;
            this.txtSrchFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSrchFind.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrchFind.ForeColor = System.Drawing.Color.Lime;
            this.txtSrchFind.Location = new System.Drawing.Point(154, 8);
            this.txtSrchFind.Name = "txtSrchFind";
            this.txtSrchFind.Size = new System.Drawing.Size(335, 36);
            this.txtSrchFind.TabIndex = 251;
            this.txtSrchFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSrchFind_KeyDown);
            this.txtSrchFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrchFind_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(-1, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 29);
            this.label13.TabIndex = 252;
            this.label13.Text = "Search Text";
            // 
            // GrdFnd
            // 
            this.GrdFnd.AllowUserToAddRows = false;
            this.GrdFnd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GrdFnd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdFnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdFnd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.GrdFnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdFnd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.GrdFnd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdFnd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GrdFnd.ColumnHeadersHeight = 40;
            this.GrdFnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdFnd.DefaultCellStyle = dataGridViewCellStyle3;
            this.GrdFnd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdFnd.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.GrdFnd.Location = new System.Drawing.Point(0, 54);
            this.GrdFnd.Name = "GrdFnd";
            this.GrdFnd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdFnd.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GrdFnd.RowHeadersVisible = false;
            this.GrdFnd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdFnd.RowTemplate.Height = 28;
            this.GrdFnd.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdFnd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GrdFnd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdFnd.Size = new System.Drawing.Size(1338, 545);
            this.GrdFnd.TabIndex = 18;
            this.GrdFnd.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdFnd_CellEndEdit);
            this.GrdFnd.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdFnd_CellEnter);
            this.GrdFnd.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GrdFnd_CellFormatting);
            this.GrdFnd.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.GrdFnd_EditingControlShowing);
            this.GrdFnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdFnd_KeyDown);
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalProduct.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduct.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalProduct.Location = new System.Drawing.Point(1045, 0);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(292, 54);
            this.lblTotalProduct.TabIndex = 255;
            this.lblTotalProduct.Text = "label1";
            this.lblTotalProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(432, 611);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(475, 55);
            this.lblMsg.TabIndex = 256;
            this.lblMsg.Text = "Update successfully...!";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsg.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SrcItemSize
            // 
            this.SrcItemSize.BackColor = System.Drawing.Color.Black;
            this.SrcItemSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrcItemSize.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcItemSize.ForeColor = System.Drawing.Color.Lime;
            this.SrcItemSize.Location = new System.Drawing.Point(777, 8);
            this.SrcItemSize.Name = "SrcItemSize";
            this.SrcItemSize.Size = new System.Drawing.Size(93, 36);
            this.SrcItemSize.TabIndex = 257;
            this.SrcItemSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SrcItemSize_KeyDown);
            this.SrcItemSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SrcItemSize_KeyUp);
            // 
            // SrcItemType
            // 
            this.SrcItemType.BackColor = System.Drawing.Color.Black;
            this.SrcItemType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrcItemType.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcItemType.ForeColor = System.Drawing.Color.Lime;
            this.SrcItemType.Location = new System.Drawing.Point(555, 8);
            this.SrcItemType.Name = "SrcItemType";
            this.SrcItemType.Size = new System.Drawing.Size(159, 36);
            this.SrcItemType.TabIndex = 258;
            this.SrcItemType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SrcItemType_KeyDown);
            this.SrcItemType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SrcItemType_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(718, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 259;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(487, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 260;
            this.label2.Text = "Type";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(885, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 36);
            this.btnClear.TabIndex = 261;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkIncom
            // 
            this.chkIncom.BackColor = System.Drawing.Color.Black;
            this.chkIncom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncom.ForeColor = System.Drawing.Color.Red;
            this.chkIncom.Location = new System.Drawing.Point(1005, 9);
            this.chkIncom.Name = "chkIncom";
            this.chkIncom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.chkIncom.Size = new System.Drawing.Size(34, 36);
            this.chkIncom.TabIndex = 262;
            this.chkIncom.Text = "Show Incomplete";
            this.chkIncom.UseVisualStyleBackColor = false;
            this.chkIncom.Visible = false;
            this.chkIncom.CheckedChanged += new System.EventHandler(this.chkIncom_CheckedChanged);
            // 
            // UpdateItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1338, 674);
            this.Controls.Add(this.chkIncom);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.SrcItemType);
            this.Controls.Add(this.SrcItemSize);
            this.Controls.Add(this.GrdFnd);
            this.Controls.Add(this.txtSrchFind);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotalProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateItemInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Item Information";
            this.Load += new System.EventHandler(this.UpdateItemInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdFnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSrchFind;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView GrdFnd;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox SrcItemSize;
        private System.Windows.Forms.TextBox SrcItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkIncom;
    }
}