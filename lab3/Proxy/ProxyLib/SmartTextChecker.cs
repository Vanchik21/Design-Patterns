using System;

namespace ProxiLib
{
    public class SmartTextChecker : ISmartTextReader
    {
        private ISmartTextReader _reader;

        public SmartTextChecker(ISmartTextReader reader)
        {
            _reader = reader;
        }

        public char[][]? ReadFile(string filepath)
        {
            char[][]? result = _reader.ReadFile(filepath);
            if (result == null)
            {
                Console.WriteLine("Some errors");
                return null;
            }
            Console.WriteLine("Successfully opened, read, and closed the file");
            Console.WriteLine($"Lines: {result.GetLength(0)}, Chars: {CountChars(result)}");
            return result;
        }

        private int CountChars(char[][] arr)
        {
            int count = 0;
            foreach (var line in arr)
            {
                count += line.Length;
            }
            return count;
        }
    }
}
