using System;
using Module2HW4.Helper;
using Module2HW4.Models;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4
{
    public class Startup
    {
        private readonly IAnimalProvider _animalProvider;
        private readonly ISectionService _sectionService;
        private readonly IInfoService _infoService;
        private Animal[] _section;

        public Startup(
            IAnimalProvider animalProvider,
            ISectionService sectionService,
            ITypeCountService typeCountService,
            IInfoService infoService)
        {
            _animalProvider = animalProvider;
            _sectionService = sectionService;
            _infoService = infoService;
        }

        public void Run()
        {
            _section = _animalProvider.GetAnimals();
            _sectionService.AddAnimalsToSection(_section);
            _infoService.WriteCountByType(_sectionService.GetCountersByType(_section));
            _sectionService.SortAnimalsBySize(_section);
            _infoService.SortedBySizeAnimals(_section);
            _infoService.WriteFoundAnimal(FindAnimalBySize.Find(_section, Sizing.Large));
        }
    }
}