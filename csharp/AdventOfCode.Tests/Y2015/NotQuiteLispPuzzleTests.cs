using AdventOfCode.Y2015;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.Tests.Y2015
{
    public class NotQuiteLispPuzzleTests
    {
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
    }
}
