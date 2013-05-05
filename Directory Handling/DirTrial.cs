using System;
using System.IO;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine(Directory.Exists(@"C:\\Users")); //for the detecting the existence of a file directory
            Console.WriteLine("Using: " + Directory.GetCurrentDirectory()); //getting the current directory
            //Directory.Delete(@"C:\WinNT\MyFoo"); //for deleting a directory
            DirectoryInfo MyRoot = new DirectoryInfo(Directory.GetCurrentDirectory());
            MyRoot.CreateSubdirectory("XFolder"); // creating a directory using DirectoryInfo
            DirectoryInfo[] MySub = MyRoot.GetDirectories(); //gets the list of directories on the directory of MyRoot
            foreach (DirectoryInfo D in MySub){
              Console.WriteLine(D.Name);
            }

        }
    }
}