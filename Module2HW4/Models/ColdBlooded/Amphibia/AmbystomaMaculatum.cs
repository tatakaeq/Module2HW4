using Module2HW4.Helper;

namespace Module2HW4.Models.ColdBlooded.Amphibia
{
    public class AmbystomaMaculatum : Amphibia
    {
        public override Sizing Size { get; init; } = Sizing.Small;
        public override bool IsPredator { get; init; } = true;
        public override bool IsHaveTail { get; init; } = true;
        public override AmphibiaType AmphibiaType { get; init; } = AmphibiaType.Caudata;
    }
}