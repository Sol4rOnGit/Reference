namespace _17_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method -> performs a section of code, whenever it is called "invoked"
            //          benefits = Lets us reuse code w/o writing it multiple times

            SingHappyBirthday();
            SingHappyBirthday();
            SingHappyBirthday();

            Console.ReadKey();
        }

        static void SingHappyBirthday(string name)
        {
            //method called singhappy birthday

            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"Happy birthday dear {name}");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("");
        }
    }
}
