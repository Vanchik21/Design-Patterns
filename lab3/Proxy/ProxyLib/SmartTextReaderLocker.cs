using System;
using System.Text.RegularExpressions;

namespace ProxiLib
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private ISmartTextReader _reader;
        private Regex _regex;

        public SmartTextReaderLocker(ISmartTextReader reader, string pattern)
        {
            _reader = reader;
            _regex = new Regex(pattern);
        }

        public char[][]? ReadFile(string filepath)
        {
            if (_regex.IsMatch(filepath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            Console.WriteLine("It's ok");
            return _reader.ReadFile(filepath);
        }
    }
}
