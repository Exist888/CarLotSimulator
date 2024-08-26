using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }  // Property - Year of Car
    public string Make { get; set; }  // Property - Make of Car
    public string Model { get; set; }  // Property - Model of Car
    public string EngineNoise { get; set; }  // Property
    public string HonkNoise { get; set; }  // Property

    public void MakeEngineNoise()
    {
        Console.WriteLine($"A {Year} {Make} {Model} makes a {EngineNoise} engine noise.");
    }

    public void MakeHonkNoise()
    {
        Console.WriteLine($"    It also makes a {HonkNoise} honk noise.\n" +
                          $"");
    }

    public Car()
    {
        CarLot.NumberOfCars++;
    }
}