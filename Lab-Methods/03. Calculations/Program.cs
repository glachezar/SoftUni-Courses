using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Console.WriteLine(Add(firstNum, secondNum));
                    break;
                case "multiply":
                    Console.WriteLine(Multiply(firstNum, secondNum));
                    break;
                case "subtract":
                    Console.WriteLine(Subtract(firstNum, secondNum));
                    break;
                case "divide":
                    Console.WriteLine(Subtract(firstNum, secondNum));
                    break;
            }
            
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber; 
        }
        static int Multiply(int firstNumber, int secondNumber)
        {
            
            return firstNumber * secondNumber;
        }
        static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        static int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
