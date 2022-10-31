using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, int displacement)
            : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        private string model;
		private int power;
		private int displacement;
		private string efficiency;

		public string Efficiency { get { return efficiency; } set { efficiency = value; } }
        public int Displacement { get { return displacement; } set { displacement = value; } }
        public int Power { get { return power; } set { power = value; } }
        public string Model { get { return model; } set { model = value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string displacementText = this.Displacement == 0 ? "n/a" : this.Displacement.ToString();
            string efficiencyText = this.Efficiency == null ? "n/a" : this.Efficiency.ToString();

            sb.AppendLine($"  {this.Model}:");
            sb.AppendLine($"    Power: {this.Power}");
            sb.AppendLine($"    Displacement: {displacementText}");
            sb.AppendLine($"    Efficiency: {efficiencyText}");
            return sb.ToString();
        }
    }
}
