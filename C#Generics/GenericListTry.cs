using System;
using System.Collections.Generic;

namespace QuickSharp
{
    public class Program{
        private static void Main(){
            List<Idol> imas = new List<Idol>();
            /*
            it initializes a generic collection called list whose objects are called IDOL...
            to create a list of another type... syntax is below:
            List<className> varName = new List<className>();
            */
            imas.Add(new Idol("Shijou Takane", 18)); //adding an Idol object name Shijou Takane with age 18 to the Idol list named imas
            Idol a = imas[0]; //accessing the Idol object on the list of Idols named imas on index 0;
            Console.WriteLine(a.ToString());
            Console.WriteLine("Idols on the list: " + imas.Count); //Count attribute in list returns an int number of objects in the list
            Idol b = new Idol("Hoshii Miki", 15);
            imas.Add(b);
            Console.WriteLine("Idols on the list: " + imas.Count);
            imas.Remove(b); //to be able to delete an object on the list, one must get the exact object to be ablt to delete it from the the list
            Console.WriteLine("Idols on the list: " + imas.Count);
            imas.Add(b);
            imas.Add(new Idol("Miura Azusa", 23));
            imas.Add(new Idol("Hagiwara Yukiho", 17));
            foreach(Idol c in imas){ //this part is for listing the objects on the list
                Console.WriteLine(c.ToString());
            }
            // to be able to change the value of a specific element on the list, use the indexing like on an array
        }
    }
    public class Idol{
        public string name;
        public int age;
        public Idol(string n, int a){
            name = n;
            age = a;
        }
        public override string ToString(){ //overrides the ToString of the Idol object. ToString is one of the generic methods on all objects
            return name + " with age " + age;
        }
    }
}