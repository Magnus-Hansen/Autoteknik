using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autoteknik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik.Tests
{
    [TestClass()]
    public class CarCatalogTests
    {
        CarCatalog carCatalog = new CarCatalog("name", 44);
        Car car1 = new Car("1234567", 2023, "CarCompany", "CarModel", 55);
        Car car2 = new Car("regNumb", 2024, "Competitor", "CoolerModel", 65);

        [TestMethod()]
        public void AddCarTest()
        {
            int numberBefore = carCatalog.Car.Count;

            carCatalog.AddCar(car1);

            int numberAfter = numberBefore + 1;

            Assert.AreEqual(numberAfter, carCatalog.Car.Count);
        }

        [TestMethod()]
        public void AddRepairToCarTest()
        {
            AutoRepair autoRepair = new AutoRepair("test", 33);

            int numOfRepair = 0;

            carCatalog.AddCar(car1);
            carCatalog.AddRepairToCar(car1.RegNr, autoRepair);

            foreach (Car c in carCatalog.Car)
            {
                numOfRepair = c.AutoRepairDic.Count + numOfRepair;
            }

            Assert.AreEqual(1, numOfRepair);
        }

        [TestMethod()]
        public void AllRepairCostTest()
        {
            carCatalog.AddCar(car2);
            carCatalog.AddCar(car1);

            Assert.AreEqual(car2.TotalAutoRepairCost() + car1.TotalAutoRepairCost(), carCatalog.AllRepairCost());
        }
    }
}