using System.Collections;
using System.Collections.Generic;
using Module2HW4.Models;

namespace Module2HW4.Helper
{
    public class AnimalSizeComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            switch (x?.Size - y?.Size)
            {
                case >0:
                    return 1;
                case <0:
                    return -1;
            }

            return 0;
        }
    }
}