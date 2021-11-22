using Module2HW4.Helper;

namespace Module2HW4.Models.ColdBlooded.Fish
{
    public abstract class Fish : ColdBlooded
    {
        public override bool IsVertebrate { get; init; } = true;
        public override ColdBloodedAnimalsTypes ColdBloodedAnimalsTypes { get; init; } = ColdBloodedAnimalsTypes.Fish;
        public override bool IsHavePaws { get; init; } = false;
        public override bool IsHaveTail { get; init; } = true;
        public override bool IsMoreThanThreePairOfLegs { get; init; } = false;
        public override CoverType Covering { get; init; } = CoverType.WetScales;
        public abstract FishType FishType { get; init; }
    }
}