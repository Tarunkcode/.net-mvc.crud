
//Default constructor, Copy constructor, private constructor, parameterized constructor;
namespace Constructors.cs
{
    public class Construct
    {
        public int users_count;
        public string user_names;
        private object SignupFields;
        public int password;




        //Default Constructor
        public Construct()
        {
            //this.users_count = 0; ;
            //this.user_names = null;
            //this.SignupFields = null;
            //this.password = 0;
            this.users_count = 23; ;
            this.user_names = "Tarun";
            //this.SignupFields = null;
            this.password = 1234;

        }
        // parameterized constructor

        public Construct(int u, string n)
        {
            users_count = u;
            user_names = n;

        }

        // Copy constructor
        public Construct(Construct c)
        {
            users_count = c.users_count;
            user_names = c.user_names;
            SignupFields = c.SignupFields;
        }

        // private constructor : unaccessable
        //private Construct()
        //{
        //    users_count = 100;
        //}
        public string Data
        {

            get
            {
                return "username is: " + user_names +
                       " password is: " + password;
            }

        }

        // deriver class
        public class Driver
        {
            public static void Main()
            {
                var def = new Construct();


                Console.WriteLine(def.users_count);
                Console.WriteLine(def.password);
               

                // alter the datafields in default constructor
                //def.users_count = 12;
                //def.user_names = "Tarun";
                //def.password = 1234;
               
                


                var param = new Construct(100, "Tarun");
                //Construct construct = new Construct(def.users_count = 1, new Array[] { }, def.{ user_name : "Tarun", user});


                // object through copy constructor initialized var given to parameterized constructor
                Construct copy = new Construct(param);

                Console.WriteLine(param.users_count = 500);
                Console.WriteLine(param.user_names= "Umesh");

            }
        }


    }
}