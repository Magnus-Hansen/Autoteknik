using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class Car : ICar
    {
        private Dictionary<int, AutoRepair> _autoRepairDic;
        private string _regNr;
        private int _year;
        private string _make;
        private string _model;
        private int _mileage;
        private Owner _owner;

        public Dictionary<int, AutoRepair> AutoRepairDic
        {
            get { return _autoRepairDic; }
        }
        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }
        public string Model
        {
            get { return _model; }
        }
        public string Make
        {
            get { return _make; }
        }
        public int Year
        {
            get { return _year; }
        }
        public string RegNr
        {
            get { return _regNr; }
        }
        public Car(string regNr, int year, string make, string model, int mileage)
        {
            if (regNr.Length != 7)
                throw new BadRegNrException();
            _regNr = regNr;
            _year = year;
            _make = make;
            _model = model;
            _mileage = mileage;
            _autoRepairDic = new Dictionary<int, AutoRepair>();
        }

        public void AddAutoRepair(AutoRepair autoRepair)
        {
            _autoRepairDic.Add(autoRepair.Id, autoRepair);
        }
        public double TotalAutoRepairCost()
        {
            double total = 0;
            foreach (AutoRepair autoRepair in _autoRepairDic.Values)
            {
                total = total + autoRepair.Price;
            }
            return total;
        }
        public void AddOwner(Owner owner)
        {
            _owner = owner;
        }
        public override string ToString()
        {
            string returnString = "";
            if (_owner != null)
            {
                returnString = _owner.ToString();
            }
            foreach (AutoRepair autoRepair in _autoRepairDic.Values)
            {
                returnString += autoRepair.ToString();
            }
            return $"RegNr: {_regNr} - Year: {_year} - Make: {_make} - Mileage: {Mileage} --" + returnString;
        }
    }
}
