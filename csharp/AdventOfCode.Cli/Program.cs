using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using AdventOfCode.Y2015;

namespace AdventOfCode.Cli
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var rootCommand = new RootCommand
            {
                new Option<uint>("--year"),
                new Option<uint>("--day"),
                new Option<FileInfo>("--input-file"),
            };

            rootCommand.Description = "My sample Advent of Code puzzle solver.";
            rootCommand.Handler = CommandHandler.Create<uint, uint, FileInfo>((year, day, inputFile) =>
            {
                Console.WriteLine($"Year: {year}.");
                Console.WriteLine($"Day: {day}.");
                Console.WriteLine($"Input file info: {inputFile}.");

                using StreamReader streamReader = inputFile.OpenText();
                string input = streamReader.ReadToEnd();

                // TODO: Select puzzle dynamically based on year and day arguments.
                var puzzle = new NotQuiteLispPuzzle(input.Trim());
                Console.WriteLine($"Part one answer: {puzzle.SolvePartOne()}.");
                Console.WriteLine($"Part two answer: {puzzle.SolvePartTwo()}.");
            });

            rootCommand.Invoke(args);
        }
    }
}
