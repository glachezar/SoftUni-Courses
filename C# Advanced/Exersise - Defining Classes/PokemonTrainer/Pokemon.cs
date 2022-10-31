using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string pokemoName, string poElement, int poHealth)
        {
            this.Name = pokemoName;
            this.Element = poElement;
            this.Health = poHealth;
        }
		private string name;
		private string element;
		private int health;

		public string Name { get { return name; } set { name = value; } }

        public string Element { get { return element; } set { element = value; } }

		public int Health { get { return health; } set { health = value; } }
	}
}
