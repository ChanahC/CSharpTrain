using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;

namespace QuickSharp
{
    public class Encryptor
    {
        //  Call this function to remove the key from memory after use for security
        [System.Runtime.InteropServices.DllImport("KERNEL32.DLL", EntryPoint="RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);
        
        public static string GenerateKey(){
            // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
            DESCryptoServiceProvider desCrypto =(DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            //
            // Use the Automatically generated key for Encryption. 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }
        public static void EncryptFile(string sInputFilename, string sOutputFilename, string sKey) {
            FileStream fsInput = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            /* The statement above initializes the stream intended to read the input file under the passed variable
            sInputFilename with action Open and Access Type reading
            */
            FileStream fsEncrypted = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
            /*
            The statement above is intended to create a stream that will create the output file
            */
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Set secret key For DES algorithm.
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Set initialization vector.
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            //Create a DES encryptor from the DES instance.
            CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write); 
            //Create crypto stream set to read and do a 
            //DES encryption transform on incoming bytes.
            byte[] bytearrayinput = new byte[fsInput.Length];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length); //reads the content of the input file and tranfers it to the bytearrayinput
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length); //writes an encrypted form of the input to the encrypted file
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
        }
        
        private static void Main()
        {
            Console.WriteLine("This program is created by Christian Arbon with the help of MSDN C# Documentation\n\n");
            Console.WriteLine("Please be sure that the file input is in the same directory as the encryptor file!\n");
            Console.WriteLine("So first input the name of the file that you want to encrypt: ");
            string input = Console.ReadLine();
            Console.WriteLine("Now, input the filename of the encrypted file: ");
            string output = Console.ReadLine();
            string secret = GenerateKey();
            Console.WriteLine(secret);
            StreamWriter xxx;
            try{
                 xxx = new StreamWriter("key.txt"); //Sets the StreamWriter Object to key.txt
                 Console.SetOut(xxx);
                 Console.WriteLine(secret);
                 xxx.Close();
            }catch(IOException e){
                Console.WriteLine("Error in opening the file!");
                return ;
            }
            // For additional security Pin the key.
            GCHandle gch = GCHandle.Alloc( secret,GCHandleType.Pinned );
            EncryptFile(input, output, secret);
            // Remove the Key from memory. 
            ZeroMemory(gch.AddrOfPinnedObject(), secret.Length * 2);
            gch.Free();
            //Console.WriteLine("Encryption Done!");
        }
    }
}