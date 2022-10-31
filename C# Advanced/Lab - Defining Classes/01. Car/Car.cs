using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

		private string make;

		public string Make
		{
			get { return make; }

			set { make = value; }
		}

		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

		private double fuelQuantity;

		public double FuelQuantity
        {
			get { return fuelQuantity; }
			set { fuelQuantity = value; }
		}

		private double fuelConsumption;

		public double FuelConsumption
        {
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}

        private Engine engine;

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        private Tire[] tires;

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }


        public void Drive(double distance)
        {
            //This method checks if the car fuel quantity minus the distance multiplied by the car fuel consumption is bigger than zero.
            //If it is removed from the fuel quantity, the result of the multiplication between the distance and the fuel consumption.
            //Otherwise, write on the console the following message:
            //"Not enough fuel to perform this trip!"
            double consumptionPerKilommeter = fuelConsumption / 100;
            double consumedFuel = distance * consumptionPerKilommeter;

            if (fuelQuantity - consumedFuel > 0)
            {
                fuelQuantity -= consumedFuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nHorsePowers: {engine.HorsePower}\nFuelQuantity: {this.FuelQuantity}";
        }
    }
}
