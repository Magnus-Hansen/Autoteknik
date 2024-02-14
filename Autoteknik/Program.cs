using Autoteknik;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car1 = new Car("1234567", 2023, "CarCompany", "CarModel", 55);
        Car car2 = new Car("regNumb", 2024, "Competitor", "CoolerModel", 65);

        Console.WriteLine(car1.ToString());
        Console.WriteLine(car2.ToString());

        CarCatalog carCatalog = new CarCatalog("CarCatalog", 44);

        carCatalog.AddCar(car1);
        carCatalog.AddCar(car2);

        Console.WriteLine(carCatalog.ToString());

        Console.WriteLine("Sprint 2");

        AutoRepair autoRepair1 = new AutoRepair("repair1", 50);
        AutoRepair autoRepair2 = new AutoRepair("repair2", 60);

        Console.WriteLine(autoRepair1.ToString());
        Console.WriteLine(autoRepair2.ToString());

        car1.AddAutoRepair(autoRepair1); 
        car1.AddAutoRepair(autoRepair2);

        Console.WriteLine(car1.ToString());

        AutoRepair autoRepair3 = new AutoRepair("repair3", 70);

        carCatalog.AddRepairToCar("12345", autoRepair3);

        Console.WriteLine();
        Console.WriteLine(carCatalog.ToString());

        Console.WriteLine("sprint 3");

        Console.WriteLine(car1.TotalAutoRepairCost());

        try
        {
            Car car3 = new Car("regNr", 2024, "failCompany", "BuggyModel", 65);
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Owner owner1 = new Owner("hr", 1, "jens", "555");
        Owner owner2 = new Owner("fru", 2, "anna", "444");

        car1.AddOwner(owner1);

        Console.WriteLine(car1.ToString());

        Repository<Mechanics> mechanics = new Repository<Mechanics>();

        Console.WriteLine("End meeeeeeeeeeeeeeeeeeeeeee");

        mechanics.GetCustomOrdering((x, y) => { return x.Education.CompareTo(y.Education); });
        mechanics.printAll();
    }
}