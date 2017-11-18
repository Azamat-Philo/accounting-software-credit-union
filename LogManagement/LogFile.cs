using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LogValidationManagement
{
    public class LogFile
    {
        private string _errorMsg { get; set; }
        private MethodBase _logMsg { get; set; }
        private DateTime? _dateTimeLog { get; set; }
        private int _userId { get; set; }

        public LogFile(MethodBase logMsg, string errorMsg, int userId)
        {
            _logMsg = logMsg;
            _errorMsg = errorMsg;
            _dateTimeLog = _dateTimeLog.GetValueOrDefault();
            _userId = userId;
        }

        public void WriteLog()
        {

        }

        public static void LogData(MethodBase logError, string genericMsg, int userId)
        {
            LogFile lg = new LogFile(logError, genericMsg, userId);
            lg.WriteLog();
        }
    }
}
