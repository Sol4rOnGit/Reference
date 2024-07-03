namespace _06_Math_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //power and roots

            double x = 3;

            double a = Math.Pow(x, 2); //first value is the base, the 2nd value is the power you are going to raise it to

            double b = Math.Sqrt(a); //find square root

            //absolute

            int negative = -1;

            int positive = Math.Abs(negative);

            //rounding

            double pi = 3.14;
            double y = 4.1;

            double d = Math.Round(pi);

            double e = Math.Ceiling(pi); //round up

            double f = Math.Floor(pi); //round down

            //max and min

            double g = Math.Max(pi, y); //return maximum value

            double h = Math.Min(pi, y); //return minimum value



            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
