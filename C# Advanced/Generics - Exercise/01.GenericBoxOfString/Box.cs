using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Box<T>
    {
        public Box()
        {
             InputValue = new List<T>();
        }
        public List<T> InputValue { get; set; }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();

            foreach (var item in InputValue)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
