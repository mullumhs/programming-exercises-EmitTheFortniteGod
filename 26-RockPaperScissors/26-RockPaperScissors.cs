using System;

/*
===============================================================================
PROJECT 26: ROCK PAPER SCISSORS
===============================================================================
Objective:
- Practice using functions and user input to create a simple game.

Main Tasks:
- Implement the main game loop structure.
- Fill in the necessary functions based on the pseudocode provided.
- Run the game and ensure it works as expected.

Example Output:

    User: 2     Computer: 3
    1: Rock
    2: Paper
    3: Scissors
    Your Choice: 1

    Win! The computer chose Scissors and you chose Rock
    Play again? 1 = Yes, 2 = No

Extension Tasks:
1. Experiment with different game logic or additional choices (like Rock, Paper, Scissors, Lizard, Spock).

===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_26_RockPaperScissors
    {
        // Global variables
        static int userScore = 0;
        static int computerScore = 0;
        static bool repeat = true;

        static void Main(string[] args)
        {
            // Game loop
            while (repeat == true)
            {
                // 1. Print scores at top of screen
                // 2. User's turn, store what they picked in a string
                // 3. Computer's turn, store what they picked in a string
                // 4. Determine the winner, store user's result in a string
                // 5. Print out your result and what each player picked
                // 6. Update the score
                // 7. Ask to play again
            }
        }

        // Prints the user's and computer's scores
        static void PrintScore()
        {
            /* Pseudocode:
            1. Clear the console screen.
            2. Print user and computer scores.
            */
        }

        // Asks the user what they would like to pick
        // Returns "Rock", "Paper" or "Scissors"
        static string UserTurn()
        {
            /* Pseudocode:
            1. Loop until a valid choice is made (1, 2, or 3).
            2. Display choices to the user.
            3. Get user input.
            4. Convert numeric choice to word (Rock, Paper, Scissors) using a helper function.
            5. Return the word.
            */
            return "";
        }

        static string ConvertChoiceToWord(string choice)
        {
            /* Pseudocode:
            1. If choice is 1, return "Rock".
            2. If choice is 2, return "Paper".
            3. If choice is 3, return "Scissors".
            */
            return "";
        }

        // Randomly picks for the computer
        // Returns "Rock", "Paper" or "Scissors"
        static string ComputerTurn()
        {
            /* Pseudocode:
            1. Generate a random number between 1 and 3.
            2. If the number is 1, return "Rock".
            3. If the number is 2, return "Paper".
            4. If the number is 3, return "Scissors".
            */
            return "";
        }

        // Determines if the user won, lost or drew the round
        // Returns "Win", "Loss" or "Draw"
        static string DetermineWinner(string userChoice, string computerChoice)
        {
            /* Pseudocode:
            1. If userChoice equals computerChoice, return "Draw".
            2. Otherwise, check winning conditions for user.
            3. If any winning condition is true, return "Win".
            4. Otherwise, return "Lose".
            */
            return "";
        }

        static bool IsUserWinner(string userChoice, string computerChoice)
        {
            /* Pseudocode:
            1. Check all winning conditions for the user.
            2. Return true if any of them are true.
            3. Otherwise, return false.
            */
            return true;
        }

        // Prints out your result and what each player picked
        static void GiveFeedback(string result, string userChoice, string computerChoice)
        {
            /* Pseudocode:
            1. Print the result (Win, Lose, Draw).
            2. Print the choices of both user and computer.
            */
        }

        // Asks if the user would like to play again
        static bool PlayAgain()
        {
            /* Pseudocode:
            1. Ask the user if they want to play again.
            2. Get user input.
            3. Return true if the user wants to play again.
            4. Return false otherwise.
            */
            return true;
        }

        // Updates the score
        static void UpdateScores(string result)
        {
            /* Pseudocode:
            1. If result is "Win", increment user score.
            2. If result is "Lose", increment computer score.
            */
        }
    }
}
/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================

The lesson has been re-organized to align with the specified format. Global variables are grouped together at the top of the class. The Main method now follows a clear, linear flow which improves readability and understanding for students. The repetitive code within UserTurn, ComputerTurn, and DetermineWinner methods has been reduced, making the code more elegant and less confusing. The simpler code structure should help students focus on understanding the logic of the game rather than getting lost in the details of the code.

===============================================================================
*/