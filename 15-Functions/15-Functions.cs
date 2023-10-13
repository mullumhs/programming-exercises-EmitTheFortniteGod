using System;

/*
===============================================================================
PROJECT 15: FUNCTIONS
===============================================================================
Objective:
- Understand and practice creating functions that return values.

Main Tasks:
1. Define a Function:
   - Create a function named `MultiplyNumbers`.
   - This function should accept two parameters, both of type `int`.
   - The function should return the product of these two numbers.

2. Call the Function and Store the Result:
   - Call the `MultiplyNumbers` function, passing the variables `x` and `y` as arguments.
   - Store the result returned by the function in a new variable named `multiplicationResult` of type `int`.

3. Output the Result:
   - Use `Console.WriteLine` to output the value of `multiplicationResult` to the console.

4. Direct Output:
   - Call the `MultiplyNumbers` function again within a `Console.WriteLine` statement, passing any two numbers of your choice as arguments. 
   - This will output the result directly to the console, bypassing the need for a separate variable.


Example:
- Below is an example function that adds two numbers and returns the result:

    private static int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

    // Usage 1:
    int additionResult = AddNumbers(9, 6);
    Console.WriteLine($"9 plus 6 equals {additionResult}");

    // Usage 2:
    Console.WriteLine($"3 plus 7 equals {AddNumbers(3, 7)}");

Questions:
1. What is a function?
2. What does a function do that a method does not?
3. What does it mean to "return" a value?
4. What is a return type?

Extension Tasks:
1. Convert one of the methods from your "AreaCalculator" program into a function.
2. Write a function called "GetName" that asks for the user's first and last name, then returns the full name as a string.

Additional Resources:
- Methods: https://www.tutorialspoint.com/csharp/csharp_methods.htm
- Methods: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
- Return Values: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods#return-values
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_15_Functions
    {
        static void Main(string[] args)
        {
            // Get two numbers from the user
            int x = GetNumber();
            int y = GetNumber();

            // Write your code here

            

            // "Exit" method is called here
            Exit();
        }

        // Create your functions here



        // This is a function I have written to get a number from the user
        private static int GetNumber()
        {
            Console.Write("Enter number: ");
            return int.Parse(Console.ReadLine());
        }

        // This is a method used to wait for any key to be pressed
        private static void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/