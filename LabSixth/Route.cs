public class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }

    public string CalculateOptimalRoute(string vehicleType)
    {
        return $"Optimal route for {vehicleType} from {StartPoint} to {EndPoint}";
    }
}