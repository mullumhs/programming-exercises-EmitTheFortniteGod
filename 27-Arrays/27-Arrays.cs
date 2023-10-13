using System;

/*
===============================================================================
PROJECT 27: ARRAYS
===============================================================================
Objective:
- Understand and practice the basics of arrays in C#.
- Use loops to interact with arrays and manipulate data.

Task 1: Introduction to Arrays
1. Create an array of 5 integers and initialize it with values.
2. Print out the 3rd element to the screen.
3. Change the 4th element to the value 10.
4. Print out the entire array using a loop.

Task 2: User Input and Arrays
1. Create an array of 3 strings.
2. Ask the user to input three names, one at a time, and store each name in the array.
3. Print out the names in reverse order (i.e., the last name entered should be printed first).

Task 3: Array Manipulation and Summation
1. Create an array of 4 floating-point numbers.
2. Ask the user to input four decimal numbers, one at a time, and store each number in the array.
3. Create a float variable called total.
4. Use a loop to calculate the sum of all the numbers in the array and store the sum in total.
5. Print out the total to the screen.
6. Find and print the average of the numbers in the array.

Questions:
1. Can an array store different types of data?
2. What is the difference between a for loop and a foreach loop when iterating through an array?

Extension Tasks:
1. Create an array of 10 numbers. Ask the user for a number and then search to see if it is in the array.
2. Research how to create a 2D array and create one. Print out the array to the screen using nested loops.

===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_27_Arrays
    {
        static void Main(string[] args)
        {
            // Run the examples
            Examples();

            // Complete the following tasks:
            Task1();
            Task2();
            Task3();

            // Wait at End
            WaitForKeyPress("End of the program");
        }

        private static void Task1()
        {
            // Your code here
        }

        private static void Task2()
        {
            // Your code here
        }

        private static void Task3()
        {
            // Your code here
        }

        static void Examples()
        {
            // Array of integers
            int[] intArray = new int[5] { 10, 20, 30, 40, 50 };

            // Accessing an element
            Console.WriteLine(intArray[2]);  // Output: 30

            // Modifying an element
            intArray[1] = 15;
            Console.WriteLine(intArray[1]);  // Output: 15

            // Using a for loop
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            // Output: 10, 15, 30, 40, 50

            // Using a foreach loop
            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }
            // Output: 10, 15, 30, 40, 50

            // Inputting data using a loop
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("Enter a number: ");
                intArray[i] = int.Parse(Console.ReadLine());
            }
        }

        private static void WaitForKeyPress(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
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