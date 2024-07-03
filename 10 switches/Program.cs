﻿namespace _10_switches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch -> an efficient alternative to many else if statements

            Console.WriteLine("What day is it?");
            String day = Console.ReadLine();
            day = day.ToLower();

            switch (day)
            {
                case "monday":
                    Console.WriteLine("It's monday!");
                    break;
                case "tuesday":
                    Console.WriteLine("It's tuesday!");
                    break;
                case "wednesday":
                    Console.WriteLine("It's wednesday!");
                    break;
                case "thursday":
                    Console.WriteLine("It's thursday!");
                    break;
                case "friday":
                    Console.WriteLine("It's friday!");
                    break;
                case "saturday":
                    Console.WriteLine("It's saturday!");
                    break;
                case "sunday":
                    Console.WriteLine("It's sunday!");
                    break;
                default:
                    Console.WriteLine("Thats not a day");
                    break;

            }

            Console.ReadKey();
        }
    }
}
