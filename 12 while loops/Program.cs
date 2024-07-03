namespace _12_while_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loops -> repeats some code while a condition remains true

            String name = "";

            while (name != "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
