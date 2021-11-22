using Module2HW4.Helper;
using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface IInfoService
    {
        void WriteAnimalsAtSection(Animal[] animals);
        void WriteCountByType(Counter[] counters);
        void SortedBySizeAnimals(Animal[] animals);
        void WriteFoundAnimal(Animal animal);
    }
}