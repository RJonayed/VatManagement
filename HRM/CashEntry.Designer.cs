namespace POS
{
    partial class CashEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashEntry));
            this.BtnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblTotCol = new System.Windows.Forms.Label();
            this.lblTotPay = new System.Windows.Forms.Label();
            this.lblCashBal = new System.Windows.Forms.Label();
            this.CboType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboSl = new System.Windows.Forms.ComboBox();
            this.CboDescription = new System.Windows.Forms.ComboBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BtnDel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.SystemColors.Control;
            this.BtnNew.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNew.Location = new System.Drawing.Point(12, 11);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(62, 54);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Serial No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAmount.Location = new System.Drawing.Point(529, 34);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(82, 31);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(529, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(613, 11);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(50, 54);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.ColumnHeadersHeight = 25;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Location = new System.Drawing.Point(0, 80);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Grid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Grid.RowTemplate.Height = 20;
            this.Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(957, 469);
            this.Grid.TabIndex = 9;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg.Location = new System.Drawing.Point(742, 25);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(96, 26);
            this.lblMsg.TabIndex = 10;
            this.lblMsg.Text = "MESSAGE";
            this.lblMsg.Visible = false;
            // 
            // lblTotCol
            // 
            this.lblTotCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotCol.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCol.ForeColor = System.Drawing.Color.White;
            this.lblTotCol.Location = new System.Drawing.Point(12, 556);
            this.lblTotCol.Name = "lblTotCol";
            this.lblTotCol.Size = new System.Drawing.Size(218, 31);
            this.lblTotCol.TabIndex = 11;
            this.lblTotCol.Text = "Total Collection : ";
            this.lblTotCol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotPay
            // 
            this.lblTotPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotPay.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotPay.ForeColor = System.Drawing.Color.White;
            this.lblTotPay.Location = new System.Drawing.Point(236, 556);
            this.lblTotPay.Name = "lblTotPay";
            this.lblTotPay.Size = new System.Drawing.Size(218, 31);
            this.lblTotPay.TabIndex = 12;
            this.lblTotPay.Text = "Total Payment :";
            this.lblTotPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCashBal
            // 
            this.lblCashBal.BackColor = System.Drawing.Color.LimeGreen;
            this.lblCashBal.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashBal.ForeColor = System.Drawing.Color.White;
            this.lblCashBal.Location = new System.Drawing.Point(460, 556);
            this.lblCashBal.Name = "lblCashBal";
            this.lblCashBal.Size = new System.Drawing.Size(247, 31);
            this.lblCashBal.TabIndex = 13;
            this.lblCashBal.Text = "Cash Balance :";
            this.lblCashBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CboType
            // 
            this.CboType.AutoCompleteCustomSource.AddRange(new string[] {
            "Payment",
            "Collection"});
            this.CboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.CboType.FormattingEnabled = true;
            this.CboType.Items.AddRange(new object[] {
            "Payment",
            "Collection"});
            this.CboType.Location = new System.Drawing.Point(179, 34);
            this.CboType.Name = "CboType";
            this.CboType.Size = new System.Drawing.Size(109, 31);
            this.CboType.TabIndex = 14;
            this.CboType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboType_KeyDown);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(181, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Entry Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CboSl
            // 
            this.CboSl.AutoCompleteCustomSource.AddRange(new string[] {
            "Payment",
            "Collection"});
            this.CboSl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboSl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboSl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.CboSl.FormattingEnabled = true;
            this.CboSl.Location = new System.Drawing.Point(77, 34);
            this.CboSl.Name = "CboSl";
            this.CboSl.Size = new System.Drawing.Size(98, 31);
            this.CboSl.TabIndex = 16;
            this.CboSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboSl_KeyPress);
            this.CboSl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CboSl_KeyUp);
            this.CboSl.Leave += new System.EventHandler(this.CboSl_Leave);
            // 
            // CboDescription
            // 
            this.CboDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboDescription.DropDownHeight = 50;
            this.CboDescription.DropDownWidth = 300;
            this.CboDescription.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.CboDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CboDescription.FormattingEnabled = true;
            this.CboDescription.IntegralHeight = false;
            this.CboDescription.Items.AddRange(new object[] {
            "bkash Cash in",
            "bkash Cash in",
            "Sale",
            "Flexiload",
            "Flexiload Robi",
            "Flexiload Grameen",
            "Flexiload Airtel",
            "bkash Cash in",
            "bkash Cash in",
            "Sale",
            "Flexiload",
            "Flexiload Robi",
            "Flexiload Grameen",
            "Flexiload Airtel"});
            this.CboDescription.Location = new System.Drawing.Point(294, 34);
            this.CboDescription.Name = "CboDescription";
            this.CboDescription.Size = new System.Drawing.Size(230, 31);
            this.CboDescription.TabIndex = 17;
            this.CboDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboDescription_KeyDown);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 3000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDel.Enabled = false;
            this.BtnDel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Image = ((System.Drawing.Image)(resources.GetObject("BtnDel.Image")));
            this.BtnDel.Location = new System.Drawing.Point(664, 11);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(29, 54);
            this.BtnDel.TabIndex = 18;
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(795, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Final Cash Report";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CashEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(957, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.CboDescription);
            this.Controls.Add(this.CboSl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboType);
            this.Controls.Add(this.lblCashBal);
            this.Controls.Add(this.lblTotPay);
            this.Controls.Add(this.lblTotCol);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.BtnNew);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CashEntry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Cash Entry - Powerpoint Technologies";
            this.Load += new System.EventHandler(this.CashEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblTotCol;
        private System.Windows.Forms.Label lblTotPay;
        private System.Windows.Forms.Label lblCashBal;
        private System.Windows.Forms.ComboBox CboType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboSl;
        private System.Windows.Forms.ComboBox CboDescription;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button button1;
    }
}