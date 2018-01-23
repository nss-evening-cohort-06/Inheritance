using System;

namespace Inheritance.Pieces.Legs
{
    class Skirt : LegBase
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public void Walk(int numberOfSteps) 
        {
            if (Length == Length.StreetCorner)
            {
                Console.WriteLine($"The {Size} legs walked {numberOfSteps} steps suggestively and knocked on your window.");
                return;
            }

            base.Walk(numberOfSteps);
        }
    }
}
