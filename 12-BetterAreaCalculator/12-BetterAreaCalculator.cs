using System;

/*
===============================================================================
PROJECT 12: BETTER AREA CALCULATOR
===============================================================================
Objective:
- Learn how to refactor code into more manageable chunks using methods, improving readability and reusability of the code.

Main Tasks:
1. Copy and paste your program from the previous lesson into this one.
2. Write methods for each of the main functions of the program. E.g. ShowMenu, CalculateRectangle, CalculateTriangle, etc.
3. Move the corresponding code into each method.
4. Call the methods from the Main method.

Questions:
1. What is the purpose of splitting the code into smaller chunks (methods)?
2. Why is it important to give a warning message to the user in the else statement?

Extension Tasks:
1. Add a trapezium option to the program. It should also be a separate method.

Example:
- Below is an example of the program's output:

    Choose an Option:
    1. Area of Circle
    2. Area of Rectangle
    3. Area of Triangle

    2

    Enter Width: 3
    Enter Height: 4

    The area of the rectangle is 12

    "Press any key to exit...

Additional Resources:
- Methods: https://www.w3schools.com/cs/cs_methods.php
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_12_BetterAreaCalculator
    {
        static void Main(string[] args)
        {
            // Your code goes below here

            ShowMenu();

            string choice = Console.ReadLine();


            if (choice == "1")
            {
                CalculateCircle();
            }

            else if (choice == "2")
            {
                CRectangle();
            }

            else if (choice == "3")
            {
                CTriangle();
            }



                // readline
                Console.ReadLine();
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Area of a Circle");
            Console.WriteLine("2. Area of a Rectangle");
            Console.WriteLine("3. Area of a Triangle");
        }

        private static void CalculateCircle()
        {
            
            
            Console.Write("What is your radius? ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The area of your circle is {Math.PI * Math.Pow(radius, 2)}");
        }

        private static void CRectangle()
        {
            Console.Write("What is your length? ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your width? ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The area of your rectangle is {length * width}");
        }

        private static void CTriangle()
        {
            Console.Write("What is your length? ");
            double tlength = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your width? ");
            double twidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The area of your triangle is {tlength * twidth * 0.5}");
        }
    }
}


/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/