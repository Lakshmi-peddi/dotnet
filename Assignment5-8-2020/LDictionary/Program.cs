using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary ld = new ListDictionary();
            ld.Add(1, 1.0);
            ld.Add(2, 2.0);
            ld.Add(3, 3.0);
            ld.Add(4, 4.0);
            ld.Add(5, 5.0);
            Console.WriteLine("the elements in the list dictionary....");
            foreach (DictionaryEntry i in ld)
            {
                Console.WriteLine("{0}={1}", i.Key, i.Value);
            }
            Console.WriteLine("the keys in list dictionary .......");
            var k = ld.Keys;
            foreach (DictionaryEntry i in ld)
            {
                Console.WriteLine(i.Key);
            }
            Console.WriteLine("the values in list dictionary .......");
            var l = ld.Values;
            foreach (DictionaryEntry i in ld)
            {
                Console.WriteLine(i.Value);
            }
            Console.WriteLine("the element is present in the list dictionary or not:{0}", ld.Contains(7));
            Console.WriteLine("the number of elements in the list dictionary:{0}", ld.Count);
            Console.Read();
        }
    }
}