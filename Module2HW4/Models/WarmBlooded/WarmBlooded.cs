using Module2HW4.Helper;

namespace Module2HW4.Models.WarmBlooded
{
    public abstract class WarmBlooded : Animal
    {
        public override BloodType BloodType { get; init; } = BloodType.WarmBlooded;
        public override bool IsVertebrate { get; init; } = true;
        public override bool IsMoreThanThreePairOfLegs { get; init; } = false;
        public abstract WarmBloodedAnimals WarmBloodedAnimals { get; init; }
    }
}