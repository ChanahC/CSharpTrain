using System;
using System.IO;

namespace QuickSharp
{
    public class FileIO
    {
        private static void Main()
        {
            StreamWriter test;
            try{
                test = new StreamWriter("test.txt"); //Sets the StreamWriter Object to test.txt
            }catch(IOException e){
                Console.WriteLine("Error in opening the file!");
                return ;
            }
            Console.WriteLine("Enter your message");
            string line = Console.ReadLine();
            Console.SetOut(test); //Sets the OutputStream for the Console to be test.txt
            Console.WriteLine("Your message is : " + line);
            test.Close(); //Closes the stream
        }
    }
}