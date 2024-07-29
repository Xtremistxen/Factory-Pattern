namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Build a new Motorcycle!");
    }
}