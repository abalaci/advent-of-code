using System.Collections.Generic;
using AdventOfCode.Y2019;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode.Tests.Y2019
{
    public class TyrannyOfRocketEquationPuzzleTests
    {
        private readonly ITestOutputHelper _output;

        public TyrannyOfRocketEquationPuzzleTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void GivenValidInput_SolvePartOne_ReturnsExpectedResult(int input, int expectedResult)
        {
            var puzzle = new TyrannyOfRocketEquationPuzzle(input);
            int result = puzzle.SolvePartOne();

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(14, 2)]
        [InlineData(1969, 966)]
        [InlineData(100756, 50346)]
        public void GivenValidInput_SolvePartTwo_ReturnsExpectedResult(int input, int expectedResult)
        {
            var puzzle = new TyrannyOfRocketEquationPuzzle(input);
            int result = puzzle.SolvePartTwo();

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InputFileData("Y2019/TyrannyOfRocketEquation.txt")]
        public void SolvePuzzle(params int[] input)
        {
            var puzzle = new TyrannyOfRocketEquationPuzzle(input);
            var partOneResult = puzzle.SolvePartOne();
            var partTwoResult = puzzle.SolvePartTwo();

            _output.WriteLine(partOneResult.ToString());
            _output.WriteLine(partTwoResult.ToString());
        }
    }
}
