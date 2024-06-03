using Adapter;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWriter fileWriter = new FileWriter();
            AdapterFileLogger fileLogger = new AdapterFileLogger(fileWriter);

            fileLogger.LogMessage("This is a log message.", WriteMode.WriteLine);
            fileLogger.LogError("This is an error message.", WriteMode.WriteLine);
            fileLogger.LogWarning("This is a warning message.", WriteMode.WriteLine);
        }
    }
}