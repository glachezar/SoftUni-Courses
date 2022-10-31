using System;
using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Products> products = new List<Products>();

            string[] peopleInput = Console.ReadLine().Split(';');

            foreach (var person in peopleInput)
            {
                string name = person.Split('=')[0];
                decimal money = decimal.Parse(person.Split('=')[1]);
                people.Add(new Person(name, money));
            }
            string[] productsInput = Console.ReadLine().Split(';');

            foreach (var product in productsInput)
            {
                string name = product.Split('=')[0];
                decimal price = decimal.Parse(product.Split('=')[1]);
                products.Add(new Products(name, price));
            }
            string command = Console.ReadLine();

            while (command != "END")
            {
                string personsName = command.Split()[0];
                string productName = command.Split()[1];


                people.Find(p => p.PersonName == personsName).BuyProduct(products.Find(p => p.Product == productName));

                command = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.purchasedProducts.Count > 0)
                {
                    Console.WriteLine($"{person.PersonName} - {string.Join(", ", person.purchasedProducts)}");
                }
                else
                {
                    Console.WriteLine($"{person.PersonName} - Nothing bought");
                }
            }
        }
    }

    class Person
    {
        public Person(string name, decimal money)
        {
            PersonName = name;
            PersonsMoney = money;
        }
        public string PersonName { get; set; }
        public decimal PersonsMoney { get; set; }

        public List<string> purchasedProducts = new List<string>();
        public void BuyProduct(Products productToBuy)
        {
            if (this.PersonsMoney >= productToBuy.PriceOfProduct)
            {
                this.purchasedProducts.Add(productToBuy.Product);
                this.PersonsMoney -= productToBuy.PriceOfProduct;
                Console.WriteLine($"{this.PersonName} bought {productToBuy.Product}");
            }
            else
            {
                Console.WriteLine($"{this.PersonName} can't afford {productToBuy.Product}");
            }
        }
    }

    class Products
    {
        public Products(string product, decimal price)
        {
            Product = product;
            PriceOfProduct = price;
        }
        public string Product { get; set; }
        public decimal PriceOfProduct { get; set; }
    }
}
