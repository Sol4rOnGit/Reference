namespace _17_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method -> performs a section of code, whenever it is called "invoked"
            //          benefits = Lets us reuse code w/o writing it multiple times

            string name = "Hiresh";
            int age = 15;

            SingHappyBirthday(name, age);
            SingHappyBirthday(name, age);
            SingHappyBirthday(name, age);

            Console.ReadKey();
        }

        static void SingHappyBirthday(string name, int age)
        {
            //method called singhappy birthday

            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"Happy birthday dear {name}");
            Console.WriteLine($"You are {age} years old");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("");
        }
    }
}
