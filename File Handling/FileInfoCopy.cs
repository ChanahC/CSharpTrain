using System;
using System.IO;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            //Console.WriteLine("Hello World!");
            // when giving the full path of the file... it is suggested to add @ before the string name
            string path1 = @"P-san1.gif";
            FileInfo f1 = new FileInfo(path1);
            string path2 = @"receiver.gif";
            FileInfo f2 = new FileInfo(path2);
            f1.CopyTo(path2);
            Console.WriteLine("{0} is already copied to {1}", path1, path2);
        }
    }
}