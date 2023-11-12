using System;

class Program
{
    static void Main()
    {
        TransportNetwork transportNetwork = new TransportNetwork();

        Car car = new Car { Speed = 60, Capacity = 4 };
        Bus bus = new Bus { Speed = 40, Capacity = 20 };
        Train train = new Train { Speed = 80, Capacity = 50 };

        transportNetwork.AddVehicle(car);
        transportNetwork.AddVehicle(bus);
        transportNetwork.AddVehicle(train);

        Human passenger1 = new Human { Speed = 5 };
        Human passenger2 = new Human { Speed = 7 };

        car.BoardPassenger(passenger1);
        bus.BoardPassenger(passenger2);

        Route route = new Route { StartPoint = "A", EndPoint = "B" };

        for (int turn = 1; turn <= 5; turn++)
        {
            Console.WriteLine($"Turn {turn}:");

            car.BoardPassenger(new Human { Speed = 6 });
            bus.AlightPassenger(passenger2);

            Console.WriteLine(route.CalculateOptimalRoute("Car"));
            Console.WriteLine(route.CalculateOptimalRoute("Bus"));

            transportNetwork.Simulate();

            Console.WriteLine();
        }
    }
}
