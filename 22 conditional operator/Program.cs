namespace _22_conditional_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conditional operator - used in conditional assignment is something is true or false

            // (condition) ? x : y 

            double temperature = 20;
            string message;

            //using if else

            if (temperature >= 10)
                message = "It's above 10 degrees celcius outside";
            else
                message = "It's less than 10 degrees celcius outside";

            Console.WriteLine(message);

            //using conditional operators

            message = (temperature >= 15) ? "It's warm outside" : "It's cold outside";

            Console.WriteLine(message); //much shorter

            Console.ReadKey();
        }
    }
}
