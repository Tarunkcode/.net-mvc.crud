using System;
namespace oopsBasic.cs
{
    public class Parent
    {
        // Instance Variables
          string? name ;
        float? height;
        int? age;
        string? bloodGroup;

        public Parent()
        {

        }

        // Constructor Decleration of Class
        public Parent(string name, float height, int age, string bloodGroup)
        {
            this.name = name;
            this.height = height;
            this.age = age;
            this.bloodGroup = bloodGroup;
        }


        //Method 1 
        public string GetSignature(string Name)
        {
            string Signature = Name;
            return Signature;
        }

        //Method 2 
        public void Biodata(string name, int age, char bloodgroup, float height)
        {
            Console.WriteLine(
                 "Hey! I am " + name + " I am "+ + age + " years old. I am " + height + " feet tall " + "& my Blood Group is :"
               + this.bloodGroup);
        }
        // Nested Class 
        public class Children:Parent
        {
            // var inst.
            string ChildName;
            int TOB;
            string ChildBlood;
            float ChildWeight;

            // Child methods 
           public string ChildData(string N, int tob, string childBg, float w)
            {
                return( "Child born time is "+ tob + " hrs, name is "+ N + " has weight and blood group is "+ w+" "+ childBg);

            }


        }
        // Constructor Overloading

        public class Over
        {
            string s;
            int i;
            char k;
            float f;

            //1. by no. of args
            public Over()
            {

            }
            public Over(int p, char r, string q)
            {
                this.i = p;
                this.s = q;
                this.k = r;
            }
            public Over(int j, string k1, char l, float m)
            {
                this.i = j;
                this.s = k1;
                this.k = l;
                this.f = m;

                           
            }
            public void print(int a , char b, string c)
            {
                Console.WriteLine(a + b + c);
            }
            public void post(int t, char u, string v, float w)
            {
                Console.WriteLine(t + u + v + w);
            }
        }

        //2. by chaning order
        //3. by types of args
        //4.Invoke an Overloaded Constructor using “this” keyword
        //5.Overloading of Copy Constructor




        // Main method
        public static void Main()
            {
                var dc = new Parent();
                var Karen = new Parent("Karen", 56.34F, 39, "B+");
                var Baby = new Children();
                Parent Baby2 = new Children();

                Karen.name = "adasd";
                dc.height = 6.3f;
                Karen.Biodata("karen", 39, 'B', 5.6F);

                Console.WriteLine(Karen.GetSignature("Karen"));
                Console.WriteLine(Baby.ChildData("Baby", 2110, "A+", 5.2F));

            Baby2.Biodata("Karen", 28, 'B', 5.6f);

            var l = new Over(10, "tarun", 'k', 5.2f);
            var m = new Over();
            l.post(10, 'k', "tarun", 5.2f);
            m.print(11, 'L', "Orange");
            }

    }
}
