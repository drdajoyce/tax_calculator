using System.Collections.Generic;

namespace TaxCalculator
{
    public static class PetrolPriceIndex
    {
        public static Dictionary<int, int> index = new Dictionary<int, int>()
        {
            {0,0},
            {50, 10},
            {75, 25},
            {90, 110},
            {100, 130},
            {110, 150},
            {130, 170},
            {150, 210},
            {170, 530},
            {190, 855},
            {225, 1280},
            {255, 1815},
            {int.MaxValue, 2135}
        };
    }
}
