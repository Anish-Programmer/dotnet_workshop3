namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. ask input from user and use try-catch-finally to handle possible exceptions
            try
            {
                // asking input from user
                Console.Write("Please enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                // printing the number entered by user
                Console.WriteLine("You entered: " + number);
            }
            // if it throws and exception i.e error, catch in catch block
            //FormatException catching
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number format.");
            }
            finally
            {
                Console.WriteLine("Program Executed.");
            }



            /*2. password validation and using throw keyword
             * to throw exception 
             * if password doesnot met condition
             */

            // asking user to enter password
            Console.Write("Enter yout password : ");
            string? password = Console.ReadLine(); // using nullable operator '?' to remove warning if null

            // based on condition throwing exception
            if (password?.Length < 6) // using null-conditional operator '?.' to avoid null reference exception
            {
                throw new Exception("Password must be at least 6 characters long.");
            }
            else
            {
                Console.WriteLine("Password satisfied the requirement");
            }
        }
    }
}
