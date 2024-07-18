namespace _21_exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* exception handling -> like the try and except that we use in python (in brackets), but instead it is:
             * try - try some code (try)
             * catch - catch the exception (except)
             * fianlly - always done (finally) */

            double x;
            double y;
            double result;

            try
            {
                Console.Write("Enter numbre 1: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ";
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            }
            catch (FormatException e) //specific exception catches
            {
                Console.WriteLine("Enter only numbers please!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("MATH ERROR, cant divide by zero idiot");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!"); //poor practice for this to exist by itself, let user know what went wrong
                // use at the end
            }
            finally
            {
                //optional part of the try-except
                Console.WriteLine("Thanks for using this program!");
            }

            Console.ReadKey();
        }
    }
}
