public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }
    public List<Human> Passengers { get; set; }

    public Vehicle()
    {
        Passengers = new List<Human>();
    }

    public virtual void Move()
    {
        Console.WriteLine($"Vehicle is moving with {Passengers.Count} passengers on board.");
    }

    public void BoardPassenger(Human passenger)
    {
        if (Passengers.Count < Capacity)
        {
            Passengers.Add(passenger);
            Console.WriteLine($"Passenger boarded. {Passengers.Count}/{Capacity} passengers on board.");
        }
        else
        {
            Console.WriteLine("Vehicle is full. Cannot board more passengers.");
        }
    }

    public void AlightPassenger(Human passenger)
    {
        if (Passengers.Contains(passenger))
        {
            Passengers.Remove(passenger);
            Console.WriteLine($"Passenger alighted. {Passengers.Count}/{Capacity} passengers remaining.");
        }
        else
        {
            Console.WriteLine("Passenger not found on the vehicle.");
        }
    }
}