// Default constructor, Copy constructor, private constructor, parameterized constructor and static constructors

using System;
namespace constructors.cs
{
    //public class Construct
   // {
       // public int users_count;
       // public string[] user_names;
       // private object SignupFields;


       

        // Default Constructor
      // public Construct()
        //{
            //this.users_count = 0;;
            //this.user_names = null;
            //this.SignupFields = null;
            //
       // }
        //parameterized constructor

        //public Construct(int u, string[] n, object fields, )
       // {
         //   users_count = u;
         //   user_names = n;
        //    SignupFields = fields;
       // }

        //Copy constructor
      //  public Construct( Construct c)
        //{
          //  users_count = c.users_count;
           // user_names = c.user_names;
           // SignupFields = c.SignupFields;
       // }


        //private constructor : unaccessable
        //private Construct()
        //{
         //   users_count = 100;
       // }
       

    //}

    public static class StaticClass
    {
        // data fields
       // public static string loginMethods; 
       
        // static constructor
        

        public static void Logged(int decide)
        {
        
           Console.WriteLine("Only five users is permitted to logged in at a time and there details are here");
            //string[] user_list = new string [5];
            try
            {
            if (decide == 1)
            {
               
                for( int i =0; i < 5; i++)
                {
                   // user_list[i] = Console.ReadLine();
                  
                    if(i % 2 == 0)
                    {
                        Console.WriteLine("Tarun"+ "is logged in with google");
                    }
                    else
                    {
                        Console.WriteLine("Honey"+ "is logged in with google");
                    }
                }
                Console.WriteLine("Users Housefull");
            }
            else
            {
                Console.WriteLine(" Login Button");
            }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
                 
        
                  
        }   
    }         
          
    // deriver class

             class driver
               {
                  public static void Main()
                  {
                    // int isLoggedin;
                    // isLoggedin = Convert.ToInt32(Console.ReadLine());
                     StaticClass.Logged(1);
                     Console.Read();   
                  }

              }
}