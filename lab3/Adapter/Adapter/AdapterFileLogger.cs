using Adapter;
using System;

namespace Adapter
{
    public enum WriteMode
    {
        Write,
        WriteLine
    };

    public class AdapterFileLogger : Logger
    {
        private readonly FileWriter _adaptee;

        public AdapterFileLogger(FileWriter adaptee)
        {
            _adaptee = adaptee;
        }

        public void LogMessage(string message, WriteMode type)
        {
            Log();
            WriteMessage(message, type);
            Reset();
        }

        public void LogError(string message, WriteMode type)
        {
            Error();
            WriteMessage(message, type);
            Reset();
        }

        public void LogWarning(string message, WriteMode type)
        {
            Warn();
            WriteMessage(message, type);
            Reset();
        }

        private void WriteMessage(string message, WriteMode type)
        {
            if (type == WriteMode.Write)
            {
                _adaptee.Write(message);
            }
            else
            {
                _adaptee.WriteLine(message);
            }
        }
    }
}
