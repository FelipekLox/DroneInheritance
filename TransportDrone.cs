using System;

public class TransportDrone : Drone
{
    public double CargoCapacity { get; set; } // кг
    public string CargoType { get; set; }     // тип груза

    public TransportDrone(string model, string manufacturer,
                          double maxSpeed, double flightRange,
                          double maxFlightTime, double takeoffWeight,
                          double cargoCapacity, string cargoType)
        : base(model, manufacturer, maxSpeed, flightRange,
               maxFlightTime, takeoffWeight)
    {
        CargoCapacity = cargoCapacity;
        CargoType = cargoType;
    }

    public void DeliverCargo()
    {
        Console.WriteLine(
            $"{Model} доставляет груз типа \"{CargoType}\". " +
            $"Грузоподъёмность: {CargoCapacity} кг.");
    }
}