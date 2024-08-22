using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarLot currentInventory = new CarLot();
            
            //TODO

            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car myFirstCar = new Car();  // Instantiating First Car - Setting Properties Using First Way - Dot Notation
            myFirstCar.Year = 1957;
            myFirstCar.Make = "Chevy";
            myFirstCar.Model = "Bel Air";
            myFirstCar.EngineNoise = "medium";
            myFirstCar.HonkNoise = "loud";

            Car mySecondCar = new Car()  // Instantiating Second Car - Setting Properties Using Second Way - Object Initializer
            {
                Year = 1991, Make = "Pontiac", Model = "Sunbird", EngineNoise = "medium", HonkNoise = "medium"
            };

            Car myThirdCar = new Car() // Instantiating Second Car - Setting Properties Using Third Way - Object Initializer
            {
                Year = 2024,
                Make = "Subaru",
                Model = "Solterra",
                EngineNoise = "very soft",
                HonkNoise = "medium"
            };

            currentInventory.CarInventory.Add(myFirstCar);
            currentInventory.CarInventory.Add(mySecondCar);
            currentInventory.CarInventory.Add(myThirdCar);
            
            myFirstCar.MakeEngineNoise();
            myFirstCar.MakeHonkNoise();
            mySecondCar.MakeEngineNoise();
            mySecondCar.MakeHonkNoise();
            myThirdCar.MakeEngineNoise();
            myThirdCar.MakeHonkNoise();

            currentInventory.CarDetails();  // Note to self - variable name from Main, Method name from CarLot Class.

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate the CarLot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
