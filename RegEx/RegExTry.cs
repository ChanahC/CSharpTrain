using System;
using System.Text.RegularExpressions;

namespace QuickSharp
{
    public class Program{
        private static void Main(){
            string sample = "Chan, Chan,Chan, Chanx";
            Regex x = new Regex(" |, "); // initializes a regex which detects space or comma and space
            foreach (string sub in x.Split(sample)){ //uses a splitter function given the regex initialized to detect space or comman and space
                Console.WriteLine("{0}", sub);
            }
        }
    }
}