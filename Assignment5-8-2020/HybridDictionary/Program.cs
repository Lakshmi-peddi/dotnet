using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HyDictionaryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            HybridDictionary hyd = new HybridDictionary();
            hyd.Add(1, "one");
            hyd.Add(2, "two");
            hyd.Add(3, "three");
            hyd.Add(4, "four");
            hyd.Add(5, "five");
            Console.WriteLine("hash dictionary......");
            foreach (DictionaryEntry i in hyd)
            {
                Console.WriteLine("{0}={1}", i.Key, i.Value);
            }
            Console.WriteLine("finding whether given key is contained or not....");
            var k = hyd.Contains(7);
            Console.WriteLine(k);
            Console.WriteLine("the number of elements in the hash dictionary:{0}", hyd.Count);
            Console.WriteLine("the keys in the hash dictionary......");
            foreach (DictionaryEntry d in hyd)
            {
                Console.WriteLine(d.Key);
            }
            Console.WriteLine("the values in the hash dictionary......");
            foreach (DictionaryEntry d in hyd)
            {
                Console.WriteLine(d.Value);
            }
            Console.Read();
        }
    }
}
