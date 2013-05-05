using System;
using System.IO;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\TaeNy\\Downloads");
            FileInfo[] files = dir.GetFiles("*.gif"); //Get files with file extension .gif
            foreach (FileInfo file in files){
                Console.Write("Name: " + file.Name + "  ");
                Console.WriteLine("Size: " + file.Length.ToString());
            }
        }
    }
}