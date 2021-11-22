using Module2HW4.Helper;
using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface ISectionService
    {
        void AddAnimalsToSection(Animal[] animals);
        void SortAnimalsBySize(Animal[] animals);
        Animal[] GetAnimalsAtSection(Animal[] animals);
        Counter[] GetCountersByType(Animal[] animals);
    }
}