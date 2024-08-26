using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> CarInventory { get; set; } = new List<Car>();
    
    //Inside the CarLot Class, create a static field called numberOfCars.
    //Have this number only increment when in our program we create a new Car.
    //From there, use the 3 cars in the Main() (from the previous exercise)
    //and then each time you create a car do a Console.WriteLine()
    //printing the current number of cars in the car lot.
    
    //Field
    public static int NumberOfCars = 0;   //Starting with 0, will add as cars come in

    // public int AddCars()
    // {
    //     foreach (var newCar in CarInventory)
    //     {
    //         _numberOfCars = _numberOfCars + 1;
    //     }
    //
    //     return _numberOfCars;
    // }
    
    public void CarDetails()
    {
        Console.WriteLine("Here is our current inventory:");
        foreach (var carYearMakeModel in CarInventory)
        {
            Console.WriteLine($"{carYearMakeModel.Year} {carYearMakeModel.Make} {carYearMakeModel.Model}.");
            //Console.WriteLine($"Total cars so far: {NumberOfCars}");
        }
    }
}

