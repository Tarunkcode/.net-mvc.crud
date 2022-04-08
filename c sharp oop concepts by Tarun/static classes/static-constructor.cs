//  static constructors

using System;
namespace stat.cs
{
  
    public static class StaticClass
    {
        // data fields
        // public static string loginMethods; 

        // static constructor


        public static void Logged(string decide)
        {

           
            string[] user_list = new string[5];
            try
            {
                if (decide == "yes")
                {


                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Enter Name... ");

                        user_list[i] = Console.ReadLine();

                        if (i % 2 == 0)
                        {
                            Console.WriteLine(user_list[i] + " is logged in with google");
                        }
                        else
                        {
                            Console.WriteLine(user_list[i] + " is logged in with id pass");
                            
                        }
                        Console.WriteLine("Are you wants to find status for other user");
                        string decideForOthers = Convert.ToString(Console.ReadLine());
                        decideForOthers = decideForOthers.ToLower();
                        if (decideForOthers != "yes")
                        {
                            Console.WriteLine("Thank you for using us! Have a nice day. ");
                            Environment.Exit(0);
                        }
                        else
                        
                           
                            continue;
                        
                    }          
                }
                else
                {
                    Console.WriteLine(" Login Button");
                    
                }

            }
            catch (Exception ex)
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
            string isLoggedin;
            Console.WriteLine("You can check log in status for 5 times at one instance.");
            Console.WriteLine("Are you logged in ?");
            isLoggedin = Convert.ToString(Console.ReadLine());
            isLoggedin = isLoggedin.ToLower();
            StaticClass.Logged(isLoggedin);
            Console.Read();
        }

    }
}