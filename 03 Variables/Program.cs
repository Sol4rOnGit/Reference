using System.Diagnostics;

namespace _03_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2 steps to creating a variable
             * 1. DECLARATION
             * 2. INITIALIZATION
             */

            int x; //declaration

            x = 123; //initialization

            int y = 321; //combined

            Console.WriteLine(x + y); //math

            int age = 21; //only whole numbers

            float height = 1.7; //decimal
            double heightdouble = 1.8; //floating point and double are both decimals, double being more precise.

            bool alive = true; //true or false

            char symbol = '@'; //only one single character

            String name = "Hiresh";

            String userName = symbol + name;

            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is between " + height + " and " + heightdouble);
            Console.WriteLine("Are you alive?" + alive);
            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your username is " + userName);


            //Constants

            //Immune to changes which are known at compile time and do not change for the life of the program

            double pi = 3.14159; //Can change

            const double PI = 3.14159; //Cannot change, generally use all capitals to signify const

            pi = 420;
            //PI = 420; error, cannot do

            Console.WriteLine(pi + PI);

            //Casting

            /* converting a value to a different data type
             * useful when we accept user input (string) and store it as something else
             * different data types can do different things */

            double a = 3.14;
            int b = Convert.ToInt32(a); //Casts

            Console.WriteLine(b);

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            //all the types

            int c = 123;
            double d = Convert.ToDouble(c);

            String f = Convert.ToString(c);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j);
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}
