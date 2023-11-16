using System;

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

namespace ProgrammingExercisesIST
{
    class Project_17_TemperatureConversion
    {
        static void Main(string[] args)
        {
            // Write your code here

        }
    }
}
static void Main(string[] args)
{




    // Write your code here

    MainMenu();


    // Wait for key press before exiting
    WaitForKeyPress();
}

// Create your functions here



// Asks the user to enter a distance in the unit specified
private static double GetDistance(string unit)
{
    Console.Write($"Enter distance (in {unit}) to convert: ");
    double distance = int.Parse(Console.ReadLine());
    return distance;
}




// Shows the menu options to the user
private static void MainMenu()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;

    Console.Clear();
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Kilometres to Miles");
    Console.WriteLine("2. Miles to Kilometres");
    string choice = Console.ReadLine();





    if (choice == "1")
    {
        Console.Write("How many kilometres? ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{km} kilometers to miles = {km * 0.621371}");
    }

    else if (choice == "2")
    {
        Console.Write("How many miles? ");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{miles} miles to kilometers = {miles * 1.60934}");
    }

}

// Waits for the user to press any key
private static void WaitForKeyPress()
{
    Console.WriteLine();
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

// Displays an error message in red text
private static void ErrorMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
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
