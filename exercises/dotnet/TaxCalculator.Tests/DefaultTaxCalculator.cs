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
            var fuelType = vehicle.FuelType;
            var cost = 0;

            if (fuelType.Equals(FuelType.Electric))
            {
                return 0;
            }
            else if(fuelType.Equals(FuelType.Petrol))
            {
                foreach (var taxband in PetrolPriceIndex.index)
                {
                    if(emissions <= taxband.Key)
                    {
                        return taxband.Value;
                    }
                }
                return cost;
            }
            else if (fuelType.Equals(FuelType.AlternativeFuel))
            {
                foreach (var taxband in AlternativeFuelPriceIndex.index)
                {
                    if (emissions <= taxband.Key)
                    {
                        return taxband.Value;
                    }
                }
                return cost;
            }
            return cost;
        }
    }
}
