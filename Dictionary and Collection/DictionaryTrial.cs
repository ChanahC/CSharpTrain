using System;
using System.Collections.Generic;

namespace QuickSharp
{
    public class DictionayTrial
    {
        private static void Main()
        {
            //Dictionary<string, double> dict = new Dictionary<string, double>();
            SortedDictionary<string, double> dict = new SortedDictionary<string, double>(); //Sorted form of dictionary
            Console.WriteLine("Enter the number of employees you have: ");
            string line = Console.ReadLine();
            int a = Convert.ToInt32(line);
            int b = 0;
            while(b < a){
                Console.WriteLine("Enter the family name of your employee: ");
                string last = Console.ReadLine();
                Console.WriteLine("Enter the given name of your employee: ");
                string first = Console.ReadLine();
                Console.WriteLine("Enter the salary of the said employee");
                string holder = Console.ReadLine();
                double salary = Convert.ToDouble(holder);
                string wName = first + " " + last;
                dict.Add(wName, salary);
                b++;
            }
            ICollection<string> cole = dict.Keys;
            foreach(string str in cole){
                Console.WriteLine("{0}'s Salary is {1:C}", str, dict[str]);
            }
        }
    }
}




