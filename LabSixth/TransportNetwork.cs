public class TransportNetwork
{
    private List<Vehicle> vehicles;

    public TransportNetwork()
    {
        vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void Simulate()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }
}