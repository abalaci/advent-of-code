namespace AdventOfCode
{
    public abstract class Puzzle<TInput, TOutput>
    {
        protected TInput Input { get; }

        protected Puzzle(TInput input)
        {
            Input = input;
        }

        public abstract TOutput SolvePartOne();

        public abstract TOutput SolvePartTwo();
    }
}
