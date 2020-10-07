using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    class Car
    {
        // these are properties
        public string Color { get; set; }
        public string Windows { get; set; }
        public string TypeOfTires { get; set; }

        public bool HasGPS { get; set; }
        public string DoorType { get; set; }
        public string AntennaType { get; set; }
        public double Price { get; set; }

        public bool HasRadio { set; get;  }

        public int Year { get; set; }
        public string CarType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public bool IsRunning { get; set; }

        public void Drive()
        {
            if (IsRunning)
            {
                Console.WriteLine("The car is now in driving mode");
            }
            else
            {
                Console.WriteLine("Cannot shift into the drive mode, the car is not running");
            }
        }
    }
}
