using System;

namespace QuickSharp
{
    public class ConsolePlay
    {
        private static void Main()
        {
            Console.Title = "長谷川貴子愛してるよ！！！"; //Sets the title of the console!
            Console.WriteLine("Just enter!");
            Console.ForegroundColor = ConsoleColor.Blue; //Sets the Foreground color of the console to red
            Console.BackgroundColor = ConsoleColor.Black; //sets the background color of the console to black
            string str = Console.ReadLine();
            Console.Clear(); //Clears the commandline from all the shits
            Console.ResetColor();
            ConsoleKeyInfo x;
            Console.WriteLine("Just press the keys and press x if you want to stop");
            do{
                x = Console.ReadKey(); //reads the key pressed. without this... the whole thing wouldn't be possible
                Console.WriteLine("\nYou pressed: " + x.KeyChar);
                //modifier keys Alt, Ctrl and Shift
                if((ConsoleModifiers.Alt & x.Modifiers) != 0) 
                    Console.WriteLine("Alt key pressed."); 
                if((ConsoleModifiers.Control & x.Modifiers) != 0) 
                    Console.WriteLine("Control key pressed."); 
                if((ConsoleModifiers.Shift & x.Modifiers) != 0) 
                    Console.WriteLine("Shift key pressed.");
            }while(x.KeyChar != 'X');
        }
    }
}