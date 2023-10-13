using System;

/*
===============================================================================
PROJECT 18: FOR LOOPS
===============================================================================
Objective:
- Understand and practice using for loops to execute code a specified number of times.

Main Tasks:
1. Follow the instructions in the comments within the code below.

Questions:
1. Explain what each part of the FOR loop does:
   a) int i = 0;
   b) i <= 100;
   c) i++;

Extension Tasks:
1. Try using user input before the loop starts to control how many times it loops.
2. Try using selection (if statements) inside the loop to do different things based on the counter.

Additional Resources:
- FOR Loop in C#: https://www.tutorialspoint.com/csharp/csharp_for_loop.htm
- FOR Keyword: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_18_ForLoops
    {
        static void Main(string[] args)
        {
            WaitBetween("From 5 to 15:");

            // 1. Fix the following FOR loop so that it prints from 5 to 15
            for (int i = 9999; i < 9999; i++)
            {
                Console.WriteLine(i);
            }

            WaitBetween("From 20 down to 1:");

            // 2. Fix the following loop so that it counts DOWN
            for (int x = 20; x > 0; x++)
            {
                Console.WriteLine(x);
            }

            WaitBetween("From 90 to 100 by two's:");

            // 3. Make the following loop increment by 2 each time
            for (int count = 90; count <=100; count++)
            {
                Console.WriteLine(count);
            }

            WaitBetween("From 60 down to 30 by three's:");

            // 4. Make your own FOR loop (press TAB twice quickly) 
            // that counts from 60 down to 30 in steps of 3



            WaitBetween("2 to the power of 0 through to 9");

            // 5. Make your own FOR loop (press TAB twice quickly).
            // Use it to print out the values of '2 to the power of 0 through to 9'



            // Wait at end
            WaitAtEnd();
        }

        private static void WaitAtEnd()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void WaitBetween(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/