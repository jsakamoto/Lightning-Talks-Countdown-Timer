using System.Configuration;

namespace LTCountDownTimer
{
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    public static class AppSettings
    {
        public static class Debug
        {
            public static string TimerInterval
            {
                get { return ConfigurationManager.AppSettings["debug.timerInterval"]; }
            }
        }

        public static string Timer1
        {
            get { return ConfigurationManager.AppSettings["timer1"]; }
        }

        public static string Timer2
        {
            get { return ConfigurationManager.AppSettings["timer2"]; }
        }

        public static string Timer3
        {
            get { return ConfigurationManager.AppSettings["timer3"]; }
        }

        public static string Timer4
        {
            get { return ConfigurationManager.AppSettings["timer4"]; }
        }

        public static string Timer5
        {
            get { return ConfigurationManager.AppSettings["timer5"]; }
        }

        public static string Timer6
        {
            get { return ConfigurationManager.AppSettings["timer6"]; }
        }

        public static string Timer7
        {
            get { return ConfigurationManager.AppSettings["timer7"]; }
        }

        public static string Timer8
        {
            get { return ConfigurationManager.AppSettings["timer8"]; }
        }

        public static string Timer9
        {
            get { return ConfigurationManager.AppSettings["timer9"]; }
        }
    }
}

