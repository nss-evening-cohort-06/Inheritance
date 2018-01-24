using System;

namespace Inheritance.Pieces.Legs
{
    abstract class LegBase
    {
        public int NumberOfPockets { get; set; }
        public string Color { get; set; }
        public LegSize Size { get; set; }

        public abstract void Jump(int howHigh);

        public virtual void Walk(int numberOfSteps)
        {
            Console.WriteLine($"The {Size} legs wearing a {GetType().Name} took {numberOfSteps} steps");
        }
    }
}
