using System;
using System.Collections.Generic;

/*
===============================================================================
PROJECT 30: INSULT GENERATOR
===============================================================================
Objective:
- Understand and practice using methods to modularize code.
- Employ lists to store and retrieve data.
- Utilize the Random class to generate random selections from a list.
- Practice string manipulation and user input in C#.

Main Tasks:
1. Implement the `GetAdjective` method to return a random adjective, ensuring it fits grammatically (e.g., "a hairy" or "an untalented").
2. Implement the `GetCompoundAdjective` method to return a random compound adjective (e.g., "no-good" or "big-headed").
3. Implement the `GetNoun` method to return a random noun (e.g., "goofball" or "nerd").
4. Implement the `GetName` method to prompt the user for their name and return it.

Extension Tasks:
1. Enhance the insult generator by adding more words to create a more complex insult.
2. Implement error checking to handle unexpected user input, such as entering a blank name or invalid choice for continuing or exiting.

===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_30_InsultGenerator
    {
        // Random number generator
        private static readonly Random rnd = new Random();

        static void Main(string[] args)
        {
            // Ask for your name
            string name = GetName();

            // Loop to generate random insult or exit
            string userResponse;
            do
            {
             // Generate a random insult
             GenerateInsult(name);

                // Ask user if they want another insult
                Console.Write("Would you like another insult? y/n: ");
                userResponse = Console.ReadLine();

            } while (userResponse.ToLower() == "y");
        }

        // 1. Should return a random adjective. E.g. "a hairy" or "an untalented"
        private static string GetAdjective()
        {
            // 'adjectives' is your list of adjectives
            List<string> adjectives = new List<string> { "hairy", "untalented" };

            // Generate a random index between 0 and the length of the 'adjectives' list (exclusive)
            int randomIndex = rnd.Next(0, adjectives.Count);

            // Use the random index to retrieve a random adjective from the list
            return adjectives[randomIndex];
        }

        // 2. Should return a random compound adjective. E.g. "no-good" or "big-headed"
        private static string GetCompoundAdjective()
        {
            // Your code here
        }

        // 3. Should return a noun. E.g. "goofball" or "nerd"
        private static string GetNoun()
        {
            // Your code here
        }

        // 4. Ask for and return the user's name
        private static string GetName()
        {
            // Your code here
        }

        // Generate the insult. E.g. "Jeff, you are a smelly, no-good sloth"
        private static void GenerateInsult(string name)
        {
            Console.WriteLine($"\n{name}, you are {GetAdjective()}, {GetCompoundAdjective()} {GetNoun()}");
        }
    }
}
/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================




===============================================================================
*/
