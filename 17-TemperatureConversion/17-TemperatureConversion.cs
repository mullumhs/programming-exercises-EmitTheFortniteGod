/*
===============================================================================
PROJECT 17: TEMPERATURE CONVERSION
===============================================================================
Objective:
- Utilise functions to create a program that converts temperatures between Celsius and Fahrenheit based on user input.

Example Output:
- This is how your program should behave:

    What would you like to do?
    1. Celsius to Fahrenheit
    2. Fahrenheit to Celsius
    1
    Enter temperature in Celsius: 0
    That is 32 Fahrenheit

Pseudocode:
    BEGIN Main
        choice = MainMenu()
        IF choice = 1 THEN
            result = CelsiusToFahrenheit()
            PRINT result
        ELSE IF choice = 2 THEN
            result = FahrenheitToCelsius()
            PRINT result
        ELSE
            PRINT "Invalid Choice!"
        END IF
    END Main

    BEGIN CelsiusToFahrenheit
        c = GetTemperature("Celsius")
        f = (c * 9/5) + 32
        RETURN f
    END CelsiusToFahrenheit

    BEGIN FahrenheitToCelsius
        f = GetTemperature("Fahrenheit")
        c = (f - 32) * 5/9
        RETURN c
    END FahrenheitToCelsius

    BEGIN GetTemperature(unit)
        PRINT "Enter temperature in " + unit
        INPUT temp
        RETURN temp
    END GetTemperature

Main Tasks:
1. Write a function to convert Celsius to Fahrenheit.
2. Write a function to convert Fahrenheit to Celsius.
3. Implement a menu for the user to choose which conversion they want to perform.
4. Display the result of the conversion based on the user's choice.

Questions:
1. What did you find challenging about implementing an entire program yourself?

Extension Tasks:
1. Add an option in the menu for the user to exit the program.
2. Enhance the program to handle invalid input gracefully without crashing.
3. Research and implement a function to convert temperature to and from Kelvin.
===============================================================================
*/

using System;

namespace ProgrammingExercisesIST
{
    class Project_17_TemperatureConversion
    {
        static void Main(string[] args)
        {
            // Write your code here

            MainMenu();

            WaitForKeyPress();
        }


        private static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            string choice = Console.ReadLine();




            if (choice == "1")
            {
                Console.Write("How many fahrenheit? ");
                double fr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{fr} fahrenheit to celsius = {(fr - 32) * 5 / 9}");
            }

            else if (choice == "2")
            {
                Console.Write("How many celsius? ");
                double cel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{cel} celsius to fahrenheit = {(cel * 9 / 5) + 32}");
            }

            else
            {
                Console.WriteLine($"{choice} is not a valid answer.");
            }
        }

        // Waits for the user to press any key
        private static void WaitForKeyPress()
        {
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