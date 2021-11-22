using Module2HW4.Helper;

namespace Module2HW4.Models.WarmBlooded.Mammal
{
    public abstract class Mammal : WarmBlooded
    {
        public override WarmBloodedAnimals WarmBloodedAnimals { get; init; } = WarmBloodedAnimals.Mammal;
        public abstract MammalType MammalType { get; set; }
    }
}