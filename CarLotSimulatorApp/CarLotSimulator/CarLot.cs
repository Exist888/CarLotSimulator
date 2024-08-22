using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> CarInventory { get; set; } = new List<Car>();
    
    public void CarDetails()
    {
        Console.WriteLine("Here is our current inventory:");
        foreach (var carYearMakeModel in CarInventory)
        {
            Console.WriteLine($"{carYearMakeModel.Year} {carYearMakeModel.Make} {carYearMakeModel.Model}.");
        }
    }
}

