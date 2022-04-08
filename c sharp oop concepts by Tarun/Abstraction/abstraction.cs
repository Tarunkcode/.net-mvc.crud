using System;
namespace abstraction.cs
{

    // pure abstract base class
    abstract class Fly
    {
        public abstract float speed(float m, float n);
        public abstract void accleration(float i,float f, float t);
    }

    class Details:Fly
    {
        private float d, t,a,s, init,fin ;
      
       
        public override float speed( float D, float T)
        {
           
            d = D;
            t = T;
            s = D / T;
             return s;
        }

        public override void accleration(float ini, float fi, float ti)
        {
            init = ini;
            fin = fi;
            t = ti;
            a = (fin - init) / ti;
            Console.WriteLine( a);
        }

    }
    // driver class
    class Driver
    {

        static void Main()
        {
        Details bird = new Details();
            Console.WriteLine(bird.speed(2.2f, 1.1f));
            bird.accleration(22.3f, 14.1f, 2f);
        }

    }
}