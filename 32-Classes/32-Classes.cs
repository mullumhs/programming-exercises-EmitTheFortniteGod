using System;

/*
===============================================================================
PROJECT 32: CLASSES
===============================================================================
Objective:
- Understand and practice creating custom classes in C#.
- Explore encapsulation by using private variables and public methods.
- Get acquainted with constructors and how they initialize objects.
- Implement and call methods to interact with objects.

Main Tasks:
1. Explore the provided 'Person' class in the separate Person.cs file.
2. Execute the 'Example' method in the Main method to understand how the 'Person' class is used.
3. Create a new custom class based on a theme (e.g., Vehicle, Animal, etc.).
4. Add private variables to your class to represent its properties.
5. Create a constructor to initialize the properties.
6. Add methods to your class to represent actions it can take.
7. In the Main method, create objects of your custom class and interact with them using the methods you defined.

Example Theme - Vehicle:
- Private Variables: string make, string model, int year, double speed
- Constructor: Initializes make, model, year, and speed
- Methods: Accelerate(), Brake(), GetSpeed(), GetInfo()

Example Tasks for Vehicle Class:
1. Create a method to increase the speed of the vehicle.
2. Create a method to decrease the speed of the vehicle.
3. Create a method to retrieve the current speed of the vehicle.
4. Create a method to retrieve information about the vehicle.

Extension Tasks:
1. Add validation to ensure speed does not go below 0.
2. Add more properties to your class (e.g., fuel level, mileage).
3. Create methods to interact with the new properties (e.g., Refuel(), Drive()).
4. Create multiple instances of your class and demonstrate how they can interact independently.

Additional Resources:
- Classes: https://www.tutorialspoint.com/csharp/csharp_classes.htm
- Classes: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes

===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_32_Classes
    {
        static void Main(string[] args)
        {
            // First check out the example:
            PersonExample();

            // Create an instance of your custom class and interact with it here


            // Wait at end
            WaitForKeyPress();
        }

        static void PersonExample()
        {
            // There is an example class included in this project called 'Person.cs'

            // Create an instance of the Person class
            Person p = new Person("John", "Doe", 42);

            // Interact with it
            p.PrintInfo();
            p.Sit();
            p.Walk(100);
            p.Stand();
            p.Birthday();
            p.Walk(100);
            p.ChangeNamePrompt();
            p.PrintInfo();
        }

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
