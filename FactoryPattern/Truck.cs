namespace FactoryPattern;

public class Truck : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Build a new Truck!");
    }
}