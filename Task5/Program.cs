namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. calculate and printing the sum of numbers from 1 to N using a loop
            Console.Write("Enter a number N: ");
            int numN = Convert.ToInt32(Console.ReadLine());

            // initializing sum variable
            int sum = 0;

            // Using a for loop to calculate the sum from 1 to N
            for (int i = 1; i <= numN; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum from 1 to {numN} is: {sum}");


            // 2. Printing numbers from 1 to 20 using while loop
            int num = 1;

            while (num <= 20)
            {
                // checking multiples of 4 and skipping them
                if (num % 4 == 0)
                {
                    num++; // incrementing num to avoid infinite loop
                    continue;
                }

                // breaking the loop if number reaches 15
                if (num==15)
                {
                    break;
                }

                // printing the number
                Console.WriteLine(num);
                num++;
            }


            // 3. finding the sum of all the  numbers in an array using a foreach loop
            // creating an array of numbers    
            int[] numbers = { 10, 20, 30, 40, 50 };

            // initalizing sum variable
            int totalSum = 0;

            // using foreach loop to calculate the sum of array elements
            foreach (int number in numbers)
            {
                totalSum += number;
            }

            // printing the total sum of alll the numbers in the array
            Console.WriteLine($"The sum of all numbers in the array is: {totalSum}");


        }


    }
}
