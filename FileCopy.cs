using System;
using System.IO;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            //This program is for copying the files
            Console.WriteLine("Hello World!");
            int i; 
            /*C#'s filestreams can be used for both reading and writing unlike Java's file streams that there
            is a specific type of stream for reading and another type of stream for writing*/
            FileStream fin; 
            FileStream fout; 
            /*This part is for opening the file*/
            try { 
              fin = new FileStream("P-san1.gif", FileMode.Open); //syntax -> FileStream(string filename, FileMode type).... FileMode.Open means the stream opens the files 
            } catch(FileNotFoundException exc) { 
              Console.WriteLine(exc.Message + "\nInput File Not Found"); //exceptions contains printable messages
              return; 
            } 
            /*This part is for create the file which will be the receiver of the file to be copied*/
            try { 
              fout = new FileStream("out.gif", FileMode.Create); 
            } catch(IOException exc) { 
              Console.WriteLine(exc.Message + "\nError Opening Output File"); 
              return; 
            } 
         
            try { 
              do { 
                i = fin.ReadByte(); //It returns 0, 1, -1
                if(i != -1) //ReadByte() returns -1 to denote the end of file
                   fout.WriteByte((byte)i); 
              } while(i != -1); 
            } catch(IOException exc) { 
              Console.WriteLine(exc.Message + "File Error"); 
            } 
         
            fin.Close(); 
            fout.Close();
        }
    }
}