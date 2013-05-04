using System;
using System.IO;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            FileInfo f1 = new FileInfo(@"P-san1.gif");
            f1.MoveTo(@"C:\\P-san1.gif");
            Console.WriteLine("The file has been moved");
        }
    }
}