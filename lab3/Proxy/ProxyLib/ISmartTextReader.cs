using System;

namespace ProxiLib
{
    public interface ISmartTextReader
    {
        char[][]? ReadFile(string filepath);
    }
}
