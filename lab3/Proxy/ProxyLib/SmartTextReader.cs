﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ProxiLib
{
    public class SmartTextReader : ISmartTextReader
    {
        public char[][]? ReadFile(string filepath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                List<char[]> contentList = new List<char[]>();

                foreach (var line in lines)
                {
                    char[] charArray = line.ToCharArray();
                    contentList.Add(charArray);
                }
                return contentList.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return null;
            }
        }
    }
}
