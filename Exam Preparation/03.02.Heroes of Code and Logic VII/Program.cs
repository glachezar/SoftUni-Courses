using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _03._02.Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            List<Heroes> heroes = new List<Heroes>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroesAndStats = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string hero = heroesAndStats[0];
                int hitPoints = int.Parse(heroesAndStats[1]);
                int manaPoints = int.Parse(heroesAndStats[2]);
                Heroes newHero = new Heroes(hero, hitPoints, manaPoints);
                heroes.Add(newHero);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End") break;

                string[] tokens = input.Split(" - ").ToArray();

                string command = tokens[0];
                var name = tokens[1];

                if (command == "CastSpell")
                {
                    // "CastSpell – {hero name} – {MP needed} – {spell name}"
                    int manaPointsNeeded = int.Parse(tokens[2]);
                    string spellName = tokens[3];
                    foreach (var hero in heroes)
                    {
                        if (hero.HeroName == name)
                        {
                            if (hero.ManaPoints >= manaPointsNeeded)
                            {
                                hero.ManaPoints -= manaPointsNeeded;
                                Console.WriteLine($"{hero.HeroName} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
                            }
                            else
                            {
                                Console.WriteLine($"{hero.HeroName} does not have enough MP to cast {spellName}!");
                            }
                        }
                    }
                }
                else if (command == "TakeDamage")
                {
                    //"TakeDamage – {hero name} – {damage} – {attacker}"
                    int damage = int.Parse(tokens[2]);
                    string attacker = tokens[3];
                    foreach (var hero in heroes)
                    {
                        if (hero.HeroName == name)
                        {
                            if (hero.HitPoints - damage > 0)
                            {
                                hero.HitPoints -= damage;
                                Console.WriteLine($"{hero.HeroName} was hit for {damage} HP by {attacker} and now has {hero.HitPoints} HP left!");
                            }
                            else if (hero.HitPoints - damage <= 0)
                            {
                                Console.WriteLine($"{hero.HeroName} has been killed by {attacker}!");
                                hero.HitPoints = 0;
                            }
                        }
                    }

                }
                else if (command == "Recharge")
                {
                    //"Recharge – {hero name} – {amount}" ***MAX MP = 200***
                    int amount = int.Parse(tokens[2]);
                    int amountOfManaRecovered = 0;
                    foreach (var hero in heroes)
                    {
                        if (hero.HeroName == name)
                        {
                            if (hero.ManaPoints + amount > 200)
                            {
                                amountOfManaRecovered = 200 - hero.ManaPoints;
                                hero.ManaPoints = 200;
                            }
                            else if (hero.ManaPoints + amount <= 200)
                            {
                                amountOfManaRecovered = amount;
                                hero.ManaPoints += amount;
                            }

                            Console.WriteLine($"{hero.HeroName} recharged for {amountOfManaRecovered} MP!");
                        }
                    }
                }
                else if (command == "Heal")
                {
                    //"Heal – {hero name} – {amount}" ***MAX HP = 100***
                    int amount = int.Parse(tokens[2]);
                    int amountOfHpRecovered = 0;
                    foreach (var hero in heroes)
                    {
                        if (hero.HeroName == name)
                        {
                            if (hero.HitPoints + amount > 100)
                            {
                                amountOfHpRecovered = 100 - hero.HitPoints;
                                hero.HitPoints = 100;
                            }
                            else if (hero.HitPoints + amount <= 100)
                            {
                                amountOfHpRecovered = amount;
                                hero.HitPoints += amount;
                            }

                            Console.WriteLine($"{hero.HeroName} healed for {amountOfHpRecovered} HP!");
                        }
                    }
                }

            }

            foreach (var hero in heroes.Where(h => h.HitPoints > 0))
            {
                Console.WriteLine(hero.HeroName);
                Console.WriteLine($"HP: {hero.HitPoints}");
                Console.WriteLine($"MP: {hero.ManaPoints}");
            }
        }
    }

    class Heroes
    {
        public Heroes(string hero, int health, int mana)
        {
            HeroName = hero;
            HitPoints = health;
            ManaPoints = mana;
        }

        public string HeroName { get; set; }

        public int HitPoints { get; set; }

        public int ManaPoints { get; set; }
    }
}
