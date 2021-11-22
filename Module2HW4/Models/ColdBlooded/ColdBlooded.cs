using Module2HW4.Helper;

namespace Module2HW4.Models.ColdBlooded
{
    public abstract class ColdBlooded : Animal
    {
        public override BloodType BloodType { get; init; } = BloodType.ColdBlooded;
        public abstract ColdBloodedAnimalsTypes ColdBloodedAnimalsTypes { get; init; }
    }
}