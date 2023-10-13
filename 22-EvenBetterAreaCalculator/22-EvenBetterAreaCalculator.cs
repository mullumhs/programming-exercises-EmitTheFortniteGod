using System;

/*
===============================================================================
PROJECT 22: EVEN BETTER AREA CALCULATOR
===============================================================================
Objective:
- Enhance the Area Calculator from Project 12 to loop back to the menu after each calculation.

Main Tasks:
1. Implement a while loop to keep displaying the menu until the user chooses to exit.
2. Utilise the provided functions to perform the area calculations based on user's choice.
3. Implement an exit option in the menu to allow users to exit the program.

Extension Tasks:
1. Adapt the 'Distance Conversion' program to loop back to the main menu after each conversion.
2. Adapt the 'Temperature Conversion' program to loop back to the main menu after each conversion.
3. Create an average number calculator that can handle any amount of numbers input by the user.

===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_22_EvenBetterAreaCalculator
    {
        static void Main(string[] args)
        {
            // Your code here

        }

        // Functions for menu and calculations

        private static string RunMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");
            Console.WriteLine("4. Exit");
            return Console.ReadLine();
        }

        private static void CalculateCircle()
        {
            Console.WriteLine();
            Console.Write("Radius: ");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (Math.PI * radius * radius));
        }

        private static void CalculateTriangle()
        {
            Console.WriteLine();
            Console.Write("Base: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Height: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (0.5 * width * height));
        }

        private static void CalculateRectangle()
        {
            Console.WriteLine();
            Console.Write("Width: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Length: ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (width * length));
        }

        private static void ErrorMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Invalid Choice! Press any key to continue...");
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