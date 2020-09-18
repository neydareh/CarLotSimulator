using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator

//Create a seperate class file called Car
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property
{
    public class Car
    {
        //Constructors
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            EngineNoise = "";
            HonkNoise = "";
        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable = false)
        {
            Make = make;
            Year = year;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        //fields
        
        //Properties

        //Make property
        public string Make { get; set; }
        //Model property
        public string Model { get; set; }
        //Year property
        public int Year { get; set; }
        //EngineNoise property
        public string EngineNoise { get; set; }
        //HonkNoise property
        public string HonkNoise { get; set; }
        //IsDriveable property
        public bool IsDriveable { get; set; }

        //Methods
        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
