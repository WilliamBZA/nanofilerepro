using System;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace FileIORepro
{
    public class Program
    {
        public static void Main()
        {
            var fileToCopy = File.OpenRead("I:\\filetoread.png");
            Debug.WriteLine($"File to be copied length: {fileToCopy.Length} (should be: 32 064 bytes)");

            Thread.Sleep(Timeout.Infinite);
        }
    }
}