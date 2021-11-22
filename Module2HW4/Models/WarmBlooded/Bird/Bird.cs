using Module2HW4.Helper;

namespace Module2HW4.Models.WarmBlooded.Bird
{
    public abstract class Bird : WarmBlooded
    {
        public override WarmBloodedAnimals WarmBloodedAnimals { get; init; } = WarmBloodedAnimals.Bird;
        public override CoverType Covering { get; init; } = CoverType.Feathers;
        public override bool IsHavePaws { get; init; } = true;
        public override bool IsMoreThanThreePairOfLegs { get; init; } = false;
        public abstract bool IsCanFly { get; init; }
        public abstract BirdType BirdType { get; init; }
    }
}