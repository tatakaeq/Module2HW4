using Module2HW4.Helper;

namespace Module2HW4.Models.ColdBlooded.Amphibia
{
    public abstract class Amphibia : ColdBlooded
    {
        public override bool IsVertebrate { get; init; } = true;

        public override ColdBloodedAnimalsTypes ColdBloodedAnimalsTypes { get; init; } =
            ColdBloodedAnimalsTypes.Amphibia;
        public override bool IsHavePaws { get; init; } = true;
        public override bool IsMoreThanThreePairOfLegs { get; init; } = false;
        public override CoverType Covering { get; init; } = CoverType.WetSlimy;
        public abstract AmphibiaType AmphibiaType { get; init; }
    }
}