using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuickSharp
{
    public class CollectionTrial
    {
        private static void Main()
        {
            ICollection<string> myCole = new Collection<string>(); //Initializing a collection of strings
            myCole.Add("Takane"); //Adding elements on a collection
            myCole.Add("Sena");
            myCole.Add("Masuzu");
            myCole.Add("Yusa Emi");
            foreach(string b in myCole){
                Console.WriteLine("myCole contains " + b);
            }
            myCole.Remove("Yusa Emi"); //removing an element on a collection
            Console.WriteLine("Deleted an element");
            bool a = myCole.Contains("Takane"); //tells whether the collection contains a certain element
            //enumerate the elements
            foreach(string b in myCole){
                Console.WriteLine("myCole contains " + b);
            }
            
            //copying the content of a collection to an array
            string[] c = new string[myCole.Count]; // initializes the array with the size equal to myCole
            myCole.CopyTo(c, 0); //Copy to string array c from element 0
            foreach(string d in c){
                Console.WriteLine("String Copy in c: {0}", d);
            }
        }
    }
}