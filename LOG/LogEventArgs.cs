using System;

namespace CameraCTRL.LOG
{
    class LogEventArgs : EventArgs
    {
        public string LogMessage;

        public LogEventArgs(string log)
        {
            LogMessage = log;
        }
    }
}