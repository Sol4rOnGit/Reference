namespace _05_basic_arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int friends = 5;

            friends = friends + 1;
            friends += 1; //same code, just shorter
            friends++; //increment by 1

            friends = friends - 1; //decrement this time
            friends -= 1; 
            friends--; //decrement by 1

            friends = friends * 2; //multiply (by 2)
            friends *= 2; //shortcut for multiplication

            friends = friends / 2; //division
            //auto rounds in integer division

            double friends2 = 5;

            friends2 = friends2 / 2; //this will divide correctly

            friends2 /= 2; //shorcut


            //modulus

            int remainder = friends % 3; //store remainder

            //useful for checking for evens, odds, etc.

        }
    }
}
