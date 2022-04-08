using System;
namespace tuple.cs
{

    public class Tup
    {
        
        public int x;

    }


    // derived class
    public class Driver
    {
        static void Main()
        {

            Tup obj = new Tup();
            //Creating Tuples 
            //1. By new Keywords 
            Tuple<int, float, string, string, double, int, float> mainobj = 
                new Tuple<int, float, string, string, double, int, float>(1,1.4f,"zdads","adad",4.5,45,3.6f);
            
            //2. By dot create method
            var person = Tuple.Create(1, "xzczx", "z", 34, 3.5f, 3.7,"rr", Tuple.Create(1,3.5));
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(9, 10, 11, 12, 13,3.5,33.4f, Tuple.Create(1,3,4,5,4,"gg")));


            // Accessing Tuple 
            Console.WriteLine(mainobj.Item5);
            Console.WriteLine(person.Rest);
            //Console.WriteLine(person.Rest.Item2);
            //Console.WriteLine(numbers.Item
            //Console.WriteLine(mainobj.Item1);


            //DisplayTuple(person); 

            // Tuple as a method parameter

            


        // tuple as a return type



        }

    }

}
