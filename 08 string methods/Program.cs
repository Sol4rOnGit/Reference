namespace _08_string_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Hiresh Solanki";
            String phoneNumber = "123-456-789-0";

            fullName = fullName.ToUpper(); //uppercase

            fullName = fullName.ToLower(); //lowercase

            phoneNumber.Replace("-", "/"); //replace all the dashes with slashes

            String userName = fullName.Insert(0, "@"); //insert "@" at the start (index 0)

            int fullNameLen = fullName.Length; //get length

            //Substring

            String firstName = fullName.Substring(0, 5);

            String lastName = fullName.Substring(7, 7);

            Console.WriteLine(fullNameLen);

            Console.WriteLine(fullName);
            Console.WriteLine(phoneNumber);

            Console.WriteLine("Hello " + firstName + " " + lastName);

            Console.ReadKey();
        }
    }
}
