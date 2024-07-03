namespace _16_for_each_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach -> simpler, more elegant way to iterate, BUT less flexible than a normal for loop

            String[] cars = { "BMW", "Mustang", "Corvette" };
            
            foreach (String car in cars)
            {
                Console.WriteLine(car); //car is just the index
            }
        }
    }
}
