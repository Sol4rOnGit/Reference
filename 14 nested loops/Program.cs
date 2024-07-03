namespace _14_nested_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nested loop -> loops inside of another loop
            //uses vary, used a lot in sorting algorithms

            Console.WriteLine("How many rows?");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns?");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which symbol?");
            Char symbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
