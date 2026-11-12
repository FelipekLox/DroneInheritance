using System;

public class LoiteringMunition : AttackDrone
{
    public double LoiterTime { get; set; } // мин.
    public string SeekerType { get; set; } // тип наведения

    public LoiteringMunition(string model, string manufacturer,
                             double maxSpeed, double flightRange,
                             double maxFlightTime, double takeoffWeight,
                             double warheadWeight, string targetType,
                             double loiterTime, string seekerType)
        : base(model, manufacturer, maxSpeed, flightRange,
               maxFlightTime, takeoffWeight, warheadWeight, targetType)
    {
        LoiterTime = loiterTime;
        SeekerType = seekerType;
    }

    public void LoiterAndStrike()
    {
        Console.WriteLine(
            $"{Model} барражирует в течение {LoiterTime} мин. " +
            $"(наведение: {SeekerType}) и наносит удар по цели типа \"{TargetType}\" " +
            $"боевой частью {WarheadWeight} кг.");
    }
}