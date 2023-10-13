using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProgrammingExercisesIST
{
    public class F1API
    {
        public async static void GetData(string query)
        {
            // ergast.com/api/<series>/<season>/<round>/...

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://ergast.com/api/f1/" + query + ".json"),   // This is the URL for the API
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                // Turn result of API request into JSON
                JsonDocument document = JsonDocument.Parse(body);

                // Grab which we need from the JSON document
                // A great way to browse your JSON and see the elements: https://jsonformatter.org/json-pretty-print
                // In the case below we are getting the "RaceTable" element which is a child of "MRData"
                var RaceTable = document.RootElement.GetProperty("MRData").GetProperty("RaceTable");

                // We have created a list of 'Results' to hold the data we need
                List<Result> results = new List<Result>();

                // Within the "RaceTable" we are accessing the "Results" and looping through each one
                foreach (JsonElement element in RaceTable.GetProperty("Races")[0].GetProperty("Results").EnumerateArray())
                {
                    // Each result is added to a new instance of the "Result" class
                    Result newResult = new Result(
                        int.Parse(element.GetProperty("position").ToString()),
                        int.Parse(element.GetProperty("number").ToString()),
                        element.GetProperty("Driver").GetProperty("givenName").ToString() + " " + element.GetProperty("Driver").GetProperty("familyName").ToString(),
                        element.GetProperty("Constructor").GetProperty("name").ToString(),
                        int.Parse(element.GetProperty("grid").ToString()),
                        int.Parse(element.GetProperty("laps").ToString()),
                        int.Parse(element.GetProperty("points").ToString())
                    );
                    // And then added to the list
                    results.Add(newResult);
                }

                // We then print out the results in a pretty format
                PrintResults(results);

                Console.WriteLine("\nWould you like to try again? y/n");
            }
        }

        public static void PrintResults(List<Result> results)
        {
            var sb = new System.Text.StringBuilder();
            sb.Append(String.Format("{0,8} {1,8}   {2,-20} {3,-15} {4,8} {5,8} {6,8}\n\n", "Position", "Number", "Driver", "Team", "Grid", "Laps", "Points"));
            foreach (Result result in results)
            {
                sb.Append(result.PrintResult());
            }
            Console.WriteLine(sb);
        }

        public static void PrintHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("########    ##        ########  ########  ######  ##     ## ##       ########  ######  ");
            Console.WriteLine("##        ####        ##     ## ##       ##    ## ##     ## ##          ##    ##    ## ");
            Console.WriteLine("##          ##        ##     ## ##       ##       ##     ## ##          ##    ##       ");
            Console.WriteLine("######      ##        ########  ######    ######  ##     ## ##          ##     ######  ");
            Console.WriteLine("##          ##        ##   ##   ##             ## ##     ## ##          ##          ## ");
            Console.WriteLine("##          ##        ##    ##  ##       ##    ## ##     ## ##          ##    ##    ## ");
            Console.WriteLine("##        ######      ##     ## ########  ######   #######  ########    ##     ######  ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
