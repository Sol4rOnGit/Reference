namespace _09_if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if statement = a basic form of decision making

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You can make a bank account! Continue...");
            }
            else if (age < 0)
            {
                Console.WriteLine("What, you havent been born yet");
            }
            else if (age > 100)
            {
                Console.WriteLine("You're too old to sign up lil bro"); //wont run because it runs in an order!! make sure if statements are done in correct orders
            }
            else
            {
                Console.WriteLine("You are too young");
            }

            //Check if input is used

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if(name == "")
                Console.WriteLine("Write your name lil bro"); //you dont need to use {} for if statements
            else
                Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}
