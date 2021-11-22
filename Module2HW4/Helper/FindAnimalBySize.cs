using System.Drawing;
using Module2HW4.Models;

namespace Module2HW4.Helper
{
    public static class FindAnimalBySize
    {
        public static Animal Find(this Animal[] animals, Sizing size)
        {
            Animal result = null;
            foreach (var animal in animals)
            {
                if (animal != null && animal.Size == size)
                {
                    result = animal;
                    break;
                }
            }

            return result;
        }
    }
}