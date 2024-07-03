namespace _15_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array -> a variable that can store multiple values, fixed size

            //declaration

            String[] cars = new string[3]; //how many values you want goes in [HERE]    



            //String[] cars = { "BMW", "Mustang", "Corvette" };

            cars[0] = "BMW";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.ReadKey();
        }
    }
}
