using System;
using System.Collections;
using System.IO;
namespace QuickSharp
{
    public class EnvironmentTest
    {
        private static void Main()
        {
            Console.WriteLine("Stack Trace: " + Environment.StackTrace); 
            Console.WriteLine("Command Line: "+ Environment.CommandLine); //The program name.
            Console.WriteLine("Current Directory: {0}", Environment.CurrentDirectory); //Getting the execution path
            Console.WriteLine("Machine Name: {0}", Environment.MachineName); //Getting the name of the machine used for execution
            Console.WriteLine("Stack Trace: {0}", Environment.StackTrace); //Stack Trace
            Console.WriteLine("System Directory: {0}", Environment.SystemDirectory); //Gets the path where the system files are located
            Console.WriteLine("Tick Count: {0}", Environment.TickCount); //Tick counts
            Console.WriteLine("Version: {0}", Environment.Version); //Gets the compiler version
            Console.WriteLine("Working Set: {0}", Environment.WorkingSet);
            Console.WriteLine("Current OS: {0}", Environment.OSVersion); //gets the OS version
            //Gets the drives on the execution unit
            string[] drives = Environment.GetLogicalDrives();
            for(int i = 0; i < drives.Length; i++)
                Console.WriteLine("Drive {0} : {1}",  i, drives[i]);
            //Getting environment variables. The values return a Dictionary.
            Console.WriteLine("Environment Variables");
            foreach (DictionaryEntry var in Environment.GetEnvironmentVariables())
                Console.WriteLine("{0}={1}", var.Key, var.Value);
            //Gets the list of processes using the commandline
            Console.WriteLine(Environment.CommandLine);
            foreach (string s in Environment.GetCommandLineArgs()){
                Console.WriteLine(s);
            }
            //creates a new line in the command line
            Console.Write(Environment.NewLine);
            //enumerates the special folders in the system
            foreach (Environment.SpecialFolder s in Enum.GetValues(typeof(Environment.SpecialFolder))) {
                Console.WriteLine("{0} folder : {1}", s, Environment.GetFolderPath(s));
            }
            //To write the error that occured... use this function Console.Error.WriteLine(exc.message); where exc is an exception
        }
    }
}