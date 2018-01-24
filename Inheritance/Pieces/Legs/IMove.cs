using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    interface IMoveable
    {
        int HowFarIMoved { get; }

        void Walk(int howManySteps);
        void Jump(int howHigh);
        void Run(int howFar);
    }
}
