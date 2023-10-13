using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProgrammingExercisesIST
{
    internal class Project_35_APIs
    {
        // Challenge: Create a program that can interact with an API

        // A sample program that prints out results from Formula 1 races is provided
        // Plenty of free API's can be found here: https://github.com/public-apis/public-apis

        static void Main(string[] args)
        {
            string tryAgain = "y";

            while (tryAgain.ToLower() == "y")
            {
                GetF1Data();

                tryAgain = Console.ReadLine();
            }
        }

        static void GetF1Data()
        {
            F1API.PrintHeader();

            Console.WriteLine("For which year would you like the data?");
            string year = Console.ReadLine();

            Console.WriteLine("For which round would you like the data?");
            string round = Console.ReadLine();

            F1API.GetData(year + "/" + round + "/results");
        }
    }
}
