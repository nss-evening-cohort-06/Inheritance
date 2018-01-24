using System;

namespace Inheritance.Pieces.Legs
{
    class Jeans : LegBase, IMoveable
    {
        public int HowFarIMoved { get; set; }

        public override void Jump(int howHigh)
        {
            Console.WriteLine("I don't jump.");
        }

        public void Run(int howFar)
        {
            HowFarIMoved += howFar;
            Console.WriteLine($"Jeans ran {howFar} feet before cramping up due to lack of exercise.");
        }

        public override void Walk(int numberOfSteps)
        {
            HowFarIMoved += numberOfSteps;
            base.Walk(numberOfSteps);
        }
    }
}
