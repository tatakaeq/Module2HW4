using Module2HW4.Helper;
using Module2HW4.Models;
using Module2HW4.Models.ColdBlooded.Amphibia;
using Module2HW4.Models.ColdBlooded.Fish;
using Module2HW4.Models.ColdBlooded.Reptile;
using Module2HW4.Models.WarmBlooded.Bird;
using Module2HW4.Models.WarmBlooded.Mammal;
using Module2HW4.Providers.Abstractions;

namespace Module2HW4.Providers
{
    public class AnimalProvider : IAnimalProvider
    {
        public Animal[] GetAnimals()
        {
            return new Animal[]
            {
                new Latimeria(),
                new Sphenodon(),
                new AiluropodaMelanoleuca(),
                new DermophisMexicanus(),
                new PloceusVelatus(),
                new AmbystomaMaculatum(),
                new DermophisMexicanus(),
                new PloceusVelatus(),
                new AiluropodaMelanoleuca(),
                new DermophisMexicanus(),
                new PloceusVelatus(),
                new AmbystomaMaculatum()
            };
        }
    }
}