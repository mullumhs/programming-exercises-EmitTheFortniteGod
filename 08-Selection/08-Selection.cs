using System;

/*
===============================================================================
PROJECT 08: SELECTION
===============================================================================
Objective:
- Understand and practice using selection statements in C# to control the flow of a program.

Main Tasks:
1. Based on the provided mark, print out:
    - "Pass" if the mark is 50 or above.
    - "Fail" if the mark is less than 50.
2. Wait for input before ending the program.

Questions:
1. What does the < symbol mean?
2. What does selection mean?
3. Which part executes if the condition is false (the 'if' part or 'else' part)?

Extension Tasks:
1. Try using a float or double instead of an integer for the mark.
2. Research online to find out how to use an "else if" statement.
   Use this information to print out grades for different mark levels (e.g., A, B, C, D).

Example:
- Below is an example of using selection with an if-else statement:

    string name = "Jeff";
    if (name == "Jeff")
    {
        Console.WriteLine("My name is Jeff!");
    }
    else
    {
        Console.WriteLine("My name is NOT Jeff!!!");
    }

Additional Resources:
- Selection: https://www.tutorialspoint.com/csharp/csharp_decision_making.htm
- if-else Statement: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_08_Selection
    {
        static void Main(string[] args)
        {
            // Variables and Input
            Console.Write("Please enter a mark out of 100: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            // Your code goes below here

        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/