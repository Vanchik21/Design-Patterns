using System;

namespace Adapter
{
    public class FileWriter
    {
        public void Write(string sth)
        {
            Console.Write("Write something without new line:");
            Console.Write(sth);
        }
        public void WriteLine(string sth)
        {
            Console.WriteLine("\nWrite something with new line:");
            Console.WriteLine(sth);
        }
    }
}
