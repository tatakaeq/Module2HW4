using Module2HW4.Helper;

namespace Module2HW4.Models.ColdBlooded.Reptile
{
    public abstract class Reptile : ColdBlooded
    {
        public override bool IsVertebrate { get; init; } = true;

        public override ColdBloodedAnimalsTypes ColdBloodedAnimalsTypes { get; init; } =
            ColdBloodedAnimalsTypes.Reptile;
        public override bool IsHavePaws { get; init; } = true;
        public override bool IsHaveTail { get; init; } = true;
        public override bool IsMoreThanThreePairOfLegs { get; init; } = false;
        public override CoverType Covering { get; init; } = CoverType.DryScales;
        public abstract ReptileType ReptileType { get; init; }
    }
}