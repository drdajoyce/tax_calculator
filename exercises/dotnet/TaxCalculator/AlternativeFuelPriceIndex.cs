using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public static class AlternativeFuelPriceIndex
    {
        public static Dictionary<int, int> index = new Dictionary<int, int>()
        {
            {0,0},
            {50, 0},
            {75, 15},
            {90, 95},
            {100, 115},
            {110, 135},
            {130, 155},
            {150, 195},
            {170, 505},
            {190, 820},
            {225, 1230},
            {255, 1750},
            {int.MaxValue, 2060}
        };
    }
}

