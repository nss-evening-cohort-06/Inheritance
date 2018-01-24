using System;

namespace Inheritance.Pieces.Legs
{
    class Shorts : LegBase, IMoveable
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public int HowFarIMoved { get; private set; }

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Shorts jumped {howHigh} feet in the air.");
        }

        public void Run(int howFar)
        {
            HowFarIMoved += howFar;
            Console.WriteLine($"Shorts ran {howFar} miles in the snow.");
        }

        public override void Walk(int numberOfSteps)
        {
            HowFarIMoved += numberOfSteps;
            base.Walk(numberOfSteps);
        }
    }
}
