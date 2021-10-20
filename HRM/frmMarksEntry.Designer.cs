namespace HRM
{
    partial class frmMarksEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarksEntry));
            System.Windows.Forms.Label lebFlag;
            this.label7 = new System.Windows.Forms.Label();
            this.CboClassID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboSub = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboExam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRemarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboStudent = new System.Windows.Forms.ComboBox();
            this.PicSave = new System.Windows.Forms.PictureBox();
            this.lblMgs = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.GridSubject = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.CboGrade = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            lebFormHead = new System.Windows.Forms.Label();
            lebFlag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSubject)).BeginInit();
            this.SuspendLayout();
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
            lebFormHead.Size = new System.Drawing.Size(875, 30);
            lebFormHead.TabIndex = 97;
            lebFormHead.Text = "*** MARKS ENTRY ***";
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
            lebFlag.Size = new System.Drawing.Size(875, 8);
            lebFlag.TabIndex = 102;
            lebFlag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 177;
            this.label7.Text = "Class";
            // 
            // CboClassID
            // 
            this.CboClassID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboClassID.FormattingEnabled = true;
            this.CboClassID.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten"});
            this.CboClassID.Location = new System.Drawing.Point(163, 80);
            this.CboClassID.Name = "CboClassID";
            this.CboClassID.Size = new System.Drawing.Size(200, 21);
            this.CboClassID.TabIndex = 176;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 179;
            this.label6.Text = "Exam Name";
            // 
            // CboSub
            // 
            this.CboSub.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSub.FormattingEnabled = true;
            this.CboSub.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CboSub.Location = new System.Drawing.Point(553, 80);
            this.CboSub.Name = "CboSub";
            this.CboSub.Size = new System.Drawing.Size(200, 21);
            this.CboSub.TabIndex = 178;
            this.CboSub.Leave += new System.EventHandler(this.Cbosub_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 181;
            this.label1.Text = "Subject Name";
            // 
            // CboExam
            // 
            this.CboExam.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboExam.FormattingEnabled = true;
            this.CboExam.Items.AddRange(new object[] {
            "1st Term",
            "MidTerm",
            "Annual",
            "Class Test"});
            this.CboExam.Location = new System.Drawing.Point(163, 103);
            this.CboExam.Name = "CboExam";
            this.CboExam.Size = new System.Drawing.Size(200, 21);
            this.CboExam.TabIndex = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 185;
            this.label4.Text = "Remarks";
            // 
            // TxtMarks
            // 
            this.TxtMarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarks.Location = new System.Drawing.Point(553, 104);
            this.TxtMarks.Name = "TxtMarks";
            this.TxtMarks.Size = new System.Drawing.Size(200, 21);
            this.TxtMarks.TabIndex = 182;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 184;
            this.label3.Text = "Marks";
            // 
            // TxtRemarks
            // 
            this.TxtRemarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRemarks.Location = new System.Drawing.Point(553, 127);
            this.TxtRemarks.Name = "TxtRemarks";
            this.TxtRemarks.Size = new System.Drawing.Size(200, 21);
            this.TxtRemarks.TabIndex = 183;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 187;
            this.label2.Text = "Student No";
            // 
            // CboStudent
            // 
            this.CboStudent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboStudent.FormattingEnabled = true;
            this.CboStudent.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CboStudent.Location = new System.Drawing.Point(163, 127);
            this.CboStudent.Name = "CboStudent";
            this.CboStudent.Size = new System.Drawing.Size(200, 21);
            this.CboStudent.TabIndex = 186;
            // 
            // PicSave
            // 
            this.PicSave.BackColor = System.Drawing.Color.Transparent;
            this.PicSave.Image = ((System.Drawing.Image)(resources.GetObject("PicSave.Image")));
            this.PicSave.Location = new System.Drawing.Point(223, 163);
            this.PicSave.Name = "PicSave";
            this.PicSave.Size = new System.Drawing.Size(160, 81);
            this.PicSave.TabIndex = 197;
            this.PicSave.TabStop = false;
            this.PicSave.Visible = false;
            // 
            // lblMgs
            // 
            this.lblMgs.AutoSize = true;
            this.lblMgs.BackColor = System.Drawing.Color.Transparent;
            this.lblMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMgs.Location = new System.Drawing.Point(229, 260);
            this.lblMgs.Name = "lblMgs";
            this.lblMgs.Size = new System.Drawing.Size(36, 16);
            this.lblMgs.TabIndex = 196;
            this.lblMgs.Text = ".......";
            this.lblMgs.Visible = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDelete.Location = new System.Drawing.Point(70, 255);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(68, 26);
            this.BtnDelete.TabIndex = 194;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(137, 255);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(65, 26);
            this.BtnExit.TabIndex = 195;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnSave.Location = new System.Drawing.Point(7, 255);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(64, 26);
            this.BtnSave.TabIndex = 193;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // GridSubject
            // 
            this.GridSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSubject.Location = new System.Drawing.Point(2, 287);
            this.GridSubject.Name = "GridSubject";
            this.GridSubject.Size = new System.Drawing.Size(863, 178);
            this.GridSubject.TabIndex = 198;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 200;
            this.label5.Text = "Grade";
            // 
            // CboGrade
            // 
            this.CboGrade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboGrade.FormattingEnabled = true;
            this.CboGrade.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B",
            "C",
            "D",
            "F"});
            this.CboGrade.Location = new System.Drawing.Point(553, 151);
            this.CboGrade.Name = "CboGrade";
            this.CboGrade.Size = new System.Drawing.Size(200, 21);
            this.CboGrade.TabIndex = 201;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6500;
            // 
            // frmMarksEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 473);
            this.Controls.Add(this.CboGrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GridSubject);
            this.Controls.Add(this.PicSave);
            this.Controls.Add(this.lblMgs);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtRemarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboExam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CboSub);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CboClassID);
            this.Controls.Add(lebFlag);
            this.Controls.Add(lebFormHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMarksEntry";
            this.Text = "frmMarksEntry";
            this.Load += new System.EventHandler(this.frmMarksEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboClassID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboExam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRemarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboStudent;
        private System.Windows.Forms.PictureBox PicSave;
        private System.Windows.Forms.Label lblMgs;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView GridSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboGrade;
        private System.Windows.Forms.Timer timer1;
    }
}