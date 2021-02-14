using AdventOfCode.Y2015;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode.Tests.Y2015
{
    public class NotQuiteLispPuzzleTests
    {
        private readonly ITestOutputHelper _output;

        public NotQuiteLispPuzzleTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [InlineData(")())())", -3)]
        [InlineData(")))", -3)]
        [InlineData("))(", -1)]
        [InlineData("())", -1)]
        [InlineData("))(((((", 3)]
        [InlineData("(()(()(", 3)]
        [InlineData("(((", 3)]
        [InlineData("()()", 0)]
        [InlineData("(())", 0)]
        public void GivenValidInput_SolvePartOne_ReturnsExpectedResult(string input, int expectedResult)
        {
            var puzzle = new NotQuiteLispPuzzle(input);
            int result = puzzle.SolvePartOne();

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("()())", 5)]
        [InlineData(")", 1)]
        public void GivenValidInput_SolvePartTwo_ReturnsExpectedResult(string input, int expectedResult)
        {
            var puzzle = new NotQuiteLispPuzzle(input);
            int result = puzzle.SolvePartTwo();

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InputFileData("Y2015/NotQuiteLispPuzzle.txt")]
        public void SolvePuzzle(string input)
        {
            var puzzle = new NotQuiteLispPuzzle(input);
            var partOneResult = puzzle.SolvePartOne();
            var partTwoResult = puzzle.SolvePartTwo();

            _output.WriteLine(partOneResult.ToString());
            _output.WriteLine(partTwoResult.ToString());
        }
    }
}
