using Robots.Domain.Exceptions;

namespace Robots.Domain
{
    public class CommandMove
    {
        public DirectionEnum Direction { get; }
        public int Steps { get; }

        public CommandMove(DirectionEnum direction, int steps)
        {
            ValidateSteps(steps);

            this.Direction = direction;
            this.Steps = steps;
        }

        private void ValidateSteps(int steps)
        {
            int UPPER = 100_000;
            int LOWER = 0;
            if (steps <= LOWER || steps >= UPPER)
            {
                throw new BadRequestException($"{nameof(steps)} must be {LOWER} < x < {UPPER}. Value: {steps}.");
            }
        }
    }
}