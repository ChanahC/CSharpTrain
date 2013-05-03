using System;

namespace QuickSharp
{
    public class Train1
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
                int a = 10;
                Base1 b = new Base1();
                basic object orientated programming in C#
                b.chan();
                b.helloer(a);
                Console.WriteLine("");
                this part is where you do the randomization
                Random rnd = new Random();
                int c = rnd.Next(15);
                RandomGame d = new RandomGame(c);
                d.playGame();
                StringGame g = new StringGame(2);
                g.playGame();
                Console.WriteLine("Enter a string to play with");
                string send = Console.ReadLine();
                StringBuild build = new StringBuild(send);
                build.replace();
                Console.WriteLine("Insertion Location");
                string line = Console.ReadLine();
                int hula = Convert.ToInt32(line);
                Console.WriteLine("String to insert: ");
                line = Console.ReadLine();
                build.insertB(hula, line);
        }
    }
    public class Base1{
        
        public void chan(){
                Console.WriteLine("Hello Hello Hello");
        }
        public void helloer(int a1){
            int z = 0;
            for(z=0; z < a1; z++){
                Console.WriteLine("Current Count: " + z);
            }
        }
        
    }
    
    public class RandomGame{
        public int number;
        public RandomGame(int a){
            number = a;
        }
        public void playGame(){
            int hula = 0;
            while(hula!= number){
                Console.WriteLine("Enter your hula:");
                string line = Console.ReadLine(); //equivalent to scanf of C
                hula = Convert.ToInt32(line); //Convertion from String to Int
                if(hula < number){
                    Console.WriteLine("Dagdagan mo pa!");
                }
                else if(hula > number){
                    Console.WriteLine("Try mo kaya bawasan");
                }
            }
            Console.WriteLine("Tumama ka rin sa wakas!");
        }
    }
    
    public class StringGame{
        public string a;
        public int rounds;
        public StringGame(int b){
            rounds = b;
        }
        public void playGame(){
            int rndcnt = 0;
            while(rndcnt < rounds){
                string c = "";
                while(c.Length < 4){ //it demonstrates strlen of C in C#
                    Console.WriteLine("Enter a string: ");
                    c = Console.ReadLine();
                    if(c.Length >= 4){
                        int half = 0;
                        if((c.Length % 2) == 1){
                            half = c.Length / 2;
                            half = half + 1;
                        }
                        else{
                            half = c.Length / 2;
                        }
                        Console.WriteLine(c[half - 1]); //Demonstrates the feature equal to charAt of Java;
                    }
                }
                rndcnt++;
            }
        }
    }
    
    public class StringBuild{
        public string str;
        public StringBuild(string a){
            str = a;
        }
        //the next 2 functions demonstrates insertion of stuff to a string.
        public void insertB(int a){
            string b = str.Insert(a, "と");
            Console.WriteLine("Original : " + str + "\nNew : " + b);
        }
        
        public void insertB(int a, string b){
            string c = str.Insert(a, b);
            Console.WriteLine("Original : " + str + "\nNew : " + c);
        }
        //this is how replacing parts of a string works.
        public void replace(){
            str = str.Replace("i", "ito");
            Console.WriteLine(str);
        }
        
    }
    
    public class ArrayMode{
        public void tryArray(){
            string[] a = new string[5];
            int[] b = new int[5];
        }
    }
    
    public class MultiDim{
        public void MultiDimX(){
            int[,] x = new int[4,5];
        }
    }
    
    
    
}