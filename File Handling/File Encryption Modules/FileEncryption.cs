using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Security.AccessControl;
using System.Runtime.InteropServices;
using System.Text;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("This is a test of cryptography!");
            
            try{
                string f = "secret.txt";
                File.Encrypt(f); //this is the encryption method in the File class of C#
                File.Decrypt(f);
            }
            catch(Exception e){
                Console.WriteLine(e);
            }
            
        }
    }
}