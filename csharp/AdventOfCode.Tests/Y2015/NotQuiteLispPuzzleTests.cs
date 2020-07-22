using AdventOfCode.Y2015;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode.Tests.Y2015
{
    [TestFixture]
    internal class NotQuiteLispPuzzleTests
    {
        [TestCase(")())())", -3)]
        [TestCase(")))", -3)]
        [TestCase("))(", -1)]
        [TestCase("())", -1)]
        [TestCase("))(((((", 3)]
        [TestCase("(()(()(", 3)]
        [TestCase("(((", 3)]
        [TestCase("()()", 0)]
        [TestCase("(())", 0)]
        public void GivenValidInput_SolvePartOne_ReturnsExpectedResult(string input, int expectedResult)
        {
            var puzzle = new NotQuiteLispPuzzle(input);
            int result = puzzle.SolvePartOne();

            result.Should().Be(expectedResult);
        }

        [TestCase("()())", 5)]
        [TestCase(")", 1)]
        public void GivenValidInput_SolvePartTwo_ReturnsExpectedResult(string input, int expectedResult)
        {
            var puzzle = new NotQuiteLispPuzzle(input);
            int result = puzzle.SolvePartTwo();

            result.Should().Be(expectedResult);
        }
    }
}
