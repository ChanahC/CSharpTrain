using System;
using System.Diagnostics;

namespace QuickSharp
{
    public class ProcessTry
    {
        private static void Main()
        {
            //Part 1 - Starting a process
            Console.WriteLine("Hello World!");
            ProcessStartInfo startInfo = new ProcessStartInfo(); //initializes the process
            startInfo.FileName = "notepad.exe"; //sets the file name of the executable file to be called to be able to open the argument
            startInfo.Arguments = "Train.cs"; //the file or other conditions to be passed for the executable file it process
            Process.Start(startInfo); // Starts the process
            
            //Part 2 - Waiting for the process to end
            
            Process newProc = Process.Start("notepad.exe");  //Executes the file or process in the argument
            Console.WriteLine("New process started."); 
            newProc.WaitForExit(); //It is a while loop that waits until the process is closed
            newProc.Close(); // free resources //Ends the process
            Console.WriteLine("New process ended."); 
            
            //Part 3 - Redirecting the process output
            
            Process p = new Process(); //initializes the process
            p.StartInfo.FileName = "cmd.exe"; //sets the file name of the executable file to be called to be able to open the argument
            p.StartInfo.Arguments = "/c dir *.cs"; //the file or other conditions to be passed for the executable file it process
            p.StartInfo.UseShellExecute = false; //Sets that the process that executes not to use the shell where the caller process runs
            p.StartInfo.RedirectStandardOutput = true; //Sets that the standard output of the process called be recorded by the caller process
            p.Start(); //Starts the process
            string output = p.StandardOutput.ReadToEnd(); //Gets the output
            Console.WriteLine("Output:");
            Console.WriteLine(output);
            
            //Part 4 - Getting the running processes on the system
            
            Process[] rP = Process.GetProcesses("."); //Gets all the processes executed on the system
            foreach(Process xp in rP)
            {
              string info = string.Format("-> PID: {0}\tName: {1}",xp.Id, xp.ProcessName); // Id -> PID, ProcessName -> the name of the file executed to able able to do the process.
              Console.WriteLine(info);
            }
            
            //Part 5 - Killing a running process
            Console.Write("--> Hit a key to launch IE");
            Console.ReadLine();
            Process ieProc = Process.Start("IExplore.exe", "www.java2s.com"); // Launch IE and goes to javaS2 site
            Console.Write("--> Hit a key to kill {0}...", ieProc.ProcessName);
            Console.ReadLine();
            try
            {
              ieProc.Kill(); //Kills the process
            }
            catch{} // In case user already killed it...
        }
    }
}