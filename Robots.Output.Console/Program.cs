using System;
using System.Collections.Generic;
using System.Linq;

using Robots.Application.UseCases;
using Robots.Domain;

namespace Robots.Output.AConsole
{
    class Program
    {
        private const string COMMAND_REPEAT = "R";

        static void Main(string[] args)
        {
            string input = COMMAND_REPEAT;
            while (string.Equals(COMMAND_REPEAT, input, StringComparison.OrdinalIgnoreCase))
            {
                // Business Req: no exceptions
                try
                {
                    int numberOfCommands = Get_NumberOfCommands();
                    (int X, int Y) startCoordinate = Get_StartingCoordinates();
                    IEnumerable<(DirectionEnum Direction, int Steps)> commands = Get_MoveCommands(numberOfCommands);

                    var moveRequest = new MoveRequest(startCoordinate.X, startCoordinate.Y, commands);
                    var useCase = new MoveRobotUseCase();
                    var response = useCase.Execute(moveRequest);
                    Console.WriteLine($"Cleaned: {response.CleanedVertices}");
                }
                finally
                {
                    Console.WriteLine($"[{COMMAND_REPEAT}]epeat?");
                    input = Console.ReadLine();
                }
            }
        }

        private static int Get_NumberOfCommands()
        {
            Console.WriteLine("Enter number of commands: 0 <= n <= 10_000");
            return int.Parse(Console.ReadLine());
        }

        private static (int X, int Y) Get_StartingCoordinates()
        {
            Console.WriteLine("Enter starting coordinates X and Y separated by space: -100_000 <= X,Y <= 100_000");
            string input = Console.ReadLine();

            int[] coordinatesArray = input.Split(" ").Select(int.Parse).ToArray();
            return (X: coordinatesArray[0], Y: coordinatesArray[1]);
        }

        private static IEnumerable<(DirectionEnum Direction, int Steps)> Get_MoveCommands(int numberOfCommands)
        {
            var result = new List<(DirectionEnum Direction, int Steps)>();

            Console.WriteLine($"Enter direction {{E,W,S,N}} and number of steps (0 < step < 100_000) separated by space. Expected number of commands: {numberOfCommands}");
            for (int i = 0; i < numberOfCommands; i++)
            {
                var input = Console.ReadLine();
                var splittedInput = input.Split(" ");

                var direction = DirectionEnumFactory.Create(splittedInput[0]);
                var steps = int.Parse(splittedInput[1]);
                result.Add((Direction: direction, Steps: steps));
            }

            return result;
        }
    }
}
