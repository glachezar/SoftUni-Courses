using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
{
    public class Box<T>
    {
        public Box()
        {
            InputValue = new List<T>();
        }

        public List<T> InputValue { get; set; }

        public void Swap(int index1, int index2)
        {
            T ValueAtIndex1 = InputValue[index1];

            InputValue[index1] = InputValue[index2];
            InputValue[index2] = ValueAtIndex1;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in InputValue)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
