namespace FactoryPattern;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Build a new car!");
    }
}