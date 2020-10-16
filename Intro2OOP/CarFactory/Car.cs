using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarFactory
{
    class Car
    {
        // data fields
        private double price;
        private int year;

        // these are properties
        public string Color { get; set; }
        public string Windows { get; set; }
        public string TypeOfTires { get; set; }

        public bool HasGPS { get; set; }
        public string DoorType { get; set; }
        public string AntennaType { get; set; }
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

        // use propfull and then click the tab twice 
        // to generate both of the property and data field
        //private int number;

        //public int Number
        //{   
        //    get { return number; }
        //    set { number = value; }
        //}



        //public double Price { get; set; }

        public bool HasRadio { set; get;  }

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

        public bool IsRunning { get; set; }

        // default constructor
        public Car()
        {
            Color = "White";
            Windows = "Tinted Windows";
            TypeOfTires = "Seaonal Tires";
            HasGPS = false;
            DoorType = "Door";
            AntennaType = "Rod";
            Price = 5000;
            HasRadio = false;
            Year = 2000;
            CarType = "Truck";
            Make = "Chevrolet";
            Model = "Silverdo";
            IsRunning = false;
         }

        public Car(string _make, string _model, int _year, string _color, string _carType)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Color = _color;
            CarType = _carType;
        }

        // parameterized constructor
        public Car(string _color, string _windows, string _typeOfTires, bool _hasGPS,
            string _doorType, string _antennaType, double _price, bool _hasRadio,
            int _year, string _carType, string _make, string _model, bool _isRunning)
        {
            Color = _color;
            Windows = _windows;
            TypeOfTires = _typeOfTires;
            HasGPS = _hasGPS;
            DoorType = _doorType;
            AntennaType = _antennaType;
            Price = _price;
            HasRadio = _hasRadio;
            Year = _year;
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
                $"\nColor: {Color}" +
                $"\nPrice: {Price}" +
                "\nYear: {0}", Year +
                $"\nType of tires: {TypeOfTires}"  +
                "\nHas GPS: " + HasGPS +
                "\nHas Radio: " + HasRadio +
                $"\nDoor Type: {DoorType}"  +
                $"\nWindows Type: {Windows}"  +
                $"\nCar Type: {CarType}" +
                $"\nIs this car currently running: {IsRunning}");
        }
    }
}
