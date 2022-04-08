using System;
namespace inheritance.sc
{

    // Objectives
    // multilevel inheritance 
    //inheritance in constructor
    // inheritance in interface
    // abstract classes
    // sealed class
    public class Promise
    {

        public string MakePromise(string p) => p;

    }
    public class Details : Promise
    {



        public string getDetails(string p)
        {
            if (p.Length > 35)

                return "Failed to fulfill promise ";

            else

                return "Promise fulfilled ";

        }

    }
    //class Encapsulation
    public class Encapped
    {

        private string np;
        private int n;
        private string res;
        private int j = 0, k = 0;
        //private string op= "unfind";
        private bool result = false;

        public void NoGuarantee(string[] p)
        {
            int n = p.Length;
            for (int i = 0; i < n; i++)
            {
                if (p[i].Length > 20 && p[i].Length < 30)
                {
                    ++j;
                    res = p[i] + "is full filled! ";
                    Console.WriteLine(res);
                }
                else
                {
                    ++k;
                    res = p[i] + "is failed to fulfill !";
                    Console.WriteLine(res);
                }
            }
        }
        // accessors
        public int NoPromise
        {
            get
            {
                if (j > k)
                {
                    result = true;
                    return j;
                }
                else return k;
            }
            set
            {

                var j1 = j.ToString();
                var k1 = k.ToString();
                //Console.WriteLine(alds);
                if (result) j1 = "max promise fullfilled";
                else k1 = "max promise is not fullfilled";

              
            }
        }

    }
    // Derived Class
    public class Derived
    {
        public static void Main()
        {
            var shyam = new Details();
            var promise = shyam.MakePromise("I will come in time !");
            var result = shyam.getDetails(promise);
            Console.WriteLine(promise);
            Console.WriteLine(result);

            var listOfPromises = new Encapped();
            listOfPromises.NoGuarantee(new string[10] { "adasdasd", "asdasdsad", "jhgsduitd7ewgdjsa", "jhtsduwdt7sxgjwa", "kadsjs", "ksdiwsdjsax", "jsyd", "ksayd", "ksyd", "jsyduwd" });

            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

            Console.WriteLine(listOfPromises.NoPromise);
            Console.WriteLine(listOfPromises.NoPromise = 12);

            
        }

    }
}