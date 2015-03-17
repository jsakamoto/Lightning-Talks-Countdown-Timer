using System;
using System.Drawing;
using System.Windows.Forms;
using LTCountDownTimer.Properties;

namespace LTCountDownTimer
{
    public partial class MainForm : Form
    {
        private enum State
        {
            StartPosition,
            Running,
            Aborted,
            Finished
        }

        private State _State;

        private const int _TimeLimit = 5;
        
        private int _SecondsToGo;

        private readonly Bitmap[] _NumImages = new[] {
            Resources.num0,Resources.num1,Resources.num2,Resources.num3,Resources.num4,
            Resources.num5,Resources.num6,Resources.num7,Resources.num8,Resources.num9,
        };

        private readonly Bitmap[] _ProgressImages = new[] {
            Resources.prog00,Resources.prog01,Resources.prog02,Resources.prog03,
            Resources.prog04,Resources.prog05,Resources.prog06,Resources.prog07,
            Resources.prog08,Resources.prog09,Resources.prog10,Resources.prog11,
            Resources.prog12,
        };

        public MainForm()
        {
            this.ControlAdded += MainForm_ControlAdded;
            InitializeComponent();
            ResetCounter();
            //DEBUG: timer1.Interval = 10;
        }

        void MainForm_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseDown += MainForm_MouseDown;
            e.Control.MouseMove += MainForm_MouseMove;
            e.Control.MouseUp += MainForm_MouseUp;
        }
    
        private void VirtualMouseClick()
        {
            switch (_State)
            {
                case State.StartPosition:
                    timer1.Start();
                    _State = State.Running;
                    break;
                case State.Running:
                    timer1.Stop();
                    _State = State.Aborted;
                    break;
                case State.Finished:
                case State.Aborted:
                    ResetCounter();
                    _State = State.StartPosition;
                    break;
            }
        }

        public void ResetCounter()
        {
            _State = State.StartPosition;
            _SecondsToGo = _TimeLimit * 60;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            this.Opacity = 0.5;

            var m = _SecondsToGo / 60;
            picM.Image = _NumImages[m];

            var s = _SecondsToGo % 60;
            var s1 = s / 10;
            var s2 = s % 10;
            picS1.Image = _NumImages[s1];
            picS2.Image = _NumImages[s2];

            var p = 12 * (_TimeLimit * 60 - _SecondsToGo) / (_TimeLimit * 60);
            picProgress.Image = _ProgressImages[p];

            BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _SecondsToGo--;
            if (_SecondsToGo < 0)
            {
                timer1.Stop();
                _State = State.Finished;
                ShowTimeUpForm();
            }
            else
            {
                UpdateDisplay();
            }
        }

        private void ShowTimeUpForm()
        {
            this.Opacity = 1.0;
            var timeUpForm = new TimeUpForm();
            timeUpForm.Show(this);
        }

        private int _mouseState = 0;
        private Point _basePos;
        private Point _windowPos;
        private DateTime _timeAtMouseDonw = DateTime.MaxValue;
        private const int _delay = 200;

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (_mouseState == 0)
            {
                _timeAtMouseDonw = DateTime.Now;
                _basePos = Cursor.Position;
                this.Capture = true;
                _mouseState = 1;
                _windowPos = this.Location;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseState != 1 && _mouseState != 2) return;
            if ((DateTime.Now - _timeAtMouseDonw).TotalMilliseconds < _delay) return;
            _mouseState = 2;
            var newPos = new Point(
                _windowPos.X + Cursor.Position.X - _basePos.X,
                _windowPos.Y + Cursor.Position.Y - _basePos.Y);
            this.Location = newPos;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (_mouseState != 1) return;
            if ((DateTime.Now - _timeAtMouseDonw).TotalMilliseconds < _delay)
                VirtualMouseClick();
            ResetMouseState();
        }

        private void MainForm_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (this.Capture == false)
            {
                ResetMouseState();
            }
        }

        private void ResetMouseState()
        {
            this.Capture = false;
            _mouseState = 0;
            _timeAtMouseDonw = DateTime.MaxValue;
        }
    }
}
