using Module2HW4.Helper;

namespace Module2HW4.Models.WarmBlooded.Bird
{
    public class HaliaéetusLeucocéphalus : Bird
    {
        public override Sizing Size { get; init; } = Sizing.Large;
        public override bool IsPredator { get; init; } = true;
        public override bool IsHaveTail { get; init; } = true;
        public override bool IsCanFly { get; init; } = true;
        public override BirdType BirdType { get; init; } = BirdType.Accipitridae;
    }
}