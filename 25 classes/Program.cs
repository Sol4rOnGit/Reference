namespace _25_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class = a bundle of related code
            //        can be used as a blueprint to create objects (in OOP)

            //e.g. Math class

            Math.Abs(-0.1);

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }

    static class Messages //can be placed in an external class, static allows to be accessed from other classes (more detail in later files)
    {
        public static void Hello()
        {
            Console.WriteLine("Welcome to the program!");
        }

        public static void Waiting()
        {
            Console.WriteLine("I am waiting");
        }
        public static void Bye()
        {
            Console.WriteLine("Goodbye");
        }

    }
}
