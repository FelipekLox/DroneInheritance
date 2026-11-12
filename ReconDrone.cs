using System;

public class ReconDrone : Drone
{
    public double CameraResolution { get; set; } // Мп
    public double ReconAltitude { get; set; }    // м

    public ReconDrone(string model, string manufacturer,
                      double maxSpeed, double flightRange,
                      double maxFlightTime, double takeoffWeight,
                      double cameraResolution, double reconAltitude)
        : base(model, manufacturer, maxSpeed, flightRange,
               maxFlightTime, takeoffWeight) // вызов конструктора базового класса
    {
        CameraResolution = cameraResolution;
        ReconAltitude = reconAltitude;
    }

    public void PerformReconnaissance()
    {
        Console.WriteLine(
            $"{Model} ведёт разведку с высоты {ReconAltitude} м. " +
            $"Камера: {CameraResolution} Мп.");
    }
}