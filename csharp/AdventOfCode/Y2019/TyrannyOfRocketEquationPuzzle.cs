using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2019
{
    [AdventCalendar(year: 2019, day: 1)]
    public class TyrannyOfRocketEquationPuzzle : Puzzle<IEnumerable<int>, int>
    {
        public TyrannyOfRocketEquationPuzzle(params int[] moduleMasses) : base(moduleMasses) {}

        public override int SolvePartOne()
        {
            return Input.Select(m => Math.Max(m / 3 - 2, 0)).Sum();
        }

        public override int SolvePartTwo()
        {
            var totalFuel = 0;

            foreach (var moduleMass in Input)
            {
                var moduleFuel = Math.Max(moduleMass / 3 - 2, 0);
                var fuelToAdd = Math.Max(moduleFuel / 3 - 2, 0);

                while (fuelToAdd > 0)
                {
                    moduleFuel = moduleFuel + fuelToAdd;
                    fuelToAdd = Math.Max(fuelToAdd / 3 - 2, 0);
                }

                totalFuel += moduleFuel;
            }
            
            return totalFuel;
        }
    }
}
