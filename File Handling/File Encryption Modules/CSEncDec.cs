using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;

namespace CSEncryptDecrypt
{
   class ClassMate
   {
      //  Call this function to remove the key from memory after use for security
      [System.Runtime.InteropServices.DllImport("KERNEL32.DLL", EntryPoint="RtlZeroMemory")]
      public static extern bool ZeroMemory(IntPtr Destination, int Length);
		
      // Function to Generate a 64 bits Key.
      static string GenerateKey(){
         // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
         DESCryptoServiceProvider desCrypto =(DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
        //
         // Use the Automatically generated key for Encryption. 
         return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
      }

      static void EncryptFile(string sInputFilename, string sOutputFilename, string sKey) {
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

      static void DecryptFile(string sInputFilename, string sOutputFilename,string sKey){
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

      static void Main(){
         // Must be 64 bits, 8 bytes.
         // Distribute this key to the user who will decrypt this file.
         string sSecretKey;
         
         // Get the Key for the file to Encrypt.
         sSecretKey = GenerateKey();

         // For additional security Pin the key.
         GCHandle gch = GCHandle.Alloc( sSecretKey,GCHandleType.Pinned );
         
         // Encrypt the file.        
         EncryptFile(@"secret.txt", @"Encrypted.txt", sSecretKey);

         // Decrypt the file.
         DecryptFile(@"Encrypted.txt", @"Decrypted.txt", sSecretKey);

         // Remove the Key from memory. 
         ZeroMemory(gch.AddrOfPinnedObject(), sSecretKey.Length * 2);
         gch.Free();
      }
   }
}