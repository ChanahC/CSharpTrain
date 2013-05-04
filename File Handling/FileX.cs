using System;
using System.IO;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(File.Exists("FileIO.cs")); //Checking whether the file exists
            foreach (string line in File.ReadAllLines("FileIO.cs")){ //File.ReadAllLines() returns the lines on the file
                Console.WriteLine(line);
            }
            /*This part is intended to create files*/
            FileInfo xfile = new FileInfo("C:\\Users\\TaeNy\\Documents\\C# Practice\\C# Training\\imbaTestFile.txt");
            xfile.Create();
            /*This part is to get the creation data of the file created*/
            Console.WriteLine("Creation: {0}", xfile.CreationTime);
            Console.WriteLine("Full name: {0}", xfile.FullName);
            Console.WriteLine("Full atts: {0}", xfile.Attributes.ToString());
            
        }
    }
}