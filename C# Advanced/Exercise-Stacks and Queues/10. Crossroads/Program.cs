using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.ConstrainedExecution;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowPass = int.Parse(Console.ReadLine());
            Queue<string> carQue = new Queue<string>();
            int carPassedTheCrossroad = 0;
            bool accident = false;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                if (command != "green")
                {
                    carQue.Enqueue(command);
                }
                else if (command == "green")
                {
                    var secondsLeftOfGreenLight = greenLightSeconds;
                    var freePass = freeWindowPass;
                    while (secondsLeftOfGreenLight > 0)
                    {
                        if (carQue.Count == 0)
                        {
                           break;
                        }

                        var currCar = carQue.Dequeue();

                        if (currCar.Length <= secondsLeftOfGreenLight)
                        {
                            carPassedTheCrossroad++;
                            secondsLeftOfGreenLight -= currCar.Length;
                        }
                        else if (currCar.Length > secondsLeftOfGreenLight)
                        {
                            freeWindowPass += secondsLeftOfGreenLight;
                            secondsLeftOfGreenLight = 0;
                            if (freeWindowPass >= currCar.Length)
                            {
                                carPassedTheCrossroad++;
                            }
                            else if (freeWindowPass < currCar.Length)
                            {
                                string placeCarWasHit = currCar[freeWindowPass].ToString();
                                accident = true;
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currCar} was hit at {placeCarWasHit}.");
                                break;

                            }
                        }
                    }
                }

                if (accident == true)
                {
                    break;
                }
            }

            if (accident == false)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carPassedTheCrossroad} total cars passed the crossroads.");
            }

        }
    }
}
