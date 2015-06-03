namespace LTCountDownTimer
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picProgress = new System.Windows.Forms.PictureBox();
            this.picM2 = new System.Windows.Forms.PictureBox();
            this.picS1 = new System.Windows.Forms.PictureBox();
            this.picS2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_VirtualClick = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_BlackOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerForUIEffects = new System.Windows.Forms.Timer(this.components);
            this.picM1 = new System.Windows.Forms.PictureBox();
            this.MenuItem_DoNotStopWhenClickMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picM1)).BeginInit();
            this.SuspendLayout();
            // 
            // picProgress
            // 
            this.picProgress.Image = global::LTCountDownTimer.Properties.Resources.prog00;
            this.picProgress.ImageLocation = "";
            this.picProgress.Location = new System.Drawing.Point(7, 3);
            this.picProgress.Margin = new System.Windows.Forms.Padding(0);
            this.picProgress.Name = "picProgress";
            this.picProgress.Size = new System.Drawing.Size(42, 43);
            this.picProgress.TabIndex = 0;
            this.picProgress.TabStop = false;
            // 
            // picM2
            // 
            this.picM2.Image = global::LTCountDownTimer.Properties.Resources.num5;
            this.picM2.Location = new System.Drawing.Point(72, 9);
            this.picM2.Name = "picM2";
            this.picM2.Size = new System.Drawing.Size(20, 34);
            this.picM2.TabIndex = 1;
            this.picM2.TabStop = false;
            // 
            // picS1
            // 
            this.picS1.Image = global::LTCountDownTimer.Properties.Resources.num0;
            this.picS1.Location = new System.Drawing.Point(103, 9);
            this.picS1.Name = "picS1";
            this.picS1.Size = new System.Drawing.Size(20, 34);
            this.picS1.TabIndex = 2;
            this.picS1.TabStop = false;
            // 
            // picS2
            // 
            this.picS2.Image = global::LTCountDownTimer.Properties.Resources.num0;
            this.picS2.Location = new System.Drawing.Point(126, 9);
            this.picS2.Name = "picS2";
            this.picS2.Size = new System.Drawing.Size(20, 34);
            this.picS2.TabIndex = 3;
            this.picS2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LTCountDownTimer.Properties.Resources.c;
            this.pictureBox1.Location = new System.Drawing.Point(92, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 34);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.MenuItem_VirtualClick,
            this.toolStripMenuItem1,
            this.MenuItem_BlackOut,
            this.MenuItem_DoNotStopWhenClickMainWindow,
            this.MenuItem_Quit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(283, 126);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(279, 6);
            // 
            // MenuItem_VirtualClick
            // 
            this.MenuItem_VirtualClick.Name = "MenuItem_VirtualClick";
            this.MenuItem_VirtualClick.Size = new System.Drawing.Size(282, 22);
            this.MenuItem_VirtualClick.Text = "&Start";
            this.MenuItem_VirtualClick.Click += new System.EventHandler(this.MenuItem_VirtualClick_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(279, 6);
            // 
            // MenuItem_BlackOut
            // 
            this.MenuItem_BlackOut.Name = "MenuItem_BlackOut";
            this.MenuItem_BlackOut.Size = new System.Drawing.Size(282, 22);
            this.MenuItem_BlackOut.Text = "&Black out when timed up";
            this.MenuItem_BlackOut.Click += new System.EventHandler(this.MenuItem_BlackOut_Click);
            // 
            // MenuItem_Quit
            // 
            this.MenuItem_Quit.Name = "MenuItem_Quit";
            this.MenuItem_Quit.Size = new System.Drawing.Size(282, 22);
            this.MenuItem_Quit.Text = "&Quit";
            this.MenuItem_Quit.Click += new System.EventHandler(this.MenuItem_Quit_Click);
            // 
            // timerForUIEffects
            // 
            this.timerForUIEffects.Interval = 50;
            this.timerForUIEffects.Tick += new System.EventHandler(this.timerForUIEffects_Tick);
            // 
            // picM1
            // 
            this.picM1.Image = global::LTCountDownTimer.Properties.Resources.num0;
            this.picM1.Location = new System.Drawing.Point(51, 9);
            this.picM1.Name = "picM1";
            this.picM1.Size = new System.Drawing.Size(20, 34);
            this.picM1.TabIndex = 5;
            this.picM1.TabStop = false;
            // 
            // MenuItem_DoNotStopWhenClickMainWindow
            // 
            this.MenuItem_DoNotStopWhenClickMainWindow.Name = "MenuItem_DoNotStopWhenClickMainWindow";
            this.MenuItem_DoNotStopWhenClickMainWindow.Size = new System.Drawing.Size(282, 22);
            this.MenuItem_DoNotStopWhenClickMainWindow.Text = "&Dont stop when tap/click main window";
            this.MenuItem_DoNotStopWhenClickMainWindow.Click += new System.EventHandler(this.MenuItem_DoNotStopWhenClickMainWindow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(154, 49);
            this.ControlBox = false;
            this.Controls.Add(this.picM1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picS2);
            this.Controls.Add(this.picS1);
            this.Controls.Add(this.picM2);
            this.Controls.Add(this.picProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.5D;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseCaptureChanged += new System.EventHandler(this.MainForm_MouseCaptureChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picM1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProgress;
        private System.Windows.Forms.PictureBox picM2;
        private System.Windows.Forms.PictureBox picS1;
        private System.Windows.Forms.PictureBox picS2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Quit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_BlackOut;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Timer timerForUIEffects;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_VirtualClick;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.PictureBox picM1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_DoNotStopWhenClickMainWindow;
    }
}

