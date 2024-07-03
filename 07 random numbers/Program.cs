namespace _07_random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num = random.Next(); //generate a INTEGER number between 0 and 2 billion

            int dice_roll = random.Next(1, 7); //random number between  1 and 6

            double decimalnum = random.NextDouble(); //random decimal numbers


            //dice

            int roll1 = random.Next(1, 7);
            int roll2 = random.Next(1, 7);
            int roll3 = random.Next(1, 7);

            Console.WriteLine("You rolled" + roll1 + " " + roll2 + " " + roll3);

            Console.ReadKey();
        }
    }
}
