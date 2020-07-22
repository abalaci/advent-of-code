using System;

namespace AdventOfCode
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AdventCalendarAttribute : Attribute
    {
        public AdventCalendarAttribute(uint year, uint day)
        {
            Day = day;
            Year = year;
        }

        public uint Day { get; }

        public uint Year { get; }
    }
}
