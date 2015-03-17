using LTCountDownTimer.Properties;
using System;
using System.Windows.Forms;

namespace LTCountDownTimer
{
    public partial class TimeUpForm : Form
    {
        private bool _isVisibleCloseBtn = false;

        public TimeUpForm()
        {
            InitializeComponent();
        }

        private void TimeUpForm_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.01;
            if (this.Opacity >= 0.9999)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            _isVisibleCloseBtn = true;
            closeButton.Image = Resources.close;
            closeButton.Cursor = Cursors.Hand;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (_isVisibleCloseBtn == false) return;
            closeButton.Visible = false;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.02;
            if (this.Opacity <= 0.0001)
            {
                timer3.Stop();
                (this.Owner as MainForm).ResetCounter();
                this.Close();
            }
        }
    }
}
