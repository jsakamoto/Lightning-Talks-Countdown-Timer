using LTCountDownTimer.Properties;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LTCountDownTimer
{
    public partial class TimeUpForm : Form
    {
        private static List<TimeUpForm> _TimeUpForms = new List<TimeUpForm>();

        public static void ShowForm(IWin32Window owner)
        {
            foreach (var screen in Screen.AllScreens)
            {
                var timeUpForm = new TimeUpForm { Bounds = screen.Bounds };
                timeUpForm.ClickCloseButton += TimeUpForm_ClickCloseButton;
                _TimeUpForms.Add(timeUpForm);
                timeUpForm.Show(owner);
            }
        }

        private static void CloseForm(TimeUpForm timeUpForm)
        {
            timeUpForm.Close();
            _TimeUpForms.Remove(timeUpForm);
            timeUpForm.Dispose();
        }

        private static void TimeUpForm_ClickCloseButton(object sender, EventArgs e)
        {
            foreach (var form in _TimeUpForms)
            {
                form.BeginClose();
            }
        }

        private bool _isVisibleCloseBtn = false;

        public event EventHandler ClickCloseButton;

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
            this.ClickCloseButton?.Invoke(this, EventArgs.Empty);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.02;
            if (this.Opacity <= 0.0001)
            {
                timer3.Stop();
                (this.Owner as MainForm).ResetCounter(resetOpacity: true);
                TimeUpForm.CloseForm(this);
            }
        }

        private void BeginClose()
        {
            closeButton.Visible = false;
            timer3.Start();
        }
    }
}
