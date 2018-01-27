namespace Inheritance.Pieces.Accessories
{
    abstract class AccessoryBase
    {
        public abstract AccessoryLocation Location { get; }
    }

    enum AccessoryLocation
    {
        Hand=1,
        Torso
    }
}
