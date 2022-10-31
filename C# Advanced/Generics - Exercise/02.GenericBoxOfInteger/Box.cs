using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxOfInteger
{
    public class Box<T>
    {
        public Box()
        {
            MyList = new List<T>();
        }

        public List<T> MyList { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in MyList)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
