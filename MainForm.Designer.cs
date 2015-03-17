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
            this.picM = new System.Windows.Forms.PictureBox();
            this.picS1 = new System.Windows.Forms.PictureBox();
            this.picS2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // picM
            // 
            this.picM.Image = global::LTCountDownTimer.Properties.Resources.num5;
            this.picM.Location = new System.Drawing.Point(53, 9);
            this.picM.Name = "picM";
            this.picM.Size = new System.Drawing.Size(20, 34);
            this.picM.TabIndex = 1;
            this.picM.TabStop = false;
            // 
            // picS1
            // 
            this.picS1.Image = global::LTCountDownTimer.Properties.Resources.num0;
            this.picS1.Location = new System.Drawing.Point(84, 9);
            this.picS1.Name = "picS1";
            this.picS1.Size = new System.Drawing.Size(20, 34);
            this.picS1.TabIndex = 2;
            this.picS1.TabStop = false;
            // 
            // picS2
            // 
            this.picS2.Image = global::LTCountDownTimer.Properties.Resources.num0;
            this.picS2.Location = new System.Drawing.Point(107, 9);
            this.picS2.Name = "picS2";
            this.picS2.Size = new System.Drawing.Size(20, 34);
            this.picS2.TabIndex = 3;
            this.picS2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LTCountDownTimer.Properties.Resources.c;
            this.pictureBox1.Location = new System.Drawing.Point(73, 9);
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(137, 49);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picS2);
            this.Controls.Add(this.picS1);
            this.Controls.Add(this.picM);
            this.Controls.Add(this.picProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.5D;
            this.TopMost = true;
            this.MouseCaptureChanged += new System.EventHandler(this.MainForm_MouseCaptureChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProgress;
        private System.Windows.Forms.PictureBox picM;
        private System.Windows.Forms.PictureBox picS1;
        private System.Windows.Forms.PictureBox picS2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

