public class Drone
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public double MaxSpeed { get; set; }      // км/ч
    public double FlightRange { get; set; }   // км
    public double MaxFlightTime { get; set; } // ч
    public double TakeoffWeight { get; set; } // кг

    public Drone(string model, string manufacturer,
                 double maxSpeed, double flightRange,
                 double maxFlightTime, double takeoffWeight)
    {
        Model = model;
        Manufacturer = manufacturer;
        MaxSpeed = maxSpeed;
        FlightRange = flightRange;
        MaxFlightTime = maxFlightTime;
        TakeoffWeight = takeoffWeight;
    }

    public string GetInfo()
    {
        return $"{Model} ({Manufacturer}): " +
               $"скорость {MaxSpeed} км/ч, " +
               $"дальность {FlightRange} км, " +
               $"время полёта {MaxFlightTime} ч, " +
               $"взлётная масса {TakeoffWeight} кг";
    }
}