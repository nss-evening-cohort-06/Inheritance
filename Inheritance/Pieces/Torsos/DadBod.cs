using System.Collections.Generic;
using Inheritance.Pieces.Accessories;

namespace Inheritance.Pieces.Torsos
{
    class DadBod : TorsoBase
    {
        public bool BeerBelly { get; set; }
        public bool BodyHair { get; set; }
        public int NumberOfNipples { get; set; }
    }

    abstract class TorsoBase
    {
        public string Shirt { get; set; }
        public List<AccessoryBase> Accessories { get; set; } = new List<AccessoryBase>();
    }
}
