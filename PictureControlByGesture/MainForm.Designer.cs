using System.Collections.Generic;

namespace PictureControlByGesture
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClickFlag = new System.Windows.Forms.Button();
            this.btnPreviouspic = new System.Windows.Forms.Button();
            this.btnNextPic = new System.Windows.Forms.Button();
            this.btnControlPPT = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericRadius = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialogGetPath = new System.Windows.Forms.FolderBrowserDialog();
            this.timerGetDistance = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.txtInfoLeft = new System.Windows.Forms.TextBox();
            this.txtInfoRight = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRadius)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 422);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.picShow, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStop, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // picShow
            // 
            this.picShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picShow.Location = new System.Drawing.Point(73, 28);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(483, 351);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShow.TabIndex = 2;
            this.picShow.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "左传感器";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(562, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "右传感器";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 385);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(64, 34);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(562, 385);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 34);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "结束";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.btnClickFlag);
            this.panel2.Controls.Add(this.btnPreviouspic);
            this.panel2.Controls.Add(this.btnNextPic);
            this.panel2.Controls.Add(this.btnControlPPT);
            this.panel2.Controls.Add(this.btnChooseFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(73, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 34);
            this.panel2.TabIndex = 17;
            // 
            // btnClickFlag
            // 
            this.btnClickFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClickFlag.Location = new System.Drawing.Point(197, 0);
            this.btnClickFlag.Name = "btnClickFlag";
            this.btnClickFlag.Size = new System.Drawing.Size(93, 34);
            this.btnClickFlag.TabIndex = 11;
            this.btnClickFlag.Tag = "false";
            this.btnClickFlag.Text = "开启点击";
            this.btnClickFlag.UseVisualStyleBackColor = true;
            this.btnClickFlag.Click += new System.EventHandler(this.btnClickFlag_Click);
            // 
            // btnPreviouspic
            // 
            this.btnPreviouspic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviouspic.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPreviouspic.Location = new System.Drawing.Point(104, 0);
            this.btnPreviouspic.Name = "btnPreviouspic";
            this.btnPreviouspic.Size = new System.Drawing.Size(93, 34);
            this.btnPreviouspic.TabIndex = 10;
            this.btnPreviouspic.Text = "上一张";
            this.btnPreviouspic.UseVisualStyleBackColor = true;
            this.btnPreviouspic.Click += new System.EventHandler(this.btnPreviouspic_Click);
            // 
            // btnNextPic
            // 
            this.btnNextPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextPic.Location = new System.Drawing.Point(290, 0);
            this.btnNextPic.Name = "btnNextPic";
            this.btnNextPic.Size = new System.Drawing.Size(78, 34);
            this.btnNextPic.TabIndex = 9;
            this.btnNextPic.Text = "下一张";
            this.btnNextPic.UseVisualStyleBackColor = true;
            this.btnNextPic.Click += new System.EventHandler(this.btnNextPic_Click);
            // 
            // btnControlPPT
            // 
            this.btnControlPPT.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnControlPPT.Location = new System.Drawing.Point(368, 0);
            this.btnControlPPT.Name = "btnControlPPT";
            this.btnControlPPT.Size = new System.Drawing.Size(115, 34);
            this.btnControlPPT.TabIndex = 8;
            this.btnControlPPT.Tag = false;
            this.btnControlPPT.Text = "PPT控制 ←..→";
            this.btnControlPPT.UseVisualStyleBackColor = true;
            this.btnControlPPT.Click += new System.EventHandler(this.btnControlPPT_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChooseFile.Location = new System.Drawing.Point(0, 0);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(104, 34);
            this.btnChooseFile.TabIndex = 7;
            this.btnChooseFile.Text = "选择文件夹";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.Controls.Add(this.numericRadius);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(91, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 19);
            this.panel3.TabIndex = 18;
            // 
            // numericRadius
            // 
            this.numericRadius.BackColor = System.Drawing.Color.White;
            this.numericRadius.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericRadius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericRadius.Location = new System.Drawing.Point(114, -3);
            this.numericRadius.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericRadius.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericRadius.Name = "numericRadius";
            this.numericRadius.Size = new System.Drawing.Size(44, 26);
            this.numericRadius.TabIndex = 1;
            this.numericRadius.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericRadius.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "手势空间半径（cm）:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerGetDistance
            // 
            this.timerGetDistance.Interval = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtInfoLeft);
            this.panel4.Controls.Add(this.txtLeft);
            this.panel4.Location = new System.Drawing.Point(3, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(64, 351);
            this.panel4.TabIndex = 19;
            // 
            // txtLeft
            // 
            this.txtLeft.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLeft.Location = new System.Drawing.Point(0, 0);
            this.txtLeft.Multiline = true;
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.ReadOnly = true;
            this.txtLeft.Size = new System.Drawing.Size(64, 213);
            this.txtLeft.TabIndex = 1;
            this.txtLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtInfoRight);
            this.panel5.Controls.Add(this.txtRight);
            this.panel5.Location = new System.Drawing.Point(562, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(64, 351);
            this.panel5.TabIndex = 20;
            // 
            // txtRight
            // 
            this.txtRight.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRight.Location = new System.Drawing.Point(0, 0);
            this.txtRight.Multiline = true;
            this.txtRight.Name = "txtRight";
            this.txtRight.ReadOnly = true;
            this.txtRight.Size = new System.Drawing.Size(64, 213);
            this.txtRight.TabIndex = 2;
            this.txtRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInfoLeft
            // 
            this.txtInfoLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInfoLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInfoLeft.Location = new System.Drawing.Point(0, 212);
            this.txtInfoLeft.Multiline = true;
            this.txtInfoLeft.Name = "txtInfoLeft";
            this.txtInfoLeft.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtInfoLeft.Size = new System.Drawing.Size(64, 139);
            this.txtInfoLeft.TabIndex = 11;
            this.txtInfoLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInfoRight
            // 
            this.txtInfoRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInfoRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInfoRight.Location = new System.Drawing.Point(0, 212);
            this.txtInfoRight.Multiline = true;
            this.txtInfoRight.Name = "txtInfoRight";
            this.txtInfoRight.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtInfoRight.Size = new System.Drawing.Size(64, 139);
            this.txtInfoRight.TabIndex = 12;
            this.txtInfoRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(629, 422);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "超声手势图片浏览器";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRadius)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGetPath;
        ///
        /// 自定义变量
        /// 
        ///
        //------------------------------------------------------------------//
        private GetPicturePaths getPicturePaths = null;
 //       private SerialPortDistance serialPortDistance = new SerialPortDistance("COM3",9600);
        //= new SerialPortDistance("COM3", 9600);
        //---------------标志--------------//
        private const int NONE = 0;
        private const int LEFT = 1;
        private const int RIGHT = 2;
        private const int LEFT_CENTER_LEFT = 3;
        private const int RIGHT_CENTER_RIGHT = 4;
        private const int LEFT_CENTER = 5;
        private const int RIGHT_CENTER = 6;
        private int gestureFLAG = NONE;
    
        private int LEFT_COUNT = 0;
        private int RIGHT_COUNT = 0;
        private bool PPTControlFlag = false;
        private bool ClikFlag = false;
        private bool GestureDetected = false;
        //-------------------------------------//
        //手势半径
        private int RADIUS = 30;
        //------- ----------------------------------------------------------//
        private System.Windows.Forms.Timer timerGetDistance;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPreviouspic;
        private System.Windows.Forms.Button btnNextPic;
        private System.Windows.Forms.Button btnControlPPT;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnClickFlag;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.TextBox txtInfoLeft;
        private System.Windows.Forms.TextBox txtInfoRight;
    }
}

