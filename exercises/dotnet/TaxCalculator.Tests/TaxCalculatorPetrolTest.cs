using System;
using NUnit.Framework;

namespace TaxCalculator.Tests
{
    class TaxCalculatorPetrolTest
    {
        private static readonly DateTime FirstOfJanuary2019 = new DateTime(2019, 1, 1);
        private TaxCalculator _taxCalculator;

        [SetUp]
        public void BeforeEach()
        {
            _taxCalculator = new DummyTaxCalculator();
        }

        [Test]
        public void WhenVehicleHas0GramsCo2()
        {
            Vehicle vehicle = new Vehicle(0, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(0, tax);
        }

        [Test]
        public void WhenVehicleHas50GramsCo2()
        {
            Vehicle vehicle = new Vehicle(50, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(10, tax);
        }

        [Test]
        public void WhenVehicleHas75GramsCo2()
        {
            Vehicle vehicle = new Vehicle(75, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(25, tax);
        }

        [Test]
        public void WhenVehicleHas90GramsCo2()
        {
            Vehicle vehicle = new Vehicle(90, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(105, tax);
        }

        [Test]
        public void WhenVehicleHas100GramsCo2()
        {
            Vehicle vehicle = new Vehicle(100, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(125, tax);
        }

        [Test]
        public void WhenVehicleHas110GramsCo2()
        {
            Vehicle vehicle = new Vehicle(110, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(145, tax);
        }

        [Test]
        public void WhenVehicleHas130GramsCo2()
        {
            Vehicle vehicle = new Vehicle(130, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(165, tax);
        }

        [Test]
        public void WhenVehicleHas150GramsCo2()
        {
            Vehicle vehicle = new Vehicle(150, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(205, tax);
        }

        [Test]
        public void WhenVehicleHas170GramsCo2()
        {
            Vehicle vehicle = new Vehicle(170, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(515, tax);
        }

        [Test]
        public void WhenVehicleHas190GramsCo2()
        {
            Vehicle vehicle = new Vehicle(190, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(830, tax);
        }

        [Test]
        public void WhenVehicleHas225GramsCo2()
        {
            Vehicle vehicle = new Vehicle(225, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(1240, tax);
        }

        [Test]
        public void WhenVehicleHas255GramsCo2()
        {
            Vehicle vehicle = new Vehicle(255, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(1760, tax);
        }

        [Test]
        public void WhenVehicleHasOver255GramsCo2()
        {
            Vehicle vehicle = new Vehicle(256, FuelType.Petrol, FirstOfJanuary2019, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(2070, tax);
        }
    }
}
