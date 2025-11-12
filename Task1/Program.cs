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
            int sum = op.Add(a, b);

            // calling subtract function    
            int difference = op.Subtract(a, b);

            // calling multiply function
            int product = op.Multiply(a, b);

            // calling divide function
            int quotient = op.Divide(a, b);


            // displaying results
            Console.WriteLine("Addition: " + sum);
            Console.WriteLine("Subtraction: " + difference);
            Console.WriteLine("Multiplication: "+ product);
            Console.WriteLine("Division: " + quotient);

            
            // calling OddEvenFinder function
            op.OddEvenFinder(a);
        }

    }
}
