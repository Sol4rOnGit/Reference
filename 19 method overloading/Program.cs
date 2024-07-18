namespace _19_method_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* method overloading -> methods share same name, but different parameters
             *                       name + parameters = unique
             *                       methods must have a unique signature */

            double a;
            double b;
            double c;

            string third;

            double ans;

            Console.WriteLine("Do you want a third number to multiply? (y/n)");

            third = Console.ReadLine();

            Console.WriteLine("Enter number 1: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            b = Convert.ToDouble(Console.ReadLine());

            if(third == "y" || third == "yes")
            {
                Console.WriteLine("Enter number 3: ");
                c = Convert.ToDouble(Console.ReadLine());

                ans = Multiply(a, b, c);
            }
            else
            {
                ans = Multiply(a, b);
            }

            Console.WriteLine(ans);


            Console.WriteLine("Hello, World!");
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

    }
}
