using System;
using ProxiLib;

namespace Proxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SmartTextReader");
            string path = "C:\\Users\\ivank\\OneDrive\\Документы\\Design-Patterns\\lab3\\files\\task4.1.txt.txt";
            SmartTextReader reader = new SmartTextReader();
            var arr = reader.ReadFile(path);
            if (arr != null)
                foreach (var line in arr)
                {
                    Console.WriteLine(line);
                }
            Console.WriteLine("\nSmartTextChecker");
            SmartTextChecker checker = new SmartTextChecker(reader);
            checker.ReadFile(path);

            Console.WriteLine("\nSmartTextReaderLocker 1");
            SmartTextReaderLocker lockerFirst = new SmartTextReaderLocker(reader, ".txt");
            lockerFirst.ReadFile(path);

            Console.WriteLine("\nSmartTextReaderLocker 2");
            SmartTextReaderLocker lockerSecond = new SmartTextReaderLocker(reader, ".pdf");
            lockerSecond.ReadFile(path);
        }
    }

    public interface ISmartTextReader
    {
        char[][]? ReadFile(string filepath);
    }

    public class SmartTextReader : ISmartTextReader
    {
        public char[][]? ReadFile(string filepath)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filepath);
                char[][] content = new char[lines.Length][];
                for (int i = 0; i < lines.Length; i++)
                {
                    content[i] = lines[i].ToCharArray();
                }
                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return null;
            }
        }
    }

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
            Console.WriteLine($"Lines: {result.Length}, Chars: {CountChars(result)}");
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

    public class SmartTextReaderLocker : ISmartTextReader
    {
        private ISmartTextReader _reader;
        private string _pattern;

        public SmartTextReaderLocker(ISmartTextReader reader, string pattern)
        {
            _reader = reader;
            _pattern = pattern;
        }

        public char[][]? ReadFile(string filepath)
        {
            if (filepath.Contains(_pattern))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            Console.WriteLine("It's ok");
            return _reader.ReadFile(filepath);
        }
    }
}
