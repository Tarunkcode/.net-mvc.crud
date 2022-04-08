using System;
namespace MethodOverriding
{
    // using abstract, virtual declerations and base keywords
    public class BaseClass
    {
       // try to override method without using virtual or abstract keyword
       public void show()
        {
            Console.WriteLine("Base Class!");
        }
        // default constructor 
        public BaseClass ()
        {
           Console.WriteLine("you are calling default constructor.");
        }
        // parameterized constructor 
        public BaseClass(string name , int age)
        {
            name = '';
            age = 0;

            getIntro(){
                Console.WriteLine('Hey! I am '+ name + 'and I am' + age + 'years old.')
            }
        }
        // data members 
        int 
        // base class methods 
        public abstract void noface();
        public virtual void haveface()
        {

        }

    }
    public class DerivedClass : BaseClass
    {
        // override show
        new public void show()
        {
            Console.WriteLine("Derived Class!");
        }
        public override void noface()
        {
            Console.WriteLine("");
        }

        public override void haveface()
        {
            
        }


    }
    public class MainClass
    {
        public static void main()
        {
           BaseClass obj1;

            obj1.show();
           DerivedClass obj2 = new DerivedClass();
            obj2.show();
           
        }
       
    }
}