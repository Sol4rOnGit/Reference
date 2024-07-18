namespace _23_string_interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string interpolation = allows us to insert variables into a string literal
             *                        precede a string literal with '$'
             *                        {} are placeholders */

            //done this a million times before, same as python

            int age = 15;

            Console.WriteLine($"You are {age} years old");
        }
    }
}
