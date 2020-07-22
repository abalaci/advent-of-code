using System.Linq;

namespace AdventOfCode.Y2015
{
    [AdventCalendar(year: 2015, day: 1)]
    public class NotQuiteLispPuzzle : Puzzle<string, int>
    {
        public NotQuiteLispPuzzle(string directionInstructions) : base(directionInstructions) {}

        public override int SolvePartOne()
        {
            int downwardFloorsCount = Input.Count(c => c == ')');
            int upwardFloorsCount = Input.Length - downwardFloorsCount;
            int finalFloor = upwardFloorsCount - downwardFloorsCount;

            return finalFloor;
        }

        public override int SolvePartTwo()
        {
            int currentFloor = 0;
            int index = 0;

            while (currentFloor >= 0 && index < Input.Length)
            {
                currentFloor = Input[index] == '('
                    ? currentFloor + 1
                    : currentFloor - 1;
                index++;
            }

            return index;
        }
    }
}
