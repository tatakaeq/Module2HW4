using System;
using Module2HW4.Helper;
using Module2HW4.Models;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class SectionService : ISectionService
    {
        private readonly ITypeCountService _typeCountService;

        public SectionService(ITypeCountService typeCountService)
        {
            _typeCountService = typeCountService;
        }

        private Animal[] Animals { get; set; }
        public void AddAnimalsToSection(Animal[] animals)
        {
            Animals = animals;
        }

        public void SortAnimalsBySize(Animal[] animals)
        {
            Array.Sort(Animals, new AnimalSizeComparer());
        }

        public Animal[] GetAnimalsAtSection(Animal[] animals)
        {
            return Animals;
        }

        public Counter[] GetCountersByType(Animal[] animals)
        {
            return _typeCountService.Count(animals);
        }
    }
}