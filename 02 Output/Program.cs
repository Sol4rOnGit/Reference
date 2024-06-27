namespace _02_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); //WriteLine is known as a method
            //The semi colon is shown to signify the end.

            //The "Hello, world!" is the string literal

            Console.Write("Hey"); //write line will create a new line, but write will not.

            //typing c and then pressing tab twice automatically does Console.WriteLine()

            /*
             * this
             * is
             * a
             * multiline
             * comment*/

            //Escape sequences

            Console.WriteLine("\tHiresh");

            /*
             * Different escape sequences
             *\a -> bell (alert)
             *\b -> backspace
             *\f -> form feed
             *\n -> new line
             *\r -> carriage return
             *\t -> horizontal tab
             *\v -> vertical tab
             *\' -> single quotation mark
             *\" -> double quotation mark
             *\\ -> backslash
             *\? -> literal question mark*/

            Console.ReadKey(); //program only ends when a keyboard input is received, removing all of the random garbage after the code without this
        }
    }
}
