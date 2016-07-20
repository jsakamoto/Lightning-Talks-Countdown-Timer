using System;

namespace LTCountDownTimer
{
    public class Option
    {
        public int TimeLimit { get; set; } = 5;

        public bool BlackOutWhenTimedUp { get; set; } = true;

        public bool DontStopWhenClickMainWnd { get; set; } = true;
    }
}
