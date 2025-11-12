using System.ComponentModel;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating two integer variables
           // int a = 20;
            // int b = 10;

                
            // taking input from users
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());


            // creating objects of Operators class
            Operators op = new Operators();


            // calling add function
            op.Add(a, b);

            // calling subtract function    
            op.Subtract(a, b);

            // calling multiply function
            op.Multiply(a, b);

            // calling divide function
            op.Divide(a, b);
            

            // calling OddEvenFinder function
            op.OddEvenFinder(a);
        }

    }
}
