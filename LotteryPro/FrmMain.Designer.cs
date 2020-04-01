namespace LotteryPro
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lbNumberList = new System.Windows.Forms.ListBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNum7 = new System.Windows.Forms.Label();
            this.lblNum6 = new System.Windows.Forms.Label();
            this.lblNum5 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnGroupSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnWriteSelf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.txtNum6 = new System.Windows.Forms.TextBox();
            this.txtNum7 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RandomTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumberList
            // 
            this.lbNumberList.AllowDrop = true;
            this.lbNumberList.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbNumberList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNumberList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumberList.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbNumberList.FormattingEnabled = true;
            this.lbNumberList.ItemHeight = 38;
            this.lbNumberList.Location = new System.Drawing.Point(28, 298);
            this.lbNumberList.Margin = new System.Windows.Forms.Padding(0);
            this.lbNumberList.Name = "lbNumberList";
            this.lbNumberList.Size = new System.Drawing.Size(447, 304);
            this.lbNumberList.TabIndex = 2;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.Location = new System.Drawing.Point(834, 14);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(44, 34);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "▁";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(939, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.Location = new System.Drawing.Point(886, 14);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(44, 34);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "□";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(260, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 57);
            this.label2.TabIndex = 9;
            this.label2.Text = "6+1 体育彩票选号器";
            // 
            // lblNum7
            // 
            this.lblNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum7.ForeColor = System.Drawing.Color.White;
            this.lblNum7.Location = new System.Drawing.Point(858, 174);
            this.lblNum7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum7.Name = "lblNum7";
            this.lblNum7.Size = new System.Drawing.Size(72, 68);
            this.lblNum7.TabIndex = 10;
            this.lblNum7.Text = "0";
            this.lblNum7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum6
            // 
            this.lblNum6.BackColor = System.Drawing.Color.White;
            this.lblNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum6.Location = new System.Drawing.Point(704, 174);
            this.lblNum6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum6.Name = "lblNum6";
            this.lblNum6.Size = new System.Drawing.Size(72, 68);
            this.lblNum6.TabIndex = 11;
            this.lblNum6.Text = "0";
            this.lblNum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum5
            // 
            this.lblNum5.BackColor = System.Drawing.Color.White;
            this.lblNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum5.Location = new System.Drawing.Point(568, 174);
            this.lblNum5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum5.Name = "lblNum5";
            this.lblNum5.Size = new System.Drawing.Size(72, 68);
            this.lblNum5.TabIndex = 12;
            this.lblNum5.Text = "0";
            this.lblNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum4
            // 
            this.lblNum4.BackColor = System.Drawing.Color.White;
            this.lblNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum4.Location = new System.Drawing.Point(434, 174);
            this.lblNum4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(72, 68);
            this.lblNum4.TabIndex = 13;
            this.lblNum4.Text = "0";
            this.lblNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum3
            // 
            this.lblNum3.BackColor = System.Drawing.Color.White;
            this.lblNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum3.Location = new System.Drawing.Point(298, 174);
            this.lblNum3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(72, 68);
            this.lblNum3.TabIndex = 14;
            this.lblNum3.Text = "0";
            this.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNum3.Click += new System.EventHandler(this.lblNum3_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.BackColor = System.Drawing.Color.White;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(164, 174);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(72, 68);
            this.lblNum2.TabIndex = 15;
            this.lblNum2.Text = "0";
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum1
            // 
            this.lblNum1.BackColor = System.Drawing.Color.White;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(28, 174);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(72, 68);
            this.lblNum1.TabIndex = 16;
            this.lblNum1.Text = "0";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(640, 582);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 54);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "清    空  ";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Silver;
            this.btnPrint.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(798, 500);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 136);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "打   印  ";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Silver;
            this.btnSelect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(640, 500);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(140, 54);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "确认选号";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Silver;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(492, 500);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 54);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "随机选号";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Silver;
            this.btnDel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(492, 582);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(140, 54);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "删    除  ";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnGroupSelect
            // 
            this.btnGroupSelect.BackColor = System.Drawing.Color.Silver;
            this.btnGroupSelect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGroupSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnGroupSelect.Image")));
            this.btnGroupSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroupSelect.Location = new System.Drawing.Point(640, 400);
            this.btnGroupSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGroupSelect.Name = "btnGroupSelect";
            this.btnGroupSelect.Size = new System.Drawing.Size(140, 54);
            this.btnGroupSelect.TabIndex = 17;
            this.btnGroupSelect.Text = "随机组选";
            this.btnGroupSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGroupSelect.UseVisualStyleBackColor = false;
            this.btnGroupSelect.Click += new System.EventHandler(this.btnGroupSelect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(494, 417);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "组个数：";
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGroup.Location = new System.Drawing.Point(586, 406);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(42, 39);
            this.txtGroup.TabIndex = 21;
            this.txtGroup.Text = "5";
            // 
            // btnWriteSelf
            // 
            this.btnWriteSelf.BackColor = System.Drawing.Color.Silver;
            this.btnWriteSelf.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteSelf.Image = ((System.Drawing.Image)(resources.GetObject("btnWriteSelf.Image")));
            this.btnWriteSelf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWriteSelf.Location = new System.Drawing.Point(798, 400);
            this.btnWriteSelf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWriteSelf.Name = "btnWriteSelf";
            this.btnWriteSelf.Size = new System.Drawing.Size(140, 54);
            this.btnWriteSelf.TabIndex = 18;
            this.btnWriteSelf.Text = "手写号码";
            this.btnWriteSelf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWriteSelf.UseVisualStyleBackColor = false;
            this.btnWriteSelf.Click += new System.EventHandler(this.btnWriteSelf_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 58);
            this.panel1.TabIndex = 23;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(76, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "喜科堂互联教育";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum1.Location = new System.Drawing.Point(498, 298);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(42, 39);
            this.txtNum1.TabIndex = 21;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum2.Location = new System.Drawing.Point(561, 298);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(42, 39);
            this.txtNum2.TabIndex = 21;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum3
            // 
            this.txtNum3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum3.Location = new System.Drawing.Point(624, 298);
            this.txtNum3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(42, 39);
            this.txtNum3.TabIndex = 21;
            this.txtNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum4
            // 
            this.txtNum4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum4.Location = new System.Drawing.Point(687, 298);
            this.txtNum4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(42, 39);
            this.txtNum4.TabIndex = 21;
            this.txtNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum5
            // 
            this.txtNum5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum5.Location = new System.Drawing.Point(750, 298);
            this.txtNum5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.Size = new System.Drawing.Size(42, 39);
            this.txtNum5.TabIndex = 21;
            this.txtNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum6
            // 
            this.txtNum6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum6.Location = new System.Drawing.Point(813, 298);
            this.txtNum6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum6.Name = "txtNum6";
            this.txtNum6.Size = new System.Drawing.Size(42, 39);
            this.txtNum6.TabIndex = 21;
            this.txtNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum7
            // 
            this.txtNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNum7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum7.Location = new System.Drawing.Point(885, 298);
            this.txtNum7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum7.Name = "txtNum7";
            this.txtNum7.Size = new System.Drawing.Size(42, 39);
            this.txtNum7.TabIndex = 21;
            this.txtNum7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbNumberList);
            this.panel2.Controls.Add(this.txtNum7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNum6);
            this.panel2.Controls.Add(this.lblNum1);
            this.panel2.Controls.Add(this.txtNum5);
            this.panel2.Controls.Add(this.lblNum2);
            this.panel2.Controls.Add(this.txtNum4);
            this.panel2.Controls.Add(this.lblNum3);
            this.panel2.Controls.Add(this.txtNum3);
            this.panel2.Controls.Add(this.lblNum4);
            this.panel2.Controls.Add(this.txtNum2);
            this.panel2.Controls.Add(this.lblNum5);
            this.panel2.Controls.Add(this.txtNum1);
            this.panel2.Controls.Add(this.lblNum6);
            this.panel2.Controls.Add(this.txtGroup);
            this.panel2.Controls.Add(this.lblNum7);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnGroupSelect);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnWriteSelf);
            this.panel2.Location = new System.Drawing.Point(15, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 698);
            this.panel2.TabIndex = 24;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // RandomTimer
            // 
            this.RandomTimer.Interval = 50;
            this.RandomTimer.Tick += new System.EventHandler(this.RandomTimer_Tick);
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1000, 783);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "体育彩票选号器-【喜科堂互联教育】";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNumberList;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNum7;
        private System.Windows.Forms.Label lblNum6;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnGroupSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnWriteSelf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.TextBox txtNum6;
        private System.Windows.Forms.TextBox txtNum7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer RandomTimer;
    }
}