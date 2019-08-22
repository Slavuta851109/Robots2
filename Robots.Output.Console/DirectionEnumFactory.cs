using System;
using Robots.Domain;

namespace Robots.Output.AConsole
{
    internal static class DirectionEnumFactory
    {
        internal static DirectionEnum Create(string direction)
        {
            switch (direction.ToLower())
            {
                case "n":
                    return DirectionEnum.N;
                case "e":
                    return DirectionEnum.E;
                case "s":
                    return DirectionEnum.S;
                case "w":
                    return DirectionEnum.W;
                default:
                    throw new NotSupportedException($"'{direction}' is not supported value of Direction.");
            }
        }
    }
}
