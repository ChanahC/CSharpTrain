using System;
using System.Collections.Generic;

namespace QuickSharp
{
    public class KeyTrial
    {
        private static void Main()
        {
            Console.WriteLine("This program is made for controls");
            Console.WriteLine("This program tells what keys are entered");
            ConsoleKeyInfo key;
            do{
                key = Console.ReadKey(true);
                if(key.Key == ConsoleKey.F1){
                    Console.WriteLine("F1 pressed");
                }
                else if(key.Key == ConsoleKey.Backspace){
                    Console.WriteLine("Backspace pressed");
                }
                else if(key.Key == ConsoleKey.Escape){
                    Console.WriteLine("Escape pressed");
                }
                else{
                    Console.WriteLine(key.KeyChar + " pressed");
                }
            }while(key.Key != ConsoleKey.X || key.Modifiers != ConsoleModifiers.Shift);
            
            //if you used && it means that either one of the two is pressed, it would be fine.
            //if you used || it means that when the two keys are pressed, it is the only time to end the activity
        }
    }
}