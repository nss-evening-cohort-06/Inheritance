using Inheritance.Pieces.Heads;
using Inheritance.Pieces.Legs;
using Inheritance.Pieces.Torsos;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var jeans = new Jeans
            {
                Color = "Black",
                Size = LegSize.Adult,
                NumberOfPockets = 4
            };

            var head = new Emmet
            {
                EyeColor = "Blue",
                Happy = true,
                HeadGear = new Hair {Color = "blonde", Length = "long"}
            };

            var body = new DadBod
            {
                BeerBelly = true,
                BodyHair = true,
                NumberOfNipples = 2,
                Shirt = "purple"
            };

            var dadEmmet = new MiniFigure(jeans, head, body, "Emmet");

            dadEmmet.Walk(50);

            dadEmmet.SwapTorso();
        }
    }
}
