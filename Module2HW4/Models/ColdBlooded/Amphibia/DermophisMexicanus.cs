using Module2HW4.Helper;

namespace Module2HW4.Models.ColdBlooded.Amphibia
{
    public class DermophisMexicanus : Amphibia
    {
        public override Sizing Size { get; init; } = Sizing.Small;
        public override bool IsPredator { get; init; } = false;
        public override bool IsHaveTail { get; init; } = false;
        public override AmphibiaType AmphibiaType { get; init; } = AmphibiaType.Gymnophiona;
    }
}