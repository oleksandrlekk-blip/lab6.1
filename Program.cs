using LabPolymorphism;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Toyota", 120),
            new Bicycle("Trek", 25),
            new Airplane("Boeing", 850)
        };

        Console.WriteLine("=== Рух транспортних засобів ===");

        foreach (var v in vehicles)
        {
            v.Move();

            if (v is IRefuelable refuelable)
            {
                refuelable.Refill();
            }

            Console.WriteLine();
        }
    }
}
