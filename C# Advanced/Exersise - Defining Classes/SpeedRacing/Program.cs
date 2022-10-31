using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuel = double.Parse(carInfo[1]);
                double consumption = double.Parse(carInfo[2]);
                cars.Add(new Car(model, fuel, consumption));
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string carModel = input.Split().Skip(1).First();
                double distance = double.Parse(input.Split().Last());
                Car currentCar = cars.Find(c => c.Model == carModel);
                currentCar.Drive(distance);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
