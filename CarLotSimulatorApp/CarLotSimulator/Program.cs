using System;
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

            CarLot carLot = new CarLot();


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car firstCar = new Car();
            firstCar.Make = "Toyota";
            firstCar.Model = "Sequia";
            firstCar.Year = 2015;
            firstCar.EngineNoise = "Car Engine";
            firstCar.HonkNoise = "Honk Honk!!!";
            firstCar.IsDriveable = true;
            firstCar.MakeEngineNoise();
            firstCar.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car secondCar = new Car()
            {
                Make = "Infiniti",
                Model = "Q60",
                Year = 2019,
                EngineNoise = "Engine Noise",
                HonkNoise = "Honk Honk!!!",
                IsDriveable = true
            };
            secondCar.MakeEngineNoise();
            secondCar.MakeHonkNoise();

            Car thirdCar = new Car(2020, "Mercedez", "G-Class", "Engine Noise", "Honk Honk!!");
            thirdCar.MakeEngineNoise();
            thirdCar.MakeHonkNoise();


            //*************BONUS X 2*************//
            //Add first car to the car lot
            carLot.carList.Add(firstCar);
            carLot.carList.Add(secondCar);
            carLot.carList.Add(thirdCar);

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("Car List");
            Console.WriteLine("***********************");
            foreach (Car car in carLot.carList)
            {
                Console.WriteLine($"Car Make = {car.Make}, Car Model = {car.Model}, Car Year = {car.Year}");
            }
        }
    }
}
