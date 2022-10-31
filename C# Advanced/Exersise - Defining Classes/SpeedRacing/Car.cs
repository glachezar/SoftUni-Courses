using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionFor1km;
            this.TravelledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double distance)
        {
            double fuelToUse = distance * FuelConsumptionPerKilometer;
            if (this.FuelAmount - fuelToUse < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            else
            {
                this.FuelAmount -= fuelToUse;
                this.TravelledDistance += distance;
            }
        }
        public override string ToString() => $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
    }
}
