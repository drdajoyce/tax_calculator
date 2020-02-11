using System.Collections.Generic;

namespace TaxCalculator.Tests
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            var emissions = vehicle.Co2Emissions;
            var fuelType = vehicle.FuelType;
            var year = vehicle.DateOfFirstRegistration.Year;
            var listPrice = vehicle.ListPrice;
            var cost = 0;
            var currentYear = 2019;

            if (!year.Equals(currentYear))
            {
                if (listPrice > 40000)
                {
                    cost = GetTaxBandFromFuelAfterYearOne(fuelType, 450, 310, 440);
                }
                else
                {
                    cost = GetTaxBandFromFuelAfterYearOne(fuelType, 140, 0, 130);
                }
            }
            else
            {
                if (fuelType.Equals(FuelType.Electric))
                {
                    cost = 0;
                }
                else if (fuelType.Equals(FuelType.Petrol) || fuelType.Equals(FuelType.DieselRDE2))
                {
                    cost = GetTaxBandFromEmissions(emissions, PetrolPriceIndex.index);

                }
                else if (fuelType.Equals(FuelType.Diesel))
                {
                    cost = GetTaxBandFromEmissions(emissions, DieselPriceIndex.index);

                }
                else if (fuelType.Equals(FuelType.AlternativeFuel))
                {
                    cost = GetTaxBandFromEmissions(emissions, AlternativeFuelPriceIndex.index);
                }
            }
            return cost;
        }

        private static int GetTaxBandFromFuelAfterYearOne(FuelType fuelType, int petrolDieselCost, int electricCost, int alternativeFuelCost)
        {
            var result = 0;
            if (fuelType.Equals(FuelType.Petrol) || fuelType.Equals(FuelType.Diesel))
            {
                result = petrolDieselCost;
            }
            else if (fuelType.Equals(FuelType.Electric))
            {
                result = electricCost;
            }
            else if (fuelType.Equals(FuelType.AlternativeFuel))
            {
                result = alternativeFuelCost;
            }
            return result;
        }

        private static int GetTaxBandFromEmissions(int emissions, Dictionary<int, int> index)
        {
            var result = 0;
            foreach (var taxband in index)
            {
                if (emissions <= taxband.Key)
                {
                    result = taxband.Value;
                    break;
                }
            }
            return result;
        }
    }
}
