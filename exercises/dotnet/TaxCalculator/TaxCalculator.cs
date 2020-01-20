using System;

namespace TaxCalculator
{
    public abstract class TaxCalculator
    {
        protected int Year { get; }

        public abstract int CalculateTax(Vehicle vehicle);

        protected TaxCalculator() : this(DateTime.Now.Year)
        { 

        }

        protected TaxCalculator(int year)
        {
            Year = year;
        }
    }
}
