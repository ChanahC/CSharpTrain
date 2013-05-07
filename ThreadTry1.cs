using System;
using System.Threading;

public class ThreadTry1{
    public static void Main()
    {
        Thread thread = new Thread(WorkerOperation); 
        /*Thread is in the namespace Threading... it requires a delegate function to be
        * which should have a private static void attribute. The delegate function contains
        * the activities that would be done by the thread. When the thread has a while or a loop that works
        * for a long time, the thread would be doin the job on the delegate function.
        * the delegate function could accept input since when you initialize the thread it just sets
        * the start to call the delegate function.
        */ 
        thread.Start(); //This is to start a thread
        //thread.Suspend(); //This is to pause the threads
        //thread.Resume(); //This is to resume a pause thread
        //thread.Abort(); //This is to destroy thread
        thread.Join(); //it is a function which waits until the activity of the thread is all done
        /*****************************************************************************************************\
        | When you are creating a new class which works like a thread, you should create a run() function.    |
        | On this run function, you could try putting up some functions like Thread.sleep( int millisecs),    |
        | and many more functions.                                                                            |
        \*****************************************************************************************************/
    }
    private static void WorkerOperation()
    {
        Console.WriteLine("Simple worker");
    }
}