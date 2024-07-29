namespace FactoryPattern;

public class VehicleFactory
{
    public static IVehicle GetVehicle(int numberOfTires)
    {
        switch (numberOfTires)
        {
            case 4:
                return new Car();
            case 2:
                return new Motorcycle();
            case 6:
                return new Truck();
            default:

                throw new ArgumentException("Invalid number of tires");
            
        }
    }
}