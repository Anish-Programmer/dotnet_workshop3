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
        public int Add(int a, int b)
        {
            return a + b;
        }

        // function to subtract two numbers 
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // function to multiply two numbers
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // function to divide two numbers
        public int Divide(int a, int b)
        {
            return a / b;
        }


        // oddEvenFinder function
        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";

            Console.WriteLine($"{number} is {result}");
        }

    }
}
