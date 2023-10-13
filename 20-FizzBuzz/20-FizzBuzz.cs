using System;

/*
===============================================================================
PROJECT 20: FIZZ BUZZ
===============================================================================
Objective:
- Understand and practice using loops with conditional statements.

Example Output:
- Here is the output for a classic Fizz Buzz implementation:

    1
    2
    Fizz
    4
    Buzz
    Fizz
    ... and so on, up to 100

Main Tasks:
1. Write a program that prints the integers from 1 to 100, but:
 - For multiples of three, print “Fizz”  (instead of the number)
 - For multiples of five, print “Buzz”  (instead of the number)
 - For multiples of both three and five, print “FizzBuzz”  (instead of the number)

Questions:
1. Why is the order of the conditions in the if statements important?

Extension Tasks:
1. Try modifying the range of numbers the loop iterates over.
2. Experiment with different multiples and add additional conditions to the Fizz Buzz game.
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_20_FizzBuzz
    {
        static void Main(string[] args)
        {
            // Implement Fizz Buzz
            FizzBuzz();

            // Wait at end
            WaitAtEnd();
        }

        static void FizzBuzz()
        {
            // Write your code here

        }

        private static void WaitAtEnd()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
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