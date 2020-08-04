using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinked
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> list = new LinkedList<String>();
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");
            list.AddLast("D");
            list.AddLast("E");
            list.AddLast("F");
            list.AddLast("G");
            Console.WriteLine("elements in the linkedlist");
            foreach (var st in list)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("using Enumerator");
            LinkedList<string>.Enumerator List = list.GetEnumerator();
            while (List.MoveNext())
            {
                Console.WriteLine(List.Current);
            }
            Console.WriteLine("remove paricualr element");
            list.Remove("one");
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("remove at first");
            list.RemoveFirst();
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Removes at last");
            list.RemoveLast();
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
        }
    }
}
