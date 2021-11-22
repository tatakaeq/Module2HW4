using Module2HW4.Helper;

namespace Module2HW4.Models.ColdBlooded.Fish
{
    public class Latimeria : Fish
    {
        public override Sizing Size { get; init; } = Sizing.Small;
        public override bool IsPredator { get; init; } = true;
        public override FishType FishType { get; init; } = FishType.Osteichthyes;
    }
}