using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace CarRecords
{
    class Car
    {
        // data fields
        private double price;
        private int year;

        // these are properties
        public string Color { get; set; }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value >= 0)
                {
                    price = value;
                }
                else
                {
                    price = 400;
                }
            }
        }


        public int Year 
        { 
            get
            {
                return year;
            }
            set
            {
                if(value >= 1990 &&  value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else
                {
                    year = DateTime.Now.Year;
                }
            }
        }


        public string CarType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public int GasTankCapacity { get; set; }

        public Engine Engine { get; set; }

        public bool IsRunning { get; set; }

        // default constructor
        public Car()
        {
            Price = 5000;
            Year = 2000;
            Color = "White";
            CarType = "Truck";
            Make = "Chevrolet";
            Model = "Silverdo";
            IsRunning = false;
         }

        public Car(string _make, string _model, int _year, string _color, string _carType, int _gasTankCap, Engine _engine)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Color = _color;
            CarType = _carType;
            GasTankCapacity = _gasTankCap;
            Engine = _engine;
            IsRunning = false;
        }

        // parameterized constructor
        public Car( double _price, int _year, string _color, string _carType, string _make, string _model, bool _isRunning)
        {
            Price = _price;
            Year = _year;
            Color = _color;
            CarType = _carType;
            Make = _make;
            Model = _model;
            IsRunning = _isRunning;
        }

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

        public override string ToString()
        {
            return string.Format("Make: " + Make +
                "\nModel: " + Model + 
                $"\nPrice: {Price}" +
                "\nYear: {0}", Year +
                $"\nCar Type: {CarType}" +
                $"\nGas Tank Capacity: {GasTankCapacity}");
        }

        public string ToCSVFormat()
        {
            return string.Format($"{Year},{Color},{GasTankCapacity}," +
                $"{Make},{Model},{CarType},{Engine.EngineSize}," +
               $"{Engine.NumCylinders},{Engine.FuelType},{Engine.HorsePower}");
        }

        public bool DoesEngineExist()
        {
            return true;
        }
    }
}
