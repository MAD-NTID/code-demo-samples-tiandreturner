using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedOOP
{
    class Engine
    {
        private int numCylinders;

        public int NumCylinders
        {
            get { return numCylinders; }
            set { numCylinders = value; }
        }

        private string fuelType;

        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }

        private int horsePower;

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        private double engineSize;

        public double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }

        public override string ToString()
        {
            return $"Number of Cylinders: {NumCylinders}\nFuel Type: {FuelType}" +
                $"\nHorse Power: {HorsePower}\nEngine Size: {EngineSize:N1}\n";
        }



    }
}
