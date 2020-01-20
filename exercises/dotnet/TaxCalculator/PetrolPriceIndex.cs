using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public static class PetrolPriceIndex
    {
        public static Dictionary<int, int> index = new Dictionary<int, int>()
        {
            {0,0},
            {50, 10},
            {75, 25},
            {90, 105},
            {100, 125},
            {110, 145},
            {130, 165},
            {150, 205},
            {170, 515},
            {190, 830},
            {225, 1240},
            {255, 1760},
            {int.MaxValue, 2070}
        };
    }
}
