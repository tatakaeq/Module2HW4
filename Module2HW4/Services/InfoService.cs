using System;
using Module2HW4.Helper;
using Module2HW4.Models;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class InfoService : IInfoService
    {
        public void WriteAnimalsAtSection(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animals at the Section:{Environment.NewLine}{animal.GetType().Name}, size: {animal.Size}");
            }
        }

        public void WriteCountByType(Counter[] counters)
        {
            foreach (var animal in counters)
            {
                Console.WriteLine($"{animal.Title} - {animal.Value}");
            }
        }

        public void SortedBySizeAnimals(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name}, size: {animal.Size}");
            }
        }

        public void WriteFoundAnimal(Animal animal)
        {
            Console.WriteLine($"Found animal:{Environment.NewLine}{animal.GetType().Name}, size: {animal.Size}");
        }
    }
}