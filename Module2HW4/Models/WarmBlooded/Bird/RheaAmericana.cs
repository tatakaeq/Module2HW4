using Module2HW4.Helper;

namespace Module2HW4.Models.WarmBlooded.Bird
{
    public class RheaAmericana : Bird
    {
        public override Sizing Size { get; init; } = Sizing.Medium;
        public override bool IsPredator { get; init; } = false;
        public override bool IsHaveTail { get; init; } = false;
        public override bool IsCanFly { get; init; } = false;
        public override BirdType BirdType { get; init; } = BirdType.Palaeognathae;
    }
}