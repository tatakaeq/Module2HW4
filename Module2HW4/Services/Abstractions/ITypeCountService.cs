using Module2HW4.Helper;
using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface ITypeCountService
    {
        Counter[] Count(Animal[] animals);
    }
}