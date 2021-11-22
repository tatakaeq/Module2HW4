using System.Runtime.Intrinsics.X86;
using Module2HW4.Helper;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Models
{
    public abstract class Animal
    {
        public abstract Sizing Size { get; init; }
        public abstract bool IsPredator { get; init; }
        public abstract CoverType Covering { get; init; }
        public abstract BloodType BloodType { get; init; }
        public abstract bool IsVertebrate { get; init; }
        public abstract bool IsHaveTail { get; init; }
        public abstract bool IsHavePaws { get; init; }
        public abstract bool IsMoreThanThreePairOfLegs { get; init; }
    }
}