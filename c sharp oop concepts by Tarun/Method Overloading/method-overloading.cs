// Method overloading

//By Changing order of parameters
//By changing no. of parameters
using System;
namespace methodoverloaded
{
    
//By changing datatype of parameters 
    public class Pressure
    {
        double pressure;
        public double Find(int a, double f) {
            
            pressure = f/a;
            return pressure;
        }
        public double Find(double a , int f)
        {
            
            pressure = f / a;
            return pressure;
        }
    }
    public class Driver
    {
    public static int Main()
    {
            Pressure Air = new Pressure();
            Console.WriteLine(Air.Find(300, 22.0));
            Console.WriteLine(Air.Find(300.0, 22));
        return 0;
    }

    }
}