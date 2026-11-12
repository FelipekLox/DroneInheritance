using System;

public class AttackReconDrone : ReconDrone
{
    public string WeaponType { get; set; } // тип вооружения
    public int Hardpoints { get; set; }    // количество точек подвески

    public AttackReconDrone(string model, string manufacturer,
                            double maxSpeed, double flightRange,
                            double maxFlightTime, double takeoffWeight,
                            double cameraResolution, double reconAltitude,
                            string weaponType, int hardpoints)
        : base(model, manufacturer, maxSpeed, flightRange,
               maxFlightTime, takeoffWeight, cameraResolution, reconAltitude)
    {
        WeaponType = weaponType;
        Hardpoints = hardpoints;
    }

    public void PerformReconAndStrike()
    {
        Console.WriteLine(
            $"{Model} ведёт разведку с высоты {ReconAltitude} м (камера {CameraResolution} Мп) " +
            $"и наносит удар вооружением типа \"{WeaponType}\" ({Hardpoints} точек подвески).");
    }
}