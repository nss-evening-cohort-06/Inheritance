using System;
using System.Collections.Generic;
using Inheritance.Pieces.Legs;

namespace Inheritance
{
    class oldcode
    {
        void oldstuff()
        {
            var shorts = new Shorts
            {
                Color = "Tan",
                Length = Length.School,
                Size = LegSize.Baby,
                NumberOfPockets = 6
            };

            var jeans1 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Adult,
                NumberOfPockets = 4
            };

            var jeans2 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Child,
                NumberOfPockets = 4
            };

            var jeans3 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Baby,
                NumberOfPockets = 4
            };

            var skirt = new Skirt
            {
                Color = "Rainbow",
                Size = LegSize.Child,
                NumberOfPockets = 0,
                Material = "Strechy",
                Length = Length.Church
            };


            var skirt1 = new Skirt
            {
                Color = "Sparkly",
                Size = LegSize.Adult,
                NumberOfPockets = 0,
                Material = "Sequins",
                Length = Length.StreetCorner
            };

            var movers = new List<IMoveable>
            {
                shorts,
                skirt,
                jeans1,
                jeans2,
                jeans3,
                skirt1
            };

            foreach (var mover in movers)
            {
                mover.Walk(10);
                mover.Jump(10);
                mover.Run(15);

                switch (mover)
                {
                    case Skirt s:
                        Console.WriteLine($"Its a skirt made of {s.Material}");
                        break;
                    case Jeans j:
                        Console.WriteLine($"its {j.Color} jeans");
                        j.HowFarIMoved = 2000;
                        break;
                    case IMoveable m:
                        m.Run(10);
                        break;
                }
                Console.WriteLine($"The {mover.GetType().Name} moved {mover.HowFarIMoved} units.");
            }

            Console.ReadLine();
        }
    }
}
