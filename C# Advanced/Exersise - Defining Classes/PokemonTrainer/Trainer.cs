using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string trainerName)
        {
            this.Name = trainerName;
            this.NumberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }
        public Trainer(string trainerName, string pokemonName, string element, int health) : this(trainerName)
        {
            this.Pokemons.Add(new Pokemon(pokemonName, element, health));
        }

        private string name;
		private int numberOfBadges;
		private List<Pokemon> pokemons;

		public string Name { get { return name; } set { name = value; } }
		public int NumberOfBadges { get { return numberOfBadges; } set { numberOfBadges = value; } }
		public List<Pokemon> Pokemons { get { return pokemons; } set { pokemons = value; } }

        public override string ToString() => $"{this.Name} {this.NumberOfBadges} {this.Pokemons.Count}";
    }
}
