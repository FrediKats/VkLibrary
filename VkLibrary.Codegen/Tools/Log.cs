using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VkLibrary.Codegen.Tools
{
    public class Log
    {
        public static readonly Log Instance = new Log();

        public void Message(string message, [CallerFilePath] string memberName = null)
        {
            Console.WriteLine($"[{memberName?.Split('\\').Last()}] {message}");
        }
    }
}