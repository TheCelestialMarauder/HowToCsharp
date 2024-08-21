using System;

namespace Basics
{
    class BasicDataTypes
    {
        static void main(string[] args)
        {
            int a; // Declaration

            // The variables are declared but not initialized. 
            // Trying to use them before initialization will result in a compile-time error.

            a = 5; // Initialization

            // You also can declare a variable and immediately initialize it with a value.

            string name = "TCM"; // Declaration + Initialization

            // Now you can use these variables since they have been declared and initialized.

            Console.WriteLine(a);
            Console.WriteLine(name);


            int number = 10;               // Integer
            double pi = 3.14;              // Double (floating point)
            string message = "Hello!";     // String
            bool isCSharpFun = true;       // Boolean

            // Output the variables
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Pi: " + pi);
            Console.WriteLine("Message: " + message);
            Console.WriteLine("Is C# Fun: " + isCSharpFun);
        }
    }

    class BasicOperation
    {
        static void Main(string[] args)
        {
            int a = 5;  
            int b = 3; 

            // Arithmetic operations
            int sum = a + b;             // Adds 'a' and 'b', stores the result in 'sum'
            int difference = a - b;      // Subtracts 'b' from 'a', stores the result in 'difference'
            int product = a * b;         // Multiplies 'a' by 'b', stores the result in 'product'
            double quotient = (double)a / b; // Divides 'a' by 'b', stores the result in 'quotient'
            // Note: We cast 'a' to 'double' to ensure the division result is also a double

            // Output the results of arithmetic operations to the console
            Console.WriteLine("Sum: " + sum);               // Prints "Sum: 8"
            Console.WriteLine("Difference: " + difference); // Prints "Difference: 2"
            Console.WriteLine("Product: " + product);       // Prints "Product: 15"
            Console.WriteLine("Quotient: " + quotient);     // Prints "Quotient: 1.66666666666667"

            // String concatenation
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName; // Concatenates 'firstName', a space, and 'lastName'

            // Output the concatenated string to the console
            Console.WriteLine("Full Name: " + fullName); // Prints "Full Name: John Doe"

            // Modulus operation
            int remainder = a % b; // The modulus operator (%) returns the remainder of the division of 'a' by 'b'
            Console.WriteLine("Remainder: " + remainder); // Prints "Remainder: 2"

            // Compound assignment operations
            a += b; // This is equivalent to 'a = a + b'; adds 'b' to 'a' and stores the result in 'a'
            Console.WriteLine("New value of a after a += b: " + a); // Prints "New value of a after a += b: 8"

            // Increment and Decrement operations
            a++; // This increments the value of 'a' by 1 (equivalent to 'a = a + 1')
            Console.WriteLine("New value of a after a++: " + a); // Prints "New value of a after a++: 9"

            b--; // This decrements the value of 'b' by 1 (equivalent to 'b = b - 1')
            Console.WriteLine("New value of b after b--: " + b); // Prints "New value of b after b--: 2"
        }
    }
}