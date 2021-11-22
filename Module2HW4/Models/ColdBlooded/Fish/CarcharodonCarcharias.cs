using Module2HW4.Helper;

namespace Module2HW4.Models.ColdBlooded.Fish
{
    public class CarcharodonCarcharias : Fish
    {
        public override Sizing Size { get; init; } = Sizing.Large;
        public override bool IsPredator { get; init; } = true;
        public override FishType FishType { get; init; } = FishType.Chondrichthyes;
    }
}