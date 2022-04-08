using System;
namespace prime
{
// static classes
    public static class Wheel
{
        public static float circumference, nrotation;
        public static int radius,distance;
       

        public static float Rotations(int d, int r)
        
        {
            radius = r;
           
            circumference = 6.2f * radius;
            distance = d;
            nrotation = distance / circumference;
            return nrotation;
        }


}
    // derived class
     public static class Driver
    {
        public static void Main()
        {
            var n = Wheel.Rotations(4400, 28);
           
            Console.WriteLine("Wheel has " + n + " no. of rotations");
        }
    }

}
    
    
    