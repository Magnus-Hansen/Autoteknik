using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class CarCatalog : ICarCatalog
    {
        private List<Car> _carList;
        private string _name;
        private int _cvr;

        public int Cvr
        {
            get { return _cvr; }
            set { _cvr = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Car> Car
        {
            get { return _carList; }
        }

        public CarCatalog(string name, int cvr)
        {
            _name = name;
            _cvr = cvr;
            _carList = new List<Car>();
        }

        public void AddCar(Car car)
        {
            if (_carList.Contains(car) || (_carList.Find(c => (c.RegNr == car.RegNr)) != null))
                throw new ArgumentException();
            _carList.Add(car);
        }
        public void AddRepairToCar(string regNr, AutoRepair newAutoRepair)
        {
            Car carToRepair = _carList.Find(car => (car.RegNr == regNr));
            if (carToRepair != null)
                carToRepair.AddAutoRepair(newAutoRepair);

            //foreach (Car car in _carList)
            //{
            //    if (car.RegNr == regNr)
            //    {
            //        car.AddAutoRepair(newAutoRepair);
            //    }
            //}
        }
        public double AllRepairCost()
        {
            return _carList.Sum(car => car.TotalAutoRepairCost());

            //double total = 0;
            //foreach (Car car in _carList)
            //{
            //    total += car.TotalAutoRepairCost();
            //}
            //return total;
        }
        public bool IsAllCarInCatalogAfter2000()
        {
            return _carList.All<Car>(c => c.Year > 2000);
            //return !(_carList.FindAll(car => car.Year <= 2000) == null);
        }
        public int NumbersOfCarsWithRepairCostAbove10000()
        {
            return _carList.FindAll(car => car.TotalAutoRepairCost() > 10000).Count();
        }
        public override string ToString()
        {
            string carString = "";
            foreach (Car car in _carList)
            {
                carString += car.ToString();
            }
            return $"Name: {_name} - Cvr: {_cvr} -- " + carString;
        }
    }
}
