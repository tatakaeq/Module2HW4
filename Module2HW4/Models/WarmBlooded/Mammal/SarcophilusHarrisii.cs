using Module2HW4.Helper;

namespace Module2HW4.Models.WarmBlooded.Mammal
{
    public class SarcophilusHarrisii : Mammal
    {
        public override Sizing Size { get; init; } = Sizing.Small;
        public override bool IsPredator { get; init; } = true;
        public override CoverType Covering { get; init; } = CoverType.Fur;
        public override bool IsHaveTail { get; init; } = true;
        public override bool IsHavePaws { get; init; } = true;
        public override MammalType MammalType { get; set; } = MammalType.Marsupialia;
    }
}