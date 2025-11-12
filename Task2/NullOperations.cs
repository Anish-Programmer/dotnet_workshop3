using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class NullOperations
    {
        // 1. creating a method named PerformNullChecks()
        public void PerformNullChecks()
        {
            // 2. declaring a nullable string variable
            string? username = null; // using nullable operator '?' to remove warning

            // 3.. using the Ternary Operator  to check if username is null (? : )
            string message = (username == null) ? "Username is not available" : username;
            Console.WriteLine("Ternary Operator Result: " + message);

            // 4. checking using the Null-Coalescing operator (??)
            // username?? "Username is not available"; // it gives error 

            // solution: assiging the result to a variable
            string checkResult = username ?? "Username is not available";
            // printing the result 
            Console.WriteLine("Null-Coalescing Operator Result: " + checkResult);


            // 5. using the Null-Coalescing Assignment Operator (??=) to assign a default value if username is null
            username ??= "defaultUserName";

            // printing the updated value of username
            Console.WriteLine("After Null-Coalescing Assignment: " + username);
        }
    }
}
