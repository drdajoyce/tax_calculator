using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Tests
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        private bool story5;
        private bool story4;


        public DefaultTaxCalculator(bool story4 = false, bool story5 = false)
        {
            this.story4 = story4;
            this.story5 = story5;
        }
        public override int CalculateTax(Vehicle vehicle)
        {

            var emissions = vehicle.Co2Emissions;
            var fuelType = vehicle.FuelType;
            var listPrice = vehicle.ListPrice;
            var year = vehicle.DateOfFirstRegistration.Year;
            var cost = 0;
            Dictionary<int, int> index = null;
            if (story5)
            {
                if (!year.Equals(2019) && listPrice > 40000)
                {
                    if (fuelType.Equals(FuelType.Petrol) || fuelType.Equals(FuelType.Diesel))
                    {
                        return 450;
                    }
                    else if (fuelType.Equals(FuelType.Electric))
                    {
                        return 310;
                    }
                    else if (fuelType.Equals(FuelType.AlternativeFuel))
                    {
                        return 440;
                    }
                }
            }
            else if (story4)
            {
                if (!year.Equals(2019))
                {
                    if (fuelType.Equals(FuelType.Petrol) || fuelType.Equals(FuelType.Diesel))
                    {
                        return 140;
                    }
                    else if (fuelType.Equals(FuelType.Electric))
                    {
                        return 0;
                    }
                    else if (fuelType.Equals(FuelType.AlternativeFuel))
                    {
                        return 130;
                    }
                }

            }

            else
            {
                if (fuelType.Equals(FuelType.Electric))
                {
                    return 0;
                }
                else if (fuelType.Equals(FuelType.Petrol))
                {
                    foreach (var taxband in PetrolPriceIndex.index)
                    {
                        if (emissions <= taxband.Key)
                        {
                            return taxband.Value;
                        }
                    }
                    return cost;
                }
                else if (fuelType.Equals(FuelType.Diesel))
                {
                    index = DieselPriceIndex.index;
                    foreach (var taxband in index)
                    {
                        if (emissions <= taxband.Key)
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
            }
            return cost;
        }
    }
}
