using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public static class DieselPriceIndex
    {
        public static Dictionary<int, int> index = new Dictionary<int, int>()
        {
            {0,0},
            {50, 25},
            {75, 105},
            {90, 125},
            {100, 145},
            {110, 165},
            {130, 205},
            {150, 515},
            {170, 830},
            {190, 1240},
            {225, 1760},
            {255, 2070},
            {int.MaxValue, 2070}
        };
    }
}
