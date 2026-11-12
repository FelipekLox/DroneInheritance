using System;

class Program
{
    static void Main()
    {
        // «Форпост-Р» — разведывательный БПЛА
        ReconDrone forpost = new ReconDrone(
            "Форпост-Р", "УЗГА",
            200, 250, 18, 500, // общие параметры
            60, 6000           // камера 60 Мп, высота 6000 м
        );

        // «Ланцет-3» — ударный БПЛА
        AttackDrone lancet = new AttackDrone(
            "Ланцет-3", "ZALA",
            110, 100, 1, 12,   // общие параметры
            5, "бронетехника"  // боевая часть 5 кг
        );

        // «Кощей» — тяжёлый транспортный БПЛА
        TransportDrone koshchey = new TransportDrone(
            "Кощей", "Авирон",
            80, 250, 6, 500,   // общие параметры (примерные)
            320, "медицинский"
        );

        // «КУБ-БЛА» — барражирующий боеприпас
        LoiteringMunition kub = new LoiteringMunition(
            "КУБ-БЛА", "ZALA",
            130, 40, 0.5, 10,             // общие параметры от Drone
            3, "живая сила и техника",    // параметры от AttackDrone
            30, "оптико-электронное"      // собственные параметры
        );

        // «Орион» — разведывательно-ударный БПЛА
        AttackReconDrone orion = new AttackReconDrone(
            "Орион", "Кронштадт",
            200, 250, 30, 1150,  // общие параметры
            60, 7000,            // параметры разведчика
            "крылатая ракета", 4 // параметры ударного вооружения
        );

        // Массив базового типа Drone[] со всеми объектами
        Drone[] fleet = { forpost, lancet, koshchey, kub, orion };

        Console.WriteLine("=== Унаследованный метод GetInfo() через массив Drone[] ===");
        foreach (Drone drone in fleet)
        {
            Console.WriteLine(drone.GetInfo());
        }

        Console.WriteLine("\n=== Собственные методы ===");
        forpost.PerformReconnaissance();
        lancet.PerformStrike();
        koshchey.DeliverCargo();
        kub.LoiterAndStrike();
        orion.PerformReconAndStrike();
    }
}