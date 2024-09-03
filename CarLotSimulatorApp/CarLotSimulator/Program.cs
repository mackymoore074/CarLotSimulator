using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var car1 = new Car();
            car1.Year = 2019;
            car1.Make = "Toyota";
            car1.Model = "Corolla";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Beep";
            car1.IsDriveable = true;

            var car2 = new Car();
            car2.Year = 2020;
            car2.Make = "Ford";
            car2.Model = "Fusion";
            car2.EngineNoise = "Vroom";
            car2.HonkNoise = "Beep";
            car2.IsDriveable = true;

            var car3 = new Car();
            car3.Year = 2021;
            car3.Make = "Chevy";
            car3.Model = "Malibu";
            car3.EngineNoise = "Vroom";
            car3.HonkNoise = "Beep";
            car3.IsDriveable = true;


            //Set the properties for each of the cars
            //Call each of the methods for each car

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Car.parkingLot = new List<Car>() { car1, car2, car3 };

            foreach (var car in Car.parkingLot)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                Console.WriteLine("Is it driveable? " + car.IsDriveable);
            }
        }
    }
}
