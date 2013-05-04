using System;
using System.IO;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
            using (Stream from = new FileStream("P-san1.gif", FileMode.Open)) //initializiing stream using the method "using"
            using (Stream to = new FileStream("imba.gif", FileMode.OpenOrCreate))
            {
                int readCount;
                byte[] buffer = new byte[1024]; //using a buffer in writing.
                while ((readCount = from.Read(buffer, 0, 1024)) != 0){ //Syntax -> Read(byte container, int inclusiveStart, int exclusiveEnd)
                    to.Write(buffer, 0, readCount); //Syntax -> Write(byte container, int start, int limit)
                }
            }
        }
    }
}