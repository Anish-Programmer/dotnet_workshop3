using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Operators
    {

        // function to add two numbers 
        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum of {a} and {b} is {a+b}");
        }

        // function to subtract two numbers 
        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference of {a} and {b} is {a - b}");
        }

        // function to multiply two numbers
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Product of {a} and {b} is {a*b}");
        }

        // function to divide two numbers
        public void Divide(int a, int b)
        {
            Console.WriteLine($"Division of {a} and {b} is {a/b}");
        }


        // oddEvenFinder function
        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";

            Console.WriteLine($"{number} is {result}");
        }

    }
}
