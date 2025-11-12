namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. asking user input
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age>13 && age <19 ) 
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 20)
            {
                Console.WriteLine("Adult");
            }

        }
    }
}