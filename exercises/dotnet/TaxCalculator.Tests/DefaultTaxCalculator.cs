using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Tests
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            var emissions = vehicle.Co2Emissions;
            var cost = 0;

            foreach (var taxband in PetrolPriceIndex.index)
            {
                if(emissions <= taxband.Key)
                {
                    return taxband.Value;
                }
            }
            return cost;

            /*if(emissions == 0)
            {
                return 0;
            }
            else if (emissions <= 50) 
            {
                return 10; 
            }
            else if (emissions <= 75)
            {
                return 25;
            }
            else if (emissions <= 90)
            {
                return 105;
            }
            else if (emissions <= 100)
            {
                return 125;
            }
            else if (emissions <= 110)
            {
                return 145;
            }
            else if (emissions <= 130)
            {
                return 165;
            }
            else if (emissions <= 150)
            {
                return 205;
            }
            else if (emissions <= 170)
            {
                return 515;
            }
            else if (emissions <= 190)
            {
                return 830;
            }
            else if (emissions <= 225)
            {
                return 1240;
            }
            else if (emissions <= 255)
            {
                return 1760;
            }
            else
            {
                return 2070;
            }*/
        }
    }
}
