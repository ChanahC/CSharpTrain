using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;

namespace QuickSharp
{
    public class Decryptor
    {
        [System.Runtime.InteropServices.DllImport("KERNEL32.DLL", EntryPoint="RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);
        
        public static void DecryptFile(string sInputFilename, string sOutputFilename,string sKey){
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            //A 64 bit key and IV is required for this provider.
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Set secret key For DES algorithm.
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Set initialization vector.
            FileStream fsread = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            //Create a file stream to read the encrypted file back.
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            //Create a DES decryptor from the DES instance.
            CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt,CryptoStreamMode.Read);
            //Create crypto stream set to read and do a 
            //DES decryption transform on incoming bytes.
            StreamWriter fsDecrypted = new StreamWriter(sOutputFilename);
            fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
            //Print the contents of the decrypted file.
            fsDecrypted.Flush();
            fsDecrypted.Close();
        }

        private static void Main()
        {
            Console.WriteLine("This is the pair program of the encryptor program done by ChanahC\n");
            Console.WriteLine("Ensure the the file that you want to decrypt is in the same director as this program\n");
            Console.WriteLine("Enter the file to be decrypted!");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the output file: ");
            string output = Console.ReadLine();
            Console.WriteLine("Enter the secret key file: ");
            string secretfile = Console.ReadLine();
            string secret = File.ReadAllText(secretfile);
            // For additional security Pin the key.
            GCHandle gch = GCHandle.Alloc( secret,GCHandleType.Pinned );
            DecryptFile(input, output, secret);
            // Remove the Key from memory. 
            ZeroMemory(gch.AddrOfPinnedObject(), secret.Length * 2);
            gch.Free();
            Console.WriteLine("Decryption Done!");
        }
    }
}