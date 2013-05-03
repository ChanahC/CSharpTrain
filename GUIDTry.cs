using System;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
            Guid id = Guid.NewGuid(); 
            Console.WriteLine( id );
        }
    }
}