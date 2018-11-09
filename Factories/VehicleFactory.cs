namespace csharp_examples.factories
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
        
    }
}