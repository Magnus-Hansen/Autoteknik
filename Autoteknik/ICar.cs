namespace Autoteknik
{
    public interface ICar
    {
        string Make { get; }
        int Mileage { get; set; }
        string Model { get; }
        string RegNr { get; }
        int Year { get; }

        void AddAutoRepair(AutoRepair autoRepair);
        void AddOwner(Owner owner);
        double TotalAutoRepairCost();
    }
}