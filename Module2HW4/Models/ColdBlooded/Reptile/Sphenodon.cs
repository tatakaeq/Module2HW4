using Module2HW4.Helper;

namespace Module2HW4.Models.ColdBlooded.Reptile
{
    public class Sphenodon : Reptile
    {
        public override Sizing Size { get; init; } = Sizing.Small;
        public override bool IsPredator { get; init; } = true;
        public override ReptileType ReptileType { get; init; } = ReptileType.Rhynchocephalia;
    }
}