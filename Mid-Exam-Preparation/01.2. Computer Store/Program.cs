using System;

namespace _01._2._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            string customerType = "";
            double tax = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "special" || command == "regular")
                {
                    tax = totalPrice * 0.2;
                    if (totalPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                    }
                    else
                    {
                        ResultOfPurchase(totalPrice, tax, command);
                    }
                    //ResultOfPurchase(totalPrice, tax, command);
                    return;
                }

                double price = double.Parse(command);

                if (price < 0) Console.WriteLine("Invalid price!");
                
                else if (price == 0) Console.WriteLine("Invalid order!");
                
                else
                {
                    totalPrice += price;
                }
            }
        }

        private static void ResultOfPurchase(double totalPrice, double tax, string command)
        {
            if (totalPrice > 0)
            {
                if (command == "regular")
                {
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                    Console.WriteLine($"Taxes: {tax:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {(totalPrice + tax):f2}$");
                }
                else if (command == "special")
                {
                    double discount = (totalPrice + tax) * 0.1;
                    double discountedBill = (totalPrice + tax) - discount;
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                    Console.WriteLine($"Taxes: {tax:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {discountedBill:f2}$");
                }
                
            }
        }
    }
}
            
