namespace Autoteknik
{
    public interface ICarCatalog
    {
        int Cvr { get; set; }
        string Name { get; set; }

        void AddCar(Car car);
        void AddRepairToCar(string regNr, AutoRepair newAutoRepair);
        double AllRepairCost();
    }
}