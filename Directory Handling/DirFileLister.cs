using System;
using System.IO;

namespace QuickSharp
{
    public class DirFileLister{
        private static void Main(){
            string path = @"C:\\Users\\TaeNy\\Google ドライブ";
            string[] f = Directory.GetFiles(path); //gets all files.
            foreach(string a in f){
                Console.WriteLine(a);
            }
        }
    }
}