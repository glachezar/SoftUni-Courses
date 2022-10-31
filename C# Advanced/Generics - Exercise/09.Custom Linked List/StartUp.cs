using System;
using System.Xml;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.AddLast(4);

            //Console.WriteLine(list.RemoveFirst());
            //Console.WriteLine(list.RemoveLast());

            int[] arr = list.ToArray();

            //list.ForEach(i => Console.WriteLine(i));

            //Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            DoublyLinkedList<string> listString = new DoublyLinkedList<string>();

            listString.AddFirst("Boo");
            listString.AddFirst("hahah");
            listString.AddFirst("NoName");
            listString.AddLast("Disconected");

            //listString.ForEach(i => Console.WriteLine(i));

            foreach (var item in listString)
            {
                Console.WriteLine(item);
            }
        }
    }
}
