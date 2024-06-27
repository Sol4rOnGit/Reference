namespace _04_User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?"); //Precede writeline as good practice
            String name = Console.ReadLine(); //Userinput


            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); //Casting and asking

            // ^^ incomplete, should typically use try and except to handle exceptions

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old.");

            Console.ReadKey();
        }
    }
}
