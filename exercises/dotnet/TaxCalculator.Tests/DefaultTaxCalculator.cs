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
            Dictionary<int, int> index = null;

            switch (vehicle.FuelType)
            {
                case FuelType.Petrol:
                    index = PetrolPriceIndex.index;
                    break;
                case FuelType.Diesel:
                    index = DieselPriceIndex.index;
                    break;
            }

            foreach (var taxband in index)
            {
                if (emissions <= taxband.Key)
                {
                    return taxband.Value;
                }
            }
            return cost;


        }
    }
}
